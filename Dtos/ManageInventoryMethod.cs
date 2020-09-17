namespace openapi_sample_client.Dtos
{
    public enum ManageInventoryMethod
    {
        /// <summary>
        /// Don't track inventory for product
        /// </summary>
        DontManageStock = 0,
        /// <summary>
        /// Track inventory for product
        /// </summary>
        ManageStock = 1,
        /// <summary>
        /// Track inventory for product by product attributes
        /// </summary>
        ManageStockByAttributes = 2,
        /// <summary>
        /// Track inventory for product by bundle products
        /// </summary>
        ManageStockByBundleProducts = 3,
    }
}