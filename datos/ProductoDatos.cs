using dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Datos
{
    public class ProductoDatos
    {
        public List<Producto> Listar()
        {
            List<Producto> lista = new List<Producto>();

            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.AbrirConexion();

                // 👇 Nombres EXACTOS: tabla Producto, columnas id, descripcion, precio
                using (SqlCommand cmd = new SqlCommand(
                    "SELECT id, descripcion, precio FROM Producto",
                    datos.Conexion))
                {
                    SqlDataReader lector = cmd.ExecuteReader();

                    while (lector.Read())
                    {
                        Producto p = new Producto
                        {
                            Id = (int)lector["id"],
                            Descripcion = (string)lector["descripcion"],
                            Precio = Convert.ToDecimal(lector["precio"])
                        };

                        lista.Add(p);
                    }
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
