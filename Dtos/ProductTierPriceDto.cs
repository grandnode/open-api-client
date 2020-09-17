
using System;

namespace Grand.Api.DTOs.Catalog
{
    public partial class ProductTierPriceDto 
    {
        public string Id { get; set; } = string.Empty;
        public string StoreId { get; set; }
        public string CustomerRoleId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public DateTime? StartDateTimeUtc { get; set; }
        public DateTime? EndDateTimeUtc { get; set; }
    }
}
