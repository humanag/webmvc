namespace BAL.Domain
{
    using System;

    public partial class BlogDto : BaseDto
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public string Image { get; set; }

        public long? CategoryId { get; set; }

        public DateTime? UpdateDate { get; set; }

        public int? Sort { get; set; }

        public int? Views { get; set; }

        public string MetaTitle { get; set; }

        public virtual BlogCategoryDto Category { get; set; }
    }
}
