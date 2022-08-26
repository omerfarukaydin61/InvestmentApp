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
    public partial class Invest : Form
    {
        List<BankAccount> _bankAccounts;
        BusinessInvest _businessInvest;
        UserDto _userModel;
        BankAccount _userBankAccount;
        public Invest()
        {
            InitializeComponent();
            _businessInvest = new BusinessInvest();
        }
        private async void Invest_Load(object sender, EventArgs e)
        {
            await LoadUserTable();
            sfcbxInvestUsers.SelectedValue = ConfigModel.RegisteredUser.ID;
            sfdgRateOfExchange.DataSource = _businessInvest.GetCurrencies();
            cbxExType.DataSource = Enum.GetValues(typeof(CurrencyTypes));
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
                sfdgInvestmentLogs.Columns[0].Visible = false;
                sfdgInvestmentLogs.Columns[1].Width = 60;
                sfdgInvestmentLogs.Columns[2].Width = 60;
                sfdgInvestmentLogs.Columns[3].Width = 80;
                sfdgInvestmentLogs.Columns[4].Width = 65;
                sfdgInvestmentLogs.Columns[6].Width = 40;
                sfdgInvestmentLogs.Columns[7].Width = 60;
            }
            catch (Exception) { }
        }
        private void SetSelectedBankAccount()
        {
            try
            {
                _userBankAccount = (BankAccount)cbxUserAccounts.SelectedItem;

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
        private void cbxExType_SelectedValueChanged(object sender, EventArgs e)
        {
            SetTotalBalance();
        }
        private void dgwInvestmentLogs_QueryRowStyle(object sender, QueryRowStyleEventArgs e)
        {
            if (e.RowType == RowType.DefaultRow)
            {
                if ((e.RowData as UserInvestment).Action == LogAction.deposit)
                    e.Style.BackColor = Color.LightGreen;
                else if ((e.RowData as UserInvestment).Action == LogAction.withdraw)
                    e.Style.BackColor = ColorTranslator.FromHtml("#EB5656");
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
        private void sfdgInvestmentLogs_AutoGeneratingColumn(object sender, AutoGeneratingColumnArgs e)
        {
            e.Column.CellStyle.VerticalAlignment = VerticalAlignment.Center;
            e.Column.CellStyle.HorizontalAlignment = HorizontalAlignment.Center;
        }
        private void tbxIBAN_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                Clipboard.SetText(tbxIBAN.Text);
            }
            catch (Exception) { }
        }
        private void sfbTransfer_Click(object sender, EventArgs e)
        {
            var tranfer = new Transfer(_userModel, _bankAccounts);
            //tranfer.Closed += (s, args) => this.Invest_Load();
            tranfer.ShowDialog();
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
        private void Invest_FormClosing(object sender, FormClosingEventArgs e)
        {
            //string message = USD"{ConfigModel.RegisteredUser.Name} logged out.";
            //Logger.Log(LogAction.logout, message, ConfigModel.RegisteredUser.ID);
        }
    }
}
