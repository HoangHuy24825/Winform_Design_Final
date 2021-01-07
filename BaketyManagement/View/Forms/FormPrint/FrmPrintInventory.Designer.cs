
namespace BaketyManagement.View.Forms.FormPrint
{
    partial class FrmPrintInventory
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
            this.rpvPrintInventory = new Microsoft.Reporting.WinForms.ReportViewer();
            this.getFullListCakeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getFullListCakeDataSet = new BaketyManagement.GetFullListCakeDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.getFullListCakeDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getFullListCakeDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // rpvPrintInventory
            // 
            this.rpvPrintInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.getFullListCakeDataSetBindingSource;
            this.rpvPrintInventory.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvPrintInventory.LocalReport.ReportEmbeddedResource = "BaketyManagement.View.Forms.FormPrint.ReportInventory.rdlc";
            this.rpvPrintInventory.Location = new System.Drawing.Point(0, 0);
            this.rpvPrintInventory.Name = "rpvPrintInventory";
            this.rpvPrintInventory.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.rpvPrintInventory.ServerReport.BearerToken = null;
            this.rpvPrintInventory.Size = new System.Drawing.Size(800, 450);
            this.rpvPrintInventory.TabIndex = 0;
            // 
            // getFullListCakeDataSetBindingSource
            // 
            this.getFullListCakeDataSetBindingSource.DataSource = this.getFullListCakeDataSet;
            this.getFullListCakeDataSetBindingSource.Position = 0;
            // 
            // getFullListCakeDataSet
            // 
            this.getFullListCakeDataSet.DataSetName = "GetFullListCakeDataSet";
            this.getFullListCakeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FrmPrintInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rpvPrintInventory);
            this.Name = "FrmPrintInventory";
            this.Text = "FrmPrintInvenroty";
            this.Load += new System.EventHandler(this.FrmPrintInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.getFullListCakeDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getFullListCakeDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvPrintInventory;
        private System.Windows.Forms.BindingSource getFullListCakeDataSetBindingSource;
        private GetFullListCakeDataSet getFullListCakeDataSet;
    }
}