using BaketyManagement.DAO;
using BaketyManagement.View.FormInfor;
using BaketyManagement.View.Forms.FormPrint;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaketyManagement.View.Forms
{
    public partial class FrmTimeKeeping : Form
    {
        Int32 row = -1;
        public FrmTimeKeeping()
        {
            InitializeComponent();
        }

        private void tlpTimeKeeping_Paint(object sender, PaintEventArgs e)
        {
            FrmMain.ShadowPanel(sender, e);
        }

        #region Events
        private void FrmTimeKeeping_Load(object sender, EventArgs e)
        {
            LoadSalary();
        }
        private void btnPrintSalary_Click(object sender, EventArgs e)
        {
            FrmPrintSalary frmPrintSalary = new FrmPrintSalary();
            frmPrintSalary.ShowDialog();
        }
        private void btnDisplaySalary_Click(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Now;
            dgvTimeKeeping.DataSource= SalaryDAO.Instance.GetListSalary(currentDate);
            row = -1;
        }
        private void btnTimeKeepingSearch_Click(object sender, EventArgs e)
        {
            SearchSalaryByStaffName();
            row = -1;
        }
        private void btnFilter_Click(object sender, EventArgs e)
        {
            FilterSalary();
            row = -1;
        }
        private void btnTimeKeeping_Click(object sender, EventArgs e)
        {
            TimeKeeping();
            row = -1;
        }
        private void dgvTimeKeeping_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
        }
        private void btnCancelTimeKeeping_Click(object sender, EventArgs e)
        {
            CancelTimeKeeping();
            row = -1;
        }
        private void btnEditSalary_Click(object sender, EventArgs e)
        {
            EditSalary();
            row = -1;
        }
        private void btnAddSalary_Click(object sender, EventArgs e)
        {
            AddNewSalary();
            row = -1;
        }
        #endregion

        #region Methods
        private void AddNewSalary()
        {
            try
            {
                row = 0;
                Int32 idStaff = Convert.ToInt32(dgvTimeKeeping.Rows[row].Cells[0].Value);
                FrmInforSalary frmInforSalary = new FrmInforSalary();
                FrmInforSalary.idStaff = idStaff;
                FrmInforSalary.checkSender = 3;
                frmInforSalary.ShowDialog();
                LoadSalary();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void EditSalary()
        {
            try
            {
                if (row < 0 || row >= dgvTimeKeeping.Rows.Count - 1)
                {
                    throw new Exception("Vui lòng chọn nhân viên cần cập nhật!");
                }
                Int32 idStaff = Convert.ToInt32(dgvTimeKeeping.Rows[row].Cells[0].Value);
                FrmInforSalary frmInforSalary = new FrmInforSalary();
                FrmInforSalary.idStaff = idStaff;
                FrmInforSalary.checkSender = 2;
                frmInforSalary.ShowDialog();
                LoadSalary();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CancelTimeKeeping()
        {
            try
            {
                if (row < 0 || row >= dgvTimeKeeping.Rows.Count - 1)
                {
                    throw new Exception("Vui lòng chọn nhân viên cần hủy chấm công!");
                }
                Int32 idStaff = Convert.ToInt32(dgvTimeKeeping.Rows[row].Cells[0].Value);
                DialogResult result = MessageBox.Show("Bạn có thực sự muốn hủy chấm công nhân viên có mã " + idStaff.ToString(),
                    "Xác nhận hủy chấm công", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    DateTime currentDate = DateTime.Now;
                    DataTable table = SalaryDAO.Instance.GetSalaryByIdStaff(idStaff,currentDate);
                    if (table.Rows.Count>0)
                    {
                        DataRow row = table.Rows[0];
                        DateTime dateIsKeeped = Convert.ToDateTime(row["dateIsTimeKeeped"]);
                        if ( currentDate.Month != dateIsKeeped.Month || currentDate.Day != dateIsKeeped.Day||
                        currentDate.Year != dateIsKeeped.Year)
                        {
                            throw new Exception("Nhân viên có mã " + idStaff + " chưa được chấm công trong ngày hôm nay!");
                        }
                        if (SalaryDAO.Instance.CancelTimeKeeping(idStaff))
                        {
                            MessageBox.Show("Hủy chấm công thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Hủy chấm công thất bại!");
                        }
                    }
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
                if (row<0||row>=dgvTimeKeeping.Rows.Count-1)
                {
                    throw new Exception("Vui lòng chọn nhân viên cần chấm công!");
                }
                Int32 idStaff =Convert.ToInt32(dgvTimeKeeping.Rows[row].Cells[0].Value);
                FrmInforSalary frmInforSalary = new FrmInforSalary();
                FrmInforSalary.idStaff = idStaff;
                FrmInforSalary.checkSender = 1;
                frmInforSalary.ShowDialog();
                LoadSalary();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FilterSalary()
        {
            try
            {
                DateTime dateFilter = dtpFilter.Value;
                DateTime currentDate = DateTime.Now;
                if (dateFilter.Year > currentDate.Year)
                {
                    throw new Exception("Vui lòng chọn ngày tháng hợp lệ!");
                }
                if (dateFilter.Month > currentDate.Month && dateFilter.Year==currentDate.Year)
                {
                    throw new Exception("Vui lòng chọn ngày tháng hợp lệ!");
                }
                dgvTimeKeeping.DataSource = SalaryDAO.Instance.GetListSalary(dateFilter);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadSalary()
        {
            DateTime currentDate = DateTime.Now;
            DataTable table = SalaryDAO.Instance.GetListSalary(currentDate);
            if (table.Rows.Count>0)
            {
                dgvTimeKeeping.DataSource = SalaryDAO.Instance.GetListSalary(currentDate);
                dgvTimeKeeping.Columns[0].HeaderText = "Mã nhân viên";
                dgvTimeKeeping.Columns[1].HeaderText = "Tên nhân viên";
                dgvTimeKeeping.Columns[2].HeaderText = "Ngày lương (VNĐ)";
                dgvTimeKeeping.Columns[3].HeaderText = "Ngày công";
                dgvTimeKeeping.Columns[4].HeaderText = "Giờ tăng ca";
                dgvTimeKeeping.Columns[5].HeaderText = "Thưởng";
                dgvTimeKeeping.Columns[6].HeaderText = "Lương tăng ca (VNĐ/giờ)";
                dgvTimeKeeping.Columns[7].HeaderText = "Lương tháng (tháng/năm)";
            }
            else
            {
                if (SalaryDAO.Instance.InsertSalaryInNewMonth())
                {
                    table = SalaryDAO.Instance.GetListSalary(currentDate);
                    dgvTimeKeeping.DataSource = table;
                    dgvTimeKeeping.Columns[0].HeaderText = "Mã nhân viên";
                    dgvTimeKeeping.Columns[1].HeaderText = "Tên nhân viên";
                    dgvTimeKeeping.Columns[2].HeaderText = "Ngày lương (VNĐ)";
                    dgvTimeKeeping.Columns[3].HeaderText = "Ngày công";
                    dgvTimeKeeping.Columns[4].HeaderText = "Giờ tăng ca";
                    dgvTimeKeeping.Columns[5].HeaderText = "Thưởng";
                    dgvTimeKeeping.Columns[6].HeaderText = "Lương tăng ca (VNĐ/giờ)";
                    dgvTimeKeeping.Columns[7].HeaderText = "Lương tháng (tháng/năm)";
                }
            }
        }
        private void SearchSalaryByStaffName()
        {
            try
            {
                String searchKey = txtTimeKeepingSearch.Text;
                if (searchKey=="")
                {
                    throw new Exception("Vui lòng nhập từ khóa cần tìm!");
                }
                dgvTimeKeeping.DataSource = SalaryDAO.Instance.GetListSalaryByStaffName(searchKey);
                if (dgvTimeKeeping.Rows.Count<=1)
                {
                    throw new Exception("Không có bản ghi lương nào của nhân viên " + searchKey + "!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }



        #endregion

       
    }
}
