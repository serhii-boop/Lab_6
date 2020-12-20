namespace WebApplication1.Concrete
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Genres
    {
        [Key]
        public int genre_id { get; set; }

        public string genre { get; set; }
    }
}
