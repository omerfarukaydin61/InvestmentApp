using InvestmentApp.Entities.Enums;
using InvestmentApp.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvestmentApp.Forms
{
    public partial class PasswordValidation : Form
    {
        private static int _transferDeletePassword = 6161;
        LogAction _action;
        public PasswordValidation(LogAction action)
        {
            InitializeComponent();
            _action = action;
        }
        private void PasswordValidation_Load(object sender, EventArgs e)
        {
            if (_action == LogAction.transferDelete)
            {
                this.Text = "Transfer Delete Process";
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ConfigValidation.isValid = false;
            this.Close();
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (tbxPassword.Text == _transferDeletePassword.ToString())
            {
                ConfigValidation.isValid = true;
                this.Close();
            }
            return;
        }
        private void tbxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!String.IsNullOrWhiteSpace(tbxPassword.Text))
                {
                    SendKeys.Send("{TAB}");
                }
                return;
            }
        }
    }
}
