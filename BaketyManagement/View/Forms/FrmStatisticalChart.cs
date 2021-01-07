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
using System.Windows.Forms.DataVisualization.Charting;

namespace BaketyManagement.View.Forms
{
    public partial class FrmStatisticalChart : Form
    {
        public FrmStatisticalChart()
        {
            InitializeComponent();
        }

        #region Events
        private void FrmStatisticalChart_Load(object sender, EventArgs e)
        {
            LoadStatisticalChart();
        }
        private void pnStatical_Paint(object sender, PaintEventArgs e)
        {
            FrmMain.ShadowPanel(sender, e);
        }

        private void pnTypeStatical_Paint(object sender, PaintEventArgs e)
        {
            FrmMain.ShadowPanel(sender, e);
        }

        private void pnTypeShape_Paint(object sender, PaintEventArgs e)
        {
            FrmMain.ShadowPanel(sender, e);
        }

        private void pnFuntionStatical_Paint(object sender, PaintEventArgs e)
        {
            FrmMain.ShadowPanel(sender, e);
        }
        private void radRevenue7DaysChart_Click(object sender, EventArgs e)
        {
            StatisticalChart();
        }
        private void radRevenue3MonthsChart_Click(object sender, EventArgs e)
        {
            StatisticalChart();
        }
        private void radBestSellerChart_Click(object sender, EventArgs e)
        {
            StatisticalChart();
        }
        private void radSlowestSellerChart_Click(object sender, EventArgs e)
        {
            StatisticalChart();
        }
        private void radColumnChart_Chart_Click(object sender, EventArgs e)
        {
            StatisticalChart();
        }
        private void radCircleChart_Chart_Click(object sender, EventArgs e)
        {
            StatisticalChart();
        }
        private void radLineChart_Chart_Click(object sender, EventArgs e)
        {
            StatisticalChart();
        }
        #endregion

        #region Methods
        private void LoadStatisticalChart()
        {
            DateTime now = DateTime.Now;
            DateTime sevenDaysAgo = DateTime.Today.AddDays(-7);
            DataTable source = StatisticalDAO.Instance.Revenue7Days(sevenDaysAgo, now);
            String chartName = "BIỂU ĐỒ THỐNG KÊ DOANH THU 7 NGÀY GẦN ĐÂY";
            DrawChart(source, "exportDate", "totalMoney", chartName, "columnChart", "Doanh thu (VND)");
        }

