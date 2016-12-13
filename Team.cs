namespace FinalExam
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Team
    {
        public int TeamID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public int? Games { get; set; }

        public int? Wins { get; set; }

        public int? Losses { get; set; }

        public int? OvertimeLosses { get; set; }

        public int? Points { get; set; }

        public int DivisionID { get; set; }

        [StringLength(100)]
        public string Logo { get; set; }

        public virtual Division Division { get; set; }
    }
}
