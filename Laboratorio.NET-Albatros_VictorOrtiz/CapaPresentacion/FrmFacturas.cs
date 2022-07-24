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
    public partial class FrmFacturas : Form
    {
        CN_Facturas cn_factura = new CN_Facturas();
        public FrmFacturas()
        {
            InitializeComponent();
        }

        public void cargarDGV()
        {
            CN_Facturas cn_factura = new CN_Facturas();
            dgvProductos.DataSource = cn_factura.MostrarTabla();
        }

        private void FrmFacturas_Load(object sender, EventArgs e)
        {
            cargarDGV();
            lblNumFactura.Text = "";
            lblNumDetalle.Text = "";
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal menuPrincipal = new FrmMenuPrincipal();
            menuPrincipal.Show();
            this.Hide();
        }
    }
}
