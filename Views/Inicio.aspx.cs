using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using m = BilleteraVirtual.Model;
using c = BilleteraVirtual.Controller;

namespace BilleteraVirtual.Views
{
    public partial class Inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            c.Tarjeta tarjeta = new c.Tarjeta();

            repTarjetas.DataSource = tarjeta.GetTarjetas();
            repTarjetas.DataBind();
        }
    }
}