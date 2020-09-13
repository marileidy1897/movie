using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movie.DAL
{
    class conexionDALL
    {
        static string ConexionString = "Data Source=DESKTOP-6IM3VH2\\SQLEXPRESS;Initial Catalog=movie;Integrated Security=True";
        static SqlConnection Conexion;

        public SqlConnection Connect()
        {
           
            Conexion = new SqlConnection(ConexionString);
            return Conexion;
        }
        

        public bool Conectar()
        {
            try
            {
                Conexion.Open();
                Console.WriteLine("conectado");

            }
            catch (Exception ex)
            {
                Console.WriteLine("error " + ex.Message);
                return false;
            }

            return true;
        }
        // metodo para eliminar, ingresar, actualizar datos.
        public bool Command(string strCommand)
        {
            try
            {
                SqlCommand Commando = new SqlCommand();
                Commando.CommandText = strCommand;
                Commando.Connection = this.Connect();
                Conexion.Open();
                Commando.ExecuteNonQuery();
                Conexion.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

            
        }

    }


}
