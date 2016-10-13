namespace BlueJaysManager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PitchingStat
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PitchingStatsID { get; set; }

        public int PlayerNum { get; set; }

        [StringLength(30)]
        public string PitchStatYear { get; set; }

        [StringLength(10)]
        public string Team { get; set; }

        [StringLength(30)]
        public string League { get; set; }

        public int Wins { get; set; }

        public int Losses { get; set; }

        public double EarnedRunsAverage { get; set; }

        public int Games { get; set; }

        public int GamesStarted { get; set; }

        public int CompleteGames { get; set; }

        public int ShutOuts { get; set; }

        public int Saves { get; set; }

        public int SaveOpportunities { get; set; }

        public double InningsPitched { get; set; }

        public int Hits { get; set; }

        public int Runs { get; set; }

        public int EarnedRuns { get; set; }

        public int HomeRuns { get; set; }

        public int HitBatsmen { get; set; }

        public int BasesOnBalls { get; set; }

        public int IntentionalBasesOnBalls { get; set; }

        public int StrikeOuts { get; set; }

        public double BattingAverage { get; set; }

        public double WalksAndHitsPerInningsPitched { get; set; }

        public double GroundOrAirOuts { get; set; }
    }
}
