namespace openapi_sample_client.Dtos
{
    public partial class ProductWarehouseInventoryDto
    {

        public string Id { get; set; } = string.Empty;
        public string WarehouseId { get; set; }
        public int StockQuantity { get; set; }
        public int ReservedQuantity { get; set; }
    }
}
