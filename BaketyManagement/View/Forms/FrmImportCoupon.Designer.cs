
namespace BaketyManagement.View.Forms
{
    partial class FrmImportCoupon
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
            this.dtpEndImportDay = new System.Windows.Forms.DateTimePicker();
            this.dtpStartImportDay = new System.Windows.Forms.DateTimePicker();
            this.label36 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.txtSearchImportCoupon = new System.Windows.Forms.TextBox();
            this.btnFilterCouponImport = new System.Windows.Forms.Button();
            this.btnSearchCouponImport = new System.Windows.Forms.Button();
            this.btnDisplayCouponImport = new System.Windows.Forms.Button();
            this.groupBox30 = new System.Windows.Forms.GroupBox();
            this.pnFunctionImport = new System.Windows.Forms.Panel();
            this.groupBox29 = new System.Windows.Forms.GroupBox();
            this.panel37 = new System.Windows.Forms.Panel();
            this.dgvDetailCouponImport = new System.Windows.Forms.DataGridView();
            this.tlpCoupon = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel13 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox28 = new System.Windows.Forms.GroupBox();
            this.panel35 = new System.Windows.Forms.Panel();
            this.dgvCouponImport = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox30.SuspendLayout();
            this.pnFunctionImport.SuspendLayout();
            this.groupBox29.SuspendLayout();
            this.panel37.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailCouponImport)).BeginInit();
            this.tlpCoupon.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel13.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox28.SuspendLayout();
            this.panel35.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCouponImport)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpEndImportDay
            // 
            this.dtpEndImportDay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpEndImportDay.CustomFormat = "dd/MM/yyyy";
            this.dtpEndImportDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndImportDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndImportDay.Location = new System.Drawing.Point(354, 162);
            this.dtpEndImportDay.Name = "dtpEndImportDay";
            this.dtpEndImportDay.Size = new System.Drawing.Size(433, 26);
            this.dtpEndImportDay.TabIndex = 7;
            // 
            // dtpStartImportDay
            // 
            this.dtpStartImportDay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpStartImportDay.CustomFormat = "dd/MM/yyyy";
            this.dtpStartImportDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartImportDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartImportDay.Location = new System.Drawing.Point(354, 118);
            this.dtpStartImportDay.Name = "dtpStartImportDay";
            this.dtpStartImportDay.Size = new System.Drawing.Size(433, 26);
            this.dtpStartImportDay.TabIndex = 7;
            // 
            // label36
            // 
            this.label36.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.label36.Location = new System.Drawing.Point(194, 168);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(119, 20);
            this.label36.TabIndex = 6;
            this.label36.Text = "Ngày kết thúc";
            // 
            // label41
            // 
            this.label41.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.label41.Location = new System.Drawing.Point(194, 123);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(115, 20);
            this.label41.TabIndex = 6;
            this.label41.Text = "Ngày bắt đầu";
            // 
            // label42
            // 
            this.label42.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.label42.Location = new System.Drawing.Point(32, 89);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(216, 20);
            this.label42.TabIndex = 6;
            this.label42.Text = "Lọc phiếu nhập theo ngày";
            // 
            // label43
            // 
            this.label43.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.label43.Location = new System.Drawing.Point(32, 49);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(316, 20);
            this.label43.TabIndex = 6;
            this.label43.Text = "Tìm phiếu nhập theo tên nhà cung cấp";
            // 
            // txtSearchImportCoupon
            // 
            this.txtSearchImportCoupon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSearchImportCoupon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchImportCoupon.Location = new System.Drawing.Point(354, 46);
            this.txtSearchImportCoupon.Name = "txtSearchImportCoupon";
            this.txtSearchImportCoupon.Size = new System.Drawing.Size(433, 26);
            this.txtSearchImportCoupon.TabIndex = 5;
            // 
            // btnFilterCouponImport
            // 
            this.btnFilterCouponImport.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnFilterCouponImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(137)))));
            this.btnFilterCouponImport.FlatAppearance.BorderSize = 0;
            this.btnFilterCouponImport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(109)))));
            this.btnFilterCouponImport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(137)))));
            this.btnFilterCouponImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterCouponImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilterCouponImport.ForeColor = System.Drawing.Color.White;
            this.btnFilterCouponImport.Image = global::BaketyManagement.Properties.Resources.filter;
            this.btnFilterCouponImport.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFilterCouponImport.Location = new System.Drawing.Point(818, 115);
            this.btnFilterCouponImport.Name = "btnFilterCouponImport";
            this.btnFilterCouponImport.Size = new System.Drawing.Size(150, 70);
            this.btnFilterCouponImport.TabIndex = 4;
            this.btnFilterCouponImport.Text = "Lọc";
            this.btnFilterCouponImport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFilterCouponImport.UseVisualStyleBackColor = false;
            this.btnFilterCouponImport.Click += new System.EventHandler(this.btnFilterCouponImport_Click);
            // 
            // btnSearchCouponImport
            // 
            this.btnSearchCouponImport.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSearchCouponImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(36)))), ((int)(((byte)(210)))));
            this.btnSearchCouponImport.FlatAppearance.BorderSize = 0;
            this.btnSearchCouponImport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(18)))), ((int)(((byte)(167)))));
            this.btnSearchCouponImport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(36)))), ((int)(((byte)(210)))));
            this.btnSearchCouponImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchCouponImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchCouponImport.ForeColor = System.Drawing.Color.White;
            this.btnSearchCouponImport.Image = global::BaketyManagement.Properties.Resources.Search;
            this.btnSearchCouponImport.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSearchCouponImport.Location = new System.Drawing.Point(818, 16);
            this.btnSearchCouponImport.Name = "btnSearchCouponImport";
            this.btnSearchCouponImport.Size = new System.Drawing.Size(150, 70);
            this.btnSearchCouponImport.TabIndex = 4;
            this.btnSearchCouponImport.Text = "Tìm";
            this.btnSearchCouponImport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSearchCouponImport.UseVisualStyleBackColor = false;
            this.btnSearchCouponImport.Click += new System.EventHandler(this.btnSearchCouponImport_Click);
            // 
            // btnDisplayCouponImport
            // 
            this.btnDisplayCouponImport.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDisplayCouponImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(159)))), ((int)(((byte)(56)))));
            this.btnDisplayCouponImport.FlatAppearance.BorderSize = 0;
            this.btnDisplayCouponImport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(126)))), ((int)(((byte)(38)))));
            this.btnDisplayCouponImport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(159)))), ((int)(((byte)(56)))));
            this.btnDisplayCouponImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisplayCouponImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayCouponImport.ForeColor = System.Drawing.Color.White;
            this.btnDisplayCouponImport.Image = global::BaketyManagement.Properties.Resources.Display;
            this.btnDisplayCouponImport.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDisplayCouponImport.Location = new System.Drawing.Point(1008, 16);
            this.btnDisplayCouponImport.Name = "btnDisplayCouponImport";
            this.btnDisplayCouponImport.Size = new System.Drawing.Size(150, 70);
            this.btnDisplayCouponImport.TabIndex = 1;
            this.btnDisplayCouponImport.Text = "Xem";
            this.btnDisplayCouponImport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDisplayCouponImport.UseVisualStyleBackColor = false;
            this.btnDisplayCouponImport.Click += new System.EventHandler(this.btnDisplayCouponImport_Click);
            // 
            // groupBox30
            // 
            this.groupBox30.BackColor = System.Drawing.Color.White;
            this.groupBox30.Controls.Add(this.pnFunctionImport);
            this.groupBox30.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox30.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.groupBox30.Location = new System.Drawing.Point(0, 0);
            this.groupBox30.Name = "groupBox30";
            this.groupBox30.Size = new System.Drawing.Size(1197, 230);
            this.groupBox30.TabIndex = 1;
            this.groupBox30.TabStop = false;
            this.groupBox30.Text = "Chức năng";
            // 
            // pnFunctionImport
            // 
            this.pnFunctionImport.BackColor = System.Drawing.Color.White;
            this.pnFunctionImport.Controls.Add(this.dtpEndImportDay);
            this.pnFunctionImport.Controls.Add(this.dtpStartImportDay);
            this.pnFunctionImport.Controls.Add(this.label36);
            this.pnFunctionImport.Controls.Add(this.label41);
            this.pnFunctionImport.Controls.Add(this.label42);
            this.pnFunctionImport.Controls.Add(this.label43);
            this.pnFunctionImport.Controls.Add(this.txtSearchImportCoupon);
            this.pnFunctionImport.Controls.Add(this.btnFilterCouponImport);
            this.pnFunctionImport.Controls.Add(this.btnSearchCouponImport);
            this.pnFunctionImport.Controls.Add(this.btnDisplayCouponImport);
            this.pnFunctionImport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnFunctionImport.Location = new System.Drawing.Point(3, 22);
            this.pnFunctionImport.Name = "pnFunctionImport";
            this.pnFunctionImport.Size = new System.Drawing.Size(1191, 205);
            this.pnFunctionImport.TabIndex = 0;
            // 
            // groupBox29
            // 
            this.groupBox29.BackColor = System.Drawing.Color.White;
            this.groupBox29.Controls.Add(this.panel37);
            this.groupBox29.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox29.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox29.Location = new System.Drawing.Point(0, 0);
            this.groupBox29.Name = "groupBox29";
            this.groupBox29.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox29.Size = new System.Drawing.Size(569, 382);
            this.groupBox29.TabIndex = 1;
            this.groupBox29.TabStop = false;
            this.groupBox29.Text = "Chi tiết phiếu nhập";
            // 
            // panel37
            // 
            this.panel37.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.panel37.Controls.Add(this.dgvDetailCouponImport);
            this.panel37.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel37.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel37.Location = new System.Drawing.Point(0, 19);
            this.panel37.Name = "panel37";
            this.panel37.Size = new System.Drawing.Size(569, 363);
            this.panel37.TabIndex = 0;
            // 
            // dgvDetailCouponImport
            // 
            this.dgvDetailCouponImport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetailCouponImport.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetailCouponImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetailCouponImport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetailCouponImport.Location = new System.Drawing.Point(0, 0);
            this.dgvDetailCouponImport.MultiSelect = false;
            this.dgvDetailCouponImport.Name = "dgvDetailCouponImport";
            this.dgvDetailCouponImport.ReadOnly = true;
            this.dgvDetailCouponImport.RowHeadersWidth = 51;
            this.dgvDetailCouponImport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetailCouponImport.Size = new System.Drawing.Size(569, 363);
            this.dgvDetailCouponImport.TabIndex = 0;
            // 
            // tlpCoupon
            // 
            this.tlpCoupon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.tlpCoupon.ColumnCount = 1;
            this.tlpCoupon.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCoupon.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpCoupon.Controls.Add(this.panel3, 0, 1);
            this.tlpCoupon.Controls.Add(this.tableLayoutPanel13, 0, 0);
            this.tlpCoupon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCoupon.Location = new System.Drawing.Point(0, 0);
            this.tlpCoupon.Name = "tlpCoupon";
            this.tlpCoupon.Padding = new System.Windows.Forms.Padding(10);
            this.tlpCoupon.RowCount = 2;
            this.tlpCoupon.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCoupon.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tlpCoupon.Size = new System.Drawing.Size(1237, 712);
            this.tlpCoupon.TabIndex = 2;
            this.tlpCoupon.Paint += new System.Windows.Forms.PaintEventHandler(this.tlpCoupon_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox30);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(20, 462);
            this.panel3.Margin = new System.Windows.Forms.Padding(10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1197, 230);
            this.panel3.TabIndex = 1;
            // 
            // tableLayoutPanel13
            // 
            this.tableLayoutPanel13.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel13.ColumnCount = 2;
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel13.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel13.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel13.Location = new System.Drawing.Point(20, 20);
            this.tableLayoutPanel13.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel13.Name = "tableLayoutPanel13";
            this.tableLayoutPanel13.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel13.RowCount = 1;
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 551F));
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 551F));
            this.tableLayoutPanel13.Size = new System.Drawing.Size(1197, 422);
            this.tableLayoutPanel13.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox28);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 20);
            this.panel1.Margin = new System.Windows.Forms.Padding(10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 382);
            this.panel1.TabIndex = 2;
            // 
            // groupBox28
            // 
            this.groupBox28.BackColor = System.Drawing.Color.White;
            this.groupBox28.Controls.Add(this.panel35);
            this.groupBox28.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox28.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox28.Location = new System.Drawing.Point(0, 0);
            this.groupBox28.Name = "groupBox28";
            this.groupBox28.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox28.Size = new System.Drawing.Size(568, 382);
            this.groupBox28.TabIndex = 0;
            this.groupBox28.TabStop = false;
            this.groupBox28.Text = "Danh sách phiếu nhập";
            // 
            // panel35
            // 
            this.panel35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.panel35.Controls.Add(this.dgvCouponImport);
            this.panel35.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel35.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel35.Location = new System.Drawing.Point(0, 19);
            this.panel35.Name = "panel35";
            this.panel35.Size = new System.Drawing.Size(568, 363);
            this.panel35.TabIndex = 0;
            // 
            // dgvCouponImport
            // 
            this.dgvCouponImport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCouponImport.BackgroundColor = System.Drawing.Color.White;
            this.dgvCouponImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCouponImport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCouponImport.Location = new System.Drawing.Point(0, 0);
            this.dgvCouponImport.MultiSelect = false;
            this.dgvCouponImport.Name = "dgvCouponImport";
            this.dgvCouponImport.ReadOnly = true;
            this.dgvCouponImport.RowHeadersWidth = 51;
            this.dgvCouponImport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCouponImport.Size = new System.Drawing.Size(568, 363);
            this.dgvCouponImport.TabIndex = 0;
            this.dgvCouponImport.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCouponImport_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox29);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(608, 20);
            this.panel2.Margin = new System.Windows.Forms.Padding(10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(569, 382);
            this.panel2.TabIndex = 3;
            // 
            // FrmImportCoupon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 712);
            this.Controls.Add(this.tlpCoupon);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmImportCoupon";
            this.Text = "FrmImportCoupon";
            this.Load += new System.EventHandler(this.FrmImportCoupon_Load);
            this.groupBox30.ResumeLayout(false);
            this.pnFunctionImport.ResumeLayout(false);
            this.pnFunctionImport.PerformLayout();
            this.groupBox29.ResumeLayout(false);
            this.panel37.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailCouponImport)).EndInit();
            this.tlpCoupon.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel13.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox28.ResumeLayout(false);
            this.panel35.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCouponImport)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpEndImportDay;
        private System.Windows.Forms.DateTimePicker dtpStartImportDay;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.TextBox txtSearchImportCoupon;
        private System.Windows.Forms.Button btnFilterCouponImport;
        private System.Windows.Forms.Button btnSearchCouponImport;
        private System.Windows.Forms.Button btnDisplayCouponImport;
        private System.Windows.Forms.GroupBox groupBox30;
        private System.Windows.Forms.Panel pnFunctionImport;
        private System.Windows.Forms.GroupBox groupBox29;
        private System.Windows.Forms.Panel panel37;
        private System.Windows.Forms.DataGridView dgvDetailCouponImport;
        private System.Windows.Forms.TableLayoutPanel tlpCoupon;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel13;
        private System.Windows.Forms.GroupBox groupBox28;
        private System.Windows.Forms.Panel panel35;
        private System.Windows.Forms.DataGridView dgvCouponImport;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}