using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CD_ConexionBD;

namespace CapaNegocio
{
    public class CN_Impuesto
    {
        private ConexionBD objeto = new ConexionBD();

        SqlDataReader dreader;
        SqlDataAdapter dadapter;
        DataTable dtable = new DataTable();
        SqlCommand cmd = new SqlCommand();

        public DataTable mostrar()
        {
            DataTable tabla = new DataTable();
            tabla = objeto.cargarTabla("Impuestos");
            return tabla;
        }
    }
}
