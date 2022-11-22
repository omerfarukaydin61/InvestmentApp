using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InvestmentApp.Entities.Enums;

namespace InvestmentApp.Entities
{
    public class UserInvestLogModel
    {
        public int EffecterID { get; set; }
        public int AffectedID { get; set; }
        public CurrencyTypes Currency { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string Explanation { get; set; }
        public LogAction Type { get; set; }
    }
}