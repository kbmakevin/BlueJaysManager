namespace BlueJaysManager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BattingStat
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BattingStatsID { get; set; }

        public int PlayerNum { get; set; }

        [StringLength(50)]
        public string BatStatYear { get; set; }

        [StringLength(50)]
        public string Team { get; set; }

        [StringLength(10)]
        public string League { get; set; }

        public int Games { get; set; }

        public int AtBats { get; set; }

        public int Runs { get; set; }

        public int Hits { get; set; }

        public int TotalBases { get; set; }

        public int Doubles { get; set; }

        public int Triples { get; set; }

        public int HomeRuns { get; set; }

        public int RunsBattedIn { get; set; }

        public int BasesOnBalls { get; set; }

        public int IntentionalBasesOnBalls { get; set; }

        public int Strikeouts { get; set; }

        public int StolenBases { get; set; }

        public int CaughtStealing { get; set; }

        public double BattingAverage { get; set; }

        public double OnBasePercentage { get; set; }

        public double SluggingPercentage { get; set; }

        public double OnBasePlusSlugging { get; set; }

        public double GroundOrAirOuts { get; set; }
    }
}
