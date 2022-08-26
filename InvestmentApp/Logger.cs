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
        public static void TransferLog(LogAction action, string explanation, int effecterID, int affectedID, CurrencyTypes currency, decimal amount)
        {
            _repository.TransferLog(action, explanation, effecterID, affectedID, currency, amount);
        }
        public static void ExeptionLog(Exception message)
        {
            _repository.Log(LogAction.exception, Convert.ToString(message), ConfigModel.RegisteredUser.ID);
        }
    }
}
