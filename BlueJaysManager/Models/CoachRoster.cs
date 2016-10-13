namespace BlueJaysManager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CoachRoster")]
    public partial class CoachRoster
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CoachID { get; set; }

        public int CoachNumber { get; set; }

        [Required]
        [StringLength(30)]
        public string Name { get; set; }

        [Required]
        [StringLength(30)]
        public string Position { get; set; }
    }
}
