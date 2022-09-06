using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication_JAILBASE_API_.Models;

namespace WebApplication_JAILBASE_API_
{
    public partial class index : System.Web.UI.Page
    {
        List<Datos> datos;
        Helper Actions;
        public index()
        {
            Actions = new Helper();
            datos = new List<Datos>();
        }

        protected async void Page_Load(object sender, EventArgs e)
        {
            await Actions.GetCondadoAsync();
            if (!IsPostBack)
            {
                Actions.GetListCondados(DdlCondado);
            }
        }
    }
}