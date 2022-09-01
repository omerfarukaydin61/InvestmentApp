namespace InvestmentApp.Entities.Classes
{
    using InvestmentApp.Entities.EntityData;
    using InvestmentApp.Entities.Enums;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BankAccountDto
    {
        public int ID { get; set; }

        public int UserId { get; set; }

        [Required]
        public string AccountName { get; set; }

        [Required]
        public string IBAN { get; set; }

        public CurrencyTypes Currency { get; set; }

        public decimal Balance { get; set; }

        public virtual UserTable UserTable { get; set; }
    }
}
