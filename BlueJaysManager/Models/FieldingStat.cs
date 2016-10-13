namespace BlueJaysManager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FieldingStat
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FieldingStatsID { get; set; }

        public int PlayerNum { get; set; }

        [StringLength(30)]
        public string FieldStatYear { get; set; }

        [StringLength(30)]
        public string Team { get; set; }

        [StringLength(30)]
        public string League { get; set; }

        [StringLength(30)]
        public string Position { get; set; }

        public int Games { get; set; }

        public int GamesStarted { get; set; }

        public double InningsAtThisPosition { get; set; }

        public int TotalChances { get; set; }

        public int Putouts { get; set; }

        public int Assists { get; set; }

        public int Errors { get; set; }

        public int DoublePlays { get; set; }

        public int PassedBall { get; set; }

        public int StolenBases { get; set; }

        public int CaughtStealing { get; set; }

        public double RangeFactor { get; set; }

        public double FieldingPercentage { get; set; }
    }
}
