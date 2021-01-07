
namespace BaketyManagement.View.Forms
{
    partial class FrmBill
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
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDay = new System.Windows.Forms.DateTimePicker();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txtSearchKeyBill = new System.Windows.Forms.TextBox();
            this.btnFilterBill = new System.Windows.Forms.Button();
            this.btnSearchBill = new System.Windows.Forms.Button();
            this.btnViewBill = new System.Windows.Forms.Button();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.panel14 = new System.Windows.Forms.Panel();
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.panel15 = new System.Windows.Forms.Panel();
            this.dgvBillDetail = new System.Windows.Forms.DataGridView();
            this.tlbBill = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.pnFunctionBill = new System.Windows.Forms.Panel();
            this.tableLayoutPanel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillDetail)).BeginInit();
            this.tlbBill.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.pnFunctionBill.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpEndDate.CustomFormat = "dd/MM/yyyy";
            this.dtpEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(279, 161);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(433, 26);
            this.dtpEndDate.TabIndex = 7;
            // 
            // dtpStartDay
            // 
            this.dtpStartDay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpStartDay.CustomFormat = "dd/MM/yyyy";
            this.dtpStartDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDay.Location = new System.Drawing.Point(279, 117);
            this.dtpStartDay.Name = "dtpStartDay";
            this.dtpStartDay.Size = new System.Drawing.Size(433, 26);
            this.dtpStartDay.TabIndex = 7;
            // 
            // label26
            // 
            this.label26.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.label26.Location = new System.Drawing.Point(140, 167);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(119, 20);
            this.label26.TabIndex = 6;
            this.label26.Text = "Ngày kết thúc";
            // 
            // label25
            // 
            this.label25.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.label25.Location = new System.Drawing.Point(144, 122);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(115, 20);
            this.label25.TabIndex = 6;
            this.label25.Text = "Ngày bắt đầu";
            // 
            // label24
            // 
            this.label24.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.label24.Location = new System.Drawing.Point(14, 89);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(192, 20);
            this.label24.TabIndex = 6;
            this.label24.Text = "Lọc hóa đơn theo ngày";
            // 
            // label23
            // 
            this.label23.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.label23.Location = new System.Drawing.Point(14, 42);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(261, 20);
            this.label23.TabIndex = 6;
            this.label23.Text = "Tìm hóa đơn theo tên nhân viên";
            // 
            // txtSearchKeyBill
            // 
            this.txtSearchKeyBill.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSearchKeyBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchKeyBill.Location = new System.Drawing.Point(279, 42);
            this.txtSearchKeyBill.Name = "txtSearchKeyBill";
            this.txtSearchKeyBill.Size = new System.Drawing.Size(433, 26);
            this.txtSearchKeyBill.TabIndex = 5;
            // 
            // btnFilterBill
            // 
            this.btnFilterBill.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnFilterBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(137)))));
            this.btnFilterBill.FlatAppearance.BorderSize = 0;
            this.btnFilterBill.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(109)))));
            this.btnFilterBill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(137)))));
            this.btnFilterBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilterBill.Image = global::BaketyManagement.Properties.Resources.filter;
            this.btnFilterBill.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFilterBill.Location = new System.Drawing.Point(740, 117);
            this.btnFilterBill.Name = "btnFilterBill";
            this.btnFilterBill.Size = new System.Drawing.Size(150, 70);
            this.btnFilterBill.TabIndex = 4;
            this.btnFilterBill.Text = "Lọc";
            this.btnFilterBill.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFilterBill.UseVisualStyleBackColor = false;
            this.btnFilterBill.Click += new System.EventHandler(this.btnFilterBill_Click);
            // 
            // btnSearchBill
            // 
            this.btnSearchBill.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSearchBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(36)))), ((int)(((byte)(210)))));
            this.btnSearchBill.FlatAppearance.BorderSize = 0;
            this.btnSearchBill.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(18)))), ((int)(((byte)(167)))));
            this.btnSearchBill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(36)))), ((int)(((byte)(210)))));
            this.btnSearchBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchBill.Image = global::BaketyManagement.Properties.Resources.Search;
            this.btnSearchBill.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSearchBill.Location = new System.Drawing.Point(740, 18);
            this.btnSearchBill.Name = "btnSearchBill";
            this.btnSearchBill.Size = new System.Drawing.Size(150, 70);
            this.btnSearchBill.TabIndex = 4;
            this.btnSearchBill.Text = "Tìm";
            this.btnSearchBill.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSearchBill.UseVisualStyleBackColor = false;
            this.btnSearchBill.Click += new System.EventHandler(this.btnSearchBill_Click);
            // 
            // btnViewBill
            // 
            this.btnViewBill.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnViewBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(159)))), ((int)(((byte)(56)))));
            this.btnViewBill.FlatAppearance.BorderSize = 0;
            this.btnViewBill.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(126)))), ((int)(((byte)(38)))));
            this.btnViewBill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(159)))), ((int)(((byte)(56)))));
            this.btnViewBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewBill.Image = global::BaketyManagement.Properties.Resources.Display;
            this.btnViewBill.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnViewBill.Location = new System.Drawing.Point(911, 18);
            this.btnViewBill.Name = "btnViewBill";
            this.btnViewBill.Size = new System.Drawing.Size(150, 70);
            this.btnViewBill.TabIndex = 1;
            this.btnViewBill.Text = "Xem";
            this.btnViewBill.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnViewBill.UseVisualStyleBackColor = false;
            this.btnViewBill.Click += new System.EventHandler(this.btnViewBill_Click);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(20, 20);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 294F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 294F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(1080, 294);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(520, 274);
            this.panel1.TabIndex = 2;
            // 
            // groupBox9
            // 
            this.groupBox9.BackColor = System.Drawing.Color.White;
            this.groupBox9.Controls.Add(this.panel14);
            this.groupBox9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.groupBox9.Location = new System.Drawing.Point(0, 0);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox9.Size = new System.Drawing.Size(520, 274);
            this.groupBox9.TabIndex = 0;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Danh sách hóa đơn";
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.panel14.Controls.Add(this.dgvBill);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel14.ForeColor = System.Drawing.Color.Black;
            this.panel14.Location = new System.Drawing.Point(0, 19);
            this.panel14.Name = "panel14";
            this.panel14.Padding = new System.Windows.Forms.Padding(3);
            this.panel14.Size = new System.Drawing.Size(520, 255);
            this.panel14.TabIndex = 0;
            // 
            // dgvBill
            // 
            this.dgvBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBill.BackgroundColor = System.Drawing.Color.White;
            this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBill.Location = new System.Drawing.Point(3, 3);
            this.dgvBill.Margin = new System.Windows.Forms.Padding(0);
            this.dgvBill.MultiSelect = false;
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.ReadOnly = true;
            this.dgvBill.RowHeadersWidth = 51;
            this.dgvBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBill.Size = new System.Drawing.Size(514, 249);
            this.dgvBill.TabIndex = 0;
            this.dgvBill.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBill_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox10);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(550, 10);
            this.panel2.Margin = new System.Windows.Forms.Padding(10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(520, 274);
            this.panel2.TabIndex = 3;
            // 
            // groupBox10
            // 
            this.groupBox10.BackColor = System.Drawing.Color.White;
            this.groupBox10.Controls.Add(this.panel15);
            this.groupBox10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.groupBox10.Location = new System.Drawing.Point(0, 0);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox10.Size = new System.Drawing.Size(520, 274);
            this.groupBox10.TabIndex = 1;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Chi tiết hóa đơn";
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.dgvBillDetail);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel15.ForeColor = System.Drawing.Color.Black;
            this.panel15.Location = new System.Drawing.Point(0, 19);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(520, 255);
            this.panel15.TabIndex = 0;
            // 
            // dgvBillDetail
            // 
            this.dgvBillDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBillDetail.BackgroundColor = System.Drawing.Color.White;
            this.dgvBillDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBillDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBillDetail.Location = new System.Drawing.Point(0, 0);
            this.dgvBillDetail.Margin = new System.Windows.Forms.Padding(10);
            this.dgvBillDetail.MultiSelect = false;
            this.dgvBillDetail.Name = "dgvBillDetail";
            this.dgvBillDetail.ReadOnly = true;
            this.dgvBillDetail.RowHeadersWidth = 51;
            this.dgvBillDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBillDetail.Size = new System.Drawing.Size(520, 255);
            this.dgvBillDetail.TabIndex = 0;
            // 
            // tlbBill
            // 
            this.tlbBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.tlbBill.ColumnCount = 1;
            this.tlbBill.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlbBill.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tlbBill.Controls.Add(this.panel4, 0, 1);
            this.tlbBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlbBill.Location = new System.Drawing.Point(0, 0);
            this.tlbBill.Name = "tlbBill";
            this.tlbBill.Padding = new System.Windows.Forms.Padding(10);
            this.tlbBill.RowCount = 2;
            this.tlbBill.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlbBill.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tlbBill.Size = new System.Drawing.Size(1120, 584);
            this.tlbBill.TabIndex = 1;
            this.tlbBill.Paint += new System.Windows.Forms.PaintEventHandler(this.tlbBill_Paint);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox11);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(20, 334);
            this.panel4.Margin = new System.Windows.Forms.Padding(10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1080, 230);
            this.panel4.TabIndex = 1;
            // 
            // groupBox11
            // 
            this.groupBox11.BackColor = System.Drawing.Color.White;
            this.groupBox11.Controls.Add(this.pnFunctionBill);
            this.groupBox11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.groupBox11.Location = new System.Drawing.Point(0, 0);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(1080, 230);
            this.groupBox11.TabIndex = 1;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Chức năng";
            // 
            // pnFunctionBill
            // 
            this.pnFunctionBill.BackColor = System.Drawing.Color.White;
            this.pnFunctionBill.Controls.Add(this.dtpEndDate);
            this.pnFunctionBill.Controls.Add(this.dtpStartDay);
            this.pnFunctionBill.Controls.Add(this.label26);
            this.pnFunctionBill.Controls.Add(this.label25);
            this.pnFunctionBill.Controls.Add(this.label24);
            this.pnFunctionBill.Controls.Add(this.label23);
            this.pnFunctionBill.Controls.Add(this.txtSearchKeyBill);
            this.pnFunctionBill.Controls.Add(this.btnFilterBill);
            this.pnFunctionBill.Controls.Add(this.btnSearchBill);
            this.pnFunctionBill.Controls.Add(this.btnViewBill);
            this.pnFunctionBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnFunctionBill.ForeColor = System.Drawing.Color.White;
            this.pnFunctionBill.Location = new System.Drawing.Point(3, 22);
            this.pnFunctionBill.Name = "pnFunctionBill";
            this.pnFunctionBill.Size = new System.Drawing.Size(1074, 205);
            this.pnFunctionBill.TabIndex = 0;
            // 
            // FrmBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 584);
            this.Controls.Add(this.tlbBill);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmBill";
            this.Text = "FrmBill";
            this.Load += new System.EventHandler(this.FrmBill_Load);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillDetail)).EndInit();
            this.tlbBill.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.pnFunctionBill.ResumeLayout(false);
            this.pnFunctionBill.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDay;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtSearchKeyBill;
        private System.Windows.Forms.Button btnFilterBill;
        private System.Windows.Forms.Button btnSearchBill;
        private System.Windows.Forms.Button btnViewBill;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.DataGridView dgvBill;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.DataGridView dgvBillDetail;
        private System.Windows.Forms.TableLayoutPanel tlbBill;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Panel pnFunctionBill;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
    }
}