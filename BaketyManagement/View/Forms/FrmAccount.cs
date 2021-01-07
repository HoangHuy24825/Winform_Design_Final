using BaketyManagement.DAO;
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
    public partial class FrmAccount : Form
    {
        private Int32 row;
        public FrmAccount()
        {
            InitializeComponent();
        }
        #region Events
        private void FrmAccount_Load(object sender, EventArgs e)
        {
            LoadTabAccount();

        }
        private void dgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            row = -1;
            SearchAccount();
        }
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            LoadTabAccount();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetPasword();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteAnAccount();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddAnAcount();
        }
        private void tlpAccount_Paint(object sender, PaintEventArgs e)
        {
            FrmMain.ShadowPanel(sender, e);
        }
        #endregion
        #region Methods
        private void LoadTabAccount()
        {
            dgvAccount.DataSource = AccountDAO.Instance.FullListAccount();
            dgvAccount.Columns[0].HeaderText = "Tài khoản";
            dgvAccount.Columns[1].HeaderText = "Mật khẩu";
            dgvAccount.Columns[1].Visible = false;//hide the password
            dgvAccount.Columns[2].HeaderText = "Loại tài khoản";
            dgvAccount.Columns[3].HeaderText = "Tên nhân viên";
            dgvAccount.Columns[4].HeaderText = "Mã tài khoản";
            dgvAccount.Columns[4].Visible = false;//hide the id staff
        }
        private void SearchAccount()
        {
            try
            {
                string nameSatff = txtAccountSearch.Text;
                if (nameSatff == "")
                    throw new Exception("Nhập từ khóa tìm kiếm");
                else
                {
                    dgvAccount.DataSource = AccountDAO.Instance.SearchAccount(nameSatff);
                    if (dgvAccount.Rows.Count <= 0)
                    {
                        throw new Exception("Không tồn tại tài khoản của nhân viên " + nameSatff + "!");
                    }
                }
                txtAccountSearch.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void ResetPasword()
        {
            try
            {
                if (row < 0)
                    throw new Exception("Chọn tài khoản cần reset mật khẩu");
                if (AccountDAO.Instance.ResetPassword(dgvAccount.Rows[row].Cells[0].Value.ToString()))
                {
                    MessageBox.Show("Đặt lại mật khẩu thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadTabAccount();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void DeleteAnAccount()
        {
            try
            {
                string userName = dgvAccount.Rows[row].Cells[0].Value.ToString();
                if(row<0)
                    throw new Exception("Vui lòng chọn tài khoản cần xóa!");
                DialogResult result = MessageBox.Show("Bạn thực sự muốn xóa tài khoản có mã " + dgvAccount.Rows[row].Cells[4].Value.ToString(), "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                    if (AccountDAO.Instance.DeleteAnAccount(userName))
                    {
                        MessageBox.Show("Xóa tài khoản thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadTabAccount();
                    }
                    else
                        MessageBox.Show("Xóa tài khoản không thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void AddAnAcount()
        {
            try
            {
                FrmInforTabAccount frmAccount = new FrmInforTabAccount();
                FrmInforTabAccount.row = row;
                frmAccount.StartPosition = FormStartPosition.CenterScreen;
                frmAccount.ShowDialog();
                LoadTabAccount();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        #endregion

    }
}
