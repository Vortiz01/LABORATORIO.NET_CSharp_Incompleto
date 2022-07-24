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
    public partial class FrmProductos : Form
    {
        CN_Productos cn_productos = new CN_Productos();

        public FrmProductos()
        {
            InitializeComponent();
        }

        public void limpiarDatos()
        {
            txtCodigo.Clear();
            txtDescrip.Clear();
            txtCantidad.Clear();
            txtPrecio.Clear();
            txtCodImp.Clear();
            rbActivo.Checked = false;
            rbInactivo.Checked = false;
        }

        public void cargarDGV()
        {
            CN_Productos cn_productos = new CN_Productos();
            dgvProductos.DataSource = cn_productos.MostrarTabla();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FrmImpuestos impuestos = new FrmImpuestos();
            impuestos.ShowDialog();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal menuPrincipal = new FrmMenuPrincipal();
            menuPrincipal.Show();
            this.Hide();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int codigo,cantidad,codImpuesto;
            string descrip,estadoProd;
            double precio;

            codigo = Int32.Parse(txtCodigo.Text);
            descrip = txtDescrip.Text;
            cantidad = Int32.Parse(txtCantidad.Text);
            precio = Double.Parse(txtPrecio.Text);

            if(rbActivo.Checked == true)
            {
                estadoProd = "Activo";
            }
            else if(rbInactivo.Checked == true)
            {
                estadoProd = "Inactivo";
            }
            else
            {
                estadoProd = "";
            }

            codImpuesto = Int32.Parse(txtCodImp.Text);

            cn_productos.InsertProd(codigo, descrip,cantidad, precio, estadoProd, codImpuesto);
            cargarDGV();
            limpiarDatos();
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            cargarDGV();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int codigo, cantidad, codImpuesto;
            string descrip, estadoProd;
            double precio;

            codigo = Int32.Parse(txtCodigo.Text);
            descrip = txtDescrip.Text;
            cantidad = Int32.Parse(txtCantidad.Text);
            precio = Double.Parse(txtPrecio.Text);

            if (rbActivo.Checked == true)
            {
                estadoProd = "Activo";
            }
            else if (rbInactivo.Checked == true)
            {
                estadoProd = "Inactivo";
            }
            else
            {
                estadoProd = "";
            }

            codImpuesto = Int32.Parse(txtCodImp.Text);

            cn_productos.UpdateProd(codigo, descrip, cantidad, precio, estadoProd, codImpuesto);
            cargarDGV();
            limpiarDatos();
        }

        private void dgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dgvProductos.CurrentRow.Cells[0].Value.ToString();
            txtDescrip.Text = dgvProductos.CurrentRow.Cells[1].Value.ToString();
            txtCantidad.Text = dgvProductos.CurrentRow.Cells[2].Value.ToString();
            txtPrecio.Text = dgvProductos.CurrentRow.Cells[3].Value.ToString();
            if (dgvProductos.CurrentRow.Cells[4].Value.ToString() == "Activo")
            {
                rbActivo.Checked = true;
            }
            else
            {
                rbInactivo.Checked = true;
            }
            txtCodImp.Text = dgvProductos.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
