using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InvestmentApp.Entities.Enums;

namespace InvestmentApp.Entities
{
    public class HomePageLogModel
    {
        public int? Effecter { get; set; }
        public int?  Affected { get; set; }
        public DateTime LogDate { get; set; }
        public LogAction LogActionType { get; set; }
        public string LogMessage { get; set; }
    }
}
