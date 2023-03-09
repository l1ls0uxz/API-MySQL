using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FormApi4_7.Shared
{
    public static class Helper
    {
        private static readonly string baseURl = "http://localhost:12345/api/webapi/";
        public static async Task<string> GetAll()
        {
            await Task.Delay(5000);
            using (HttpClient client = new HttpClient()) 
            {
                using (HttpResponseMessage res = await client.GetAsync(baseURl + "coder"))
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
