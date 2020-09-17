using Newtonsoft.Json;
using openapi_sample_client.Dtos;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace openapi_sample_client
{
    public static class Extensions
    {
        public static async Task<T> GetFromJsonAsync<T>(this HttpClient client,string url)
        {
            var response = await client.GetAsync(url);
            var content = await response.Content.ReadAsStringAsync();

            
          
            return JsonConvert.DeserializeObject<T>(content);
        }

        public static async Task<T> PostFromJsonAsync<T>(this HttpClient client, string url,object data)
        {
            var json = JsonConvert.SerializeObject(data);
            var body= new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync(url,body);
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(content);
        }

        public static async Task<T> PutFromJsonAsync<T>(this HttpClient client, string url, object data)
        {
            var json = JsonConvert.SerializeObject(data);
            var body = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PutAsync(url, body);
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(content);
        }

        public static async Task<T> DeleteFromJsonAsync<T>(this HttpClient client, string url)
        {
            var response = await client.DeleteAsync(url);
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(content);
        }

        public static async Task<string> DeleteFromJsonAsync(this HttpClient client, string url)
        {
            var response = await client.DeleteAsync(url);
            var content = await response.Content.ReadAsStringAsync();
            return content;
        }

        public static async Task<string> PostFromJsonAsync(this HttpClient client, string url, object data)
        {
            var json = JsonConvert.SerializeObject(data);
            var body = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync(url, body);
            var content = await response.Content.ReadAsStringAsync();
            return content;
        }

        public  static void Print(this string s)
        {
            Console.WriteLine(s);
        }
    }
}
