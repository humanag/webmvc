namespace DAL.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductRelation")]
    public partial class ProductRelation
    {
        public long Id { get; set; }

        public long? ProductId { get; set; }

        public long? RelationId { get; set; }
    }
}
