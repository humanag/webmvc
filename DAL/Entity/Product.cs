namespace DAL.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product : BaseEntity
    {
        [Required]
        [StringLength(250)]
        public string Name { get; set; }

        [StringLength(39)]
        public string Code { get; set; }

        [StringLength(250)]
        public string MetaTitle { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [Column(TypeName = "ntext")]
        public string Detail { get; set; }

        [StringLength(250)]
        public string Image { get; set; }

        public long? CategoryId { get; set; }

        public DateTime? CreateDate { get; set; }

        public long? CreateBy { get; set; }

        public DateTime? UpdateDate { get; set; }

        public long? UpdateBy { get; set; }

        public bool? Visible { get; set; }

        public int? Sort { get; set; }

        public bool? IsNew { get; set; }

        public int? Views { get; set; }

        public virtual Category Category { get; set; }
    }
}
