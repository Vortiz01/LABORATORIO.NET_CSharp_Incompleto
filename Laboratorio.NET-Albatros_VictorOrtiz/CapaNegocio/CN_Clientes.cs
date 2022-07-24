using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CD_ConexionBD;
using CD_Clientes;

namespace CapaNegocio
{
    public class CN_Clientes
    {
        DataTable dtable = new DataTable();
        SqlCommand cmd = new SqlCommand();

        private ConexionBD conexion = new ConexionBD();
        private Clientes cd_clientes = new Clientes();

        public DataTable MostrarTabla()
        {
            DataTable tabla = new DataTable();
            tabla = conexion.cargarTabla("Clientes");
            return tabla;
        }

        public void InsertCli(int codigo, string nombre, string rtn, string direccion, string estado)
        {
            cd_clientes.Codigo = codigo;
            cd_clientes.Nombre = nombre;
            cd_clientes.Rtn = rtn;
            cd_clientes.Direccion = direccion;
            cd_clientes.Estado = estado;
            cd_clientes.Insertar_Cliente();
        }

        public void UpdateCli(int codigo, string nombre, string rtn, string direccion, string estado)
        {
            cd_clientes.Codigo = codigo;
            cd_clientes.Nombre = nombre;
            cd_clientes.Rtn = rtn;
            cd_clientes.Direccion = direccion;
            cd_clientes.Estado = estado;
            cd_clientes.Editar_Cliente();
        }
    }
}
