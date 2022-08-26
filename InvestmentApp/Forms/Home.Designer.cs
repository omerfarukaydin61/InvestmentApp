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
            this.gbxHome = new System.Windows.Forms.GroupBox();
            this.btnUserOperations = new System.Windows.Forms.Button();
            this.btnInvest = new System.Windows.Forms.Button();
            this.sfdgHome = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sfdgHome)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxHome
            // 
            this.gbxHome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxHome.Controls.Add(this.btnUserOperations);
            this.gbxHome.Controls.Add(this.btnInvest);
            this.gbxHome.Location = new System.Drawing.Point(12, 2);
            this.gbxHome.Name = "gbxHome";
            this.gbxHome.Size = new System.Drawing.Size(776, 77);
            this.gbxHome.TabIndex = 16;
            this.gbxHome.TabStop = false;
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
            this.btnInvest.Location = new System.Drawing.Point(624, 10);
            this.btnInvest.Name = "btnInvest";
            this.btnInvest.Size = new System.Drawing.Size(141, 60);
            this.btnInvest.TabIndex = 15;
            this.btnInvest.UseVisualStyleBackColor = false;
            this.btnInvest.Click += new System.EventHandler(this.btnInvest_Click);
            // 
            // sfdgHome
            // 
            this.sfdgHome.AccessibleName = "Table";
            this.sfdgHome.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            this.sfdgHome.Location = new System.Drawing.Point(12, 122);
            this.sfdgHome.Name = "sfdgHome";
            this.sfdgHome.Size = new System.Drawing.Size(776, 316);
            this.sfdgHome.TabIndex = 17;
            this.sfdgHome.Text = "sfDataGrid1";
            this.sfdgHome.AutoGeneratingColumn += new Syncfusion.WinForms.DataGrid.Events.AutoGeneratingColumnEventHandler(this.sfdgHome_AutoGeneratingColumn);
            // 
            // tbxSearch
            // 
            this.tbxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSearch.Location = new System.Drawing.Point(595, 85);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(193, 29);
            this.tbxSearch.TabIndex = 18;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(538, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "SEARCH";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.sfdgHome);
            this.Controls.Add(this.gbxHome);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
            this.Load += new System.EventHandler(this.Home_Load);
            this.gbxHome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sfdgHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnInvest;
        private System.Windows.Forms.GroupBox gbxHome;
        private System.Windows.Forms.Button btnUserOperations;
        private Syncfusion.WinForms.DataGrid.SfDataGrid sfdgHome;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Label label1;
    }
}

