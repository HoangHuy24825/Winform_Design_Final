
namespace BaketyManagement.View.Forms
{
    partial class FrmStaff
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
            this.tlpStaff = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvStaff = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.btnDisplayStaff = new System.Windows.Forms.Button();
            this.btnEditStaff = new System.Windows.Forms.Button();
            this.btnDeleteStaff = new System.Windows.Forms.Button();
            this.txtStaffSearch = new System.Windows.Forms.TextBox();
            this.btnStaffSearch = new System.Windows.Forms.Button();
            this.pnFunctionStaff = new System.Windows.Forms.Panel();
            this.tlpStaff.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            this.panel6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.pnFunctionStaff.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpStaff
            // 
            this.tlpStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.tlpStaff.ColumnCount = 1;
            this.tlpStaff.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpStaff.Controls.Add(this.panel5, 0, 0);
            this.tlpStaff.Controls.Add(this.panel6, 0, 1);
            this.tlpStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpStaff.Location = new System.Drawing.Point(0, 0);
            this.tlpStaff.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.tlpStaff.Name = "tlpStaff";
            this.tlpStaff.Padding = new System.Windows.Forms.Padding(18, 20, 18, 20);
            this.tlpStaff.RowCount = 2;
            this.tlpStaff.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpStaff.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tlpStaff.Size = new System.Drawing.Size(1138, 493);
            this.tlpStaff.TabIndex = 2;
            this.tlpStaff.Paint += new System.Windows.Forms.PaintEventHandler(this.tlpStaff_Paint);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.groupBox1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(36, 40);
            this.panel5.Margin = new System.Windows.Forms.Padding(18, 20, 18, 20);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1066, 113);
            this.panel5.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1066, 113);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách nhân viên";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvStaff);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(3, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1060, 88);
            this.panel1.TabIndex = 0;
            // 
            // dgvStaff
            // 
            this.dgvStaff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStaff.BackgroundColor = System.Drawing.Color.White;
            this.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStaff.Location = new System.Drawing.Point(0, 0);
            this.dgvStaff.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.dgvStaff.MultiSelect = false;
            this.dgvStaff.Name = "dgvStaff";
            this.dgvStaff.ReadOnly = true;
            this.dgvStaff.RowHeadersWidth = 51;
            this.dgvStaff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStaff.Size = new System.Drawing.Size(1060, 88);
            this.dgvStaff.TabIndex = 1;
            this.dgvStaff.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStaff_CellClick);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.groupBox4);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(36, 193);
            this.panel6.Margin = new System.Windows.Forms.Padding(18, 20, 18, 20);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1066, 260);
            this.panel6.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.pnFunctionStaff);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.groupBox4.Size = new System.Drawing.Size(1066, 260);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chức năng";
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.label21.Location = new System.Drawing.Point(32, 68);
            this.label21.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(151, 20);
            this.label21.TabIndex = 2;
            this.label21.Text = "Tìm kiếm theo tên";
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(140)))), ((int)(((byte)(36)))));
            this.btnAddStaff.FlatAppearance.BorderSize = 0;
            this.btnAddStaff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(107)))), ((int)(((byte)(18)))));
            this.btnAddStaff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(140)))), ((int)(((byte)(36)))));
            this.btnAddStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStaff.ForeColor = System.Drawing.Color.White;
            this.btnAddStaff.Image = global::BaketyManagement.Properties.Resources.Add;
            this.btnAddStaff.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddStaff.Location = new System.Drawing.Point(313, 137);
            this.btnAddStaff.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(150, 70);
            this.btnAddStaff.TabIndex = 0;
            this.btnAddStaff.Text = "Thêm";
            this.btnAddStaff.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddStaff.UseVisualStyleBackColor = false;
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // btnDisplayStaff
            // 
            this.btnDisplayStaff.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDisplayStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(159)))), ((int)(((byte)(56)))));
            this.btnDisplayStaff.FlatAppearance.BorderSize = 0;
            this.btnDisplayStaff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(126)))), ((int)(((byte)(38)))));
            this.btnDisplayStaff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(159)))), ((int)(((byte)(56)))));
            this.btnDisplayStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisplayStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayStaff.ForeColor = System.Drawing.Color.White;
            this.btnDisplayStaff.Image = global::BaketyManagement.Properties.Resources.Display;
            this.btnDisplayStaff.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDisplayStaff.Location = new System.Drawing.Point(36, 137);
            this.btnDisplayStaff.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.btnDisplayStaff.Name = "btnDisplayStaff";
            this.btnDisplayStaff.Size = new System.Drawing.Size(150, 70);
            this.btnDisplayStaff.TabIndex = 0;
            this.btnDisplayStaff.Text = "Xem";
            this.btnDisplayStaff.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDisplayStaff.UseVisualStyleBackColor = false;
            this.btnDisplayStaff.Click += new System.EventHandler(this.btnDisplayStaff_Click);
            // 
            // btnEditStaff
            // 
            this.btnEditStaff.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEditStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(137)))));
            this.btnEditStaff.FlatAppearance.BorderSize = 0;
            this.btnEditStaff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(109)))));
            this.btnEditStaff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(137)))));
            this.btnEditStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditStaff.ForeColor = System.Drawing.Color.White;
            this.btnEditStaff.Image = global::BaketyManagement.Properties.Resources.Edit;
            this.btnEditStaff.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditStaff.Location = new System.Drawing.Point(590, 137);
            this.btnEditStaff.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.btnEditStaff.Name = "btnEditStaff";
            this.btnEditStaff.Size = new System.Drawing.Size(150, 70);
            this.btnEditStaff.TabIndex = 0;
            this.btnEditStaff.Text = "Sửa";
            this.btnEditStaff.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditStaff.UseVisualStyleBackColor = false;
            this.btnEditStaff.Click += new System.EventHandler(this.btnEditStaff_Click);
            // 
            // btnDeleteStaff
            // 
            this.btnDeleteStaff.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDeleteStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(52)))), ((int)(((byte)(36)))));
            this.btnDeleteStaff.FlatAppearance.BorderSize = 0;
            this.btnDeleteStaff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(32)))), ((int)(((byte)(18)))));
            this.btnDeleteStaff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(52)))), ((int)(((byte)(36)))));
            this.btnDeleteStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteStaff.ForeColor = System.Drawing.Color.White;
            this.btnDeleteStaff.Image = global::BaketyManagement.Properties.Resources.Delete;
            this.btnDeleteStaff.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDeleteStaff.Location = new System.Drawing.Point(867, 137);
            this.btnDeleteStaff.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.btnDeleteStaff.Name = "btnDeleteStaff";
            this.btnDeleteStaff.Size = new System.Drawing.Size(150, 70);
            this.btnDeleteStaff.TabIndex = 0;
            this.btnDeleteStaff.Text = "Xóa";
            this.btnDeleteStaff.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDeleteStaff.UseVisualStyleBackColor = false;
            this.btnDeleteStaff.Click += new System.EventHandler(this.btnDeleteStaff_Click);
            // 
            // txtStaffSearch
            // 
            this.txtStaffSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtStaffSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffSearch.ForeColor = System.Drawing.Color.Black;
            this.txtStaffSearch.Location = new System.Drawing.Point(201, 65);
            this.txtStaffSearch.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.txtStaffSearch.Name = "txtStaffSearch";
            this.txtStaffSearch.Size = new System.Drawing.Size(618, 26);
            this.txtStaffSearch.TabIndex = 1;
            // 
            // btnStaffSearch
            // 
            this.btnStaffSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnStaffSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(36)))), ((int)(((byte)(210)))));
            this.btnStaffSearch.FlatAppearance.BorderSize = 0;
            this.btnStaffSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(18)))), ((int)(((byte)(167)))));
            this.btnStaffSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(36)))), ((int)(((byte)(210)))));
            this.btnStaffSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaffSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaffSearch.ForeColor = System.Drawing.Color.White;
            this.btnStaffSearch.Image = global::BaketyManagement.Properties.Resources.Search;
            this.btnStaffSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnStaffSearch.Location = new System.Drawing.Point(867, 34);
            this.btnStaffSearch.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.btnStaffSearch.Name = "btnStaffSearch";
            this.btnStaffSearch.Size = new System.Drawing.Size(150, 70);
            this.btnStaffSearch.TabIndex = 0;
            this.btnStaffSearch.Text = "Tìm";
            this.btnStaffSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStaffSearch.UseVisualStyleBackColor = false;
            this.btnStaffSearch.Click += new System.EventHandler(this.btnStaffSearch_Click);
            // 
            // pnFunctionStaff
            // 
            this.pnFunctionStaff.Controls.Add(this.label21);
            this.pnFunctionStaff.Controls.Add(this.btnAddStaff);
            this.pnFunctionStaff.Controls.Add(this.btnStaffSearch);
            this.pnFunctionStaff.Controls.Add(this.btnDisplayStaff);
            this.pnFunctionStaff.Controls.Add(this.txtStaffSearch);
            this.pnFunctionStaff.Controls.Add(this.btnEditStaff);
            this.pnFunctionStaff.Controls.Add(this.btnDeleteStaff);
            this.pnFunctionStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnFunctionStaff.Location = new System.Drawing.Point(9, 19);
            this.pnFunctionStaff.Name = "pnFunctionStaff";
            this.pnFunctionStaff.Size = new System.Drawing.Size(1048, 241);
            this.pnFunctionStaff.TabIndex = 2;
            // 
            // FrmStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 493);
            this.Controls.Add(this.tlpStaff);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.Name = "FrmStaff";
            this.Text = "FrmStaff";
            this.Load += new System.EventHandler(this.FrmStaff_Load);
            this.tlpStaff.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            this.panel6.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.pnFunctionStaff.ResumeLayout(false);
            this.pnFunctionStaff.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpStaff;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnAddStaff;
        private System.Windows.Forms.Button btnDisplayStaff;
        private System.Windows.Forms.Button btnEditStaff;
        private System.Windows.Forms.Button btnDeleteStaff;
        private System.Windows.Forms.TextBox txtStaffSearch;
        private System.Windows.Forms.Button btnStaffSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvStaff;
        private System.Windows.Forms.Panel pnFunctionStaff;
    }
}