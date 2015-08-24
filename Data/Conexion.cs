using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Data
{
    public class Conexion
    {
        public string cadenaConexion { get; set; }

        public Conexion()
        {
            cadenaConexion = "Data Source=localhost;Initial Catalog=Customers;User ID=sa;Password=SOPTEC;Integrated Security=True;";
        }

        public DataTable ConsultaClientes(params entClientes cliente)
        {
            var ds = new DataTable();
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    using (SqlCommand comando = new SqlCommand("example", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.Add("@Id", SqlDbType.VarChar).Value = cliente.CustomerId;

                        SqlDataAdapter da = new SqlDataAdapter { SelectCommand = comando };

                        conexion.Open();
                        comando.ExecuteNonQuery();
                        da.Fill(ds);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

            return ds;
        }

    }
}
