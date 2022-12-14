using Syncfusion.Windows.Forms;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.Input.Enums;
using System.Windows.Forms;

namespace InvestmentApp.Forms
{
    partial class Transfer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transfer));
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn1 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn2 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn3 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn4 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridNumericColumn gridNumericColumn1 = new Syncfusion.WinForms.DataGrid.GridNumericColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn5 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn6 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn7 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            this.tbxExplanation = new System.Windows.Forms.RichTextBox();
            this.sfcbxTargetUsers = new Syncfusion.WinForms.ListView.SfComboBox();
            this.userDtoBindingSourceTarget = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxAmount = new Syncfusion.Windows.Forms.Tools.CurrencyTextBox();
            this.sfcbxSenderBankAccounts = new Syncfusion.WinForms.ListView.SfComboBox();
            this.tbxSenderName = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.sfdgSenderBankAccounts = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.bankAccountBindingSourceTarget = new System.Windows.Forms.BindingSource(this.components);
            this.gbxHome = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sfcbxTargetBankAccounts = new Syncfusion.WinForms.ListView.SfComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxTargetIBAN = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.tbxSenderIBAN = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.sfbtnPush = new Syncfusion.WinForms.Controls.SfButton();
            this.sfdgMoneyTransferOperations = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bankAccountBindingSourceSender = new System.Windows.Forms.BindingSource(this.components);
            this.moneyTransferDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sfcbxTargetUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDtoBindingSourceTarget)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfcbxSenderBankAccounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxSenderName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfdgSenderBankAccounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankAccountBindingSourceTarget)).BeginInit();
            this.gbxHome.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sfcbxTargetBankAccounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxTargetIBAN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxSenderIBAN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfdgMoneyTransferOperations)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bankAccountBindingSourceSender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyTransferDtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxExplanation
            // 
            this.tbxExplanation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxExplanation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxExplanation.Location = new System.Drawing.Point(380, 82);
            this.tbxExplanation.Name = "tbxExplanation";
            this.tbxExplanation.Size = new System.Drawing.Size(419, 76);
            this.tbxExplanation.TabIndex = 28;
            this.tbxExplanation.Text = "";
            // 
            // sfcbxTargetUsers
            // 
            this.sfcbxTargetUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sfcbxTargetUsers.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.sfcbxTargetUsers.DataSource = this.userDtoBindingSourceTarget;
            this.sfcbxTargetUsers.DisplayMember = "Name";
            this.sfcbxTargetUsers.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.sfcbxTargetUsers.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfcbxTargetUsers.Location = new System.Drawing.Point(992, 25);
            this.sfcbxTargetUsers.MaxDropDownItems = 15;
            this.sfcbxTargetUsers.Name = "sfcbxTargetUsers";
            this.sfcbxTargetUsers.Size = new System.Drawing.Size(181, 35);
            this.sfcbxTargetUsers.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.sfcbxTargetUsers.Style.EditorStyle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfcbxTargetUsers.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfcbxTargetUsers.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sfcbxTargetUsers.Style.TokenStyle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfcbxTargetUsers.TabIndex = 26;
            this.sfcbxTargetUsers.ValueMember = "ID";
            this.sfcbxTargetUsers.SelectedIndexChanged += new System.EventHandler(this.sfcbxTargetUsers_SelectedIndexChanged);
            // 
            // userDtoBindingSourceTarget
            // 
            this.userDtoBindingSourceTarget.DataSource = typeof(InvestmentApp.Entities.Classes.UserDto);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(801, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "TARGET ACCOUNT";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(563, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "AMOUNT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(273, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "SENDER ACCOUNT";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1043, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "TARGET NAME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(57, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "SENDER NAME";
            // 
            // tbxAmount
            // 
            this.tbxAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxAmount.BeforeTouchSize = new System.Drawing.Size(368, 35);
            this.tbxAmount.DecimalValue = new decimal(new int[] {
            1000,
            0,
            0,
            131072});
            this.tbxAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAmount.Location = new System.Drawing.Point(503, 25);
            this.tbxAmount.Name = "tbxAmount";
            this.tbxAmount.Size = new System.Drawing.Size(176, 35);
            this.tbxAmount.TabIndex = 19;
            this.tbxAmount.Text = "$10.00";
            this.tbxAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sfcbxSenderBankAccounts
            // 
            this.sfcbxSenderBankAccounts.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.sfcbxSenderBankAccounts.DisplayMember = "AccountName";
            this.sfcbxSenderBankAccounts.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.sfcbxSenderBankAccounts.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfcbxSenderBankAccounts.Location = new System.Drawing.Point(193, 25);
            this.sfcbxSenderBankAccounts.Name = "sfcbxSenderBankAccounts";
            this.sfcbxSenderBankAccounts.Size = new System.Drawing.Size(267, 35);
            this.sfcbxSenderBankAccounts.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.sfcbxSenderBankAccounts.Style.EditorStyle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfcbxSenderBankAccounts.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfcbxSenderBankAccounts.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sfcbxSenderBankAccounts.Style.TokenStyle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfcbxSenderBankAccounts.TabIndex = 18;
            this.sfcbxSenderBankAccounts.ValueMember = "IBAN";
            this.sfcbxSenderBankAccounts.SelectedIndexChanged += new System.EventHandler(this.sfcbxSenderBankAccounts_SelectedIndexChanged);
            // 
            // tbxSenderName
            // 
            this.tbxSenderName.BeforeTouchSize = new System.Drawing.Size(368, 35);
            this.tbxSenderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSenderName.Location = new System.Drawing.Point(6, 25);
            this.tbxSenderName.Name = "tbxSenderName";
            this.tbxSenderName.Size = new System.Drawing.Size(181, 35);
            this.tbxSenderName.TabIndex = 17;
            // 
            // sfdgSenderBankAccounts
            // 
            this.sfdgSenderBankAccounts.AccessibleName = "Table";
            this.sfdgSenderBankAccounts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sfdgSenderBankAccounts.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            this.sfdgSenderBankAccounts.DataSource = this.bankAccountBindingSourceTarget;
            this.sfdgSenderBankAccounts.Location = new System.Drawing.Point(6, 12);
            this.sfdgSenderBankAccounts.Name = "sfdgSenderBankAccounts";
            this.sfdgSenderBankAccounts.RowHeight = 50;
            this.sfdgSenderBankAccounts.Size = new System.Drawing.Size(1167, 236);
            this.sfdgSenderBankAccounts.TabIndex = 29;
            this.sfdgSenderBankAccounts.AutoGeneratingColumn += new Syncfusion.WinForms.DataGrid.Events.AutoGeneratingColumnEventHandler(this.sfdgSenderBankAccounts_AutoGeneratingColumn);
            this.sfdgSenderBankAccounts.QueryRowStyle += new Syncfusion.WinForms.DataGrid.Events.QueryRowStyleEventHandler(this.sfdgSenderBankAccounts_QueryRowStyle);
            // 
            // bankAccountBindingSourceTarget
            // 
            this.bankAccountBindingSourceTarget.DataSource = typeof(InvestmentApp.Entities.Classes.BankAccountDto);
            // 
            // gbxHome
            // 
            this.gbxHome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxHome.Controls.Add(this.btnUpdate);
            this.gbxHome.Controls.Add(this.btnRefresh);
            this.gbxHome.Controls.Add(this.btnAdd);
            this.gbxHome.Controls.Add(this.btnDelete);
            this.gbxHome.Location = new System.Drawing.Point(3, 395);
            this.gbxHome.Name = "gbxHome";
            this.gbxHome.Size = new System.Drawing.Size(1179, 77);
            this.gbxHome.TabIndex = 30;
            this.gbxHome.TabStop = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.Location = new System.Drawing.Point(593, 11);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(60, 60);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.BackgroundImage")));
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRefresh.Location = new System.Drawing.Point(659, 11);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(60, 60);
            this.btnRefresh.TabIndex = 16;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAdd.Location = new System.Drawing.Point(461, 11);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(60, 60);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDelete.Location = new System.Drawing.Point(527, 11);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(60, 60);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "SEARCH";
            // 
            // tbxSearch
            // 
            this.tbxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSearch.Location = new System.Drawing.Point(7, 27);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(184, 29);
            this.tbxSearch.TabIndex = 42;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.sfcbxTargetBankAccounts);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbxTargetIBAN);
            this.groupBox1.Controls.Add(this.tbxSenderIBAN);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbxSenderName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.sfcbxSenderBankAccounts);
            this.groupBox1.Controls.Add(this.tbxExplanation);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbxAmount);
            this.groupBox1.Controls.Add(this.sfcbxTargetUsers);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(3, 471);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1179, 165);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            // 
            // sfcbxTargetBankAccounts
            // 
            this.sfcbxTargetBankAccounts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sfcbxTargetBankAccounts.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.sfcbxTargetBankAccounts.DataSource = this.bankAccountBindingSourceTarget;
            this.sfcbxTargetBankAccounts.DisplayMember = "AccountName";
            this.sfcbxTargetBankAccounts.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.sfcbxTargetBankAccounts.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfcbxTargetBankAccounts.Location = new System.Drawing.Point(719, 25);
            this.sfcbxTargetBankAccounts.Name = "sfcbxTargetBankAccounts";
            this.sfcbxTargetBankAccounts.Size = new System.Drawing.Size(267, 35);
            this.sfcbxTargetBankAccounts.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.sfcbxTargetBankAccounts.Style.EditorStyle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfcbxTargetBankAccounts.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfcbxTargetBankAccounts.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sfcbxTargetBankAccounts.Style.TokenStyle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfcbxTargetBankAccounts.TabIndex = 48;
            this.sfcbxTargetBankAccounts.ValueMember = "IBAN";
            this.sfcbxTargetBankAccounts.SelectedIndexChanged += new System.EventHandler(this.sfcbxTargetBankAccounts_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(550, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "EXPLANATION";
            // 
            // tbxTargetIBAN
            // 
            this.tbxTargetIBAN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxTargetIBAN.BeforeTouchSize = new System.Drawing.Size(368, 35);
            this.tbxTargetIBAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTargetIBAN.Location = new System.Drawing.Point(805, 66);
            this.tbxTargetIBAN.Name = "tbxTargetIBAN";
            this.tbxTargetIBAN.Size = new System.Drawing.Size(368, 35);
            this.tbxTargetIBAN.TabIndex = 31;
            // 
            // tbxSenderIBAN
            // 
            this.tbxSenderIBAN.BeforeTouchSize = new System.Drawing.Size(368, 35);
            this.tbxSenderIBAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSenderIBAN.Location = new System.Drawing.Point(6, 66);
            this.tbxSenderIBAN.Name = "tbxSenderIBAN";
            this.tbxSenderIBAN.Size = new System.Drawing.Size(368, 35);
            this.tbxSenderIBAN.TabIndex = 29;
            // 
            // sfbtnPush
            // 
            this.sfbtnPush.AccessibleName = "Button";
            this.sfbtnPush.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sfbtnPush.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.sfbtnPush.Location = new System.Drawing.Point(949, 12);
            this.sfbtnPush.Name = "sfbtnPush";
            this.sfbtnPush.Size = new System.Drawing.Size(224, 44);
            this.sfbtnPush.TabIndex = 44;
            this.sfbtnPush.Text = "PUSH";
            this.sfbtnPush.Click += new System.EventHandler(this.sfbtnPush_Click);
            // 
            // sfdgMoneyTransferOperations
            // 
            this.sfdgMoneyTransferOperations.AccessibleName = "Table";
            this.sfdgMoneyTransferOperations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sfdgMoneyTransferOperations.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            gridTextColumn1.HeaderStyle.FilterIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            gridTextColumn1.HeaderText = "STATUS";
            gridTextColumn1.MappingName = "Status";
            gridTextColumn1.Visible = false;
            gridTextColumn2.AllowEditing = false;
            gridTextColumn2.CellStyle.HorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            gridTextColumn2.HeaderText = "SENDER NAME";
            gridTextColumn2.MappingName = "SenderUser.Name";
            gridTextColumn3.AllowEditing = false;
            gridTextColumn3.CellStyle.HorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            gridTextColumn3.HeaderText = "SENDER ACCOUNT";
            gridTextColumn3.MappingName = "SenderBankAccount.AccountName";
            gridTextColumn4.AllowEditing = false;
            gridTextColumn4.CellStyle.HorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            gridTextColumn4.HeaderText = "CURRENCY TYPE";
            gridTextColumn4.MappingName = "CurrencyType";
            gridNumericColumn1.CellStyle.HorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            gridNumericColumn1.HeaderStyle.FilterIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            gridNumericColumn1.HeaderText = "AMOUNT";
            gridNumericColumn1.MappingName = "Amount";
            gridTextColumn5.CellStyle.HorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            gridTextColumn5.HeaderText = "EXPLANATION";
            gridTextColumn5.MappingName = "Explanation";
            gridTextColumn6.AllowEditing = false;
            gridTextColumn6.CellStyle.HorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            gridTextColumn6.HeaderText = "TARGET NAME";
            gridTextColumn6.MappingName = "TargetUser.Name";
            gridTextColumn7.CellStyle.HorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            gridTextColumn7.HeaderText = "TARGET ACCOUNT";
            gridTextColumn7.MappingName = "TargetBankAccount.AccountName";
            this.sfdgMoneyTransferOperations.Columns.Add(gridTextColumn1);
            this.sfdgMoneyTransferOperations.Columns.Add(gridTextColumn2);
            this.sfdgMoneyTransferOperations.Columns.Add(gridTextColumn3);
            this.sfdgMoneyTransferOperations.Columns.Add(gridTextColumn4);
            this.sfdgMoneyTransferOperations.Columns.Add(gridNumericColumn1);
            this.sfdgMoneyTransferOperations.Columns.Add(gridTextColumn5);
            this.sfdgMoneyTransferOperations.Columns.Add(gridTextColumn6);
            this.sfdgMoneyTransferOperations.Columns.Add(gridTextColumn7);
            this.sfdgMoneyTransferOperations.Location = new System.Drawing.Point(6, 62);
            this.sfdgMoneyTransferOperations.Name = "sfdgMoneyTransferOperations";
            this.sfdgMoneyTransferOperations.RowHeight = 50;
            this.sfdgMoneyTransferOperations.Size = new System.Drawing.Size(1167, 333);
            this.sfdgMoneyTransferOperations.TabIndex = 45;
            this.sfdgMoneyTransferOperations.Text = "sfDataGrid1";
            this.sfdgMoneyTransferOperations.QueryRowStyle += new Syncfusion.WinForms.DataGrid.Events.QueryRowStyleEventHandler(this.sfdgMoneyTransferOperations_QueryRowStyle);
            this.sfdgMoneyTransferOperations.SelectionChanged += new Syncfusion.WinForms.DataGrid.Events.SelectionChangedEventHandler(this.sfdgMoneyTransferOperations_SelectionChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.sfdgMoneyTransferOperations);
            this.groupBox2.Controls.Add(this.sfbtnPush);
            this.groupBox2.Controls.Add(this.tbxSearch);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(3, -3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1179, 401);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.sfdgSenderBankAccounts);
            this.groupBox3.Location = new System.Drawing.Point(3, 635);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1179, 254);
            this.groupBox3.TabIndex = 49;
            this.groupBox3.TabStop = false;
            // 
            // moneyTransferDtoBindingSource
            // 
            this.moneyTransferDtoBindingSource.DataSource = typeof(InvestmentApp.Entities.Classes.MoneyTransferDto);
            // 
            // Transfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(109)))), ((int)(((byte)(126)))));
            this.ClientSize = new System.Drawing.Size(1185, 892);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxHome);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Transfer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transfer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Transfer_FormClosed);
            this.Load += new System.EventHandler(this.Transfer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sfcbxTargetUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDtoBindingSourceTarget)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfcbxSenderBankAccounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxSenderName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfdgSenderBankAccounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankAccountBindingSourceTarget)).EndInit();
            this.gbxHome.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sfcbxTargetBankAccounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxTargetIBAN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxSenderIBAN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfdgMoneyTransferOperations)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bankAccountBindingSourceSender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyTransferDtoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox tbxExplanation;
        private Syncfusion.WinForms.ListView.SfComboBox sfcbxTargetUsers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Syncfusion.Windows.Forms.Tools.CurrencyTextBox tbxAmount;
        private Syncfusion.WinForms.ListView.SfComboBox sfcbxSenderBankAccounts;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt tbxSenderName;
        private Syncfusion.WinForms.DataGrid.SfDataGrid sfdgSenderBankAccounts;
        private System.Windows.Forms.GroupBox gbxHome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt tbxSenderIBAN;
        private System.Windows.Forms.Label label7;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt tbxTargetIBAN;
        private Syncfusion.WinForms.Controls.SfButton sfbtnPush;
        private Syncfusion.WinForms.DataGrid.SfDataGrid sfdgMoneyTransferOperations;
        private Syncfusion.WinForms.ListView.SfComboBox sfcbxTargetBankAccounts;
        private BindingSource userDtoBindingSourceTarget;
        private BindingSource bankAccountBindingSourceTarget;
        private BindingSource moneyTransferDtoBindingSource;
        private BindingSource bankAccountBindingSourceSender;
        private Button btnUpdate;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
    }
}