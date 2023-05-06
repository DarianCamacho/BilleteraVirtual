using BilleteraVirtual.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;
using m = BilleteraVirtual.Model;


namespace BilleteraVirtual.DatabaseHelper
{
    public class Database
    {
        const string database = "BilleteraVirtual";
        const string server = "localhost";
        SqlConnection connection = new SqlConnection($"Data Source={server};Initial Catalog={database};Integrated Security=True");
        string cnn = $"Data Source={server};Initial Catalog={database};Integrated Security=True";

        public DataTable GetTarjetas()
        {
            return ExecuteQuery("[dbo].[GetTarjetas]", null);
        }

        public DataTable GetTarjetas(int Id)
        {
            List<SqlParameter> param = new List<SqlParameter>()
            {
                new SqlParameter("@Id", Id),
            };

            return this.Fill("[dbo].[spGetTarjetas]", param);
        }

        
        public DataTable GetTarjeta()
        {
            return this.Fill("[dbo].[GetTarjeta]", null);
        }

        public DataTable GetTarjeta(int Id)
        {
            List<SqlParameter> param = new List<SqlParameter>()
            {
                new SqlParameter("@Id", Id),
            };

            return this.Fill("[dbo].[GetTarjeta]", param);
        }

        public void SaveTarjeta(m.Tarjeta tarjeta)
        {
            List<SqlParameter> param = new List<SqlParameter>()
            {

                new SqlParameter("@Foto", tarjeta.Foto),
                new SqlParameter("@Banco", tarjeta.Banco),
                new SqlParameter("@Emisor", tarjeta.Emisor),
                new SqlParameter("@Dueno", tarjeta.Dueno),
                new SqlParameter("@NumeroTarjeta", tarjeta.NumeroTarjeta),
                new SqlParameter("@CodigoCVV", tarjeta.CodigoCVV),
                new SqlParameter("@fechaExpiracion", tarjeta.FechaExpiracion),

            };

            ExecuteQuery("[dbo].[spSaveTarjeta]", param);
        }

        public DataTable Fill(string storedProcedure, List<SqlParameter> param)
        {
            try
            {
                using (this.connection)
                {
                    connection.Open();
                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = storedProcedure;

                    if (param != null)
                    {
                        foreach (SqlParameter p in param)
                        {
                            cmd.Parameters.Add(p);
                        }
                    }

                    DataTable ds = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(ds);
                    return ds;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ExecuteQuery(string storedProcedure, List<SqlParameter> param)
        {
            try
            {
                DataTable ds = new DataTable();

                using (SqlConnection connection = new SqlConnection(cnn))
                {
                    connection.Open();
                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = storedProcedure;

                    if (param != null)
                    {
                        foreach (SqlParameter p in param)
                        {
                            cmd.Parameters.Add(p);
                        }
                    }

                    cmd.ExecuteNonQuery();

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(ds);
                }

                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}