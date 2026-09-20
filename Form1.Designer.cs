namespace ExpenseTracher
{
    partial class MainForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnSavings = new System.Windows.Forms.Button();
            this.btnBudget = new System.Windows.Forms.Button();
            this.btnTransaction = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlTransactions = new System.Windows.Forms.Panel();
            this.pnlBudget = new System.Windows.Forms.Panel();
            this.pnlSaving = new System.Windows.Forms.Panel();
            this.pnlReports = new System.Windows.Forms.Panel();
            this.lblExpensesByCategoryTitle = new System.Windows.Forms.Label();
            this.chtExpensesByCategory = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlReportSummary = new System.Windows.Forms.Panel();
            this.lblReportSavings = new System.Windows.Forms.Label();
            this.lblReportSavingsTitle = new System.Windows.Forms.Label();
            this.lblReportExpenses = new System.Windows.Forms.Label();
            this.lblReportExpensesTitle = new System.Windows.Forms.Label();
            this.lblReportIncome = new System.Windows.Forms.Label();
            this.lblReportIncomeTitle = new System.Windows.Forms.Label();
            this.pnlReportFilter = new System.Windows.Forms.Panel();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.numReportYear = new System.Windows.Forms.NumericUpDown();
            this.lblReportYear = new System.Windows.Forms.Label();
            this.cmbReportMonth = new System.Windows.Forms.ComboBox();
            this.lblReportMonth = new System.Windows.Forms.Label();
            this.lblReportsPageTitle = new System.Windows.Forms.Label();
            this.btnDeleteGoal = new System.Windows.Forms.Button();
            this.btnAddSavings = new System.Windows.Forms.Button();
            this.dgvSavingsGoals = new System.Windows.Forms.DataGridView();
            this.lblYourGoals = new System.Windows.Forms.Label();
            this.pnlAddGoal = new System.Windows.Forms.Panel();
            this.btnAddGoal = new System.Windows.Forms.Button();
            this.numAlreadySaved = new System.Windows.Forms.NumericUpDown();
            this.lblAlreadySaved = new System.Windows.Forms.Label();
            this.numTargetAmount = new System.Windows.Forms.NumericUpDown();
            this.lblTargetAmount = new System.Windows.Forms.Label();
            this.txtGoalName = new System.Windows.Forms.TextBox();
            this.lblGoalName = new System.Windows.Forms.Label();
            this.lblAddGoalTitle = new System.Windows.Forms.Label();
            this.lblSavingPageTitle = new System.Windows.Forms.Label();
            this.pnlBudgetOverview = new System.Windows.Forms.Panel();
            this.lblBudgetPercentage = new System.Windows.Forms.Label();
            this.prgBudgetOverview = new System.Windows.Forms.ProgressBar();
            this.lblRemaining = new System.Windows.Forms.Label();
            this.lblRemainingTitle = new System.Windows.Forms.Label();
            this.lblSpent = new System.Windows.Forms.Label();
            this.lblSpentTitle = new System.Windows.Forms.Label();
            this.lblOverviewBudget = new System.Windows.Forms.Label();
            this.lblOverviewBudgetTitle = new System.Windows.Forms.Label();
            this.lblBudgetOvetvieoTitle = new System.Windows.Forms.Label();
            this.pnlSetBudget = new System.Windows.Forms.Panel();
            this.btnSaveBudget = new System.Windows.Forms.Button();
            this.numBudgetAmount = new System.Windows.Forms.NumericUpDown();
            this.lblBudgetAmountInput = new System.Windows.Forms.Label();
            this.numBudgetYear = new System.Windows.Forms.NumericUpDown();
            this.lblBudgetYear = new System.Windows.Forms.Label();
            this.cmbBudgetMonth = new System.Windows.Forms.ComboBox();
            this.lblBudgetMonth = new System.Windows.Forms.Label();
            this.lblSetBudgetTitle = new System.Windows.Forms.Label();
            this.lblBudgetPageTitle = new System.Windows.Forms.Label();
            this.dgvTransactions = new System.Windows.Forms.DataGridView();
            this.lblAllTransaction = new System.Windows.Forms.Label();
            this.pnlAddTransaction = new System.Windows.Forms.Panel();
            this.btnAddTransaction = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.numAmount = new System.Windows.Forms.NumericUpDown();
            this.lblAmount = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblAddTransactionTitle = new System.Windows.Forms.Label();
            this.lblTransactionsTitle = new System.Windows.Forms.Label();
            this.dgvRecentTransactions = new System.Windows.Forms.DataGridView();
            this.lblRecentTransactions = new System.Windows.Forms.Label();
            this.pnlBudgetSummary = new System.Windows.Forms.Panel();
            this.prgBudget = new System.Windows.Forms.ProgressBar();
            this.lblBudgetAmount = new System.Windows.Forms.Label();
            this.lblBudgetTitle = new System.Windows.Forms.Label();
            this.pnlExpenses = new System.Windows.Forms.Panel();
            this.lblExpanses = new System.Windows.Forms.Label();
            this.lblExpenses = new System.Windows.Forms.Label();
            this.pnlIncome = new System.Windows.Forms.Panel();
            this.lblIncome = new System.Windows.Forms.Label();
            this.lblIncomeTitle = new System.Windows.Forms.Label();
            this.bnlBalance = new System.Windows.Forms.Panel();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblBalanceTitle = new System.Windows.Forms.Label();
            this.lblDashTitle = new System.Windows.Forms.Label();
            this.pnlSidebar.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlTransactions.SuspendLayout();
            this.pnlBudget.SuspendLayout();
            this.pnlSaving.SuspendLayout();
            this.pnlReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtExpensesByCategory)).BeginInit();
            this.pnlReportSummary.SuspendLayout();
            this.pnlReportFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numReportYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSavingsGoals)).BeginInit();
            this.pnlAddGoal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAlreadySaved)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTargetAmount)).BeginInit();
            this.pnlBudgetOverview.SuspendLayout();
            this.pnlSetBudget.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBudgetAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBudgetYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).BeginInit();
            this.pnlAddTransaction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentTransactions)).BeginInit();
            this.pnlBudgetSummary.SuspendLayout();
            this.pnlExpenses.SuspendLayout();
            this.pnlIncome.SuspendLayout();
            this.bnlBalance.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.Controls.Add(this.btnReports);
            this.pnlSidebar.Controls.Add(this.btnSavings);
            this.pnlSidebar.Controls.Add(this.btnBudget);
            this.pnlSidebar.Controls.Add(this.btnTransaction);
            this.pnlSidebar.Controls.Add(this.btnDashboard);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(220, 944);
            this.pnlSidebar.TabIndex = 0;
            // 
            // btnReports
            // 
            this.btnReports.Location = new System.Drawing.Point(43, 384);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(133, 30);
            this.btnReports.TabIndex = 4;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = true;
            // 
            // btnSavings
            // 
            this.btnSavings.Location = new System.Drawing.Point(43, 334);
            this.btnSavings.Name = "btnSavings";
            this.btnSavings.Size = new System.Drawing.Size(133, 33);
            this.btnSavings.TabIndex = 3;
            this.btnSavings.Text = "Saving Goals";
            this.btnSavings.UseVisualStyleBackColor = true;
            // 
            // btnBudget
            // 
            this.btnBudget.Location = new System.Drawing.Point(43, 284);
            this.btnBudget.Name = "btnBudget";
            this.btnBudget.Size = new System.Drawing.Size(133, 29);
            this.btnBudget.TabIndex = 2;
            this.btnBudget.Text = "Budget";
            this.btnBudget.UseVisualStyleBackColor = true;
            // 
            // btnTransaction
            // 
            this.btnTransaction.Location = new System.Drawing.Point(43, 233);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Size = new System.Drawing.Size(133, 32);
            this.btnTransaction.TabIndex = 1;
            this.btnTransaction.Text = "Transactions";
            this.btnTransaction.UseVisualStyleBackColor = true;
            // 
            // btnDashboard
            // 
            this.btnDashboard.Location = new System.Drawing.Point(43, 186);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(133, 28);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlTransactions);
            this.pnlMain.Controls.Add(this.dgvRecentTransactions);
            this.pnlMain.Controls.Add(this.lblRecentTransactions);
            this.pnlMain.Controls.Add(this.pnlBudgetSummary);
            this.pnlMain.Controls.Add(this.pnlExpenses);
            this.pnlMain.Controls.Add(this.pnlIncome);
            this.pnlMain.Controls.Add(this.bnlBalance);
            this.pnlMain.Controls.Add(this.lblDashTitle);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(220, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(496, 944);
            this.pnlMain.TabIndex = 1;
            // 
            // pnlTransactions
            // 
            this.pnlTransactions.Controls.Add(this.pnlBudget);
            this.pnlTransactions.Controls.Add(this.dgvTransactions);
            this.pnlTransactions.Controls.Add(this.lblAllTransaction);
            this.pnlTransactions.Controls.Add(this.pnlAddTransaction);
            this.pnlTransactions.Controls.Add(this.lblTransactionsTitle);
            this.pnlTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTransactions.Location = new System.Drawing.Point(0, 0);
            this.pnlTransactions.Name = "pnlTransactions";
            this.pnlTransactions.Size = new System.Drawing.Size(496, 944);
            this.pnlTransactions.TabIndex = 12;
            // 
            // pnlBudget
            // 
            this.pnlBudget.Controls.Add(this.pnlSaving);
            this.pnlBudget.Controls.Add(this.pnlBudgetOverview);
            this.pnlBudget.Controls.Add(this.pnlSetBudget);
            this.pnlBudget.Controls.Add(this.lblBudgetPageTitle);
            this.pnlBudget.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBudget.Location = new System.Drawing.Point(0, 0);
            this.pnlBudget.Name = "pnlBudget";
            this.pnlBudget.Size = new System.Drawing.Size(496, 944);
            this.pnlBudget.TabIndex = 4;
            // 
            // pnlSaving
            // 
            this.pnlSaving.Controls.Add(this.pnlReports);
            this.pnlSaving.Controls.Add(this.btnDeleteGoal);
            this.pnlSaving.Controls.Add(this.btnAddSavings);
            this.pnlSaving.Controls.Add(this.dgvSavingsGoals);
            this.pnlSaving.Controls.Add(this.lblYourGoals);
            this.pnlSaving.Controls.Add(this.pnlAddGoal);
            this.pnlSaving.Controls.Add(this.lblSavingPageTitle);
            this.pnlSaving.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSaving.Location = new System.Drawing.Point(0, 0);
            this.pnlSaving.Name = "pnlSaving";
            this.pnlSaving.Size = new System.Drawing.Size(496, 944);
            this.pnlSaving.TabIndex = 3;
            // 
            // pnlReports
            // 
            this.pnlReports.Controls.Add(this.lblExpensesByCategoryTitle);
            this.pnlReports.Controls.Add(this.chtExpensesByCategory);
            this.pnlReports.Controls.Add(this.pnlReportSummary);
            this.pnlReports.Controls.Add(this.pnlReportFilter);
            this.pnlReports.Controls.Add(this.lblReportsPageTitle);
            this.pnlReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlReports.Location = new System.Drawing.Point(0, 0);
            this.pnlReports.Name = "pnlReports";
            this.pnlReports.Size = new System.Drawing.Size(496, 944);
            this.pnlReports.TabIndex = 6;
            // 
            // lblExpensesByCategoryTitle
            // 
            this.lblExpensesByCategoryTitle.AutoSize = true;
            this.lblExpensesByCategoryTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpensesByCategoryTitle.Location = new System.Drawing.Point(41, 504);
            this.lblExpensesByCategoryTitle.Name = "lblExpensesByCategoryTitle";
            this.lblExpensesByCategoryTitle.Size = new System.Drawing.Size(318, 32);
            this.lblExpensesByCategoryTitle.TabIndex = 4;
            this.lblExpensesByCategoryTitle.Text = "Expenses by Category";
            this.lblExpensesByCategoryTitle.Click += new System.EventHandler(this.lblExpensesByCategoryTitle_Click);
            // 
            // chtExpensesByCategory
            // 
            chartArea3.Name = "ChartArea1";
            this.chtExpensesByCategory.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chtExpensesByCategory.Legends.Add(legend3);
            this.chtExpensesByCategory.Location = new System.Drawing.Point(19, 553);
            this.chtExpensesByCategory.Name = "chtExpensesByCategory";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chtExpensesByCategory.Series.Add(series3);
            this.chtExpensesByCategory.Size = new System.Drawing.Size(462, 331);
            this.chtExpensesByCategory.TabIndex = 3;
            this.chtExpensesByCategory.Text = "chart1";
            // 
            // pnlReportSummary
            // 
            this.pnlReportSummary.Controls.Add(this.lblReportSavings);
            this.pnlReportSummary.Controls.Add(this.lblReportSavingsTitle);
            this.pnlReportSummary.Controls.Add(this.lblReportExpenses);
            this.pnlReportSummary.Controls.Add(this.lblReportExpensesTitle);
            this.pnlReportSummary.Controls.Add(this.lblReportIncome);
            this.pnlReportSummary.Controls.Add(this.lblReportIncomeTitle);
            this.pnlReportSummary.Location = new System.Drawing.Point(19, 341);
            this.pnlReportSummary.Name = "pnlReportSummary";
            this.pnlReportSummary.Size = new System.Drawing.Size(448, 113);
            this.pnlReportSummary.TabIndex = 2;
            // 
            // lblReportSavings
            // 
            this.lblReportSavings.AutoSize = true;
            this.lblReportSavings.Location = new System.Drawing.Point(310, 57);
            this.lblReportSavings.Name = "lblReportSavings";
            this.lblReportSavings.Size = new System.Drawing.Size(76, 20);
            this.lblReportSavings.TabIndex = 5;
            this.lblReportSavings.Text = "0.00 JOD";
            // 
            // lblReportSavingsTitle
            // 
            this.lblReportSavingsTitle.AutoSize = true;
            this.lblReportSavingsTitle.Location = new System.Drawing.Point(301, 16);
            this.lblReportSavingsTitle.Name = "lblReportSavingsTitle";
            this.lblReportSavingsTitle.Size = new System.Drawing.Size(94, 20);
            this.lblReportSavingsTitle.TabIndex = 4;
            this.lblReportSavingsTitle.Text = "Net Savings";
            this.lblReportSavingsTitle.Click += new System.EventHandler(this.lblReportSavingsTitle_Click);
            // 
            // lblReportExpenses
            // 
            this.lblReportExpenses.AutoSize = true;
            this.lblReportExpenses.Location = new System.Drawing.Point(176, 57);
            this.lblReportExpenses.Name = "lblReportExpenses";
            this.lblReportExpenses.Size = new System.Drawing.Size(76, 20);
            this.lblReportExpenses.TabIndex = 3;
            this.lblReportExpenses.Text = "0.00 JOD";
            this.lblReportExpenses.Click += new System.EventHandler(this.lblReportExpenses_Click);
            // 
            // lblReportExpensesTitle
            // 
            this.lblReportExpensesTitle.AutoSize = true;
            this.lblReportExpensesTitle.Location = new System.Drawing.Point(157, 16);
            this.lblReportExpensesTitle.Name = "lblReportExpensesTitle";
            this.lblReportExpensesTitle.Size = new System.Drawing.Size(118, 20);
            this.lblReportExpensesTitle.TabIndex = 2;
            this.lblReportExpensesTitle.Text = "Total Expenses";
            // 
            // lblReportIncome
            // 
            this.lblReportIncome.AutoSize = true;
            this.lblReportIncome.Location = new System.Drawing.Point(47, 53);
            this.lblReportIncome.Name = "lblReportIncome";
            this.lblReportIncome.Size = new System.Drawing.Size(76, 20);
            this.lblReportIncome.TabIndex = 1;
            this.lblReportIncome.Text = "0.00 JOD";
            // 
            // lblReportIncomeTitle
            // 
            this.lblReportIncomeTitle.AutoSize = true;
            this.lblReportIncomeTitle.Location = new System.Drawing.Point(27, 16);
            this.lblReportIncomeTitle.Name = "lblReportIncomeTitle";
            this.lblReportIncomeTitle.Size = new System.Drawing.Size(101, 20);
            this.lblReportIncomeTitle.TabIndex = 0;
            this.lblReportIncomeTitle.Text = "Total Income";
            // 
            // pnlReportFilter
            // 
            this.pnlReportFilter.Controls.Add(this.btnGenerateReport);
            this.pnlReportFilter.Controls.Add(this.numReportYear);
            this.pnlReportFilter.Controls.Add(this.lblReportYear);
            this.pnlReportFilter.Controls.Add(this.cmbReportMonth);
            this.pnlReportFilter.Controls.Add(this.lblReportMonth);
            this.pnlReportFilter.Location = new System.Drawing.Point(19, 157);
            this.pnlReportFilter.Name = "pnlReportFilter";
            this.pnlReportFilter.Size = new System.Drawing.Size(448, 112);
            this.pnlReportFilter.TabIndex = 1;
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Location = new System.Drawing.Point(124, 62);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(234, 32);
            this.btnGenerateReport.TabIndex = 4;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // numReportYear
            // 
            this.numReportYear.Location = new System.Drawing.Point(293, 17);
            this.numReportYear.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.numReportYear.Minimum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.numReportYear.Name = "numReportYear";
            this.numReportYear.Size = new System.Drawing.Size(120, 26);
            this.numReportYear.TabIndex = 3;
            this.numReportYear.Value = new decimal(new int[] {
            2026,
            0,
            0,
            0});
            this.numReportYear.ValueChanged += new System.EventHandler(this.numReportYear_ValueChanged);
            // 
            // lblReportYear
            // 
            this.lblReportYear.AutoSize = true;
            this.lblReportYear.Location = new System.Drawing.Point(232, 23);
            this.lblReportYear.Name = "lblReportYear";
            this.lblReportYear.Size = new System.Drawing.Size(43, 20);
            this.lblReportYear.TabIndex = 2;
            this.lblReportYear.Text = "Year";
            // 
            // cmbReportMonth
            // 
            this.cmbReportMonth.FormattingEnabled = true;
            this.cmbReportMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cmbReportMonth.Location = new System.Drawing.Point(76, 17);
            this.cmbReportMonth.Name = "cmbReportMonth";
            this.cmbReportMonth.Size = new System.Drawing.Size(121, 28);
            this.cmbReportMonth.TabIndex = 1;
            // 
            // lblReportMonth
            // 
            this.lblReportMonth.AutoSize = true;
            this.lblReportMonth.Location = new System.Drawing.Point(13, 24);
            this.lblReportMonth.Name = "lblReportMonth";
            this.lblReportMonth.Size = new System.Drawing.Size(54, 20);
            this.lblReportMonth.TabIndex = 0;
            this.lblReportMonth.Text = "Month";
            // 
            // lblReportsPageTitle
            // 
            this.lblReportsPageTitle.AutoSize = true;
            this.lblReportsPageTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportsPageTitle.Location = new System.Drawing.Point(36, 66);
            this.lblReportsPageTitle.Name = "lblReportsPageTitle";
            this.lblReportsPageTitle.Size = new System.Drawing.Size(167, 46);
            this.lblReportsPageTitle.TabIndex = 0;
            this.lblReportsPageTitle.Text = "Reports";
            // 
            // btnDeleteGoal
            // 
            this.btnDeleteGoal.Location = new System.Drawing.Point(259, 804);
            this.btnDeleteGoal.Name = "btnDeleteGoal";
            this.btnDeleteGoal.Size = new System.Drawing.Size(134, 36);
            this.btnDeleteGoal.TabIndex = 5;
            this.btnDeleteGoal.Text = "Delete Goal";
            this.btnDeleteGoal.UseVisualStyleBackColor = true;
            // 
            // btnAddSavings
            // 
            this.btnAddSavings.Location = new System.Drawing.Point(82, 804);
            this.btnAddSavings.Name = "btnAddSavings";
            this.btnAddSavings.Size = new System.Drawing.Size(134, 36);
            this.btnAddSavings.TabIndex = 4;
            this.btnAddSavings.Text = "Add Savings";
            this.btnAddSavings.UseVisualStyleBackColor = true;
            // 
            // dgvSavingsGoals
            // 
            this.dgvSavingsGoals.AllowUserToAddRows = false;
            this.dgvSavingsGoals.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSavingsGoals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSavingsGoals.Location = new System.Drawing.Point(33, 530);
            this.dgvSavingsGoals.MultiSelect = false;
            this.dgvSavingsGoals.Name = "dgvSavingsGoals";
            this.dgvSavingsGoals.ReadOnly = true;
            this.dgvSavingsGoals.RowHeadersWidth = 62;
            this.dgvSavingsGoals.RowTemplate.Height = 28;
            this.dgvSavingsGoals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSavingsGoals.Size = new System.Drawing.Size(411, 232);
            this.dgvSavingsGoals.TabIndex = 3;
            this.dgvSavingsGoals.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblYourGoals
            // 
            this.lblYourGoals.AutoSize = true;
            this.lblYourGoals.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourGoals.Location = new System.Drawing.Point(47, 452);
            this.lblYourGoals.Name = "lblYourGoals";
            this.lblYourGoals.Size = new System.Drawing.Size(268, 32);
            this.lblYourGoals.TabIndex = 2;
            this.lblYourGoals.Text = "Your Saving Goals";
            // 
            // pnlAddGoal
            // 
            this.pnlAddGoal.Controls.Add(this.btnAddGoal);
            this.pnlAddGoal.Controls.Add(this.numAlreadySaved);
            this.pnlAddGoal.Controls.Add(this.lblAlreadySaved);
            this.pnlAddGoal.Controls.Add(this.numTargetAmount);
            this.pnlAddGoal.Controls.Add(this.lblTargetAmount);
            this.pnlAddGoal.Controls.Add(this.txtGoalName);
            this.pnlAddGoal.Controls.Add(this.lblGoalName);
            this.pnlAddGoal.Controls.Add(this.lblAddGoalTitle);
            this.pnlAddGoal.Location = new System.Drawing.Point(36, 138);
            this.pnlAddGoal.Name = "pnlAddGoal";
            this.pnlAddGoal.Size = new System.Drawing.Size(408, 242);
            this.pnlAddGoal.TabIndex = 1;
            // 
            // btnAddGoal
            // 
            this.btnAddGoal.Location = new System.Drawing.Point(95, 188);
            this.btnAddGoal.Name = "btnAddGoal";
            this.btnAddGoal.Size = new System.Drawing.Size(222, 34);
            this.btnAddGoal.TabIndex = 7;
            this.btnAddGoal.Text = "Add Goal";
            this.btnAddGoal.UseVisualStyleBackColor = true;
            this.btnAddGoal.Click += new System.EventHandler(this.button1_Click);
            // 
            // numAlreadySaved
            // 
            this.numAlreadySaved.DecimalPlaces = 2;
            this.numAlreadySaved.Location = new System.Drawing.Point(163, 135);
            this.numAlreadySaved.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numAlreadySaved.Name = "numAlreadySaved";
            this.numAlreadySaved.Size = new System.Drawing.Size(120, 26);
            this.numAlreadySaved.TabIndex = 6;
            // 
            // lblAlreadySaved
            // 
            this.lblAlreadySaved.AutoSize = true;
            this.lblAlreadySaved.Location = new System.Drawing.Point(30, 141);
            this.lblAlreadySaved.Name = "lblAlreadySaved";
            this.lblAlreadySaved.Size = new System.Drawing.Size(111, 20);
            this.lblAlreadySaved.TabIndex = 5;
            this.lblAlreadySaved.Text = "Already Saved";
            // 
            // numTargetAmount
            // 
            this.numTargetAmount.DecimalPlaces = 2;
            this.numTargetAmount.Location = new System.Drawing.Point(163, 99);
            this.numTargetAmount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numTargetAmount.Name = "numTargetAmount";
            this.numTargetAmount.Size = new System.Drawing.Size(120, 26);
            this.numTargetAmount.TabIndex = 4;
            // 
            // lblTargetAmount
            // 
            this.lblTargetAmount.AutoSize = true;
            this.lblTargetAmount.Location = new System.Drawing.Point(28, 104);
            this.lblTargetAmount.Name = "lblTargetAmount";
            this.lblTargetAmount.Size = new System.Drawing.Size(115, 20);
            this.lblTargetAmount.TabIndex = 3;
            this.lblTargetAmount.Text = "Target Amount";
            // 
            // txtGoalName
            // 
            this.txtGoalName.Location = new System.Drawing.Point(163, 60);
            this.txtGoalName.Name = "txtGoalName";
            this.txtGoalName.Size = new System.Drawing.Size(154, 26);
            this.txtGoalName.TabIndex = 2;
            // 
            // lblGoalName
            // 
            this.lblGoalName.AutoSize = true;
            this.lblGoalName.Location = new System.Drawing.Point(26, 63);
            this.lblGoalName.Name = "lblGoalName";
            this.lblGoalName.Size = new System.Drawing.Size(89, 20);
            this.lblGoalName.TabIndex = 1;
            this.lblGoalName.Text = "Goal Name";
            // 
            // lblAddGoalTitle
            // 
            this.lblAddGoalTitle.AutoSize = true;
            this.lblAddGoalTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddGoalTitle.Location = new System.Drawing.Point(14, 12);
            this.lblAddGoalTitle.Name = "lblAddGoalTitle";
            this.lblAddGoalTitle.Size = new System.Drawing.Size(258, 32);
            this.lblAddGoalTitle.TabIndex = 0;
            this.lblAddGoalTitle.Text = "Add Savings Goal";
            // 
            // lblSavingPageTitle
            // 
            this.lblSavingPageTitle.AutoSize = true;
            this.lblSavingPageTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSavingPageTitle.Location = new System.Drawing.Point(39, 41);
            this.lblSavingPageTitle.Name = "lblSavingPageTitle";
            this.lblSavingPageTitle.Size = new System.Drawing.Size(269, 46);
            this.lblSavingPageTitle.TabIndex = 0;
            this.lblSavingPageTitle.Text = "Saving Goals";
            this.lblSavingPageTitle.Click += new System.EventHandler(this.lblSavingPageTitle_Click);
            // 
            // pnlBudgetOverview
            // 
            this.pnlBudgetOverview.Controls.Add(this.lblBudgetPercentage);
            this.pnlBudgetOverview.Controls.Add(this.prgBudgetOverview);
            this.pnlBudgetOverview.Controls.Add(this.lblRemaining);
            this.pnlBudgetOverview.Controls.Add(this.lblRemainingTitle);
            this.pnlBudgetOverview.Controls.Add(this.lblSpent);
            this.pnlBudgetOverview.Controls.Add(this.lblSpentTitle);
            this.pnlBudgetOverview.Controls.Add(this.lblOverviewBudget);
            this.pnlBudgetOverview.Controls.Add(this.lblOverviewBudgetTitle);
            this.pnlBudgetOverview.Controls.Add(this.lblBudgetOvetvieoTitle);
            this.pnlBudgetOverview.Location = new System.Drawing.Point(33, 407);
            this.pnlBudgetOverview.Name = "pnlBudgetOverview";
            this.pnlBudgetOverview.Size = new System.Drawing.Size(448, 222);
            this.pnlBudgetOverview.TabIndex = 2;
            // 
            // lblBudgetPercentage
            // 
            this.lblBudgetPercentage.AutoSize = true;
            this.lblBudgetPercentage.Location = new System.Drawing.Point(33, 169);
            this.lblBudgetPercentage.Name = "lblBudgetPercentage";
            this.lblBudgetPercentage.Size = new System.Drawing.Size(32, 20);
            this.lblBudgetPercentage.TabIndex = 8;
            this.lblBudgetPercentage.Text = "0%";
            // 
            // prgBudgetOverview
            // 
            this.prgBudgetOverview.Location = new System.Drawing.Point(77, 169);
            this.prgBudgetOverview.Name = "prgBudgetOverview";
            this.prgBudgetOverview.Size = new System.Drawing.Size(334, 23);
            this.prgBudgetOverview.TabIndex = 7;
            // 
            // lblRemaining
            // 
            this.lblRemaining.AutoSize = true;
            this.lblRemaining.Location = new System.Drawing.Point(299, 123);
            this.lblRemaining.Name = "lblRemaining";
            this.lblRemaining.Size = new System.Drawing.Size(76, 20);
            this.lblRemaining.TabIndex = 6;
            this.lblRemaining.Text = "0.00 JOD";
            // 
            // lblRemainingTitle
            // 
            this.lblRemainingTitle.AutoSize = true;
            this.lblRemainingTitle.Location = new System.Drawing.Point(296, 77);
            this.lblRemainingTitle.Name = "lblRemainingTitle";
            this.lblRemainingTitle.Size = new System.Drawing.Size(85, 20);
            this.lblRemainingTitle.TabIndex = 5;
            this.lblRemainingTitle.Text = "Remaining";
            // 
            // lblSpent
            // 
            this.lblSpent.AutoSize = true;
            this.lblSpent.Location = new System.Drawing.Point(167, 123);
            this.lblSpent.Name = "lblSpent";
            this.lblSpent.Size = new System.Drawing.Size(76, 20);
            this.lblSpent.TabIndex = 4;
            this.lblSpent.Text = "0.00 JOD";
            // 
            // lblSpentTitle
            // 
            this.lblSpentTitle.AutoSize = true;
            this.lblSpentTitle.Location = new System.Drawing.Point(178, 77);
            this.lblSpentTitle.Name = "lblSpentTitle";
            this.lblSpentTitle.Size = new System.Drawing.Size(52, 20);
            this.lblSpentTitle.TabIndex = 3;
            this.lblSpentTitle.Text = "Spent";
            // 
            // lblOverviewBudget
            // 
            this.lblOverviewBudget.AutoSize = true;
            this.lblOverviewBudget.Location = new System.Drawing.Point(43, 123);
            this.lblOverviewBudget.Name = "lblOverviewBudget";
            this.lblOverviewBudget.Size = new System.Drawing.Size(76, 20);
            this.lblOverviewBudget.TabIndex = 2;
            this.lblOverviewBudget.Text = "0.00 JOD";
            // 
            // lblOverviewBudgetTitle
            // 
            this.lblOverviewBudgetTitle.AutoSize = true;
            this.lblOverviewBudgetTitle.Location = new System.Drawing.Point(43, 79);
            this.lblOverviewBudgetTitle.Name = "lblOverviewBudgetTitle";
            this.lblOverviewBudgetTitle.Size = new System.Drawing.Size(61, 20);
            this.lblOverviewBudgetTitle.TabIndex = 1;
            this.lblOverviewBudgetTitle.Text = "Budget";
            // 
            // lblBudgetOvetvieoTitle
            // 
            this.lblBudgetOvetvieoTitle.AutoSize = true;
            this.lblBudgetOvetvieoTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBudgetOvetvieoTitle.Location = new System.Drawing.Point(31, 14);
            this.lblBudgetOvetvieoTitle.Name = "lblBudgetOvetvieoTitle";
            this.lblBudgetOvetvieoTitle.Size = new System.Drawing.Size(245, 32);
            this.lblBudgetOvetvieoTitle.TabIndex = 0;
            this.lblBudgetOvetvieoTitle.Text = "Budget Overview";
            // 
            // pnlSetBudget
            // 
            this.pnlSetBudget.Controls.Add(this.btnSaveBudget);
            this.pnlSetBudget.Controls.Add(this.numBudgetAmount);
            this.pnlSetBudget.Controls.Add(this.lblBudgetAmountInput);
            this.pnlSetBudget.Controls.Add(this.numBudgetYear);
            this.pnlSetBudget.Controls.Add(this.lblBudgetYear);
            this.pnlSetBudget.Controls.Add(this.cmbBudgetMonth);
            this.pnlSetBudget.Controls.Add(this.lblBudgetMonth);
            this.pnlSetBudget.Controls.Add(this.lblSetBudgetTitle);
            this.pnlSetBudget.Location = new System.Drawing.Point(33, 150);
            this.pnlSetBudget.Name = "pnlSetBudget";
            this.pnlSetBudget.Size = new System.Drawing.Size(448, 233);
            this.pnlSetBudget.TabIndex = 1;
            // 
            // btnSaveBudget
            // 
            this.btnSaveBudget.Location = new System.Drawing.Point(143, 176);
            this.btnSaveBudget.Name = "btnSaveBudget";
            this.btnSaveBudget.Size = new System.Drawing.Size(190, 34);
            this.btnSaveBudget.TabIndex = 7;
            this.btnSaveBudget.Text = "Save Budget";
            this.btnSaveBudget.UseVisualStyleBackColor = true;
            // 
            // numBudgetAmount
            // 
            this.numBudgetAmount.DecimalPlaces = 2;
            this.numBudgetAmount.Location = new System.Drawing.Point(156, 123);
            this.numBudgetAmount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numBudgetAmount.Name = "numBudgetAmount";
            this.numBudgetAmount.Size = new System.Drawing.Size(128, 26);
            this.numBudgetAmount.TabIndex = 6;
            // 
            // lblBudgetAmountInput
            // 
            this.lblBudgetAmountInput.AutoSize = true;
            this.lblBudgetAmountInput.Location = new System.Drawing.Point(29, 125);
            this.lblBudgetAmountInput.Name = "lblBudgetAmountInput";
            this.lblBudgetAmountInput.Size = new System.Drawing.Size(121, 20);
            this.lblBudgetAmountInput.TabIndex = 5;
            this.lblBudgetAmountInput.Text = "Budget Amount";
            // 
            // numBudgetYear
            // 
            this.numBudgetYear.Location = new System.Drawing.Point(303, 65);
            this.numBudgetYear.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.numBudgetYear.Minimum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.numBudgetYear.Name = "numBudgetYear";
            this.numBudgetYear.Size = new System.Drawing.Size(94, 26);
            this.numBudgetYear.TabIndex = 4;
            this.numBudgetYear.Value = new decimal(new int[] {
            2026,
            0,
            0,
            0});
            // 
            // lblBudgetYear
            // 
            this.lblBudgetYear.AutoSize = true;
            this.lblBudgetYear.Location = new System.Drawing.Point(250, 67);
            this.lblBudgetYear.Name = "lblBudgetYear";
            this.lblBudgetYear.Size = new System.Drawing.Size(43, 20);
            this.lblBudgetYear.TabIndex = 3;
            this.lblBudgetYear.Text = "Year";
            this.lblBudgetYear.Click += new System.EventHandler(this.lblBudgetYear_Click);
            // 
            // cmbBudgetMonth
            // 
            this.cmbBudgetMonth.FormattingEnabled = true;
            this.cmbBudgetMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cmbBudgetMonth.Location = new System.Drawing.Point(91, 64);
            this.cmbBudgetMonth.Name = "cmbBudgetMonth";
            this.cmbBudgetMonth.Size = new System.Drawing.Size(121, 28);
            this.cmbBudgetMonth.TabIndex = 2;
            // 
            // lblBudgetMonth
            // 
            this.lblBudgetMonth.AutoSize = true;
            this.lblBudgetMonth.Location = new System.Drawing.Point(31, 68);
            this.lblBudgetMonth.Name = "lblBudgetMonth";
            this.lblBudgetMonth.Size = new System.Drawing.Size(54, 20);
            this.lblBudgetMonth.TabIndex = 1;
            this.lblBudgetMonth.Text = "Month";
            // 
            // lblSetBudgetTitle
            // 
            this.lblSetBudgetTitle.AutoSize = true;
            this.lblSetBudgetTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetBudgetTitle.Location = new System.Drawing.Point(20, 15);
            this.lblSetBudgetTitle.Name = "lblSetBudgetTitle";
            this.lblSetBudgetTitle.Size = new System.Drawing.Size(280, 32);
            this.lblSetBudgetTitle.TabIndex = 0;
            this.lblSetBudgetTitle.Text = "Set Monthly Budget";
            // 
            // lblBudgetPageTitle
            // 
            this.lblBudgetPageTitle.AutoSize = true;
            this.lblBudgetPageTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBudgetPageTitle.Location = new System.Drawing.Point(64, 66);
            this.lblBudgetPageTitle.Name = "lblBudgetPageTitle";
            this.lblBudgetPageTitle.Size = new System.Drawing.Size(152, 46);
            this.lblBudgetPageTitle.TabIndex = 0;
            this.lblBudgetPageTitle.Text = "Budget";
            // 
            // dgvTransactions
            // 
            this.dgvTransactions.AllowUserToAddRows = false;
            this.dgvTransactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransactions.Location = new System.Drawing.Point(33, 530);
            this.dgvTransactions.MultiSelect = false;
            this.dgvTransactions.Name = "dgvTransactions";
            this.dgvTransactions.ReadOnly = true;
            this.dgvTransactions.RowHeadersWidth = 62;
            this.dgvTransactions.RowTemplate.Height = 28;
            this.dgvTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransactions.Size = new System.Drawing.Size(422, 197);
            this.dgvTransactions.TabIndex = 3;
            // 
            // lblAllTransaction
            // 
            this.lblAllTransaction.AutoSize = true;
            this.lblAllTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllTransaction.Location = new System.Drawing.Point(64, 475);
            this.lblAllTransaction.Name = "lblAllTransaction";
            this.lblAllTransaction.Size = new System.Drawing.Size(233, 32);
            this.lblAllTransaction.TabIndex = 2;
            this.lblAllTransaction.Text = "All Transactions";
            // 
            // pnlAddTransaction
            // 
            this.pnlAddTransaction.Controls.Add(this.btnAddTransaction);
            this.pnlAddTransaction.Controls.Add(this.txtDescription);
            this.pnlAddTransaction.Controls.Add(this.lblDescription);
            this.pnlAddTransaction.Controls.Add(this.dtpDate);
            this.pnlAddTransaction.Controls.Add(this.lblDate);
            this.pnlAddTransaction.Controls.Add(this.cmbCategory);
            this.pnlAddTransaction.Controls.Add(this.lblCategory);
            this.pnlAddTransaction.Controls.Add(this.numAmount);
            this.pnlAddTransaction.Controls.Add(this.lblAmount);
            this.pnlAddTransaction.Controls.Add(this.cmbType);
            this.pnlAddTransaction.Controls.Add(this.lblType);
            this.pnlAddTransaction.Controls.Add(this.lblAddTransactionTitle);
            this.pnlAddTransaction.Location = new System.Drawing.Point(33, 147);
            this.pnlAddTransaction.Name = "pnlAddTransaction";
            this.pnlAddTransaction.Size = new System.Drawing.Size(422, 254);
            this.pnlAddTransaction.TabIndex = 1;
            // 
            // btnAddTransaction
            // 
            this.btnAddTransaction.Location = new System.Drawing.Point(143, 205);
            this.btnAddTransaction.Name = "btnAddTransaction";
            this.btnAddTransaction.Size = new System.Drawing.Size(173, 31);
            this.btnAddTransaction.TabIndex = 11;
            this.btnAddTransaction.Text = "Add Transaction";
            this.btnAddTransaction.UseVisualStyleBackColor = true;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(120, 162);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(274, 26);
            this.txtDescription.TabIndex = 10;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(25, 165);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(89, 20);
            this.lblDescription.TabIndex = 9;
            this.lblDescription.Text = "Description";
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(279, 108);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(115, 26);
            this.dtpDate.TabIndex = 8;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(222, 113);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(44, 20);
            this.lblDate.TabIndex = 7;
            this.lblDate.Text = "Date";
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "Food",
            "Trnsport",
            "Shopping",
            "Bills",
            "Entertainment",
            "Health",
            "Education",
            "Other"});
            this.cmbCategory.Location = new System.Drawing.Point(98, 110);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(104, 28);
            this.cmbCategory.TabIndex = 6;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(21, 113);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(73, 20);
            this.lblCategory.TabIndex = 5;
            this.lblCategory.Text = "Category";
            // 
            // numAmount
            // 
            this.numAmount.DecimalPlaces = 2;
            this.numAmount.Location = new System.Drawing.Point(300, 69);
            this.numAmount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numAmount.Name = "numAmount";
            this.numAmount.Size = new System.Drawing.Size(94, 26);
            this.numAmount.TabIndex = 4;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(221, 71);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(65, 20);
            this.lblAmount.TabIndex = 3;
            this.lblAmount.Text = "Amount";
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Income",
            "Expense"});
            this.cmbType.Location = new System.Drawing.Point(98, 68);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(102, 28);
            this.cmbType.TabIndex = 2;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(21, 71);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(43, 20);
            this.lblType.TabIndex = 1;
            this.lblType.Text = "Type";
            // 
            // lblAddTransactionTitle
            // 
            this.lblAddTransactionTitle.AutoSize = true;
            this.lblAddTransactionTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddTransactionTitle.Location = new System.Drawing.Point(25, 15);
            this.lblAddTransactionTitle.Name = "lblAddTransactionTitle";
            this.lblAddTransactionTitle.Size = new System.Drawing.Size(236, 32);
            this.lblAddTransactionTitle.TabIndex = 0;
            this.lblAddTransactionTitle.Text = "Add Transaction";
            // 
            // lblTransactionsTitle
            // 
            this.lblTransactionsTitle.AutoSize = true;
            this.lblTransactionsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionsTitle.Location = new System.Drawing.Point(58, 77);
            this.lblTransactionsTitle.Name = "lblTransactionsTitle";
            this.lblTransactionsTitle.Size = new System.Drawing.Size(261, 46);
            this.lblTransactionsTitle.TabIndex = 0;
            this.lblTransactionsTitle.Text = "Transactions";
            // 
            // dgvRecentTransactions
            // 
            this.dgvRecentTransactions.AllowUserToAddRows = false;
            this.dgvRecentTransactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecentTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecentTransactions.Location = new System.Drawing.Point(19, 544);
            this.dgvRecentTransactions.Name = "dgvRecentTransactions";
            this.dgvRecentTransactions.ReadOnly = true;
            this.dgvRecentTransactions.RowHeadersWidth = 62;
            this.dgvRecentTransactions.RowTemplate.Height = 28;
            this.dgvRecentTransactions.Size = new System.Drawing.Size(465, 296);
            this.dgvRecentTransactions.TabIndex = 11;
            // 
            // lblRecentTransactions
            // 
            this.lblRecentTransactions.AutoSize = true;
            this.lblRecentTransactions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecentTransactions.Location = new System.Drawing.Point(58, 484);
            this.lblRecentTransactions.Name = "lblRecentTransactions";
            this.lblRecentTransactions.Size = new System.Drawing.Size(293, 32);
            this.lblRecentTransactions.TabIndex = 10;
            this.lblRecentTransactions.Text = "Recent Transactions";
            this.lblRecentTransactions.Click += new System.EventHandler(this.lblRecentTransactions_Click);
            // 
            // pnlBudgetSummary
            // 
            this.pnlBudgetSummary.Controls.Add(this.prgBudget);
            this.pnlBudgetSummary.Controls.Add(this.lblBudgetAmount);
            this.pnlBudgetSummary.Controls.Add(this.lblBudgetTitle);
            this.pnlBudgetSummary.Location = new System.Drawing.Point(19, 275);
            this.pnlBudgetSummary.Name = "pnlBudgetSummary";
            this.pnlBudgetSummary.Size = new System.Drawing.Size(230, 139);
            this.pnlBudgetSummary.TabIndex = 9;
            // 
            // prgBudget
            // 
            this.prgBudget.Location = new System.Drawing.Point(28, 98);
            this.prgBudget.Name = "prgBudget";
            this.prgBudget.Size = new System.Drawing.Size(165, 28);
            this.prgBudget.TabIndex = 10;
            // 
            // lblBudgetAmount
            // 
            this.lblBudgetAmount.AutoSize = true;
            this.lblBudgetAmount.Location = new System.Drawing.Point(53, 65);
            this.lblBudgetAmount.Name = "lblBudgetAmount";
            this.lblBudgetAmount.Size = new System.Drawing.Size(119, 20);
            this.lblBudgetAmount.TabIndex = 1;
            this.lblBudgetAmount.Text = "0.00 / 0.00 JOD";
            // 
            // lblBudgetTitle
            // 
            this.lblBudgetTitle.AutoSize = true;
            this.lblBudgetTitle.Location = new System.Drawing.Point(24, 13);
            this.lblBudgetTitle.Name = "lblBudgetTitle";
            this.lblBudgetTitle.Size = new System.Drawing.Size(120, 20);
            this.lblBudgetTitle.TabIndex = 0;
            this.lblBudgetTitle.Text = "Monthly Budget";
            // 
            // pnlExpenses
            // 
            this.pnlExpenses.Controls.Add(this.lblExpanses);
            this.pnlExpenses.Controls.Add(this.lblExpenses);
            this.pnlExpenses.Location = new System.Drawing.Point(333, 126);
            this.pnlExpenses.Name = "pnlExpenses";
            this.pnlExpenses.Size = new System.Drawing.Size(151, 110);
            this.pnlExpenses.TabIndex = 8;
            this.pnlExpenses.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlExpenses_Paint);
            // 
            // lblExpanses
            // 
            this.lblExpanses.AutoSize = true;
            this.lblExpanses.Location = new System.Drawing.Point(35, 68);
            this.lblExpanses.Name = "lblExpanses";
            this.lblExpanses.Size = new System.Drawing.Size(76, 20);
            this.lblExpanses.TabIndex = 1;
            this.lblExpanses.Text = "0.00 JOD";
            // 
            // lblExpenses
            // 
            this.lblExpenses.AutoSize = true;
            this.lblExpenses.Location = new System.Drawing.Point(24, 13);
            this.lblExpenses.Name = "lblExpenses";
            this.lblExpenses.Size = new System.Drawing.Size(118, 20);
            this.lblExpenses.TabIndex = 0;
            this.lblExpenses.Text = "Total Expenses";
            // 
            // pnlIncome
            // 
            this.pnlIncome.Controls.Add(this.lblIncome);
            this.pnlIncome.Controls.Add(this.lblIncomeTitle);
            this.pnlIncome.Location = new System.Drawing.Point(176, 126);
            this.pnlIncome.Name = "pnlIncome";
            this.pnlIncome.Size = new System.Drawing.Size(151, 110);
            this.pnlIncome.TabIndex = 7;
            // 
            // lblIncome
            // 
            this.lblIncome.AutoSize = true;
            this.lblIncome.Location = new System.Drawing.Point(35, 68);
            this.lblIncome.Name = "lblIncome";
            this.lblIncome.Size = new System.Drawing.Size(76, 20);
            this.lblIncome.TabIndex = 1;
            this.lblIncome.Text = "0.00 JOD";
            // 
            // lblIncomeTitle
            // 
            this.lblIncomeTitle.AutoSize = true;
            this.lblIncomeTitle.Location = new System.Drawing.Point(24, 13);
            this.lblIncomeTitle.Name = "lblIncomeTitle";
            this.lblIncomeTitle.Size = new System.Drawing.Size(101, 20);
            this.lblIncomeTitle.TabIndex = 0;
            this.lblIncomeTitle.Text = "Total Income";
            // 
            // bnlBalance
            // 
            this.bnlBalance.Controls.Add(this.lblBalance);
            this.bnlBalance.Controls.Add(this.lblBalanceTitle);
            this.bnlBalance.Location = new System.Drawing.Point(19, 126);
            this.bnlBalance.Name = "bnlBalance";
            this.bnlBalance.Size = new System.Drawing.Size(151, 110);
            this.bnlBalance.TabIndex = 6;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(35, 68);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(76, 20);
            this.lblBalance.TabIndex = 1;
            this.lblBalance.Text = "0.00 JOD";
            // 
            // lblBalanceTitle
            // 
            this.lblBalanceTitle.AutoSize = true;
            this.lblBalanceTitle.Location = new System.Drawing.Point(24, 13);
            this.lblBalanceTitle.Name = "lblBalanceTitle";
            this.lblBalanceTitle.Size = new System.Drawing.Size(124, 20);
            this.lblBalanceTitle.TabIndex = 0;
            this.lblBalanceTitle.Text = "Current Balance";
            // 
            // lblDashTitle
            // 
            this.lblDashTitle.AutoSize = true;
            this.lblDashTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashTitle.Location = new System.Drawing.Point(56, 41);
            this.lblDashTitle.Name = "lblDashTitle";
            this.lblDashTitle.Size = new System.Drawing.Size(224, 46);
            this.lblDashTitle.TabIndex = 5;
            this.lblDashTitle.Text = "Dashboard";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 944);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlSidebar);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expense Tracker";
            this.pnlSidebar.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTransactions.ResumeLayout(false);
            this.pnlTransactions.PerformLayout();
            this.pnlBudget.ResumeLayout(false);
            this.pnlBudget.PerformLayout();
            this.pnlSaving.ResumeLayout(false);
            this.pnlSaving.PerformLayout();
            this.pnlReports.ResumeLayout(false);
            this.pnlReports.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtExpensesByCategory)).EndInit();
            this.pnlReportSummary.ResumeLayout(false);
            this.pnlReportSummary.PerformLayout();
            this.pnlReportFilter.ResumeLayout(false);
            this.pnlReportFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numReportYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSavingsGoals)).EndInit();
            this.pnlAddGoal.ResumeLayout(false);
            this.pnlAddGoal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAlreadySaved)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTargetAmount)).EndInit();
            this.pnlBudgetOverview.ResumeLayout(false);
            this.pnlBudgetOverview.PerformLayout();
            this.pnlSetBudget.ResumeLayout(false);
            this.pnlSetBudget.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBudgetAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBudgetYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).EndInit();
            this.pnlAddTransaction.ResumeLayout(false);
            this.pnlAddTransaction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentTransactions)).EndInit();
            this.pnlBudgetSummary.ResumeLayout(false);
            this.pnlBudgetSummary.PerformLayout();
            this.pnlExpenses.ResumeLayout(false);
            this.pnlExpenses.PerformLayout();
            this.pnlIncome.ResumeLayout(false);
            this.pnlIncome.PerformLayout();
            this.bnlBalance.ResumeLayout(false);
            this.bnlBalance.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnSavings;
        private System.Windows.Forms.Button btnBudget;
        private System.Windows.Forms.Button btnTransaction;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblDashTitle;
        private System.Windows.Forms.Panel bnlBalance;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblBalanceTitle;
        private System.Windows.Forms.Panel pnlIncome;
        private System.Windows.Forms.Label lblIncome;
        private System.Windows.Forms.Label lblIncomeTitle;
        private System.Windows.Forms.Panel pnlExpenses;
        private System.Windows.Forms.Label lblExpanses;
        private System.Windows.Forms.Label lblExpenses;
        private System.Windows.Forms.Panel pnlBudgetSummary;
        private System.Windows.Forms.Label lblBudgetAmount;
        private System.Windows.Forms.Label lblBudgetTitle;
        private System.Windows.Forms.ProgressBar prgBudget;
        private System.Windows.Forms.Label lblRecentTransactions;
        private System.Windows.Forms.DataGridView dgvRecentTransactions;
        private System.Windows.Forms.Panel pnlTransactions;
        private System.Windows.Forms.Label lblTransactionsTitle;
        private System.Windows.Forms.Panel pnlAddTransaction;
        private System.Windows.Forms.Label lblAddTransactionTitle;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.NumericUpDown numAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnAddTransaction;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.DataGridView dgvTransactions;
        private System.Windows.Forms.Label lblAllTransaction;
        private System.Windows.Forms.Panel pnlBudget;
        private System.Windows.Forms.Label lblBudgetPageTitle;
        private System.Windows.Forms.Panel pnlSetBudget;
        private System.Windows.Forms.Label lblSetBudgetTitle;
        private System.Windows.Forms.NumericUpDown numBudgetYear;
        private System.Windows.Forms.Label lblBudgetYear;
        private System.Windows.Forms.ComboBox cmbBudgetMonth;
        private System.Windows.Forms.Label lblBudgetMonth;
        private System.Windows.Forms.Label lblBudgetAmountInput;
        private System.Windows.Forms.NumericUpDown numBudgetAmount;
        private System.Windows.Forms.Panel pnlBudgetOverview;
        private System.Windows.Forms.Button btnSaveBudget;
        private System.Windows.Forms.Label lblBudgetOvetvieoTitle;
        private System.Windows.Forms.Label lblRemaining;
        private System.Windows.Forms.Label lblRemainingTitle;
        private System.Windows.Forms.Label lblSpent;
        private System.Windows.Forms.Label lblSpentTitle;
        private System.Windows.Forms.Label lblOverviewBudget;
        private System.Windows.Forms.Label lblOverviewBudgetTitle;
        private System.Windows.Forms.Label lblBudgetPercentage;
        private System.Windows.Forms.ProgressBar prgBudgetOverview;
        private System.Windows.Forms.Panel pnlSaving;
        private System.Windows.Forms.Label lblSavingPageTitle;
        private System.Windows.Forms.Panel pnlAddGoal;
        private System.Windows.Forms.Label lblAddGoalTitle;
        private System.Windows.Forms.NumericUpDown numTargetAmount;
        private System.Windows.Forms.Label lblTargetAmount;
        private System.Windows.Forms.TextBox txtGoalName;
        private System.Windows.Forms.Label lblGoalName;
        private System.Windows.Forms.Button btnAddGoal;
        private System.Windows.Forms.NumericUpDown numAlreadySaved;
        private System.Windows.Forms.Label lblAlreadySaved;
        private System.Windows.Forms.DataGridView dgvSavingsGoals;
        private System.Windows.Forms.Label lblYourGoals;
        private System.Windows.Forms.Button btnDeleteGoal;
        private System.Windows.Forms.Button btnAddSavings;
        private System.Windows.Forms.Panel pnlReports;
        private System.Windows.Forms.Panel pnlReportFilter;
        private System.Windows.Forms.Label lblReportMonth;
        private System.Windows.Forms.Label lblReportsPageTitle;
        private System.Windows.Forms.NumericUpDown numReportYear;
        private System.Windows.Forms.Label lblReportYear;
        private System.Windows.Forms.ComboBox cmbReportMonth;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.Panel pnlReportSummary;
        private System.Windows.Forms.Label lblReportExpenses;
        private System.Windows.Forms.Label lblReportExpensesTitle;
        private System.Windows.Forms.Label lblReportIncome;
        private System.Windows.Forms.Label lblReportIncomeTitle;
        private System.Windows.Forms.Label lblReportSavings;
        private System.Windows.Forms.Label lblReportSavingsTitle;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtExpensesByCategory;
        private System.Windows.Forms.Label lblExpensesByCategoryTitle;
    }
}

