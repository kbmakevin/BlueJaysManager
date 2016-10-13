namespace BlueJaysManager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PlayerStatsSummary
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PlayerStatsSummaryID { get; set; }

        public int PlayerNum { get; set; }

        public string SummaryYear { get; set; }

        public int Wins { get; set; }

        public int Losses { get; set; }

        public double EarnedRunsAverage { get; set; }

        public int Games { get; set; }

        public int GamesStarted { get; set; }

        public int Saves { get; set; }

        public double InningsPitched { get; set; }

        public int StrikeOuts { get; set; }

        public double WalkAndHitsPerInningsPitched { get; set; }
    }
}
