using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Formatting;
using FormApi48.Shared;
using Newtonsoft.Json;

namespace FormApi48
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            //HttpClient client = new HttpClient();
            //client.BaseAddress = new Uri("http://localhost:12345/api/");
            //HttpResponseMessage response = client.GetAsync("webapi/coder").Result;
            //var responce = await Helper.GetAll();
            //button1.Text = Helper.BeautifyJson(responce);
            //var responseMessage = await client.GetAsync("coder", HttpCompletionOption.ResponseContentRead);
            //dataGridView1.DataSource = responseMessage;

            // Create an instance of your API class
            //var api = new MyApiClass();

            // Call the API method to get data
            //try
            //{
            //    var data = await api.GetDataAsync();
            //    dataGridView1.DataSource = data;
            //}
            //catch (Exception ex)
            //{
            //    // Handle any errors
            //    MessageBox.Show("Error calling API: " + ex.Message);
            //}

            string url = "http://localhost:13245/api/webapi/coder";
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(url);
            string responseBody = await response.Content.ReadAsStringAsync();
            dynamic data = JsonConvert.DeserializeObject(responseBody);
            MessageBox.Show(JsonConvert.SerializeObject(data, Formatting.Indented));
        }
        //public class MyApiClass
        //{
        //    private readonly HttpClient _httpClient;

        //    public MyApiClass()
        //    {
        //        _httpClient = new HttpClient();
        //    }

        //    public async Task<string> GetDataAsync()
        //    {
        //        var response = await _httpClient.GetAsync("http://localhost:12345/api/webapi/coder");
        //        response.EnsureSuccessStatusCode();
        //        var content = await response.Content.ReadAsStringAsync();
        //        return content;
                
        //    }
        //}
    }
}
