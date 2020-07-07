namespace DAL.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductImage")]
    public partial class ProductImage
    {
        public long Id { get; set; }

        public long? ProductId { get; set; }

        [StringLength(250)]
        public string path { get; set; }

        [StringLength(50)]
        public string Description { get; set; }
    }
}
