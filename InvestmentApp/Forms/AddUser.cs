using InvestmentApp.Entities;
using InvestmentApp.Entities.Enums;
using InvestmentApp.Entities.Classes;
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
    public partial class AddUser : Form
    {
        Repository _repository = new Repository();
        public AddUser()
        {
            InitializeComponent();
            tbxID.Text = "##";
            tbxRegisterDate.Text = "####-##-## &&:&&:&&";
            cbxPermission.DataSource = Enum.GetValues(typeof(Permissions));
            cbxPermission.SelectedIndex = 3;
        }

        private void AddCheck()
        {
            if (!String.IsNullOrWhiteSpace(tbxName.Text) ||
                !String.IsNullOrWhiteSpace(tbxSurname.Text) ||
                !String.IsNullOrWhiteSpace(tbxUsername.Text) ||
                !String.IsNullOrWhiteSpace(tbxPassword.Text))
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to add this user?", "???", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    UserDto user = new UserDto();
                    {
                        user.Name = tbxName.Text;
                        user.Surname = tbxSurname.Text;
                        user.Username = tbxUsername.Text;
                        user.Password = tbxPassword.Text;
                        user.RegisterDate = DateTime.Now;
                        user.Permission = (Permissions)cbxPermission.SelectedIndex;
                    }
                    (bool isAdded, string msg) = _repository.Add(user);

                    if (isAdded == true)
                    {
                        MessageBox.Show(msg);
                        string message = $"{ConfigModel.RegisteredUser.Name} added new user {user.Name}.";
                        Logger.Log(LogAction.add, message, ConfigModel.RegisteredUser.ID, user.ID);
                        this.Close();
                        tbxName.Clear();
                        tbxSurname.Clear();
                        tbxUsername.Clear();
                        tbxPassword.Clear();
                    }
                    else
                    {
                        MessageBox.Show(msg);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please fill all the blanks !!!");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddCheck();
        }

        private void btnAdd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddCheck();
            }
        }
        private void EnterAsTAB(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void tbxName_KeyDown(object sender, KeyEventArgs e)
        {
            EnterAsTAB(e);
        }

        private void tbxSurname_KeyDown(object sender, KeyEventArgs e)
        {
            EnterAsTAB(e);
        }

        private void tbxUsername_KeyDown(object sender, KeyEventArgs e)
        {
            EnterAsTAB(e);
        }

        private void tbxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            EnterAsTAB(e);
        }

        private void cbxPermission_KeyDown(object sender, KeyEventArgs e)
        {
            EnterAsTAB(e);
        }

        private void AddUser_Load(object sender, EventArgs e)
        {

        }
    }
}
