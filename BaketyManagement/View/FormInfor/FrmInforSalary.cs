using BaketyManagement.DAO;
using BaketyManagement.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaketyManagement.View.FormInfor
{
    public partial class FrmInforSalary : Form
    {
        public static Int32 idStaff;
        public static Int32 checkSender;
        public FrmInforSalary()
        {
            InitializeComponent();
        }

        #region Events
        private void FrmInforSalary_Load(object sender, EventArgs e)
        {
            LoadCboStaffName();
            if (checkSender==1)
            {
                btnTimeKeeping.BringToFront();
                txtSalaryDate.ReadOnly = true;
                txtSalaryOverTime.ReadOnly = true;
                txtRewards.ReadOnly = true;
                LoadInforToForm();
            }
            else if(checkSender==2)
            {
                btnUpdate.BringToFront();
                txtHoursOverTime.ReadOnly = true;
                LoadInforToForm();
            }
            else if (checkSender == 3)
            {
                btnAddSalary.BringToFront();
                txtHoursOverTime.ReadOnly = true;
                txtRewards.ReadOnly = true;
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnTimeKeeping_Click(object sender, EventArgs e)
        {
            TimeKeeping();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateSalary();
        }
        private void btnAddSalary_Click(object sender, EventArgs e)
        {
            AddSalaryByIdStaff();
        }
        private void cboStaffName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkSender==3)
            {
                txtIDStaff.Text = (cboStaffName.SelectedItem as Staff).IdStaff.ToString();
            }
        }
        #endregion

        #region Methods
        private void AddSalaryByIdStaff()
        {
            try
            {
                Int32 idStaffAdd = (cboStaffName.SelectedItem as Staff).IdStaff;
                if (SalaryDAO.Instance.CheckExistsSalaryByIdStaff(idStaffAdd))
                {
                    throw new Exception("Nhân viên có mã " + idStaffAdd + " đã có bảng lương!");
                }
                Single salaryDate = Convert.ToSingle(txtSalaryDate.Text);
                Single salaryOverTime = Convert.ToSingle(txtSalaryOverTime.Text);
                if (salaryDate <= 0)
                {
                    throw new Exception("Ngày công phải lớn hơn 0!");
                }
                if (salaryOverTime <= 0)
                {
                    throw new Exception("Lương giờ làm thêm phải lớn hơn 0!");
                }
                if (SalaryDAO.Instance.AddSalaryByIdStaff(idStaffAdd, salaryDate, salaryOverTime))
                {
                    MessageBox.Show("Thêm thành công!");
                    idStaff = idStaffAdd;
                    LoadInforToForm();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void UpdateSalary()
        {
            try
            {
                Single salaryDate = Convert.ToSingle(txtSalaryDate.Text);
                Single reward = Convert.ToSingle(txtRewards.Text);
                Single salaryOverTime = Convert.ToSingle(txtSalaryOverTime.Text);
                if (salaryDate<=0)
                {
                    throw new Exception("Ngày công phải lớn hơn 0!");
                }
                if (reward<0)
                {
                    throw new Exception("Thưởng phải lớn hơn hoặc bằng 0!");
                }
                if (salaryOverTime<=0)
                {
                    throw new Exception("Lương giờ làm thêm phải lớn hơn 0!");
                }
                if (SalaryDAO.Instance.UpdateSalaryByID(idStaff,salaryDate,reward,salaryOverTime))
                {
                    MessageBox.Show("Cập nhật thành công!");
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void TimeKeeping()
        {
            try
            {
                Single hoursOverTime = Convert.ToSingle(txtHoursOverTime.Text);
                if (hoursOverTime < 0)
                {
                    throw new Exception("Giờ làm thêm phải lớn hơn hoặc bằng 0!");
                }
                DateTime currentDate = DateTime.Now;
                DataTable table = SalaryDAO.Instance.GetSalaryByIdStaff(idStaff, currentDate);
                DataRow row = table.Rows[0];
                DateTime dateIsKeeped = Convert.ToDateTime(row["dateIsTimeKeeped"]);
                if (currentDate.Month == dateIsKeeped.Month && currentDate.Day == dateIsKeeped.Day
                    && currentDate.Year == dateIsKeeped.Year)
                {
                    throw new Exception("Nhân viên này đã được chấm công trong ngày hôm nay!");
                }
                if (SalaryDAO.Instance.TimeKeeping(hoursOverTime, idStaff))
                {
                    MessageBox.Show("Chấm công thành công!", "Thông báo!");
                }
                else
                {
                    MessageBox.Show("Chấm công thất bại!", "Thông báo!");
                }
                LoadInforToForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadInforToForm()
        {
            DateTime currentDate = DateTime.Now;
            DataTable table = SalaryDAO.Instance.GetSalaryByIdStaff(idStaff, currentDate);
            DataRow row = table.Rows[0];
            txtIDStaff.Text = row["idStaff"].ToString();
            cboStaffName.Text = row["nameStaff"].ToString();
            txtSalaryDate.Text = row["salaryDate"].ToString();
            txtWorkDays.Text = row["workDays"].ToString();
            txtHoursOverTime.Text = row["hoursOverTime"].ToString();
            txtRewards.Text = row["rewards"].ToString();
            txtSalaryOverTime.Text = row["salaryOverTime"].ToString();
        }

        private void LoadCboStaffName()
        {
            cboStaffName.DataSource = StaffDAO.Instance.GetFullStaff();
            cboStaffName.DisplayMember = "nameStaff";
            txtIDStaff.Text = (cboStaffName.SelectedItem as Staff).IdStaff.ToString();
        }

        #endregion

        
    }
}
