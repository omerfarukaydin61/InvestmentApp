namespace InvestmentApp.Forms
{
    partial class Home
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
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn1 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn2 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridDateTimeColumn gridDateTimeColumn1 = new Syncfusion.WinForms.DataGrid.GridDateTimeColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn3 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn4 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            this.btnUserOperations = new System.Windows.Forms.Button();
            this.btnInvest = new System.Windows.Forms.Button();
            this.sfdgHome = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbxHome = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.sfdgHome)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbxHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUserOperations
            // 
            this.btnUserOperations.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnUserOperations.BackColor = System.Drawing.Color.Transparent;
            this.btnUserOperations.BackgroundImage = global::InvestmentApp.Properties.Resources.users_gear;
            this.btnUserOperations.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUserOperations.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnUserOperations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserOperations.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUserOperations.Location = new System.Drawing.Point(6, 11);
            this.btnUserOperations.Name = "btnUserOperations";
            this.btnUserOperations.Size = new System.Drawing.Size(60, 60);
            this.btnUserOperations.TabIndex = 17;
            this.btnUserOperations.UseVisualStyleBackColor = false;
            this.btnUserOperations.Click += new System.EventHandler(this.btnUserOperations_Click);
            // 
            // btnInvest
            // 
            this.btnInvest.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnInvest.BackColor = System.Drawing.Color.Transparent;
            this.btnInvest.BackgroundImage = global::InvestmentApp.Properties.Resources.dollar;
            this.btnInvest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInvest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvest.ForeColor = System.Drawing.SystemColors.Control;
            this.btnInvest.Location = new System.Drawing.Point(645, 10);
            this.btnInvest.Name = "btnInvest";
            this.btnInvest.Size = new System.Drawing.Size(141, 60);
            this.btnInvest.TabIndex = 15;
            this.btnInvest.UseVisualStyleBackColor = false;
            this.btnInvest.Click += new System.EventHandler(this.btnInvest_Click);
            // 
            // sfdgHome
            // 
            this.sfdgHome.AccessibleName = "Table";
            this.sfdgHome.AllowEditing = false;
            this.sfdgHome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sfdgHome.AutoGenerateColumns = false;
            this.sfdgHome.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            gridTextColumn1.AllowEditing = false;
            gridTextColumn1.CellStyle.HorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            gridTextColumn1.HeaderText = "EffecterID";
            gridTextColumn1.MappingName = "EffecterID";
            gridTextColumn1.Width = 70D;
            gridTextColumn2.AllowEditing = false;
            gridTextColumn2.CellStyle.HorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            gridTextColumn2.HeaderText = "AffectedID";
            gridTextColumn2.MappingName = "AffectedID";
            gridTextColumn2.Width = 70D;
            gridDateTimeColumn1.AllowEditing = false;
            gridDateTimeColumn1.CellStyle.HorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            gridDateTimeColumn1.HeaderText = "Date";
            gridDateTimeColumn1.MappingName = "Date";
            gridDateTimeColumn1.MaxDateTime = new System.DateTime(9999, 12, 31, 23, 59, 59, 999);
            gridDateTimeColumn1.Width = 120D;
            gridTextColumn3.AllowEditing = false;
            gridTextColumn3.CellStyle.HorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            gridTextColumn3.HeaderText = "Action";
            gridTextColumn3.MappingName = "Action";
            gridTextColumn3.Width = 70D;
            gridTextColumn4.AllowEditing = false;
            gridTextColumn4.CellStyle.HorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            gridTextColumn4.HeaderText = "Explanation";
            gridTextColumn4.MappingName = "Explanation";
            this.sfdgHome.Columns.Add(gridTextColumn1);
            this.sfdgHome.Columns.Add(gridTextColumn2);
            this.sfdgHome.Columns.Add(gridDateTimeColumn1);
            this.sfdgHome.Columns.Add(gridTextColumn3);
            this.sfdgHome.Columns.Add(gridTextColumn4);
            this.sfdgHome.HeaderRowHeight = 40;
            this.sfdgHome.Location = new System.Drawing.Point(6, 48);
            this.sfdgHome.Name = "sfdgHome";
            this.sfdgHome.RowHeight = 35;
            this.sfdgHome.Size = new System.Drawing.Size(780, 318);
            this.sfdgHome.TabIndex = 17;
            this.sfdgHome.Text = "sfDataGrid1";
            // 
            // tbxSearch
            // 
            this.tbxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSearch.Location = new System.Drawing.Point(593, 13);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(193, 29);
            this.tbxSearch.TabIndex = 18;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(536, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "SEARCH";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.sfdgHome);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbxSearch);
            this.groupBox1.Location = new System.Drawing.Point(3, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(792, 372);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // gbxHome
            // 
            this.gbxHome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxHome.Controls.Add(this.btnUserOperations);
            this.gbxHome.Controls.Add(this.btnInvest);
            this.gbxHome.Location = new System.Drawing.Point(3, -2);
            this.gbxHome.Name = "gbxHome";
            this.gbxHome.Size = new System.Drawing.Size(792, 77);
            this.gbxHome.TabIndex = 16;
            this.gbxHome.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Home_FormClosed);
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sfdgHome)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbxHome.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnInvest;
        private System.Windows.Forms.Button btnUserOperations;
        private Syncfusion.WinForms.DataGrid.SfDataGrid sfdgHome;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbxHome;
    }
}

