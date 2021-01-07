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
    public partial class FrmBill : Form
    {
        public FrmBill()
        {
            InitializeComponent();
        }

        private void FrmBill_Load(object sender, EventArgs e)
        {
            LoadTabBill();
        }

        #region Events
        Int32 rowDgvBill = 0;
        private void dgvBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowDgvBill = e.RowIndex;
            if (rowDgvBill >= 0 && rowDgvBill < dgvBill.Rows.Count - 1)
            {
                Int32 idBill = Convert.ToInt32(dgvBill.Rows[rowDgvBill].Cells[0].Value);
                dgvBillDetail.DataSource = BillDetailDAO.Instance.GetBillDetailByIdBill(idBill);
                dgvBillDetail.Columns[0].HeaderText = "Tên bánh";
                dgvBillDetail.Columns[1].HeaderText = "Giá";
                dgvBillDetail.Columns[2].HeaderText = "Số lượng mua";
            }
            else
            {
                dgvBillDetail.DataSource = null;
            }
        }
        private void btnViewBill_Click(object sender, EventArgs e)
        {
            LoadTabBill();
            txtSearchKeyBill.Clear();
        }
        private void btnSearchBill_Click(object sender, EventArgs e)
        {
            rowDgvBill = -1;
            SearchBillByStaffName();
        }
        private void btnFilterBill_Click(object sender, EventArgs e)
        {
            FilterBill();
        }
        private void tlbBill_Paint(object sender, PaintEventArgs e)
        {
            FrmMain.ShadowPanel(sender, e);
        }
        #endregion

        #region Methods
        private void LoadTabBill()
        {
            dgvBill.DataSource = BillDAO.Instance.GetFullListBill();
            dgvBill.Columns[0].HeaderText = "Mã hóa đơn";
            dgvBill.Columns[1].HeaderText = "Ngày bán";
            dgvBill.Columns[2].HeaderText = "Tên nhân viên";
            dgvBill.Columns[3].HeaderText = "Giảm giá (%)";
            dgvBill.Columns[4].HeaderText = "Tổng tiền";
        }
        private void SearchBillByStaffName()
        {
            try
            {
                dgvBillDetail.DataSource = null;
                String searchKey = txtSearchKeyBill.Text;
                if (searchKey == "")
                {
                    throw new Exception("Vui lòng nhập từ khóa tìm kiếm!");
                }
                dgvBill.DataSource = BillDAO.Instance.SearchBillByNameStaff(searchKey);
                txtSearchKeyBill.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FilterBill()
        {
            try
            {
                dgvBillDetail.DataSource = null;
                DateTime startDate = dtpStartDay.Value;
                DateTime endDate = dtpEndDate.Value;
                if (DateTime.Compare(startDate, endDate) > 0)
                {
                    throw new Exception("Vui lòng chọn ngày kết thúc trùng hoặc sau ngày bắt đầu!");
                }
                dgvBill.DataSource = BillDAO.Instance.FilterBillByDate(startDate, endDate);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion



    }
}
