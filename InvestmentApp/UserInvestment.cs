namespace InvestmentApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UserInvestment
    {
        public int ID { get; set; }

        public int EffecterID { get; set; }

        public int AffectedID { get; set; }

        public int Currency { get; set; }

        public decimal Amount { get; set; }

        public DateTime Date { get; set; }

        [Required]
        public string Explanation { get; set; }

        public int Type { get; set; }
    }
}
