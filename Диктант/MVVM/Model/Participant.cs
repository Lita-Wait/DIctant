namespace Диктант.MVVM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Participant")]
    public partial class Participant
    {
        public int ParticipantID { get; set; }

        [Required]
        [StringLength(255)]
        public string ParticipantFIO { get; set; }

        [Required]
        [StringLength(11)]
        public string Phone { get; set; }

        public int Dictant_ID { get; set; }

        public int Center_ID { get; set; }

        public int? Resultat { get; set; }

        public virtual Center Center { get; set; }

        public virtual Dictant Dictant { get; set; }
    }
}
