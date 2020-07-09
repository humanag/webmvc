namespace DAL.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BlogCategory")]
    public partial class BlogCategory : BaseEntity
    {
        [Required]
        [StringLength(250)]
        public string Name { get; set; }

        [StringLength(250)]
        public string MetaTitle { get; set; }

        public long? ParentId { get; set; }

        public DateTime? CreateDate { get; set; }

        public long? CreateBy { get; set; }

        public DateTime? UpdateDate { get; set; }

        public long? UpdateBy { get; set; }

        public bool? Visible { get; set; }

        public int? Sort { get; set; }

        public virtual ICollection<Blog> Blogs { get; set; }
    }
}
