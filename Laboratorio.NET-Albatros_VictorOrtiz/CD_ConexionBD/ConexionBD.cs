using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace CD_ConexionBD
{
    public class ConexionBD
    {
        SqlDataReader dreader;
        SqlDataAdapter dadapter;
        DataTable dtable = new DataTable();
        SqlCommand cmd = new SqlCommand();

        string conexion = "Data Source = localhost; Initial Catalog = VentasAlbatros; Integrated Security = true";
        public SqlConnection Sc = new SqlConnection();

        //METODO CONTRUCTOR
        public ConexionBD()
        {
            Sc.ConnectionString = conexion;
        }
        public SqlConnection abrir()
        {
            try
            {
                Sc.Open();
                MessageBox.Show("Conexion Abierta", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return Sc;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL ABRIR LA BASE DE DATOS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Sc;
            }
        }

        public void cerrar()
        {
            Sc.Close();
            MessageBox.Show("Conexion Cerrada", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public DataTable cargarTabla(string nomtabla)
        {
            SqlConnection conn = new SqlConnection("Data Source = localhost; Initial Catalog = VentasAlbatros; Integrated Security = true");
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "Select * from " + nomtabla;
            dreader = cmd.ExecuteReader();
            dtable.Load(dreader);
            conn.Close();
            return dtable;
        }
    }
}
