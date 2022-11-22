namespace InvestmentApp.Entities.Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UserAccount
    {
        public int ID { get; set; }

        public int UserId { get; set; }

        [Required]
        public string AccountName { get; set; }

        [Required]
        public string IBAN { get; set; }

        public int Currency { get; set; }

        public int Balance { get; set; }
    }
}
