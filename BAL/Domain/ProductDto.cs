namespace BAL.Domain
{
    public class ProductDto : BaseDto
    {
        public string Name { get; set; }

        public string Code { get; set; }

        public string Meta { get; set; }

        public string Description { get; set; }

        public string Detail { get; set; }

        public string Image { get; set; }

        public long? CategoryId { get; set; }

        public int? Views { get; set; }
    }
}
