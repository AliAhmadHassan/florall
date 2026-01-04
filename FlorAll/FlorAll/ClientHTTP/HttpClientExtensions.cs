using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FlorAll.ClientHTTP
{
    public static class HttpClientExtensions
    {
        public static async Task<T> GetAsync<T>(this HttpClient client, string url)
        {
            var httpRequest = new HttpRequestMessage(new HttpMethod("GET"), url);

            client.Timeout = TimeSpan.FromSeconds(30);

            var response = await client.SendAsync(httpRequest);
            var jsonString = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<T>(jsonString);

            return result;
        }

        public static async Task<string> GetStringAsync(this HttpClient client, string url)
        {
            var httpRequest = new HttpRequestMessage(new HttpMethod("GET"), url);
            var response = client.SendAsync(httpRequest).Result;
            var jsonString = await response.Content.ReadAsStringAsync();

            return jsonString;
        }
    }
}
