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
    public partial class FrmPrintInventory : Form
    {
        public FrmPrintInventory()
        {
            InitializeComponent();
        }

        private void FrmPrintInventory_Load(object sender, EventArgs e)
        {
            this.getFullListCakeDataSetBindingSource.DataSource = CakeDAO.Instance.GetFullListCake();
            this.rpvPrintInventory.RefreshReport();
        }
    }
}
