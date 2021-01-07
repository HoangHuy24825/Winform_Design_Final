
namespace BaketyManagement.View.Forms
{
    partial class FrmCategory
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
            this.tlpCategory = new System.Windows.Forms.TableLayoutPanel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvCategory = new System.Windows.Forms.DataGridView();
            this.panel19 = new System.Windows.Forms.Panel();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.pnFunctionCategory = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.txtCategorySearch = new System.Windows.Forms.TextBox();
            this.btnDisplayCategory = new System.Windows.Forms.Button();
            this.btnCategorySearch = new System.Windows.Forms.Button();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.btnEditCategory = new System.Windows.Forms.Button();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.tlpCategory.SuspendLayout();
            this.panel18.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).BeginInit();
            this.panel19.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.pnFunctionCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpCategory
            // 
            this.tlpCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.tlpCategory.ColumnCount = 1;
            this.tlpCategory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCategory.Controls.Add(this.panel18, 0, 0);
            this.tlpCategory.Controls.Add(this.panel19, 0, 1);
            this.tlpCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCategory.Location = new System.Drawing.Point(0, 0);
            this.tlpCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tlpCategory.Name = "tlpCategory";
            this.tlpCategory.Padding = new System.Windows.Forms.Padding(15);
            this.tlpCategory.RowCount = 2;
            this.tlpCategory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCategory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tlpCategory.Size = new System.Drawing.Size(1231, 501);
            this.tlpCategory.TabIndex = 2;
            this.tlpCategory.Paint += new System.Windows.Forms.PaintEventHandler(this.tlpCategory_Paint);
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.groupBox1);
            this.panel18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel18.Location = new System.Drawing.Point(30, 30);
            this.panel18.Margin = new System.Windows.Forms.Padding(15);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(1171, 141);
            this.panel18.TabIndex = 1;
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
            this.groupBox1.Size = new System.Drawing.Size(1171, 141);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách danh mục";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvCategory);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(3, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1165, 116);
            this.panel1.TabIndex = 0;
            // 
            // dgvCategory
            // 
            this.dgvCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategory.BackgroundColor = System.Drawing.Color.White;
            this.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCategory.Location = new System.Drawing.Point(0, 0);
            this.dgvCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvCategory.MultiSelect = false;
            this.dgvCategory.Name = "dgvCategory";
            this.dgvCategory.ReadOnly = true;
            this.dgvCategory.RowHeadersWidth = 51;
            this.dgvCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategory.Size = new System.Drawing.Size(1165, 116);
            this.dgvCategory.TabIndex = 2;
            this.dgvCategory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategory_CellClick);
            // 
            // panel19
            // 
            this.panel19.Controls.Add(this.groupBox14);
            this.panel19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel19.Location = new System.Drawing.Point(30, 201);
            this.panel19.Margin = new System.Windows.Forms.Padding(15);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(1171, 270);
            this.panel19.TabIndex = 2;
            // 
            // groupBox14
            // 
            this.groupBox14.BackColor = System.Drawing.Color.White;
            this.groupBox14.Controls.Add(this.pnFunctionCategory);
            this.groupBox14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.groupBox14.Location = new System.Drawing.Point(0, 0);
            this.groupBox14.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox14.Size = new System.Drawing.Size(1171, 270);
            this.groupBox14.TabIndex = 0;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Chức năng";
            // 
            // pnFunctionCategory
            // 
            this.pnFunctionCategory.Controls.Add(this.label15);
            this.pnFunctionCategory.Controls.Add(this.txtCategorySearch);
            this.pnFunctionCategory.Controls.Add(this.btnDisplayCategory);
            this.pnFunctionCategory.Controls.Add(this.btnCategorySearch);
            this.pnFunctionCategory.Controls.Add(this.btnDeleteCategory);
            this.pnFunctionCategory.Controls.Add(this.btnEditCategory);
            this.pnFunctionCategory.Controls.Add(this.btnAddCategory);
            this.pnFunctionCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnFunctionCategory.Location = new System.Drawing.Point(4, 24);
            this.pnFunctionCategory.Name = "pnFunctionCategory";
            this.pnFunctionCategory.Size = new System.Drawing.Size(1163, 241);
            this.pnFunctionCategory.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.label15.Location = new System.Drawing.Point(60, 61);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(234, 20);
            this.label15.TabIndex = 2;
            this.label15.Text = "Tìm kiếm theo tên danh mục";
            // 
            // txtCategorySearch
            // 
            this.txtCategorySearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCategorySearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategorySearch.ForeColor = System.Drawing.Color.Black;
            this.txtCategorySearch.Location = new System.Drawing.Point(312, 58);
            this.txtCategorySearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCategorySearch.Name = "txtCategorySearch";
            this.txtCategorySearch.Size = new System.Drawing.Size(600, 26);
            this.txtCategorySearch.TabIndex = 1;
            // 
            // btnDisplayCategory
            // 
            this.btnDisplayCategory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDisplayCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(159)))), ((int)(((byte)(56)))));
            this.btnDisplayCategory.FlatAppearance.BorderSize = 0;
            this.btnDisplayCategory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(126)))), ((int)(((byte)(38)))));
            this.btnDisplayCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(159)))), ((int)(((byte)(56)))));
            this.btnDisplayCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisplayCategory.ForeColor = System.Drawing.Color.White;
            this.btnDisplayCategory.Image = global::BaketyManagement.Properties.Resources.Display;
            this.btnDisplayCategory.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDisplayCategory.Location = new System.Drawing.Point(64, 142);
            this.btnDisplayCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDisplayCategory.Name = "btnDisplayCategory";
            this.btnDisplayCategory.Size = new System.Drawing.Size(150, 70);
            this.btnDisplayCategory.TabIndex = 0;
            this.btnDisplayCategory.Text = "Xem";
            this.btnDisplayCategory.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDisplayCategory.UseVisualStyleBackColor = false;
            this.btnDisplayCategory.Click += new System.EventHandler(this.btnDisplayCategory_Click);
            // 
            // btnCategorySearch
            // 
            this.btnCategorySearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCategorySearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(18)))), ((int)(((byte)(167)))));
            this.btnCategorySearch.FlatAppearance.BorderSize = 0;
            this.btnCategorySearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(36)))), ((int)(((byte)(210)))));
            this.btnCategorySearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(18)))), ((int)(((byte)(167)))));
            this.btnCategorySearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategorySearch.ForeColor = System.Drawing.Color.White;
            this.btnCategorySearch.Image = global::BaketyManagement.Properties.Resources.Search;
            this.btnCategorySearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCategorySearch.Location = new System.Drawing.Point(952, 28);
            this.btnCategorySearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCategorySearch.Name = "btnCategorySearch";
            this.btnCategorySearch.Size = new System.Drawing.Size(150, 70);
            this.btnCategorySearch.TabIndex = 0;
            this.btnCategorySearch.Text = "Tìm";
            this.btnCategorySearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCategorySearch.UseVisualStyleBackColor = false;
            this.btnCategorySearch.Click += new System.EventHandler(this.btnCategorySearch_Click);
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDeleteCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(52)))), ((int)(((byte)(36)))));
            this.btnDeleteCategory.FlatAppearance.BorderSize = 0;
            this.btnDeleteCategory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(32)))), ((int)(((byte)(18)))));
            this.btnDeleteCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(52)))), ((int)(((byte)(36)))));
            this.btnDeleteCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCategory.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCategory.Image = global::BaketyManagement.Properties.Resources.Delete;
            this.btnDeleteCategory.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDeleteCategory.Location = new System.Drawing.Point(952, 142);
            this.btnDeleteCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(150, 70);
            this.btnDeleteCategory.TabIndex = 0;
            this.btnDeleteCategory.Text = "Xóa";
            this.btnDeleteCategory.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDeleteCategory.UseVisualStyleBackColor = false;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // btnEditCategory
            // 
            this.btnEditCategory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEditCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(137)))));
            this.btnEditCategory.FlatAppearance.BorderSize = 0;
            this.btnEditCategory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(109)))));
            this.btnEditCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(137)))));
            this.btnEditCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCategory.ForeColor = System.Drawing.Color.White;
            this.btnEditCategory.Image = global::BaketyManagement.Properties.Resources.Edit;
            this.btnEditCategory.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditCategory.Location = new System.Drawing.Point(656, 142);
            this.btnEditCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditCategory.Name = "btnEditCategory";
            this.btnEditCategory.Size = new System.Drawing.Size(150, 70);
            this.btnEditCategory.TabIndex = 0;
            this.btnEditCategory.Text = "Sửa";
            this.btnEditCategory.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditCategory.UseVisualStyleBackColor = false;
            this.btnEditCategory.Click += new System.EventHandler(this.btnEditCategory_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(140)))), ((int)(((byte)(36)))));
            this.btnAddCategory.FlatAppearance.BorderSize = 0;
            this.btnAddCategory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(107)))), ((int)(((byte)(18)))));
            this.btnAddCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(140)))), ((int)(((byte)(36)))));
            this.btnAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCategory.ForeColor = System.Drawing.Color.White;
            this.btnAddCategory.Image = global::BaketyManagement.Properties.Resources.Add;
            this.btnAddCategory.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddCategory.Location = new System.Drawing.Point(360, 142);
            this.btnAddCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(150, 70);
            this.btnAddCategory.TabIndex = 0;
            this.btnAddCategory.Text = "Thêm";
            this.btnAddCategory.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddCategory.UseVisualStyleBackColor = false;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click_1);
            // 
            // FrmCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 501);
            this.Controls.Add(this.tlpCategory);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmCategory";
            this.Text = "FrmCategory";
            this.Load += new System.EventHandler(this.FrmCategory_Load);
            this.tlpCategory.ResumeLayout(false);
            this.panel18.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).EndInit();
            this.panel19.ResumeLayout(false);
            this.groupBox14.ResumeLayout(false);
            this.pnFunctionCategory.ResumeLayout(false);
            this.pnFunctionCategory.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tlpCategory;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnDisplayCategory;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Button btnEditCategory;
        private System.Windows.Forms.TextBox txtCategorySearch;
        private System.Windows.Forms.Button btnCategorySearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvCategory;
        private System.Windows.Forms.Panel pnFunctionCategory;
    }
}