using InvestmentApp.Entities;
using InvestmentApp.Entities.Classes;
using InvestmentApp.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestmentApp
{
    public static class Logger
    {
        static Repository _repository = new Repository();
        public async static Task Log(LogAction action, string message, int? effecterID = null, int? affectedID = null)
        {
            await _repository.Log(action, message, effecterID, affectedID);
        }
        public async static Task TransferLog(BankAccountDto senderBankAccount, BankAccountDto targetBankAccount, string explanation, CurrencyTypes currency, decimal amount)
        {
            await _repository.TransferLog(senderBankAccount, targetBankAccount, explanation, currency, amount);
        }
        public async static Task ExeptionLog(Exception message)
        {
            await _repository.Log(LogAction.exception, Convert.ToString(message), ConfigModel.RegisteredUser.ID);
        }
    }
}
