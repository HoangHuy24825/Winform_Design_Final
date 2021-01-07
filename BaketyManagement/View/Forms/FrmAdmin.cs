using BaketyManagement.DAO;
using BaketyManagement.DTO;
using BaketyManagement.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BaketyManagement
{
    public partial class FrmAdmin : Form
    {
        Int32 row;
        Int32 rowDgvSupplier = 0;
        Int32 rowDgvCakePresent;
        public FrmAdmin()
        {
            InitializeComponent();
        }

        #region Events
        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            if (BillDetailDAO.Instance.GetRowCountByIDBill(BillDAO.Instance.GetMaxIDBill()) <= 0)
            {
                BillDAO.Instance.DeleteBillByIdBill(BillDAO.Instance.GetMaxIDBill());
            }
            LoadTabAccount();
            LoadTabStaff();
            LoadTabCake();
            LoadTabSupplier();
            LoadTabBill();
            LoadTabCategory();
            LoadTabStatistical();
            LoadTabInputImportCoupon();
            LoadTabImportCoupon();
        }




        #region TabAccount
        private void dgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
            if (row >= 0 && row < dgvAccount.Rows.Count)
            {
                txtUserName.Text = dgvAccount.Rows[row].Cells[0].Value.ToString();
                txtPassword.Text = dgvAccount.Rows[row].Cells[1].Value.ToString();
                if (dgvAccount.Rows[row].Cells[2].Value.Equals("Admin"))
                    ckbStaff.Checked = false;
                else
                    ckbStaff.Checked = true;
                cbbListStaff.Text = dgvAccount.Rows[row].Cells[3].Value.ToString();

            }
        }
        private void cbbListStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIdStaffAccount.Text = (cbbListStaff.SelectedItem as Staff).IdStaff.ToString();
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
            //AddAnAcount();
            
        }
        #endregion

        #region TabStaff
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;

            if (row >= 0 && row < dgvStaff.Rows.Count)
            {
                txtNameStaff.Text = dgvStaff.Rows[row].Cells[1].Value.ToString();
                if (dgvStaff.Rows[row].Cells[2].Value.Equals("Nam"))
                    rdbMan.Checked = true;
                if (dgvStaff.Rows[row].Cells[2].Value.Equals("Nữ"))
                    rdbWoman.Checked = true;
                txtPhoneStaff.Text = dgvStaff.Rows[row].Cells[3].Value.ToString();
                txtAddressStaff.Text = dgvStaff.Rows[row].Cells[4].Value.ToString();
                txtSalary.Text = dgvStaff.Rows[row].Cells[5].Value.ToString();
                txtWorkDay.Text = dgvStaff.Rows[row].Cells[6].Value.ToString();
            }
        }
        private void btnDisplayStaff_Click(object sender, EventArgs e)
        {
            LoadTabStaff();
        }
        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {
            DeletedStaff();
        }
        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            AddStaff();
        }
        private void btnStaffSearch_Click(object sender, EventArgs e)
        {
            SearchStaff();
            row = -1;
            ClearTextBox();
        }
        private void btnEditStaff_Click(object sender, EventArgs e)
        {
            EditStaff();
        }
        #endregion

        #region TabCake
        private void btnCakeDisplay_Click(object sender, EventArgs e)
        {
            LoadTabCake();
        }
        private void btnCakeDel_Click(object sender, EventArgs e)
        {
            DeleteCake();
        }
        private void dgvCake_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
        }
        private void btnCakeEdit_Click(object sender, EventArgs e)
        {
            EditCake();
        }
        private void btnCakeSearch_Click(object sender, EventArgs e)
        {
            row = -1;
            SearchCake();
            CLearTextBoxCake();
        }

        #endregion

        #region TabSupplier
        private void dgvSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowDgvSupplier = e.RowIndex;
            if (rowDgvSupplier >= 0 && rowDgvSupplier < dgvSupplier.Rows.Count)
            {
                txtIdSupplier.Text = dgvSupplier.Rows[rowDgvSupplier].Cells[0].Value.ToString();
                txtNameSupplier.Text = dgvSupplier.Rows[rowDgvSupplier].Cells[1].Value.ToString();
                txtPhoneSupplier.Text = dgvSupplier.Rows[rowDgvSupplier].Cells[2].Value.ToString();
                txtAddressSupplier.Text = dgvSupplier.Rows[rowDgvSupplier].Cells[3].Value.ToString();
            }
        }
        private void btnSearchSupplier_Click(object sender, EventArgs e)
        {
            row = -1;
            String searchSupplier = txtSearchKeySupplier.Text;
            if (searchSupplier != "")
            {
                dgvSupplier.DataSource = SupplierDAO.Instance.GetListSupplierByName(searchSupplier);
                ClearTextBoxSupplier();
                if (dgvSupplier.Rows.Count <= 0)
                {
                    MessageBox.Show("Không tồn tại nhà cung cấp nào có tên " + searchSupplier + "!", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên nhà cung cấp");
            }
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
        #endregion

        #region TabBill
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
            row = -1;
            SearchBillByStaffName();
        }
        private void btnFilterBill_Click(object sender, EventArgs e)
        {
            FilterBill();
        }
        #endregion

        #region TabStatistical
        private void btnStatisticalChart_Click(object sender, EventArgs e)
        {
            StatisticalChart();
        }
        private void btnStatisticalList_Click(object sender, EventArgs e)
        {
            StatisticalList();
        }
        #endregion

        #region TabCategory
        private void dgvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
            if (row >= 0 && row <= dgvCategory.Rows.Count - 1)
                txtNameCategory.Text = dgvCategory.Rows[row].Cells[1].Value.ToString();
        }
        private void btnDisplayCategory_Click(object sender, EventArgs e)
        {
            LoadTabCategory();
        }
        private void btnAddCategory_Click_1(object sender, EventArgs e)
        {
            AddCategory();
        }
        private void btnEditCategory_Click(object sender, EventArgs e)
        {
            EditCategory();
        }
        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            DeleteCategory();
        }
        private void btnCategorySearch_Click(object sender, EventArgs e)
        {
            row = -1;
            SearchCategory();
            ClearTextBoxCategory();
        }

        #endregion

        #region TabInputImportCoupon
        private void dgvCakePresent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowDgvCakePresent = e.RowIndex;
            if (rowDgvCakePresent >= 0 && rowDgvCakePresent < dgvCakePresent.Rows.Count - 1)
            {
                txtIdCakeImportTabImport.Text = dgvCakePresent.Rows[rowDgvCakePresent].Cells[0].Value.ToString();
                txtNameCakeImport.Text = dgvCakePresent.Rows[rowDgvCakePresent].Cells[1].Value.ToString();
                txtExportPrice.Text = dgvCakePresent.Rows[rowDgvCakePresent].Cells[2].Value.ToString();
                txtImportPrice.Text = dgvCakePresent.Rows[rowDgvCakePresent].Cells[3].Value.ToString();
                dtpExpImport.Value = Convert.ToDateTime(dgvCakePresent.Rows[rowDgvCakePresent].Cells[5].Value);
                dtpMfgImport.Value = Convert.ToDateTime(dgvCakePresent.Rows[rowDgvCakePresent].Cells[6].Value);
                txtSizeCakeImport.Text = dgvCakePresent.Rows[rowDgvCakePresent].Cells[7].Value.ToString();
                cbbCategoryCake.Text = dgvCakePresent.Rows[rowDgvCakePresent].Cells[8].Value.ToString();
                cbbNameSupplier.Text = dgvCakePresent.Rows[rowDgvCakePresent].Cells[9].Value.ToString();
                dtpDayImport.Value = Convert.ToDateTime(dgvCakePresent.Rows[rowDgvCakePresent].Cells[10].Value);
            }
            row = -1;//Để phân biệt đang chọn bảng nào
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
                txtIdCakeImportTabImport.Text = dgvCakePresent.Rows[rowDgvCakePresent].Cells[0].Value.ToString();
                txtNameCakeImport.Text = dgvCakePresent.Rows[rowDgvCakePresent].Cells[1].Value.ToString();
                txtExportPrice.Text = dgvCakePresent.Rows[rowDgvCakePresent].Cells[2].Value.ToString();
                txtImportPrice.Text = dgvCakePresent.Rows[rowDgvCakePresent].Cells[3].Value.ToString();
                txtAmountImport.Text = dgvDetailImport.Rows[row].Cells[3].Value.ToString();
                dtpExpImport.Value = Convert.ToDateTime(dgvCakePresent.Rows[rowDgvCakePresent].Cells[5].Value);
                dtpMfgImport.Value = Convert.ToDateTime(dgvCakePresent.Rows[rowDgvCakePresent].Cells[6].Value);
                txtSizeCakeImport.Text = dgvCakePresent.Rows[rowDgvCakePresent].Cells[7].Value.ToString();
                cbbCategoryCake.Text = dgvCakePresent.Rows[rowDgvCakePresent].Cells[8].Value.ToString();
                cbbNameSupplier.Text = dgvCakePresent.Rows[rowDgvCakePresent].Cells[9].Value.ToString();
                dtpDayImport.Value = Convert.ToDateTime(dgvCakePresent.Rows[rowDgvCakePresent].Cells[10].Value);
            }
        }
        private void btnAddImportCoupon_Click(object sender, EventArgs e)
        {
            AddCakeToImportDetail();
            LoadTabImportCoupon();
        }
        private void btnEditImportCoupon_Click(object sender, EventArgs e)
        {
            EditCouponDetail();
            LoadTabImportCoupon();
        }
        private void btnDeleteImportCoupon_Click(object sender, EventArgs e)
        {
            DeleteCouponDetail();
            LoadTabImportCoupon();
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
            LoadTabImportCoupon();
        }



        #endregion
        #region TabImportCoupon
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

        #endregion
        #endregion

        #region Methods
        #region TabAccount
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
                    ClearInputAccount();
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
                string userName = txtUserName.Text;
                if (userName == "")
                    throw new Exception("Không tìm thấy tài khoản này");
                if (AccountDAO.Instance.ResetPassword(userName))
                {
                    MessageBox.Show("Đặt lại mật khẩu thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadTabAccount();
                    ClearInputAccount();
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
                string userName = txtUserName.Text;
                if (userName == "")
                    throw new Exception("Vui lòng chọn tài khoản cần xóa!");
                DialogResult result = MessageBox.Show("Bạn thực sự muốn xóa tài khoản có mã " + dgvAccount.Rows[row].Cells[4].Value.ToString(), "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                    if (AccountDAO.Instance.DeleteAnAccount(userName))
                    {
                        MessageBox.Show("Xóa tài khoản thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadTabAccount();
                        ClearInputAccount();
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
                string userName = txtUserName.Text;
                Boolean staff = ckbStaff.Checked;
                int idStaff = (cbbListStaff.SelectedItem as Staff).IdStaff;

                if (userName == "")
                    throw new Exception("Nhập tên tài khoản cần thêm");
                if (idStaff < 0)
                    throw new Exception("Chọn nhân viên cho tài khoản cần thêm");
                if (AccountDAO.Instance.AddAnAccount(userName, staff, idStaff))
                {
                    MessageBox.Show("Thêm tài khoản thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadTabAccount();
                    ClearInputAccount();

                }
                else
                    throw new Exception("Nhân viên này đã có tài khoản");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ClearInputAccount()
        {
            txtUserName.Clear();
            txtPassword.Clear();
            ckbStaff.Checked = true;
            cbbListStaff.Text = "";
        }
        #endregion

        #region TabStaff
        private void LoadTabStaff()
        {
            dgvStaff.DataSource = StaffDAO.Instance.GetFullStaff();
            dgvStaff.Columns[0].HeaderText = "Mã Nhân Viên";
            dgvStaff.Columns[1].HeaderText = "Tên Nhân Viên";
            dgvStaff.Columns[2].HeaderText = "Giới Tính";
            dgvStaff.Columns[3].HeaderText = "Số Điện Thoại";
            dgvStaff.Columns[4].HeaderText = "Địa Chỉ";
            dgvStaff.Columns[5].HeaderText = "Hệ Số Lương";
            dgvStaff.Columns[6].HeaderText = "Số Ngày Làm Việc";

        }
        private void ClearTextBox()
        {
            txtNameStaff.Clear();
            rdbMan.Checked = true;
            txtPhoneStaff.Clear();
            txtAddressStaff.Clear();
            txtSalary.Clear();
            txtWorkDay.Clear();
        }
        private void DeletedStaff()
        {
            try
            {
                if (row < 0)
                    throw new Exception("Chọn nhân viên cần xóa");
                Int32 idStaff = Int32.Parse(dgvStaff.Rows[row].Cells[0].Value.ToString());
                DialogResult result = MessageBox.Show("Bạn thực sự muốn xóa nhân viên có mã " + dgvStaff.Rows[row].Cells[0].Value.ToString(), "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                    if (StaffDAO.Instance.DeleteStaff(idStaff))
                    {
                        MessageBox.Show("Xóa nhân viên thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadTabStaff();
                        ClearTextBox();
                    }
                    else
                        MessageBox.Show("Xóa nhân viên thất bại", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void AddStaff()
        {
            try
            {
                FrmInforTabStaff.isAdd = true;
                FrmInforTabStaff frm = new FrmInforTabStaff();
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.ShowDialog();
                LoadTabStaff();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void SearchStaff()
        {
            try
            {
                string nameStaff = txtStaffSearch.Text;
                if (nameStaff == "")
                    throw new Exception("Nhập tên nhân viên cần tìm");
                else
                    dgvStaff.DataSource = StaffDAO.Instance.SearchStaff(nameStaff);
                if (dgvStaff.Rows.Count <= 0)
                {
                    throw new Exception("Không tồn tại nhân viên có tên " + nameStaff + "!");
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
                if (row < 0)
                    throw new Exception("Chọn nhân viên cần sửa");
                FrmInforTabStaff.isAdd = false;
                FrmInforTabStaff.idStaff = Int32.Parse(dgvStaff.Rows[row].Cells[0].Value.ToString());
                FrmInforTabStaff frm = new FrmInforTabStaff();
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.ShowDialog();
                LoadTabStaff();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        #endregion

        #region TabCake
        private void LoadTabCake()
        {
            dgvCake.DataSource = CakeDAO.Instance.GetFullCakeWithCategory();
            dgvCake.Columns[0].HeaderText = "Mã Bánh";
            dgvCake.Columns[1].HeaderText = "Tên Bánh";
            dgvCake.Columns[2].HeaderText = "Loại Bánh";
            dgvCake.Columns[3].HeaderText = "Giá";
            dgvCake.Columns[4].HeaderText = "Số Lượng Còn";
            dgvCake.Columns[5].HeaderText = "Kích Thước";
            dgvCake.Columns[6].HeaderText = "Hạn Dùng";


        }
        private void DeleteCake()
        {
            try
            {
                if (row < 0)
                    throw new Exception("Chọn loại bánh cần xóa");
                Int32 idCake = Int32.Parse(dgvCake.Rows[row].Cells[0].Value.ToString());
                DialogResult result = MessageBox.Show("Bạn thực sự muốn xóa bánh có mã " + dgvCake.Rows[row].Cells[0].Value.ToString(), "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                    if (CakeDAO.Instance.DeleteCake(idCake))
                    {
                        MessageBox.Show("Xóa thành công");
                        LoadTabCake();
                        LoadTabCategory();
                        CLearTextBoxCake();

                    }
                    else
                        MessageBox.Show("Xóa không thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void EditCake()
        {
            try
            {
                if (row < 0)
                    throw new Exception("Chọn bánh cần xóa!");
                FrmInforTabProduct.id = Int32.Parse(dgvCake.Rows[row].Cells[0].Value.ToString());
                FrmInforTabProduct frm = new FrmInforTabProduct();
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.ShowDialog();
                LoadTabCake();
                LoadTabCategory();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SearchCake()
        {
            try
            {
                String keyWord = txtCakeSearch.Text;
                if (keyWord == "")
                    throw new Exception("Nhập từ khóa tìm kiếm");
                if (CakeDAO.Instance.SearchCakeByCakeName(keyWord).Rows.Count > 0)
                    dgvCake.DataSource = CakeDAO.Instance.SearchCakeByCakeNameWithCategory(keyWord);
                else
                    dgvCake.DataSource = CakeDAO.Instance.SearchCakeByCategoryNameWithCategory(keyWord);
                if (dgvCake.Rows.Count <= 1)
                {
                    throw new Exception("Không tồn tại sản phẩm nào có tên " + keyWord + "!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CLearTextBoxCake()
        {
            txtNameCake.Clear();
            cbbCategory.Text = "";
            txtPrice.Clear();
            txtSize.Clear();
        }

        #endregion

        #region TabSupplier
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
            if (txtIdSupplier.Text != "")
            {
                Int32 idSupplier = Convert.ToInt32(txtIdSupplier.Text);
                DialogResult result = MessageBox.Show("Bạn thực sự muốn xóa nhà cung cấp có mã " + idSupplier, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                    if (SupplierDAO.Instance.DeleteSupplier(idSupplier))
                    {
                        MessageBox.Show("Xóa thành công!", "Thông báo");
                        LoadTabSupplier();
                        ClearTextBoxSupplier();
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
                if (row < 0)
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
                FrmInforTabProvider.id = Int32.Parse(dgvSupplier.Rows[row].Cells[0].Value.ToString());
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
        private void ClearTextBoxSupplier()
        {
            txtIdSupplier.Clear();
            txtNameSupplier.Clear();
            txtPhoneSupplier.Clear();
            txtAddressSupplier.Clear();
        }
        #endregion

        #region TabBill
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

        #region TabStatistical
        private void LoadTabStatistical()
        {
            LoadStatisticalChart();
            LoadStatisticalList();
        }
        #region List
        private void StatisticalList()
        {
            if (radRevenue7DaysList.Checked)
            {
                DateTime now = DateTime.Now;
                DateTime sevenDaysAgo = DateTime.Today.AddDays(-7);
                dgvStatistical.DataSource = StatisticalDAO.Instance.Revenue7Days(sevenDaysAgo, now);
                dgvStatistical.Columns[0].HeaderText = "Ngày";
                dgvStatistical.Columns[1].HeaderText = "Tổng tiền";
                gbStatisticalList.Text = "Danh sách doanh thu 7 ngày gần đây";
            }
            else if (radRevenue3MonthsList.Checked)
            {
                DateTime now = DateTime.Now;
                DateTime month = new DateTime(now.Year, now.Month, 1);
                DateTime threeMonthAgo = month.AddMonths(-3);
                dgvStatistical.DataSource = StatisticalDAO.Instance.Revenue3Moths(threeMonthAgo, now);
                dgvStatistical.Columns[0].HeaderText = "Tháng";
                dgvStatistical.Columns[1].HeaderText = "Tổng tiền";
                gbStatisticalList.Text = "Danh sách doanh thu 3 tháng gần đây";
            }
            else if (radBestSellerList.Checked)
            {
                DateTime now = DateTime.Now;
                DateTime thirtyDaysAgo = DateTime.Today.AddDays(-30);
                dgvStatistical.DataSource = StatisticalDAO.Instance.TenBestSeller(thirtyDaysAgo, now);
                dgvStatistical.Columns[0].HeaderText = "Tên bánh";
                dgvStatistical.Columns[1].HeaderText = "Số lượng";
                gbStatisticalList.Text = "Danh sách 10 loại bánh bán chạy nhất trong 30 ngày gần đây";
            }
            else if (radSlowestSellerList.Checked)
            {
                DateTime now = DateTime.Now;
                DateTime thirtyDaysAgo = DateTime.Today.AddDays(-30);
                dgvStatistical.DataSource = StatisticalDAO.Instance.TenSlowestSeller(thirtyDaysAgo, now);
                dgvStatistical.Columns[0].HeaderText = "Tên bánh";
                dgvStatistical.Columns[1].HeaderText = "Số lượng";
                gbStatisticalList.Text = "Danh sách 10 loại bánh bán chậm nhất trong 30 ngày gần đây";
            }
        }
        private void LoadStatisticalList()
        {
            DateTime now = DateTime.Now;
            DateTime sevenDaysAgo = DateTime.Today.AddDays(-7);
            dgvStatistical.DataSource = StatisticalDAO.Instance.Revenue7Days(sevenDaysAgo, now);
            dgvStatistical.Columns[0].HeaderText = "Ngày";
            dgvStatistical.Columns[1].HeaderText = "Tổng tiền";
            gbStatisticalList.Text = "Danh sách doanh thu 7 ngày gần đây";
        }
        #endregion

        #region Chart
        private void LoadStatisticalChart()
        {
            DateTime now = DateTime.Now;
            DateTime sevenDaysAgo = DateTime.Today.AddDays(-7);
            DataTable source = StatisticalDAO.Instance.Revenue7Days(sevenDaysAgo, now);
            String chartName = "BIỂU ĐỒ THỐNG KÊ DOANH THU 7 NGÀY GẦN ĐÂY";
            DrawChart(source, "exportDate", "totalMoney", chartName, "columnChart", "Doanh thu (VND)");
        }

        private void DrawChart(DataTable source, String xValueMember, String yValueMeber, String chartName,
           String typeChart, String legend)
        {
            chartStatistical.DataSource = source;
            chartStatistical.Series["statistical"].XValueMember = xValueMember;
            chartStatistical.Series["statistical"].YValueMembers = yValueMeber;
            chartStatistical.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            chartStatistical.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dot;
            chartStatistical.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dot;
            if (String.Compare(typeChart, "circleChart", true) == 0)
            {
                chartStatistical.Series[0].ChartType = SeriesChartType.Pie;
                chartStatistical.Series[0].LegendText = legend;
            }
            else if (String.Compare(typeChart, "lineChart", true) == 0)
            {
                chartStatistical.Series[0].ChartType = SeriesChartType.Line;
                chartStatistical.Series[0].LegendText = legend;
                chartStatistical.ChartAreas[0].AxisX.MajorGrid.LineWidth = 1;
                chartStatistical.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;

            }
            else if (String.Compare(typeChart, "columnChart", true) == 0)
            {
                chartStatistical.Series[0].ChartType = SeriesChartType.Column;
                chartStatistical.Series[0].LegendText = legend;
            }
            chartStatistical.Titles[0].Text = chartName;
        }
        private void StatisticalChart()
        {
            if (radRevenue7DaysChart.Checked)
            {
                DateTime now = DateTime.Now;
                DateTime sevenDaysAgo = DateTime.Today.AddDays(-7);
                DataTable source = StatisticalDAO.Instance.Revenue7Days(sevenDaysAgo, now);
                String chartName = "BIỂU ĐỒ THỐNG KÊ DOANH THU 7 NGÀY GẦN ĐÂY";
                String xValueMember = "exportDate";
                String yValueMemer = "totalMoney";
                if (radColumnChart_Chart.Checked)
                {
                    DrawChart(source, xValueMember, yValueMemer, chartName, "columnChart", "Doanh thu (VND)");
                }
                else if (radCircleChart_Chart.Checked)
                {
                    DrawChart(source, xValueMember, yValueMemer, chartName, "circleChart", "");
                }
                else if (radLineChart_Chart.Checked)
                {
                    DrawChart(source, xValueMember, yValueMemer, chartName, "lineChart", "Doanh thu (VND)");
                }
            }
            else if (radBestSellerChart.Checked)
            {
                DateTime now = DateTime.Now;
                DateTime thirtyDaysAgo = DateTime.Today.AddDays(-30);
                DataTable source = StatisticalDAO.Instance.TenBestSeller(thirtyDaysAgo, now);
                String chartName = "BIỂU ĐỒ THỐNG KÊ DOANH THU 10 SẢN PHẨM BÁN CHẠY NHẤT TRONG 30 NGÀY GẦN ĐÂY";
                String xValueMember = "nameCake";
                String yValueMemer = "order1";
                if (radColumnChart_Chart.Checked)
                {
                    DrawChart(source, xValueMember, yValueMemer, chartName, "columnChart", "Số lượng (cái)");
                }
                else if (radCircleChart_Chart.Checked)
                {
                    DrawChart(source, xValueMember, yValueMemer, chartName, "circleChart", "");
                }
                else if (radLineChart_Chart.Checked)
                {
                    DrawChart(source, xValueMember, yValueMemer, chartName, "lineChart", "Số lượng (cái)");
                }
            }
            else if (radSlowestSellerChart.Checked)
            {
                DateTime now = DateTime.Now;
                DateTime thirtyDaysAgo = DateTime.Today.AddDays(-30);
                DataTable source = StatisticalDAO.Instance.TenSlowestSeller(thirtyDaysAgo, now);
                String chartName = "BIỂU ĐỒ THỐNG KÊ DOANH THU 10 SẢN PHẨM BÁN CHẬM NHẤT TRONG 30 NGÀY GẦN ĐÂY";
                String xValueMember = "nameCake";
                String yValueMemer = "order1";
                if (radColumnChart_Chart.Checked)
                {
                    DrawChart(source, xValueMember, yValueMemer, chartName, "columnChart", "Số lượng (cái)");
                }
                else if (radCircleChart_Chart.Checked)
                {
                    DrawChart(source, xValueMember, yValueMemer, chartName, "circleChart", "");
                }
                else if (radLineChart_Chart.Checked)
                {
                    DrawChart(source, xValueMember, yValueMemer, chartName, "lineChart", "Số lượng (cái)");
                }
            }
            else if (radRevenue3MonthsChart.Checked)
            {
                DateTime now = DateTime.Now;
                DateTime month = new DateTime(now.Year, now.Month, 1);
                DateTime threeMonthAgo = month.AddMonths(-3);
                DataTable source = StatisticalDAO.Instance.Revenue3Moths(threeMonthAgo, now);
                String chartName = "BIỂU ĐỒ THỐNG KÊ DOANH THU 3 THÁNG GẦN ĐÂY";
                String xValueMember = "exportDate";
                String yValueMemer = "totalMoney";
                if (radColumnChart_Chart.Checked)
                {
                    DrawChart(source, xValueMember, yValueMemer, chartName, "columnChart", "Doanh thu (VND)");
                }
                else if (radCircleChart_Chart.Checked)
                {
                    DrawChart(source, xValueMember, yValueMemer, chartName, "circleChart", "");
                }
                else if (radLineChart_Chart.Checked)
                {
                    DrawChart(source, xValueMember, yValueMemer, chartName, "lineChart", "Doanh thu (VND)");
                }
            }
        }
        #endregion
        #endregion

        #region TabCategory

        private void LoadTabCategory()
        {
            dgvCategory.DataSource = CategoryDAO.Instant.LoadCategory();
            dgvCategory.Columns[0].HeaderText = "Mã Loại Bánh";
            dgvCategory.Columns[1].HeaderText = "Tên Loại Bánh";
        }
        private void AddCategory()
        {
            try
            {
                FrmInforTabCategory.id = Int32.Parse(dgvCategory.Rows[row].Cells[0].Value.ToString());
                FrmInforTabCategory.isAdd = true;
                FrmInforTabCategory frm = new FrmInforTabCategory();
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.ShowDialog();
                LoadTabCategory();
                LoadTabCake();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EditCategory()
        {
            try
            {
                if (row < 0)
                    throw new Exception("Chọn loại bánh cần sửa");
                FrmInforTabCategory.id = Int32.Parse(dgvCategory.Rows[row].Cells[0].Value.ToString());
                FrmInforTabCategory.isAdd = false;
                FrmInforTabCategory frm = new FrmInforTabCategory();
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.ShowDialog();
                LoadTabCategory();
                LoadTabCake();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void DeleteCategory()
        {
            try
            {
                if (row < 0)
                    throw new Exception("Chọn loại bánh cần xóa");
                Int32 idCategory = Int32.Parse(dgvCategory.Rows[row].Cells[0].Value.ToString());
                DialogResult result = MessageBox.Show("Bạn thực sự muốn xóa loại bánh có mã" + dgvCategory.Rows[row].Cells[0].Value.ToString(), "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                    if (CategoryDAO.Instant.DeleteCategory(idCategory))
                    {
                        MessageBox.Show("Xóa thành công");
                        LoadTabCategory();
                        LoadTabCake();
                        ClearTextBoxCategory();
                    }
                    else
                        MessageBox.Show("Xóa không thành công");//del
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void SearchCategory()
        {
            try
            {
                String keyWord = txtCategorySearch.Text;
                if (keyWord == "")
                    throw new Exception("Nhập từ khóa tìm kiếm");
                else
                    dgvCategory.DataSource = CategoryDAO.Instant.SearchCategory(keyWord);
                if (dgvCategory.Rows.Count <= 1)
                {
                    MessageBox.Show("Không tồn tại sản phẩm nào có tên " + keyWord + "!", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ClearTextBoxCategory()
        {
            txtNameCategory.Clear();
        }
        #endregion

        #region TabInputImportCoupon
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
                FrmInforTabImputCouponImport.idCake = Int32.Parse(dgvCakePresent.Rows[rowDgvCakePresent].Cells[0].Value.ToString());
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
                LoadDetailCoupon();
                LoadCakePresent();
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
                FrmInforTabImputCouponImport.couponDetailRows = dgvDetailImport.Rows.Count;
                if (checkAdd)//This for update cake present
                    FrmInforTabImputCouponImport.idSupplierPresent = Int32.Parse(dgvCakePresent.Rows[rowDgvCakePresent].Cells[11].Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ClearImport()
        {
            txtNameCakeImport.Focus();
            txtNameCakeImport.Clear();
            txtSizeCakeImport.Clear();
            cbbCategoryCake.Text = "";
            cbbNameSupplier.Text = "";
            txtExportPrice.Clear();
            txtImportPrice.Clear();
            txtAmountImport.Clear();
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
                Int32 priceImport = Int32.Parse(txtImportPrice.Text);
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
                String keyWord = txtSearchCakeImport.Text;
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
                ClearImport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion
        #region Tab Coupon Import
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

        #endregion


    }
}
