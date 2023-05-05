using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static BilleteraVirtual.Views.Inicio;

namespace BilleteraVirtual.Views
{
    public partial class Inicio : System.Web.UI.Page
    {
        public class Tarjeta
        {
            public string Foto { get; set; }
            public string Banco { get; set; }
            public string Emisor { get; set; }
            public string Dueno { get; set; }
            public string NumeroTarjeta { get; set; }
            public string CodigoCVV { get; set; }
            public DateTime FechaExpiracion { get; set; }
        }

        private List<Tarjeta> tarjetas;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                tarjetas = new List<Tarjeta>();
                ViewState["tarjetas"] = tarjetas;
            }
            else
            {
                tarjetas = (List<Tarjeta>)ViewState["tarjetas"];
            }

            BindData();
        }

        protected void btnAgregarTarjeta_Click(object sender, EventArgs e)
        {
            Tarjeta tarjeta = new Tarjeta();
            tarjeta.Foto = "ruta de la foto";
            tarjeta.Banco = ddlBanco.SelectedValue;
            tarjeta.Emisor = ddlEmisor.SelectedValue;
            tarjeta.Dueno = txtDueno.Text;
            tarjeta.NumeroTarjeta = txtNumeroTarjeta.Text;
            tarjeta.CodigoCVV = txtCodigoCVV.Text;
            tarjeta.FechaExpiracion = Convert.ToDateTime(txtFechaExpiracion.Text);

            tarjetas.Add(tarjeta);
            ViewState["tarjetas"] = tarjetas;

            BindData();

            LimpiarCampos();
        }

        private void BindData()
        {
            gvTarjetas.DataSource = tarjetas;
            gvTarjetas.DataBind();
        }

        private void LimpiarCampos()
        {
            // Limpiar los campos del formulario
            txtDueno.Text = string.Empty;
            txtNumeroTarjeta.Text = string.Empty;
            txtCodigoCVV.Text = string.Empty;
            txtFechaExpiracion.Text = string.Empty;
        }

    }
}