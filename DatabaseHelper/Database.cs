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
        const string database = "BilleteraVirtua;";
        const string server = "localhost";
        SqlConnection connection = new SqlConnection($"Data Source={server};Initial Catalog={database};Integrated Security=True");

        public DataTable GetTarjetas()
        {
            return this.Fill("[dbo].[spGetTarjetas]", null);
        }

        public DataTable GetTarjetas(int Id)
        {
            List<SqlParameter> param = new List<SqlParameter>()
            {
                new SqlParameter("@Id", Id),
            };

            return this.Fill("[dbo].[spGetTarjetas]", param);
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
    }
}