using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using CD_ConexionBD;

namespace CD_Clientes
{
    public class Clientes
    {
        SqlDataReader dreader;
        SqlDataAdapter dadapter;
        DataTable dtable = new DataTable();
        SqlCommand cmd = new SqlCommand();

        private ConexionBD conexion = new ConexionBD();

        private int _codigo;
        private string _nombre;
        private string _rtn;
        private string _direccion;
        private string _estado;

        public int Codigo { get => _codigo; set => _codigo = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Rtn { get => _rtn; set => _rtn = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public string Estado { get => _estado; set => _estado = value; }

        public void Insertar_Cliente()
        {
            try
            {
                cmd = new SqlCommand("sp_InsertCliente");
                cmd.Connection = conexion.abrir();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codigo", _codigo);
                cmd.Parameters.AddWithValue("@nombre", _nombre);
                cmd.Parameters.AddWithValue("@rtn", _rtn);
                cmd.Parameters.AddWithValue("@direccion", _direccion);
                cmd.Parameters.AddWithValue("@estado", _estado);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente Insertado Correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL REGISTRAR EL CLIENTE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.cerrar();
            }
        }

        public void Editar_Cliente()
        {
            try
            {
                cmd = new SqlCommand("sp_UpdateCliente");
                cmd.Connection = conexion.abrir();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codigo", _codigo);
                cmd.Parameters.AddWithValue("@nombre", _nombre);
                cmd.Parameters.AddWithValue("@rtn", _rtn);
                cmd.Parameters.AddWithValue("@direccion", _direccion);
                cmd.Parameters.AddWithValue("@estado", _estado);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente Actualizado Correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL ACTUALIZAR EL CLIENTE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.cerrar();
            }
        }
    }
}
