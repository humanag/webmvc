namespace DAL.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SysParam")]
    public partial class SysParam
    {
        [StringLength(50)]
        public string Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public int? Type { get; set; }

        [StringLength(250)]
        public string Value { get; set; }
    }
}
