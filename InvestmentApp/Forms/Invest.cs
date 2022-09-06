using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using InvestmentApp.Business;
using InvestmentApp.Entities;
using InvestmentApp.Entities.Enums;
using InvestmentApp.Entities.Classes;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.WinForms.DataGrid.Enums;
using Syncfusion.WinForms.DataGrid.Events;
using System.Threading.Tasks;

namespace InvestmentApp.Forms
{
    public partial class Invest : BGYForm
    {
        List<BankAccountDto> _bankAccounts;
        BusinessInvest _businessInvest;
        UserDto _userModel;
        BankAccountDto _userBankAccount;
        public Invest()
        {
            InitializeComponent();
            PageType = Pages.Invest;
            ConfigForm.CurrentForm = this;
            _businessInvest = new BusinessInvest();
        }
        private async void Invest_Load(object sender, EventArgs e)
        {
            await LoadUserTable();
            sfcbxInvestUsers.SelectedValue = ConfigModel.RegisteredUser.ID;
            sfdgRateOfExchange.DataSource = _businessInvest.GetCurrencies();
            cbxExType.DataSource = Enum.GetValues(typeof(CurrencyTypes));
            if (ConfigModel.RegisteredUser.Permission != Permissions.Admin)
            {
                sfcbxInvestUsers.Enabled = false;
            }
        }
        private async Task LoadUserTable()
        {
            sfcbxInvestUsers.DataSource = await _businessInvest.GetUserTable();
        } 
        private async void sfcbxInvestUsers_SelectedValueChanged(object sender, EventArgs e)
        {
            if (sfcbxInvestUsers.SelectedIndex == -1)
                return;
            SetSelectedUser();
            await SetBankAccounts();
            await LoadLogs();
            SetSelectedBankAccount();
            SetTotalBalance();
        }
        private void SetSelectedUser()
        {
            try
            {
                _userModel = (UserDto)sfcbxInvestUsers.SelectedItem;
            }
            catch (Exception) { }
        }
        private async Task SetBankAccounts()
        {
            try
            {
                _bankAccounts = await _businessInvest.GetUserBankAccounts(_userModel.ID);
                if (_bankAccounts.Count == 0)
                {
                    cbxUserAccounts.DataSource = null;
                    return;
                }
                cbxUserAccounts.DataSource = _bankAccounts;
                cbxUserAccounts.SelectedIndex = -1;
                cbxUserAccounts.SelectedIndex = 0;
            }
            catch (Exception) { }
        }
        private async Task LoadLogs()
        {
            try
            {
                var userInvestments = await _businessInvest.GetUserInvestmentLog(_userModel.ID);
                if (userInvestments.Count == 0)
                {
                    sfdgInvestmentLogs.DataSource = null;
                    return;
                }
                    
                sfdgInvestmentLogs.DataSource = userInvestments;
            }
            catch (Exception) { }
        }
        private void SetSelectedBankAccount()
        {
            try
            {
                _userBankAccount = (BankAccountDto)cbxUserAccounts.SelectedItem;

                if (_userBankAccount == null)
                {
                    cbxUserAccounts.ResetText();
                    tbxIBAN.Clear();
                    tbxUserBalance.Clear();
                    return;
                }
                tbxIBAN.Text = _userBankAccount?.IBAN;
                tbxUserBalance.Text = _userBankAccount?.Balance.ToString();
                tbxUserBalance.CurrencySymbol = _userBankAccount?.Currency.ToString();
                SetTotalBalance();
            }
            catch (Exception) { }
        }
        private void SetTotalBalance()
        {
            try
            {
                decimal result = _businessInvest.CalculateTotalBalance(_bankAccounts, (CurrencyTypes)cbxExType.SelectedValue);
                tbxTotal.Text = result.ToString("###,###,###,###,###,###.##");
            }
            catch (Exception) { }
        }
        private void cbxUserAccounts_SelectedValueChanged(object sender, EventArgs e)
        {
            SetSelectedBankAccount();
        }
        private void dgwInvestmentLogs_QueryRowStyle(object sender, QueryRowStyleEventArgs e)
        {
            if (e.RowType == RowType.DefaultRow)
            {
                if ((e.RowData as UserInvestmentDto).Action == LogAction.outgo)
                    e.Style.BackColor = ColorTranslator.FromHtml("#EB5656");
                else if ((e.RowData as UserInvestmentDto).Action == LogAction.income)
                    e.Style.BackColor = Color.LightGreen;
                else if ((e.RowData as UserInvestmentDto).Action == LogAction.backTransfer)
                    e.Style.BackColor = ColorTranslator.FromHtml("#DED943");
            }
        }
        private void sfdgRateOfExchange_QueryRowStyle(object sender, QueryRowStyleEventArgs e)
        {
            if (e.RowType == RowType.DefaultRow)
            {
                if (e.RowIndex % 2 == 0)
                    e.Style.BackColor = Color.Lavender;
                else
                    e.Style.BackColor = Color.AliceBlue;
            }
        }
        private void tbxIBAN_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                Clipboard.SetText(tbxIBAN.Text);
            }
            catch (Exception) { }
        }
        private void sfbtnDeposit_Click(object sender, EventArgs e)
        {
            if (ConfigForm.OpenedForms.Any(x => x.Text == "Transfer"))
            {
                ConfigForm.OpenedForms.FirstOrDefault(x => x.Text == "Transfer").BringToFront();
            }
            else
            {
                Transfer tranfer = new Transfer(_userModel, _bankAccounts);
                tranfer.TopLevel = false;
                Investment_App._mother.Controls.Add(tranfer);
                tranfer.BringToFront();
                tranfer.Dock = DockStyle.Fill;
                tranfer.Closed += (s, args) => this.Invest_Load(sender, e);
                tranfer.Show();
            }  
        }
        private void Search(string key)
        {
            sfdgInvestmentLogs.SearchController.AllowFiltering = true;
            sfdgInvestmentLogs.SearchController.Search(key);
        }
        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            Search(tbxSearch.Text);
        }
        private async void Invest_FormClosing(object sender, FormClosingEventArgs e)
        {
            string message = $"{ConfigModel.RegisteredUser.Name} logged out.";
            await Logger.Log(LogAction.logout, message, ConfigModel.RegisteredUser.ID);
        }
        private async void sfbtnWithdraw_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedItem = sfdgInvestmentLogs.SelectedItem as UserInvestmentDto;
                if (selectedItem.Action == LogAction.outgo)
                {
                    var dialogResult = MessageBox.Show($"Are you sure about cancel this transaction\n" +
                                                       $"{selectedItem.Explanation}","CANCELLATION REQUEST" ,MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        selectedItem.Action = LogAction.backTransfer;
                        (bool isBackTransfered, string msg) = await _businessInvest.BackTransfer(selectedItem);
                        if (isBackTransfered)
                        {
                            await SetBankAccounts();
                            MessageBox.Show(msg);
                            return;
                        }
                        else
                        {
                            MessageBox.Show(msg);
                            return;
                        }
                    }
                }
                MessageBox.Show("You can not cancel this transaction.");
                return;
            }
            catch (Exception) { }
        }
        private async void sfdgInvestmentLogs_CellDoubleClick(object sender, CellClickEventArgs e)
        {
            try
            {
                var selectedItem = sfdgInvestmentLogs.SelectedItem as UserInvestmentDto;
                if (selectedItem.Action == LogAction.backTransfer)
                {
                    var dialogResult = MessageBox.Show($"Are you sure about delete this BACKTRANSFERED transaction\n" +
                                                       $"{selectedItem.Action}\n" +
                                                       $"{selectedItem.Explanation}", "DELETE REQUEST", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        this.Enabled = false;
                        PasswordValidation passwordValidation = new PasswordValidation(LogAction.transferDelete);
                        passwordValidation.Closed += (s, args) => this.Invest_Load(sender, e);
                        passwordValidation.ShowDialog();
                        if (ConfigValidation.isValid == true)
                        {
                            selectedItem.Action = LogAction.transferDelete;
                            (bool isBackTransfered, string msg) = await _businessInvest.BackTransfer(selectedItem);
                            if (isBackTransfered)
                            {
                                MessageBox.Show(msg);
                                return;
                            }
                            else
                            {
                                MessageBox.Show(msg);
                                return;
                            }
                        }
                        return;
                    }
                }
            }
            catch (Exception) { }
            finally 
            {
                this.Enabled = true;
                ConfigValidation.isValid = false;
                await LoadLogs();
            }
        }
        private void Invest_FormClosed(object sender, FormClosedEventArgs e)
        {
            ConfigForm.RemoveSpecificForm(this);
        }
    }
}
