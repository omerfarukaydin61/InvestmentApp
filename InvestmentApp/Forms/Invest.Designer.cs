namespace InvestmentApp.Forms
{
    partial class Invest
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
            Syncfusion.WinForms.DataGrid.GridNumericColumn gridNumericColumn1 = new Syncfusion.WinForms.DataGrid.GridNumericColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn1 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn2 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn3 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridDateTimeColumn gridDateTimeColumn1 = new Syncfusion.WinForms.DataGrid.GridDateTimeColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn4 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn5 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridNumericColumn gridNumericColumn2 = new Syncfusion.WinForms.DataGrid.GridNumericColumn();
            Syncfusion.WinForms.DataGrid.GridNumericColumn gridNumericColumn3 = new Syncfusion.WinForms.DataGrid.GridNumericColumn();
            Syncfusion.WinForms.DataGrid.GridNumericColumn gridNumericColumn4 = new Syncfusion.WinForms.DataGrid.GridNumericColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tbxTotal = new System.Windows.Forms.TextBox();
            this.cbxExType = new System.Windows.Forms.ComboBox();
            this.tbxUserBalance = new Syncfusion.Windows.Forms.Tools.CurrencyTextBox();
            this.cbxUserAccounts = new Syncfusion.WinForms.ListView.SfComboBox();
            this.sfcbxInvestUsers = new Syncfusion.WinForms.ListView.SfComboBox();
            this.tbxIBAN = new System.Windows.Forms.TextBox();
            this.sfButton1 = new Syncfusion.WinForms.Controls.SfButton();
            this.sfdgRateOfExchange = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.sfdgInvestmentLogs = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.sfbtnWithdraw = new Syncfusion.WinForms.Controls.SfButton();
            this.sfbtnDeposit = new Syncfusion.WinForms.Controls.SfButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbxUserBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxUserAccounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfcbxInvestUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfdgRateOfExchange)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sfdgInvestmentLogs)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.tbxUserBalance);
            this.groupBox1.Controls.Add(this.cbxUserAccounts);
            this.groupBox1.Controls.Add(this.sfcbxInvestUsers);
            this.groupBox1.Controls.Add(this.tbxIBAN);
            this.groupBox1.Location = new System.Drawing.Point(1, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1079, 123);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBox6.Controls.Add(this.tbxTotal);
            this.groupBox6.Controls.Add(this.cbxExType);
            this.groupBox6.Location = new System.Drawing.Point(859, 13);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(214, 104);
            this.groupBox6.TabIndex = 35;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "TOTAL BANALCE";
            // 
            // tbxTotal
            // 
            this.tbxTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTotal.Location = new System.Drawing.Point(6, 19);
            this.tbxTotal.Name = "tbxTotal";
            this.tbxTotal.Size = new System.Drawing.Size(201, 31);
            this.tbxTotal.TabIndex = 28;
            // 
            // cbxExType
            // 
            this.cbxExType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxExType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxExType.FormattingEnabled = true;
            this.cbxExType.Location = new System.Drawing.Point(6, 59);
            this.cbxExType.Name = "cbxExType";
            this.cbxExType.Size = new System.Drawing.Size(201, 32);
            this.cbxExType.TabIndex = 27;
            this.cbxExType.SelectedValueChanged += new System.EventHandler(this.cbxUserAccounts_SelectedValueChanged);
            // 
            // tbxUserBalance
            // 
            this.tbxUserBalance.BeforeTouchSize = new System.Drawing.Size(262, 35);
            this.tbxUserBalance.DecimalValue = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.tbxUserBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUserBalance.Location = new System.Drawing.Point(6, 53);
            this.tbxUserBalance.Name = "tbxUserBalance";
            this.tbxUserBalance.Size = new System.Drawing.Size(262, 35);
            this.tbxUserBalance.TabIndex = 39;
            this.tbxUserBalance.Text = "$0.00";
            // 
            // cbxUserAccounts
            // 
            this.cbxUserAccounts.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxUserAccounts.DisplayMember = "AccountName";
            this.cbxUserAccounts.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cbxUserAccounts.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxUserAccounts.Location = new System.Drawing.Point(275, 12);
            this.cbxUserAccounts.Name = "cbxUserAccounts";
            this.cbxUserAccounts.Size = new System.Drawing.Size(407, 35);
            this.cbxUserAccounts.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbxUserAccounts.Style.EditorStyle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxUserAccounts.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxUserAccounts.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbxUserAccounts.Style.TokenStyle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxUserAccounts.TabIndex = 38;
            this.cbxUserAccounts.ThemeName = "Office2016Black";
            this.cbxUserAccounts.ValueMember = "IBAN";
            this.cbxUserAccounts.SelectedValueChanged += new System.EventHandler(this.cbxUserAccounts_SelectedValueChanged);
            // 
            // sfcbxInvestUsers
            // 
            this.sfcbxInvestUsers.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.sfcbxInvestUsers.BackColor = System.Drawing.Color.White;
            this.sfcbxInvestUsers.DisplayMember = "Name";
            this.sfcbxInvestUsers.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.sfcbxInvestUsers.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfcbxInvestUsers.Location = new System.Drawing.Point(6, 12);
            this.sfcbxInvestUsers.Name = "sfcbxInvestUsers";
            this.sfcbxInvestUsers.Size = new System.Drawing.Size(262, 35);
            this.sfcbxInvestUsers.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.sfcbxInvestUsers.Style.EditorStyle.BackColor = System.Drawing.Color.White;
            this.sfcbxInvestUsers.Style.EditorStyle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfcbxInvestUsers.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfcbxInvestUsers.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sfcbxInvestUsers.Style.TokenStyle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfcbxInvestUsers.TabIndex = 37;
            this.sfcbxInvestUsers.ThemeName = "";
            this.sfcbxInvestUsers.ValueMember = "ID";
            this.sfcbxInvestUsers.SelectedValueChanged += new System.EventHandler(this.sfcbxInvestUsers_SelectedValueChanged);
            // 
            // tbxIBAN
            // 
            this.tbxIBAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxIBAN.Location = new System.Drawing.Point(275, 53);
            this.tbxIBAN.Name = "tbxIBAN";
            this.tbxIBAN.Size = new System.Drawing.Size(407, 35);
            this.tbxIBAN.TabIndex = 32;
            this.tbxIBAN.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbxIBAN_MouseClick);
            // 
            // sfButton1
            // 
            this.sfButton1.AccessibleName = "Button";
            this.sfButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sfButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.sfButton1.Location = new System.Drawing.Point(1247, 659);
            this.sfButton1.Name = "sfButton1";
            this.sfButton1.Size = new System.Drawing.Size(165, 95);
            this.sfButton1.TabIndex = 36;
            this.sfButton1.Text = "ADD NEW ACCOUNT";
            this.sfButton1.Visible = false;
            // 
            // sfdgRateOfExchange
            // 
            this.sfdgRateOfExchange.AccessibleName = "Table";
            this.sfdgRateOfExchange.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sfdgRateOfExchange.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            this.sfdgRateOfExchange.Location = new System.Drawing.Point(6, 19);
            this.sfdgRateOfExchange.Name = "sfdgRateOfExchange";
            this.sfdgRateOfExchange.Size = new System.Drawing.Size(321, 370);
            this.sfdgRateOfExchange.TabIndex = 30;
            this.sfdgRateOfExchange.Text = "sfDataGrid1";
            this.sfdgRateOfExchange.QueryRowStyle += new Syncfusion.WinForms.DataGrid.Events.QueryRowStyleEventHandler(this.sfdgRateOfExchange_QueryRowStyle);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.sfdgInvestmentLogs);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.tbxSearch);
            this.groupBox5.Controls.Add(this.sfbtnWithdraw);
            this.groupBox5.Controls.Add(this.sfbtnDeposit);
            this.groupBox5.Location = new System.Drawing.Point(1, 123);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1078, 643);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            // 
            // sfdgInvestmentLogs
            // 
            this.sfdgInvestmentLogs.AccessibleName = "Table";
            this.sfdgInvestmentLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sfdgInvestmentLogs.AutoGenerateColumns = false;
            this.sfdgInvestmentLogs.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            gridNumericColumn1.AllowEditing = false;
            gridNumericColumn1.CellStyle.HorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            gridNumericColumn1.HeaderStyle.FilterIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            gridNumericColumn1.HeaderText = "ID";
            gridNumericColumn1.MappingName = "ID";
            gridNumericColumn1.Visible = false;
            gridTextColumn1.AllowEditing = false;
            gridTextColumn1.CellStyle.HorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            gridTextColumn1.HeaderStyle.FilterIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            gridTextColumn1.HeaderText = "EffectedID";
            gridTextColumn1.MappingName = "EffectedID";
            gridTextColumn1.Visible = false;
            gridTextColumn1.Width = 60D;
            gridTextColumn2.AllowEditing = false;
            gridTextColumn2.CellStyle.HorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            gridTextColumn2.HeaderStyle.FilterIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            gridTextColumn2.HeaderText = "AffectedID";
            gridTextColumn2.MappingName = "AffectedID";
            gridTextColumn2.Visible = false;
            gridTextColumn2.Width = 60D;
            gridTextColumn3.AllowEditing = false;
            gridTextColumn3.CellStyle.HorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            gridTextColumn3.HeaderStyle.FilterIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            gridTextColumn3.HeaderText = "Action";
            gridTextColumn3.MappingName = "Action";
            gridTextColumn3.Width = 65D;
            gridDateTimeColumn1.AllowEditing = false;
            gridDateTimeColumn1.CellStyle.HorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            gridDateTimeColumn1.HeaderStyle.FilterIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            gridDateTimeColumn1.HeaderText = "Date";
            gridDateTimeColumn1.MappingName = "Date";
            gridDateTimeColumn1.MaxDateTime = new System.DateTime(9999, 12, 31, 23, 59, 59, 999);
            gridDateTimeColumn1.Width = 80D;
            gridTextColumn4.AllowEditing = false;
            gridTextColumn4.CellStyle.HorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            gridTextColumn4.HeaderStyle.FilterIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            gridTextColumn4.HeaderText = "Explanation";
            gridTextColumn4.MappingName = "Explanation";
            gridTextColumn5.AllowEditing = false;
            gridTextColumn5.CellStyle.HorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            gridTextColumn5.HeaderStyle.FilterIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            gridTextColumn5.HeaderText = "Currency";
            gridTextColumn5.MappingName = "Currency";
            gridTextColumn5.Width = 60D;
            gridNumericColumn2.AllowEditing = false;
            gridNumericColumn2.CellStyle.HorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            gridNumericColumn2.HeaderStyle.FilterIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            gridNumericColumn2.HeaderText = "Amount";
            gridNumericColumn2.MappingName = "Amount";
            gridNumericColumn2.Width = 60D;
            gridNumericColumn3.AllowEditing = false;
            gridNumericColumn3.HeaderStyle.FilterIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            gridNumericColumn3.HeaderText = "SenderBankAccountId";
            gridNumericColumn3.MappingName = "SenderBankAccountId";
            gridNumericColumn3.Visible = false;
            gridNumericColumn4.AllowEditing = false;
            gridNumericColumn4.HeaderStyle.FilterIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            gridNumericColumn4.HeaderText = "TargetBankAccountId";
            gridNumericColumn4.MappingName = "TargetBankAccountId";
            gridNumericColumn4.Visible = false;
            this.sfdgInvestmentLogs.Columns.Add(gridNumericColumn1);
            this.sfdgInvestmentLogs.Columns.Add(gridTextColumn1);
            this.sfdgInvestmentLogs.Columns.Add(gridTextColumn2);
            this.sfdgInvestmentLogs.Columns.Add(gridTextColumn3);
            this.sfdgInvestmentLogs.Columns.Add(gridDateTimeColumn1);
            this.sfdgInvestmentLogs.Columns.Add(gridTextColumn4);
            this.sfdgInvestmentLogs.Columns.Add(gridTextColumn5);
            this.sfdgInvestmentLogs.Columns.Add(gridNumericColumn2);
            this.sfdgInvestmentLogs.Columns.Add(gridNumericColumn3);
            this.sfdgInvestmentLogs.Columns.Add(gridNumericColumn4);
            this.sfdgInvestmentLogs.Location = new System.Drawing.Point(111, 47);
            this.sfdgInvestmentLogs.Name = "sfdgInvestmentLogs";
            this.sfdgInvestmentLogs.RowHeight = 50;
            this.sfdgInvestmentLogs.Size = new System.Drawing.Size(955, 584);
            this.sfdgInvestmentLogs.TabIndex = 37;
            this.sfdgInvestmentLogs.Text = "sfDataGrid2";
            this.sfdgInvestmentLogs.ThemeName = "Office2016Black";
            this.sfdgInvestmentLogs.QueryRowStyle += new Syncfusion.WinForms.DataGrid.Events.QueryRowStyleEventHandler(this.dgwInvestmentLogs_QueryRowStyle);
            this.sfdgInvestmentLogs.CellDoubleClick += new Syncfusion.WinForms.DataGrid.Events.CellClickEventHandler(this.sfdgInvestmentLogs_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(823, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "SEARCH";
            // 
            // tbxSearch
            // 
            this.tbxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSearch.Location = new System.Drawing.Point(880, 12);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(186, 29);
            this.tbxSearch.TabIndex = 40;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // sfbtnWithdraw
            // 
            this.sfbtnWithdraw.AccessibleName = "Button";
            this.sfbtnWithdraw.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.sfbtnWithdraw.Location = new System.Drawing.Point(6, 122);
            this.sfbtnWithdraw.Name = "sfbtnWithdraw";
            this.sfbtnWithdraw.Size = new System.Drawing.Size(99, 69);
            this.sfbtnWithdraw.TabIndex = 39;
            this.sfbtnWithdraw.Text = "WITHDRAW";
            this.sfbtnWithdraw.Click += new System.EventHandler(this.sfbtnWithdraw_Click);
            // 
            // sfbtnDeposit
            // 
            this.sfbtnDeposit.AccessibleName = "Button";
            this.sfbtnDeposit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.sfbtnDeposit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sfbtnDeposit.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.sfbtnDeposit.Location = new System.Drawing.Point(6, 47);
            this.sfbtnDeposit.Name = "sfbtnDeposit";
            this.sfbtnDeposit.Size = new System.Drawing.Size(99, 69);
            this.sfbtnDeposit.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.sfbtnDeposit.TabIndex = 38;
            this.sfbtnDeposit.Text = "DEPOSIT";
            this.sfbtnDeposit.UseVisualStyleBackColor = false;
            this.sfbtnDeposit.Click += new System.EventHandler(this.sfbtnDeposit_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.sfdgRateOfExchange);
            this.groupBox4.Location = new System.Drawing.Point(1085, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(344, 395);
            this.groupBox4.TabIndex = 31;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "RATE OF EXCHANGE";
            // 
            // Invest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(193)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(1424, 766);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.sfButton1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Invest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invest";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Invest_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Invest_FormClosed);
            this.Load += new System.EventHandler(this.Invest_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbxUserBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxUserAccounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfcbxInvestUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfdgRateOfExchange)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sfdgInvestmentLogs)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox tbxTotal;
        private Syncfusion.WinForms.DataGrid.SfDataGrid sfdgRateOfExchange;
        private System.Windows.Forms.TextBox tbxIBAN;
        private System.Windows.Forms.GroupBox groupBox4;
        private Syncfusion.WinForms.Controls.SfButton sfButton1;
        private System.Windows.Forms.GroupBox groupBox6;
        private Syncfusion.WinForms.Controls.SfButton sfbtnWithdraw;
        private Syncfusion.WinForms.Controls.SfButton sfbtnDeposit;
        private Syncfusion.WinForms.DataGrid.SfDataGrid sfdgInvestmentLogs;
        private Syncfusion.WinForms.ListView.SfComboBox sfcbxInvestUsers;
        private Syncfusion.WinForms.ListView.SfComboBox cbxUserAccounts;
        private Syncfusion.Windows.Forms.Tools.CurrencyTextBox tbxUserBalance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.ComboBox cbxExType;
    }
}