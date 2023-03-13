using MySql.Data.MySqlClient;
using Mysqlx.Connection;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Results;
using System.IO.Compression;
using System.IO;
using ConsoleApiDB.Filters;
using System.Xml.Linq;

namespace ConsoleApiDB
{
    public class WebApiController : ApiController
    {
        

        // Connect MySQL Database
        string datareturn;
        string connStr = "server=127.0.0.1;user=root;database=demohmiconnectpc1;port=3306;password=0546";

        // GET api/webapi/name
        [Route("api/{controller}/{name}/{date}")]
        public string GetItemByName(string name, string date)
        {

            string query = "SELECT DATE_FORMAT(Datetime, '%H:%i:%s') FROM " + $"{name}" + " where Datetime between" + $"'{date} 00:00:00'" + " and " + $"'{date} 23:59:59'";

            DataTable table = new DataTable();
            MySqlDataReader myReader;
            using (MySqlConnection mycon = new MySqlConnection(connStr))
            {
                mycon.Open();
                using (MySqlCommand myCommand = new MySqlCommand(query, mycon))
                {
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    mycon.Close();
                }
            }

            datareturn = JsonConvert.SerializeObject(table);
            return datareturn;
        }

        // GET api/webapi/name/datefrom/dateto
        [Route("api/{controller}/{name}/{Datefrom}/{Dateto}")]
        [GzipCompressionAtribute]
        public string GetItemDateTime(string name, string Datefrom, string Dateto)
        {
            string query = "select * from " + $"{name}" + " where `DateTime` between " + $"{Datefrom}" + " and " + $"{Dateto}";

            DataTable table = new DataTable();
            MySqlDataReader myReader;
            using (MySqlConnection mycon = new MySqlConnection(connStr))
            {
                mycon.Open();
                using (MySqlCommand myCommand = new MySqlCommand(query, mycon))
                {
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    mycon.Close();
                }
            }

            datareturn = JsonConvert.SerializeObject(table);
            return datareturn;
        }
    }
}
