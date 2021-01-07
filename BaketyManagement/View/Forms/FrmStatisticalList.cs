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

namespace BaketyManagement.View.Forms
{
    public partial class FrmStatisticalList : Form
    {
        public FrmStatisticalList()
        {
            InitializeComponent();
        }

        #region Events
        private void radRevenue7DaysList_Click(object sender, EventArgs e)
        {
            StatisticalList();
        }

        private void radRevenue3MonthsList_Click(object sender, EventArgs e)
        {
            StatisticalList();
        }

        private void radBestSellerList_Click(object sender, EventArgs e)
        {
            StatisticalList();
        }

        private void radSlowestSellerList_Click(object sender, EventArgs e)
        {
            StatisticalList();
        }
        private void FrmStatisticalList_Load(object sender, EventArgs e)
        {
            LoadStatisticalList();
        }
        private void pnListStatical_Paint(object sender, PaintEventArgs e)
        {
            FrmMain.ShadowPanel(sender, e);
        }

        private void pnTypeStatical_Paint(object sender, PaintEventArgs e)
        {
            FrmMain.ShadowPanel(sender, e);

        }

        private void pnFuntionStatical_Paint(object sender, PaintEventArgs e)
        {
            FrmMain.ShadowPanel(sender, e);
        }

        #endregion

        #region Methods
        private void StatisticalList()
        {
            if (radRevenue7DaysList.Checked)
            {
                DateTime now = DateTime.Now;
                DateTime sevenDaysAgo = DateTime.Today.AddDays(-7);
                dgvStatistical.DataSource = StatisticalDAO.Instance.Revenue7Days(sevenDaysAgo, now);
                dgvStatistical.Columns[0].HeaderText = "Ngày";
                dgvStatistical.Columns[1].HeaderText = "Tổng tiền";
                gbStatisticalList.Text = "Danh sách doanh thu 7 ngày gần đây";
            }
            else if (radRevenue3MonthsList.Checked)
            {
                DateTime now = DateTime.Now;
                DateTime month = new DateTime(now.Year, now.Month, 1);
                DateTime threeMonthAgo = month.AddMonths(-3);
                dgvStatistical.DataSource = StatisticalDAO.Instance.Revenue3Moths(threeMonthAgo, now);
                dgvStatistical.Columns[0].HeaderText = "Tháng";
                dgvStatistical.Columns[1].HeaderText = "Tổng tiền";
                gbStatisticalList.Text = "Danh sách doanh thu 3 tháng gần đây";
            }
            else if (radBestSellerList.Checked)
            {
                DateTime now = DateTime.Now;
                DateTime thirtyDaysAgo = DateTime.Today.AddDays(-30);
                dgvStatistical.DataSource = StatisticalDAO.Instance.TenBestSeller(thirtyDaysAgo, now);
                dgvStatistical.Columns[0].HeaderText = "Tên bánh";
                dgvStatistical.Columns[1].HeaderText = "Số lượng";
                gbStatisticalList.Text = "Danh sách 10 loại bánh bán chạy nhất trong 30 ngày gần đây";
            }
            else if (radSlowestSellerList.Checked)
            {
                DateTime now = DateTime.Now;
                DateTime thirtyDaysAgo = DateTime.Today.AddDays(-30);
                dgvStatistical.DataSource = StatisticalDAO.Instance.TenSlowestSeller(thirtyDaysAgo, now);
                dgvStatistical.Columns[0].HeaderText = "Tên bánh";
                dgvStatistical.Columns[1].HeaderText = "Số lượng";
                gbStatisticalList.Text = "Danh sách 10 loại bánh bán chậm nhất trong 30 ngày gần đây";
            }
        }
        private void LoadStatisticalList()
        {
            DateTime now = DateTime.Now;
            DateTime sevenDaysAgo = DateTime.Today.AddDays(-7);
            dgvStatistical.DataSource = StatisticalDAO.Instance.Revenue7Days(sevenDaysAgo, now);
            dgvStatistical.Columns[0].HeaderText = "Ngày";
            dgvStatistical.Columns[1].HeaderText = "Tổng tiền";
            gbStatisticalList.Text = "Danh sách doanh thu 7 ngày gần đây";
        }

        #endregion

        
    }
}
