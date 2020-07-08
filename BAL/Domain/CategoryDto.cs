namespace BAL.Domain
{
    using System;

    public class CategoryDto : BaseDto
    {
        public string Name { get; set; }

        public string MetaTitle { get; set; }

        public long? ParentId { get; set; }

        public bool? Visible { get; set; }

        public int? Sort { get; set; }
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