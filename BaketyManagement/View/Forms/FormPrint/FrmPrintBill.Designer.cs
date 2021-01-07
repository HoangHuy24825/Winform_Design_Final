
namespace BaketyManagement.View.Forms.FormPrint
{
    partial class FrmPrintBill
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
            this.rpvPrintBill = new Microsoft.Reporting.WinForms.ReportViewer();
            this.printBillDataSet = new BaketyManagement.PrintBillDataSet();
            this.printBillDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.printBillDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printBillDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rpvPrintBill
            // 
            this.rpvPrintBill.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.printBillDataSetBindingSource;
            this.rpvPrintBill.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvPrintBill.LocalReport.ReportEmbeddedResource = "BaketyManagement.View.Forms.FormPrint.ReportBill.rdlc";
            this.rpvPrintBill.Location = new System.Drawing.Point(0, 0);
            this.rpvPrintBill.Name = "rpvPrintBill";
            this.rpvPrintBill.ServerReport.BearerToken = null;
            this.rpvPrintBill.Size = new System.Drawing.Size(684, 565);
            this.rpvPrintBill.TabIndex = 0;
            // 
            // printBillDataSet
            // 
            this.printBillDataSet.DataSetName = "PrintBillDataSet";
            this.printBillDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // printBillDataSetBindingSource
            // 
            this.printBillDataSetBindingSource.DataSource = this.printBillDataSet;
            this.printBillDataSetBindingSource.Position = 0;
            // 
            // FrmPrintBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 565);
            this.Controls.Add(this.rpvPrintBill);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmPrintBill";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "In Hóa Đơn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrintBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.printBillDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printBillDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvPrintBill;
        private System.Windows.Forms.BindingSource printBillDataSetBindingSource;
        private PrintBillDataSet printBillDataSet;
    }
}