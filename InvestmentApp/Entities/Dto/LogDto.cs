namespace InvestmentApp.Entities.Classes
{
    using InvestmentApp.Entities.EntityData;
    using InvestmentApp.Entities.Enums;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LogDto
    {
        public int ID { get; set; }

        public int? EffecterID { get; set; }

        public int? AffectedID { get; set; }

        public DateTime Date { get; set; }

        public LogAction Action { get; set; }

        [Required]
        public string Explanation { get; set; }

        public virtual UserTable UserTable { get; set; }
    }
}
