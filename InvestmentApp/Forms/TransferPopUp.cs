using InvestmentApp.Business;
using InvestmentApp.Entities.Classes;
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
    public partial class TransferPopUp : Form
    {
        BusinessTransfer _businessTransfer = new BusinessTransfer();
        MoneyTransferDto _moneyTransferDto;
        UserDto _senderUser;
        List<BankAccount> _senderBankAccounts;
        bool _isSetTargetBankAccountsBusy = false;
        public TransferPopUp(MoneyTransferDto moneyTransferDto, UserDto senderUser, List<BankAccount> senderBankAccounts)
        {
            InitializeComponent();
            _moneyTransferDto = moneyTransferDto;
            _senderUser = senderUser;
            _senderBankAccounts = senderBankAccounts;
        }

        private async void TransferPopUp_Load(object sender, EventArgs e)
        {
            tbxSenderName.Text = _senderUser.Name;
            sfcbxSenderBankAccounts.DataSource = _senderBankAccounts;
            sfcbxSenderBankAccounts.SelectedItem = _moneyTransferDto.SenderBankAccount;

            sfcbxTargetUsers.DataSource = await _businessTransfer.GetUserTable();
            sfcbxTargetUsers.SelectedItem = _moneyTransferDto?.TargetUser;

            tbxAmount.CurrencySymbol = _moneyTransferDto.SenderBankAccount.Currency.ToString();
            tbxAmount.DecimalValue = _moneyTransferDto.Amount;

            List<BankAccount> targerBankAccounts = await SetTargetBankAccounts(_moneyTransferDto.TargetUser, _moneyTransferDto.SenderBankAccount.Currency);
            sfcbxTargetBankAccounts.DataSource = targerBankAccounts;
            sfcbxSenderBankAccounts.SelectedItem = _moneyTransferDto.TargetBankAccount;
        }
        private async Task<List<BankAccount>> SetTargetBankAccounts(UserDto targetUser, CurrencyTypes currencyType)
        {
            try
            {
                if (!_isSetTargetBankAccountsBusy)
                {
                    _isSetTargetBankAccountsBusy = true;
                    List<BankAccount> targetBankAccounts = await _businessTransfer.GetUserBankAccounts(targetUser, currencyType);
                    if (targetBankAccounts.Count == 0)
                    {
                        sfcbxTargetBankAccounts.DataSource = null;
                        sfcbxTargetBankAccounts.ResetText();
                        return null;
                    }
                    return targetBankAccounts;
                }
                return null;
            }
            catch (Exception ex) { return null; }
            finally
            {
                _isSetTargetBankAccountsBusy = false;
            }
        }
    }
}
