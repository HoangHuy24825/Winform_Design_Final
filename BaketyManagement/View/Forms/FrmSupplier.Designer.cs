
namespace BaketyManagement.View.Forms
{
    partial class FrmSupplier
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
            this.tlpSupplier = new System.Windows.Forms.TableLayoutPanel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvSupplier = new System.Windows.Forms.DataGridView();
            this.panel12 = new System.Windows.Forms.Panel();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnAddSupplier = new System.Windows.Forms.Button();
            this.btnEditSupplier = new System.Windows.Forms.Button();
            this.btnViewSupplier = new System.Windows.Forms.Button();
            this.btnDelSupplier = new System.Windows.Forms.Button();
            this.txtSearchKeySupplier = new System.Windows.Forms.TextBox();
            this.btnSearchSupplier = new System.Windows.Forms.Button();
            this.pnFunctionSupplier = new System.Windows.Forms.Panel();
            this.tlpSupplier.SuspendLayout();
            this.panel11.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).BeginInit();
            this.panel12.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.pnFunctionSupplier.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpSupplier
            // 
            this.tlpSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.tlpSupplier.ColumnCount = 1;
            this.tlpSupplier.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSupplier.Controls.Add(this.panel11, 0, 0);
            this.tlpSupplier.Controls.Add(this.panel12, 0, 1);
            this.tlpSupplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSupplier.Location = new System.Drawing.Point(0, 0);
            this.tlpSupplier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tlpSupplier.Name = "tlpSupplier";
            this.tlpSupplier.Padding = new System.Windows.Forms.Padding(15);
            this.tlpSupplier.RowCount = 2;
            this.tlpSupplier.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSupplier.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tlpSupplier.Size = new System.Drawing.Size(1191, 482);
            this.tlpSupplier.TabIndex = 4;
            this.tlpSupplier.Paint += new System.Windows.Forms.PaintEventHandler(this.tlpSupplier_Paint);
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.groupBox1);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel11.Location = new System.Drawing.Point(30, 30);
            this.panel11.Margin = new System.Windows.Forms.Padding(15);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1131, 122);
            this.panel11.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1131, 122);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách các nhà cung cấp";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvSupplier);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(3, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1125, 97);
            this.panel1.TabIndex = 0;
            // 
            // dgvSupplier
            // 
            this.dgvSupplier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSupplier.BackgroundColor = System.Drawing.Color.White;
            this.dgvSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSupplier.Location = new System.Drawing.Point(0, 0);
            this.dgvSupplier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvSupplier.MultiSelect = false;
            this.dgvSupplier.Name = "dgvSupplier";
            this.dgvSupplier.ReadOnly = true;
            this.dgvSupplier.RowHeadersWidth = 51;
            this.dgvSupplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSupplier.Size = new System.Drawing.Size(1125, 97);
            this.dgvSupplier.TabIndex = 1;
            this.dgvSupplier.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSupplier_CellClick);
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.groupBox8);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Location = new System.Drawing.Point(30, 182);
            this.panel12.Margin = new System.Windows.Forms.Padding(15);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(1131, 270);
            this.panel12.TabIndex = 2;
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.Color.White;
            this.groupBox8.Controls.Add(this.pnFunctionSupplier);
            this.groupBox8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.groupBox8.Location = new System.Drawing.Point(0, 0);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox8.Size = new System.Drawing.Size(1131, 270);
            this.groupBox8.TabIndex = 0;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Chức năng";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.label16.Location = new System.Drawing.Point(38, 62);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(264, 20);
            this.label16.TabIndex = 3;
            this.label16.Text = "Tìm kiếm theo tên nhà cung cấp";
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(140)))), ((int)(((byte)(36)))));
            this.btnAddSupplier.FlatAppearance.BorderSize = 0;
            this.btnAddSupplier.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(107)))), ((int)(((byte)(18)))));
            this.btnAddSupplier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(140)))), ((int)(((byte)(36)))));
            this.btnAddSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSupplier.ForeColor = System.Drawing.Color.White;
            this.btnAddSupplier.Image = global::BaketyManagement.Properties.Resources.Add;
            this.btnAddSupplier.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddSupplier.Location = new System.Drawing.Point(343, 138);
            this.btnAddSupplier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(150, 70);
            this.btnAddSupplier.TabIndex = 2;
            this.btnAddSupplier.Text = "Thêm";
            this.btnAddSupplier.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddSupplier.UseVisualStyleBackColor = false;
            this.btnAddSupplier.Click += new System.EventHandler(this.btnAddSupplier_Click);
            // 
            // btnEditSupplier
            // 
            this.btnEditSupplier.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEditSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(137)))));
            this.btnEditSupplier.FlatAppearance.BorderSize = 0;
            this.btnEditSupplier.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(109)))));
            this.btnEditSupplier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(137)))));
            this.btnEditSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditSupplier.ForeColor = System.Drawing.Color.White;
            this.btnEditSupplier.Image = global::BaketyManagement.Properties.Resources.Edit;
            this.btnEditSupplier.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditSupplier.Location = new System.Drawing.Point(644, 138);
            this.btnEditSupplier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditSupplier.Name = "btnEditSupplier";
            this.btnEditSupplier.Size = new System.Drawing.Size(150, 70);
            this.btnEditSupplier.TabIndex = 0;
            this.btnEditSupplier.Text = "Sửa";
            this.btnEditSupplier.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditSupplier.UseVisualStyleBackColor = false;
            this.btnEditSupplier.Click += new System.EventHandler(this.btnEditSupplier_Click);
            // 
            // btnViewSupplier
            // 
            this.btnViewSupplier.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnViewSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(159)))), ((int)(((byte)(56)))));
            this.btnViewSupplier.FlatAppearance.BorderSize = 0;
            this.btnViewSupplier.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(126)))), ((int)(((byte)(38)))));
            this.btnViewSupplier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(159)))), ((int)(((byte)(56)))));
            this.btnViewSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewSupplier.ForeColor = System.Drawing.Color.White;
            this.btnViewSupplier.Image = global::BaketyManagement.Properties.Resources.Display;
            this.btnViewSupplier.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnViewSupplier.Location = new System.Drawing.Point(42, 138);
            this.btnViewSupplier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnViewSupplier.Name = "btnViewSupplier";
            this.btnViewSupplier.Size = new System.Drawing.Size(150, 70);
            this.btnViewSupplier.TabIndex = 0;
            this.btnViewSupplier.Text = "Xem";
            this.btnViewSupplier.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnViewSupplier.UseVisualStyleBackColor = false;
            this.btnViewSupplier.Click += new System.EventHandler(this.btnViewSupplier_Click);
            // 
            // btnDelSupplier
            // 
            this.btnDelSupplier.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDelSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(52)))), ((int)(((byte)(36)))));
            this.btnDelSupplier.FlatAppearance.BorderSize = 0;
            this.btnDelSupplier.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(32)))), ((int)(((byte)(18)))));
            this.btnDelSupplier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(52)))), ((int)(((byte)(36)))));
            this.btnDelSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelSupplier.ForeColor = System.Drawing.Color.White;
            this.btnDelSupplier.Image = global::BaketyManagement.Properties.Resources.Delete;
            this.btnDelSupplier.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDelSupplier.Location = new System.Drawing.Point(934, 138);
            this.btnDelSupplier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelSupplier.Name = "btnDelSupplier";
            this.btnDelSupplier.Size = new System.Drawing.Size(150, 70);
            this.btnDelSupplier.TabIndex = 0;
            this.btnDelSupplier.Text = "Xóa";
            this.btnDelSupplier.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDelSupplier.UseVisualStyleBackColor = false;
            this.btnDelSupplier.Click += new System.EventHandler(this.btnDelSupplier_Click);
            // 
            // txtSearchKeySupplier
            // 
            this.txtSearchKeySupplier.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSearchKeySupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchKeySupplier.ForeColor = System.Drawing.Color.Black;
            this.txtSearchKeySupplier.Location = new System.Drawing.Point(310, 59);
            this.txtSearchKeySupplier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchKeySupplier.Name = "txtSearchKeySupplier";
            this.txtSearchKeySupplier.Size = new System.Drawing.Size(600, 26);
            this.txtSearchKeySupplier.TabIndex = 1;
            // 
            // btnSearchSupplier
            // 
            this.btnSearchSupplier.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSearchSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(36)))), ((int)(((byte)(210)))));
            this.btnSearchSupplier.FlatAppearance.BorderSize = 0;
            this.btnSearchSupplier.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(18)))), ((int)(((byte)(167)))));
            this.btnSearchSupplier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(36)))), ((int)(((byte)(210)))));
            this.btnSearchSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchSupplier.ForeColor = System.Drawing.Color.White;
            this.btnSearchSupplier.Image = global::BaketyManagement.Properties.Resources.Search;
            this.btnSearchSupplier.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSearchSupplier.Location = new System.Drawing.Point(934, 32);
            this.btnSearchSupplier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearchSupplier.Name = "btnSearchSupplier";
            this.btnSearchSupplier.Size = new System.Drawing.Size(150, 70);
            this.btnSearchSupplier.TabIndex = 0;
            this.btnSearchSupplier.Text = "Tìm";
            this.btnSearchSupplier.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSearchSupplier.UseVisualStyleBackColor = false;
            this.btnSearchSupplier.Click += new System.EventHandler(this.btnSearchSupplier_Click);
            // 
            // pnFunctionSupplier
            // 
            this.pnFunctionSupplier.Controls.Add(this.label16);
            this.pnFunctionSupplier.Controls.Add(this.txtSearchKeySupplier);
            this.pnFunctionSupplier.Controls.Add(this.btnAddSupplier);
            this.pnFunctionSupplier.Controls.Add(this.btnSearchSupplier);
            this.pnFunctionSupplier.Controls.Add(this.btnEditSupplier);
            this.pnFunctionSupplier.Controls.Add(this.btnDelSupplier);
            this.pnFunctionSupplier.Controls.Add(this.btnViewSupplier);
            this.pnFunctionSupplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnFunctionSupplier.Location = new System.Drawing.Point(4, 24);
            this.pnFunctionSupplier.Name = "pnFunctionSupplier";
            this.pnFunctionSupplier.Size = new System.Drawing.Size(1123, 241);
            this.pnFunctionSupplier.TabIndex = 2;
            // 
            // FrmSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 482);
            this.Controls.Add(this.tlpSupplier);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmSupplier";
            this.Text = "FrmSupplier";
            this.Load += new System.EventHandler(this.FrmSupplier_Load);
            this.tlpSupplier.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).EndInit();
            this.panel12.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.pnFunctionSupplier.ResumeLayout(false);
            this.pnFunctionSupplier.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpSupplier;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnAddSupplier;
        private System.Windows.Forms.Button btnEditSupplier;
        private System.Windows.Forms.Button btnViewSupplier;
        private System.Windows.Forms.Button btnDelSupplier;
        private System.Windows.Forms.TextBox txtSearchKeySupplier;
        private System.Windows.Forms.Button btnSearchSupplier;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvSupplier;
        private System.Windows.Forms.Panel pnFunctionSupplier;
    }
}