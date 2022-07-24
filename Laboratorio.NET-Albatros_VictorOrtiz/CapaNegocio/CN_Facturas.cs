using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CD_ConexionBD;
using CD_Facturas;

namespace CapaNegocio
{
    public class CN_Facturas
    {
        DataTable dtable = new DataTable();
        SqlCommand cmd = new SqlCommand();

        private ConexionBD conexion = new ConexionBD();
        private Facturas cd_facturas = new Facturas();

        public DataTable MostrarTabla()
        {
            DataTable tabla = new DataTable();
            tabla = conexion.cargarTabla("Productos");
            return tabla;
        }
    }
}
