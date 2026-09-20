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
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnTransaction = new System.Windows.Forms.Button();
            this.btnBudget = new System.Windows.Forms.Button();
            this.btnSavings = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblDashTitle = new System.Windows.Forms.Label();
            this.bnlBalance = new System.Windows.Forms.Panel();
            this.lblBalanceTitle = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.pnlIncome = new System.Windows.Forms.Panel();
            this.lblIncome = new System.Windows.Forms.Label();
            this.lblIncomeTitle = new System.Windows.Forms.Label();
            this.pnlExpenses = new System.Windows.Forms.Panel();
            this.lblExpanses = new System.Windows.Forms.Label();
            this.lblExpenses = new System.Windows.Forms.Label();
            this.pnlBudgetSummary = new System.Windows.Forms.Panel();
            this.lblBudgetAmount = new System.Windows.Forms.Label();
            this.lblBudgetTitle = new System.Windows.Forms.Label();
            this.prgBudget = new System.Windows.Forms.ProgressBar();
            this.lblRecentTransactions = new System.Windows.Forms.Label();
            this.dgvRecentTransactions = new System.Windows.Forms.DataGridView();
            this.pnlSidebar.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.bnlBalance.SuspendLayout();
            this.pnlIncome.SuspendLayout();
            this.pnlExpenses.SuspendLayout();
            this.pnlBudgetSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentTransactions)).BeginInit();
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
            // btnDashboard
            // 
            this.btnDashboard.Location = new System.Drawing.Point(43, 77);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(133, 30);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            // 
            // btnTransaction
            // 
            this.btnTransaction.Location = new System.Drawing.Point(43, 139);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Size = new System.Drawing.Size(133, 27);
            this.btnTransaction.TabIndex = 1;
            this.btnTransaction.Text = "Transactions";
            this.btnTransaction.UseVisualStyleBackColor = true;
            // 
            // btnBudget
            // 
            this.btnBudget.Location = new System.Drawing.Point(43, 207);
            this.btnBudget.Name = "btnBudget";
            this.btnBudget.Size = new System.Drawing.Size(133, 29);
            this.btnBudget.TabIndex = 2;
            this.btnBudget.Text = "Budget";
            this.btnBudget.UseVisualStyleBackColor = true;
            // 
            // btnSavings
            // 
            this.btnSavings.Location = new System.Drawing.Point(43, 275);
            this.btnSavings.Name = "btnSavings";
            this.btnSavings.Size = new System.Drawing.Size(133, 29);
            this.btnSavings.TabIndex = 3;
            this.btnSavings.Text = "Saving Goals";
            this.btnSavings.UseVisualStyleBackColor = true;
            // 
            // btnReports
            // 
            this.btnReports.Location = new System.Drawing.Point(43, 340);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(133, 29);
            this.btnReports.TabIndex = 4;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = true;
            // 
            // pnlMain
            // 
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
            // bnlBalance
            // 
            this.bnlBalance.Controls.Add(this.lblBalance);
            this.bnlBalance.Controls.Add(this.lblBalanceTitle);
            this.bnlBalance.Location = new System.Drawing.Point(19, 126);
            this.bnlBalance.Name = "bnlBalance";
            this.bnlBalance.Size = new System.Drawing.Size(151, 110);
            this.bnlBalance.TabIndex = 6;
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
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(35, 68);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(76, 20);
            this.lblBalance.TabIndex = 1;
            this.lblBalance.Text = "0.00 JOD";
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
            // prgBudget
            // 
            this.prgBudget.Location = new System.Drawing.Point(28, 98);
            this.prgBudget.Name = "prgBudget";
            this.prgBudget.Size = new System.Drawing.Size(165, 28);
            this.prgBudget.TabIndex = 10;
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
            this.bnlBalance.ResumeLayout(false);
            this.bnlBalance.PerformLayout();
            this.pnlIncome.ResumeLayout(false);
            this.pnlIncome.PerformLayout();
            this.pnlExpenses.ResumeLayout(false);
            this.pnlExpenses.PerformLayout();
            this.pnlBudgetSummary.ResumeLayout(false);
            this.pnlBudgetSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentTransactions)).EndInit();
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
    }
}

