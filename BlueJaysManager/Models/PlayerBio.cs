namespace BlueJaysManager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PlayerBio")]
    public partial class PlayerBio
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PlayerBioID { get; set; }

        public int PlayerNum { get; set; }

        [Required]
        public string Name { get; set; }

        public int Age { get; set; }

        [Required]
        public string Born { get; set; }

        public string Draft { get; set; }

        public string HighSchool { get; set; }

        public string College { get; set; }

        [Required]
        public string Debut { get; set; }
    }
}
