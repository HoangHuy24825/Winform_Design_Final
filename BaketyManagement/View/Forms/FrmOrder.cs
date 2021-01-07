using BaketyManagement.DAO;
using BaketyManagement.View.Forms.FormPrint;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaketyManagement.View
{
    public partial class FrmOrder : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // height of ellipse
           int nHeightEllipse // width of ellipse
       );
        private Int32 rowDgvCake = 0;
        private Int32 rowDgvBill = 0;
        public static String userName;
        CultureInfo culture = CultureInfo.GetCultureInfo("vi-VN");
        public FrmOrder()
        {
            InitializeComponent();
            //InitGraphic(); 
            //DisableButton();
        }

        #region Design
        //private Button currentButton;
        //private void InitGraphic()
        //{
        //    //
        //    //btn All
        //    //
        //    btnAll.FlatStyle = FlatStyle.Flat;
        //    btnAll.FlatAppearance.BorderSize = 0;
        //    btnAll.BackColor = Color.FromArgb(59, 198, 221);
        //    btnAll.ForeColor = Color.White;
        //    btnAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //    btnAll.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnAll.Width, btnAll.Height, 40, 40));
        //    //
        //    //BtnCookies
        //    //
        //    btnCookies.FlatStyle = FlatStyle.Flat;
        //    btnCookies.FlatAppearance.BorderSize = 0;
        //    btnCookies.BackColor = Color.FromArgb(59, 198, 221);
        //    btnCookies.ForeColor = Color.White;
        //    btnCookies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //    btnCookies.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnCookies.Width, btnCookies.Height, 40, 40));
        //    //
        //    //BtnMoonCake
        //    //
        //    btnMoonCake.FlatStyle = FlatStyle.Flat;
        //    btnMoonCake.FlatAppearance.BorderSize = 0;
        //    btnMoonCake.BackColor = Color.FromArgb(59, 198, 221);
        //    btnMoonCake.ForeColor = Color.White;
        //    btnMoonCake.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //    btnMoonCake.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnCookies.Width, btnCookies.Height, 40, 40));
        //    //
        //    //BtnGato
        //    //
        //    btnGato.FlatStyle = FlatStyle.Flat;
        //    btnGato.FlatAppearance.BorderSize = 0;
        //    btnGato.BackColor = Color.FromArgb(59, 198, 221);
        //    btnGato.ForeColor = Color.White;
        //    btnGato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //    btnGato.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnGato.Width, btnGato.Height, 40, 40));

        //    //
        //    //BtnBread
        //    //
        //    btnBread.FlatStyle = FlatStyle.Flat;
        //    btnBread.FlatAppearance.BorderSize = 0;
        //    btnBread.BackColor = Color.FromArgb(59, 198, 221);
        //    btnBread.ForeColor = Color.White;
        //    btnBread.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //    btnBread.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnBread.Width, btnBread.Height, 40, 40));

        //    //
        //    //BtnQuickBread
        //    //
        //    btnQuickBread.FlatStyle = FlatStyle.Flat;
        //    btnQuickBread.FlatAppearance.BorderSize = 0;
        //    btnQuickBread.BackColor = Color.FromArgb(59, 198, 221);
        //    btnQuickBread.ForeColor = Color.White;
        //    btnQuickBread.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //    btnQuickBread.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnQuickBread.Width, btnQuickBread.Height, 40, 40));

        //    //
        //    //BtnSearch
        //    //
        //    btnSearch.FlatStyle = FlatStyle.Flat;
        //    btnSearch.FlatAppearance.BorderSize = 0;
        //    btnSearch.BackColor = Color.FromArgb(59, 198, 221);
        //    btnSearch.ForeColor = Color.White;
        //    btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //    btnSearch.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnSearch.Width, btnSearch.Height, 40, 40));

        //    //
        //    //BtnAdd
        //    //
        //    btnAdd.FlatStyle = FlatStyle.Flat;
        //    btnAdd.FlatAppearance.BorderSize = 0;
        //    btnAdd.BackColor = Color.FromArgb(59, 198, 221);
        //    btnAdd.ForeColor = Color.White;
        //    btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //    btnAdd.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnAdd.Width, btnAdd.Height, 40, 40));

        //    //
        //    //BtnCancel
        //    //
        //    btnCancel.FlatStyle = FlatStyle.Flat;
        //    btnCancel.FlatAppearance.BorderSize = 0;
        //    btnCancel.BackColor = Color.FromArgb(59, 198, 221);
        //    btnCancel.ForeColor = Color.White;
        //    btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //    btnCancel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnCancel.Width, btnCancel.Height, 40, 40));

        //    //
        //    //BtnPay
        //    //
        //    btnPay.FlatStyle = FlatStyle.Flat;
        //    btnPay.FlatAppearance.BorderSize = 0;
        //    btnPay.BackColor = Color.FromArgb(59, 198, 221);
        //    btnPay.ForeColor = Color.White;
        //    btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //    btnPay.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnPay.Width, btnPay.Height, 40, 40));


        //}
        //private void ActivateButton(object senderBtn)
        //{
        //    if (senderBtn != null)
        //    {
        //        if (currentButton != (Button)senderBtn)
        //        {
        //            DisableButton();
        //            currentButton = (Button)senderBtn;
        //            currentButton.BackColor = Color.FromArgb(79, 158, 226);
        //            currentButton.ForeColor = Color.Black;
        //            currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //        }
        //    }
        //}
        //public void DisableButton()
        //{
        //    foreach (Control btn in pnAmountCake.Controls)
        //    {
        //        if (btn.GetType() == typeof(Button))
        //        {
        //            btnAll.BackColor = Color.FromArgb(59, 198, 221);
        //            btn.ForeColor = Color.White;
        //            btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //        }
        //    }
        //    foreach (Control btn in pnSearchCake.Controls)
        //    {
        //        if (btn.GetType() == typeof(Button))
        //        {
        //            btnAll.BackColor = Color.FromArgb(59, 198, 221);
        //            btn.ForeColor = Color.White;
        //            btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //        }
        //    }
        //    foreach (Control btn in pnPayCake.Controls)
        //    {
        //        if (btn.GetType() == typeof(Button))
        //        {
        //            btnAll.BackColor = Color.FromArgb(59, 198, 221);
        //            btn.ForeColor = Color.White;
        //            btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //        }
        //    }
        //}
        #endregion

        #region Events
        private void FrmStaff_Load(object sender, EventArgs e)
        {
            LoadCake();
        }
        private void mnuAdmin_Click(object sender, EventArgs e)
        {
            FrmAdmin frmAdmin = new FrmAdmin();
            this.Hide();
            frmAdmin.ShowDialog();
            this.Show();
        }
        private void dgvCake_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowDgvCake = e.RowIndex;
            if (rowDgvCake >= 0)
            {
                txtNameCake.Text = dgvCake.Rows[rowDgvCake].Cells[1].Value.ToString();
                numAmountOrder.Value = 0;
                txtNameCake.Tag = dgvCake.Rows[rowDgvCake].Cells[0].Value;
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            LoadCake();
        }
        private void btnCookies_Click(object sender, EventArgs e)
        {
            dgvCake.DataSource = CakeDAO.Instance.SearchCakeByCategoryName("Bánh quy");
        }
        private void btnGato_Click(object sender, EventArgs e)
        {
            dgvCake.DataSource = CakeDAO.Instance.SearchCakeByCategoryName("Bánh Gato");
        }
        private void btnBread_Click(object sender, EventArgs e)
        {
            dgvCake.DataSource = CakeDAO.Instance.SearchCakeByCategoryName("Bánh mỳ");
        }
        private void btnMoonCake_Click(object sender, EventArgs e)
        {
            dgvCake.DataSource = CakeDAO.Instance.SearchCakeByCategoryName("Bánh Trung Thu");
        }
        private void btnQuickBread_Click(object sender, EventArgs e)
        {
            dgvCake.DataSource = CakeDAO.Instance.SearchCakeByCategoryName("Quick Bread");
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            String cakeName = txtSearchCake.Text;
            if (cakeName == "")
            {
                MessageBox.Show("Vui lòng nhập tên bánh cần tìm!", "Thông báo");
            }
            else
            {
                dgvCake.DataSource = CakeDAO.Instance.SearchCakeByCakeName(cakeName);
                if (dgvCake.Rows.Count <= 1)
                {
                    MessageBox.Show("Không tồn tại sản phẩm nào có tên " + cakeName + "!", "Thông báo");
                }
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddCakeToBill();
        }
        private void dgvBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowDgvBill = e.RowIndex;
            if (rowDgvBill >= 0 && rowDgvBill < dgvBill.Rows.Count - 1)
            {
                txtNameCake.Text = dgvBill.Rows[rowDgvBill].Cells[1].Value.ToString();
                numAmountOrder.Value = Convert.ToInt32(dgvBill.Rows[rowDgvBill].Cells[3].Value);
                txtNameCake.Tag = dgvBill.Rows[rowDgvBill].Cells[0].Value;
            }
        }
        private void btnPay_Click(object sender, EventArgs e)
        {
            Single totalMoney = Convert.ToSingle(txtTotalMoney.Text);
            if (totalMoney > 0)
            {
                Pay();
            }
            else
            {
                MessageBox.Show("Không có hóa đơn nào cần thanh toán!", "Thông báo");
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            cancelOrder();
        }
        private void tlpOderRight_Paint(object sender, PaintEventArgs e)
        {
            FrmMain.ShadowPanel(sender, e);

        }

        private void tlpOderLeft_Paint(object sender, PaintEventArgs e)
        {
            FrmMain.ShadowPanel(sender, e);
        }
        private void txtTotalMoney_TextChanged(object sender, EventArgs e)
        {
            changeTotalAfterDiscount();
        }
        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            changeTotalAfterDiscount();
        }
        public void FrmOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            closeForm(sender, e);
        }
        #endregion

        #region Methods
        public void closeForm(object sender, FormClosingEventArgs e)
        {
            if (dgvBill.Rows.Count > 1)
            {
                BillDetailDAO.Instance.DeleteRecordByIdBill(BillDAO.Instance.GetMaxIDBill());
                txtTotalMoney.Text = "0";
                txtCustomerMoney.Text = "0";
                txtDiscount.Text = "0";
                txtReturnMoney.Text = "0";
                LoadBill(BillDAO.Instance.GetMaxIDBill());
                BillDAO.Instance.DeleteBillByIdBill(BillDAO.Instance.GetMaxIDBill());
                LoadCake();
                MessageBox.Show("Bạn đã hủy hóa đơn vừa nhập!");
            }
        }
        private void cancelOrder()
        {
            if (dgvBill.Rows.Count > 1)
            {
                DialogResult result =
                MessageBox.Show("Bạn có thực sự muốn hủy hóa đơn này?", "Xác nhận hủy",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    BillDetailDAO.Instance.DeleteRecordByIdBill(BillDAO.Instance.GetMaxIDBill());
                    txtTotalMoney.Text = "0";
                    txtCustomerMoney.Text = "0";
                    txtDiscount.Text = "0";
                    txtReturnMoney.Text = "0";
                    LoadBill(BillDAO.Instance.GetMaxIDBill());
                    BillDAO.Instance.DeleteBillByIdBill(BillDAO.Instance.GetMaxIDBill());
                    LoadCake();
                }
            }
            else
            {
                MessageBox.Show("Không có hóa đơn nào được chọn!", "Thông báo");
            }
        }
        private void changeTotalAfterDiscount()
        {
            try
            {
                Single total = Convert.ToSingle(txtTotalMoney.Text);
                Single discount = Convert.ToSingle(txtDiscount.Text);
                if (discount < 0)
                {
                    throw new Exception("Giảm giá phải lớn hơn hoặc bằng 0!");
                }
                if (discount != 0)
                {
                    txtTotalMoneyAfterDiscount.Text = (total - total * discount / 100).ToString();
                    txtDiscount.Text = discount.ToString();
                }
                else
                {
                    txtTotalMoneyAfterDiscount.Text = txtTotalMoney.Text;
                    txtDiscount.Text = discount.ToString();
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void Pay()
        {
            try
            {
                Single totalMoney = Convert.ToSingle(txtTotalMoney.Text);
                Single discount = Convert.ToSingle(txtDiscount.Text);
                Single customerMoney = Convert.ToSingle(txtCustomerMoney.Text);
                Single returnMoney = 0;
                Single totalAfterDiscount = 0;
                if (customerMoney <= 0)
                {
                    throw new Exception("Số tiền khách hàng thanh toán ít hơn số tiền phải trả!");
                }
                if (discount > 0)
                {
                    Int32 idBill = BillDAO.Instance.GetMaxIDBill();
                    BillDAO.Instance.UpdateDisCountBillByID(discount, idBill);
                    if (customerMoney < totalMoney - totalMoney * discount / 100)
                    {
                        throw new Exception("Số tiền khách hàng thanh toán ít hơn số tiền phải trả!");
                    }
                    txtReturnMoney.Text = String.Format(culture, "{0:c}", (customerMoney - (totalMoney - totalMoney * discount / 100)));
                    returnMoney = customerMoney - (totalMoney - totalMoney * discount / 100);
                    totalAfterDiscount = totalMoney - totalMoney * discount / 100;
                }
                else
                {
                    if (customerMoney < totalMoney)
                    {
                        throw new Exception("Số tiền khách hàng thanh toán ít hơn số tiền phải trả!");
                    }
                    txtReturnMoney.Text = String.Format(culture, "{0:c}", (customerMoney - totalMoney));
                    returnMoney = customerMoney - totalMoney;
                    totalAfterDiscount = totalMoney;
                }
                Int32 maxIdBill = BillDAO.Instance.GetMaxIDBill();
                BillDAO.Instance.InsertPayBill(maxIdBill, totalMoney, totalAfterDiscount, customerMoney, returnMoney);
                dgvBill.DataSource = null;
                FrmPrintBill frmPrintBill = new FrmPrintBill();
                frmPrintBill.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadCake()
        {
            dgvCake.DataSource = CakeDAO.Instance.GetFullListCake();
            dgvCake.Columns[0].HeaderText = "Mã";
            dgvCake.Columns[1].HeaderText = "Tên bánh";
            dgvCake.Columns[2].HeaderText = "Giá";
            dgvCake.Columns[3].HeaderText = "Số lượng còn";
            dgvCake.Columns[4].HeaderText = "Kích cỡ";
            dgvCake.Columns[5].HeaderText = "Hạn dùng";
        }
        private void AddCakeToBill()
        {
            try
            {
                txtTotalMoney.Text = "0";
                txtCustomerMoney.Text = "0";
                txtReturnMoney.Text = "0";
                if (txtNameCake.Text != "")
                {
                    Int32 idBill = BillDAO.Instance.GetMaxIDBill();
                    if (dgvBill.Rows.Count <= 1)
                    {
                        if (BillDetailDAO.Instance.GetRowCountByIDBill(idBill) > 0)
                        {
                            Int32 idStaff = StaffDAO.Instance.GetIDStaffByUserName(userName);
                            if (BillDAO.Instance.InsertBill(idStaff))
                            {
                                txtDiscount.Text = "0";
                                idBill = Convert.ToInt32(BillDAO.Instance.GetMaxIDBill());
                                Int32 amount = Convert.ToInt32(numAmountOrder.Value);
                                if (amount <= 0)
                                {
                                    throw new Exception("Số lượng mua hàng phải lớn 0!");
                                }
                                Int32 idCake = Convert.ToInt32(txtNameCake.Tag);
                                Int32 remainingAmount = CakeDAO.Instance.GetRemainingAmountByIdCake(idCake);
                                if (amount > remainingAmount)
                                {
                                    throw new Exception("Số lượng trong kho còn ít hơn số lượng khách hàng mua!");
                                }
                                BillDetailDAO.Instance.InsertBillDetail(idCake, idBill, amount);
                                txtTotalMoney.Text = TotalMoney(idBill);
                                LoadBill(idBill);
                                LoadCake();
                            }
                        }
                        else
                        {
                            Int32 amount = Convert.ToInt32(numAmountOrder.Value);
                            if (amount < 0)
                            {
                                throw new Exception("Số lượng mua hàng phải lớn 0!");
                            }
                            Int32 idCake = Convert.ToInt32(txtNameCake.Tag);
                            Int32 remainingAmount = CakeDAO.Instance.GetRemainingAmountByIdCake(idCake);
                            Int32 oldOrder = BillDetailDAO.Instance.GetOldOrder(idCake, idBill);
                            if (oldOrder == 0 && amount == 0)
                            {
                                throw new Exception("Số lượng mua hàng phải lớn hơn 0!");
                            }
                            if (amount - oldOrder > remainingAmount)
                            {
                                throw new Exception("Số lượng trong kho còn ít hơn số lượng khách hàng mua!");
                            }
                            BillDetailDAO.Instance.InsertBillDetail(idCake, idBill, amount);
                            txtTotalMoney.Text = TotalMoney(idBill);
                            LoadBill(idBill);
                            LoadCake();
                        }
                    }
                    else
                    {
                        Int32 amount = Convert.ToInt32(numAmountOrder.Value);
                        if (amount < 0)
                        {
                            throw new Exception("Số lượng mua hàng phải lớn 0!");
                        }
                        Int32 idCake = Convert.ToInt32(txtNameCake.Tag);
                        Int32 remainingAmount = CakeDAO.Instance.GetRemainingAmountByIdCake(idCake);
                        Int32 oldOrder = BillDetailDAO.Instance.GetOldOrder(idCake, idBill);
                        if (oldOrder == 0 && amount == 0)
                        {
                            throw new Exception("Số lượng mua hàng phải lớn hơn 0!");
                        }
                        if (amount - oldOrder > remainingAmount)
                        {
                            throw new Exception("Số lượng trong kho còn ít hơn số lượng khách hàng mua!");
                        }
                        BillDetailDAO.Instance.InsertBillDetail(idCake, idBill, amount);
                        txtTotalMoney.Text = TotalMoney(idBill);
                        LoadBill(idBill);
                        LoadCake();
                    }
                }
                else throw new Exception("Vui lòng chọn bánh khách hàng mua!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string TotalMoney(int idBill)
        {
            return BillDetailDAO.Instance.GetTotalMoneyByIDBill(idBill).ToString();
        }

        private void LoadBill(Int32 idBill)
        {
            dgvBill.DataSource = BillDAO.Instance.GetBillByID(idBill);
            dgvBill.Columns[0].HeaderText = "Mã";
            dgvBill.Columns[1].HeaderText = "Tên bánh";
            dgvBill.Columns[2].HeaderText = "Giá";
            dgvBill.Columns[3].HeaderText = "Số lượng";
            dgvBill.Columns[4].HeaderText = "Kích cỡ";
        }
        #endregion


    }
}
