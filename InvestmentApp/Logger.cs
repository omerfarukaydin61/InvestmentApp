using InvestmentApp.Entities;
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
        public static void Log(LogAction action, string message, int? effecterID = null, int? affectedID = null)
        {
            _repository.Log(action, message, effecterID, affectedID);
        }

        public static void TransferLog(int effecterID, int affectedID, CurrencyTypes currency, decimal amount, string explanation, LogAction type)
        {
            _repository.TransferLog(effecterID, affectedID, currency, amount, explanation, type);
        }

        public static void ExeptionLog(Exception message)
        {
            _repository.Log(LogAction.exception, Convert.ToString(message), ConfigModel.RegisteredUser.ID);
        }
    }
}
