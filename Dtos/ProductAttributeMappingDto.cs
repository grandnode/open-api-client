using System.Collections.Generic;

namespace openapi_sample_client.Dtos
{
    public partial class ProductAttributeMappingDto
    {
        public ProductAttributeMappingDto()
        {
            ProductAttributeValues = new List<ProductAttributeValueDto>();
        }

        public string Id { get; set; } = string.Empty;
        public string ProductAttributeId { get; set; }
        public string TextPrompt { get; set; }
        public bool IsRequired { get; set; }
        public int DisplayOrder { get; set; }
        public int? ValidationMinLength { get; set; }
        public int? ValidationMaxLength { get; set; }
        public string ValidationFileAllowedExtensions { get; set; }
        public int? ValidationFileMaximumSize { get; set; }
        public string DefaultValue { get; set; }
        public string ConditionAttributeXml { get; set; }

        public string AttributeControlType { get; set; }

        public IList<ProductAttributeValueDto> ProductAttributeValues { get; set; }


    }
    public partial class ProductAttributeValueDto
    {
        public string AssociatedProductId { get; set; }
        public string Name { get; set; }
        public string ColorSquaresRgb { get; set; }
        public string ImageSquaresPictureId { get; set; }
        public decimal PriceAdjustment { get; set; }
        public decimal WeightAdjustment { get; set; }
        public decimal Cost { get; set; }
        public int Quantity { get; set; }
        public bool IsPreSelected { get; set; }
        public int DisplayOrder { get; set; }
        public string PictureId { get; set; }

        public string AttributeValueType { get; set; }
    }
}
