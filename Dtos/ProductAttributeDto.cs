using System.Collections.Generic;

namespace openapi_sample_client.Dtos
{
    public partial class ProductAttributeDto
    {
        public ProductAttributeDto()
        {
            PredefinedProductAttributeValues = new List<PredefinedProductAttributeValueDto>();
        }
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; }
        public string Description { get; set; }
        public IList<PredefinedProductAttributeValueDto> PredefinedProductAttributeValues { get; set; }
    }

    public partial class PredefinedProductAttributeValueDto
    {
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; }
        public decimal PriceAdjustment { get; set; }
        public decimal WeightAdjustment { get; set; }
        public decimal Cost { get; set; }
        public bool IsPreSelected { get; set; }
        public int DisplayOrder { get; set; }
    }
}
