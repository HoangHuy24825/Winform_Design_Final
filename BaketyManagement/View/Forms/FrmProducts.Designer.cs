
namespace BaketyManagement.View.Forms
{
    partial class FrmProducts
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
            this.tlpProduct = new System.Windows.Forms.TableLayoutPanel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvCake = new System.Windows.Forms.DataGridView();
            this.panel9 = new System.Windows.Forms.Panel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.pnFunctionProduct = new System.Windows.Forms.Panel();
            this.label22 = new System.Windows.Forms.Label();
            this.txtCakeSearch = new System.Windows.Forms.TextBox();
            this.btnCakeEdit = new System.Windows.Forms.Button();
            this.btnCakeSearch = new System.Windows.Forms.Button();
            this.btnCakeDisplay = new System.Windows.Forms.Button();
            this.btnCakeDel = new System.Windows.Forms.Button();
            this.tlpProduct.SuspendLayout();
            this.panel8.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCake)).BeginInit();
            this.panel9.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.pnFunctionProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpProduct
            // 
            this.tlpProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.tlpProduct.ColumnCount = 1;
            this.tlpProduct.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpProduct.Controls.Add(this.panel8, 0, 0);
            this.tlpProduct.Controls.Add(this.panel9, 0, 1);
            this.tlpProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpProduct.Location = new System.Drawing.Point(0, 0);
            this.tlpProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tlpProduct.Name = "tlpProduct";
            this.tlpProduct.Padding = new System.Windows.Forms.Padding(15);
            this.tlpProduct.RowCount = 2;
            this.tlpProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tlpProduct.Size = new System.Drawing.Size(1092, 522);
            this.tlpProduct.TabIndex = 3;
            this.tlpProduct.Paint += new System.Windows.Forms.PaintEventHandler(this.tlpProduct_Paint);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.groupBox1);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel8.Location = new System.Drawing.Point(30, 30);
            this.panel8.Margin = new System.Windows.Forms.Padding(15);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1032, 162);
            this.panel8.TabIndex = 1;
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
            this.groupBox1.Size = new System.Drawing.Size(1032, 162);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách bánh";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvCake);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(3, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1026, 137);
            this.panel1.TabIndex = 0;
            // 
            // dgvCake
            // 
            this.dgvCake.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCake.BackgroundColor = System.Drawing.Color.White;
            this.dgvCake.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCake.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCake.Location = new System.Drawing.Point(0, 0);
            this.dgvCake.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvCake.MultiSelect = false;
            this.dgvCake.Name = "dgvCake";
            this.dgvCake.ReadOnly = true;
            this.dgvCake.RowHeadersWidth = 51;
            this.dgvCake.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCake.Size = new System.Drawing.Size(1026, 137);
            this.dgvCake.TabIndex = 2;
            this.dgvCake.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCake_CellClick);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.groupBox6);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(30, 222);
            this.panel9.Margin = new System.Windows.Forms.Padding(15);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1032, 270);
            this.panel9.TabIndex = 2;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.White;
            this.groupBox6.Controls.Add(this.pnFunctionProduct);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.groupBox6.Location = new System.Drawing.Point(0, 0);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox6.Size = new System.Drawing.Size(1032, 270);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Chức năng";
            // 
            // pnFunctionProduct
            // 
            this.pnFunctionProduct.Controls.Add(this.label22);
            this.pnFunctionProduct.Controls.Add(this.txtCakeSearch);
            this.pnFunctionProduct.Controls.Add(this.btnCakeEdit);
            this.pnFunctionProduct.Controls.Add(this.btnCakeSearch);
            this.pnFunctionProduct.Controls.Add(this.btnCakeDisplay);
            this.pnFunctionProduct.Controls.Add(this.btnCakeDel);
            this.pnFunctionProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnFunctionProduct.Location = new System.Drawing.Point(4, 24);
            this.pnFunctionProduct.Name = "pnFunctionProduct";
            this.pnFunctionProduct.Size = new System.Drawing.Size(1024, 241);
            this.pnFunctionProduct.TabIndex = 3;
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.label22.Location = new System.Drawing.Point(24, 69);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(151, 20);
            this.label22.TabIndex = 2;
            this.label22.Text = "Tìm kiếm theo tên";
            // 
            // txtCakeSearch
            // 
            this.txtCakeSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCakeSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCakeSearch.ForeColor = System.Drawing.Color.Black;
            this.txtCakeSearch.Location = new System.Drawing.Point(197, 66);
            this.txtCakeSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCakeSearch.Name = "txtCakeSearch";
            this.txtCakeSearch.Size = new System.Drawing.Size(600, 26);
            this.txtCakeSearch.TabIndex = 1;
            // 
            // btnCakeEdit
            // 
            this.btnCakeEdit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCakeEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(137)))));
            this.btnCakeEdit.FlatAppearance.BorderSize = 0;
            this.btnCakeEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(109)))));
            this.btnCakeEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(137)))));
            this.btnCakeEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCakeEdit.ForeColor = System.Drawing.Color.White;
            this.btnCakeEdit.Image = global::BaketyManagement.Properties.Resources.Edit;
            this.btnCakeEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCakeEdit.Location = new System.Drawing.Point(435, 132);
            this.btnCakeEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCakeEdit.Name = "btnCakeEdit";
            this.btnCakeEdit.Size = new System.Drawing.Size(150, 70);
            this.btnCakeEdit.TabIndex = 0;
            this.btnCakeEdit.Text = "Sửa";
            this.btnCakeEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCakeEdit.UseVisualStyleBackColor = false;
            this.btnCakeEdit.Click += new System.EventHandler(this.btnCakeEdit_Click);
            // 
            // btnCakeSearch
            // 
            this.btnCakeSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCakeSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(36)))), ((int)(((byte)(210)))));
            this.btnCakeSearch.FlatAppearance.BorderSize = 0;
            this.btnCakeSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(18)))), ((int)(((byte)(167)))));
            this.btnCakeSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(36)))), ((int)(((byte)(210)))));
            this.btnCakeSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCakeSearch.ForeColor = System.Drawing.Color.White;
            this.btnCakeSearch.Image = global::BaketyManagement.Properties.Resources.Search;
            this.btnCakeSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCakeSearch.Location = new System.Drawing.Point(850, 38);
            this.btnCakeSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCakeSearch.Name = "btnCakeSearch";
            this.btnCakeSearch.Size = new System.Drawing.Size(150, 70);
            this.btnCakeSearch.TabIndex = 0;
            this.btnCakeSearch.Text = "Tìm";
            this.btnCakeSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCakeSearch.UseVisualStyleBackColor = false;
            this.btnCakeSearch.Click += new System.EventHandler(this.btnCakeSearch_Click);
            // 
            // btnCakeDisplay
            // 
            this.btnCakeDisplay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCakeDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(159)))), ((int)(((byte)(56)))));
            this.btnCakeDisplay.FlatAppearance.BorderSize = 0;
            this.btnCakeDisplay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(126)))), ((int)(((byte)(38)))));
            this.btnCakeDisplay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(159)))), ((int)(((byte)(56)))));
            this.btnCakeDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCakeDisplay.ForeColor = System.Drawing.Color.White;
            this.btnCakeDisplay.Image = global::BaketyManagement.Properties.Resources.Display;
            this.btnCakeDisplay.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCakeDisplay.Location = new System.Drawing.Point(189, 132);
            this.btnCakeDisplay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCakeDisplay.Name = "btnCakeDisplay";
            this.btnCakeDisplay.Size = new System.Drawing.Size(150, 70);
            this.btnCakeDisplay.TabIndex = 0;
            this.btnCakeDisplay.Text = "Xem";
            this.btnCakeDisplay.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCakeDisplay.UseVisualStyleBackColor = false;
            this.btnCakeDisplay.Click += new System.EventHandler(this.btnCakeDisplay_Click);
            // 
            // btnCakeDel
            // 
            this.btnCakeDel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCakeDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(52)))), ((int)(((byte)(36)))));
            this.btnCakeDel.FlatAppearance.BorderSize = 0;
            this.btnCakeDel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(32)))), ((int)(((byte)(18)))));
            this.btnCakeDel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(52)))), ((int)(((byte)(36)))));
            this.btnCakeDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCakeDel.ForeColor = System.Drawing.Color.White;
            this.btnCakeDel.Image = global::BaketyManagement.Properties.Resources.Delete;
            this.btnCakeDel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCakeDel.Location = new System.Drawing.Point(681, 132);
            this.btnCakeDel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCakeDel.Name = "btnCakeDel";
            this.btnCakeDel.Size = new System.Drawing.Size(150, 70);
            this.btnCakeDel.TabIndex = 0;
            this.btnCakeDel.Text = "Xóa";
            this.btnCakeDel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCakeDel.UseVisualStyleBackColor = false;
            this.btnCakeDel.Click += new System.EventHandler(this.btnCakeDel_Click);
            // 
            // FrmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 522);
            this.Controls.Add(this.tlpProduct);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmProducts";
            this.Text = "FrmProducts";
            this.Load += new System.EventHandler(this.FrmProducts_Load);
            this.tlpProduct.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCake)).EndInit();
            this.panel9.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.pnFunctionProduct.ResumeLayout(false);
            this.pnFunctionProduct.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpProduct;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btnCakeEdit;
        private System.Windows.Forms.Button btnCakeDisplay;
        private System.Windows.Forms.Button btnCakeDel;
        private System.Windows.Forms.TextBox txtCakeSearch;
        private System.Windows.Forms.Button btnCakeSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvCake;
        private System.Windows.Forms.Panel pnFunctionProduct;
    }
}