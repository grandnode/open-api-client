using System.ComponentModel.DataAnnotations;

namespace openapi_sample_client.Dtos
{
    public partial class ProductCategoryDto
    {
        [Key]
        public string CategoryId { get; set; }
        public bool IsFeaturedProduct { get; set; }
    }
}
