namespace openapi_sample_client.Dtos
{
    public partial class ProductAttributeCombinationDto
    {
        public string Id { get; set; } = string.Empty;
        public string AttributesXml { get; set; }
        public int StockQuantity { get; set; }
        public bool AllowOutOfStockOrders { get; set; }
        public string Text { get; set; }
        public string Sku { get; set; }
        public string ManufacturerPartNumber { get; set; }
        public string Gtin { get; set; }
        public decimal? OverriddenPrice { get; set; }
        public int NotifyAdminForQuantityBelow { get; set; }
        public string PictureId { get; set; }
    }
}
