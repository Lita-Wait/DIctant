namespace Диктант.MVVM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Dictant")]
    public partial class Dictant
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Dictant()
        {
            Participant = new HashSet<Participant>();
        }

        public int DictantID { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime Date { get; set; }

        public int Difficult { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Participant> Participant { get; set; }
    }
}
