using System.Collections.Generic;

namespace BAL.Domain
{
    public class BlogCategoryDto : BaseDto
    {
        public string Name { get; set; }

        public string MetaTitle { get; set; }

        public long? ParentId { get; set; }

        public int? Sort { get; set; }

        public virtual ICollection<BlogDto> Blogs { get; set; }
    }
}
