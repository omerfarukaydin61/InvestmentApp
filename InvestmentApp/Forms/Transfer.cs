using InvestmentApp.Business;
using InvestmentApp.Entities;
using InvestmentApp.Entities.Classes;
using InvestmentApp.Entities.Enums;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Enums;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        BankAccountDto _senderSelectedBankAccount;
        UserDto _targetSelectedUser;
        BankAccountDto _targetSelectedBankAccount;
        BusinessTransfer _businessTransfer;
        UserDto _senderUser;
        List<BankAccountDto> _senderBankAccounts;
        ObservableCollection<MoneyTransferDto> _moneyTransferOperationList;
        bool _isSenderBankAccounts_SVC = false;
        bool _isTargetUser_SVCBusy = false;
        bool _isTargetBankAccounts_SVCBusy = false;
        bool _Mto_SC = false;

        public Transfer(UserDto senderUser, List<BankAccountDto> senderBankAccounts)
        {
            InitializeComponent();
            ConfigForm.CurrentForm = this;
            this.Tag = ConfigForm.MaxIdOfOpenedForm() + 1;
            _senderUser = senderUser;
            _senderBankAccounts = senderBankAccounts.ToList();
            _businessTransfer = new BusinessTransfer();
            _moneyTransferOperationList = new ObservableCollection<MoneyTransferDto>();
            sfdgMoneyTransferOperations.DataSource = _moneyTransferOperationList;
        }
        private async void Transfer_Load(object sender, EventArgs e)
        {
            try
            {
                tbxSenderName.Text = _senderUser.Name;
                sfcbxSenderBankAccounts.DataSource = _senderBankAccounts;
                sfdgSenderBankAccounts.DataSource = _senderBankAccounts;
                sfdgSenderBankAccounts.Columns[0].Visible = false;
                sfcbxSenderBankAccounts.SelectedIndex = -1;
                if (sfcbxSenderBankAccounts.DataSource == null)
                    return;
                sfcbxSenderBankAccounts.SelectedIndex = 0;

                sfcbxTargetUsers.DataSource = await _businessTransfer.GetUserTable();
                sfcbxTargetUsers.SelectedIndex = -1;
                if (sfcbxTargetUsers.DataSource == null)
                    return;
                sfcbxTargetUsers.SelectedIndex = 27;
            }
            catch (Exception ex) { }
        }
        private void sfdgMto_Load()
        {
            sfdgMoneyTransferOperations.DataSource = null;
            sfdgMoneyTransferOperations.DataSource = _moneyTransferOperationList;
        }
        private void sfcbxSenderBankAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (!_isSenderBankAccounts_SVC)
                {
                    _isSenderBankAccounts_SVC = true;

                    tbxSenderIBAN.Clear();

                    _senderSelectedBankAccount = sfcbxSenderBankAccounts.SelectedItem as BankAccountDto;
                    if (_senderSelectedBankAccount != null)
                    {
                        tbxSenderIBAN.Text = _senderSelectedBankAccount.IBAN;
                        tbxAmount.CurrencySymbol = _senderSelectedBankAccount.Currency.ToString();
                    }
                    _isSenderBankAccounts_SVC = false;
                    if (!_Mto_SC)
                    {
                        sfcbxTargetUsers_SelectedIndexChanged(sender, e);
                    }
                }
                return;
            }
            catch (Exception) { }
            finally { _isSenderBankAccounts_SVC = false; }
        }
        private async void sfcbxTargetUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (!_Mto_SC)
                {
                    if (!_isTargetUser_SVCBusy)
                    {
                        _isTargetUser_SVCBusy = true;

                        sfcbxTargetBankAccounts.ResetText();
                        tbxTargetIBAN.Clear();

                        _targetSelectedUser = sfcbxTargetUsers.SelectedItem as UserDto;
                        _senderSelectedBankAccount = sfcbxSenderBankAccounts.SelectedItem as BankAccountDto;
                        if (_targetSelectedUser != null && _senderSelectedBankAccount != null)
                        {
                            var _targetBankAccounts = await _businessTransfer.GetUserBankAccounts(_targetSelectedUser, _senderSelectedBankAccount.Currency);
                            sfcbxTargetBankAccounts.DataSource = null;
                            sfcbxTargetBankAccounts.DataSource = _targetBankAccounts;

                            sfcbxTargetBankAccounts.SelectedIndex = -1;
                            if (_targetBankAccounts.Count == 0)
                            {
                                _isTargetUser_SVCBusy = false;
                                return;
                            }
                            sfcbxTargetBankAccounts.SelectedIndex = 0;
                        }
                        _isTargetUser_SVCBusy = false;
                        return;
                    }
                    return;
                }
                return;
            }
            catch (Exception) { }
            finally { _isTargetUser_SVCBusy = false; }

        }
        private void sfcbxTargetBankAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (!_Mto_SC)
                {
                    if (!_isTargetBankAccounts_SVCBusy)
                    {
                        _isTargetBankAccounts_SVCBusy = true;

                        tbxTargetIBAN.Clear();

                        _targetSelectedBankAccount = sfcbxTargetBankAccounts.SelectedItem as BankAccountDto;
                        if (_targetSelectedBankAccount != null)
                            tbxTargetIBAN.Text = _targetSelectedBankAccount.IBAN;
                        _isTargetBankAccounts_SVCBusy = false;
                    }
                    return;
                }
            }
            catch (Exception) { }
            finally { _isTargetBankAccounts_SVCBusy = false; }
        }
        private async void sfdgMoneyTransferOperations_SelectionChanged(object sender, Syncfusion.WinForms.DataGrid.Events.SelectionChangedEventArgs e)
        {
            try
            {
                if (!_Mto_SC)
                {
                    _Mto_SC = true;
                    var selectedItem = sfdgMoneyTransferOperations.SelectedItem as MoneyTransferDto;
                    if (selectedItem == null)
                        return;
                    if ((sfcbxSenderBankAccounts.SelectedItem as BankAccountDto)?.ID != selectedItem.SenderBankAccount.ID)
                    {   
                        sfcbxSenderBankAccounts.SelectedItem = selectedItem.SenderBankAccount;
                    }   

                    await isWait();

                    if ((sfcbxTargetUsers.SelectedItem as UserDto)?.ID != selectedItem.TargetUser.ID)
                    {
                        sfcbxTargetUsers.SelectedItem = selectedItem.TargetUser;
                    }
                    if (selectedItem.TargetUser != null)
                    {
                        var _targetBankAccounts = await _businessTransfer.GetUserBankAccounts(selectedItem.TargetUser, selectedItem.SenderBankAccount.Currency);
                        sfcbxTargetBankAccounts.DataSource = null;
                        sfcbxTargetBankAccounts.DataSource = _targetBankAccounts;
                    }

                    await isWait();

                    if ((sfcbxTargetBankAccounts.SelectedItem as BankAccountDto)?.ID != selectedItem.TargetBankAccount.ID)
                    {
                        sfcbxTargetBankAccounts.SelectedItem = selectedItem.TargetBankAccount;
                    }

                    _targetSelectedBankAccount = sfcbxTargetBankAccounts.SelectedItem as BankAccountDto;
                    if (_targetSelectedBankAccount != null)
                        tbxTargetIBAN.Text = _targetSelectedBankAccount.IBAN;

                    tbxAmount.DecimalValue = selectedItem.Amount;
                    tbxExplanation.Text = selectedItem.Explanation;
                    _Mto_SC = false;
                }
                return;
            }
            catch (Exception) { }
            finally { _Mto_SC = false; }
        }
        private async Task isWait()
        {
            while (_isTargetBankAccounts_SVCBusy || _isTargetUser_SVCBusy || _isSenderBankAccounts_SVC)
            {
                await Task.Delay(100);
            }
        }
        private void sfdgSenderBankAccounts_QueryRowStyle(object sender, Syncfusion.WinForms.DataGrid.Events.QueryRowStyleEventArgs e)
        {
            if (e.RowType == RowType.DefaultRow)
            {
                if ((e.RowData as BankAccountDto).Currency == CurrencyTypes.USD)
                    e.Style.BackColor = ColorTranslator.FromHtml("#96F85B");
                else if ((e.RowData as BankAccountDto).Currency == CurrencyTypes.EUR)
                    e.Style.BackColor = ColorTranslator.FromHtml("#F0F54E");
                else if ((e.RowData as BankAccountDto).Currency == CurrencyTypes.TL)
                    e.Style.BackColor = ColorTranslator.FromHtml("#4FEBF8");
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string msg = "";
            var moneyTransferTransaction = new MoneyTransferDto();
            moneyTransferTransaction.SenderUser = _senderUser;
            moneyTransferTransaction.SenderBankAccount = sfcbxSenderBankAccounts.SelectedItem as BankAccountDto;
            moneyTransferTransaction.CurrencyType = _senderSelectedBankAccount.Currency;
            moneyTransferTransaction.Amount = tbxAmount.DecimalValue;
            moneyTransferTransaction.Explanation = tbxExplanation.Text;
            moneyTransferTransaction.TargetUser = sfcbxTargetUsers.SelectedItem as UserDto;
            moneyTransferTransaction.TargetBankAccount = sfcbxTargetBankAccounts.SelectedItem as BankAccountDto;

            if (moneyTransferTransaction.SenderBankAccount == null)
            {
                msg += $"Sender Bank Account property can not be null\n";
            }
            if (moneyTransferTransaction.TargetUser == null)
            {
                msg += $"Target user property can not be null\n";
            }
            if (moneyTransferTransaction.TargetBankAccount == null)
            {
                msg += $"Target Bank Accont property can not be null\n";
            }
            if (moneyTransferTransaction.Amount == 0)
            {
                msg += $"Amount can not be 0\n";
            }
            if (msg != "")
            {
                MessageBox.Show(msg);
                return;
            }
            _moneyTransferOperationList.Add(moneyTransferTransaction);
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var willBeDeleteItem = sfdgMoneyTransferOperations.SelectedItem as MoneyTransferDto;

            if (willBeDeleteItem == null)
                return;

            var dialogResult = MessageBox.Show($"Do you want to delete this transaction:\n" +
                $"{willBeDeleteItem.CurrencyType} {willBeDeleteItem.Amount}\n" +
                $"will be transfered from\n" +
                $"{willBeDeleteItem.SenderUser.Name}\n" +
                $"to\n" +
                $"{willBeDeleteItem.TargetUser.Name}.", 
                "DELETE OPERATION", MessageBoxButtons.YesNoCancel);

            if (dialogResult != DialogResult.Yes)
                return;

            _moneyTransferOperationList.Remove(willBeDeleteItem);
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            sfdgMto_Load();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var selectedItem = sfdgMoneyTransferOperations.SelectedItem as MoneyTransferDto;
            selectedItem.SenderUser = _senderUser;
            selectedItem.SenderBankAccount = sfcbxSenderBankAccounts.SelectedItem as BankAccountDto;
            selectedItem.CurrencyType = _senderSelectedBankAccount.Currency;
            selectedItem.Amount = tbxAmount.DecimalValue;
            selectedItem.Explanation = tbxExplanation.Text;
            selectedItem.TargetUser = sfcbxTargetUsers.SelectedItem as UserDto;
            selectedItem.TargetBankAccount = sfcbxTargetBankAccounts.SelectedItem as BankAccountDto;

            sfdgMto_Load();
        }        
        private void sfdgMoneyTransferOperations_QueryRowStyle(object sender, Syncfusion.WinForms.DataGrid.Events.QueryRowStyleEventArgs e)
        {
            if (e.RowType == RowType.DefaultRow)
            {
                if ((e.RowData as MoneyTransferDto).Status == 1)
                    e.Style.BackColor = ColorTranslator.FromHtml("#27AE60");
                else if ((e.RowData as MoneyTransferDto).Status == 0)
                    e.Style.BackColor = ColorTranslator.FromHtml("#E74C3C");
            }
        }
        private void sfdgSenderBankAccounts_AutoGeneratingColumn(object sender, Syncfusion.WinForms.DataGrid.Events.AutoGeneratingColumnArgs e)
        {
            e.Column.CellStyle.VerticalAlignment = VerticalAlignment.Center;
            e.Column.CellStyle.HorizontalAlignment = HorizontalAlignment.Center;
        }
        private void Search(string key)
        {
            sfdgMoneyTransferOperations.SearchController.AllowFiltering = true;
            sfdgMoneyTransferOperations.SearchController.Search(key);
        }
        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            Search(tbxSearch.Text);
        }
        private async void sfbtnPush_Click(object sender, EventArgs e)
        {
            foreach (var mtoDto in _moneyTransferOperationList)
            {
                if (mtoDto.Status != 1)
                {
                    (bool isTransfered, string msg) = await _businessTransfer.Transfer(mtoDto.SenderBankAccount, mtoDto.TargetBankAccount, mtoDto.Explanation, mtoDto.Amount);
                    if (isTransfered)
                    {
                        mtoDto.Status = 1;
                    }
                    else
                    {
                        mtoDto.Status = 0;
                        var dialogResult = MessageBox.Show($"{msg}" +
                                        $"\nfor\n" +
                                        $"{mtoDto.CurrencyType} {mtoDto.Amount}\n" +
                                        $"will be transfered from\n" +
                                        $"{mtoDto.SenderUser.Name}\n" +
                                        $"to\n" +
                                        $"{mtoDto.TargetUser.Name}.",
                                        "DELETE OPERATION", MessageBoxButtons.OKCancel);

                        if (dialogResult == DialogResult.Cancel)
                            return;
                    }
                    sfdgMto_Load();
                }
            }
        }
        private void Transfer_FormClosed(object sender, FormClosedEventArgs e)
        {
            ConfigForm.RemoveSpecificForm(this);
        }
    }
}