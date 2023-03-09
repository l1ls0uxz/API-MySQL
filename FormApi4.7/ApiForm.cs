using FormApi4_7.Shared;
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
using MySqlX.XDevAPI.Common;
using MySqlX.XDevAPI;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Security.Policy;

namespace FormApi4._7
{
    public partial class ApiForm : Form
    {
        public ApiForm()
        {
            InitializeComponent();
        }

        private async void btnGet_Click(object sender, EventArgs e)
        {
            //HttpClient clientt = new HttpClient();
            //clientt.BaseAddress = new Uri("http://localhhost:13245/api/webapi/coder");
            //HttpResponseMessage response = clientt.GetAsync("coder").Result;
            //var responce = await Helper.GetAll();
            //txtRes.Text = Helper.BeautifyJson(responce);

            string url = "https://localhost:12345/api/webapi/coder";
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(url);
            string responseBody = await response.Content.ReadAsStringAsync();
            dynamic data = JsonConvert.DeserializeObject(responseBody);
            MessageBox.Show(JsonConvert.SerializeObject(data, Formatting.Indented));
            dtView.DataSource = data;

        }

        private void ApiForm_Load(object sender, EventArgs e)
        {

        }

        private void grbButton_Enter(object sender, EventArgs e)
        {

        }
    }
}
