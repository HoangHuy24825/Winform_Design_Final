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
    public partial class FrmSupplier : Form
    {
        Int32 rowDgvSupplier = 0;
        public FrmSupplier()
        {
            InitializeComponent();
        }

        private void FrmSupplier_Load(object sender, EventArgs e)
        {
            LoadTabSupplier();
        }
        #region Events
        private void dgvSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowDgvSupplier = e.RowIndex;
        }
        private void btnViewSupplier_Click(object sender, EventArgs e)
        {
            LoadTabSupplier();
        }
        private void btnDelSupplier_Click(object sender, EventArgs e)
        {
            DeleteSupplier();
        }
        private void btnEditSupplier_Click(object sender, EventArgs e)
        {
            UpdateSupplier();
        }
        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            AddSupplier();
        }
        private void btnSearchSupplier_Click(object sender, EventArgs e)
        {
            SearchSupplier();
        }
        private void tlpSupplier_Paint(object sender, PaintEventArgs e)
        {
            FrmMain.ShadowPanel(sender, e);
        }

        #endregion
        #region Methods
        private void LoadTabSupplier()
        {
            dgvSupplier.DataSource = SupplierDAO.Instance.GetFullListSupplier();
            dgvSupplier.Columns[0].HeaderText = "Mã nhà cung cấp";
            dgvSupplier.Columns[1].HeaderText = "Tên nhà cung cấp";
            dgvSupplier.Columns[2].HeaderText = "Số điện thoại";
            dgvSupplier.Columns[3].HeaderText = "Địa chỉ";
        }
        private void DeleteSupplier()
        {
            if (rowDgvSupplier>0)
            {
                Int32 idSupplier = Convert.ToInt32(dgvSupplier.Rows[rowDgvSupplier].Cells[0].Value.ToString());
                DialogResult result = MessageBox.Show("Bạn thực sự muốn xóa nhà cung cấp có mã " + idSupplier, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                    if (SupplierDAO.Instance.DeleteSupplier(idSupplier))
                    {
                        MessageBox.Show("Xóa thành công!", "Thông báo");
                        LoadTabSupplier();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại!", "Thông báo");
                    }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp cần xóa!");
            }
        }
        private void UpdateSupplier()
        {
            try
            {
                if (rowDgvSupplier < 0)
                    throw new Exception("Vui lòng chọn nhà cung cấp cần cập nhật!");
                FrmInforTabProvider.isAdd = false;
                FrmInforTabProvider.id = Int32.Parse(dgvSupplier.Rows[rowDgvSupplier].Cells[0].Value.ToString());
                FrmInforTabProvider frm = new FrmInforTabProvider();
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.ShowDialog();
                LoadTabSupplier();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void AddSupplier()
        {
            try
            {
                FrmInforTabProvider.isAdd = true;
                FrmInforTabProvider.id = Int32.Parse(dgvSupplier.Rows[rowDgvSupplier].Cells[0].Value.ToString());
                FrmInforTabProvider frm = new FrmInforTabProvider();
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.ShowDialog();
                LoadTabSupplier();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void SearchSupplier()
        {
            try
            {
                String keyWord = txtSearchKeySupplier.Text;
                if (keyWord == "")
                    throw new Exception("Nhập từ khóa tìm kiếm !!!");
                else
                    dgvSupplier.DataSource = SupplierDAO.Instance.SearchSupplier(keyWord);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion


    }

}
