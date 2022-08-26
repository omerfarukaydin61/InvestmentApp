using InvestmentApp.Business;
using InvestmentApp.Entities.Classes;
using InvestmentApp.Entities.Enums;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace InvestmentApp.Forms
{
    public partial class Transfer : Form
    {
        BusinessTransfer _businessTransfer = new BusinessTransfer();
        UserDto _senderUser;
        List<BankAccount> _senderBankAccounts;
        List<UserDto> _targetUsers;
        List<MoneyTransferDto> _moneyTransferList = new List<MoneyTransferDto>();
        bool _isBusy = false;
        public Transfer(UserDto senderUser, List<BankAccount> senderBankAccounts)

        {
            InitializeComponent();
            _senderUser = senderUser;
            _senderBankAccounts = senderBankAccounts.ToList();
        }
        private async void Transfer_Load(object sender, EventArgs e)
        {
            try
            {
                tbxSenderName.Text = _senderUser.Name;
                bankAccountBindingSourceSender.DataSource = _senderBankAccounts;
                if (_senderBankAccounts.Count == 0)
                    return;
                sfcbxSenderBankAccounts.DataSource = bankAccountBindingSourceSender;
                sfcbxSenderBankAccounts.SelectedIndex = 0;
                sfdgSenderBankAccounts.DataSource = bankAccountBindingSourceSender;
                sfdgSenderBankAccounts.Columns[0].Visible = false;
                _targetUsers = await _businessTransfer.GetUserTable();
                bankAccountBindingSourceTarget.DataSource = _targetUsers;
                sfcbxTargetUsers.DataSource = bankAccountBindingSourceTarget;
                sfcbxTargetUsers.SelectedIndex = 0;
            }
            catch (Exception ex) { }
        }
        private async void sfcbxSenderBankAccounts_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                tbxTargetIBAN.Clear();
                if (sfcbxSenderBankAccounts.SelectedIndex == -1)
                    return;
                BankAccount senderBankAccount = (BankAccount)sfcbxSenderBankAccounts.SelectedItem;
                UserDto targetUser = (UserDto)sfcbxTargetUsers.SelectedItem;
                tbxSenderIBAN.Text = senderBankAccount.IBAN;

                if (targetUser != null && senderBankAccount != null)
                {
                    await SetTargetBankAccounts(targetUser, senderBankAccount.Currency);
                }
            }
            catch (Exception ex) { }
        }
        private async Task SetTargetBankAccounts(UserDto targetUser, CurrencyTypes currencyType)
        {
            try
            {
                if (!_isBusy)
                {
                    _isBusy = true;
                    List<BankAccount> targetBankAccounts = await _businessTransfer.GetUserBankAccounts(targetUser, currencyType);
                    if (targetBankAccounts.Count == 0)
                    {
                        sfcbxTargetBankAccounts.DataSource = null;
                        sfcbxTargetBankAccounts.ResetText();
                        return;
                    }
                    sfcbxTargetBankAccounts.DataSource = targetBankAccounts;

                    sfcbxTargetBankAccounts.SelectedIndex = -1;
                    if (targetBankAccounts.Count < 1)
                        return;
                    sfcbxTargetBankAccounts.SelectedIndex = 0;
                }
                return;
            }
            catch (Exception ex) { }
            finally { _isBusy = false; }
        }
        private async void sfcbxTargetUsers_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                tbxTargetIBAN.Clear();
                BankAccount senderBankAccount = (BankAccount)sfcbxSenderBankAccounts.SelectedItem;
                UserDto targetUser = (UserDto)sfcbxTargetUsers.SelectedItem;

                if (targetUser != null && senderBankAccount != null)
                {
                    await SetTargetBankAccounts(targetUser, senderBankAccount.Currency);
                }
            }
            catch (Exception ex) { }
        }
        private void sfcbxTargetBankAccounts_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                tbxTargetIBAN.Clear();
                BankAccount targetBankAccount = (BankAccount)sfcbxTargetBankAccounts.SelectedItem;
                tbxTargetIBAN.Text = targetBankAccount?.IBAN;
            }
            catch (Exception ex) { }
            
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            BankAccount senderBankAccount = (BankAccount)sfcbxSenderBankAccounts.SelectedItem;
            MoneyTransferDto moneyTransferDto = new MoneyTransferDto
            {
                SenderUser = _senderUser,
                SenderBankAccount = senderBankAccount,
                CurrencyType = senderBankAccount.Currency,
                Amount = tbxAmount.DecimalValue,
                Explanation = tbxExplanation.Text,
                TargetBankAccount = (BankAccount)sfcbxTargetBankAccounts.SelectedItem,
                TargetUser = (UserDto)sfcbxTargetUsers.SelectedItem
            };
            _moneyTransferList.Add(moneyTransferDto);
            moneyTransferDtoBindingSource.DataSource = _moneyTransferList;
            MTOLoad();
        }
        private void MTOLoad()
        {
            sfdgMoneyTransferOperations.DataSource = null;
            sfdgMoneyTransferOperations.DataSource = moneyTransferDtoBindingSource;
        }
        private void sfdgSenderBankAccounts_AutoGeneratingColumn(object sender, Syncfusion.WinForms.DataGrid.Events.AutoGeneratingColumnArgs e)
        {
            e.Column.CellStyle.VerticalAlignment = VerticalAlignment.Center;
            e.Column.CellStyle.HorizontalAlignment = HorizontalAlignment.Center;
        }
        private void sfdgSenderBankAccounts_QueryRowStyle(object sender, Syncfusion.WinForms.DataGrid.Events.QueryRowStyleEventArgs e)
        {
            if (e.RowType == RowType.DefaultRow)
            {
                if ((e.RowData as BankAccount).Currency == CurrencyTypes.USD)
                    e.Style.BackColor = ColorTranslator.FromHtml("#96F85B");
                else if ((e.RowData as BankAccount).Currency == CurrencyTypes.EUR)
                    e.Style.BackColor = ColorTranslator.FromHtml("#F0F54E");
                else if ((e.RowData as BankAccount).Currency == CurrencyTypes.TL)
                    e.Style.BackColor = ColorTranslator.FromHtml("#4FEBF8");
            }
        }

        private void sfdgMoneyTransferOperations_CellClick(object sender, Syncfusion.WinForms.DataGrid.Events.CellClickEventArgs e)
        {
            MoneyTransferDto moneyTransferDto = new MoneyTransferDto();
            moneyTransferDto = sfdgMoneyTransferOperations.SelectedItem as MoneyTransferDto;
            tbxSenderName.Text = moneyTransferDto.SenderUser.Name;
            sfcbxTargetUsers.SelectedItem = moneyTransferDto.TargetUser;
            sfcbxSenderBankAccounts.SelectedItem = moneyTransferDto.SenderBankAccount;
            sfcbxTargetBankAccounts.SelectedItem = moneyTransferDto.TargetBankAccount;
        }

        private void sfdgMoneyTransferOperations_SelectionChanged(object sender, Syncfusion.WinForms.DataGrid.Events.SelectionChangedEventArgs e)
        {
            try
            {
                MoneyTransferDto moneyTransferDto = new MoneyTransferDto();
                moneyTransferDto = sfdgMoneyTransferOperations.SelectedItem as MoneyTransferDto;
                tbxSenderName.Text = moneyTransferDto?.SenderUser.Name;
                sfcbxTargetUsers.SelectedItem = moneyTransferDto?.TargetUser;
                sfcbxSenderBankAccounts.SelectedItem = moneyTransferDto?.SenderBankAccount;

                tbxAmount.CurrencySymbol = moneyTransferDto.SenderBankAccount.Currency.ToString();
                tbxAmount.DecimalValue = moneyTransferDto.Amount;

                sfcbxTargetBankAccounts.SelectedItem = moneyTransferDto?.TargetBankAccount;
            }
            catch (Exception) { }
        }
    }
}