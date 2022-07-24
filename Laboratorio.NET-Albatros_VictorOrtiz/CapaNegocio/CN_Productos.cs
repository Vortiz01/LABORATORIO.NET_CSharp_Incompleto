using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CD_ConexionBD;
using CD_Productos;

namespace CapaNegocio
{
    public class CN_Productos
    {
        DataTable dtable = new DataTable();
        SqlCommand cmd = new SqlCommand();

        private ConexionBD conexion = new ConexionBD();
        private Productos cd_productos = new Productos();

        public DataTable MostrarTabla()
        {
            DataTable tabla = new DataTable();
            tabla = conexion.cargarTabla("Productos");
            return tabla;
        }

        public void InsertProd (int codigo, string descripcion, int cantidad, double precio, string estado, int codImpuesto)
        {
            cd_productos.Codigo = codigo;
            cd_productos.Descripcion = descripcion;
            cd_productos.Cantidad = cantidad;
            cd_productos.Precio = precio;
            cd_productos.Estado = estado;
            cd_productos.CodImpuesto = codImpuesto;
            cd_productos.Insertar_Producto();
        }

        public void UpdateProd(int codigo, string descripcion, int cantidad, double precio, string estado, int codImpuesto)
        {
            cd_productos.Codigo = codigo;
            cd_productos.Descripcion = descripcion;
            cd_productos.Cantidad = cantidad;
            cd_productos.Precio = precio;
            cd_productos.Estado = estado;
            cd_productos.CodImpuesto = codImpuesto;
            cd_productos.Editar_Producto();
        }
    }
}
