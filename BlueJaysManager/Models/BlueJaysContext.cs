namespace BlueJaysManager.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BlueJaysContext : DbContext
    {
        public BlueJaysContext()
            : base("name=BlueJaysConnection")
        {
        }

        public virtual DbSet<BattingStat> BattingStats { get; set; }
        public virtual DbSet<CoachRoster> CoachRosters { get; set; }
        public virtual DbSet<FieldingStat> FieldingStats { get; set; }
        public virtual DbSet<PitchingStat> PitchingStats { get; set; }
        public virtual DbSet<PlayerBio> PlayerBios { get; set; }
        public virtual DbSet<PlayerRoster> PlayerRosters { get; set; }
        public virtual DbSet<PlayerStatsSummary> PlayerStatsSummaries { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
