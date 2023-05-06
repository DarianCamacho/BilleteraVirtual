using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using m = BilleteraVirtual.Model;
using d = BilleteraVirtual.DatabaseHelper;
namespace BilleteraVirtual.Views
{
    public partial class AddCard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // cargar datos en la página
            }
        }

        protected void btnSave_OnClick(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                SaveTarjeta();
            }
        }

        private void SaveTarjeta()
        {
            m.Tarjeta tarjetaModelo = new m.Tarjeta();

            tarjetaModelo.Banco = SelectBanco.Value;
            tarjetaModelo.Emisor = SelectEmisor.Value;

            if (tarjetaModelo.Banco == "Banco Nacional de Costa Rica")
                tarjetaModelo.Foto = "https://www.bncr.fi.cr/_cache_d1ea/content/debito2-1609240000006845.png";
            if (tarjetaModelo.Banco == "Banco de Costa Rica")
                tarjetaModelo.Foto = "https://www.bancobcr.com/wps/wcm/connect/bcr/4e9cda6f-35ca-492f-a0dc-74ad8a5581c3/4/bcr_tarjeta_black_mastercard.png?MOD=AJPERES";
            if (tarjetaModelo.Banco == "Banco Popular")
                tarjetaModelo.Foto = "https://www.bancopopular.fi.cr/wp-content/uploads/2022/06/2_Tarjeta-Tradicional-BP.png";
            if (tarjetaModelo.Banco == "ScotiaBank")
                tarjetaModelo.Foto = "https://scotiabankfiles.azureedge.net/scotiabank-peru/imagenes/scotiabank/small/tarjetas/credito/mastercard/new-card/tc-MC-Clasica.png";
            if (tarjetaModelo.Banco == "BAC Credomatic")
                tarjetaModelo.Foto = "https://www.baccredomatic.com/sites/default/files/styles/card_646xauto/public/2022-09/sv-tta-visa_platinum_mini.png?itok=y3biJR1a";


            tarjetaModelo.Dueno = inputDueno.Value;
            tarjetaModelo.NumeroTarjeta = inputNumeroTarjeta.Value;
            tarjetaModelo.CodigoCVV = inputCodigoCVV.Value;
            tarjetaModelo.FechaExpiracion = DateTime.Parse(inputFechaExpiracion.Value);

            List<m.Tarjeta> tarjeta = (List<m.Tarjeta>)Session["Tarjeta"];
            if (tarjeta == null)
            {
                tarjeta = new List<m.Tarjeta>();
            }

            Session["Tarjeta"] = tarjeta;

            d.Database DBSave = new d.Database();

            DBSave.SaveTarjeta(tarjetaModelo);

            lblMensaje.Text = " The card has been saved successfully !";

            Response.Redirect("Inicio.aspx");

            return;


            // Lógica para insertar datos en la base de datos
        }

    }
}