namespace WebApplication1.Concrete
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Films
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Films()
        {
            Actors = new HashSet<Actors>();
        }

        [Key]
        public int film_id { get; set; }

        [Required]
        [StringLength(50)]
        public string film { get; set; }

        [Required]
        public string main_director { get; set; }

        public decimal budget { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Actors> Actors { get; set; }
    }
}
