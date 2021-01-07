using BaketyManagement.DAO;
using System;
using System.Drawing;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace BaketyManagement
{
    public partial class FrmStaff : Form
    {
        //        private Int32 rowDgvCake = 0;
        //        private Int32 rowDgvBill = 0;
        //        private String userName;
        //        CultureInfo culture = CultureInfo.GetCultureInfo("vi-VN"); 
        //        public string UserName { get => userName; set => userName = value; }

        public FrmStaff()
        {
            InitializeComponent();
            CustomizeDesign();
            this.Text = String.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //Design
        #region Design
        private Button currentButton=null;
        private Form activeForm;

        private void CustomizeDesign()
        {
            pnStatistical.Visible = false;
            pnSubmenuAdmin.Visible = false;
        }
        private void HidePnStatistical()
        {
            if (pnStatistical.Visible==true)
            {
                pnStatistical.Visible = false;
            }
        }
        private void HidePnAdmin()
        {
            if (pnSubmenuAdmin.Visible == true)
            {
                pnSubmenuAdmin.Visible = false;
            }
        }
        private void ActivateButton(object senderBtn)
        {
            if (senderBtn!=null)
            {
                if (currentButton!=(Button)senderBtn)
                {
                    DisableButton();
                    currentButton = (Button)senderBtn;
                    currentButton.BackColor = Color.FromArgb(37, 36, 38);
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    txtTitle.Text = currentButton.Text;
                    txtTitle.Anchor = AnchorStyles.None;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control btn in pnMenu.Controls)
            {
                if (btn.GetType()==typeof(Button))
                {
                    btn.BackColor = Color.FromArgb(51, 51, 76);
                    btn.ForeColor = Color.Gainsboro;
                    btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
            foreach (Control btn in pnSubmenuAdmin.Controls)
            {
                if (btn.GetType() == typeof(Button))
                {
                    btn.BackColor = Color.FromArgb(51, 60, 76);
                    btn.ForeColor = Color.Gainsboro;
                    btn.Font =new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
            foreach (Control btn in pnStatistical.Controls)
            {
                if (btn.GetType() == typeof(Button))
                {
                    btn.BackColor = Color.FromArgb(51, 70, 76);
                    btn.ForeColor = Color.Gainsboro;
                    btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void OpenChildForm(Form childForm,object sender)
        {
            if (activeForm!=null)
            {
                activeForm.Close();
            }
            ActivateButton(sender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnDesktop.Controls.Add(childForm);
            this.pnDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        #endregion

        //Events
        #region Events
        private void btnAdmin_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender);
            if (pnSubmenuAdmin.Visible == false)
            {
                pnSubmenuAdmin.Visible = true;
                pnStatistical.Visible = false;
                pnSubmenuAdmin.Height = pnSubmenuAdmin.Height - pnStatistical.Height;
            }
            else
            {
                if (pnStatistical.Visible == true)
                {
                    pnSubmenuAdmin.Visible = false;
                    pnSubmenuAdmin.Height = pnSubmenuAdmin.Height;
                    pnStatistical.Visible = false;
                }
                else
                {
                    pnSubmenuAdmin.Visible = false;
                    pnSubmenuAdmin.Height = pnSubmenuAdmin.Height + pnStatistical.Height;
                }
            }
        }

        private void btnStatistical_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender);
            if (pnStatistical.Visible == false)
            {
                pnStatistical.Visible = true;
                pnSubmenuAdmin.Height = pnSubmenuAdmin.Height + pnStatistical.Height;
            }
            else
            {
                pnStatistical.Visible = false;
                pnSubmenuAdmin.Height = pnSubmenuAdmin.Height - pnStatistical.Height;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMax1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            btnMax2.BringToFront();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMax2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            btnMax1.BringToFront();
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            FrmAdmin frm = new FrmAdmin();
            OpenChildForm(frm, sender);
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnImportCoupon_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnEnterImportCoupon_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnStatisticalList_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnStatisticalChart_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnAccountInfor_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void pnControl_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
            btnMax1.BringToFront();
        }


        //        private void FrmStaff_Load(object sender, EventArgs e)
        //        {
        //            LoadCake();
        //            if (AccountDAO.Instance.GetTypeOfAccount(userName))
        //            {
        //                mnuAdmin.Enabled = false;
        //            }
        //            else
        //            {
        //                btnAdd.Enabled = true;
        //            }
        //        }
        //        private void mnuAdmin_Click(object sender, EventArgs e)
        //        {
        //            FrmAdmin frmAdmin = new FrmAdmin();
        //            this.Hide();
        //            frmAdmin.ShowDialog();
        //            this.Show();
        //        }
        //        private void dgvCake_CellClick(object sender, DataGridViewCellEventArgs e)
        //        {
        //            rowDgvCake = e.RowIndex;
        //            if (rowDgvCake >= 0)
        //            {
        //                txtNameCake.Text = dgvCake.Rows[rowDgvCake].Cells[1].Value.ToString();
        //                numAmountOrder.Value = 0;
        //                txtNameCake.Tag = dgvCake.Rows[rowDgvCake].Cells[0].Value;
        //            }
        //        }

        //        private void btnAll_Click(object sender, EventArgs e)
        //        {
        //            LoadCake();
        //        }
        //        private void btnCookies_Click(object sender, EventArgs e)
        //        {
        //            dgvCake.DataSource = CakeDAO.Instance.SearchCakeByCategoryName("Bánh quy");
        //        }
        //        private void btnGato_Click(object sender, EventArgs e)
        //        {
        //            dgvCake.DataSource = CakeDAO.Instance.SearchCakeByCategoryName("Bánh Gato");
        //        }
        //        private void btnBread_Click(object sender, EventArgs e)
        //        {
        //            dgvCake.DataSource = CakeDAO.Instance.SearchCakeByCategoryName("Bánh mỳ");
        //        }
        //        private void btnMoonCake_Click(object sender, EventArgs e)
        //        {
        //            dgvCake.DataSource = CakeDAO.Instance.SearchCakeByCategoryName("Bánh Trung Thu");
        //        }
        //        private void btnQuickBread_Click(object sender, EventArgs e)
        //        {
        //            dgvCake.DataSource = CakeDAO.Instance.SearchCakeByCategoryName("Quick Bread");
        //        }
        //        private void btnSearch_Click(object sender, EventArgs e)
        //        {
        //            String cakeName = txtSearchCake.Text;
        //            if (cakeName == "")
        //            {
        //                MessageBox.Show("Vui lòng nhập tên bánh cần tìm!", "Thông báo");
        //            }
        //            else
        //            {
        //                dgvCake.DataSource = CakeDAO.Instance.SearchCakeByCakeName(cakeName);
        //                if (dgvCake.Rows.Count<=1)
        //                {
        //                    MessageBox.Show("Không tồn tại sản phẩm nào có tên "+cakeName+"!", "Thông báo");
        //                }
        //            }
        //        }
        //        private void btnAdd_Click(object sender, EventArgs e)
        //        {
        //            AddCakeToBill();
        //        }
        //        private void dgvBill_CellClick(object sender, DataGridViewCellEventArgs e)
        //        {
        //            rowDgvBill = e.RowIndex;
        //            if (rowDgvBill >= 0&&rowDgvBill<dgvBill.Rows.Count-1)
        //            {
        //                txtNameCake.Text = dgvBill.Rows[rowDgvBill].Cells[1].Value.ToString();
        //                numAmountOrder.Value = Convert.ToInt32(dgvBill.Rows[rowDgvBill].Cells[3].Value);
        //                txtNameCake.Tag = dgvBill.Rows[rowDgvBill].Cells[0].Value;
        //            }
        //        }
        //        private void btnPay_Click(object sender, EventArgs e)
        //        {
        //            Single totalMoney = Convert.ToSingle(txtTotalMoney.Text);
        //            if (totalMoney>0)
        //            {
        //                Pay();
        //            }
        //            else
        //            {
        //                MessageBox.Show("Không có hóa đơn nào cần thanh toán!","Thông báo");
        //            }
        //        }
        //        private void btnCancel_Click(object sender, EventArgs e)
        //        {
        //            if (dgvBill.Rows.Count>1)
        //            {
        //                DialogResult result =
        //                MessageBox.Show("Bạn có thực sự muốn hủy hóa đơn này?", "Xác nhận hủy",
        //                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //                if (result == DialogResult.Yes)
        //                {
        //                    BillDetailDAO.Instance.DeleteRecordByIdBill(BillDAO.Instance.GetMaxIDBill());
        //                    txtTotalMoney.Text = "0";
        //                    txtCustomerMoney.Text = "0";
        //                    txtDiscount.Text = "0";
        //                    txtReturnMoney.Text = "0";
        //                }
        //                LoadBill(BillDAO.Instance.GetMaxIDBill());
        //                BillDAO.Instance.DeleteBillByIdBill(BillDAO.Instance.GetMaxIDBill());
        //                LoadCake();
        //            }
        //            else
        //            {
        //                MessageBox.Show("Không có hóa đơn nào được chọn!", "Thông báo");
        //            }
        //        }
        //        private void mnuAccountInfor_Click(object sender, EventArgs e)
        //        {
        //            FrmAccountInfor frmAccountInfor = new FrmAccountInfor();
        //            frmAccountInfor.UserName = userName;
        //            frmAccountInfor.ShowDialog();
        //        }
        //        private void FrmStaff_FormClosing(object sender, FormClosingEventArgs e)
        //        {
        //            if (BillDetailDAO.Instance.GetRowCountByIDBill(BillDAO.Instance.GetMaxIDBill()) <= 0)
        //            {
        //                BillDAO.Instance.DeleteBillByIdBill(BillDAO.Instance.GetMaxIDBill());
        //            }
        //        }
        #endregion

        //        #region Methods
        //        private void Pay()
        //        {
        //            try
        //            {
        //                Single totalMoney = Convert.ToSingle(txtTotalMoney.Text);
        //                Single discount = Convert.ToSingle(txtDiscount.Text);
        //                Single customerMoney = Convert.ToSingle(txtCustomerMoney.Text);
        //                if (customerMoney<=0)
        //                {
        //                    throw new Exception("Số tiền khách hàng thanh toán ít hơn số tiền phải trả!");
        //                }
        //                if (discount>0)
        //                {
        //                    Int32 idBill = BillDAO.Instance.GetMaxIDBill();
        //                    BillDAO.Instance.UpdateDisCountBillByID(discount, idBill);
        //                    if (customerMoney < totalMoney * discount / 100)
        //                    {
        //                        throw new Exception("Số tiền khách hàng thanh toán ít hơn số tiền phải trả!");
        //                    }
        //                    txtReturnMoney.Text = String.Format(culture, "{0:c}",(customerMoney - totalMoney * discount / 100));
        //                }
        //                else
        //                {
        //                    if (customerMoney<totalMoney)
        //                    {
        //                        throw new Exception("Số tiền khách hàng thanh toán ít hơn số tiền phải trả!");
        //                    }
        //                    txtReturnMoney.Text = String.Format(culture, "{0:c}",(customerMoney - totalMoney));
        //                }
        //                dgvBill.DataSource = null;
        //            }
        //            catch (Exception ex)
        //            {
        //                MessageBox.Show(ex.Message);
        //            }
        //        }
        //        private void LoadCake()
        //        {
        //            dgvCake.DataSource = CakeDAO.Instance.GetFullListCake();
        //            dgvCake.Columns[0].HeaderText = "Mã";
        //            dgvCake.Columns[1].HeaderText = "Tên bánh";
        //            dgvCake.Columns[2].HeaderText = "Giá";
        //            dgvCake.Columns[3].HeaderText = "Số lượng còn";
        //            dgvCake.Columns[4].HeaderText = "Kích cỡ";
        //            dgvCake.Columns[5].HeaderText = "Hạn dùng";
        //        }
        //        private void AddCakeToBill()
        //        {
        //            try
        //            {
        //                txtTotalMoney.Text= "0";
        //                txtCustomerMoney.Text = "0";
        //                txtDiscount.Text = "0";
        //                txtReturnMoney.Text = "0";
        //                if (txtNameCake.Text != "")
        //                {
        //                    Int32 idBill = BillDAO.Instance.GetMaxIDBill();
        //                    if (dgvBill.Rows.Count<=1)
        //                    {
        //                        if (BillDetailDAO.Instance.GetRowCountByIDBill(idBill)>0)
        //                        {
        //                            Int32 idStaff = StaffDAO.Instance.GetIDStaffByUserName(userName);
        //                            if (BillDAO.Instance.InsertBill(idStaff))
        //                            {
        //                                idBill = Convert.ToInt32(BillDAO.Instance.GetMaxIDBill());
        //                                Int32 amount = Convert.ToInt32(numAmountOrder.Value);
        //                                if (amount <= 0)
        //                                {
        //                                    throw new Exception("Số lượng mua hàng phải lớn 0!");
        //                                }
        //                                Int32 idCake = Convert.ToInt32(txtNameCake.Tag);
        //                                Int32 remainingAmount = CakeDAO.Instance.GetRemainingAmountByIdCake(idCake);
        //                                if (amount > remainingAmount)
        //                                {
        //                                    throw new Exception("Số lượng trong kho còn ít hơn số lượng khách hàng mua!");
        //                                }
        //                                BillDetailDAO.Instance.InsertBillDetail(idCake, idBill, amount);
        //                                txtTotalMoney.Text = TotalMoney(idBill);
        //                                LoadBill(idBill);
        //                                LoadCake();
        //                            }
        //                        }
        //                        else
        //                        {
        //                            Int32 amount = Convert.ToInt32(numAmountOrder.Value);
        //                            if (amount < 0)
        //                            {
        //                                throw new Exception("Số lượng mua hàng phải lớn 0!");
        //                            }
        //                            Int32 idCake = Convert.ToInt32(txtNameCake.Tag);
        //                            Int32 remainingAmount = CakeDAO.Instance.GetRemainingAmountByIdCake(idCake);
        //                            Int32 oldOrder = BillDetailDAO.Instance.GetOldOrder(idCake, idBill);
        //                            if (oldOrder == 0 && amount == 0)
        //                            {
        //                                throw new Exception("Số lượng mua hàng phải lớn hơn 0!");
        //                            }
        //                            if (amount - oldOrder > remainingAmount)
        //                            {
        //                                throw new Exception("Số lượng trong kho còn ít hơn số lượng khách hàng mua!");
        //                            }
        //                            BillDetailDAO.Instance.InsertBillDetail(idCake, idBill, amount);
        //                            txtTotalMoney.Text = TotalMoney(idBill);
        //                            LoadBill(idBill);
        //                            LoadCake();
        //                        }
        //                    }
        //                    else
        //                    {
        //                        Int32 amount = Convert.ToInt32(numAmountOrder.Value);
        //                        if (amount < 0)
        //                        {
        //                            throw new Exception("Số lượng mua hàng phải lớn 0!");
        //                        }
        //                        Int32 idCake = Convert.ToInt32(txtNameCake.Tag);
        //                        Int32 remainingAmount = CakeDAO.Instance.GetRemainingAmountByIdCake(idCake);
        //                        Int32 oldOrder = BillDetailDAO.Instance.GetOldOrder(idCake, idBill);
        //                        if (oldOrder == 0 && amount == 0)
        //                        {
        //                            throw new Exception("Số lượng mua hàng phải lớn hơn 0!");
        //                        }
        //                        if (amount - oldOrder > remainingAmount)
        //                        {
        //                            throw new Exception("Số lượng trong kho còn ít hơn số lượng khách hàng mua!");
        //                        }
        //                        BillDetailDAO.Instance.InsertBillDetail(idCake, idBill, amount);
        //                        txtTotalMoney.Text = TotalMoney(idBill);
        //                        LoadBill(idBill);
        //                        LoadCake();
        //                    }
        //                }
        //                else throw new Exception("Vui lòng chọn bánh khách hàng mua!");
        //            }
        //            catch (Exception ex)
        //            {
        //                MessageBox.Show(ex.Message);
        //            }
        //        }

        //        private string TotalMoney(int idBill)
        //        {
        //            return BillDetailDAO.Instance.GetTotalMoneyByIDBill(idBill).ToString();
        //        }

        //        private void LoadBill(Int32 idBill)
        //        {
        //            dgvBill.DataSource = BillDAO.Instance.GetBillByID(idBill);
        //            dgvBill.Columns[0].HeaderText = "Mã";
        //            dgvBill.Columns[1].HeaderText = "Tên bánh";
        //            dgvBill.Columns[2].HeaderText = "Giá";
        //            dgvBill.Columns[3].HeaderText = "Số lượng";
        //            dgvBill.Columns[4].HeaderText = "Kích cỡ";
        //        }

        //        #endregion


    }
}
