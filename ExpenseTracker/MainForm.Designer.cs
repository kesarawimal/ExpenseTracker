namespace ExpenseTracker
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title7 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title8 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.dashboard = new System.Windows.Forms.TabPage();
            this.lbl7daysBalance = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lbl7daysExpense = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lbl7daysIncome = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblYesterdayBalance = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblYesterdayExpense = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblYesterdayIncome = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblTodayBalance = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTodayExpense = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTodayIncome = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.transactions = new System.Windows.Forms.TabPage();
            this.dtgTransactions = new System.Windows.Forms.DataGridView();
            this.transactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.expenseTrackerData = new ExpenseTracker.ExpenseTrackerData();
            this.btnAddTransaction = new System.Windows.Forms.Button();
            this.reports = new System.Windows.Forms.TabPage();
            this.chrtWeeklyOverallReport = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chrtWeeklyReport = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.forecasting = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label14 = new System.Windows.Forms.Label();
            this.lblPredictIncome = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPredictExpense = new System.Windows.Forms.Label();
            this.dtForecastDate = new System.Windows.Forms.DateTimePicker();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isReccuringDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabControl1.SuspendLayout();
            this.dashboard.SuspendLayout();
            this.transactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseTrackerData)).BeginInit();
            this.reports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrtWeeklyOverallReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtWeeklyReport)).BeginInit();
            this.forecasting.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.dashboard);
            this.tabControl1.Controls.Add(this.transactions);
            this.tabControl1.Controls.Add(this.reports);
            this.tabControl1.Controls.Add(this.forecasting);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.TabSelected);
            // 
            // dashboard
            // 
            this.dashboard.Controls.Add(this.lbl7daysBalance);
            this.dashboard.Controls.Add(this.label15);
            this.dashboard.Controls.Add(this.lbl7daysExpense);
            this.dashboard.Controls.Add(this.label17);
            this.dashboard.Controls.Add(this.lbl7daysIncome);
            this.dashboard.Controls.Add(this.label19);
            this.dashboard.Controls.Add(this.lblYesterdayBalance);
            this.dashboard.Controls.Add(this.label8);
            this.dashboard.Controls.Add(this.lblYesterdayExpense);
            this.dashboard.Controls.Add(this.label11);
            this.dashboard.Controls.Add(this.lblYesterdayIncome);
            this.dashboard.Controls.Add(this.label13);
            this.dashboard.Controls.Add(this.lblTodayBalance);
            this.dashboard.Controls.Add(this.label9);
            this.dashboard.Controls.Add(this.lblTodayExpense);
            this.dashboard.Controls.Add(this.label7);
            this.dashboard.Controls.Add(this.lblTodayIncome);
            this.dashboard.Controls.Add(this.label5);
            this.dashboard.Controls.Add(this.label3);
            this.dashboard.Controls.Add(this.label2);
            this.dashboard.Controls.Add(this.label1);
            this.dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard.Location = new System.Drawing.Point(4, 25);
            this.dashboard.Name = "dashboard";
            this.dashboard.Padding = new System.Windows.Forms.Padding(3);
            this.dashboard.Size = new System.Drawing.Size(768, 397);
            this.dashboard.TabIndex = 0;
            this.dashboard.Text = "Dashboard";
            this.dashboard.UseVisualStyleBackColor = true;
            // 
            // lbl7daysBalance
            // 
            this.lbl7daysBalance.AutoSize = true;
            this.lbl7daysBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl7daysBalance.Location = new System.Drawing.Point(682, 234);
            this.lbl7daysBalance.Name = "lbl7daysBalance";
            this.lbl7daysBalance.Size = new System.Drawing.Size(68, 17);
            this.lbl7daysBalance.TabIndex = 23;
            this.lbl7daysBalance.Text = "0.0 USD";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(565, 234);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 17);
            this.label15.TabIndex = 22;
            this.label15.Text = "Balance: ";
            // 
            // lbl7daysExpense
            // 
            this.lbl7daysExpense.AutoSize = true;
            this.lbl7daysExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl7daysExpense.Location = new System.Drawing.Point(682, 167);
            this.lbl7daysExpense.Name = "lbl7daysExpense";
            this.lbl7daysExpense.Size = new System.Drawing.Size(68, 17);
            this.lbl7daysExpense.TabIndex = 21;
            this.lbl7daysExpense.Text = "0.0 USD";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(565, 167);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(106, 17);
            this.label17.TabIndex = 20;
            this.label17.Text = "Total Expense: ";
            // 
            // lbl7daysIncome
            // 
            this.lbl7daysIncome.AutoSize = true;
            this.lbl7daysIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl7daysIncome.Location = new System.Drawing.Point(682, 100);
            this.lbl7daysIncome.Name = "lbl7daysIncome";
            this.lbl7daysIncome.Size = new System.Drawing.Size(68, 17);
            this.lbl7daysIncome.TabIndex = 19;
            this.lbl7daysIncome.Text = "0.0 USD";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(565, 100);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(97, 17);
            this.label19.TabIndex = 18;
            this.label19.Text = "Total Income: ";
            // 
            // lblYesterdayBalance
            // 
            this.lblYesterdayBalance.AutoSize = true;
            this.lblYesterdayBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYesterdayBalance.Location = new System.Drawing.Point(423, 234);
            this.lblYesterdayBalance.Name = "lblYesterdayBalance";
            this.lblYesterdayBalance.Size = new System.Drawing.Size(68, 17);
            this.lblYesterdayBalance.TabIndex = 17;
            this.lblYesterdayBalance.Text = "0.0 USD";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(306, 234);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Balance: ";
            // 
            // lblYesterdayExpense
            // 
            this.lblYesterdayExpense.AutoSize = true;
            this.lblYesterdayExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYesterdayExpense.Location = new System.Drawing.Point(423, 167);
            this.lblYesterdayExpense.Name = "lblYesterdayExpense";
            this.lblYesterdayExpense.Size = new System.Drawing.Size(68, 17);
            this.lblYesterdayExpense.TabIndex = 15;
            this.lblYesterdayExpense.Text = "0.0 USD";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(306, 167);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 17);
            this.label11.TabIndex = 14;
            this.label11.Text = "Total Expense: ";
            // 
            // lblYesterdayIncome
            // 
            this.lblYesterdayIncome.AutoSize = true;
            this.lblYesterdayIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYesterdayIncome.Location = new System.Drawing.Point(423, 100);
            this.lblYesterdayIncome.Name = "lblYesterdayIncome";
            this.lblYesterdayIncome.Size = new System.Drawing.Size(68, 17);
            this.lblYesterdayIncome.TabIndex = 13;
            this.lblYesterdayIncome.Text = "0.0 USD";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(306, 100);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 17);
            this.label13.TabIndex = 12;
            this.label13.Text = "Total Income: ";
            // 
            // lblTodayBalance
            // 
            this.lblTodayBalance.AutoSize = true;
            this.lblTodayBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodayBalance.Location = new System.Drawing.Point(150, 234);
            this.lblTodayBalance.Name = "lblTodayBalance";
            this.lblTodayBalance.Size = new System.Drawing.Size(68, 17);
            this.lblTodayBalance.TabIndex = 11;
            this.lblTodayBalance.Text = "0.0 USD";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(33, 234);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "Balance: ";
            // 
            // lblTodayExpense
            // 
            this.lblTodayExpense.AutoSize = true;
            this.lblTodayExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodayExpense.Location = new System.Drawing.Point(150, 167);
            this.lblTodayExpense.Name = "lblTodayExpense";
            this.lblTodayExpense.Size = new System.Drawing.Size(68, 17);
            this.lblTodayExpense.TabIndex = 9;
            this.lblTodayExpense.Text = "0.0 USD";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Total Expense: ";
            // 
            // lblTodayIncome
            // 
            this.lblTodayIncome.AutoSize = true;
            this.lblTodayIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodayIncome.Location = new System.Drawing.Point(150, 100);
            this.lblTodayIncome.Name = "lblTodayIncome";
            this.lblTodayIncome.Size = new System.Drawing.Size(68, 17);
            this.lblTodayIncome.TabIndex = 7;
            this.lblTodayIncome.Text = "0.0 USD";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Total Income: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(592, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Last 7 Days";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(331, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Yesterday";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(91, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Today";
            // 
            // transactions
            // 
            this.transactions.Controls.Add(this.dtgTransactions);
            this.transactions.Controls.Add(this.btnAddTransaction);
            this.transactions.Location = new System.Drawing.Point(4, 25);
            this.transactions.Name = "transactions";
            this.transactions.Padding = new System.Windows.Forms.Padding(3);
            this.transactions.Size = new System.Drawing.Size(768, 397);
            this.transactions.TabIndex = 1;
            this.transactions.Text = "Transactions";
            this.transactions.UseVisualStyleBackColor = true;
            // 
            // dtgTransactions
            // 
            this.dtgTransactions.AutoGenerateColumns = false;
            this.dtgTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTransactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noteDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.isReccuringDataGridViewCheckBoxColumn,
            this.Update,
            this.Delete});
            this.dtgTransactions.DataSource = this.transactionBindingSource;
            this.dtgTransactions.Location = new System.Drawing.Point(6, 42);
            this.dtgTransactions.Name = "dtgTransactions";
            this.dtgTransactions.Size = new System.Drawing.Size(744, 349);
            this.dtgTransactions.TabIndex = 1;
            this.dtgTransactions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgTransactions_CellContentClick);
            // 
            // transactionBindingSource
            // 
            this.transactionBindingSource.DataMember = "Transaction";
            this.transactionBindingSource.DataSource = this.expenseTrackerData;
            // 
            // expenseTrackerData
            // 
            this.expenseTrackerData.DataSetName = "ExpenseTrackerData";
            this.expenseTrackerData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAddTransaction
            // 
            this.btnAddTransaction.Location = new System.Drawing.Point(611, 6);
            this.btnAddTransaction.Name = "btnAddTransaction";
            this.btnAddTransaction.Size = new System.Drawing.Size(139, 30);
            this.btnAddTransaction.TabIndex = 0;
            this.btnAddTransaction.Text = "Add Transaction";
            this.btnAddTransaction.UseVisualStyleBackColor = true;
            this.btnAddTransaction.Click += new System.EventHandler(this.AddTransaction);
            // 
            // reports
            // 
            this.reports.AutoScroll = true;
            this.reports.Controls.Add(this.chrtWeeklyOverallReport);
            this.reports.Controls.Add(this.chrtWeeklyReport);
            this.reports.Location = new System.Drawing.Point(4, 25);
            this.reports.Name = "reports";
            this.reports.Padding = new System.Windows.Forms.Padding(3);
            this.reports.Size = new System.Drawing.Size(768, 397);
            this.reports.TabIndex = 2;
            this.reports.Text = "Reports";
            this.reports.UseVisualStyleBackColor = true;
            // 
            // chrtWeeklyOverallReport
            // 
            chartArea7.Name = "ChartArea1";
            this.chrtWeeklyOverallReport.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chrtWeeklyOverallReport.Legends.Add(legend7);
            this.chrtWeeklyOverallReport.Location = new System.Drawing.Point(162, 346);
            this.chrtWeeklyOverallReport.Name = "chrtWeeklyOverallReport";
            series13.ChartArea = "ChartArea1";
            series13.Legend = "Legend1";
            series13.Name = "Income";
            series14.ChartArea = "ChartArea1";
            series14.Legend = "Legend1";
            series14.Name = "Expense";
            this.chrtWeeklyOverallReport.Series.Add(series13);
            this.chrtWeeklyOverallReport.Series.Add(series14);
            this.chrtWeeklyOverallReport.Size = new System.Drawing.Size(425, 221);
            this.chrtWeeklyOverallReport.TabIndex = 1;
            this.chrtWeeklyOverallReport.Text = "chart1";
            title7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            title7.Name = "Weekly Overall Report";
            title7.Text = "Weekly Overall Report";
            this.chrtWeeklyOverallReport.Titles.Add(title7);
            // 
            // chrtWeeklyReport
            // 
            chartArea8.Name = "ChartArea1";
            this.chrtWeeklyReport.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.chrtWeeklyReport.Legends.Add(legend8);
            this.chrtWeeklyReport.Location = new System.Drawing.Point(6, 6);
            this.chrtWeeklyReport.Name = "chrtWeeklyReport";
            series15.ChartArea = "ChartArea1";
            series15.Legend = "Legend1";
            series15.Name = "Income";
            series16.ChartArea = "ChartArea1";
            series16.Legend = "Legend1";
            series16.Name = "Expense";
            this.chrtWeeklyReport.Series.Add(series15);
            this.chrtWeeklyReport.Series.Add(series16);
            this.chrtWeeklyReport.Size = new System.Drawing.Size(744, 334);
            this.chrtWeeklyReport.TabIndex = 0;
            this.chrtWeeklyReport.Text = "chart1";
            title8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            title8.Name = "Title1";
            title8.Text = "Weekly Financial Report";
            this.chrtWeeklyReport.Titles.Add(title8);
            // 
            // forecasting
            // 
            this.forecasting.Controls.Add(this.tableLayoutPanel1);
            this.forecasting.Location = new System.Drawing.Point(4, 25);
            this.forecasting.Name = "forecasting";
            this.forecasting.Size = new System.Drawing.Size(768, 397);
            this.forecasting.TabIndex = 3;
            this.forecasting.Text = "Forecasting";
            this.forecasting.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.51331F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.48669F));
            this.tableLayoutPanel1.Controls.Add(this.label14, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblPredictIncome, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPredictExpense, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dtForecastDate, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(123, 54);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.17391F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.82609F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(526, 205);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(3, 137);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(126, 17);
            this.label14.TabIndex = 5;
            this.label14.Text = "Predicted Expense";
            // 
            // lblPredictIncome
            // 
            this.lblPredictIncome.AutoSize = true;
            this.lblPredictIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPredictIncome.Location = new System.Drawing.Point(295, 71);
            this.lblPredictIncome.Name = "lblPredictIncome";
            this.lblPredictIncome.Size = new System.Drawing.Size(68, 17);
            this.lblPredictIncome.TabIndex = 3;
            this.lblPredictIncome.Text = "0.0 USD";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "Predicted Income";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(257, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Forecast Finance to a Future Date";
            // 
            // lblPredictExpense
            // 
            this.lblPredictExpense.AutoSize = true;
            this.lblPredictExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPredictExpense.Location = new System.Drawing.Point(295, 137);
            this.lblPredictExpense.Name = "lblPredictExpense";
            this.lblPredictExpense.Size = new System.Drawing.Size(68, 17);
            this.lblPredictExpense.TabIndex = 1;
            this.lblPredictExpense.Text = "0.0 USD";
            // 
            // dtForecastDate
            // 
            this.dtForecastDate.CustomFormat = "dd/MM/yyyy";
            this.dtForecastDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtForecastDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtForecastDate.Location = new System.Drawing.Point(295, 3);
            this.dtForecastDate.Name = "dtForecastDate";
            this.dtForecastDate.Size = new System.Drawing.Size(135, 23);
            this.dtForecastDate.TabIndex = 6;
            this.dtForecastDate.ValueChanged += new System.EventHandler(this.ForecasteValues);
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "Note";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount (USD)";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // isReccuringDataGridViewCheckBoxColumn
            // 
            this.isReccuringDataGridViewCheckBoxColumn.DataPropertyName = "isReccuring";
            this.isReccuringDataGridViewCheckBoxColumn.HeaderText = "Is Recurring";
            this.isReccuringDataGridViewCheckBoxColumn.Name = "isReccuringDataGridViewCheckBoxColumn";
            // 
            // Update
            // 
            this.Update.HeaderText = "Update";
            this.Update.Name = "Update";
            this.Update.ReadOnly = true;
            this.Update.Text = "Update";
            this.Update.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Welcome to Expense Tracker";
            this.Shown += new System.EventHandler(this.CheckAuthentication);
            this.tabControl1.ResumeLayout(false);
            this.dashboard.ResumeLayout(false);
            this.dashboard.PerformLayout();
            this.transactions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseTrackerData)).EndInit();
            this.reports.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chrtWeeklyOverallReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtWeeklyReport)).EndInit();
            this.forecasting.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage dashboard;
        private System.Windows.Forms.TabPage transactions;
        private System.Windows.Forms.Button btnAddTransaction;
        private System.Windows.Forms.TabPage reports;
        private System.Windows.Forms.TabPage forecasting;
        private System.Windows.Forms.DataGridView dtgTransactions;
        private System.Windows.Forms.BindingSource transactionBindingSource;
        private ExpenseTrackerData expenseTrackerData;
        private System.Windows.Forms.Label lblTodayBalance;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTodayExpense;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTodayIncome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl7daysBalance;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbl7daysExpense;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lbl7daysIncome;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblYesterdayBalance;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblYesterdayExpense;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblYesterdayIncome;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtWeeklyReport;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtWeeklyOverallReport;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblPredictIncome;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPredictExpense;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtForecastDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isReccuringDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Update;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}

