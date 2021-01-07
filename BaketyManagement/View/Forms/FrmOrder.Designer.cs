
namespace BaketyManagement.View
{
    partial class FrmOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrder));
            this.txtReturnMoney = new System.Windows.Forms.TextBox();
            this.txtCustomerMoney = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtTotalMoney = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbPayCake = new System.Windows.Forms.GroupBox();
            this.pnPayCake = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.txtTotalMoneyAfterDiscount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.tlpOderRight = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pnSearchCake = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnQuickBread = new System.Windows.Forms.Button();
            this.btnMoonCake = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchCake = new System.Windows.Forms.TextBox();
            this.btnBread = new System.Windows.Forms.Button();
            this.btnGato = new System.Windows.Forms.Button();
            this.btnCookies = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.tlpOder = new System.Windows.Forms.TableLayoutPanel();
            this.gbChoseCake = new System.Windows.Forms.GroupBox();
            this.tlpOderLeft = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pnDgvCake = new System.Windows.Forms.Panel();
            this.dgvCake = new System.Windows.Forms.DataGridView();
            this.pnAmountCake = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.numAmountOrder = new System.Windows.Forms.NumericUpDown();
            this.txtNameCake = new System.Windows.Forms.TextBox();
            this.gbPayCake.SuspendLayout();
            this.pnPayCake.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            this.tlpOderRight.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnSearchCake.SuspendLayout();
            this.tlpOder.SuspendLayout();
            this.gbChoseCake.SuspendLayout();
            this.tlpOderLeft.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.pnDgvCake.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCake)).BeginInit();
            this.pnAmountCake.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAmountOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // txtReturnMoney
            // 
            this.txtReturnMoney.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReturnMoney.Location = new System.Drawing.Point(190, 227);
            this.txtReturnMoney.Name = "txtReturnMoney";
            this.txtReturnMoney.Size = new System.Drawing.Size(324, 26);
            this.txtReturnMoney.TabIndex = 2;
            this.txtReturnMoney.Text = "0";
            this.txtReturnMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCustomerMoney
            // 
            this.txtCustomerMoney.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCustomerMoney.Location = new System.Drawing.Point(190, 176);
            this.txtCustomerMoney.Name = "txtCustomerMoney";
            this.txtCustomerMoney.Size = new System.Drawing.Size(324, 26);
            this.txtCustomerMoney.TabIndex = 2;
            this.txtCustomerMoney.Text = "0";
            this.txtCustomerMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiscount.Location = new System.Drawing.Point(190, 74);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(324, 26);
            this.txtDiscount.TabIndex = 2;
            this.txtDiscount.Text = "0";
            this.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
            // 
            // txtTotalMoney
            // 
            this.txtTotalMoney.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalMoney.Location = new System.Drawing.Point(190, 23);
            this.txtTotalMoney.Name = "txtTotalMoney";
            this.txtTotalMoney.ReadOnly = true;
            this.txtTotalMoney.Size = new System.Drawing.Size(324, 26);
            this.txtTotalMoney.TabIndex = 2;
            this.txtTotalMoney.Text = "0";
            this.txtTotalMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalMoney.TextChanged += new System.EventHandler(this.txtTotalMoney_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(36, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Trả lại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(36, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tiền khách đưa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(36, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giảm giá (%)";
            // 
            // gbPayCake
            // 
            this.gbPayCake.BackColor = System.Drawing.Color.White;
            this.gbPayCake.Controls.Add(this.pnPayCake);
            this.gbPayCake.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbPayCake.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPayCake.Location = new System.Drawing.Point(0, 0);
            this.gbPayCake.Name = "gbPayCake";
            this.gbPayCake.Size = new System.Drawing.Size(556, 392);
            this.gbPayCake.TabIndex = 1;
            this.gbPayCake.TabStop = false;
            this.gbPayCake.Text = "Chức năng";
            // 
            // pnPayCake
            // 
            this.pnPayCake.Controls.Add(this.btnCancel);
            this.pnPayCake.Controls.Add(this.label1);
            this.pnPayCake.Controls.Add(this.txtReturnMoney);
            this.pnPayCake.Controls.Add(this.btnPay);
            this.pnPayCake.Controls.Add(this.txtTotalMoneyAfterDiscount);
            this.pnPayCake.Controls.Add(this.txtCustomerMoney);
            this.pnPayCake.Controls.Add(this.label2);
            this.pnPayCake.Controls.Add(this.txtDiscount);
            this.pnPayCake.Controls.Add(this.label7);
            this.pnPayCake.Controls.Add(this.label3);
            this.pnPayCake.Controls.Add(this.txtTotalMoney);
            this.pnPayCake.Controls.Add(this.label4);
            this.pnPayCake.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPayCake.Location = new System.Drawing.Point(3, 22);
            this.pnPayCake.Name = "pnPayCake";
            this.pnPayCake.Size = new System.Drawing.Size(550, 367);
            this.pnPayCake.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(52)))), ((int)(((byte)(36)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(32)))), ((int)(((byte)(18)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(52)))), ((int)(((byte)(36)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Image = global::BaketyManagement.Properties.Resources.Cancel;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancel.Location = new System.Drawing.Point(190, 274);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 70);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Hủy ";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(36, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tổng tiền";
            // 
            // btnPay
            // 
            this.btnPay.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(159)))), ((int)(((byte)(56)))));
            this.btnPay.FlatAppearance.BorderSize = 0;
            this.btnPay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(126)))), ((int)(((byte)(38)))));
            this.btnPay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(159)))), ((int)(((byte)(56)))));
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Image = global::BaketyManagement.Properties.Resources.pay;
            this.btnPay.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPay.Location = new System.Drawing.Point(364, 274);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(150, 70);
            this.btnPay.TabIndex = 0;
            this.btnPay.Text = "Thanh toán";
            this.btnPay.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // txtTotalMoneyAfterDiscount
            // 
            this.txtTotalMoneyAfterDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalMoneyAfterDiscount.Location = new System.Drawing.Point(190, 125);
            this.txtTotalMoneyAfterDiscount.Name = "txtTotalMoneyAfterDiscount";
            this.txtTotalMoneyAfterDiscount.ReadOnly = true;
            this.txtTotalMoneyAfterDiscount.Size = new System.Drawing.Size(324, 26);
            this.txtTotalMoneyAfterDiscount.TabIndex = 2;
            this.txtTotalMoneyAfterDiscount.Text = "0";
            this.txtTotalMoneyAfterDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(36, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Tổng tiền đã giảm";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(556, 202);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hóa đơn";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvBill);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(3, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 177);
            this.panel1.TabIndex = 0;
            // 
            // dgvBill
            // 
            this.dgvBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBill.BackgroundColor = System.Drawing.Color.White;
            this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBill.Location = new System.Drawing.Point(0, 0);
            this.dgvBill.MultiSelect = false;
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.ReadOnly = true;
            this.dgvBill.RowHeadersWidth = 51;
            this.dgvBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBill.Size = new System.Drawing.Size(550, 177);
            this.dgvBill.TabIndex = 1;
            this.dgvBill.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBill_CellClick);
            // 
            // tlpOderRight
            // 
            this.tlpOderRight.ColumnCount = 1;
            this.tlpOderRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpOderRight.Controls.Add(this.panel4, 0, 1);
            this.tlpOderRight.Controls.Add(this.panel3, 0, 0);
            this.tlpOderRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpOderRight.Location = new System.Drawing.Point(595, 13);
            this.tlpOderRight.Name = "tlpOderRight";
            this.tlpOderRight.RowCount = 2;
            this.tlpOderRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.1735F));
            this.tlpOderRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.8265F));
            this.tlpOderRight.Size = new System.Drawing.Size(576, 634);
            this.tlpOderRight.TabIndex = 1;
            this.tlpOderRight.Paint += new System.Windows.Forms.PaintEventHandler(this.tlpOderRight_Paint);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.gbPayCake);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(10, 232);
            this.panel4.Margin = new System.Windows.Forms.Padding(10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(556, 392);
            this.panel4.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(10, 10);
            this.panel3.Margin = new System.Windows.Forms.Padding(10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(556, 202);
            this.panel3.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(13, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(262, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Số lượng bánh khách hàng mua";
            // 
            // pnSearchCake
            // 
            this.pnSearchCake.BackColor = System.Drawing.Color.White;
            this.pnSearchCake.Controls.Add(this.label5);
            this.pnSearchCake.Controls.Add(this.btnQuickBread);
            this.pnSearchCake.Controls.Add(this.btnMoonCake);
            this.pnSearchCake.Controls.Add(this.btnSearch);
            this.pnSearchCake.Controls.Add(this.txtSearchCake);
            this.pnSearchCake.Controls.Add(this.btnBread);
            this.pnSearchCake.Controls.Add(this.btnGato);
            this.pnSearchCake.Controls.Add(this.btnCookies);
            this.pnSearchCake.Controls.Add(this.btnAll);
            this.pnSearchCake.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnSearchCake.Location = new System.Drawing.Point(20, 20);
            this.pnSearchCake.Margin = new System.Windows.Forms.Padding(10);
            this.pnSearchCake.Name = "pnSearchCake";
            this.pnSearchCake.Size = new System.Drawing.Size(530, 280);
            this.pnSearchCake.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(6, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tìm bánh theo tên";
            // 
            // btnQuickBread
            // 
            this.btnQuickBread.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnQuickBread.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(137)))));
            this.btnQuickBread.FlatAppearance.BorderSize = 0;
            this.btnQuickBread.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(109)))));
            this.btnQuickBread.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(137)))));
            this.btnQuickBread.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuickBread.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuickBread.Image = global::BaketyManagement.Properties.Resources.quickBread;
            this.btnQuickBread.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnQuickBread.Location = new System.Drawing.Point(363, 99);
            this.btnQuickBread.Name = "btnQuickBread";
            this.btnQuickBread.Size = new System.Drawing.Size(150, 80);
            this.btnQuickBread.TabIndex = 6;
            this.btnQuickBread.Text = "Quick Bread";
            this.btnQuickBread.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnQuickBread.UseVisualStyleBackColor = false;
            this.btnQuickBread.Click += new System.EventHandler(this.btnQuickBread_Click);
            // 
            // btnMoonCake
            // 
            this.btnMoonCake.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnMoonCake.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(137)))));
            this.btnMoonCake.FlatAppearance.BorderSize = 0;
            this.btnMoonCake.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(109)))));
            this.btnMoonCake.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(137)))));
            this.btnMoonCake.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoonCake.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoonCake.Image = global::BaketyManagement.Properties.Resources.midMoonCake;
            this.btnMoonCake.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMoonCake.Location = new System.Drawing.Point(363, 13);
            this.btnMoonCake.Name = "btnMoonCake";
            this.btnMoonCake.Size = new System.Drawing.Size(150, 80);
            this.btnMoonCake.TabIndex = 6;
            this.btnMoonCake.Text = "Bánh Trung Thu";
            this.btnMoonCake.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMoonCake.UseVisualStyleBackColor = false;
            this.btnMoonCake.Click += new System.EventHandler(this.btnMoonCake_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(36)))), ((int)(((byte)(210)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(18)))), ((int)(((byte)(167)))));
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(36)))), ((int)(((byte)(210)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Image = global::BaketyManagement.Properties.Resources.Search;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSearch.Location = new System.Drawing.Point(363, 199);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(150, 70);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchCake
            // 
            this.txtSearchCake.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchCake.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchCake.Location = new System.Drawing.Point(10, 226);
            this.txtSearchCake.Name = "txtSearchCake";
            this.txtSearchCake.Size = new System.Drawing.Size(332, 26);
            this.txtSearchCake.TabIndex = 4;
            // 
            // btnBread
            // 
            this.btnBread.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBread.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(137)))));
            this.btnBread.FlatAppearance.BorderSize = 0;
            this.btnBread.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(109)))));
            this.btnBread.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(137)))));
            this.btnBread.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBread.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBread.Image = global::BaketyManagement.Properties.Resources.bread;
            this.btnBread.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBread.Location = new System.Drawing.Point(190, 101);
            this.btnBread.Name = "btnBread";
            this.btnBread.Size = new System.Drawing.Size(150, 80);
            this.btnBread.TabIndex = 3;
            this.btnBread.Text = "Bánh Mỳ";
            this.btnBread.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBread.UseVisualStyleBackColor = false;
            this.btnBread.Click += new System.EventHandler(this.btnBread_Click);
            // 
            // btnGato
            // 
            this.btnGato.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(137)))));
            this.btnGato.FlatAppearance.BorderSize = 0;
            this.btnGato.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(109)))));
            this.btnGato.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(137)))));
            this.btnGato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGato.Image = global::BaketyManagement.Properties.Resources.gato;
            this.btnGato.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGato.Location = new System.Drawing.Point(17, 101);
            this.btnGato.Name = "btnGato";
            this.btnGato.Size = new System.Drawing.Size(150, 80);
            this.btnGato.TabIndex = 2;
            this.btnGato.Text = "Bánh Gato";
            this.btnGato.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGato.UseVisualStyleBackColor = false;
            this.btnGato.Click += new System.EventHandler(this.btnGato_Click);
            // 
            // btnCookies
            // 
            this.btnCookies.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCookies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(137)))));
            this.btnCookies.FlatAppearance.BorderSize = 0;
            this.btnCookies.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(109)))));
            this.btnCookies.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(137)))));
            this.btnCookies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCookies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCookies.Image = ((System.Drawing.Image)(resources.GetObject("btnCookies.Image")));
            this.btnCookies.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCookies.Location = new System.Drawing.Point(190, 13);
            this.btnCookies.Name = "btnCookies";
            this.btnCookies.Size = new System.Drawing.Size(150, 80);
            this.btnCookies.TabIndex = 1;
            this.btnCookies.Text = "Bánh Quy";
            this.btnCookies.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCookies.UseVisualStyleBackColor = false;
            this.btnCookies.Click += new System.EventHandler(this.btnCookies_Click);
            // 
            // btnAll
            // 
            this.btnAll.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(137)))));
            this.btnAll.FlatAppearance.BorderSize = 0;
            this.btnAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(109)))));
            this.btnAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(137)))));
            this.btnAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll.Image = global::BaketyManagement.Properties.Resources.allIcon;
            this.btnAll.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAll.Location = new System.Drawing.Point(17, 15);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(150, 80);
            this.btnAll.TabIndex = 0;
            this.btnAll.Text = "Tất cả";
            this.btnAll.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAll.UseVisualStyleBackColor = false;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // tlpOder
            // 
            this.tlpOder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.tlpOder.ColumnCount = 2;
            this.tlpOder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpOder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpOder.Controls.Add(this.tlpOderRight, 1, 0);
            this.tlpOder.Controls.Add(this.gbChoseCake, 0, 0);
            this.tlpOder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpOder.Location = new System.Drawing.Point(0, 0);
            this.tlpOder.Name = "tlpOder";
            this.tlpOder.Padding = new System.Windows.Forms.Padding(10);
            this.tlpOder.RowCount = 1;
            this.tlpOder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpOder.Size = new System.Drawing.Size(1184, 660);
            this.tlpOder.TabIndex = 2;
            // 
            // gbChoseCake
            // 
            this.gbChoseCake.Controls.Add(this.tlpOderLeft);
            this.gbChoseCake.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbChoseCake.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbChoseCake.Location = new System.Drawing.Point(13, 13);
            this.gbChoseCake.Name = "gbChoseCake";
            this.gbChoseCake.Size = new System.Drawing.Size(576, 634);
            this.gbChoseCake.TabIndex = 0;
            this.gbChoseCake.TabStop = false;
            this.gbChoseCake.Text = "Chọn món";
            // 
            // tlpOderLeft
            // 
            this.tlpOderLeft.ColumnCount = 1;
            this.tlpOderLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpOderLeft.Controls.Add(this.panel2, 0, 1);
            this.tlpOderLeft.Controls.Add(this.pnSearchCake, 0, 0);
            this.tlpOderLeft.Controls.Add(this.pnAmountCake, 0, 2);
            this.tlpOderLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpOderLeft.Location = new System.Drawing.Point(3, 22);
            this.tlpOderLeft.Name = "tlpOderLeft";
            this.tlpOderLeft.Padding = new System.Windows.Forms.Padding(10);
            this.tlpOderLeft.RowCount = 3;
            this.tlpOderLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tlpOderLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpOderLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlpOderLeft.Size = new System.Drawing.Size(570, 609);
            this.tlpOderLeft.TabIndex = 0;
            this.tlpOderLeft.Paint += new System.Windows.Forms.PaintEventHandler(this.tlpOderLeft_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(20, 320);
            this.panel2.Margin = new System.Windows.Forms.Padding(10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(530, 149);
            this.panel2.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.pnDgvCake);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(530, 149);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách bánh";
            // 
            // pnDgvCake
            // 
            this.pnDgvCake.Controls.Add(this.dgvCake);
            this.pnDgvCake.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDgvCake.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnDgvCake.ForeColor = System.Drawing.Color.Black;
            this.pnDgvCake.Location = new System.Drawing.Point(3, 22);
            this.pnDgvCake.Name = "pnDgvCake";
            this.pnDgvCake.Size = new System.Drawing.Size(524, 124);
            this.pnDgvCake.TabIndex = 4;
            // 
            // dgvCake
            // 
            this.dgvCake.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCake.BackgroundColor = System.Drawing.Color.White;
            this.dgvCake.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCake.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCake.Location = new System.Drawing.Point(0, 0);
            this.dgvCake.MultiSelect = false;
            this.dgvCake.Name = "dgvCake";
            this.dgvCake.ReadOnly = true;
            this.dgvCake.RowHeadersWidth = 51;
            this.dgvCake.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCake.Size = new System.Drawing.Size(524, 124);
            this.dgvCake.TabIndex = 2;
            this.dgvCake.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCake_CellClick);
            // 
            // pnAmountCake
            // 
            this.pnAmountCake.BackColor = System.Drawing.Color.White;
            this.pnAmountCake.Controls.Add(this.label6);
            this.pnAmountCake.Controls.Add(this.btnAdd);
            this.pnAmountCake.Controls.Add(this.numAmountOrder);
            this.pnAmountCake.Controls.Add(this.txtNameCake);
            this.pnAmountCake.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnAmountCake.Location = new System.Drawing.Point(20, 489);
            this.pnAmountCake.Margin = new System.Windows.Forms.Padding(10);
            this.pnAmountCake.Name = "pnAmountCake";
            this.pnAmountCake.Size = new System.Drawing.Size(530, 100);
            this.pnAmountCake.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(140)))), ((int)(((byte)(36)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(107)))), ((int)(((byte)(18)))));
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(140)))), ((int)(((byte)(36)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Image = global::BaketyManagement.Properties.Resources.Add;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdd.Location = new System.Drawing.Point(369, 17);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 70);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // numAmountOrder
            // 
            this.numAmountOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numAmountOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numAmountOrder.Location = new System.Drawing.Point(292, 42);
            this.numAmountOrder.Name = "numAmountOrder";
            this.numAmountOrder.Size = new System.Drawing.Size(71, 26);
            this.numAmountOrder.TabIndex = 5;
            // 
            // txtNameCake
            // 
            this.txtNameCake.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNameCake.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameCake.Location = new System.Drawing.Point(12, 42);
            this.txtNameCake.Name = "txtNameCake";
            this.txtNameCake.Size = new System.Drawing.Size(263, 26);
            this.txtNameCake.TabIndex = 4;
            // 
            // FrmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 660);
            this.Controls.Add(this.tlpOder);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmOrder";
            this.Text = "FrmOrder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmOrder_FormClosing);
            this.Load += new System.EventHandler(this.FrmStaff_Load);
            this.gbPayCake.ResumeLayout(false);
            this.pnPayCake.ResumeLayout(false);
            this.pnPayCake.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            this.tlpOderRight.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.pnSearchCake.ResumeLayout(false);
            this.pnSearchCake.PerformLayout();
            this.tlpOder.ResumeLayout(false);
            this.gbChoseCake.ResumeLayout(false);
            this.tlpOderLeft.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.pnDgvCake.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCake)).EndInit();
            this.pnAmountCake.ResumeLayout(false);
            this.pnAmountCake.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAmountOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtReturnMoney;
        private System.Windows.Forms.TextBox txtCustomerMoney;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtTotalMoney;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.GroupBox gbPayCake;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tlpOderRight;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel pnSearchCake;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnQuickBread;
        private System.Windows.Forms.Button btnMoonCake;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchCake;
        private System.Windows.Forms.Button btnBread;
        private System.Windows.Forms.Button btnGato;
        private System.Windows.Forms.Button btnCookies;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.TableLayoutPanel tlpOder;
        private System.Windows.Forms.GroupBox gbChoseCake;
        private System.Windows.Forms.TableLayoutPanel tlpOderLeft;
        private System.Windows.Forms.Panel pnAmountCake;
        private System.Windows.Forms.NumericUpDown numAmountOrder;
        private System.Windows.Forms.TextBox txtNameCake;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvBill;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel pnDgvCake;
        private System.Windows.Forms.DataGridView dgvCake;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel pnPayCake;
        private System.Windows.Forms.TextBox txtTotalMoneyAfterDiscount;
        private System.Windows.Forms.Label label7;
    }
}