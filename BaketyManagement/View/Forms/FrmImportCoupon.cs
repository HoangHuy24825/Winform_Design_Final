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
    public partial class FrmImportCoupon : Form
    {
        Int32 row = 0;
        public FrmImportCoupon()
        {
            InitializeComponent();
        }

        #region Events
        private void dgvCouponImport_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
            if (row >= 0 && row < dgvCouponImport.Rows.Count - 1)
                LoadDetailCouponById();
        }
        private void btnDisplayCouponImport_Click(object sender, EventArgs e)
        {
            LoadTabImportCoupon();
        }
        private void btnSearchCouponImport_Click(object sender, EventArgs e)
        {
            SearchImportCoupon();
        }
        private void btnFilterCouponImport_Click(object sender, EventArgs e)
        {
            FilterCouponImport();
        }
        private void FrmImportCoupon_Load(object sender, EventArgs e)
        {
            LoadTabImportCoupon();
        }
        private void tlpCoupon_Paint(object sender, PaintEventArgs e)
        {
            FrmMain.ShadowPanel(sender, e);
        }
        #endregion

        #region Methods
        private void LoadTabImportCoupon()
        {
            dgvCouponImport.DataSource = ImportCouponDAO.Instant.GetListCouponImport();
            dgvCouponImport.Columns[0].HeaderText = "Mã Phiếu";
            dgvCouponImport.Columns[1].HeaderText = "Tên Nhà Cung Cấp";
            dgvCouponImport.Columns[2].HeaderText = "Ngày Nhập";
        }
        private void LoadDetailCouponById()
        {
            if (row < 0)
            {
                dgvDetailCouponImport.DataSource = null;
                return;
            }
            Int32 idCoupon = Int32.Parse(dgvCouponImport.Rows[row].Cells[0].Value.ToString());
            dgvDetailCouponImport.DataSource = ImportCouponDetailDAO.Instant.LoadDetailCouponById(idCoupon);
            dgvDetailCouponImport.Columns[0].HeaderText = "Mã Chi Tiết Phiếu";
            dgvDetailCouponImport.Columns[1].HeaderText = "Tên Bánh";
            dgvDetailCouponImport.Columns[2].HeaderText = "Kích Thước";
            dgvDetailCouponImport.Columns[3].HeaderText = "Số Lượng Nhập";
            dgvDetailCouponImport.Columns[4].HeaderText = "Đơn Giá";
            dgvDetailCouponImport.Columns[5].HeaderText = "Tổng Tiền";
        }
        private void SearchImportCoupon()
        {
            String keyWord = txtSearchImportCoupon.Text;
            dgvCouponImport.DataSource = ImportCouponDAO.Instant.SearchCouponByNameSupplier(keyWord);
            row = -1;
            LoadDetailCouponById();
        }
        private void FilterCouponImport()
        {
            try
            {
                dgvDetailCouponImport.DataSource = null;
                DateTime startDate = dtpStartImportDay.Value;
                DateTime endDate = dtpEndImportDay.Value;
                if (DateTime.Compare(startDate, endDate) > 0)
                {
                    throw new Exception("Vui lòng chọn ngày kết thúc trùng hoặc sau ngày bắt đầu!");
                }
                dgvCouponImport.DataSource = ImportCouponDAO.Instant.FilterCouponImportByDate(startDate, endDate);
                row = -1;
                LoadDetailCouponById();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion


    }
}
