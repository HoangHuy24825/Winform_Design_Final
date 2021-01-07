using BaketyManagement.DAO;
using BaketyManagement.View;
using BaketyManagement.View.Forms;
using BaketyManagement.View.Forms.FormPrint;
using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace BaketyManagement
{
    public partial class FrmMain : Form
    {
        public static String userName;

        public FrmMain()
        {
            InitializeComponent();
            CustomizeDesign();
            this.Text = String.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.FormBorderStyle = FormBorderStyle.None;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //
        //Design
        //
        #region Design
        private Button currentButton = null;

        private Form activeForm;

        private void CustomizeDesign()
        {
            pnStatistical.Visible = false;
            pnSubmenuAdmin.Visible = false;
        }
        private void ActivateButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                if (currentButton != (Button)senderBtn)
                {
                    DisableButton();
                    currentButton = (Button)senderBtn;
                    currentButton.BackColor = Color.FromArgb(92, 105, 129);
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    txtTitle.Text = currentButton.Text;
                    txtTitle.Anchor = AnchorStyles.None;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control btn in pnMenu.Controls)
            {
                if (btn.GetType() == typeof(Button))
                {
                    btn.BackColor = Color.FromArgb(30, 29, 47);
                    btn.ForeColor = Color.Gainsboro;
                    btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
            foreach (Control btn in pnSubmenuAdmin.Controls)
            {
                if (btn.GetType() == typeof(Button))
                {
                    btn.BackColor = Color.FromArgb(30, 29, 47);
                    btn.ForeColor = Color.Gainsboro;
                    btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
            foreach (Control btn in pnStatistical.Controls)
            {
                if (btn.GetType() == typeof(Button))
                {
                    btn.BackColor = Color.FromArgb(30, 29, 47);
                    btn.ForeColor = Color.Gainsboro;
                    btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void OpenChildForm(Form childForm, object sender)
        {
            pnDesktop.BackgroundImage = null;
            if (activeForm != null)
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

        //
        //Events
        //
        #region Events
        private void FrmMain_Load(object sender, EventArgs e)
        {
            btnMaximize1.Visible = false;
            if (AccountDAO.Instance.GetTypeOfAccount(userName))
            {
                btnAdmin.Enabled = false;
            }
            else
            {
                btnAdmin.Enabled = true;
            }
        }
        private void btnTimeKeeping_Click(object sender, EventArgs e)
        {
            FrmTimeKeeping frmTimeKeeping = new FrmTimeKeeping();
            OpenChildForm(frmTimeKeeping, sender);
        }
        private void btnAdmin_Click(object sender, EventArgs e)
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

        private void btnStatistical_Click(object sender, EventArgs e)
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
            this.Close();
        }

        private void btnMax1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            btnMaximize1.Visible = false;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMax2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
        }

        private void btnMain_Click(object sender, EventArgs e)
        {

            FrmOrder frmOrder = new FrmOrder();
            FrmOrder.userName = userName;
            OpenChildForm(frmOrder, sender);

        }

        private void btnPrintInventory_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmPrintInventory(), sender);
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {

            FrmAccount frm = new FrmAccount();
            OpenChildForm(frm, sender);

        }

        private void btnStaff_Click(object sender, EventArgs e)
        {

            FrmStaff frm = new FrmStaff();
            OpenChildForm(frm, sender);

        }

        private void btnProduct_Click(object sender, EventArgs e)
        {

            FrmProducts frm = new FrmProducts();
            OpenChildForm(frm, sender);

        }

        private void btnCategory_Click(object sender, EventArgs e)
        {

            FrmCategory frm = new FrmCategory();
            OpenChildForm(frm, sender);

        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            FrmSupplier frm = new FrmSupplier();
            OpenChildForm(frm, sender);
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            FrmBill frmBill = new FrmBill();
            OpenChildForm(frmBill, sender);
        }

        private void btnImportCoupon_Click(object sender, EventArgs e)
        {
            FrmImportCoupon frmImportCoupon = new FrmImportCoupon();
            OpenChildForm(frmImportCoupon, sender);
        }

        private void btnEnterImportCoupon_Click(object sender, EventArgs e)
        {
            FrmInputImportCoupon frm = new FrmInputImportCoupon();
            OpenChildForm(frm, sender);
        }

        private void btnStatisticalList_Click(object sender, EventArgs e)
        {
            FrmStatisticalList frmStatisticalList = new FrmStatisticalList();
            OpenChildForm(frmStatisticalList, sender);
        }

        private void btnStatisticalChart_Click(object sender, EventArgs e)
        {
            FrmStatisticalChart frmStatisticalChart = new FrmStatisticalChart();
            OpenChildForm(frmStatisticalChart, sender);
        }

        private void btnAccountInfor_Click(object sender, EventArgs e)
        {
            FrmAccountInfor frmAccount = new FrmAccountInfor();
            FrmAccountInfor.userName = userName;
            OpenChildForm(frmAccount, sender);
        }

        private void pnControl_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
            btnMaximize1.Visible = true;
        }
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có thực sự muốn đăng xuất khỏi phần mềm?", "Hỏi thoát?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }

        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (pnMenuLarge.Visible)
                pnMenuLarge.Visible = false;
            else
                pnMenuLarge.Visible = true;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ShadowPanel(sender, e);
        }
        private void pnTitle_Paint(object sender, PaintEventArgs e)
        {
            FrmMain.ShadowPanel(sender, e);
        }
        #endregion


        //
        //Methods
        //
        #region Methods
        public static void ShadowPanel(object sender, PaintEventArgs e)
        {
            Panel panel = (Panel)sender;
            Int32 n = 14;
            Int32 startRang = 235;
            Int32 endRang = 249;
            Int32 step = (Int32)((endRang - startRang) / (n - 1));
            Color[] shadow = new Color[n];
            for (int i = 0; i < n; i++)
            {
                shadow[i] = Color.FromArgb(startRang + step * i, startRang + step * i, startRang + step * i);
            }
            Pen pen = new Pen(shadow[0]);
            using (pen)
            {
                foreach (Panel p in panel.Controls.OfType<Panel>())
                {
                    Point pt = p.Location;
                    pt.Y += p.Height;

                    Point pt2 = p.Location;
                    pt2.X += p.Width;

                    Point pt3 = p.Location;
                    pt3.X += 0;

                    Point pt4 = p.Location;
                    pt4.Y += 0;
                    for (var sp = 0; sp < n; sp++)
                    {
                        pen.Color = shadow[sp];
                        e.Graphics.DrawLine(pen, pt.X - n + 1, pt.Y, pt.X + 4 + p.Width + 1, pt.Y);//Botton
                        e.Graphics.DrawLine(pen, pt4.X - n + 1, pt4.Y, pt4.X + p.Width + 1 + n, pt4.Y);//Top
                        e.Graphics.DrawLine(pen, pt2.X, pt2.Y - n, pt2.X, pt2.Y + p.Height + n - 1);//Right
                        e.Graphics.DrawLine(pen, pt3.X, pt3.Y - n, pt3.X, pt3.Y + p.Height + n - 1);//Left

                        pt.Y++;
                        pt2.X++;
                        pt3.X--;
                        pt4.Y--;
                    }
                }
            }
        }

        #endregion

       
    }
}
