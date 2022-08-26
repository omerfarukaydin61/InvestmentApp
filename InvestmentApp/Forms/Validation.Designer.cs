namespace InvestmentApp.Forms
{
    partial class Validation
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
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.sfbtnVerify = new Syncfusion.WinForms.Controls.SfButton();
            this.SuspendLayout();
            // 
            // tbxPassword
            // 
            this.tbxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPassword.Location = new System.Drawing.Point(100, 40);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(157, 35);
            this.tbxPassword.TabIndex = 0;
            // 
            // sfbtnVerify
            // 
            this.sfbtnVerify.AccessibleName = "Button";
            this.sfbtnVerify.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.sfbtnVerify.Location = new System.Drawing.Point(128, 81);
            this.sfbtnVerify.Name = "sfbtnVerify";
            this.sfbtnVerify.Size = new System.Drawing.Size(104, 64);
            this.sfbtnVerify.TabIndex = 1;
            this.sfbtnVerify.Text = "VERIFY";
            // 
            // Validation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 174);
            this.Controls.Add(this.sfbtnVerify);
            this.Controls.Add(this.tbxPassword);
            this.Name = "Validation";
            this.Text = "Validation";
            this.Load += new System.EventHandler(this.Validation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxPassword;
        private Syncfusion.WinForms.Controls.SfButton sfbtnVerify;
    }
}