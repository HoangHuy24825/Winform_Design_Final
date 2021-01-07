using BaketyManagement.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaketyManagement.View.Forms.FormPrint
{
    public partial class FrmPrintBill : Form
    {
        public FrmPrintBill()
        {
            InitializeComponent();
        }

        private void FrmPrintBill_Load(object sender, EventArgs e)
        {
            Int32 idBill = BillDAO.Instance.GetMaxIDBill();
            this.printBillDataSetBindingSource.DataSource = BillDAO.Instance.PrintBill(idBill);
            this.rpvPrintBill.RefreshReport();
        }
    }
}
