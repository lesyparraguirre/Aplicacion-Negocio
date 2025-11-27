using Datos;
using dominio;
using System.Collections.Generic;

namespace Negocio
{
    public class ProductoNegocio
    {
        public List<Producto> ListarProductos()
        {
            ProductoDatos datos = new ProductoDatos();
            return datos.Listar();
        }
    }
}