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
    public partial class FrmInforTabAccount : Form
    {
        public static Int32 row;
        public FrmInforTabAccount()
        {
            InitializeComponent();
            this.Text = "";
            cbbListStaff.DataSource = StaffDAO.Instance.GetFullStaff();
            cbbListStaff.DisplayMember = "nameStaff";
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
        }
        #region Events
        private void cbbListStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIdStaffAccount.Text = (cbbListStaff.SelectedItem as Staff).IdStaff.ToString();
        }
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            AddAnAcount();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        #region Methods
        private void AddAnAcount()
        {
            try
            {
                string userName = txtUserName.Text;
                Boolean staff = ckbStaff.Checked;
                int idStaff = (cbbListStaff.SelectedItem as Staff).IdStaff;

                if (userName == "")
                    throw new Exception("Nhập tên tài khoản cần thêm");
                if (idStaff < 0)
                    throw new Exception("Chọn nhân viên cho tài khoản cần thêm");
                if (AccountDAO.Instance.AddAnAccount(userName, staff, idStaff))
                {
                    DialogResult result = MessageBox.Show("Thêm tài khoản thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                        this.Close();
                }
                else
                    throw new Exception("Nhân viên này đã có tài khoản");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion


    }
}
