using FormApi4._7;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormApi4_7.Shared
{
    public static class Helper
    {
        private static readonly string baseURl = "http://localhost:12345/api/webapi/";
        public static async Task<string> GetAll(string name,string datefrom, string dateto)
        {
            await Task.Delay(1000);
            using (HttpClient client = new HttpClient(new HttpClientHandler {
                AutomaticDecompression = System.Net.DecompressionMethods.GZip | System.Net.DecompressionMethods.Deflate })) 
            {
                using (HttpResponseMessage res = await client.GetAsync(baseURl + $"{name}" + $"/'{datefrom}'" + $"/'{dateto}'"))
                {
                    using (HttpContent content = res.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        
                        if (data != null) 
                        { 

                            return data;
                        }
                    }
                }
            }
            return string.Empty;
        }
        public static async Task<string> GetTable(string name, string date)
        {
            await Task.Delay(1000);
            using (HttpClient client = new HttpClient(new HttpClientHandler
            {
                AutomaticDecompression = System.Net.DecompressionMethods.GZip | System.Net.DecompressionMethods.Deflate
            }))
            {
                using (HttpResponseMessage res = await client.GetAsync(baseURl + $"{name}" + $"/{date}"))
                {
                    using (HttpContent content = res.Content)
                    {
                        string data = await content.ReadAsStringAsync();

                        if (data != null)
                        {

                            return data;
                        }
                    }
                }
            }
            return string.Empty;
        }
        public static string BeautifyJson(string jsonStr)
        {
            JToken parseJson = JToken.Parse(jsonStr);
            return parseJson.ToString(Formatting.Indented);
        }
    }
}
