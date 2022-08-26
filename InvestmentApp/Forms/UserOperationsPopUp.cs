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
using InvestmentApp.Entities.Classes;
using InvestmentApp.Entities.Enums;
using InvestmentApp.Properties;

namespace InvestmentApp.Forms
{
    public partial class UserOperationsPopUp : Form
    {
        Repository _repository = new Repository();
        OperationTypes _page;
        UserDto _userDto;
        public UserOperationsPopUp(OperationTypes page, UserDto user)
        {
            InitializeComponent();
            _page = page;
            _userDto = user;
        }
        public UserOperationsPopUp(OperationTypes page)
        {
            InitializeComponent();
            _page = page;
        }
        private void UserOperationPopUp_Load(object sender, EventArgs e)
        {
            cbxPermission.DataSource = Enum.GetValues(typeof(Permissions));

            if (_page == OperationTypes.add)
            {
                this.Text = "Add";
                tbxID.Text = "##";
                tbxRegisterDate.Text = "####-##-## &&:&&:&&";
                cbxPermission.SelectedIndex = 3;
                btnOperation.BackgroundImage = Resources.circle_plus_;
            }
            if (_page == OperationTypes.delete)
            {
                this.Text = "Delete";
                tbxID.Text = _userDto.ID.ToString();
                tbxName.Text = _userDto.Name.ToString();
                tbxSurname.Text = _userDto.Surname.ToString();
                tbxUsername.Text = _userDto.Username.ToString();
                tbxPassword.Text = _userDto.Password.ToString();
                tbxRegisterDate.Text = _userDto.RegisterDate.ToString();
                cbxPermission.SelectedIndex = Convert.ToInt32(_userDto.Permission);
                btnOperation.BackgroundImage = Resources.circle_xmark;
            }
            if (_page == OperationTypes.update)
            {
                this.Text = "Update";
                tbxID.Text = _userDto.ID.ToString();
                tbxName.Text = _userDto.Name.ToString();
                tbxSurname.Text = _userDto.Surname.ToString();
                tbxUsername.Text = _userDto.Username.ToString();
                tbxPassword.Text = _userDto.Password.ToString();
                tbxRegisterDate.Text = _userDto.RegisterDate.ToString();
                cbxPermission.SelectedIndex = Convert.ToInt32(_userDto.Permission);
                btnOperation.BackgroundImage = Resources.circle_check;
            }
        }
        private void btnOperation_Click(object sender, EventArgs e)
        {
            if (_page == OperationTypes.add)
            {
                Add();
            }
            if (_page == OperationTypes.delete)
            {
                Delete();
            }
            if (_page == OperationTypes.update)
            {
                Update();
            }
        }
        private void Add()
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
                    (bool isUpdated, string msg) = _repository.Update(user);
                    if (isUpdated)
                    {
                        MessageBox.Show(msg);
                        string message = $"{ConfigModel.RegisteredUser.Name} updated {user.Name}'s informations.";
                        Logger.Log(LogAction.update, message, ConfigModel.RegisteredUser.ID, user.ID);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(msg);
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
        private void tbxID_KeyDown(object sender, KeyEventArgs e)
        {
            EnterAsTAB(e);
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
        private void btnOperation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (_page == OperationTypes.add)
                {
                    Add();
                }
                if (_page == OperationTypes.delete)
                {
                    Delete();
                }
                if (_page == OperationTypes.update)
                {
                    Update();
                }
            }
        }
    }
}
