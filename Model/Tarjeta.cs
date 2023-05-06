using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Permissions;
using System.Web;
using System.Web.UI.WebControls;
using c = BilleteraVirtual.Controller;

namespace BilleteraVirtual.Model
{
    public class Tarjeta
    {
        public int Id { get; set; }
        public string Foto { get; set; }
        public string Banco { get; set; }
        public string Emisor { get; set; }
        public string Dueno { get; set; }
        public string UltimosDigitos { get; set; }
        public string NumeroTarjeta { get; set; }
        public string CodigoCVV { get; set; }
        public DateTime FechaExpiracion { get; set; }
    }

}