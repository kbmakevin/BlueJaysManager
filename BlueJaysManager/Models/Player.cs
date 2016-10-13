namespace BlueJaysManager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PlayerRoster")]
    public partial class Player
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PlayerID { get; set; }

        public int PlayerNum { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Position { get; set; }

        public int Height { get; set; }

        public int Weight { get; set; }

        [Required]
        public string SkillOrientation { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }
    }
}
