using System.Windows.Forms;

namespace BaketyManagement
{
    partial class FrmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdmin));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.tcAccount = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbbListStaff = new System.Windows.Forms.ComboBox();
            this.txtIdStaffAccount = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.ckbStaff = new System.Windows.Forms.CheckBox();
            this.label37 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtAccountSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdbWoman = new System.Windows.Forms.RadioButton();
            this.rdbMan = new System.Windows.Forms.RadioButton();
            this.txtWorkDay = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtAddressStaff = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPhoneStaff = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNameStaff = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvStaff = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.btnDisplayStaff = new System.Windows.Forms.Button();
            this.btnEditStaff = new System.Windows.Forms.Button();
            this.btnDeleteStaff = new System.Windows.Forms.Button();
            this.txtStaffSearch = new System.Windows.Forms.TextBox();
            this.btnStaffSearch = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbbCategory = new System.Windows.Forms.ComboBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtNameCake = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.dgvCake = new System.Windows.Forms.DataGridView();
            this.panel9 = new System.Windows.Forms.Panel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.btnCakeEdit = new System.Windows.Forms.Button();
            this.btnCakeDisplay = new System.Windows.Forms.Button();
            this.btnCakeDel = new System.Windows.Forms.Button();
            this.txtCakeSearch = new System.Windows.Forms.TextBox();
            this.btnCakeSearch = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtAddressSupplier = new System.Windows.Forms.TextBox();
            this.txtPhoneSupplier = new System.Windows.Forms.TextBox();
            this.txtIdSupplier = new System.Windows.Forms.TextBox();
            this.txtNameSupplier = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.dgvSupplier = new System.Windows.Forms.DataGridView();
            this.panel12 = new System.Windows.Forms.Panel();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnAddSupplier = new System.Windows.Forms.Button();
            this.btnEditSupplier = new System.Windows.Forms.Button();
            this.btnViewSupplier = new System.Windows.Forms.Button();
            this.btnDelSupplier = new System.Windows.Forms.Button();
            this.txtSearchKeySupplier = new System.Windows.Forms.TextBox();
            this.btnSearchSupplier = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.panel14 = new System.Windows.Forms.Panel();
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.panel15 = new System.Windows.Forms.Panel();
            this.dgvBillDetail = new System.Windows.Forms.DataGridView();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.panel13 = new System.Windows.Forms.Panel();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDay = new System.Windows.Forms.DateTimePicker();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txtSearchKeyBill = new System.Windows.Forms.TextBox();
            this.btnFilterBill = new System.Windows.Forms.Button();
            this.btnSearchBill = new System.Windows.Forms.Button();
            this.btnViewBill = new System.Windows.Forms.Button();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.txtNameCategory = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.panel18 = new System.Windows.Forms.Panel();
            this.dgvCategory = new System.Windows.Forms.DataGridView();
            this.panel19 = new System.Windows.Forms.Panel();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnDisplayCategory = new System.Windows.Forms.Button();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.btnEditCategory = new System.Windows.Forms.Button();
            this.txtCategorySearch = new System.Windows.Forms.TextBox();
            this.btnCategorySearch = new System.Windows.Forms.Button();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.panel28 = new System.Windows.Forms.Panel();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.dgvCakePresent = new System.Windows.Forms.DataGridView();
            this.panel30 = new System.Windows.Forms.Panel();
            this.groupBox23 = new System.Windows.Forms.GroupBox();
            this.cbbCategoryCake = new System.Windows.Forms.ComboBox();
            this.cbbNameSupplier = new System.Windows.Forms.ComboBox();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.txtIdCakeImportTabImport = new System.Windows.Forms.TextBox();
            this.txtExportPrice = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.dtpMfgImport = new System.Windows.Forms.DateTimePicker();
            this.txtNameCakeImport = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.dtpDayImport = new System.Windows.Forms.DateTimePicker();
            this.dtpExpImport = new System.Windows.Forms.DateTimePicker();
            this.txtImportPrice = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.txtAmountImport = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.txtSizeCakeImport = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.panel31 = new System.Windows.Forms.Panel();
            this.groupBox25 = new System.Windows.Forms.GroupBox();
            this.txtSearchCakeImport = new System.Windows.Forms.TextBox();
            this.btnSearchCakeImport = new System.Windows.Forms.Button();
            this.panel32 = new System.Windows.Forms.Panel();
            this.groupBox24 = new System.Windows.Forms.GroupBox();
            this.btnCancelCakeImport = new System.Windows.Forms.Button();
            this.btnDisplayCakePresent = new System.Windows.Forms.Button();
            this.btnAddImportCoupon = new System.Windows.Forms.Button();
            this.btnEditImportCoupon = new System.Windows.Forms.Button();
            this.btnDeleteImportCoupon = new System.Windows.Forms.Button();
            this.panel33 = new System.Windows.Forms.Panel();
            this.groupBox21 = new System.Windows.Forms.GroupBox();
            this.dgvDetailImport = new System.Windows.Forms.DataGridView();
            this.panel34 = new System.Windows.Forms.Panel();
            this.groupBox26 = new System.Windows.Forms.GroupBox();
            this.txtSearchDetailImport = new System.Windows.Forms.TextBox();
            this.btnSearchDetailImport = new System.Windows.Forms.Button();
            this.panel36 = new System.Windows.Forms.Panel();
            this.groupBox27 = new System.Windows.Forms.GroupBox();
            this.btnInputCoupon = new System.Windows.Forms.Button();
            this.tabPage12 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.gbStatisticalList = new System.Windows.Forms.GroupBox();
            this.panel25 = new System.Windows.Forms.Panel();
            this.dgvStatistical = new System.Windows.Forms.DataGridView();
            this.panel26 = new System.Windows.Forms.Panel();
            this.groupBox20 = new System.Windows.Forms.GroupBox();
            this.panel27 = new System.Windows.Forms.Panel();
            this.btnStatisticalList = new System.Windows.Forms.Button();
            this.groupBox22 = new System.Windows.Forms.GroupBox();
            this.panel29 = new System.Windows.Forms.Panel();
            this.radSlowestSellerList = new System.Windows.Forms.RadioButton();
            this.radBestSellerList = new System.Windows.Forms.RadioButton();
            this.radRevenue3MonthsList = new System.Windows.Forms.RadioButton();
            this.radRevenue7DaysList = new System.Windows.Forms.RadioButton();
            this.tabPage13 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.panel20 = new System.Windows.Forms.Panel();
            this.chartStatistical = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel21 = new System.Windows.Forms.Panel();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.panel24 = new System.Windows.Forms.Panel();
            this.btnStatisticalChart = new System.Windows.Forms.Button();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.panel23 = new System.Windows.Forms.Panel();
            this.radLineChart_Chart = new System.Windows.Forms.RadioButton();
            this.radCircleChart_Chart = new System.Windows.Forms.RadioButton();
            this.radColumnChart_Chart = new System.Windows.Forms.RadioButton();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.panel22 = new System.Windows.Forms.Panel();
            this.radSlowestSellerChart = new System.Windows.Forms.RadioButton();
            this.radBestSellerChart = new System.Windows.Forms.RadioButton();
            this.radRevenue3MonthsChart = new System.Windows.Forms.RadioButton();
            this.radRevenue7DaysChart = new System.Windows.Forms.RadioButton();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel13 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox28 = new System.Windows.Forms.GroupBox();
            this.panel35 = new System.Windows.Forms.Panel();
            this.dgvCouponImport = new System.Windows.Forms.DataGridView();
            this.groupBox29 = new System.Windows.Forms.GroupBox();
            this.panel37 = new System.Windows.Forms.Panel();
            this.dgvDetailCouponImport = new System.Windows.Forms.DataGridView();
            this.groupBox30 = new System.Windows.Forms.GroupBox();
            this.panel38 = new System.Windows.Forms.Panel();
            this.dtpEndImportDay = new System.Windows.Forms.DateTimePicker();
            this.dtpStartImportDay = new System.Windows.Forms.DateTimePicker();
            this.label36 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.txtSearchImportCoupon = new System.Windows.Forms.TextBox();
            this.btnFilterCouponImport = new System.Windows.Forms.Button();
            this.btnSearchCouponImport = new System.Windows.Forms.Button();
            this.btnDisplayCouponImport = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.txtExpImport = new System.Windows.Forms.TextBox();
            this.txtPriceCakeImport = new System.Windows.Forms.TextBox();
            this.txtIdCakeImport = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.tcAccount.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            this.panel6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCake)).BeginInit();
            this.panel9.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel10.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).BeginInit();
            this.panel12.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            this.groupBox10.SuspendLayout();
            this.panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillDetail)).BeginInit();
            this.groupBox11.SuspendLayout();
            this.panel13.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.panel17.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.panel18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).BeginInit();
            this.panel19.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.panel28.SuspendLayout();
            this.groupBox19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCakePresent)).BeginInit();
            this.panel30.SuspendLayout();
            this.groupBox23.SuspendLayout();
            this.panel31.SuspendLayout();
            this.groupBox25.SuspendLayout();
            this.panel32.SuspendLayout();
            this.groupBox24.SuspendLayout();
            this.panel33.SuspendLayout();
            this.groupBox21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailImport)).BeginInit();
            this.panel34.SuspendLayout();
            this.groupBox26.SuspendLayout();
            this.panel36.SuspendLayout();
            this.groupBox27.SuspendLayout();
            this.tabPage12.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.gbStatisticalList.SuspendLayout();
            this.panel25.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistical)).BeginInit();
            this.panel26.SuspendLayout();
            this.groupBox20.SuspendLayout();
            this.panel27.SuspendLayout();
            this.groupBox22.SuspendLayout();
            this.panel29.SuspendLayout();
            this.tabPage13.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.panel20.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartStatistical)).BeginInit();
            this.panel21.SuspendLayout();
            this.groupBox18.SuspendLayout();
            this.panel24.SuspendLayout();
            this.groupBox17.SuspendLayout();
            this.panel23.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.panel22.SuspendLayout();
            this.tabPage9.SuspendLayout();
            this.tableLayoutPanel12.SuspendLayout();
            this.tableLayoutPanel13.SuspendLayout();
            this.groupBox28.SuspendLayout();
            this.panel35.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCouponImport)).BeginInit();
            this.groupBox29.SuspendLayout();
            this.panel37.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailCouponImport)).BeginInit();
            this.groupBox30.SuspendLayout();
            this.panel38.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.panel16.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcAccount
            // 
            this.tcAccount.Controls.Add(this.tabPage1);
            this.tcAccount.Controls.Add(this.tabPage2);
            this.tcAccount.Controls.Add(this.tabPage3);
            this.tcAccount.Controls.Add(this.tabPage4);
            this.tcAccount.Controls.Add(this.tabPage5);
            this.tcAccount.Controls.Add(this.tabPage7);
            this.tcAccount.Controls.Add(this.tabPage8);
            this.tcAccount.Controls.Add(this.tabPage12);
            this.tcAccount.Controls.Add(this.tabPage9);
            this.tcAccount.Controls.Add(this.tabPage10);
            this.tcAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcAccount.ImageList = this.imageList1;
            this.tcAccount.Location = new System.Drawing.Point(0, 0);
            this.tcAccount.Name = "tcAccount";
            this.tcAccount.SelectedIndex = 0;
            this.tcAccount.Size = new System.Drawing.Size(1540, 845);
            this.tcAccount.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.ImageIndex = 0;
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1532, 812);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tài Khoản";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1526, 806);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1520, 194);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbbListStaff);
            this.groupBox2.Controls.Add(this.txtIdStaffAccount);
            this.groupBox2.Controls.Add(this.txtPassword);
            this.groupBox2.Controls.Add(this.txtUserName);
            this.groupBox2.Controls.Add(this.ckbStaff);
            this.groupBox2.Controls.Add(this.label37);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1520, 194);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết tài khoản";
            // 
            // cbbListStaff
            // 
            this.cbbListStaff.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbbListStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbListStaff.FormattingEnabled = true;
            this.cbbListStaff.Location = new System.Drawing.Point(924, 32);
            this.cbbListStaff.Name = "cbbListStaff";
            this.cbbListStaff.Size = new System.Drawing.Size(266, 28);
            this.cbbListStaff.TabIndex = 5;
            this.cbbListStaff.SelectedIndexChanged += new System.EventHandler(this.cbbListStaff_SelectedIndexChanged);
            // 
            // txtIdStaffAccount
            // 
            this.txtIdStaffAccount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtIdStaffAccount.Enabled = false;
            this.txtIdStaffAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdStaffAccount.Location = new System.Drawing.Point(924, 85);
            this.txtIdStaffAccount.Name = "txtIdStaffAccount";
            this.txtIdStaffAccount.ReadOnly = true;
            this.txtIdStaffAccount.Size = new System.Drawing.Size(266, 26);
            this.txtIdStaffAccount.TabIndex = 4;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPassword.Enabled = false;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(441, 85);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ReadOnly = true;
            this.txtPassword.Size = new System.Drawing.Size(266, 26);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(441, 32);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(266, 26);
            this.txtUserName.TabIndex = 4;
            // 
            // ckbStaff
            // 
            this.ckbStaff.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ckbStaff.AutoSize = true;
            this.ckbStaff.Location = new System.Drawing.Point(924, 134);
            this.ckbStaff.Name = "ckbStaff";
            this.ckbStaff.Size = new System.Drawing.Size(111, 24);
            this.ckbStaff.TabIndex = 3;
            this.ckbStaff.Text = "Nhân Viên";
            this.ckbStaff.UseVisualStyleBackColor = true;
            // 
            // label37
            // 
            this.label37.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(778, 91);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(115, 20);
            this.label37.TabIndex = 2;
            this.label37.Text = "Mã nhân viên";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(778, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Nhân Viên";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(331, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật Khẩu";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(331, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tài Khoản";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvAccount);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(3, 203);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1520, 350);
            this.panel2.TabIndex = 1;
            // 
            // dgvAccount
            // 
            this.dgvAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAccount.Location = new System.Drawing.Point(0, 0);
            this.dgvAccount.MultiSelect = false;
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.ReadOnly = true;
            this.dgvAccount.RowHeadersWidth = 51;
            this.dgvAccount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccount.Size = new System.Drawing.Size(1520, 350);
            this.dgvAccount.TabIndex = 0;
            this.dgvAccount.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccount_CellClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 559);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1520, 244);
            this.panel3.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnDisplay);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.txtAccountSearch);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1520, 244);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(342, 63);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(151, 20);
            this.label20.TabIndex = 2;
            this.label20.Text = "Tìm kiếm theo tên";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdd.Location = new System.Drawing.Point(552, 141);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(162, 65);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDisplay.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDisplay.Location = new System.Drawing.Point(298, 141);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(162, 65);
            this.btnDisplay.TabIndex = 0;
            this.btnDisplay.Text = "Xem";
            this.btnDisplay.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDelete.Location = new System.Drawing.Point(806, 141);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(162, 65);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReset.Location = new System.Drawing.Point(1060, 141);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(162, 65);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Đặt lại mật khẩu";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtAccountSearch
            // 
            this.txtAccountSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAccountSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountSearch.Location = new System.Drawing.Point(511, 60);
            this.txtAccountSearch.Name = "txtAccountSearch";
            this.txtAccountSearch.Size = new System.Drawing.Size(502, 26);
            this.txtAccountSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSearch.Location = new System.Drawing.Point(1031, 38);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(162, 65);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel2);
            this.tabPage2.ImageIndex = 6;
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1532, 812);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Nhân Viên";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel5, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel6, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1526, 806);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1520, 194);
            this.panel4.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdbWoman);
            this.groupBox3.Controls.Add(this.rdbMan);
            this.groupBox3.Controls.Add(this.txtWorkDay);
            this.groupBox3.Controls.Add(this.txtSalary);
            this.groupBox3.Controls.Add(this.txtAddressStaff);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtPhoneStaff);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtNameStaff);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1520, 194);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi tiết nhân viên";
            // 
            // rdbWoman
            // 
            this.rdbWoman.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdbWoman.AutoSize = true;
            this.rdbWoman.Location = new System.Drawing.Point(538, 86);
            this.rdbWoman.Name = "rdbWoman";
            this.rdbWoman.Size = new System.Drawing.Size(49, 24);
            this.rdbWoman.TabIndex = 6;
            this.rdbWoman.TabStop = true;
            this.rdbWoman.Text = "Nữ";
            this.rdbWoman.UseVisualStyleBackColor = true;
            // 
            // rdbMan
            // 
            this.rdbMan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdbMan.AutoSize = true;
            this.rdbMan.Location = new System.Drawing.Point(445, 86);
            this.rdbMan.Name = "rdbMan";
            this.rdbMan.Size = new System.Drawing.Size(63, 24);
            this.rdbMan.TabIndex = 6;
            this.rdbMan.TabStop = true;
            this.rdbMan.Text = "Nam";
            this.rdbMan.UseVisualStyleBackColor = true;
            // 
            // txtWorkDay
            // 
            this.txtWorkDay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtWorkDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWorkDay.Location = new System.Drawing.Point(943, 133);
            this.txtWorkDay.Name = "txtWorkDay";
            this.txtWorkDay.Size = new System.Drawing.Size(266, 26);
            this.txtWorkDay.TabIndex = 4;
            // 
            // txtSalary
            // 
            this.txtSalary.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalary.Location = new System.Drawing.Point(943, 85);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(266, 26);
            this.txtSalary.TabIndex = 4;
            // 
            // txtAddressStaff
            // 
            this.txtAddressStaff.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAddressStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddressStaff.Location = new System.Drawing.Point(943, 37);
            this.txtAddressStaff.Name = "txtAddressStaff";
            this.txtAddressStaff.Size = new System.Drawing.Size(266, 26);
            this.txtAddressStaff.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(809, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Ngày Làm Việc";
            // 
            // txtPhoneStaff
            // 
            this.txtPhoneStaff.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPhoneStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneStaff.Location = new System.Drawing.Point(445, 133);
            this.txtPhoneStaff.Name = "txtPhoneStaff";
            this.txtPhoneStaff.Size = new System.Drawing.Size(266, 26);
            this.txtPhoneStaff.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(809, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Hệ Số Lương";
            // 
            // txtNameStaff
            // 
            this.txtNameStaff.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNameStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameStaff.Location = new System.Drawing.Point(445, 34);
            this.txtNameStaff.Name = "txtNameStaff";
            this.txtNameStaff.Size = new System.Drawing.Size(266, 26);
            this.txtNameStaff.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(809, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Địa Chỉ";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(312, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Điện Thoại";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(312, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Giới Tính";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(312, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tên Nhân Viên";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgvStaff);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(3, 203);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1520, 350);
            this.panel5.TabIndex = 1;
            // 
            // dgvStaff
            // 
            this.dgvStaff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStaff.Location = new System.Drawing.Point(0, 0);
            this.dgvStaff.MultiSelect = false;
            this.dgvStaff.Name = "dgvStaff";
            this.dgvStaff.ReadOnly = true;
            this.dgvStaff.RowHeadersWidth = 51;
            this.dgvStaff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStaff.Size = new System.Drawing.Size(1520, 350);
            this.dgvStaff.TabIndex = 0;
            this.dgvStaff.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.groupBox4);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 559);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1520, 244);
            this.panel6.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.btnAddStaff);
            this.groupBox4.Controls.Add(this.btnDisplayStaff);
            this.groupBox4.Controls.Add(this.btnEditStaff);
            this.groupBox4.Controls.Add(this.btnDeleteStaff);
            this.groupBox4.Controls.Add(this.txtStaffSearch);
            this.groupBox4.Controls.Add(this.btnStaffSearch);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1520, 244);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chức năng";
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(319, 70);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(151, 20);
            this.label21.TabIndex = 2;
            this.label21.Text = "Tìm kiếm theo tên";
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddStaff.Location = new System.Drawing.Point(572, 140);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(162, 65);
            this.btnAddStaff.TabIndex = 0;
            this.btnAddStaff.Text = "Thêm";
            this.btnAddStaff.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddStaff.UseVisualStyleBackColor = true;
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // btnDisplayStaff
            // 
            this.btnDisplayStaff.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDisplayStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnDisplayStaff.ForeColor = System.Drawing.Color.White;
            this.btnDisplayStaff.Location = new System.Drawing.Point(335, 140);
            this.btnDisplayStaff.Name = "btnDisplayStaff";
            this.btnDisplayStaff.Size = new System.Drawing.Size(162, 65);
            this.btnDisplayStaff.TabIndex = 0;
            this.btnDisplayStaff.Text = "Xem";
            this.btnDisplayStaff.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDisplayStaff.UseVisualStyleBackColor = false;
            this.btnDisplayStaff.Click += new System.EventHandler(this.btnDisplayStaff_Click);
            // 
            // btnEditStaff
            // 
            this.btnEditStaff.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEditStaff.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditStaff.Location = new System.Drawing.Point(786, 140);
            this.btnEditStaff.Name = "btnEditStaff";
            this.btnEditStaff.Size = new System.Drawing.Size(162, 65);
            this.btnEditStaff.TabIndex = 0;
            this.btnEditStaff.Text = "Sửa";
            this.btnEditStaff.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditStaff.UseVisualStyleBackColor = true;
            this.btnEditStaff.Click += new System.EventHandler(this.btnEditStaff_Click);
            // 
            // btnDeleteStaff
            // 
            this.btnDeleteStaff.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDeleteStaff.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDeleteStaff.Location = new System.Drawing.Point(1000, 140);
            this.btnDeleteStaff.Name = "btnDeleteStaff";
            this.btnDeleteStaff.Size = new System.Drawing.Size(162, 65);
            this.btnDeleteStaff.TabIndex = 0;
            this.btnDeleteStaff.Text = "Xóa";
            this.btnDeleteStaff.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDeleteStaff.UseVisualStyleBackColor = true;
            this.btnDeleteStaff.Click += new System.EventHandler(this.btnDeleteStaff_Click);
            // 
            // txtStaffSearch
            // 
            this.txtStaffSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtStaffSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffSearch.Location = new System.Drawing.Point(504, 64);
            this.txtStaffSearch.Name = "txtStaffSearch";
            this.txtStaffSearch.Size = new System.Drawing.Size(502, 26);
            this.txtStaffSearch.TabIndex = 1;
            // 
            // btnStaffSearch
            // 
            this.btnStaffSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnStaffSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnStaffSearch.Location = new System.Drawing.Point(1040, 39);
            this.btnStaffSearch.Name = "btnStaffSearch";
            this.btnStaffSearch.Size = new System.Drawing.Size(162, 65);
            this.btnStaffSearch.TabIndex = 0;
            this.btnStaffSearch.Text = "Tìm";
            this.btnStaffSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStaffSearch.UseVisualStyleBackColor = true;
            this.btnStaffSearch.Click += new System.EventHandler(this.btnStaffSearch_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableLayoutPanel3);
            this.tabPage3.ImageIndex = 2;
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1532, 812);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Sản Phẩm";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.panel7, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel8, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.panel9, 0, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1532, 812);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.groupBox5);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(3, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1526, 194);
            this.panel7.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbbCategory);
            this.groupBox5.Controls.Add(this.txtSize);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.txtPrice);
            this.groupBox5.Controls.Add(this.txtNameCake);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(0, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1526, 194);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Chi tiết sản phẩm";
            // 
            // cbbCategory
            // 
            this.cbbCategory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbCategory.FormattingEnabled = true;
            this.cbbCategory.Location = new System.Drawing.Point(936, 104);
            this.cbbCategory.Name = "cbbCategory";
            this.cbbCategory.Size = new System.Drawing.Size(266, 28);
            this.cbbCategory.TabIndex = 6;
            // 
            // txtSize
            // 
            this.txtSize.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSize.Location = new System.Drawing.Point(936, 61);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(266, 26);
            this.txtSize.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(824, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "Loại Bánh";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(824, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "Kích Thước";
            // 
            // txtPrice
            // 
            this.txtPrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(455, 107);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(266, 26);
            this.txtPrice.TabIndex = 4;
            // 
            // txtNameCake
            // 
            this.txtNameCake.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNameCake.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameCake.Location = new System.Drawing.Point(455, 61);
            this.txtNameCake.Name = "txtNameCake";
            this.txtNameCake.Size = new System.Drawing.Size(266, 26);
            this.txtNameCake.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(324, 112);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 20);
            this.label13.TabIndex = 2;
            this.label13.Text = "Giá";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(324, 64);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 20);
            this.label14.TabIndex = 2;
            this.label14.Text = "Tên Bánh";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.dgvCake);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel8.Location = new System.Drawing.Point(3, 203);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1526, 356);
            this.panel8.TabIndex = 1;
            // 
            // dgvCake
            // 
            this.dgvCake.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCake.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCake.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCake.Location = new System.Drawing.Point(0, 0);
            this.dgvCake.MultiSelect = false;
            this.dgvCake.Name = "dgvCake";
            this.dgvCake.ReadOnly = true;
            this.dgvCake.RowHeadersWidth = 51;
            this.dgvCake.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCake.Size = new System.Drawing.Size(1526, 356);
            this.dgvCake.TabIndex = 0;
            this.dgvCake.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCake_CellClick);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.groupBox6);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(3, 565);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1526, 244);
            this.panel9.TabIndex = 2;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label22);
            this.groupBox6.Controls.Add(this.btnCakeEdit);
            this.groupBox6.Controls.Add(this.btnCakeDisplay);
            this.groupBox6.Controls.Add(this.btnCakeDel);
            this.groupBox6.Controls.Add(this.txtCakeSearch);
            this.groupBox6.Controls.Add(this.btnCakeSearch);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(0, 0);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1526, 244);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Chức năng";
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(337, 62);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(151, 20);
            this.label22.TabIndex = 2;
            this.label22.Text = "Tìm kiếm theo tên";
            // 
            // btnCakeEdit
            // 
            this.btnCakeEdit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCakeEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCakeEdit.Location = new System.Drawing.Point(924, 143);
            this.btnCakeEdit.Name = "btnCakeEdit";
            this.btnCakeEdit.Size = new System.Drawing.Size(162, 65);
            this.btnCakeEdit.TabIndex = 0;
            this.btnCakeEdit.Text = "Sửa";
            this.btnCakeEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCakeEdit.UseVisualStyleBackColor = true;
            this.btnCakeEdit.Click += new System.EventHandler(this.btnCakeEdit_Click);
            // 
            // btnCakeDisplay
            // 
            this.btnCakeDisplay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCakeDisplay.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCakeDisplay.Location = new System.Drawing.Point(674, 143);
            this.btnCakeDisplay.Name = "btnCakeDisplay";
            this.btnCakeDisplay.Size = new System.Drawing.Size(162, 65);
            this.btnCakeDisplay.TabIndex = 0;
            this.btnCakeDisplay.Text = "Xem";
            this.btnCakeDisplay.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCakeDisplay.UseVisualStyleBackColor = true;
            this.btnCakeDisplay.Click += new System.EventHandler(this.btnCakeDisplay_Click);
            // 
            // btnCakeDel
            // 
            this.btnCakeDel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCakeDel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCakeDel.Location = new System.Drawing.Point(424, 143);
            this.btnCakeDel.Name = "btnCakeDel";
            this.btnCakeDel.Size = new System.Drawing.Size(162, 65);
            this.btnCakeDel.TabIndex = 0;
            this.btnCakeDel.Text = "Xóa";
            this.btnCakeDel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCakeDel.UseVisualStyleBackColor = true;
            this.btnCakeDel.Click += new System.EventHandler(this.btnCakeDel_Click);
            // 
            // txtCakeSearch
            // 
            this.txtCakeSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCakeSearch.Location = new System.Drawing.Point(507, 56);
            this.txtCakeSearch.Name = "txtCakeSearch";
            this.txtCakeSearch.Size = new System.Drawing.Size(502, 26);
            this.txtCakeSearch.TabIndex = 1;
            // 
            // btnCakeSearch
            // 
            this.btnCakeSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCakeSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCakeSearch.Location = new System.Drawing.Point(1028, 37);
            this.btnCakeSearch.Name = "btnCakeSearch";
            this.btnCakeSearch.Size = new System.Drawing.Size(162, 65);
            this.btnCakeSearch.TabIndex = 0;
            this.btnCakeSearch.Text = "Tìm";
            this.btnCakeSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCakeSearch.UseVisualStyleBackColor = true;
            this.btnCakeSearch.Click += new System.EventHandler(this.btnCakeSearch_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.tabPage4.Controls.Add(this.tableLayoutPanel4);
            this.tabPage4.ImageIndex = 5;
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1532, 812);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Nhà Cung Cấp";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.panel10, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.panel11, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.panel12, 0, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1526, 806);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.groupBox7);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(3, 3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1520, 194);
            this.panel10.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.groupBox7.Controls.Add(this.txtAddressSupplier);
            this.groupBox7.Controls.Add(this.txtPhoneSupplier);
            this.groupBox7.Controls.Add(this.txtIdSupplier);
            this.groupBox7.Controls.Add(this.txtNameSupplier);
            this.groupBox7.Controls.Add(this.label17);
            this.groupBox7.Controls.Add(this.label18);
            this.groupBox7.Controls.Add(this.label12);
            this.groupBox7.Controls.Add(this.label19);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.ForeColor = System.Drawing.Color.White;
            this.groupBox7.Location = new System.Drawing.Point(0, 0);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(1520, 194);
            this.groupBox7.TabIndex = 0;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Chi tiết nhà cung cấp";
            // 
            // txtAddressSupplier
            // 
            this.txtAddressSupplier.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAddressSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddressSupplier.Location = new System.Drawing.Point(938, 109);
            this.txtAddressSupplier.Name = "txtAddressSupplier";
            this.txtAddressSupplier.Size = new System.Drawing.Size(266, 26);
            this.txtAddressSupplier.TabIndex = 4;
            // 
            // txtPhoneSupplier
            // 
            this.txtPhoneSupplier.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPhoneSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneSupplier.Location = new System.Drawing.Point(938, 59);
            this.txtPhoneSupplier.Name = "txtPhoneSupplier";
            this.txtPhoneSupplier.Size = new System.Drawing.Size(266, 26);
            this.txtPhoneSupplier.TabIndex = 4;
            // 
            // txtIdSupplier
            // 
            this.txtIdSupplier.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtIdSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdSupplier.Location = new System.Drawing.Point(493, 65);
            this.txtIdSupplier.Name = "txtIdSupplier";
            this.txtIdSupplier.ReadOnly = true;
            this.txtIdSupplier.Size = new System.Drawing.Size(266, 26);
            this.txtIdSupplier.TabIndex = 4;
            // 
            // txtNameSupplier
            // 
            this.txtNameSupplier.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNameSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameSupplier.Location = new System.Drawing.Point(493, 106);
            this.txtNameSupplier.Name = "txtNameSupplier";
            this.txtNameSupplier.Size = new System.Drawing.Size(266, 26);
            this.txtNameSupplier.TabIndex = 4;
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(817, 115);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(64, 20);
            this.label17.TabIndex = 2;
            this.label17.Text = "Địa chỉ";
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(817, 65);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(115, 20);
            this.label18.TabIndex = 2;
            this.label18.Text = "Số điện thoại";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(321, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(146, 20);
            this.label12.TabIndex = 2;
            this.label12.Text = "Mã nhà cung cấp";
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(316, 112);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(152, 20);
            this.label19.TabIndex = 2;
            this.label19.Text = "Tên nhà cung cấp";
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.dgvSupplier);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel11.Location = new System.Drawing.Point(3, 203);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1520, 350);
            this.panel11.TabIndex = 1;
            // 
            // dgvSupplier
            // 
            this.dgvSupplier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSupplier.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.dgvSupplier.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSupplier.Location = new System.Drawing.Point(0, 0);
            this.dgvSupplier.MultiSelect = false;
            this.dgvSupplier.Name = "dgvSupplier";
            this.dgvSupplier.ReadOnly = true;
            this.dgvSupplier.RowHeadersWidth = 51;
            this.dgvSupplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSupplier.Size = new System.Drawing.Size(1520, 350);
            this.dgvSupplier.TabIndex = 0;
            this.dgvSupplier.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSupplier_CellClick);
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.groupBox8);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Location = new System.Drawing.Point(3, 559);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(1520, 244);
            this.panel12.TabIndex = 2;
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.groupBox8.Controls.Add(this.label16);
            this.groupBox8.Controls.Add(this.btnAddSupplier);
            this.groupBox8.Controls.Add(this.btnEditSupplier);
            this.groupBox8.Controls.Add(this.btnViewSupplier);
            this.groupBox8.Controls.Add(this.btnDelSupplier);
            this.groupBox8.Controls.Add(this.txtSearchKeySupplier);
            this.groupBox8.Controls.Add(this.btnSearchSupplier);
            this.groupBox8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.ForeColor = System.Drawing.Color.White;
            this.groupBox8.Location = new System.Drawing.Point(0, 0);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(1520, 244);
            this.groupBox8.TabIndex = 0;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Chức năng";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(309, 64);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(264, 20);
            this.label16.TabIndex = 3;
            this.label16.Text = "Tìm kiếm theo tên nhà cung cấp";
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddSupplier.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddSupplier.Location = new System.Drawing.Point(1072, 145);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(162, 65);
            this.btnAddSupplier.TabIndex = 2;
            this.btnAddSupplier.Text = "Thêm";
            this.btnAddSupplier.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddSupplier.UseVisualStyleBackColor = true;
            this.btnAddSupplier.Click += new System.EventHandler(this.btnAddSupplier_Click);
            // 
            // btnEditSupplier
            // 
            this.btnEditSupplier.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEditSupplier.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditSupplier.Location = new System.Drawing.Point(810, 145);
            this.btnEditSupplier.Name = "btnEditSupplier";
            this.btnEditSupplier.Size = new System.Drawing.Size(162, 65);
            this.btnEditSupplier.TabIndex = 0;
            this.btnEditSupplier.Text = "Sửa";
            this.btnEditSupplier.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditSupplier.UseVisualStyleBackColor = true;
            this.btnEditSupplier.Click += new System.EventHandler(this.btnEditSupplier_Click);
            // 
            // btnViewSupplier
            // 
            this.btnViewSupplier.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnViewSupplier.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnViewSupplier.Location = new System.Drawing.Point(548, 145);
            this.btnViewSupplier.Name = "btnViewSupplier";
            this.btnViewSupplier.Size = new System.Drawing.Size(162, 65);
            this.btnViewSupplier.TabIndex = 0;
            this.btnViewSupplier.Text = "Xem";
            this.btnViewSupplier.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnViewSupplier.UseVisualStyleBackColor = true;
            this.btnViewSupplier.Click += new System.EventHandler(this.btnViewSupplier_Click);
            // 
            // btnDelSupplier
            // 
            this.btnDelSupplier.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDelSupplier.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDelSupplier.Location = new System.Drawing.Point(286, 145);
            this.btnDelSupplier.Name = "btnDelSupplier";
            this.btnDelSupplier.Size = new System.Drawing.Size(162, 65);
            this.btnDelSupplier.TabIndex = 0;
            this.btnDelSupplier.Text = "Xóa";
            this.btnDelSupplier.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDelSupplier.UseVisualStyleBackColor = true;
            this.btnDelSupplier.Click += new System.EventHandler(this.btnDelSupplier_Click);
            // 
            // txtSearchKeySupplier
            // 
            this.txtSearchKeySupplier.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSearchKeySupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchKeySupplier.Location = new System.Drawing.Point(579, 58);
            this.txtSearchKeySupplier.Name = "txtSearchKeySupplier";
            this.txtSearchKeySupplier.Size = new System.Drawing.Size(433, 26);
            this.txtSearchKeySupplier.TabIndex = 1;
            // 
            // btnSearchSupplier
            // 
            this.btnSearchSupplier.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSearchSupplier.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSearchSupplier.Location = new System.Drawing.Point(1050, 34);
            this.btnSearchSupplier.Name = "btnSearchSupplier";
            this.btnSearchSupplier.Size = new System.Drawing.Size(162, 65);
            this.btnSearchSupplier.TabIndex = 0;
            this.btnSearchSupplier.Text = "Tìm";
            this.btnSearchSupplier.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSearchSupplier.UseVisualStyleBackColor = true;
            this.btnSearchSupplier.Click += new System.EventHandler(this.btnSearchSupplier_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.tableLayoutPanel5);
            this.tabPage5.ImageIndex = 1;
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1532, 812);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Hóa Đơn";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.groupBox11, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1526, 806);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.groupBox9, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.groupBox10, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 550F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 550F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(1520, 550);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.panel14);
            this.groupBox9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox9.Location = new System.Drawing.Point(3, 3);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(754, 544);
            this.groupBox9.TabIndex = 0;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Danh sách hóa đơn";
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.dgvBill);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel14.Location = new System.Drawing.Point(3, 22);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(748, 519);
            this.panel14.TabIndex = 0;
            // 
            // dgvBill
            // 
            this.dgvBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBill.Location = new System.Drawing.Point(0, 0);
            this.dgvBill.MultiSelect = false;
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.ReadOnly = true;
            this.dgvBill.RowHeadersWidth = 51;
            this.dgvBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBill.Size = new System.Drawing.Size(748, 519);
            this.dgvBill.TabIndex = 0;
            this.dgvBill.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBill_CellClick);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.panel15);
            this.groupBox10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox10.Location = new System.Drawing.Point(763, 3);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(754, 544);
            this.groupBox10.TabIndex = 1;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Chi tiết hóa đơn";
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.dgvBillDetail);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel15.Location = new System.Drawing.Point(3, 22);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(748, 519);
            this.panel15.TabIndex = 0;
            // 
            // dgvBillDetail
            // 
            this.dgvBillDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBillDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBillDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBillDetail.Location = new System.Drawing.Point(0, 0);
            this.dgvBillDetail.MultiSelect = false;
            this.dgvBillDetail.Name = "dgvBillDetail";
            this.dgvBillDetail.ReadOnly = true;
            this.dgvBillDetail.RowHeadersWidth = 51;
            this.dgvBillDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBillDetail.Size = new System.Drawing.Size(748, 519);
            this.dgvBillDetail.TabIndex = 0;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.panel13);
            this.groupBox11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox11.Location = new System.Drawing.Point(3, 559);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(1520, 244);
            this.groupBox11.TabIndex = 1;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Chức năng";
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.dtpEndDate);
            this.panel13.Controls.Add(this.dtpStartDay);
            this.panel13.Controls.Add(this.label26);
            this.panel13.Controls.Add(this.label25);
            this.panel13.Controls.Add(this.label24);
            this.panel13.Controls.Add(this.label23);
            this.panel13.Controls.Add(this.txtSearchKeyBill);
            this.panel13.Controls.Add(this.btnFilterBill);
            this.panel13.Controls.Add(this.btnSearchBill);
            this.panel13.Controls.Add(this.btnViewBill);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel13.Location = new System.Drawing.Point(3, 22);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(1514, 219);
            this.panel13.TabIndex = 0;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpEndDate.CustomFormat = "dd/MM/yyyy";
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(474, 174);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(433, 26);
            this.dtpEndDate.TabIndex = 7;
            // 
            // dtpStartDay
            // 
            this.dtpStartDay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpStartDay.CustomFormat = "dd/MM/yyyy";
            this.dtpStartDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDay.Location = new System.Drawing.Point(474, 130);
            this.dtpStartDay.Name = "dtpStartDay";
            this.dtpStartDay.Size = new System.Drawing.Size(433, 26);
            this.dtpStartDay.TabIndex = 7;
            // 
            // label26
            // 
            this.label26.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(326, 180);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(119, 20);
            this.label26.TabIndex = 6;
            this.label26.Text = "Ngày kết thúc";
            // 
            // label25
            // 
            this.label25.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(330, 135);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(115, 20);
            this.label25.TabIndex = 6;
            this.label25.Text = "Ngày bắt đầu";
            // 
            // label24
            // 
            this.label24.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(197, 95);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(192, 20);
            this.label24.TabIndex = 6;
            this.label24.Text = "Lọc hóa đơn theo ngày";
            // 
            // label23
            // 
            this.label23.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(197, 48);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(261, 20);
            this.label23.TabIndex = 6;
            this.label23.Text = "Tìm hóa đơn theo tên nhân viên";
            // 
            // txtSearchKeyBill
            // 
            this.txtSearchKeyBill.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSearchKeyBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchKeyBill.Location = new System.Drawing.Point(474, 42);
            this.txtSearchKeyBill.Name = "txtSearchKeyBill";
            this.txtSearchKeyBill.Size = new System.Drawing.Size(433, 26);
            this.txtSearchKeyBill.TabIndex = 5;
            // 
            // btnFilterBill
            // 
            this.btnFilterBill.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnFilterBill.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFilterBill.Location = new System.Drawing.Point(935, 135);
            this.btnFilterBill.Name = "btnFilterBill";
            this.btnFilterBill.Size = new System.Drawing.Size(162, 65);
            this.btnFilterBill.TabIndex = 4;
            this.btnFilterBill.Text = "Lọc";
            this.btnFilterBill.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFilterBill.UseVisualStyleBackColor = true;
            this.btnFilterBill.Click += new System.EventHandler(this.btnFilterBill_Click);
            // 
            // btnSearchBill
            // 
            this.btnSearchBill.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSearchBill.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSearchBill.Location = new System.Drawing.Point(935, 18);
            this.btnSearchBill.Name = "btnSearchBill";
            this.btnSearchBill.Size = new System.Drawing.Size(162, 65);
            this.btnSearchBill.TabIndex = 4;
            this.btnSearchBill.Text = "Tìm";
            this.btnSearchBill.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSearchBill.UseVisualStyleBackColor = true;
            this.btnSearchBill.Click += new System.EventHandler(this.btnSearchBill_Click);
            // 
            // btnViewBill
            // 
            this.btnViewBill.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnViewBill.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnViewBill.Location = new System.Drawing.Point(1156, 18);
            this.btnViewBill.Name = "btnViewBill";
            this.btnViewBill.Size = new System.Drawing.Size(162, 65);
            this.btnViewBill.TabIndex = 1;
            this.btnViewBill.Text = "Xem";
            this.btnViewBill.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnViewBill.UseVisualStyleBackColor = true;
            this.btnViewBill.Click += new System.EventHandler(this.btnViewBill_Click);
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.tableLayoutPanel8);
            this.tabPage7.ImageIndex = 3;
            this.tabPage7.Location = new System.Drawing.Point(4, 29);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(1532, 812);
            this.tabPage7.TabIndex = 5;
            this.tabPage7.Text = "Loại Bánh";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Controls.Add(this.panel17, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.panel18, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.panel19, 0, 2);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 3;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(1532, 812);
            this.tableLayoutPanel8.TabIndex = 1;
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.groupBox13);
            this.panel17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel17.Location = new System.Drawing.Point(3, 3);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(1526, 194);
            this.panel17.TabIndex = 0;
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.txtNameCategory);
            this.groupBox13.Controls.Add(this.label29);
            this.groupBox13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox13.Location = new System.Drawing.Point(0, 0);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(1526, 194);
            this.groupBox13.TabIndex = 0;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Loại Bánh";
            // 
            // txtNameCategory
            // 
            this.txtNameCategory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNameCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameCategory.Location = new System.Drawing.Point(728, 61);
            this.txtNameCategory.Name = "txtNameCategory";
            this.txtNameCategory.Size = new System.Drawing.Size(266, 26);
            this.txtNameCategory.TabIndex = 4;
            // 
            // label29
            // 
            this.label29.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(533, 64);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(125, 20);
            this.label29.TabIndex = 2;
            this.label29.Text = "Tên Loại Bánh";
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.dgvCategory);
            this.panel18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel18.Location = new System.Drawing.Point(3, 203);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(1526, 356);
            this.panel18.TabIndex = 1;
            // 
            // dgvCategory
            // 
            this.dgvCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCategory.Location = new System.Drawing.Point(0, 0);
            this.dgvCategory.MultiSelect = false;
            this.dgvCategory.Name = "dgvCategory";
            this.dgvCategory.ReadOnly = true;
            this.dgvCategory.RowHeadersWidth = 51;
            this.dgvCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategory.Size = new System.Drawing.Size(1526, 356);
            this.dgvCategory.TabIndex = 0;
            this.dgvCategory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategory_CellClick);
            // 
            // panel19
            // 
            this.panel19.Controls.Add(this.groupBox14);
            this.panel19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel19.Location = new System.Drawing.Point(3, 565);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(1526, 244);
            this.panel19.TabIndex = 2;
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.label15);
            this.groupBox14.Controls.Add(this.btnDisplayCategory);
            this.groupBox14.Controls.Add(this.btnDeleteCategory);
            this.groupBox14.Controls.Add(this.btnAddCategory);
            this.groupBox14.Controls.Add(this.btnEditCategory);
            this.groupBox14.Controls.Add(this.txtCategorySearch);
            this.groupBox14.Controls.Add(this.btnCategorySearch);
            this.groupBox14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox14.Location = new System.Drawing.Point(0, 0);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(1526, 244);
            this.groupBox14.TabIndex = 0;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Chức năng";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(345, 63);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(151, 20);
            this.label15.TabIndex = 2;
            this.label15.Text = "Tìm kiếm theo tên";
            // 
            // btnDisplayCategory
            // 
            this.btnDisplayCategory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDisplayCategory.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDisplayCategory.Location = new System.Drawing.Point(343, 141);
            this.btnDisplayCategory.Name = "btnDisplayCategory";
            this.btnDisplayCategory.Size = new System.Drawing.Size(162, 65);
            this.btnDisplayCategory.TabIndex = 0;
            this.btnDisplayCategory.Text = "Xem";
            this.btnDisplayCategory.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDisplayCategory.UseVisualStyleBackColor = true;
            this.btnDisplayCategory.Click += new System.EventHandler(this.btnDisplayCategory_Click);
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDeleteCategory.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDeleteCategory.Location = new System.Drawing.Point(1021, 141);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(162, 65);
            this.btnDeleteCategory.TabIndex = 0;
            this.btnDeleteCategory.Text = "Xóa";
            this.btnDeleteCategory.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDeleteCategory.UseVisualStyleBackColor = true;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddCategory.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddCategory.Location = new System.Drawing.Point(569, 141);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(162, 65);
            this.btnAddCategory.TabIndex = 0;
            this.btnAddCategory.Text = "Thêm";
            this.btnAddCategory.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click_1);
            // 
            // btnEditCategory
            // 
            this.btnEditCategory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEditCategory.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditCategory.Location = new System.Drawing.Point(795, 141);
            this.btnEditCategory.Name = "btnEditCategory";
            this.btnEditCategory.Size = new System.Drawing.Size(162, 65);
            this.btnEditCategory.TabIndex = 0;
            this.btnEditCategory.Text = "Sửa";
            this.btnEditCategory.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditCategory.UseVisualStyleBackColor = true;
            this.btnEditCategory.Click += new System.EventHandler(this.btnEditCategory_Click);
            // 
            // txtCategorySearch
            // 
            this.txtCategorySearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCategorySearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategorySearch.Location = new System.Drawing.Point(514, 60);
            this.txtCategorySearch.Name = "txtCategorySearch";
            this.txtCategorySearch.Size = new System.Drawing.Size(502, 26);
            this.txtCategorySearch.TabIndex = 1;
            // 
            // btnCategorySearch
            // 
            this.btnCategorySearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCategorySearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCategorySearch.Location = new System.Drawing.Point(1034, 38);
            this.btnCategorySearch.Name = "btnCategorySearch";
            this.btnCategorySearch.Size = new System.Drawing.Size(162, 65);
            this.btnCategorySearch.TabIndex = 0;
            this.btnCategorySearch.Text = "Tìm";
            this.btnCategorySearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCategorySearch.UseVisualStyleBackColor = true;
            this.btnCategorySearch.Click += new System.EventHandler(this.btnCategorySearch_Click);
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.tableLayoutPanel11);
            this.tabPage8.ImageIndex = 4;
            this.tabPage8.Location = new System.Drawing.Point(4, 29);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(1532, 812);
            this.tabPage8.TabIndex = 6;
            this.tabPage8.Text = "Nhập Phiếu Nhập";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.ColumnCount = 2;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.Controls.Add(this.panel28, 0, 0);
            this.tableLayoutPanel11.Controls.Add(this.panel30, 1, 0);
            this.tableLayoutPanel11.Controls.Add(this.panel31, 0, 1);
            this.tableLayoutPanel11.Controls.Add(this.panel32, 1, 1);
            this.tableLayoutPanel11.Controls.Add(this.panel33, 0, 2);
            this.tableLayoutPanel11.Controls.Add(this.panel34, 1, 2);
            this.tableLayoutPanel11.Controls.Add(this.panel36, 0, 3);
            this.tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel11.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 4;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(1532, 812);
            this.tableLayoutPanel11.TabIndex = 0;
            // 
            // panel28
            // 
            this.panel28.Controls.Add(this.groupBox19);
            this.panel28.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel28.Location = new System.Drawing.Point(3, 3);
            this.panel28.Name = "panel28";
            this.panel28.Size = new System.Drawing.Size(760, 290);
            this.panel28.TabIndex = 0;
            // 
            // groupBox19
            // 
            this.groupBox19.Controls.Add(this.dgvCakePresent);
            this.groupBox19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox19.Location = new System.Drawing.Point(0, 0);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Size = new System.Drawing.Size(760, 290);
            this.groupBox19.TabIndex = 0;
            this.groupBox19.TabStop = false;
            this.groupBox19.Text = "Sản phẩm có sẵn";
            // 
            // dgvCakePresent
            // 
            this.dgvCakePresent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCakePresent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCakePresent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCakePresent.Location = new System.Drawing.Point(3, 22);
            this.dgvCakePresent.MultiSelect = false;
            this.dgvCakePresent.Name = "dgvCakePresent";
            this.dgvCakePresent.ReadOnly = true;
            this.dgvCakePresent.RowHeadersWidth = 51;
            this.dgvCakePresent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCakePresent.Size = new System.Drawing.Size(754, 265);
            this.dgvCakePresent.TabIndex = 0;
            this.dgvCakePresent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCakePresent_CellClick);
            // 
            // panel30
            // 
            this.panel30.Controls.Add(this.groupBox23);
            this.panel30.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel30.Location = new System.Drawing.Point(769, 3);
            this.panel30.Name = "panel30";
            this.panel30.Size = new System.Drawing.Size(760, 290);
            this.panel30.TabIndex = 1;
            // 
            // groupBox23
            // 
            this.groupBox23.Controls.Add(this.cbbCategoryCake);
            this.groupBox23.Controls.Add(this.cbbNameSupplier);
            this.groupBox23.Controls.Add(this.label38);
            this.groupBox23.Controls.Add(this.label39);
            this.groupBox23.Controls.Add(this.label35);
            this.groupBox23.Controls.Add(this.txtIdCakeImportTabImport);
            this.groupBox23.Controls.Add(this.txtExportPrice);
            this.groupBox23.Controls.Add(this.label40);
            this.groupBox23.Controls.Add(this.label27);
            this.groupBox23.Controls.Add(this.dtpMfgImport);
            this.groupBox23.Controls.Add(this.txtNameCakeImport);
            this.groupBox23.Controls.Add(this.label34);
            this.groupBox23.Controls.Add(this.dtpDayImport);
            this.groupBox23.Controls.Add(this.dtpExpImport);
            this.groupBox23.Controls.Add(this.txtImportPrice);
            this.groupBox23.Controls.Add(this.label28);
            this.groupBox23.Controls.Add(this.label33);
            this.groupBox23.Controls.Add(this.txtAmountImport);
            this.groupBox23.Controls.Add(this.label30);
            this.groupBox23.Controls.Add(this.label32);
            this.groupBox23.Controls.Add(this.txtSizeCakeImport);
            this.groupBox23.Controls.Add(this.label31);
            this.groupBox23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox23.Location = new System.Drawing.Point(0, 0);
            this.groupBox23.Name = "groupBox23";
            this.groupBox23.Size = new System.Drawing.Size(760, 290);
            this.groupBox23.TabIndex = 4;
            this.groupBox23.TabStop = false;
            this.groupBox23.Text = "groupBox23";
            // 
            // cbbCategoryCake
            // 
            this.cbbCategoryCake.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbCategoryCake.FormattingEnabled = true;
            this.cbbCategoryCake.Location = new System.Drawing.Point(534, 73);
            this.cbbCategoryCake.Name = "cbbCategoryCake";
            this.cbbCategoryCake.Size = new System.Drawing.Size(203, 28);
            this.cbbCategoryCake.TabIndex = 3;
            // 
            // cbbNameSupplier
            // 
            this.cbbNameSupplier.FormattingEnabled = true;
            this.cbbNameSupplier.Location = new System.Drawing.Point(148, 33);
            this.cbbNameSupplier.Name = "cbbNameSupplier";
            this.cbbNameSupplier.Size = new System.Drawing.Size(203, 28);
            this.cbbNameSupplier.TabIndex = 3;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(18, 41);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(80, 20);
            this.label38.TabIndex = 0;
            this.label38.Text = "Tên NCC";
            // 
            // label39
            // 
            this.label39.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(390, 114);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(96, 20);
            this.label39.TabIndex = 0;
            this.label39.Text = "Ngày Nhập";
            // 
            // label35
            // 
            this.label35.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(388, 76);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(90, 20);
            this.label35.TabIndex = 0;
            this.label35.Text = "Loại Bánh";
            // 
            // txtIdCakeImportTabImport
            // 
            this.txtIdCakeImportTabImport.Location = new System.Drawing.Point(148, 105);
            this.txtIdCakeImportTabImport.Name = "txtIdCakeImportTabImport";
            this.txtIdCakeImportTabImport.ReadOnly = true;
            this.txtIdCakeImportTabImport.Size = new System.Drawing.Size(203, 26);
            this.txtIdCakeImportTabImport.TabIndex = 1;
            // 
            // txtExportPrice
            // 
            this.txtExportPrice.Location = new System.Drawing.Point(148, 135);
            this.txtExportPrice.Name = "txtExportPrice";
            this.txtExportPrice.Size = new System.Drawing.Size(203, 26);
            this.txtExportPrice.TabIndex = 1;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(18, 108);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(80, 20);
            this.label40.TabIndex = 0;
            this.label40.Text = "Mã Bánh";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(18, 138);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(80, 20);
            this.label27.TabIndex = 0;
            this.label27.Text = "Giá Xuất";
            // 
            // dtpMfgImport
            // 
            this.dtpMfgImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpMfgImport.CustomFormat = "dd-MM-yyyy";
            this.dtpMfgImport.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMfgImport.Location = new System.Drawing.Point(534, 179);
            this.dtpMfgImport.Name = "dtpMfgImport";
            this.dtpMfgImport.Size = new System.Drawing.Size(200, 26);
            this.dtpMfgImport.TabIndex = 2;
            // 
            // txtNameCakeImport
            // 
            this.txtNameCakeImport.Location = new System.Drawing.Point(148, 73);
            this.txtNameCakeImport.Name = "txtNameCakeImport";
            this.txtNameCakeImport.Size = new System.Drawing.Size(203, 26);
            this.txtNameCakeImport.TabIndex = 1;
            // 
            // label34
            // 
            this.label34.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(388, 41);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(97, 20);
            this.label34.TabIndex = 0;
            this.label34.Text = "Kích Thước";
            // 
            // dtpDayImport
            // 
            this.dtpDayImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDayImport.CustomFormat = "dd-MM-yyyy";
            this.dtpDayImport.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDayImport.Location = new System.Drawing.Point(534, 108);
            this.dtpDayImport.Name = "dtpDayImport";
            this.dtpDayImport.Size = new System.Drawing.Size(200, 26);
            this.dtpDayImport.TabIndex = 2;
            // 
            // dtpExpImport
            // 
            this.dtpExpImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpExpImport.CustomFormat = "dd-MM-yyyy";
            this.dtpExpImport.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpExpImport.Location = new System.Drawing.Point(534, 143);
            this.dtpExpImport.Name = "dtpExpImport";
            this.dtpExpImport.Size = new System.Drawing.Size(200, 26);
            this.dtpExpImport.TabIndex = 2;
            // 
            // txtImportPrice
            // 
            this.txtImportPrice.Location = new System.Drawing.Point(148, 167);
            this.txtImportPrice.Name = "txtImportPrice";
            this.txtImportPrice.Size = new System.Drawing.Size(203, 26);
            this.txtImportPrice.TabIndex = 1;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(18, 76);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(86, 20);
            this.label28.TabIndex = 0;
            this.label28.Text = "Tên Bánh";
            // 
            // label33
            // 
            this.label33.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(390, 180);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(129, 20);
            this.label33.TabIndex = 0;
            this.label33.Text = "Ngày Sản Xuất";
            // 
            // txtAmountImport
            // 
            this.txtAmountImport.Location = new System.Drawing.Point(148, 202);
            this.txtAmountImport.Name = "txtAmountImport";
            this.txtAmountImport.Size = new System.Drawing.Size(203, 26);
            this.txtAmountImport.TabIndex = 1;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(18, 170);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(82, 20);
            this.label30.TabIndex = 0;
            this.label30.Text = "Giá nhập";
            // 
            // label32
            // 
            this.label32.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(388, 146);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(90, 20);
            this.label32.TabIndex = 0;
            this.label32.Text = "Hạn Dùng";
            // 
            // txtSizeCakeImport
            // 
            this.txtSizeCakeImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSizeCakeImport.Location = new System.Drawing.Point(534, 35);
            this.txtSizeCakeImport.Name = "txtSizeCakeImport";
            this.txtSizeCakeImport.Size = new System.Drawing.Size(204, 26);
            this.txtSizeCakeImport.TabIndex = 1;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(17, 208);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(86, 20);
            this.label31.TabIndex = 0;
            this.label31.Text = "Số Lượng";
            // 
            // panel31
            // 
            this.panel31.Controls.Add(this.groupBox25);
            this.panel31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel31.Location = new System.Drawing.Point(3, 299);
            this.panel31.Name = "panel31";
            this.panel31.Size = new System.Drawing.Size(760, 104);
            this.panel31.TabIndex = 2;
            // 
            // groupBox25
            // 
            this.groupBox25.Controls.Add(this.txtSearchCakeImport);
            this.groupBox25.Controls.Add(this.btnSearchCakeImport);
            this.groupBox25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox25.Location = new System.Drawing.Point(0, 0);
            this.groupBox25.Name = "groupBox25";
            this.groupBox25.Size = new System.Drawing.Size(760, 104);
            this.groupBox25.TabIndex = 0;
            this.groupBox25.TabStop = false;
            this.groupBox25.Text = "Tìm Kiếm Bánh";
            // 
            // txtSearchCakeImport
            // 
            this.txtSearchCakeImport.Location = new System.Drawing.Point(56, 42);
            this.txtSearchCakeImport.Name = "txtSearchCakeImport";
            this.txtSearchCakeImport.Size = new System.Drawing.Size(482, 26);
            this.txtSearchCakeImport.TabIndex = 0;
            // 
            // btnSearchCakeImport
            // 
            this.btnSearchCakeImport.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSearchCakeImport.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchCakeImport.Image")));
            this.btnSearchCakeImport.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSearchCakeImport.Location = new System.Drawing.Point(587, 25);
            this.btnSearchCakeImport.Name = "btnSearchCakeImport";
            this.btnSearchCakeImport.Size = new System.Drawing.Size(129, 70);
            this.btnSearchCakeImport.TabIndex = 0;
            this.btnSearchCakeImport.Text = "Tìm Kiếm";
            this.btnSearchCakeImport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSearchCakeImport.UseVisualStyleBackColor = true;
            this.btnSearchCakeImport.Click += new System.EventHandler(this.btnSearchCakeImport_Click);
            // 
            // panel32
            // 
            this.panel32.Controls.Add(this.groupBox24);
            this.panel32.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel32.Location = new System.Drawing.Point(769, 299);
            this.panel32.Name = "panel32";
            this.panel32.Size = new System.Drawing.Size(760, 104);
            this.panel32.TabIndex = 3;
            // 
            // groupBox24
            // 
            this.groupBox24.Controls.Add(this.btnCancelCakeImport);
            this.groupBox24.Controls.Add(this.btnDisplayCakePresent);
            this.groupBox24.Controls.Add(this.btnAddImportCoupon);
            this.groupBox24.Controls.Add(this.btnEditImportCoupon);
            this.groupBox24.Controls.Add(this.btnDeleteImportCoupon);
            this.groupBox24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox24.Location = new System.Drawing.Point(0, 0);
            this.groupBox24.Name = "groupBox24";
            this.groupBox24.Size = new System.Drawing.Size(760, 104);
            this.groupBox24.TabIndex = 0;
            this.groupBox24.TabStop = false;
            this.groupBox24.Text = "Chức Năng";
            // 
            // btnCancelCakeImport
            // 
            this.btnCancelCakeImport.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancelCakeImport.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelCakeImport.Location = new System.Drawing.Point(626, 28);
            this.btnCancelCakeImport.Name = "btnCancelCakeImport";
            this.btnCancelCakeImport.Size = new System.Drawing.Size(129, 70);
            this.btnCancelCakeImport.TabIndex = 0;
            this.btnCancelCakeImport.Text = "Hủy";
            this.btnCancelCakeImport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelCakeImport.UseVisualStyleBackColor = true;
            this.btnCancelCakeImport.Click += new System.EventHandler(this.btnCancelCakeImport_Click);
            // 
            // btnDisplayCakePresent
            // 
            this.btnDisplayCakePresent.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDisplayCakePresent.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDisplayCakePresent.Location = new System.Drawing.Point(6, 25);
            this.btnDisplayCakePresent.Name = "btnDisplayCakePresent";
            this.btnDisplayCakePresent.Size = new System.Drawing.Size(129, 70);
            this.btnDisplayCakePresent.TabIndex = 0;
            this.btnDisplayCakePresent.Text = "Xem";
            this.btnDisplayCakePresent.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDisplayCakePresent.UseVisualStyleBackColor = true;
            this.btnDisplayCakePresent.Click += new System.EventHandler(this.btnDisplayCakePresent_Click);
            // 
            // btnAddImportCoupon
            // 
            this.btnAddImportCoupon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddImportCoupon.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddImportCoupon.Location = new System.Drawing.Point(161, 28);
            this.btnAddImportCoupon.Name = "btnAddImportCoupon";
            this.btnAddImportCoupon.Size = new System.Drawing.Size(129, 70);
            this.btnAddImportCoupon.TabIndex = 0;
            this.btnAddImportCoupon.Text = "Thêm";
            this.btnAddImportCoupon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddImportCoupon.UseVisualStyleBackColor = true;
            this.btnAddImportCoupon.Click += new System.EventHandler(this.btnAddImportCoupon_Click);
            // 
            // btnEditImportCoupon
            // 
            this.btnEditImportCoupon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEditImportCoupon.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditImportCoupon.Location = new System.Drawing.Point(316, 28);
            this.btnEditImportCoupon.Name = "btnEditImportCoupon";
            this.btnEditImportCoupon.Size = new System.Drawing.Size(129, 70);
            this.btnEditImportCoupon.TabIndex = 0;
            this.btnEditImportCoupon.Text = "Sửa";
            this.btnEditImportCoupon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditImportCoupon.UseVisualStyleBackColor = true;
            this.btnEditImportCoupon.Click += new System.EventHandler(this.btnEditImportCoupon_Click);
            // 
            // btnDeleteImportCoupon
            // 
            this.btnDeleteImportCoupon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDeleteImportCoupon.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDeleteImportCoupon.Location = new System.Drawing.Point(471, 28);
            this.btnDeleteImportCoupon.Name = "btnDeleteImportCoupon";
            this.btnDeleteImportCoupon.Size = new System.Drawing.Size(129, 70);
            this.btnDeleteImportCoupon.TabIndex = 0;
            this.btnDeleteImportCoupon.Text = "Xóa";
            this.btnDeleteImportCoupon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDeleteImportCoupon.UseVisualStyleBackColor = true;
            this.btnDeleteImportCoupon.Click += new System.EventHandler(this.btnDeleteImportCoupon_Click);
            // 
            // panel33
            // 
            this.tableLayoutPanel11.SetColumnSpan(this.panel33, 2);
            this.panel33.Controls.Add(this.groupBox21);
            this.panel33.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel33.Location = new System.Drawing.Point(3, 409);
            this.panel33.Name = "panel33";
            this.panel33.Size = new System.Drawing.Size(1526, 290);
            this.panel33.TabIndex = 4;
            // 
            // groupBox21
            // 
            this.groupBox21.Controls.Add(this.dgvDetailImport);
            this.groupBox21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox21.Location = new System.Drawing.Point(0, 0);
            this.groupBox21.Name = "groupBox21";
            this.groupBox21.Size = new System.Drawing.Size(1526, 290);
            this.groupBox21.TabIndex = 0;
            this.groupBox21.TabStop = false;
            this.groupBox21.Text = "Chi tiết phiếu nhập";
            // 
            // dgvDetailImport
            // 
            this.dgvDetailImport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetailImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetailImport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetailImport.Location = new System.Drawing.Point(3, 22);
            this.dgvDetailImport.MultiSelect = false;
            this.dgvDetailImport.Name = "dgvDetailImport";
            this.dgvDetailImport.ReadOnly = true;
            this.dgvDetailImport.RowHeadersWidth = 51;
            this.dgvDetailImport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetailImport.Size = new System.Drawing.Size(1520, 265);
            this.dgvDetailImport.TabIndex = 0;
            this.dgvDetailImport.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetailImport_CellClick);
            // 
            // panel34
            // 
            this.panel34.Controls.Add(this.groupBox26);
            this.panel34.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel34.Location = new System.Drawing.Point(3, 705);
            this.panel34.Name = "panel34";
            this.panel34.Size = new System.Drawing.Size(760, 104);
            this.panel34.TabIndex = 5;
            // 
            // groupBox26
            // 
            this.groupBox26.Controls.Add(this.txtSearchDetailImport);
            this.groupBox26.Controls.Add(this.btnSearchDetailImport);
            this.groupBox26.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox26.Location = new System.Drawing.Point(0, 0);
            this.groupBox26.Name = "groupBox26";
            this.groupBox26.Size = new System.Drawing.Size(760, 104);
            this.groupBox26.TabIndex = 0;
            this.groupBox26.TabStop = false;
            this.groupBox26.Text = "Tìm Kiếm Bánh";
            // 
            // txtSearchDetailImport
            // 
            this.txtSearchDetailImport.Location = new System.Drawing.Point(56, 49);
            this.txtSearchDetailImport.Name = "txtSearchDetailImport";
            this.txtSearchDetailImport.Size = new System.Drawing.Size(482, 26);
            this.txtSearchDetailImport.TabIndex = 0;
            // 
            // btnSearchDetailImport
            // 
            this.btnSearchDetailImport.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSearchDetailImport.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchDetailImport.Image")));
            this.btnSearchDetailImport.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSearchDetailImport.Location = new System.Drawing.Point(587, 24);
            this.btnSearchDetailImport.Name = "btnSearchDetailImport";
            this.btnSearchDetailImport.Size = new System.Drawing.Size(129, 70);
            this.btnSearchDetailImport.TabIndex = 0;
            this.btnSearchDetailImport.Text = "Tìm Kiếm";
            this.btnSearchDetailImport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSearchDetailImport.UseVisualStyleBackColor = true;
            this.btnSearchDetailImport.Click += new System.EventHandler(this.btnSearchDetailImport_Click);
            // 
            // panel36
            // 
            this.panel36.Controls.Add(this.groupBox27);
            this.panel36.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel36.Location = new System.Drawing.Point(769, 705);
            this.panel36.Name = "panel36";
            this.panel36.Size = new System.Drawing.Size(760, 104);
            this.panel36.TabIndex = 7;
            // 
            // groupBox27
            // 
            this.groupBox27.Controls.Add(this.btnInputCoupon);
            this.groupBox27.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox27.Location = new System.Drawing.Point(0, 0);
            this.groupBox27.Name = "groupBox27";
            this.groupBox27.Size = new System.Drawing.Size(760, 104);
            this.groupBox27.TabIndex = 0;
            this.groupBox27.TabStop = false;
            this.groupBox27.Text = "Chức Năng";
            // 
            // btnInputCoupon
            // 
            this.btnInputCoupon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnInputCoupon.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnInputCoupon.Location = new System.Drawing.Point(310, 19);
            this.btnInputCoupon.Name = "btnInputCoupon";
            this.btnInputCoupon.Size = new System.Drawing.Size(140, 70);
            this.btnInputCoupon.TabIndex = 0;
            this.btnInputCoupon.Text = "Nhập phiếu";
            this.btnInputCoupon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInputCoupon.UseVisualStyleBackColor = true;
            // 
            // tabPage12
            // 
            this.tabPage12.Controls.Add(this.tabControl1);
            this.tabPage12.ImageIndex = 7;
            this.tabPage12.Location = new System.Drawing.Point(4, 29);
            this.tabPage12.Name = "tabPage12";
            this.tabPage12.Size = new System.Drawing.Size(1532, 812);
            this.tabPage12.TabIndex = 10;
            this.tabPage12.Text = "Thống kê";
            this.tabPage12.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage13);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1532, 812);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.tableLayoutPanel10);
            this.tabPage6.Location = new System.Drawing.Point(4, 29);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(1524, 779);
            this.tabPage6.TabIndex = 0;
            this.tabPage6.Text = "Danh Sách";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 1;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel10.Controls.Add(this.gbStatisticalList, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.panel26, 0, 1);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 2;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(1518, 773);
            this.tableLayoutPanel10.TabIndex = 1;
            // 
            // gbStatisticalList
            // 
            this.gbStatisticalList.Controls.Add(this.panel25);
            this.gbStatisticalList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbStatisticalList.Location = new System.Drawing.Point(3, 3);
            this.gbStatisticalList.Name = "gbStatisticalList";
            this.gbStatisticalList.Size = new System.Drawing.Size(1512, 517);
            this.gbStatisticalList.TabIndex = 0;
            this.gbStatisticalList.TabStop = false;
            this.gbStatisticalList.Text = "Danh sách thống kê";
            // 
            // panel25
            // 
            this.panel25.Controls.Add(this.dgvStatistical);
            this.panel25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel25.Location = new System.Drawing.Point(3, 22);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(1506, 492);
            this.panel25.TabIndex = 0;
            // 
            // dgvStatistical
            // 
            this.dgvStatistical.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStatistical.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatistical.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStatistical.Location = new System.Drawing.Point(0, 0);
            this.dgvStatistical.MultiSelect = false;
            this.dgvStatistical.Name = "dgvStatistical";
            this.dgvStatistical.ReadOnly = true;
            this.dgvStatistical.RowHeadersWidth = 51;
            this.dgvStatistical.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStatistical.Size = new System.Drawing.Size(1506, 492);
            this.dgvStatistical.TabIndex = 0;
            // 
            // panel26
            // 
            this.panel26.Controls.Add(this.groupBox20);
            this.panel26.Controls.Add(this.groupBox22);
            this.panel26.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel26.Location = new System.Drawing.Point(3, 526);
            this.panel26.Name = "panel26";
            this.panel26.Size = new System.Drawing.Size(1512, 244);
            this.panel26.TabIndex = 1;
            // 
            // groupBox20
            // 
            this.groupBox20.Controls.Add(this.panel27);
            this.groupBox20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox20.Location = new System.Drawing.Point(763, 0);
            this.groupBox20.Name = "groupBox20";
            this.groupBox20.Size = new System.Drawing.Size(749, 244);
            this.groupBox20.TabIndex = 2;
            this.groupBox20.TabStop = false;
            this.groupBox20.Text = "Chức năng";
            // 
            // panel27
            // 
            this.panel27.Controls.Add(this.btnStatisticalList);
            this.panel27.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel27.Location = new System.Drawing.Point(3, 22);
            this.panel27.Name = "panel27";
            this.panel27.Size = new System.Drawing.Size(743, 219);
            this.panel27.TabIndex = 0;
            // 
            // btnStatisticalList
            // 
            this.btnStatisticalList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnStatisticalList.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnStatisticalList.Location = new System.Drawing.Point(290, 75);
            this.btnStatisticalList.Name = "btnStatisticalList";
            this.btnStatisticalList.Size = new System.Drawing.Size(162, 69);
            this.btnStatisticalList.TabIndex = 1;
            this.btnStatisticalList.Text = "Thống kê";
            this.btnStatisticalList.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStatisticalList.UseVisualStyleBackColor = true;
            this.btnStatisticalList.Click += new System.EventHandler(this.btnStatisticalList_Click);
            // 
            // groupBox22
            // 
            this.groupBox22.Controls.Add(this.panel29);
            this.groupBox22.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox22.Location = new System.Drawing.Point(0, 0);
            this.groupBox22.Name = "groupBox22";
            this.groupBox22.Size = new System.Drawing.Size(763, 244);
            this.groupBox22.TabIndex = 0;
            this.groupBox22.TabStop = false;
            this.groupBox22.Text = "Kiểu thống kê";
            // 
            // panel29
            // 
            this.panel29.Controls.Add(this.radSlowestSellerList);
            this.panel29.Controls.Add(this.radBestSellerList);
            this.panel29.Controls.Add(this.radRevenue3MonthsList);
            this.panel29.Controls.Add(this.radRevenue7DaysList);
            this.panel29.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel29.Location = new System.Drawing.Point(3, 22);
            this.panel29.Name = "panel29";
            this.panel29.Size = new System.Drawing.Size(757, 219);
            this.panel29.TabIndex = 0;
            // 
            // radSlowestSellerList
            // 
            this.radSlowestSellerList.AutoSize = true;
            this.radSlowestSellerList.Location = new System.Drawing.Point(162, 171);
            this.radSlowestSellerList.Name = "radSlowestSellerList";
            this.radSlowestSellerList.Size = new System.Drawing.Size(432, 24);
            this.radSlowestSellerList.TabIndex = 0;
            this.radSlowestSellerList.Text = "10 loại bánh bán chậm nhất trong 30 ngày gần đây";
            this.radSlowestSellerList.UseVisualStyleBackColor = true;
            // 
            // radBestSellerList
            // 
            this.radBestSellerList.AutoSize = true;
            this.radBestSellerList.Location = new System.Drawing.Point(162, 122);
            this.radBestSellerList.Name = "radBestSellerList";
            this.radBestSellerList.Size = new System.Drawing.Size(426, 24);
            this.radBestSellerList.TabIndex = 0;
            this.radBestSellerList.Text = "10 loại bánh bán chạy nhất trong 30 ngày gần đây";
            this.radBestSellerList.UseVisualStyleBackColor = true;
            // 
            // radRevenue3MonthsList
            // 
            this.radRevenue3MonthsList.AutoSize = true;
            this.radRevenue3MonthsList.Location = new System.Drawing.Point(162, 73);
            this.radRevenue3MonthsList.Name = "radRevenue3MonthsList";
            this.radRevenue3MonthsList.Size = new System.Drawing.Size(245, 24);
            this.radRevenue3MonthsList.TabIndex = 0;
            this.radRevenue3MonthsList.Text = "Doanh thu 3 tháng gần đây";
            this.radRevenue3MonthsList.UseVisualStyleBackColor = true;
            // 
            // radRevenue7DaysList
            // 
            this.radRevenue7DaysList.AutoSize = true;
            this.radRevenue7DaysList.Checked = true;
            this.radRevenue7DaysList.Location = new System.Drawing.Point(162, 24);
            this.radRevenue7DaysList.Name = "radRevenue7DaysList";
            this.radRevenue7DaysList.Size = new System.Drawing.Size(237, 24);
            this.radRevenue7DaysList.TabIndex = 0;
            this.radRevenue7DaysList.TabStop = true;
            this.radRevenue7DaysList.Text = "Doanh thu 7 ngày gần đây";
            this.radRevenue7DaysList.UseVisualStyleBackColor = true;
            // 
            // tabPage13
            // 
            this.tabPage13.Controls.Add(this.tableLayoutPanel9);
            this.tabPage13.Location = new System.Drawing.Point(4, 29);
            this.tabPage13.Name = "tabPage13";
            this.tabPage13.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage13.Size = new System.Drawing.Size(1524, 779);
            this.tabPage13.TabIndex = 1;
            this.tabPage13.Text = "Biểu Đồ";
            this.tabPage13.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 1;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel9.Controls.Add(this.groupBox15, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.panel21, 0, 1);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 2;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(1518, 773);
            this.tableLayoutPanel9.TabIndex = 0;
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.panel20);
            this.groupBox15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox15.Location = new System.Drawing.Point(3, 3);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(1512, 517);
            this.groupBox15.TabIndex = 0;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Biểu đồ";
            // 
            // panel20
            // 
            this.panel20.Controls.Add(this.chartStatistical);
            this.panel20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel20.Location = new System.Drawing.Point(3, 22);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(1506, 492);
            this.panel20.TabIndex = 0;
            // 
            // chartStatistical
            // 
            chartArea6.Name = "ChartArea1";
            this.chartStatistical.ChartAreas.Add(chartArea6);
            this.chartStatistical.Dock = System.Windows.Forms.DockStyle.Fill;
            legend6.Name = "Legend1";
            this.chartStatistical.Legends.Add(legend6);
            this.chartStatistical.Location = new System.Drawing.Point(0, 0);
            this.chartStatistical.Name = "chartStatistical";
            series6.ChartArea = "ChartArea1";
            series6.IsValueShownAsLabel = true;
            series6.Legend = "Legend1";
            series6.Name = "statistical";
            this.chartStatistical.Series.Add(series6);
            this.chartStatistical.Size = new System.Drawing.Size(1506, 492);
            this.chartStatistical.TabIndex = 0;
            this.chartStatistical.Text = "chart1";
            title6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            title6.ForeColor = System.Drawing.Color.Red;
            title6.Name = "Title1";
            title6.Text = "BIỂU ĐỒ";
            this.chartStatistical.Titles.Add(title6);
            // 
            // panel21
            // 
            this.panel21.Controls.Add(this.groupBox18);
            this.panel21.Controls.Add(this.groupBox17);
            this.panel21.Controls.Add(this.groupBox16);
            this.panel21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel21.Location = new System.Drawing.Point(3, 526);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(1512, 244);
            this.panel21.TabIndex = 1;
            // 
            // groupBox18
            // 
            this.groupBox18.Controls.Add(this.panel24);
            this.groupBox18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox18.Location = new System.Drawing.Point(851, 0);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Size = new System.Drawing.Size(661, 244);
            this.groupBox18.TabIndex = 2;
            this.groupBox18.TabStop = false;
            this.groupBox18.Text = "Chức năng";
            // 
            // panel24
            // 
            this.panel24.Controls.Add(this.btnStatisticalChart);
            this.panel24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel24.Location = new System.Drawing.Point(3, 22);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(655, 219);
            this.panel24.TabIndex = 0;
            // 
            // btnStatisticalChart
            // 
            this.btnStatisticalChart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnStatisticalChart.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnStatisticalChart.Location = new System.Drawing.Point(246, 75);
            this.btnStatisticalChart.Name = "btnStatisticalChart";
            this.btnStatisticalChart.Size = new System.Drawing.Size(162, 69);
            this.btnStatisticalChart.TabIndex = 1;
            this.btnStatisticalChart.Text = "Thống kê";
            this.btnStatisticalChart.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStatisticalChart.UseVisualStyleBackColor = true;
            this.btnStatisticalChart.Click += new System.EventHandler(this.btnStatisticalChart_Click);
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.panel23);
            this.groupBox17.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox17.Location = new System.Drawing.Point(517, 0);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(334, 244);
            this.groupBox17.TabIndex = 1;
            this.groupBox17.TabStop = false;
            this.groupBox17.Text = "Loại biểu đồ";
            // 
            // panel23
            // 
            this.panel23.Controls.Add(this.radLineChart_Chart);
            this.panel23.Controls.Add(this.radCircleChart_Chart);
            this.panel23.Controls.Add(this.radColumnChart_Chart);
            this.panel23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel23.Location = new System.Drawing.Point(3, 22);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(328, 219);
            this.panel23.TabIndex = 0;
            // 
            // radLineChart_Chart
            // 
            this.radLineChart_Chart.AutoSize = true;
            this.radLineChart_Chart.Location = new System.Drawing.Point(93, 122);
            this.radLineChart_Chart.Name = "radLineChart_Chart";
            this.radLineChart_Chart.Size = new System.Drawing.Size(143, 24);
            this.radLineChart_Chart.TabIndex = 1;
            this.radLineChart_Chart.Text = "Biểu đồ đường";
            this.radLineChart_Chart.UseVisualStyleBackColor = true;
            // 
            // radCircleChart_Chart
            // 
            this.radCircleChart_Chart.AutoSize = true;
            this.radCircleChart_Chart.Location = new System.Drawing.Point(93, 73);
            this.radCircleChart_Chart.Name = "radCircleChart_Chart";
            this.radCircleChart_Chart.Size = new System.Drawing.Size(125, 24);
            this.radCircleChart_Chart.TabIndex = 2;
            this.radCircleChart_Chart.Text = "Biểu đồ tròn";
            this.radCircleChart_Chart.UseVisualStyleBackColor = true;
            // 
            // radColumnChart_Chart
            // 
            this.radColumnChart_Chart.AutoSize = true;
            this.radColumnChart_Chart.Checked = true;
            this.radColumnChart_Chart.Location = new System.Drawing.Point(93, 24);
            this.radColumnChart_Chart.Name = "radColumnChart_Chart";
            this.radColumnChart_Chart.Size = new System.Drawing.Size(118, 24);
            this.radColumnChart_Chart.TabIndex = 3;
            this.radColumnChart_Chart.TabStop = true;
            this.radColumnChart_Chart.Text = "Biểu đồ cột";
            this.radColumnChart_Chart.UseVisualStyleBackColor = true;
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.panel22);
            this.groupBox16.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox16.Location = new System.Drawing.Point(0, 0);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(517, 244);
            this.groupBox16.TabIndex = 0;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "Kiểu thống kê";
            // 
            // panel22
            // 
            this.panel22.Controls.Add(this.radSlowestSellerChart);
            this.panel22.Controls.Add(this.radBestSellerChart);
            this.panel22.Controls.Add(this.radRevenue3MonthsChart);
            this.panel22.Controls.Add(this.radRevenue7DaysChart);
            this.panel22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel22.Location = new System.Drawing.Point(3, 22);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(511, 219);
            this.panel22.TabIndex = 0;
            // 
            // radSlowestSellerChart
            // 
            this.radSlowestSellerChart.AutoSize = true;
            this.radSlowestSellerChart.Location = new System.Drawing.Point(39, 171);
            this.radSlowestSellerChart.Name = "radSlowestSellerChart";
            this.radSlowestSellerChart.Size = new System.Drawing.Size(432, 24);
            this.radSlowestSellerChart.TabIndex = 0;
            this.radSlowestSellerChart.Text = "10 loại bánh bán chậm nhất trong 30 ngày gần đây";
            this.radSlowestSellerChart.UseVisualStyleBackColor = true;
            // 
            // radBestSellerChart
            // 
            this.radBestSellerChart.AutoSize = true;
            this.radBestSellerChart.Location = new System.Drawing.Point(39, 122);
            this.radBestSellerChart.Name = "radBestSellerChart";
            this.radBestSellerChart.Size = new System.Drawing.Size(426, 24);
            this.radBestSellerChart.TabIndex = 0;
            this.radBestSellerChart.Text = "10 loại bánh bán chạy nhất trong 30 ngày gần đây";
            this.radBestSellerChart.UseVisualStyleBackColor = true;
            // 
            // radRevenue3MonthsChart
            // 
            this.radRevenue3MonthsChart.AutoSize = true;
            this.radRevenue3MonthsChart.Location = new System.Drawing.Point(39, 73);
            this.radRevenue3MonthsChart.Name = "radRevenue3MonthsChart";
            this.radRevenue3MonthsChart.Size = new System.Drawing.Size(245, 24);
            this.radRevenue3MonthsChart.TabIndex = 0;
            this.radRevenue3MonthsChart.Text = "Doanh thu 3 tháng gần đây";
            this.radRevenue3MonthsChart.UseVisualStyleBackColor = true;
            // 
            // radRevenue7DaysChart
            // 
            this.radRevenue7DaysChart.AutoSize = true;
            this.radRevenue7DaysChart.Checked = true;
            this.radRevenue7DaysChart.Location = new System.Drawing.Point(39, 24);
            this.radRevenue7DaysChart.Name = "radRevenue7DaysChart";
            this.radRevenue7DaysChart.Size = new System.Drawing.Size(237, 24);
            this.radRevenue7DaysChart.TabIndex = 0;
            this.radRevenue7DaysChart.TabStop = true;
            this.radRevenue7DaysChart.Text = "Doanh thu 7 ngày gần đây";
            this.radRevenue7DaysChart.UseVisualStyleBackColor = true;
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.tableLayoutPanel12);
            this.tabPage9.Location = new System.Drawing.Point(4, 29);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Size = new System.Drawing.Size(1532, 812);
            this.tabPage9.TabIndex = 11;
            this.tabPage9.Text = "Phiếu Nhập";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.ColumnCount = 1;
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel12.Controls.Add(this.tableLayoutPanel13, 0, 0);
            this.tableLayoutPanel12.Controls.Add(this.groupBox30, 0, 1);
            this.tableLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel12.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 2;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(1532, 812);
            this.tableLayoutPanel12.TabIndex = 1;
            // 
            // tableLayoutPanel13
            // 
            this.tableLayoutPanel13.ColumnCount = 2;
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel13.Controls.Add(this.groupBox28, 0, 0);
            this.tableLayoutPanel13.Controls.Add(this.groupBox29, 1, 0);
            this.tableLayoutPanel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel13.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel13.Name = "tableLayoutPanel13";
            this.tableLayoutPanel13.RowCount = 1;
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 556F));
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 556F));
            this.tableLayoutPanel13.Size = new System.Drawing.Size(1526, 556);
            this.tableLayoutPanel13.TabIndex = 0;
            // 
            // groupBox28
            // 
            this.groupBox28.Controls.Add(this.panel35);
            this.groupBox28.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox28.Location = new System.Drawing.Point(3, 3);
            this.groupBox28.Name = "groupBox28";
            this.groupBox28.Size = new System.Drawing.Size(757, 550);
            this.groupBox28.TabIndex = 0;
            this.groupBox28.TabStop = false;
            this.groupBox28.Text = "Danh sách phiếu nhập";
            // 
            // panel35
            // 
            this.panel35.Controls.Add(this.dgvCouponImport);
            this.panel35.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel35.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel35.Location = new System.Drawing.Point(3, 22);
            this.panel35.Name = "panel35";
            this.panel35.Size = new System.Drawing.Size(751, 525);
            this.panel35.TabIndex = 0;
            // 
            // dgvCouponImport
            // 
            this.dgvCouponImport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCouponImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCouponImport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCouponImport.Location = new System.Drawing.Point(0, 0);
            this.dgvCouponImport.MultiSelect = false;
            this.dgvCouponImport.Name = "dgvCouponImport";
            this.dgvCouponImport.ReadOnly = true;
            this.dgvCouponImport.RowHeadersWidth = 51;
            this.dgvCouponImport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCouponImport.Size = new System.Drawing.Size(751, 525);
            this.dgvCouponImport.TabIndex = 0;
            this.dgvCouponImport.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCouponImport_CellClick);
            // 
            // groupBox29
            // 
            this.groupBox29.Controls.Add(this.panel37);
            this.groupBox29.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox29.Location = new System.Drawing.Point(766, 3);
            this.groupBox29.Name = "groupBox29";
            this.groupBox29.Size = new System.Drawing.Size(757, 550);
            this.groupBox29.TabIndex = 1;
            this.groupBox29.TabStop = false;
            this.groupBox29.Text = "Chi tiết phiếu nhập";
            // 
            // panel37
            // 
            this.panel37.Controls.Add(this.dgvDetailCouponImport);
            this.panel37.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel37.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel37.Location = new System.Drawing.Point(3, 22);
            this.panel37.Name = "panel37";
            this.panel37.Size = new System.Drawing.Size(751, 525);
            this.panel37.TabIndex = 0;
            // 
            // dgvDetailCouponImport
            // 
            this.dgvDetailCouponImport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetailCouponImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetailCouponImport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetailCouponImport.Location = new System.Drawing.Point(0, 0);
            this.dgvDetailCouponImport.MultiSelect = false;
            this.dgvDetailCouponImport.Name = "dgvDetailCouponImport";
            this.dgvDetailCouponImport.ReadOnly = true;
            this.dgvDetailCouponImport.RowHeadersWidth = 51;
            this.dgvDetailCouponImport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetailCouponImport.Size = new System.Drawing.Size(751, 525);
            this.dgvDetailCouponImport.TabIndex = 0;
            // 
            // groupBox30
            // 
            this.groupBox30.Controls.Add(this.panel38);
            this.groupBox30.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox30.Location = new System.Drawing.Point(3, 565);
            this.groupBox30.Name = "groupBox30";
            this.groupBox30.Size = new System.Drawing.Size(1526, 244);
            this.groupBox30.TabIndex = 1;
            this.groupBox30.TabStop = false;
            this.groupBox30.Text = "Chức năng";
            // 
            // panel38
            // 
            this.panel38.Controls.Add(this.dtpEndImportDay);
            this.panel38.Controls.Add(this.dtpStartImportDay);
            this.panel38.Controls.Add(this.label36);
            this.panel38.Controls.Add(this.label41);
            this.panel38.Controls.Add(this.label42);
            this.panel38.Controls.Add(this.label43);
            this.panel38.Controls.Add(this.txtSearchImportCoupon);
            this.panel38.Controls.Add(this.btnFilterCouponImport);
            this.panel38.Controls.Add(this.btnSearchCouponImport);
            this.panel38.Controls.Add(this.btnDisplayCouponImport);
            this.panel38.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel38.Location = new System.Drawing.Point(3, 22);
            this.panel38.Name = "panel38";
            this.panel38.Size = new System.Drawing.Size(1520, 219);
            this.panel38.TabIndex = 0;
            // 
            // dtpEndImportDay
            // 
            this.dtpEndImportDay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpEndImportDay.CustomFormat = "dd/MM/yyyy";
            this.dtpEndImportDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndImportDay.Location = new System.Drawing.Point(477, 174);
            this.dtpEndImportDay.Name = "dtpEndImportDay";
            this.dtpEndImportDay.Size = new System.Drawing.Size(433, 26);
            this.dtpEndImportDay.TabIndex = 7;
            // 
            // dtpStartImportDay
            // 
            this.dtpStartImportDay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpStartImportDay.CustomFormat = "dd/MM/yyyy";
            this.dtpStartImportDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartImportDay.Location = new System.Drawing.Point(477, 130);
            this.dtpStartImportDay.Name = "dtpStartImportDay";
            this.dtpStartImportDay.Size = new System.Drawing.Size(433, 26);
            this.dtpStartImportDay.TabIndex = 7;
            // 
            // label36
            // 
            this.label36.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(329, 180);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(119, 20);
            this.label36.TabIndex = 6;
            this.label36.Text = "Ngày kết thúc";
            // 
            // label41
            // 
            this.label41.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.Location = new System.Drawing.Point(333, 135);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(115, 20);
            this.label41.TabIndex = 6;
            this.label41.Text = "Ngày bắt đầu";
            // 
            // label42
            // 
            this.label42.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.Location = new System.Drawing.Point(200, 95);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(216, 20);
            this.label42.TabIndex = 6;
            this.label42.Text = "Lọc phiếu nhập theo ngày";
            // 
            // label43
            // 
            this.label43.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.Location = new System.Drawing.Point(117, 45);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(316, 20);
            this.label43.TabIndex = 6;
            this.label43.Text = "Tìm phiếu nhập theo tên nhà cung cấp";
            // 
            // txtSearchImportCoupon
            // 
            this.txtSearchImportCoupon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSearchImportCoupon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchImportCoupon.Location = new System.Drawing.Point(477, 42);
            this.txtSearchImportCoupon.Name = "txtSearchImportCoupon";
            this.txtSearchImportCoupon.Size = new System.Drawing.Size(433, 26);
            this.txtSearchImportCoupon.TabIndex = 5;
            // 
            // btnFilterCouponImport
            // 
            this.btnFilterCouponImport.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnFilterCouponImport.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFilterCouponImport.Location = new System.Drawing.Point(938, 135);
            this.btnFilterCouponImport.Name = "btnFilterCouponImport";
            this.btnFilterCouponImport.Size = new System.Drawing.Size(162, 65);
            this.btnFilterCouponImport.TabIndex = 4;
            this.btnFilterCouponImport.Text = "Lọc";
            this.btnFilterCouponImport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFilterCouponImport.UseVisualStyleBackColor = true;
            this.btnFilterCouponImport.Click += new System.EventHandler(this.btnFilterCouponImport_Click);
            // 
            // btnSearchCouponImport
            // 
            this.btnSearchCouponImport.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSearchCouponImport.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSearchCouponImport.Location = new System.Drawing.Point(938, 18);
            this.btnSearchCouponImport.Name = "btnSearchCouponImport";
            this.btnSearchCouponImport.Size = new System.Drawing.Size(162, 65);
            this.btnSearchCouponImport.TabIndex = 4;
            this.btnSearchCouponImport.Text = "Tìm";
            this.btnSearchCouponImport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSearchCouponImport.UseVisualStyleBackColor = true;
            this.btnSearchCouponImport.Click += new System.EventHandler(this.btnSearchCouponImport_Click);
            // 
            // btnDisplayCouponImport
            // 
            this.btnDisplayCouponImport.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDisplayCouponImport.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDisplayCouponImport.Location = new System.Drawing.Point(1159, 18);
            this.btnDisplayCouponImport.Name = "btnDisplayCouponImport";
            this.btnDisplayCouponImport.Size = new System.Drawing.Size(162, 65);
            this.btnDisplayCouponImport.TabIndex = 1;
            this.btnDisplayCouponImport.Text = "Xem";
            this.btnDisplayCouponImport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDisplayCouponImport.UseVisualStyleBackColor = true;
            this.btnDisplayCouponImport.Click += new System.EventHandler(this.btnDisplayCouponImport_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Account.png");
            this.imageList1.Images.SetKeyName(1, "Bill.png");
            this.imageList1.Images.SetKeyName(2, "Cake.png");
            this.imageList1.Images.SetKeyName(3, "Category.png");
            this.imageList1.Images.SetKeyName(4, "ImportCoupon.png");
            this.imageList1.Images.SetKeyName(5, "Provider.png");
            this.imageList1.Images.SetKeyName(6, "Staff.png");
            this.imageList1.Images.SetKeyName(7, "statistical.png");
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(189, 306);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(392, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(189, 264);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(392, 20);
            this.textBox8.TabIndex = 1;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(0, 0);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 0;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(0, 0);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 0;
            // 
            // txtExpImport
            // 
            this.txtExpImport.Location = new System.Drawing.Point(0, 0);
            this.txtExpImport.Name = "txtExpImport";
            this.txtExpImport.Size = new System.Drawing.Size(100, 20);
            this.txtExpImport.TabIndex = 0;
            // 
            // txtPriceCakeImport
            // 
            this.txtPriceCakeImport.Location = new System.Drawing.Point(0, 0);
            this.txtPriceCakeImport.Name = "txtPriceCakeImport";
            this.txtPriceCakeImport.Size = new System.Drawing.Size(100, 20);
            this.txtPriceCakeImport.TabIndex = 0;
            // 
            // txtIdCakeImport
            // 
            this.txtIdCakeImport.Location = new System.Drawing.Point(189, 19);
            this.txtIdCakeImport.Name = "txtIdCakeImport";
            this.txtIdCakeImport.Size = new System.Drawing.Size(392, 20);
            this.txtIdCakeImport.TabIndex = 1;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.panel16, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 3;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(1279, 760);
            this.tableLayoutPanel7.TabIndex = 1;
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.groupBox12);
            this.panel16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel16.Location = new System.Drawing.Point(3, 3);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(1273, 194);
            this.panel16.TabIndex = 0;
            // 
            // groupBox12
            // 
            this.groupBox12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox12.Location = new System.Drawing.Point(0, 0);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(1273, 194);
            this.groupBox12.TabIndex = 0;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Chi tiết loại bánh";
            // 
            // tabPage10
            // 
            this.tabPage10.Location = new System.Drawing.Point(4, 29);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage10.Size = new System.Drawing.Size(1532, 812);
            this.tabPage10.TabIndex = 12;
            this.tabPage10.Text = "tabPage10";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1540, 845);
            this.Controls.Add(this.tcAccount);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý tiệm bánh";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmAdmin_Load);
            this.tcAccount.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            this.panel6.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCake)).EndInit();
            this.panel9.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).EndInit();
            this.panel12.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            this.groupBox10.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillDetail)).EndInit();
            this.groupBox11.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.panel17.ResumeLayout(false);
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.panel18.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).EndInit();
            this.panel19.ResumeLayout(false);
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.tabPage8.ResumeLayout(false);
            this.tableLayoutPanel11.ResumeLayout(false);
            this.panel28.ResumeLayout(false);
            this.groupBox19.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCakePresent)).EndInit();
            this.panel30.ResumeLayout(false);
            this.groupBox23.ResumeLayout(false);
            this.groupBox23.PerformLayout();
            this.panel31.ResumeLayout(false);
            this.groupBox25.ResumeLayout(false);
            this.groupBox25.PerformLayout();
            this.panel32.ResumeLayout(false);
            this.groupBox24.ResumeLayout(false);
            this.panel33.ResumeLayout(false);
            this.groupBox21.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailImport)).EndInit();
            this.panel34.ResumeLayout(false);
            this.groupBox26.ResumeLayout(false);
            this.groupBox26.PerformLayout();
            this.panel36.ResumeLayout(false);
            this.groupBox27.ResumeLayout(false);
            this.tabPage12.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            this.gbStatisticalList.ResumeLayout(false);
            this.panel25.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistical)).EndInit();
            this.panel26.ResumeLayout(false);
            this.groupBox20.ResumeLayout(false);
            this.panel27.ResumeLayout(false);
            this.groupBox22.ResumeLayout(false);
            this.panel29.ResumeLayout(false);
            this.panel29.PerformLayout();
            this.tabPage13.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.groupBox15.ResumeLayout(false);
            this.panel20.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartStatistical)).EndInit();
            this.panel21.ResumeLayout(false);
            this.groupBox18.ResumeLayout(false);
            this.panel24.ResumeLayout(false);
            this.groupBox17.ResumeLayout(false);
            this.panel23.ResumeLayout(false);
            this.panel23.PerformLayout();
            this.groupBox16.ResumeLayout(false);
            this.panel22.ResumeLayout(false);
            this.panel22.PerformLayout();
            this.tabPage9.ResumeLayout(false);
            this.tableLayoutPanel12.ResumeLayout(false);
            this.tableLayoutPanel13.ResumeLayout(false);
            this.groupBox28.ResumeLayout(false);
            this.panel35.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCouponImport)).EndInit();
            this.groupBox29.ResumeLayout(false);
            this.panel37.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailCouponImport)).EndInit();
            this.groupBox30.ResumeLayout(false);
            this.panel38.ResumeLayout(false);
            this.panel38.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcAccount;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvAccount;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.CheckBox ckbStaff;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAccountSearch;
        private System.Windows.Forms.ComboBox cbbListStaff;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtNameStaff;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStaffSearch;
        private System.Windows.Forms.Button btnStaffSearch;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dgvStaff;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnAddStaff;
        private System.Windows.Forms.Button btnDisplayStaff;
        private System.Windows.Forms.Button btnDeleteStaff;
        private System.Windows.Forms.RadioButton rdbWoman;
        private System.Windows.Forms.RadioButton rdbMan;
        private System.Windows.Forms.TextBox txtWorkDay;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtAddressStaff;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPhoneStaff;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cbbCategory;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtNameCake;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtCakeSearch;
        private System.Windows.Forms.Button btnCakeSearch;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.DataGridView dgvCake;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnCakeEdit;
        private System.Windows.Forms.Button btnCakeDisplay;
        private System.Windows.Forms.Button btnCakeDel;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox txtAddressSupplier;
        private System.Windows.Forms.TextBox txtPhoneSupplier;
        private System.Windows.Forms.TextBox txtIdSupplier;
        private System.Windows.Forms.TextBox txtNameSupplier;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.DataGridView dgvSupplier;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button btnEditSupplier;
        private System.Windows.Forms.Button btnViewSupplier;
        private System.Windows.Forms.Button btnDelSupplier;
        private System.Windows.Forms.TextBox txtSearchKeySupplier;
        private System.Windows.Forms.Button btnSearchSupplier;
        private System.Windows.Forms.Button btnAddSupplier;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Button btnViewBill;
        private System.Windows.Forms.DateTimePicker dtpStartDay;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtSearchKeyBill;
        private System.Windows.Forms.Button btnSearchBill;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Button btnFilterBill;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.DataGridView dgvBill;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.DataGridView dgvBillDetail;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TabPage tabPage12;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.TextBox txtNameCategory;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.DataGridView dgvCategory;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnDisplayCategory;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.Button btnEditCategory;
        private System.Windows.Forms.TextBox txtCategorySearch;
        private System.Windows.Forms.Button btnCategorySearch;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.GroupBox gbStatisticalList;
        private System.Windows.Forms.Panel panel25;
        private System.Windows.Forms.DataGridView dgvStatistical;
        private System.Windows.Forms.Panel panel26;
        private System.Windows.Forms.GroupBox groupBox20;
        private System.Windows.Forms.Panel panel27;
        private System.Windows.Forms.Button btnStatisticalList;
        private System.Windows.Forms.GroupBox groupBox22;
        private System.Windows.Forms.Panel panel29;
        private System.Windows.Forms.RadioButton radSlowestSellerList;
        private System.Windows.Forms.RadioButton radBestSellerList;
        private System.Windows.Forms.RadioButton radRevenue3MonthsList;
        private System.Windows.Forms.RadioButton radRevenue7DaysList;
        private System.Windows.Forms.TabPage tabPage13;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStatistical;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.GroupBox groupBox18;
        private System.Windows.Forms.Panel panel24;
        private System.Windows.Forms.Button btnStatisticalChart;
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private System.Windows.Forms.Panel panel28;
        private GroupBox groupBox19;
        private System.Windows.Forms.DataGridView dgvCakePresent;
        private System.Windows.Forms.Panel panel30;
        private TextBox textBox1;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox txtExpImport;
        private System.Windows.Forms.Label label34;
        private DateTimePicker dtpDayImport;
        private DateTimePicker dtpExpImport;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Panel panel31;
        private System.Windows.Forms.Panel panel32;
        private Button btnDeleteImportCoupon;
        private Button btnEditImportCoupon;
        private Button btnAddImportCoupon;
        private System.Windows.Forms.Panel panel33;
        private GroupBox groupBox21;
        private DataGridView dgvDetailImport;
        private System.Windows.Forms.Panel panel34;
        private System.Windows.Forms.Panel panel36;
        private Button btnInputCoupon;
        private System.Windows.Forms.TextBox txtSizeCakeImport;
        private System.Windows.Forms.TextBox txtAmountImport;
        private TextBox txtPriceCakeImport;
        private System.Windows.Forms.TextBox txtImportPrice;
        private System.Windows.Forms.TextBox txtNameCakeImport;
        private System.Windows.Forms.TextBox txtExportPrice;
        private System.Windows.Forms.Label label35;
        private DateTimePicker dtpMfgImport;
        private TextBox txtIdCakeImport;
        private GroupBox groupBox23;
        private Label label38;

        private System.Windows.Forms.Button btnEditStaff;
        private System.Windows.Forms.TextBox txtIdStaffAccount;
        private System.Windows.Forms.Label label37;
        private Label label39;
        private ComboBox cbbCategoryCake;
        private ComboBox cbbNameSupplier;
        private TextBox txtIdCakeImportTabImport;
        private Label label40;
        private GroupBox groupBox24;
        private GroupBox groupBox25;
        private GroupBox groupBox26;
        private GroupBox groupBox27;
        private TextBox txtSearchCakeImport;
        private Button btnSearchCakeImport;
        private TextBox txtSearchDetailImport;
        private Button btnSearchDetailImport;
        private Button btnCancelCakeImport;
        private Button btnDisplayCakePresent;
        private ImageList imageList1;
        private TabPage tabPage9;
        private TableLayoutPanel tableLayoutPanel12;
        private TableLayoutPanel tableLayoutPanel13;
        private GroupBox groupBox28;
        private Panel panel35;
        private DataGridView dgvCouponImport;
        private GroupBox groupBox29;
        private Panel panel37;
        private DataGridView dgvDetailCouponImport;
        private GroupBox groupBox30;
        private Panel panel38;
        private DateTimePicker dtpEndImportDay;
        private DateTimePicker dtpStartImportDay;
        private Label label36;
        private Label label41;
        private Label label42;
        private Label label43;
        private TextBox txtSearchImportCoupon;
        private Button btnFilterCouponImport;
        private Button btnSearchCouponImport;
        private Button btnDisplayCouponImport;
        private TabPage tabPage10;
        //=======
        //private System.Windows.Forms.Button btnAddImportCoupon;
        //private System.Windows.Forms.DataGridView dgvDetailImport;
        //private System.Windows.Forms.Button btnDeleteImportCoupon;
        //private System.Windows.Forms.Button btnEditImportCoupon;
        //private System.Windows.Forms.GroupBox groupBox19;
        //private System.Windows.Forms.GroupBox groupBox21;
        //private System.Windows.Forms.Button btnInputCoupon;
        //private System.Windows.Forms.DateTimePicker dtpMfgImport;
        //private System.Windows.Forms.DateTimePicker dtpExpImport;
        //private System.Windows.Forms.Label label38;
        //private System.Windows.Forms.GroupBox groupBox23;
        //private System.Windows.Forms.DateTimePicker dtpDayImport;
        //private System.Windows.Forms.TextBox txtNameSupplierImport;
        //>>>>>>> aae0b2ac386595e963d1efe070ddedc5bcf9b57f
    }
}