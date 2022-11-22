using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InvestmentApp.Entities;
using InvestmentApp.Entities.Enums;
using InvestmentApp.Entities.Classes;


namespace InvestmentApp.Forms
{
    public partial class UpdateUser : Form
    {
        Repository _repository = new Repository();
        public UpdateUser(UserDto user)
        {
            InitializeComponent();
            cbxPermission.DataSource = Enum.GetValues(typeof(Permissions));

            tbxID.Text = user.ID.ToString();
            tbxName.Text = user.Name.ToString();
            tbxSurname.Text = user.Surname.ToString();
            tbxUsername.Text = user.Username.ToString();
            tbxPassword.Text = user.Password.ToString();
            tbxRegisterDate.Text = user.RegisterDate.ToString();
            cbxPermission.SelectedIndex = Convert.ToInt32(user.Permission);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void Update()
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to update this user?", "???", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (!String.IsNullOrWhiteSpace(tbxName.Text) ||
                    !String.IsNullOrWhiteSpace(tbxSurname.Text) ||
                    !String.IsNullOrWhiteSpace(tbxUsername.Text) ||
                    !String.IsNullOrWhiteSpace(tbxPassword.Text))
                {
                    UserDto user = new UserDto
                    {
                        ID = Convert.ToInt32(tbxID.Text),
                        Name = tbxName.Text.ToString(),
                        Surname = tbxSurname.Text.ToString(),
                        Username = tbxUsername.Text.ToString(),
                        Password = tbxPassword.Text.ToString(),
                        RegisterDate = Convert.ToDateTime(tbxRegisterDate.Text),
                        Permission = (Permissions)cbxPermission.SelectedIndex
                    };
                    if (_repository.Update(user))
                    {
                        MessageBox.Show("User's informations updated successfully");
                        string message = $"{ConfigModel.RegisteredUser.Name} updated {user.Name}'s informations.";
                        Logger.Log(LogAction.update, message, ConfigModel.RegisteredUser.ID, user.ID);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Something gone wrong\nPlease try again");
                    }
                }
                else
                {
                    MessageBox.Show("Please fill all the blanks !!!");
                }
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

        private void btnUpdate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Update();
            }
        }

        private void UpdateUser_Load(object sender, EventArgs e)
        {

        }
    }
}
