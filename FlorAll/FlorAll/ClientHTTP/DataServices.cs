using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FlorAll.ClientHTTP
{
    public class DataServices
    {
        HttpClient client;

        public async Task<T> GetAll<T>(string url, string toke)
        {
            try
            {
                using (System.Net.Http.HttpClient client = new System.Net.Http.HttpClient())
                {
                    client.DefaultRequestHeaders.Add("token", toke);
                    var resp = await client.GetStringAsync(url);

                    var result = JsonConvert.DeserializeObject<T>(resp);
                    return result;
                }
            }
            catch { throw; }
        }

        public async Task Add<T>(T obj, string url)
        {
            HttpClient client = null;
            try
            {

                client = new HttpClient();
                var uri = new Uri(string.Format(url, (obj as Models.common).id));

                var data = JsonConvert.SerializeObject(obj);
                var content = new StringContent(data, Encoding.UTF8, "application/json");

                HttpResponseMessage response = null;
                response = await client.PostAsync(uri, content);

                if (!response.IsSuccessStatusCode)
                    throw new Exception("Erro ao acessar servidor");

            }
            catch { throw; }
            finally
            {
                if (client != null)
                {
                    client.Dispose();
                    client = null;
                }
            }
        }

        public async Task Update<T>(T obj, string url)
        {
            try
            {
                client = new HttpClient();
                var uri = new Uri(string.Format(url, (obj as Models.common).id));

                var data = JsonConvert.SerializeObject(obj);
                var content = new StringContent(data, Encoding.UTF8, "application/json");

                HttpResponseMessage response = null;
                response = await client.PutAsync(uri, content);

                if (!response.IsSuccessStatusCode)
                    throw new Exception("Erro ao acessar servidor");

            }
            catch { throw; }
            finally
            {
                if (client != null)
                {
                    client.Dispose();
                    client = null;
                }
            }
        }

        public async Task Delete<T>(T obj, string url)
        {
            try
            {
                client = new HttpClient();
                var uri = new Uri(string.Format(url, (obj as Models.common).id));

                HttpResponseMessage response = null;
                response = await client.DeleteAsync(uri);

                if (!response.IsSuccessStatusCode)
                    throw new Exception("Erro ao acessar servidor");

            }
            catch { throw; }
            finally
            {
                if (client != null)
                {
                    client.Dispose();
                    client = null;
                }
            }
        }
    }
}
