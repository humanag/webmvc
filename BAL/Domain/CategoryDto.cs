namespace BAL.Domain
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;

    public class CategoryDto : BaseDto
    {
        [DisplayName("Tên nhóm")]
        public string Name { get; set; }

        [DisplayName("Liên kết")]
        public string MetaTitle { get; set; }

        public long? ParentId { get; set; }

        public bool? Visible { get; set; }

        public int? Sort { get; set; }

        public virtual ICollection<ProductDto> Products { get; set; }
    }

    public class CategorySmallDto : BaseDto
    {
        public string Name { get; set; }

        public string MetaTitle { get; set; }
    }

    public class CategoryWithProductContDto : BaseDto
    {
        public string Name { get; set; }

        public string MetaTitle { get; set; }

        public int ProductCount { get; set; }
    }
}