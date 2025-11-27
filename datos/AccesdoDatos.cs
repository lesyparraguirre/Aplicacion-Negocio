using System;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class AccesoDatos
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        public SqlDataReader Lector => lector;

        public AccesoDatos()
        {
            conexion = new SqlConnection("Server=.\\SQLEXPRESS; Database=NegocioDB; Integrated Security=True");
            comando = new SqlCommand();
            comando.Connection = conexion;
        }

        public void AbrirConexion()
        {
            if (conexion.State != ConnectionState.Open)
                conexion.Open();
        }
    }
}