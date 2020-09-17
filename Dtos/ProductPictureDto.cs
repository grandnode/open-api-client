using System.ComponentModel.DataAnnotations;

namespace openapi_sample_client.Dtos
{
    public partial class ProductPictureDto
    {
        [Key]
        public string PictureId { get; set; }
        public int DisplayOrder { get; set; }
        public string MimeType { get; set; }
        public string SeoFilename { get; set; }
        public string AltAttribute { get; set; }
        public string TitleAttribute { get; set; }
    }
}
