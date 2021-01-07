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

namespace BaketyManagement.View
{
    public partial class FrmInforTabStaff : Form
    {
        public static Boolean isAdd;
        public static Int32 idStaff;
        public FrmInforTabStaff()
        {
            InitializeComponent();
            this.Text = "";
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            this.TopLevelControl.BackColor = this.BackColor;
            if (isAdd)
                btnEditStaff.Visible = false;
            else
            {
                btnAddStaff.Visible = false;
                LoadTextBox();
            }
        }
        #region Events
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAddStaff_Click_1(object sender, EventArgs e)
        {
            AddStaff();
        }
        private void btnEditStaff_Click(object sender, EventArgs e)
        {
            EditStaff();
        }
        #endregion
        #region TabStaff
        private void ClearTextBox()
        {
            txtNameStaff.Clear();
            rdbMan.Checked = true;
            txtPhoneStaff.Clear();
            txtAddressStaff.Clear();
        }
        private void AddStaff()
        {
            try
            {
                string nameStaff = txtNameStaff.Text;
                Boolean gender = false;
                if (rdbMan.Checked)
                    gender = false;
                if (rdbWoman.Checked)
                    gender = true;

                string phoneStaff = txtPhoneStaff.Text;
                string addressStaff = txtAddressStaff.Text;

                if (nameStaff == "")
                    throw new Exception("Cần nhập tên nhân viên");
                if (phoneStaff == "")
                    throw new Exception("Cần nhập số điện thoại");
                if (addressStaff == "")
                    throw new Exception("Cần nhập địa chỉ ");

                if (StaffDAO.Instance.AddStaff(nameStaff, gender, phoneStaff, addressStaff))
                {
                    MessageBox.Show("Thêm nhân viên thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    ClearTextBox();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void EditStaff()
        {
            try
            {
                String nameStaff = txtNameStaff.Text;
                String phoneStaff = txtPhoneStaff.Text;
                String addressStaff = txtAddressStaff.Text;
                if (nameStaff == "" || phoneStaff == "" || addressStaff == "")
                {
                    throw new Exception("Vui lòng nhập đầy đủ thông tin nhân viên!");
                }
                Boolean gender = false;
                if (rdbMan.Checked)
                    gender = false;
                if (rdbWoman.Checked)
                    gender = true;
                if (StaffDAO.Instance.EditStaff(nameStaff, gender, phoneStaff, addressStaff, idStaff))
                {
                    MessageBox.Show("Sửa nhân viên thành công");
                    this.Close();
                    ClearTextBox();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void LoadTextBox()
        {
            Staff staff = StaffDAO.Instance.GetStaffById(idStaff);
            txtNameStaff.Text = staff.NameStaff;
            if (staff.Gender.Equals("Nam"))
                rdbMan.Checked = true;
            if (staff.Gender.Equals("Nữ"))
                rdbWoman.Checked = true;
            txtPhoneStaff.Text = staff.PhoneStaff.ToString();
            txtAddressStaff.Text = staff.AddressStaff.ToString();
        }
        #endregion

        
    }
}
