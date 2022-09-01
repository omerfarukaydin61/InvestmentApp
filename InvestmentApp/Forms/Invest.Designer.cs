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
            this.tbxUserBalance = new Syncfusion.Windows.Forms.Tools.CurrencyTextBox();
            this.cbxUserAccounts = new Syncfusion.WinForms.ListView.SfComboBox();
            this.sfcbxInvestUsers = new Syncfusion.WinForms.ListView.SfComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tbxTotal = new System.Windows.Forms.TextBox();
            this.cbxExType = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbxIBAN = new System.Windows.Forms.TextBox();
            this.sfButton1 = new Syncfusion.WinForms.Controls.SfButton();
            this.sfdgRateOfExchange = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.sfdgInvestmentLogs = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.sfButton2 = new Syncfusion.WinForms.Controls.SfButton();
            this.sfbTransfer = new Syncfusion.WinForms.Controls.SfButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbxUserBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxUserAccounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfcbxInvestUsers)).BeginInit();
            this.groupBox6.SuspendLayout();
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
            this.groupBox1.Controls.Add(this.tbxUserBalance);
            this.groupBox1.Controls.Add(this.cbxUserAccounts);
            this.groupBox1.Controls.Add(this.sfcbxInvestUsers);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.tbxIBAN);
            this.groupBox1.Location = new System.Drawing.Point(1, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(820, 123);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // tbxUserBalance
            // 
            this.tbxUserBalance.BeforeTouchSize = new System.Drawing.Size(206, 35);
            this.tbxUserBalance.DecimalValue = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.tbxUserBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUserBalance.Location = new System.Drawing.Point(14, 53);
            this.tbxUserBalance.Name = "tbxUserBalance";
            this.tbxUserBalance.Size = new System.Drawing.Size(206, 35);
            this.tbxUserBalance.TabIndex = 39;
            this.tbxUserBalance.Text = "$0.00";
            // 
            // cbxUserAccounts
            // 
            this.cbxUserAccounts.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbxUserAccounts.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxUserAccounts.DisplayMember = "AccountName";
            this.cbxUserAccounts.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cbxUserAccounts.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxUserAccounts.Location = new System.Drawing.Point(226, 12);
            this.cbxUserAccounts.Name = "cbxUserAccounts";
            this.cbxUserAccounts.Size = new System.Drawing.Size(368, 35);
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
            this.sfcbxInvestUsers.Location = new System.Drawing.Point(14, 12);
            this.sfcbxInvestUsers.Name = "sfcbxInvestUsers";
            this.sfcbxInvestUsers.Size = new System.Drawing.Size(206, 35);
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
            // groupBox6
            // 
            this.groupBox6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBox6.Controls.Add(this.tbxTotal);
            this.groupBox6.Controls.Add(this.cbxExType);
            this.groupBox6.Location = new System.Drawing.Point(600, 13);
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
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(820, 53);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(322, 219);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // tbxIBAN
            // 
            this.tbxIBAN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbxIBAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxIBAN.Location = new System.Drawing.Point(226, 53);
            this.tbxIBAN.Name = "tbxIBAN";
            this.tbxIBAN.Size = new System.Drawing.Size(368, 35);
            this.tbxIBAN.TabIndex = 32;
            this.tbxIBAN.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbxIBAN_MouseClick);
            // 
            // sfButton1
            // 
            this.sfButton1.AccessibleName = "Button";
            this.sfButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sfButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.sfButton1.Location = new System.Drawing.Point(988, 562);
            this.sfButton1.Name = "sfButton1";
            this.sfButton1.Size = new System.Drawing.Size(165, 95);
            this.sfButton1.TabIndex = 36;
            this.sfButton1.Text = "CREATE NEW ACCOUNT";
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
            this.groupBox5.Controls.Add(this.sfButton2);
            this.groupBox5.Controls.Add(this.sfbTransfer);
            this.groupBox5.Location = new System.Drawing.Point(1, 123);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(819, 546);
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
            gridNumericColumn1.HeaderText = "ID";
            gridNumericColumn1.MappingName = "ID";
            gridNumericColumn1.Visible = false;
            gridTextColumn1.AllowEditing = false;
            gridTextColumn1.CellStyle.HorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            gridTextColumn1.HeaderText = "EffectedID";
            gridTextColumn1.MappingName = "EffectedID";
            gridTextColumn1.Visible = false;
            gridTextColumn1.Width = 60D;
            gridTextColumn2.AllowEditing = false;
            gridTextColumn2.CellStyle.HorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            gridTextColumn2.HeaderText = "AffectedID";
            gridTextColumn2.MappingName = "AffectedID";
            gridTextColumn2.Visible = false;
            gridTextColumn2.Width = 60D;
            gridTextColumn3.AllowEditing = false;
            gridTextColumn3.CellStyle.HorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            gridTextColumn3.HeaderText = "Action";
            gridTextColumn3.MappingName = "Action";
            gridTextColumn3.Width = 65D;
            gridDateTimeColumn1.AllowEditing = false;
            gridDateTimeColumn1.CellStyle.HorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            gridDateTimeColumn1.HeaderText = "Date";
            gridDateTimeColumn1.MappingName = "Date";
            gridDateTimeColumn1.MaxDateTime = new System.DateTime(9999, 12, 31, 23, 59, 59, 999);
            gridDateTimeColumn1.Width = 80D;
            gridTextColumn4.AllowEditing = false;
            gridTextColumn4.CellStyle.HorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            gridTextColumn4.HeaderText = "Explanation";
            gridTextColumn4.MappingName = "Explanation";
            gridTextColumn5.AllowEditing = false;
            gridTextColumn5.CellStyle.HorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            gridTextColumn5.HeaderText = "Currency";
            gridTextColumn5.MappingName = "Currency";
            gridTextColumn5.Width = 40D;
            gridNumericColumn2.AllowEditing = false;
            gridNumericColumn2.CellStyle.HorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            gridNumericColumn2.HeaderText = "Amount";
            gridNumericColumn2.MappingName = "Amount";
            gridNumericColumn2.Width = 60D;
            gridNumericColumn3.AllowEditing = false;
            gridNumericColumn3.HeaderText = "SenderBankAccountId";
            gridNumericColumn3.MappingName = "SenderBankAccountId";
            gridNumericColumn3.Visible = false;
            gridNumericColumn4.AllowEditing = false;
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
            this.sfdgInvestmentLogs.Location = new System.Drawing.Point(96, 59);
            this.sfdgInvestmentLogs.Name = "sfdgInvestmentLogs";
            this.sfdgInvestmentLogs.RowHeight = 50;
            this.sfdgInvestmentLogs.Size = new System.Drawing.Size(711, 475);
            this.sfdgInvestmentLogs.TabIndex = 37;
            this.sfdgInvestmentLogs.Text = "sfDataGrid2";
            this.sfdgInvestmentLogs.ThemeName = "Office2016Black";
            this.sfdgInvestmentLogs.AutoGeneratingColumn += new Syncfusion.WinForms.DataGrid.Events.AutoGeneratingColumnEventHandler(this.sfdgInvestmentLogs_AutoGeneratingColumn);
            this.sfdgInvestmentLogs.QueryRowStyle += new Syncfusion.WinForms.DataGrid.Events.QueryRowStyleEventHandler(this.dgwInvestmentLogs_QueryRowStyle);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(566, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "SEARCH";
            // 
            // tbxSearch
            // 
            this.tbxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSearch.Location = new System.Drawing.Point(623, 19);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(184, 29);
            this.tbxSearch.TabIndex = 40;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // sfButton2
            // 
            this.sfButton2.AccessibleName = "Button";
            this.sfButton2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.sfButton2.Location = new System.Drawing.Point(6, 134);
            this.sfButton2.Name = "sfButton2";
            this.sfButton2.Size = new System.Drawing.Size(84, 69);
            this.sfButton2.TabIndex = 39;
            this.sfButton2.Text = "BANK";
            this.sfButton2.Visible = false;
            // 
            // sfbTransfer
            // 
            this.sfbTransfer.AccessibleName = "Button";
            this.sfbTransfer.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.sfbTransfer.Location = new System.Drawing.Point(6, 59);
            this.sfbTransfer.Name = "sfbTransfer";
            this.sfbTransfer.Size = new System.Drawing.Size(84, 69);
            this.sfbTransfer.TabIndex = 38;
            this.sfbTransfer.Text = "TRANSFER";
            this.sfbTransfer.Click += new System.EventHandler(this.sfbTransfer_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.sfdgRateOfExchange);
            this.groupBox4.Location = new System.Drawing.Point(826, 0);
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
            this.ClientSize = new System.Drawing.Size(1165, 669);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.sfButton1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "Invest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invest";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Invest_FormClosing);
            this.Load += new System.EventHandler(this.Invest_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbxUserBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxUserAccounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfcbxInvestUsers)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private Syncfusion.WinForms.Controls.SfButton sfButton1;
        private System.Windows.Forms.GroupBox groupBox6;
        private Syncfusion.WinForms.Controls.SfButton sfButton2;
        private Syncfusion.WinForms.Controls.SfButton sfbTransfer;
        private Syncfusion.WinForms.DataGrid.SfDataGrid sfdgInvestmentLogs;
        private Syncfusion.WinForms.ListView.SfComboBox sfcbxInvestUsers;
        private Syncfusion.WinForms.ListView.SfComboBox cbxUserAccounts;
        private Syncfusion.Windows.Forms.Tools.CurrencyTextBox tbxUserBalance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.ComboBox cbxExType;
    }
}