namespace InvestmentApp.Entities.Classes
{
    using InvestmentApp.Entities.EntityData;
    using InvestmentApp.Entities.Enums;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UserInvestmentDto : LogDto
    {
        public CurrencyTypes Currency { get; set; }

        public decimal Amount { get; set; }

        public int SenderBankAccountId { get; set; }

        public int TargetBankAccountId { get; set; }

        public UserTable UserTable1 { get; set; }
    }
}