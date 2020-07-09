namespace DAL.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Blog")]
    public partial class Blog : BaseEntity
    {
        [StringLength(250)]
        public string Title { get; set; }

        [Column(TypeName = "ntext")]
        public string Content { get; set; }

        [StringLength(250)]
        public string Image { get; set; }

        public long? CategoryId { get; set; }

        public DateTime? CreateDate { get; set; }

        public long? CreateBy { get; set; }

        public DateTime? UpdateDate { get; set; }

        public long? UpdateBy { get; set; }

        public bool? Visible { get; set; }

        public int? Sort { get; set; }

        public int? Views { get; set; }

        [StringLength(250)]
        public string MetaTitle { get; set; }

        public virtual BlogCategory Category { get; set; }
    }
}
