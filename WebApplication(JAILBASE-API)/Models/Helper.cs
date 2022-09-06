using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI.WebControls;

namespace WebApplication_JAILBASE_API_.Models
{
    public class Helper
    {
        Condado Condados;

        DataColumn column;
        DataRow row;

        public string Error { get; set; }

        string dirBase;

        HttpMessageHandler Handler; //Controlador de mensajes Http o Cliente Http

        public Helper()
        {
            Handler = new HttpClientHandler();
        }

        public async Task GetCondadoAsync()
        {
            dirBase = "https://www.jailbase.com/";
            string SolicitudClienteURI = "/api/1/sources/";
            try
            {
                using (var Cliente = new HttpClient(Handler))
                {
                    Cliente.BaseAddress = new Uri(dirBase);
                    Cliente.DefaultRequestHeaders.Accept.Clear();
                    Cliente.DefaultRequestHeaders.Accept.Add(
                        new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue
                        ("application/Json"));

                    HttpResponseMessage respuesta = await Cliente.GetAsync($"{SolicitudClienteURI}");
                    respuesta.EnsureSuccessStatusCode();

                    if (respuesta.IsSuccessStatusCode)
                    {
                        var jsoncadena = await respuesta.Content.ReadAsStringAsync();
                        Condados = JsonConvert.DeserializeObject<Condado>(jsoncadena);
                    }
                    else
                    {
                        Error = "Se ha producido un error al solicitar el Servicio Web";
                        throw new Exception();
                    }
                }
            }
            catch (HttpRequestException ex)
            {
                Error = ex.Message;
            }

            return;
        }

        public void GetListCondados(DropDownList dropDown)
        {
            DataTable tabla = new DataTable();

            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "source_id";
            tabla.Columns.Add(column);
            
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "state_full";
            tabla.Columns.Add(column);
            
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "name";
            tabla.Columns.Add(column);

            for (int i = 0; i < Condados.records.Count; i++)
            {
                row = tabla.NewRow();
                row["source_id"] = Condados.records[i].source_id;
                row["state_full"] = Condados.records[i].state_full;
                row["name"] = Condados.records[i].name;
                tabla.Rows.Add(row);
            }

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                dropDown.Items.Add(new ListItem(tabla.Rows[i]["name"].ToString(), tabla.Rows[i]["source_id"].ToString())); ;
            }
        }
    }
}