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
    public partial class FrmInforTabImputCouponImport : Form
    {
        public static Int32 idCake = 0;
        public static Int32 idSupplierPresent;
        public static Int32 couponDetailRows;
        public static Int32 idCouponDetail;
        public static Int32 rowDetailCoupon;
        public static Boolean isAdd;
        public static Boolean isCancel = false;
        private Int32 amount;


        public int Amount { get => amount; set => amount = value; }

        public FrmInforTabImputCouponImport()
        {
            InitializeComponent();
            isCancel = false;
            cbbCategoryCake.DataSource = CategoryDAO.Instant.GetFullListCategory();
            cbbCategoryCake.DisplayMember = "nameCategory";
            cbbNameSupplier.DataSource = SupplierDAO.Instance.GetFullListSupplier();
            cbbNameSupplier.DisplayMember = "name";
            if (isAdd)
            {
                btnEditImportCoupon.Visible = false;
                if (rowDetailCoupon > 0)//check user chose from dgvacake or dgvDetail
                    LoadTextBoxForEdit();//dgvDetail
                else
                    LoadTextBoxForAdd();//dgvCake
            }
            else
            {
                btnAddImportCoupon.Visible = false;
                LoadTextBoxForEdit();
                amount = Int32.Parse(txtAmountImport.Text);
            }

        }
        #region Events
        private void btnAddImportCoupon_Click(object sender, EventArgs e)
        {
            AddCakeToImportDetail();
        }
        private void btnEditImportCoupon_Click(object sender, EventArgs e)
        {
            EditCouponDetail();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            isCancel = true;
            this.Close();
        }
        #endregion
        #region Methods
        private void AddCakeToImportDetail()
        {
            try
            {
                String nameSupplier = cbbNameSupplier.Text;
                if (SupplierDAO.Instance.CheckExistsSupplier(nameSupplier) != 1)
                    throw new Exception("Cần thêm nhà cung cấp này trước");
                String nameCake = txtNameCakeImport.Text;
                String size = txtSizeCakeImport.Text;
                String nameCategory = cbbCategoryCake.Text;

                if (CategoryDAO.Instant.CheckExistsCategory(nameCategory) != 1)
                    throw new Exception("Cần thêm loại bánh này trước");
                if (nameCake == "")
                    throw new Exception("Nhập tên bánh");
                if (size == "")
                    throw new Exception("Nhập kích thước");
                if (nameCategory == "")
                    throw new Exception("Nhập tên loại bánh");

                Int32 exportPrice = Int32.Parse(txtExportPrice.Text);
                Int32 importPrice = Int32.Parse(txtImportPrice.Text);
                Int32 amount = Int32.Parse(txtAmountImport.Text);

                DateTime expDay = Convert.ToDateTime(dtpExpImport.Value);
                DateTime mfgDay = Convert.ToDateTime(dtpMfgImport.Value);

                if (exportPrice < 0)
                    throw new Exception("Giá phải lớn hơn 0");
                if (importPrice < 0)
                    throw new Exception("Giá phải lớn hơn 0");
                if (amount < 0)
                    throw new Exception("Số lượng phải lớn hơn 0");
                Int32 rowBeforeAdd = CakeDAO.Instance.AmountRows();
                if (CakeDAO.Instance.AddCakeFromImportCoupon(nameCake, exportPrice, importPrice, amount, expDay, mfgDay, size, nameCategory))
                {
                    Int32 rowAfterAdd = CakeDAO.Instance.AmountRows();
                    if (rowBeforeAdd - rowAfterAdd == 0)
                        AddImportCoupon(true);//số lượng bánh trc và sau khi nhập không bị đổi -> không có bánh mới 
                    else
                        AddImportCoupon(false);//có bánh mới-> chưa có NCC trước đó
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
                String nameSupplier = cbbNameSupplier.Text;
                if (nameSupplier == "")
                    throw new Exception("Chọn nhà cung cấp");
                DateTime dayImport = Convert.ToDateTime(dtpDayImport.Value);
                Int32 idCoupon = -1;
                if (couponDetailRows <= 1)
                    ImportCouponDAO.Instant.AddImportCoupon((cbbNameSupplier.SelectedItem as Supplier).Id, dayImport);

                if (checkAdd)//This for update cake present
                {
                    Int32 idSupplier = (cbbNameSupplier.SelectedItem as Supplier).Id;
                    Int32 idSupplierCoupon = ImportCouponDAO.Instant.GetIdSupplierPresent();

                    if (idSupplierCoupon != idSupplier || idSupplierPresent != idSupplier)
                        throw new Exception("Sản phẩm thêm có nhà cung cấp khác với trong phiếu");
                }
                else
                    txtIdCakeImportTabImport.Text = CakeDAO.Instance.idCakeMax().ToString();
                idCoupon = ImportCouponDAO.Instant.GetIdCouponPresent();
                AddCouponDetail(idCoupon);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void AddCouponDetail(Int32 idCoupon)
        {
            try
            {
                Int32 idCake = Int32.Parse(txtIdCakeImportTabImport.Text);
                Int32 amountCake = Int32.Parse(txtAmountImport.Text);
                Single priceImprot = Single.Parse(txtImportPrice.Text);

                if (ImportCouponDetailDAO.Instant.AddCouponDetail(idCoupon, idCake, amountCake, priceImprot))
                {
                    this.Close();
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
                Int32 amountCake = Int32.Parse(txtAmountImport.Text);
                Int32 priceImport = Int32.Parse(txtImportPrice.Text);
                Int32 amountCakeEdited = Int32.Parse(txtAmountImport.Text) - amount;

                if (idCouponDetail < 0)
                    throw new Exception("Chọn hóa đơn cần sửa");
                if (amountCake < 0)
                    throw new Exception("Số lượng nhập phải lớn hơn 0");
                if (priceImport <= 0)
                    throw new Exception("Giá nhập phải lớn hơn 0");

                if (ImportCouponDetailDAO.Instant.EditDetailCoupon(idCouponDetail, amountCake, amountCakeEdited, priceImport))
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadTextBoxForEdit()
        {
            DataTable data = ImportCouponDetailDAO.Instant.GetDetailImportById(idCouponDetail);
            if (data != null)
            {
                txtIdCakeImportTabImport.Text = data.Rows[0]["idCake"].ToString();
                txtNameCakeImport.Text = data.Rows[0]["nameCake"].ToString();
                txtExportPrice.Text = data.Rows[0]["exportPrice"].ToString();
                txtImportPrice.Text = data.Rows[0]["importPrice"].ToString();
                txtAmountImport.Text = data.Rows[0]["amountCake"].ToString();
                dtpExpImport.Value = Convert.ToDateTime(data.Rows[0]["expCake"].ToString());
                dtpMfgImport.Value = Convert.ToDateTime(data.Rows[0]["mfgCake"].ToString());
                txtSizeCakeImport.Text = data.Rows[0]["size"].ToString();
                cbbCategoryCake.Text = data.Rows[0]["nameCategory"].ToString();
                cbbNameSupplier.Text = data.Rows[0]["nameSupplier"].ToString();
                dtpDayImport.Value = Convert.ToDateTime(data.Rows[0]["dayImport"].ToString());
            }
        }
        private void LoadTextBoxForAdd()
        {
            if (idCake > 0)
            {
                DataTable data = CakeDAO.Instance.GetCakePresentById(idCake);
                if (data != null)
                {
                    txtIdCakeImportTabImport.Text = data.Rows[0]["idCake"].ToString();
                    txtNameCakeImport.Text = data.Rows[0]["nameCake"].ToString();
                    txtExportPrice.Text = data.Rows[0]["exportPrice"].ToString();
                    txtImportPrice.Text = data.Rows[0]["importPrice"].ToString();
                    dtpExpImport.Value = Convert.ToDateTime(data.Rows[0]["expCake"].ToString());
                    dtpMfgImport.Value = Convert.ToDateTime(data.Rows[0]["mfgCake"].ToString());
                    txtSizeCakeImport.Text = data.Rows[0]["size"].ToString();
                    cbbCategoryCake.Text = data.Rows[0]["nameCategory"].ToString();
                    cbbNameSupplier.Text = data.Rows[0]["nameSupplier"].ToString();
                    dtpDayImport.Value = Convert.ToDateTime(data.Rows[0]["dayImport"].ToString());
                }
            }
        }

        #endregion
    }
}
