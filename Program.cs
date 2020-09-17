using openapi_sample_client.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace openapi_sample_client
{
    class Program
    {
        private static string _fetchTokenUrl = "http://localhost:16592/api/token/create";
        private static string _coutryUrl = "http://localhost:16592/odata/Country";
        private  static string _categoryUrl = "http://localhost:16592/odata/Category";
        private static string _productUrl = "http://localhost:16592/odata/Product";
        private static string _createCategoryProduct = "http://localhost:16592/odata/Product/CreateProductCategory";
        static async  Task Main(string[] args)
        {
            var client = new HttpClient();
            //credential
            string email = "admin@yourstore.com";
            string password = "123456";

            //fech auth token 
            var token = await client.PostFromJsonAsync(_fetchTokenUrl, new
            {
                email = email,
                password = Base64Encode(password)
            });
            $"Fetch auth token :{token}".Print();

            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);

            //Country
            var allCountries = await client.GetFromJsonAsync<ODataWrapper<List<CountryDto>>>(_coutryUrl);
            $"Fetch {allCountries.Value.Count }countiers ".Print();
            //--------category--------
            var allCategories = await client.GetFromJsonAsync<ODataWrapper<List<CategoryDto>>>(_categoryUrl);

            //add category 
            var newCategory = new CategoryDto()
            {
                Name = "SampleCategory"
            };

            var addedCategory = await client.PostFromJsonAsync<CategoryDto>(_categoryUrl, newCategory);
            $"Add new category '{addedCategory.Name}' with Id {addedCategory.Id}".Print();
            addedCategory.Name = "new sample name";
            //update
            var updatedCategory = await client.PutFromJsonAsync<CategoryDto>(_categoryUrl, addedCategory);
            $"Update category '{updatedCategory.Name}' with id {updatedCategory.Id}".Print();
            //category by id
            var category = await client.GetFromJsonAsync<CategoryDto>($"{_categoryUrl}/{addedCategory.Id}");
            //delete category
            await client.DeleteFromJsonAsync($"{_categoryUrl}?key={addedCategory.Id}");
            $"Delete category with id {addedCategory.Id}".Print();
            //--------Products------
            //insert
            var productDto = new ProductDto()
            {
                Name = "Sample product name"
            };

            var addedProduct = await client.GetFromJsonAsync<ODataWrapper<List<ProductDto>>>(_productUrl);
            $"Fetch {addedProduct.Value.Count} products".Print();
            var product = addedProduct.Value.FirstOrDefault();
            var cat = allCategories.Value.FirstOrDefault();
            var productCategory=new ProductCategoryDto()
            {
                CategoryId = cat.Id
            };
            //Add new category to product 
            var updatedProduct = await client.PostFromJsonAsync<ProductDto>($"{_createCategoryProduct}/({product.Id})", productCategory);
            $"Add category to product id {product.Id}".Print();
        }

        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }
    }
}
