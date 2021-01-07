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

namespace BaketyManagement
{
    public partial class FrmAccountInfor : Form
    {
        public static String userName;
        public FrmAccountInfor()
        {
            InitializeComponent();
        }
        #region Events
        private void FrmAccountInfor_Load(object sender, EventArgs e)
        {
            LoadInfor();
        }
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            ChangePassword();
        }
        private void pnAccountInfor_Paint(object sender, PaintEventArgs e)
        {
            FrmMain.ShadowPanel(sender, e);

        }
        #endregion
        #region Methods
        private void LoadInfor()
        {
            Account account = AccountDAO.Instance.GetAccountByUserName(userName);
            txtUserName.Text = account.UserName;
            txtPassword.Text = account.Pass;
        }

        private void ChangePassword()
        {
            try
            {
                String newPass = txtNewPassword.Text;
                String reenter = txtReEnter.Text;
                if (newPass=="")
                {
                    throw new Exception("Vui lòng nhập mật khẩu mới!");
                }
                if (String.Compare(newPass,reenter,true)!=0)
                {
                    throw new Exception("Mật khẩu không khớp. Vui lòng nhập lại!");
                }
                if (AccountDAO.Instance.ChangePassword(userName,newPass))
                {
                    MessageBox.Show("Đổi mật khẩu thành công!","Thông báo");
                }
                else
                {
                    MessageBox.Show("Đổi mật khẩu thất bại!","Thông báo");
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
