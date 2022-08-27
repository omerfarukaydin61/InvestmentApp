namespace InvestmentApp.Forms
{
    partial class TransferPopUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransferPopUp));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sfcbxTargetBankAccounts = new Syncfusion.WinForms.ListView.SfComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxTargetIBAN = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.tbxSenderIBAN = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.tbxSenderName = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label1 = new System.Windows.Forms.Label();
            this.sfcbxSenderBankAccounts = new Syncfusion.WinForms.ListView.SfComboBox();
            this.tbxExplanation = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxAmount = new Syncfusion.Windows.Forms.Tools.CurrencyTextBox();
            this.sfcbxTargetUsers = new Syncfusion.WinForms.ListView.SfComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbxHome = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sfcbxTargetBankAccounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxTargetIBAN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxSenderIBAN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxSenderName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfcbxSenderBankAccounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfcbxTargetUsers)).BeginInit();
            this.gbxHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sfcbxTargetBankAccounts);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbxTargetIBAN);
            this.groupBox1.Controls.Add(this.tbxSenderIBAN);
            this.groupBox1.Controls.Add(this.tbxSenderName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.sfcbxSenderBankAccounts);
            this.groupBox1.Controls.Add(this.tbxExplanation);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbxAmount);
            this.groupBox1.Controls.Add(this.sfcbxTargetUsers);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1160, 165);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            // 
            // sfcbxTargetBankAccounts
            // 
            this.sfcbxTargetBankAccounts.DisplayMember = "AccountName";
            this.sfcbxTargetBankAccounts.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.sfcbxTargetBankAccounts.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfcbxTargetBankAccounts.Location = new System.Drawing.Point(972, 25);
            this.sfcbxTargetBankAccounts.Name = "sfcbxTargetBankAccounts";
            this.sfcbxTargetBankAccounts.Size = new System.Drawing.Size(181, 35);
            this.sfcbxTargetBankAccounts.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.sfcbxTargetBankAccounts.Style.EditorStyle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfcbxTargetBankAccounts.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfcbxTargetBankAccounts.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sfcbxTargetBankAccounts.Style.TokenStyle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfcbxTargetBankAccounts.TabIndex = 48;
            this.sfcbxTargetBankAccounts.ValueMember = "IBAN";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(540, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "EXPLANATION";
            // 
            // tbxTargetIBAN
            // 
            this.tbxTargetIBAN.BeforeTouchSize = new System.Drawing.Size(150, 35);
            this.tbxTargetIBAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTargetIBAN.Location = new System.Drawing.Point(785, 66);
            this.tbxTargetIBAN.Name = "tbxTargetIBAN";
            this.tbxTargetIBAN.Size = new System.Drawing.Size(368, 35);
            this.tbxTargetIBAN.TabIndex = 31;
            // 
            // tbxSenderIBAN
            // 
            this.tbxSenderIBAN.BeforeTouchSize = new System.Drawing.Size(150, 35);
            this.tbxSenderIBAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSenderIBAN.Location = new System.Drawing.Point(6, 66);
            this.tbxSenderIBAN.Name = "tbxSenderIBAN";
            this.tbxSenderIBAN.Size = new System.Drawing.Size(368, 35);
            this.tbxSenderIBAN.TabIndex = 29;
            // 
            // tbxSenderName
            // 
            this.tbxSenderName.BeforeTouchSize = new System.Drawing.Size(150, 35);
            this.tbxSenderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSenderName.Location = new System.Drawing.Point(6, 25);
            this.tbxSenderName.Name = "tbxSenderName";
            this.tbxSenderName.Size = new System.Drawing.Size(181, 35);
            this.tbxSenderName.TabIndex = 17;
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
            // sfcbxSenderBankAccounts
            // 
            this.sfcbxSenderBankAccounts.DisplayMember = "AccountName";
            this.sfcbxSenderBankAccounts.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.sfcbxSenderBankAccounts.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfcbxSenderBankAccounts.Location = new System.Drawing.Point(193, 25);
            this.sfcbxSenderBankAccounts.Name = "sfcbxSenderBankAccounts";
            this.sfcbxSenderBankAccounts.Size = new System.Drawing.Size(181, 35);
            this.sfcbxSenderBankAccounts.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.sfcbxSenderBankAccounts.Style.EditorStyle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfcbxSenderBankAccounts.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfcbxSenderBankAccounts.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sfcbxSenderBankAccounts.Style.TokenStyle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfcbxSenderBankAccounts.TabIndex = 18;
            this.sfcbxSenderBankAccounts.ValueMember = "IBAN";
            // 
            // tbxExplanation
            // 
            this.tbxExplanation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxExplanation.Location = new System.Drawing.Point(380, 82);
            this.tbxExplanation.Name = "tbxExplanation";
            this.tbxExplanation.Size = new System.Drawing.Size(399, 76);
            this.tbxExplanation.TabIndex = 28;
            this.tbxExplanation.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(229, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "SENDER ACCOUNT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1002, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "TARGET ACCOUNT";
            // 
            // tbxAmount
            // 
            this.tbxAmount.BeforeTouchSize = new System.Drawing.Size(150, 35);
            this.tbxAmount.DecimalValue = new decimal(new int[] {
            100,
            0,
            0,
            131072});
            this.tbxAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAmount.Location = new System.Drawing.Point(504, 25);
            this.tbxAmount.Name = "tbxAmount";
            this.tbxAmount.Size = new System.Drawing.Size(150, 35);
            this.tbxAmount.TabIndex = 19;
            this.tbxAmount.Text = "$1.00";
            // 
            // sfcbxTargetUsers
            // 
            this.sfcbxTargetUsers.DisplayMember = "Name";
            this.sfcbxTargetUsers.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.sfcbxTargetUsers.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfcbxTargetUsers.Location = new System.Drawing.Point(785, 25);
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
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(553, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "AMOUNT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(832, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "TARGET NAME";
            // 
            // gbxHome
            // 
            this.gbxHome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxHome.Controls.Add(this.btnUpdate);
            this.gbxHome.Controls.Add(this.btnDelete);
            this.gbxHome.Location = new System.Drawing.Point(12, 12);
            this.gbxHome.Name = "gbxHome";
            this.gbxHome.Size = new System.Drawing.Size(1161, 77);
            this.gbxHome.TabIndex = 32;
            this.gbxHome.TabStop = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.Location = new System.Drawing.Point(583, 11);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(60, 60);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = " ";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDelete.Location = new System.Drawing.Point(517, 11);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(60, 60);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // TransferPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(109)))), ((int)(((byte)(126)))));
            this.ClientSize = new System.Drawing.Size(1185, 271);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TransferPopUp";
            this.Text = "TransferPopUp";
            this.Load += new System.EventHandler(this.TransferPopUp_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sfcbxTargetBankAccounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxTargetIBAN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxSenderIBAN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxSenderName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfcbxSenderBankAccounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfcbxTargetUsers)).EndInit();
            this.gbxHome.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Syncfusion.WinForms.ListView.SfComboBox sfcbxTargetBankAccounts;
        private System.Windows.Forms.Label label7;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt tbxTargetIBAN;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt tbxSenderIBAN;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt tbxSenderName;
        private System.Windows.Forms.Label label1;
        private Syncfusion.WinForms.ListView.SfComboBox sfcbxSenderBankAccounts;
        private System.Windows.Forms.RichTextBox tbxExplanation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private Syncfusion.Windows.Forms.Tools.CurrencyTextBox tbxAmount;
        private Syncfusion.WinForms.ListView.SfComboBox sfcbxTargetUsers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbxHome;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}