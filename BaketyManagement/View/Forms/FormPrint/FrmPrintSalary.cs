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
    public partial class FrmPrintSalary : Form
    {
        public FrmPrintSalary()
        {
            InitializeComponent();
        }

        private void FrmPrintSalary_Load(object sender, EventArgs e)
        {
            this.rpvSalary.RefreshReport();
        }

        private void btnPrintSalary_Click(object sender, EventArgs e)
        {
            DateTime datePrint = dtpDatePrintSalary.Value;
            this.payrollDataSetBindingSource.DataSource = SalaryDAO.Instance.GetPayroll(datePrint);
            this.rpvSalary.RefreshReport();
        }
    }
}
