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
    public partial class FrmImpuestos : Form
    {
        public FrmImpuestos()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmImpuestos_Load(object sender, EventArgs e)
        {
            CN_Impuesto imp = new CN_Impuesto();
            dgvImpuesto.DataSource = imp.mostrar();
        }

        private void dgvImpuesto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmProductos productos = new FrmProductos();
            productos.txtCodImp.Text = dgvImpuesto.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
