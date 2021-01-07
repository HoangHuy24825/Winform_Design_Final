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
    public partial class FrmInputImportCoupon : Form
    {
        Int32 row;
        Int32 rowDgvCakePresent;
        public FrmInputImportCoupon()
        {
            InitializeComponent();
        }

        private void FrmInputImportCoupon_Load(object sender, EventArgs e)
        {
            LoadTabInputImportCoupon();
        }
        #region Events
        private void dgvCakePresent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowDgvCakePresent = e.RowIndex;
            row = -1;//Để phân biệt đang chọn bảng nào
            if(rowDgvCakePresent >= 0 && rowDgvCakePresent < dgvCakePresent.RowCount - 1)
                FrmInforTabImputCouponImport.idCake = Int32.Parse(dgvCakePresent.Rows[rowDgvCakePresent].Cells[0].Value.ToString());
        }
        private void dgvDetailImport_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
            if (row >= 0 && row < dgvDetailImport.Rows.Count - 1)
            {
                Int32 idCake = Int32.Parse(dgvDetailImport.Rows[row].Cells[6].Value.ToString());
                rowDgvCakePresent = 0;
                foreach (DataGridViewRow r in dgvCakePresent.Rows)
                {
                    if (Int32.Parse(r.Cells[0].Value.ToString()) == idCake)
                        break;
                    else
                        rowDgvCakePresent++;
                }
            }
        }
        private void btnAddImportCoupon_Click(object sender, EventArgs e)
        {
            AddCakeToImportDetail();
        }
        private void btnEditImportCoupon_Click(object sender, EventArgs e)
        {
            EditCouponDetail();
        }
        private void btnDeleteImportCoupon_Click(object sender, EventArgs e)
        {
            DeleteCouponDetail();
        }
        private void btnSearchCakeImport_Click(object sender, EventArgs e)
        {
            row = -1;
            SearchCakePresent();
        }
        private void btnDisplayCakePresent_Click(object sender, EventArgs e)
        {
            LoadCakePresent();
        }

        private void btnSearchDetailImport_Click(object sender, EventArgs e)
        {
            row = -1;
            SearchCouponDetail();
        }
        private void btnCancelCakeImport_Click(object sender, EventArgs e)
        {
            CancelCoupon();
        }
        private void tlpImportCoupon_Paint(object sender, PaintEventArgs e)
        {
            FrmMain.ShadowPanel(sender, e);
        }
        private void btnInputCoupon_Click(object sender, EventArgs e)
        {
            NewCoupon();
        }
        private void FrmInputImportCoupon_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormClosingMethod(sender, e);
        }


        #endregion

        #region Methods
        private void LoadTabInputImportCoupon()
        {
            LoadCakePresent();
            btnCancelCakeImport.Enabled = false;
        }

        private void LoadCakePresent()
        {
            dgvCakePresent.DataSource = CakeDAO.Instance.GetFullCakeDetail();
            dgvCakePresent.Columns[0].HeaderText = "Mã Bánh";
            dgvCakePresent.Columns[1].HeaderText = "Tên Bánh";
            dgvCakePresent.Columns[2].HeaderText = "Giá Bán";
            dgvCakePresent.Columns[3].HeaderText = "Giá Nhập";
            dgvCakePresent.Columns[3].Visible = false;
            dgvCakePresent.Columns[4].HeaderText = "Số Lượng";
            //dgvCakePresent.Columns[4].Visible = false;
            dgvCakePresent.Columns[5].HeaderText = "HSD";
            dgvCakePresent.Columns[5].Visible = false;
            dgvCakePresent.Columns[6].HeaderText = "NSX";
            dgvCakePresent.Columns[6].Visible = false;
            dgvCakePresent.Columns[7].HeaderText = "Kích Thước";
            dgvCakePresent.Columns[8].HeaderText = "Loại Bánh";
            dgvCakePresent.Columns[8].Visible = false;
            dgvCakePresent.Columns[9].HeaderText = "NCC";
            dgvCakePresent.Columns[10].HeaderText = "Ngày Nhập";
            dgvCakePresent.Columns[10].Visible = false;
            dgvCakePresent.Columns[11].HeaderText = "Mã Nhà Cung Cấp";
            dgvCakePresent.Columns[11].Visible = false;
        }

        private void LoadDetailCoupon()
        {
            try
            {
                dgvDetailImport.DataSource = ImportCouponDetailDAO.Instant.LoadNewDetailCoupon();
                dgvDetailImport.Columns[0].HeaderText = "Mã Chi Tiết Hóa Đơn";
                dgvDetailImport.Columns[0].Visible = false;
                dgvDetailImport.Columns[1].HeaderText = "Tên Bánh";
                dgvDetailImport.Columns[2].HeaderText = "Kích Thước";
                dgvDetailImport.Columns[3].HeaderText = "Số Lượng Nhập";
                dgvDetailImport.Columns[4].HeaderText = "Giá Nhập";
                dgvDetailImport.Columns[5].HeaderText = "Tổng Tiền";
                dgvDetailImport.Columns[6].HeaderText = "Mã Bánh";
                dgvDetailImport.Columns[7].HeaderText = "Mã Phiếu";
                dgvDetailImport.Columns[6].Visible = false;
                dgvDetailImport.Columns[7].Visible = true;
                CheckToDeleteCoupon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void AddCakeToImportDetail()
        {
            try
            {
                FrmInforTabImputCouponImport.isAdd = true;
                FrmInforTabImputCouponImport.rowDetailCoupon = row;
                FrmInforTabImputCouponImport frm = new FrmInforTabImputCouponImport();
                frm.StartPosition = FormStartPosition.CenterScreen;
                Int32 rowBeforeAdd = CakeDAO.Instance.AmountRows();
                Int32 rowAfterAdd = CakeDAO.Instance.AmountRows();
                if (rowBeforeAdd - rowAfterAdd == 0)
                    AddImportCoupon(true);
                else
                    AddImportCoupon(false);
                frm.ShowDialog();
                if (!FrmInforTabImputCouponImport.isCancel)
                {
                    LoadDetailCoupon();
                    LoadCakePresent();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddImportCoupon(Boolean checkAdd)
        {
            try
            {
                if (rowDgvCakePresent >= 0 && rowDgvCakePresent < dgvCakePresent.RowCount - 1)
                {
                    FrmInforTabImputCouponImport.couponDetailRows = dgvDetailImport.Rows.Count;
                    if (checkAdd)//This for update cake present
                        FrmInforTabImputCouponImport.idSupplierPresent = Int32.Parse(dgvCakePresent.Rows[rowDgvCakePresent].Cells[11].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void EditCouponDetail()
        {
            try
            {
                if (row < 0)
                    throw new Exception("Chọn sản phẩm ở chi tiết phiếu nhập");
                FrmInforTabImputCouponImport.idCouponDetail = Int32.Parse(dgvDetailImport.Rows[row].Cells[0].Value.ToString());
                FrmInforTabImputCouponImport.idCake = Int32.Parse(dgvCakePresent.Rows[rowDgvCakePresent].Cells[0].Value.ToString());
                FrmInforTabImputCouponImport.isAdd = false;
                FrmInforTabImputCouponImport.rowDetailCoupon = row;
                FrmInforTabImputCouponImport frm = new FrmInforTabImputCouponImport();
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.ShowDialog();
                LoadCakePresent();
                LoadDetailCoupon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void DeleteCouponDetail()
        {
            try
            {
                if (row < 0)
                    throw new Exception("Chọn sản phẩm ở chi tiết phiếu nhập");

                Int32 idCouponDetail = Int32.Parse(dgvDetailImport.Rows[row].Cells[0].Value.ToString());
                Int32 amountCake = 0;
                Int32 priceImport = Int32.Parse(dgvCakePresent.Rows[rowDgvCakePresent].Cells[2].Value.ToString());
                Int32 amountCakeEdited = -Int32.Parse(dgvDetailImport.Rows[row].Cells[3].Value.ToString());


                if (idCouponDetail < 0)
                    throw new Exception("Chọn hóa đơn cần sửa");
                if (amountCake < 0)
                    throw new Exception("Số lượng nhập phải lớn hơn 0");
                if (priceImport <= 0)
                    throw new Exception("Giá nhập phải lớn hơn 0");

                if (ImportCouponDetailDAO.Instant.EditDetailCoupon(idCouponDetail, amountCake, amountCakeEdited, priceImport))
                {
                    LoadCakePresent();
                    LoadDetailCoupon();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CheckToDeleteCoupon()
        {
            if (dgvDetailImport.Rows.Count <= 1)
            {
                Int32 idCoupon = ImportCouponDAO.Instant.GetIdCouponPresent();
                ImportCouponDAO.Instant.DeleteCouponPresent(idCoupon);
                btnCancelCakeImport.Enabled = false;
            }
            else
                btnCancelCakeImport.Enabled = true;

        }

        private void SearchCakePresent()
        {
            try
            {
                String keyWord = txtSearchCakeImport.Text;
                if (keyWord == "")
                    throw new Exception("Nhập tên bánh hoặc tên nhà cung cấp");
                dgvCakePresent.DataSource = CakeDAO.Instance.SearchCakePresentByName(keyWord);
                if (dgvCakePresent.Rows.Count <= 1)
                    dgvCakePresent.DataSource = CakeDAO.Instance.SearchCakePresentBySupplier(keyWord);
                if (dgvCakePresent.Rows.Count <= 1)
                {
                    LoadCakePresent();
                    throw new Exception("Không tìm thấy kết quả nào!!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SearchCouponDetail()
        {
            try
            {
                String keyWord = txtSearchDetailImport.Text;
                if (keyWord == "")
                    throw new Exception("Nhập tên bánh hoặc tên nhà cung cấp");
                dgvCakePresent.DataSource = ImportCouponDetailDAO.Instant.SearchCouponDetailByName(keyWord);
                if (dgvCakePresent.Rows.Count <= 1)
                {
                    LoadCakePresent();
                    throw new Exception("Không tìm thấy kết quả nào!!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CancelCoupon()
        {
            try
            {
                Int32 lengthDetail = dgvDetailImport.Rows.Count - 1;
                for (int i = 0; i < lengthDetail; i++)
                {
                    Int32 idCouponDetail = Int32.Parse(dgvDetailImport.Rows[i].Cells[0].Value.ToString());
                    Int32 amountCake = 0;
                    Int32 priceImport = 0;
                    Int32 amountCakeEdited = -Int32.Parse(dgvDetailImport.Rows[i].Cells[3].Value.ToString());

                    if (idCouponDetail < 0)
                        throw new Exception("Chọn hóa đơn cần sửa");
                    if (amountCake < 0)
                        throw new Exception("Số lượng nhập phải lớn hơn 0");

                    ImportCouponDetailDAO.Instant.EditDetailCoupon(idCouponDetail, amountCake, amountCakeEdited, priceImport);
                }
                LoadCakePresent();
                LoadDetailCoupon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void NewCoupon()
        {
            dgvDetailImport.DataSource = null;
        }
        private void FormClosingMethod(object sender, FormClosingEventArgs e)
        {
            if (dgvDetailImport.Rows.Count > 1)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn hủy Phiếu nhập này không??", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    CancelCoupon(); 
                    this.Close();
                }
                else
                {
                    e.Cancel = false;
                }
            }
        }
        #endregion


    }
}
