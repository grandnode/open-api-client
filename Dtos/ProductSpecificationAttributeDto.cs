namespace openapi_sample_client.Dtos
{
    public partial class ProductSpecificationAttributeDto
    {
        public string Id { get; set; } = string.Empty;
        public string SpecificationAttributeId { get; set; }
        public string SpecificationAttributeOptionId { get; set; }
        public string CustomValue { get; set; }
        public bool AllowFiltering { get; set; }
        public bool ShowOnProductPage { get; set; }
        public int DisplayOrder { get; set; }

        public SpecificationAttributeType AttributeType { get; set; }
    }
}
