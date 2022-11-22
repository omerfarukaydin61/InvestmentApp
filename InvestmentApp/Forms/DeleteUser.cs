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
    public partial class DeleteUser : Form
    {
        Repository _repository = new Repository();
        UserDto _userDto;
        public DeleteUser(UserDto user)
        {
            InitializeComponent();
            _userDto = user;
            cbxPermission.DataSource = Enum.GetValues(typeof(Permissions));

            tbxID.Text = user.ID.ToString();
            tbxName.Text = user.Name.ToString();
            tbxSurname.Text = user.Surname.ToString();
            tbxUsername.Text = user.Username.ToString();
            tbxPassword.Text = user.Password.ToString();
            tbxRegisterDate.Text = user.RegisterDate.ToString();
            cbxPermission.SelectedIndex = Convert.ToInt32(user.Permission);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void Delete()
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this user?", "???", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                (bool isDeleted, string msg) = _repository.Delete(_userDto);
                if (isDeleted)
                {
                    string message = $"{ConfigModel.RegisteredUser.Name} deleted user {tbxName.Text}.";
                    Logger.Log(LogAction.remove, message, ConfigModel.RegisteredUser.ID, Convert.ToInt32(tbxID.Text));
                    MessageBox.Show(msg);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(msg);
                    this.Close();
                }
            }
        }
    }
}
