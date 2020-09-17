using System.Collections.Generic;

namespace openapi_sample_client.Dtos
{
    public partial class SpecificationAttributeDto
    {
        public SpecificationAttributeDto()
        {
            SpecificationAttributeOptions = new List<SpecificationAttributeOptionDto>();
        }
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
        public IList<SpecificationAttributeOptionDto> SpecificationAttributeOptions { get; set; }

    }
    public partial class SpecificationAttributeOptionDto
    {
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
        public string ColorSquaresRgb { get; set; }
    }
}
