
namespace BaketyManagement.View.FormInfor
{
    partial class FrmInforSalary
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cboStaffName = new System.Windows.Forms.ComboBox();
            this.txtSalaryOverTime = new System.Windows.Forms.TextBox();
            this.txtRewards = new System.Windows.Forms.TextBox();
            this.txtHoursOverTime = new System.Windows.Forms.TextBox();
            this.txtWorkDays = new System.Windows.Forms.TextBox();
            this.txtSalaryDate = new System.Windows.Forms.TextBox();
            this.txtIDStaff = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnTimeKeeping = new System.Windows.Forms.Button();
            this.btnAddSalary = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(580, 624);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(574, 74);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(147, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin lương";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cboStaffName);
            this.panel2.Controls.Add(this.txtSalaryOverTime);
            this.panel2.Controls.Add(this.txtRewards);
            this.panel2.Controls.Add(this.txtHoursOverTime);
            this.panel2.Controls.Add(this.txtWorkDays);
            this.panel2.Controls.Add(this.txtSalaryDate);
            this.panel2.Controls.Add(this.txtIDStaff);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(574, 408);
            this.panel2.TabIndex = 1;
            // 
            // cboStaffName
            // 
            this.cboStaffName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStaffName.FormattingEnabled = true;
            this.cboStaffName.Location = new System.Drawing.Point(220, 79);
            this.cboStaffName.Name = "cboStaffName";
            this.cboStaffName.Size = new System.Drawing.Size(317, 28);
            this.cboStaffName.TabIndex = 7;
            this.cboStaffName.SelectedIndexChanged += new System.EventHandler(this.cboStaffName_SelectedIndexChanged);
            // 
            // txtSalaryOverTime
            // 
            this.txtSalaryOverTime.Location = new System.Drawing.Point(220, 339);
            this.txtSalaryOverTime.Name = "txtSalaryOverTime";
            this.txtSalaryOverTime.Size = new System.Drawing.Size(317, 26);
            this.txtSalaryOverTime.TabIndex = 6;
            // 
            // txtRewards
            // 
            this.txtRewards.Location = new System.Drawing.Point(220, 287);
            this.txtRewards.Name = "txtRewards";
            this.txtRewards.Size = new System.Drawing.Size(317, 26);
            this.txtRewards.TabIndex = 5;
            // 
            // txtHoursOverTime
            // 
            this.txtHoursOverTime.Location = new System.Drawing.Point(220, 235);
            this.txtHoursOverTime.Name = "txtHoursOverTime";
            this.txtHoursOverTime.Size = new System.Drawing.Size(317, 26);
            this.txtHoursOverTime.TabIndex = 4;
            // 
            // txtWorkDays
            // 
            this.txtWorkDays.Location = new System.Drawing.Point(220, 183);
            this.txtWorkDays.Name = "txtWorkDays";
            this.txtWorkDays.ReadOnly = true;
            this.txtWorkDays.Size = new System.Drawing.Size(317, 26);
            this.txtWorkDays.TabIndex = 3;
            // 
            // txtSalaryDate
            // 
            this.txtSalaryDate.Location = new System.Drawing.Point(220, 131);
            this.txtSalaryDate.Name = "txtSalaryDate";
            this.txtSalaryDate.Size = new System.Drawing.Size(317, 26);
            this.txtSalaryDate.TabIndex = 2;
            // 
            // txtIDStaff
            // 
            this.txtIDStaff.Location = new System.Drawing.Point(220, 27);
            this.txtIDStaff.Name = "txtIDStaff";
            this.txtIDStaff.ReadOnly = true;
            this.txtIDStaff.Size = new System.Drawing.Size(317, 26);
            this.txtIDStaff.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(37, 342);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 40);
            this.label7.TabIndex = 0;
            this.label7.Text = "Lương làm thêm \r\n     (VNĐ/Giờ)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(37, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Thưởng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(37, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tên Nhân Viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(37, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã Nhân Viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(37, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Giờ Làm Thêm";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(37, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Ngày Lương (VNĐ)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(37, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày Công";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Controls.Add(this.btnTimeKeeping);
            this.panel3.Controls.Add(this.btnAddSalary);
            this.panel3.Controls.Add(this.btnUpdate);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 497);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(574, 124);
            this.panel3.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(52)))), ((int)(((byte)(36)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(32)))), ((int)(((byte)(18)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(52)))), ((int)(((byte)(36)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = global::BaketyManagement.Properties.Resources.Cancel;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancel.Location = new System.Drawing.Point(316, 27);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 70);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnTimeKeeping
            // 
            this.btnTimeKeeping.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(159)))), ((int)(((byte)(56)))));
            this.btnTimeKeeping.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnTimeKeeping.FlatAppearance.BorderSize = 0;
            this.btnTimeKeeping.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(126)))), ((int)(((byte)(38)))));
            this.btnTimeKeeping.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(159)))), ((int)(((byte)(56)))));
            this.btnTimeKeeping.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimeKeeping.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimeKeeping.ForeColor = System.Drawing.Color.White;
            this.btnTimeKeeping.Image = global::BaketyManagement.Properties.Resources.Edit;
            this.btnTimeKeeping.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTimeKeeping.Location = new System.Drawing.Point(109, 27);
            this.btnTimeKeeping.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTimeKeeping.Name = "btnTimeKeeping";
            this.btnTimeKeeping.Size = new System.Drawing.Size(150, 70);
            this.btnTimeKeeping.TabIndex = 0;
            this.btnTimeKeeping.Text = "Chấm Công";
            this.btnTimeKeeping.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTimeKeeping.UseVisualStyleBackColor = false;
            this.btnTimeKeeping.Click += new System.EventHandler(this.btnTimeKeeping_Click);
            // 
            // btnAddSalary
            // 
            this.btnAddSalary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(159)))), ((int)(((byte)(56)))));
            this.btnAddSalary.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnAddSalary.FlatAppearance.BorderSize = 0;
            this.btnAddSalary.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(126)))), ((int)(((byte)(38)))));
            this.btnAddSalary.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(159)))), ((int)(((byte)(56)))));
            this.btnAddSalary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSalary.ForeColor = System.Drawing.Color.White;
            this.btnAddSalary.Image = global::BaketyManagement.Properties.Resources.Add;
            this.btnAddSalary.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddSalary.Location = new System.Drawing.Point(109, 27);
            this.btnAddSalary.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddSalary.Name = "btnAddSalary";
            this.btnAddSalary.Size = new System.Drawing.Size(150, 70);
            this.btnAddSalary.TabIndex = 1;
            this.btnAddSalary.Text = "Thêm mới";
            this.btnAddSalary.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddSalary.UseVisualStyleBackColor = false;
            this.btnAddSalary.Click += new System.EventHandler(this.btnAddSalary_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(159)))), ((int)(((byte)(56)))));
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(126)))), ((int)(((byte)(38)))));
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(159)))), ((int)(((byte)(56)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(109, 27);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(150, 70);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Cập Nhật";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // FrmInforSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(580, 624);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmInforSalary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmInforSalary";
            this.Load += new System.EventHandler(this.FrmInforSalary_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSalaryOverTime;
        private System.Windows.Forms.TextBox txtRewards;
        private System.Windows.Forms.TextBox txtHoursOverTime;
        private System.Windows.Forms.TextBox txtWorkDays;
        private System.Windows.Forms.TextBox txtSalaryDate;
        private System.Windows.Forms.TextBox txtIDStaff;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnTimeKeeping;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAddSalary;
        private System.Windows.Forms.ComboBox cboStaffName;
    }
}