using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using c = BilleteraVirtual.Controller;
using m = BilleteraVirtual.Model;


namespace BilleteraVirtual.Views
{
    public partial class MyCreditCard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            int Id = Convert.ToInt16(Request.QueryString["Id"]);

            c.Tarjeta tarjetaController = new c.Tarjeta();
            List<m.Tarjeta> tarjeta = tarjetaController.GetTarjeta(Id);
            Session["tarjeta"] = tarjeta;

            repTarjeta.DataSource = tarjeta;
            repTarjeta.DataBind();
            
            /*
            int IdCard = Convert.ToInt16(Request.QueryString["IdCard"]);
            string Id = Request.QueryString["Id"];

            c.Tarjeta tarjetaController = new c.Tarjeta();
            m.MiTarjeta MitarjetaModel = new m.MiTarjeta();

            m.MiTarjeta tarjeta = tarjetaController.GetTarjeta(Convert.ToInt16(IdCard));

            List<m.Tarjeta> TarjetaList = tarjetaController.GetTarjeta(IdCard);
            Session["tarjeta"] = tarjeta;

            repTarjeta.DataSource = tarjeta;
            repTarjeta.DataBind();
            */

        }
    }
}