        private void DrawChart(DataTable source, String xValueMember, String yValueMeber, String chartName,
           String typeChart, String legend)
        {
            chartStatistical.DataSource = source;
            chartStatistical.Series["statistical"].XValueMember = xValueMember;
            chartStatistical.Series["statistical"].YValueMembers = yValueMeber;
            chartStatistical.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            chartStatistical.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dot;
            chartStatistical.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dot;
            if (String.Compare(typeChart, "circleChart", true) == 0)
            {
                chartStatistical.Series[0].ChartType = SeriesChartType.Pie;
                chartStatistical.Series[0].LegendText = legend;
            }
            else if (String.Compare(typeChart, "lineChart", true) == 0)
            {
                chartStatistical.Series[0].ChartType = SeriesChartType.Line;
                chartStatistical.Series[0].LegendText = legend;
                chartStatistical.ChartAreas[0].AxisX.MajorGrid.LineWidth = 1;
                chartStatistical.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;

            }
            else if (String.Compare(typeChart, "columnChart", true) == 0)
            {
                chartStatistical.Series[0].ChartType = SeriesChartType.Column;
                chartStatistical.Series[0].LegendText = legend;
            }
            chartStatistical.Titles[0].Text = chartName;
        }
        private void StatisticalChart()
        {
            if (radRevenue7DaysChart.Checked)
            {
                DateTime now = DateTime.Now;
                DateTime sevenDaysAgo = DateTime.Today.AddDays(-7);
                DataTable source = StatisticalDAO.Instance.Revenue7Days(sevenDaysAgo, now);
                String chartName = "BIỂU ĐỒ THỐNG KÊ DOANH THU 7 NGÀY GẦN ĐÂY";
                String xValueMember = "exportDate";
                String yValueMemer = "totalMoney";
                if (radColumnChart_Chart.Checked)
                {
                    DrawChart(source, xValueMember, yValueMemer, chartName, "columnChart", "Doanh thu (VND)");
                }
                else if (radCircleChart_Chart.Checked)
                {
                    DrawChart(source, xValueMember, yValueMemer, chartName, "circleChart", "");
                }
                else if (radLineChart_Chart.Checked)
                {
                    DrawChart(source, xValueMember, yValueMemer, chartName, "lineChart", "Doanh thu (VND)");
                }
            }
            else if (radBestSellerChart.Checked)
            {
                DateTime now = DateTime.Now;
                DateTime thirtyDaysAgo = DateTime.Today.AddDays(-30);
                DataTable source = StatisticalDAO.Instance.TenBestSeller(thirtyDaysAgo, now);
                String chartName = "BIỂU ĐỒ THỐNG KÊ DOANH THU 10 SẢN PHẨM BÁN CHẠY NHẤT TRONG 30 NGÀY GẦN ĐÂY";
                String xValueMember = "nameCake";
                String yValueMemer = "order1";
                if (radColumnChart_Chart.Checked)
                {
                    DrawChart(source, xValueMember, yValueMemer, chartName, "columnChart", "Số lượng (cái)");
                }
                else if (radCircleChart_Chart.Checked)
                {
                    DrawChart(source, xValueMember, yValueMemer, chartName, "circleChart", "");
                }
                else if (radLineChart_Chart.Checked)
                {
                    DrawChart(source, xValueMember, yValueMemer, chartName, "lineChart", "Số lượng (cái)");
                }
            }
            else if (radSlowestSellerChart.Checked)
            {
                DateTime now = DateTime.Now;
                DateTime thirtyDaysAgo = DateTime.Today.AddDays(-30);
                DataTable source = StatisticalDAO.Instance.TenSlowestSeller(thirtyDaysAgo, now);
                String chartName = "BIỂU ĐỒ THỐNG KÊ DOANH THU 10 SẢN PHẨM BÁN CHẬM NHẤT TRONG 30 NGÀY GẦN ĐÂY";
                String xValueMember = "nameCake";
                String yValueMemer = "order1";
                if (radColumnChart_Chart.Checked)
                {
                    DrawChart(source, xValueMember, yValueMemer, chartName, "columnChart", "Số lượng (cái)");
                }
                else if (radCircleChart_Chart.Checked)
                {
                    DrawChart(source, xValueMember, yValueMemer, chartName, "circleChart", "");
                }
                else if (radLineChart_Chart.Checked)
                {
                    DrawChart(source, xValueMember, yValueMemer, chartName, "lineChart", "Số lượng (cái)");
                }
            }
            else if (radRevenue3MonthsChart.Checked)
            {
                DateTime now = DateTime.Now;
                DateTime month = new DateTime(now.Year, now.Month, 1);
                DateTime threeMonthAgo = month.AddMonths(-3);
                DataTable source = StatisticalDAO.Instance.Revenue3Moths(threeMonthAgo, now);
                String chartName = "BIỂU ĐỒ THỐNG KÊ DOANH THU 3 THÁNG GẦN ĐÂY";
                String xValueMember = "exportDate";
                String yValueMemer = "totalMoney";
                if (radColumnChart_Chart.Checked)
                {
                    DrawChart(source, xValueMember, yValueMemer, chartName, "columnChart", "Doanh thu (VND)");
                }
                else if (radCircleChart_Chart.Checked)
                {
                    DrawChart(source, xValueMember, yValueMemer, chartName, "circleChart", "");
                }
                else if (radLineChart_Chart.Checked)
                {
                    DrawChart(source, xValueMember, yValueMemer, chartName, "lineChart", "Doanh thu (VND)");
                }
            }
        }







        #endregion
    }
}
