using BilleteraVirtual.Model;
using BilleteraVirtual.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Web;
using System.Web.UI;
using m = BilleteraVirtual.Model;

namespace BilleteraVirtual.Controller
{
    public class Tarjeta
    {
        public List<m.Tarjeta> GetTarjetas()
        {
            DatabaseHelper.Database db = new DatabaseHelper.Database();

            DataTable ds = db.GetTarjetas();

            return ConvertDSToList(ds);
        }

        public List<m.Tarjeta> GetTarjeta(int Id)
        {
            DatabaseHelper.Database db = new DatabaseHelper.Database();

            DataTable ds = db.GetTarjeta();

            return ConvertDSToList(ds);
        }

        public List<m.Tarjeta> ConvertDSToList(DataTable ds)
        {
            List<m.Tarjeta> TarjetaList = new List<m.Tarjeta>();

            foreach (DataRow row in ds.Rows) 
            {
                TarjetaList.Add(new m.Tarjeta{
                    Foto = row["Foto"].ToString(),
                    Banco = row["Banco"].ToString(),
                    Emisor = row["Emisor"].ToString(),
                    Dueno = row["Dueno"].ToString(),
                    UltimosDigitos = row["UltimosDigitos"].ToString(),
                    FechaExpiracion = Convert.ToDateTime(row["FechaExpiracion"])
                });
            }

            return TarjetaList;
        }
    }
}
