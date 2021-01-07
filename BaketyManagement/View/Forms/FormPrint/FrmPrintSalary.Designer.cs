
namespace BaketyManagement.View.Forms.FormPrint
{
    partial class FrmPrintSalary
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.payrollDataSet = new BaketyManagement.PayrollDataSet();
            this.payrollDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rpvSalary = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPrintSalary = new System.Windows.Forms.Button();
            this.dtpDatePrintSalary = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.payrollDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollDataSetBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // payrollDataSet
            // 
            this.payrollDataSet.DataSetName = "PayrollDataSet";
            this.payrollDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // payrollDataSetBindingSource
            // 
            this.payrollDataSetBindingSource.DataSource = this.payrollDataSet;
            this.payrollDataSetBindingSource.Position = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(701, 423);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rpvSalary);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(695, 317);
            this.panel1.TabIndex = 0;
            // 
            // rpvSalary
            // 
            this.rpvSalary.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.payrollDataSetBindingSource;
            this.rpvSalary.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvSalary.LocalReport.ReportEmbeddedResource = "BaketyManagement.View.Forms.FormPrint.ReportSalary.rdlc";
            this.rpvSalary.Location = new System.Drawing.Point(0, 0);
            this.rpvSalary.Name = "rpvSalary";
            this.rpvSalary.ServerReport.BearerToken = null;
            this.rpvSalary.Size = new System.Drawing.Size(695, 317);
            this.rpvSalary.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtpDatePrintSalary);
            this.panel2.Controls.Add(this.btnPrintSalary);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(695, 94);
            this.panel2.TabIndex = 1;
            // 
            // btnPrintSalary
            // 
            this.btnPrintSalary.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrintSalary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(36)))), ((int)(((byte)(210)))));
            this.btnPrintSalary.FlatAppearance.BorderSize = 0;
            this.btnPrintSalary.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(32)))), ((int)(((byte)(18)))));
            this.btnPrintSalary.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(52)))), ((int)(((byte)(36)))));
            this.btnPrintSalary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintSalary.ForeColor = System.Drawing.Color.White;
            this.btnPrintSalary.Image = global::BaketyManagement.Properties.Resources.print;
            this.btnPrintSalary.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPrintSalary.Location = new System.Drawing.Point(467, 12);
            this.btnPrintSalary.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.btnPrintSalary.Name = "btnPrintSalary";
            this.btnPrintSalary.Size = new System.Drawing.Size(150, 70);
            this.btnPrintSalary.TabIndex = 8;
            this.btnPrintSalary.Text = "In Lương";
            this.btnPrintSalary.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPrintSalary.UseVisualStyleBackColor = false;
            this.btnPrintSalary.Click += new System.EventHandler(this.btnPrintSalary_Click);
            // 
            // dtpDatePrintSalary
            // 
            this.dtpDatePrintSalary.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpDatePrintSalary.CustomFormat = "MM/yyyy";
            this.dtpDatePrintSalary.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatePrintSalary.Location = new System.Drawing.Point(77, 32);
            this.dtpDatePrintSalary.Name = "dtpDatePrintSalary";
            this.dtpDatePrintSalary.ShowUpDown = true;
            this.dtpDatePrintSalary.Size = new System.Drawing.Size(352, 26);
            this.dtpDatePrintSalary.TabIndex = 9;
            // 
            // FrmPrintSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 423);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmPrintSalary";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "In lương";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrintSalary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.payrollDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollDataSetBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource payrollDataSetBindingSource;
        private PayrollDataSet payrollDataSet;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer rpvSalary;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtpDatePrintSalary;
        private System.Windows.Forms.Button btnPrintSalary;
    }
}