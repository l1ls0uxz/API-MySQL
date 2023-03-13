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
using MySqlX.XDevAPI.Relational;

namespace FormApi4._7
{
    public partial class ApiForm : Form
    {
        string datareturn;
        public ApiForm()
        {
            InitializeComponent();
        }
        // Button Get
        private async void btnGet_Click(object sender, EventArgs e)
        {
            var responce = await Helper.GetAll(
                cbxName.Text.ToString(),
                dateFrom.Value.ToString("yyyy-MM-dd HH:mm:ss"), 
                dateTo.Value.ToString("yyyy-MM-dd HH:mm:ss")
                );
            dtView.Text = Helper.BeautifyJson(responce);
            
        }
        private void btnGet2_Click(object sender, EventArgs e)
        {
        }

        private void ApiForm_Load(object sender, EventArgs e)
        {
        }

        private void grbButton_Enter(object sender, EventArgs e)
        {
        }

        // Checked status
        private void ckbReport_CheckedChanged(object sender, EventArgs e)
        {
            if(ckbReport.Checked)
            {
                pnTime.Visible = false;
                pnReport.Visible = true;
            }
            else { 
                pnTime.Visible = true; 
                pnReport.Visible = false; 
            }
        }

        private async void cbxName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ckbReport.Checked)
            {
                var responce = await Helper.GetTable(
                cbxName.Text.ToString(),
                dateTimePicker2.Value.ToString("yyyy-MM-dd"));
                //cbxName.DataSource = responce;
                cbxTime.Items.Add(responce);
                MessageBox.Show("oki!");
            }
            else
            {
                
            }

        }

        
    }
}
