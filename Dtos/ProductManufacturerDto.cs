using System.ComponentModel.DataAnnotations;

namespace openapi_sample_client.Dtos
{
    public partial class ProductManufacturerDto
    {
        [Key]
        public string ManufacturerId { get; set; }
        public bool IsFeaturedProduct { get; set; }
    }
}
