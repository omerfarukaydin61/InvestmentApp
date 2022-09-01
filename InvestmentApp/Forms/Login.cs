using InvestmentApp.Entities;
using InvestmentApp.Entities.Enums;
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
    public partial class Login : Form
    {
        Repository _repository = new Repository();
        public Login()
        {
            InitializeComponent();
            HorizontallyCenterElement();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserLogin(tbxUsername.Text, tbxPassword.Text);
        }
        private void btnLogin_KeyDown(object sender, KeyEventArgs e)
        {
            PressEnter(e);
        }
        private void tbxUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!String.IsNullOrWhiteSpace(tbxUsername.Text))
                {
                    SendKeys.Send("{TAB}");
                }
                else
                {
                    tbxUsername.Focus();
                    lblUsename.ForeColor = Color.Red;
                    lblUsename.ForeColor = Color.Red;
                }
            }
        }
        private void tbxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!String.IsNullOrWhiteSpace(tbxPassword.Text))
                {
                    UserLogin(tbxUsername.Text, tbxPassword.Text);
                }
                else
                {
                    tbxPassword.Focus();
                    lblPassword.ForeColor = Color.Red;
                    lblPassword.ForeColor = Color.Red;
                }
            }
        }
        private void PressEnter(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                UserLogin(tbxUsername.Text, tbxPassword.Text);
            }
        }
        private async void UserLogin(string Username, string Password)
        {
            if (await _repository.Login(Username, Password))
            {
                string message = ($"{ConfigModel.RegisteredUser.Name} logged in.");
                await Logger.Log(LogAction.login, message, ConfigModel.RegisteredUser.ID);
                this.Hide();
                var home = new Home();
                home.Closed += (s, args) => this.Close();
                home.Show();
            }
            else
            {
                MessageBox.Show("Access denied");
            }
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            ConfigModel.RegisteredUser = new Entities.Classes.UserDto
            {
                ID = 1018,
                Name = "omerfaruk",
                Surname = "aydin",
                Username = "admin",
                Password = "00",
                RegisterDate = DateTime.Now,
                Permission = Permissions.Admin
            };
            UserLogin("admin", "00");
        }

        private void HorizontallyCenterElement()
        {
            tbxUsername.Left = (tbxUsername.Parent.Width - tbxUsername.Width) / 2;
            tbxPassword.Left = (tbxPassword.Parent.Width - tbxUsername.Width) / 2;
            lblPassword.Left = (lblPassword.Parent.Width - lblPassword.Width) / 2;
            lblUsename.Left = (lblUsename.Parent.Width - lblUsename.Width) / 2;
            btnLogin.Left = (btnLogin.Parent.Width - btnLogin.Width) / 2;
        }
    }
}
