namespace InvestmentApp.Forms
{
    partial class UserOperations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserOperations));
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn1 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn2 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn3 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn4 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn5 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            this.gbxHome = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.sfdgUserOperations = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gbxHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sfdgUserOperations)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxHome
            // 
            this.gbxHome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxHome.Controls.Add(this.label1);
            this.gbxHome.Controls.Add(this.btnUpdate);
            this.gbxHome.Controls.Add(this.tbxSearch);
            this.gbxHome.Controls.Add(this.btnRefresh);
            this.gbxHome.Controls.Add(this.btnAdd);
            this.gbxHome.Controls.Add(this.btnDelete);
            this.gbxHome.Location = new System.Drawing.Point(2, -1);
            this.gbxHome.Name = "gbxHome";
            this.gbxHome.Size = new System.Drawing.Size(796, 77);
            this.gbxHome.TabIndex = 18;
            this.gbxHome.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(549, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "SEARCH";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.Location = new System.Drawing.Point(138, 10);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(60, 60);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbxSearch
            // 
            this.tbxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSearch.Location = new System.Drawing.Point(606, 41);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(184, 29);
            this.tbxSearch.TabIndex = 42;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.BackgroundImage")));
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRefresh.Location = new System.Drawing.Point(204, 10);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(60, 60);
            this.btnRefresh.TabIndex = 16;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAdd.Location = new System.Drawing.Point(6, 10);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(60, 60);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDelete.Location = new System.Drawing.Point(72, 10);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(60, 60);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // sfdgUserOperations
            // 
            this.sfdgUserOperations.AccessibleName = "Table";
            this.sfdgUserOperations.AllowEditing = false;
            this.sfdgUserOperations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sfdgUserOperations.AutoGenerateColumns = false;
            this.sfdgUserOperations.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            gridTextColumn1.AllowEditing = false;
            gridTextColumn1.CellStyle.HorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            gridTextColumn1.HeaderText = "ID";
            gridTextColumn1.MappingName = "ID";
            gridTextColumn2.AllowEditing = false;
            gridTextColumn2.CellStyle.HorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            gridTextColumn2.HeaderText = "Name";
            gridTextColumn2.MappingName = "Name";
            gridTextColumn3.AllowEditing = false;
            gridTextColumn3.CellStyle.HorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            gridTextColumn3.HeaderText = "Surname";
            gridTextColumn3.MappingName = "Surname";
            gridTextColumn4.AllowEditing = false;
            gridTextColumn4.CellStyle.HorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            gridTextColumn4.HeaderText = "Username";
            gridTextColumn4.MappingName = "Username";
            gridTextColumn5.AllowEditing = false;
            gridTextColumn5.CellStyle.HorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            gridTextColumn5.HeaderText = "Permission";
            gridTextColumn5.MappingName = "Permission";
            this.sfdgUserOperations.Columns.Add(gridTextColumn1);
            this.sfdgUserOperations.Columns.Add(gridTextColumn2);
            this.sfdgUserOperations.Columns.Add(gridTextColumn3);
            this.sfdgUserOperations.Columns.Add(gridTextColumn4);
            this.sfdgUserOperations.Columns.Add(gridTextColumn5);
            this.sfdgUserOperations.Location = new System.Drawing.Point(0, 11);
            this.sfdgUserOperations.Name = "sfdgUserOperations";
            this.sfdgUserOperations.Size = new System.Drawing.Size(796, 363);
            this.sfdgUserOperations.TabIndex = 19;
            this.sfdgUserOperations.Text = "sfDataGrid1";
            this.sfdgUserOperations.AutoGeneratingColumn += new Syncfusion.WinForms.DataGrid.Events.AutoGeneratingColumnEventHandler(this.sfdgUserOperations_AutoGeneratingColumn);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.sfdgUserOperations);
            this.groupBox2.Location = new System.Drawing.Point(2, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(796, 374);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            // 
            // UserOperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(203)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbxHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserOperations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserOperations";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserOperations_FormClosed);
            this.Load += new System.EventHandler(this.UserOperations_Load);
            this.gbxHome.ResumeLayout(false);
            this.gbxHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sfdgUserOperations)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxHome;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private Syncfusion.WinForms.DataGrid.SfDataGrid sfdgUserOperations;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}