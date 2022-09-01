namespace InvestmentApp.Entities.EntityData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Log
    {
        public int ID { get; set; }

        public int? EffecterID { get; set; }

        public int? AffectedID { get; set; }

        public DateTime Date { get; set; }

        public int Action { get; set; }

        [Required]
        public string Explanation { get; set; }

        public virtual UserTable UserTable { get; set; }
    }
}
