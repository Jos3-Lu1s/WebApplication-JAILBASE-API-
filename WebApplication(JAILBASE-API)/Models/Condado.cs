using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication_JAILBASE_API_.Models
{
    public class Datos
    {
        public string IdCondado { get; set; }
        public string Estado { get; set; }
        public string NombreCondado { get; set; }
    }

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Record
    {
        public string city { get; set; }
        public string name { get; set; }
        public string state_full { get; set; }
        public string address1 { get; set; }
        public string source_url { get; set; }
        public string county { get; set; }
        public string phone { get; set; }
        public string state { get; set; }
        public string source_id { get; set; }
        public string zip_code { get; set; }
        public string email { get; set; }
        public bool has_mugshots { get; set; }
    }

    public class Condado
    {
        public int status { get; set; }
        public string msg { get; set; }
        public List<Record> records { get; set; }
    }


}