using InvestmentApp.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestmentApp.Entities
{
    public class UserBankAccountModel
    {
        public int ID { get; set; }
        public string AccountName { get; set; }
        public string IBAN { get; set; }
        public CurrencyTypes CurrencyType { get; set; }
        public decimal Balance { get; set; }
    }
}
