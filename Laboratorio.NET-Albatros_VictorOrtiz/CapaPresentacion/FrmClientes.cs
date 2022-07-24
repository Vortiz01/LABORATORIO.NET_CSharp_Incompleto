using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmClientes : Form
    {
        CN_Clientes cn_clientes = new CN_Clientes();
        public FrmClientes()
        {
            InitializeComponent();
        }

        public void limpiarDatos()
        {
            txtCodigo.Clear();
            txtRTN.Clear();
            txtDireccion.Clear();
            txtNombre.Clear();
            rbActivo.Checked = false;
            rbInactivo.Checked = false;
        }
        public void cargarDGV()
        {
            CN_Clientes cn_clientes = new CN_Clientes();
            dgvClientes.DataSource = cn_clientes.MostrarTabla();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            cargarDGV();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal menuPrincipal = new FrmMenuPrincipal();
            menuPrincipal.Show();
            this.Hide();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int codigo;
            string nombre, rtn, direccion, estadoCli;

            codigo = Int32.Parse(txtCodigo.Text);
            nombre = txtNombre.Text;
            rtn = txtRTN.Text;
            direccion = txtDireccion.Text;

            if (rbActivo.Checked == true)
            {
                estadoCli = "Activo";
            }
            else if (rbInactivo.Checked == true)
            {
                estadoCli = "Inactivo";
            }
            else
            {
                estadoCli = "";
            }

            cn_clientes.InsertCli(codigo, nombre, rtn, direccion, estadoCli);
            cargarDGV();
            limpiarDatos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int codigo;
            string nombre, rtn, direccion, estadoCli;

            codigo = Int32.Parse(txtCodigo.Text);
            nombre = txtNombre.Text;
            rtn = txtRTN.Text;
            direccion = txtDireccion.Text;

            if (rbActivo.Checked == true)
            {
                estadoCli = "Activo";
            }
            else if (rbInactivo.Checked == true)
            {
                estadoCli = "Inactivo";
            }
            else
            {
                estadoCli = "";
            }

            cn_clientes.UpdateCli(codigo, nombre, rtn, direccion, estadoCli);
            cargarDGV();
            limpiarDatos();
        }

        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dgvClientes.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dgvClientes.CurrentRow.Cells[1].Value.ToString();
            txtRTN.Text = dgvClientes.CurrentRow.Cells[2].Value.ToString();
            txtDireccion.Text = dgvClientes.CurrentRow.Cells[3].Value.ToString();
            if (dgvClientes.CurrentRow.Cells[4].Value.ToString() == "Activo")
            {
                rbActivo.Checked = true;
            }
            else
            {
                rbInactivo.Checked = true;
            }
            
        }
    }
}
