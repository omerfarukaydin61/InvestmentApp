using InvestmentApp.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestmentApp.Entities.Classes
{
    internal class MoneyTransferDto
    {
        public UserDto SenderUser { get; set; }
        public BankAccount SenderBankAccount { get; set; }
        public CurrencyTypes CurrencyType { get; set; }
        public decimal Amount { get; set; }
        public UserDto TargetUser { get; set; }
        public BankAccount TargetBankAccount { get; set; }
        public string Explanation { get; set; }
    }
}
