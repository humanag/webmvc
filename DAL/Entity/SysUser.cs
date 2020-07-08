namespace DAL.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SysUser")]
    public partial class SysUser : BaseEntity
    {
        [Required]
        [StringLength(64)]
        public string UserName { get; set; }

        [Required]
        [StringLength(250)]
        public string FullName { get; set; }

        [StringLength(64)]
        public string PassWD { get; set; }

        [StringLength(250)]
        public string Email { get; set; }
    }
}
