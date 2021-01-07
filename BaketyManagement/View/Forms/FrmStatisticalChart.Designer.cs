
namespace BaketyManagement.View.Forms
{
    partial class FrmStatisticalChart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartStatistical = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.pnStatical = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.panel20 = new System.Windows.Forms.Panel();
            this.panel21 = new System.Windows.Forms.Panel();
            this.pnTypeShape = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.panel23 = new System.Windows.Forms.Panel();
            this.radLineChart_Chart = new System.Windows.Forms.RadioButton();
            this.radCircleChart_Chart = new System.Windows.Forms.RadioButton();
            this.radColumnChart_Chart = new System.Windows.Forms.RadioButton();
            this.pnTypeStatical = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.panel22 = new System.Windows.Forms.Panel();
            this.radSlowestSellerChart = new System.Windows.Forms.RadioButton();
            this.radBestSellerChart = new System.Windows.Forms.RadioButton();
            this.radRevenue3MonthsChart = new System.Windows.Forms.RadioButton();
            this.radRevenue7DaysChart = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.chartStatistical)).BeginInit();
            this.tableLayoutPanel9.SuspendLayout();
            this.pnStatical.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.panel20.SuspendLayout();
            this.panel21.SuspendLayout();
            this.pnTypeShape.SuspendLayout();
            this.panel6.SuspendLayout();
            this.groupBox17.SuspendLayout();
            this.panel23.SuspendLayout();
            this.pnTypeStatical.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.panel22.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartStatistical
            // 
            chartArea1.Name = "ChartArea1";
            this.chartStatistical.ChartAreas.Add(chartArea1);
            this.chartStatistical.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartStatistical.Legends.Add(legend1);
            this.chartStatistical.Location = new System.Drawing.Point(0, 0);
            this.chartStatistical.Name = "chartStatistical";
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "statistical";
            this.chartStatistical.Series.Add(series1);
            this.chartStatistical.Size = new System.Drawing.Size(1155, 299);
            this.chartStatistical.TabIndex = 0;
            this.chartStatistical.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            title1.ForeColor = System.Drawing.Color.Red;
            title1.Name = "Title1";
            title1.Text = "BIỂU ĐỒ";
            this.chartStatistical.Titles.Add(title1);
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.tableLayoutPanel9.ColumnCount = 1;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel9.Controls.Add(this.pnStatical, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.panel21, 0, 1);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel9.RowCount = 2;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(1221, 634);
            this.tableLayoutPanel9.TabIndex = 1;
            // 
            // pnStatical
            // 
            this.pnStatical.Controls.Add(this.panel1);
            this.pnStatical.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnStatical.Location = new System.Drawing.Point(13, 13);
            this.pnStatical.Name = "pnStatical";
            this.pnStatical.Padding = new System.Windows.Forms.Padding(10);
            this.pnStatical.Size = new System.Drawing.Size(1195, 358);
            this.pnStatical.TabIndex = 4;
            this.pnStatical.Paint += new System.Windows.Forms.PaintEventHandler(this.pnStatical_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox15);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1175, 338);
            this.panel1.TabIndex = 2;
            // 
            // groupBox15
            // 
            this.groupBox15.BackColor = System.Drawing.Color.White;
            this.groupBox15.Controls.Add(this.panel20);
            this.groupBox15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.groupBox15.Location = new System.Drawing.Point(0, 0);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox15.Size = new System.Drawing.Size(1175, 338);
            this.groupBox15.TabIndex = 0;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Biểu đồ";
            // 
            // panel20
            // 
            this.panel20.Controls.Add(this.chartStatistical);
            this.panel20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel20.Location = new System.Drawing.Point(10, 29);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(1155, 299);
            this.panel20.TabIndex = 0;
            // 
            // panel21
            // 
            this.panel21.Controls.Add(this.pnTypeShape);
            this.panel21.Controls.Add(this.pnTypeStatical);
            this.panel21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel21.Location = new System.Drawing.Point(13, 377);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(1195, 244);
            this.panel21.TabIndex = 1;
            // 
            // pnTypeShape
            // 
            this.pnTypeShape.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.pnTypeShape.Controls.Add(this.panel6);
            this.pnTypeShape.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnTypeShape.Location = new System.Drawing.Point(744, 0);
            this.pnTypeShape.Name = "pnTypeShape";
            this.pnTypeShape.Padding = new System.Windows.Forms.Padding(10);
            this.pnTypeShape.Size = new System.Drawing.Size(451, 244);
            this.pnTypeShape.TabIndex = 4;
            this.pnTypeShape.Paint += new System.Windows.Forms.PaintEventHandler(this.pnTypeShape_Paint);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.groupBox17);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(10, 10);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(431, 224);
            this.panel6.TabIndex = 0;
            // 
            // groupBox17
            // 
            this.groupBox17.BackColor = System.Drawing.Color.White;
            this.groupBox17.Controls.Add(this.panel23);
            this.groupBox17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.groupBox17.Location = new System.Drawing.Point(0, 0);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(431, 224);
            this.groupBox17.TabIndex = 1;
            this.groupBox17.TabStop = false;
            this.groupBox17.Text = "Loại biểu đồ";
            // 
            // panel23
            // 
            this.panel23.BackColor = System.Drawing.Color.White;
            this.panel23.Controls.Add(this.radLineChart_Chart);
            this.panel23.Controls.Add(this.radCircleChart_Chart);
            this.panel23.Controls.Add(this.radColumnChart_Chart);
            this.panel23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel23.Location = new System.Drawing.Point(3, 22);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(425, 199);
            this.panel23.TabIndex = 0;
            // 
            // radLineChart_Chart
            // 
            this.radLineChart_Chart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radLineChart_Chart.AutoSize = true;
            this.radLineChart_Chart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.radLineChart_Chart.Location = new System.Drawing.Point(141, 112);
            this.radLineChart_Chart.Name = "radLineChart_Chart";
            this.radLineChart_Chart.Size = new System.Drawing.Size(143, 24);
            this.radLineChart_Chart.TabIndex = 1;
            this.radLineChart_Chart.Text = "Biểu đồ đường";
            this.radLineChart_Chart.UseVisualStyleBackColor = true;
            this.radLineChart_Chart.Click += new System.EventHandler(this.radLineChart_Chart_Click);
            // 
            // radCircleChart_Chart
            // 
            this.radCircleChart_Chart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radCircleChart_Chart.AutoSize = true;
            this.radCircleChart_Chart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.radCircleChart_Chart.Location = new System.Drawing.Point(141, 68);
            this.radCircleChart_Chart.Name = "radCircleChart_Chart";
            this.radCircleChart_Chart.Size = new System.Drawing.Size(125, 24);
            this.radCircleChart_Chart.TabIndex = 2;
            this.radCircleChart_Chart.Text = "Biểu đồ tròn";
            this.radCircleChart_Chart.UseVisualStyleBackColor = true;
            this.radCircleChart_Chart.Click += new System.EventHandler(this.radCircleChart_Chart_Click);
            // 
            // radColumnChart_Chart
            // 
            this.radColumnChart_Chart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radColumnChart_Chart.AutoSize = true;
            this.radColumnChart_Chart.Checked = true;
            this.radColumnChart_Chart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.radColumnChart_Chart.Location = new System.Drawing.Point(141, 19);
            this.radColumnChart_Chart.Name = "radColumnChart_Chart";
            this.radColumnChart_Chart.Size = new System.Drawing.Size(118, 24);
            this.radColumnChart_Chart.TabIndex = 3;
            this.radColumnChart_Chart.TabStop = true;
            this.radColumnChart_Chart.Text = "Biểu đồ cột";
            this.radColumnChart_Chart.UseVisualStyleBackColor = true;
            this.radColumnChart_Chart.Click += new System.EventHandler(this.radColumnChart_Chart_Click);
            // 
            // pnTypeStatical
            // 
            this.pnTypeStatical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.pnTypeStatical.Controls.Add(this.panel5);
            this.pnTypeStatical.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnTypeStatical.Location = new System.Drawing.Point(0, 0);
            this.pnTypeStatical.Name = "pnTypeStatical";
            this.pnTypeStatical.Padding = new System.Windows.Forms.Padding(10);
            this.pnTypeStatical.Size = new System.Drawing.Size(744, 244);
            this.pnTypeStatical.TabIndex = 1;
            this.pnTypeStatical.Paint += new System.Windows.Forms.PaintEventHandler(this.pnTypeStatical_Paint);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.groupBox16);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(10, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(724, 224);
            this.panel5.TabIndex = 0;
            // 
            // groupBox16
            // 
            this.groupBox16.BackColor = System.Drawing.Color.White;
            this.groupBox16.Controls.Add(this.panel22);
            this.groupBox16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.groupBox16.Location = new System.Drawing.Point(0, 0);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(724, 224);
            this.groupBox16.TabIndex = 0;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "Kiểu thống kê";
            // 
            // panel22
            // 
            this.panel22.BackColor = System.Drawing.Color.White;
            this.panel22.Controls.Add(this.radSlowestSellerChart);
            this.panel22.Controls.Add(this.radBestSellerChart);
            this.panel22.Controls.Add(this.radRevenue3MonthsChart);
            this.panel22.Controls.Add(this.radRevenue7DaysChart);
            this.panel22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel22.Location = new System.Drawing.Point(3, 22);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(718, 199);
            this.panel22.TabIndex = 0;
            // 
            // radSlowestSellerChart
            // 
            this.radSlowestSellerChart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radSlowestSellerChart.AutoSize = true;
            this.radSlowestSellerChart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.radSlowestSellerChart.Location = new System.Drawing.Point(143, 161);
            this.radSlowestSellerChart.Name = "radSlowestSellerChart";
            this.radSlowestSellerChart.Size = new System.Drawing.Size(432, 24);
            this.radSlowestSellerChart.TabIndex = 0;
            this.radSlowestSellerChart.Text = "10 loại bánh bán chậm nhất trong 30 ngày gần đây";
            this.radSlowestSellerChart.UseVisualStyleBackColor = true;
            this.radSlowestSellerChart.Click += new System.EventHandler(this.radSlowestSellerChart_Click);
            // 
            // radBestSellerChart
            // 
            this.radBestSellerChart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radBestSellerChart.AutoSize = true;
            this.radBestSellerChart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.radBestSellerChart.Location = new System.Drawing.Point(143, 112);
            this.radBestSellerChart.Name = "radBestSellerChart";
            this.radBestSellerChart.Size = new System.Drawing.Size(426, 24);
            this.radBestSellerChart.TabIndex = 0;
            this.radBestSellerChart.Text = "10 loại bánh bán chạy nhất trong 30 ngày gần đây";
            this.radBestSellerChart.UseVisualStyleBackColor = true;
            this.radBestSellerChart.Click += new System.EventHandler(this.radBestSellerChart_Click);
            // 
            // radRevenue3MonthsChart
            // 
            this.radRevenue3MonthsChart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radRevenue3MonthsChart.AutoSize = true;
            this.radRevenue3MonthsChart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.radRevenue3MonthsChart.Location = new System.Drawing.Point(143, 63);
            this.radRevenue3MonthsChart.Name = "radRevenue3MonthsChart";
            this.radRevenue3MonthsChart.Size = new System.Drawing.Size(245, 24);
            this.radRevenue3MonthsChart.TabIndex = 0;
            this.radRevenue3MonthsChart.Text = "Doanh thu 3 tháng gần đây";
            this.radRevenue3MonthsChart.UseVisualStyleBackColor = true;
            this.radRevenue3MonthsChart.Click += new System.EventHandler(this.radRevenue3MonthsChart_Click);
            // 
            // radRevenue7DaysChart
            // 
            this.radRevenue7DaysChart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radRevenue7DaysChart.AutoSize = true;
            this.radRevenue7DaysChart.Checked = true;
            this.radRevenue7DaysChart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.radRevenue7DaysChart.Location = new System.Drawing.Point(143, 14);
            this.radRevenue7DaysChart.Name = "radRevenue7DaysChart";
            this.radRevenue7DaysChart.Size = new System.Drawing.Size(237, 24);
            this.radRevenue7DaysChart.TabIndex = 0;
            this.radRevenue7DaysChart.TabStop = true;
            this.radRevenue7DaysChart.Text = "Doanh thu 7 ngày gần đây";
            this.radRevenue7DaysChart.UseVisualStyleBackColor = true;
            this.radRevenue7DaysChart.Click += new System.EventHandler(this.radRevenue7DaysChart_Click);
            // 
            // FrmStatisticalChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 634);
            this.Controls.Add(this.tableLayoutPanel9);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmStatisticalChart";
            this.Text = "FrmStatisticalChart";
            this.Load += new System.EventHandler(this.FrmStatisticalChart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartStatistical)).EndInit();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.pnStatical.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox15.ResumeLayout(false);
            this.panel20.ResumeLayout(false);
            this.panel21.ResumeLayout(false);
            this.pnTypeShape.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.groupBox17.ResumeLayout(false);
            this.panel23.ResumeLayout(false);
            this.panel23.PerformLayout();
            this.pnTypeStatical.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.groupBox16.ResumeLayout(false);
            this.panel22.ResumeLayout(false);
            this.panel22.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartStatistical;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.GroupBox groupBox17;
        private System.Windows.Forms.Panel panel23;
        private System.Windows.Forms.RadioButton radLineChart_Chart;
        private System.Windows.Forms.RadioButton radCircleChart_Chart;
        private System.Windows.Forms.RadioButton radColumnChart_Chart;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.RadioButton radSlowestSellerChart;
        private System.Windows.Forms.RadioButton radBestSellerChart;
        private System.Windows.Forms.RadioButton radRevenue3MonthsChart;
        private System.Windows.Forms.RadioButton radRevenue7DaysChart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnTypeShape;
        private System.Windows.Forms.Panel pnTypeStatical;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel pnStatical;
    }
}