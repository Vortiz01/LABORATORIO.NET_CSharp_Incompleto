using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using CD_ConexionBD;

namespace CD_Productos
{
    public class Productos
    {
        SqlDataReader dreader;
        SqlDataAdapter dadapter;
        DataTable dtable = new DataTable();
        SqlCommand cmd = new SqlCommand();

        private ConexionBD conexion = new ConexionBD();

        private int _codigo;
        private string _descripcion;
        private int _cantidad;
        private double _precio;
        private string _estado;
        private int _codImpuesto;

        //public Productos(int codigo, string descripcion, double precio, string estado, int codImpuesto)
        //{
        //    this._codigo = codigo;
        //    this._descripcion = descripcion;
        //    this._precio = precio;
        //    this._estado = estado;
        //    this._codImpuesto = codImpuesto;
        //}

        public int Codigo { get => _codigo; set => _codigo = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public int Cantidad { get => _cantidad; set => _cantidad = value; }
        public double Precio { get => _precio; set => _precio = value; }
        public string Estado { get => _estado; set => _estado = value; }
        public int CodImpuesto { get => _codImpuesto; set => _codImpuesto = value; }

        public void Insertar_Producto()
        {
            try
            {
                cmd = new SqlCommand("sp_InsertProducto");
                cmd.Connection = conexion.abrir();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codigo", _codigo);
                cmd.Parameters.AddWithValue("@descripcion", _descripcion);
                cmd.Parameters.AddWithValue("@cantidad", _cantidad);
                cmd.Parameters.AddWithValue("@precio", _precio);
                cmd.Parameters.AddWithValue("@estado", _estado);
                cmd.Parameters.AddWithValue("@codImpuesto", _codImpuesto);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Producto Insertado Correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR AL REGISTRAR EL PRODUCTO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.cerrar();
            }
        }

        public void Editar_Producto()
        {
            try
            {
                cmd = new SqlCommand("sp_UpdateProducto");
                cmd.Connection = conexion.abrir();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codigo", _codigo);
                cmd.Parameters.AddWithValue("@descripcion", _descripcion);
                cmd.Parameters.AddWithValue("@cantidad", _cantidad);
                cmd.Parameters.AddWithValue("@precio", _precio);
                cmd.Parameters.AddWithValue("@estado", _estado);
                cmd.Parameters.AddWithValue("@codImpuesto", _codImpuesto);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Producto Actualizado Correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL ACTUALIZAR EL PRODUCTO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.cerrar();
            }
        }
    }
}
