
namespace CapaPresentacion
{
    partial class FrmReportes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRpClientes = new System.Windows.Forms.Button();
            this.btnRpProductos = new System.Windows.Forms.Button();
            this.btnRpFacturas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRpClientes
            // 
            this.btnRpClientes.Location = new System.Drawing.Point(61, 41);
            this.btnRpClientes.Name = "btnRpClientes";
            this.btnRpClientes.Size = new System.Drawing.Size(137, 31);
            this.btnRpClientes.TabIndex = 0;
            this.btnRpClientes.Text = "Reporte Clientes";
            this.btnRpClientes.UseVisualStyleBackColor = true;
            // 
            // btnRpProductos
            // 
            this.btnRpProductos.Location = new System.Drawing.Point(61, 126);
            this.btnRpProductos.Name = "btnRpProductos";
            this.btnRpProductos.Size = new System.Drawing.Size(137, 31);
            this.btnRpProductos.TabIndex = 1;
            this.btnRpProductos.Text = "Reporte Productos";
            this.btnRpProductos.UseVisualStyleBackColor = true;
            // 
            // btnRpFacturas
            // 
            this.btnRpFacturas.Location = new System.Drawing.Point(61, 206);
            this.btnRpFacturas.Name = "btnRpFacturas";
            this.btnRpFacturas.Size = new System.Drawing.Size(137, 31);
            this.btnRpFacturas.TabIndex = 2;
            this.btnRpFacturas.Text = "Reporte Facturas";
            this.btnRpFacturas.UseVisualStyleBackColor = true;
            // 
            // FrmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 290);
            this.Controls.Add(this.btnRpFacturas);
            this.Controls.Add(this.btnRpProductos);
            this.Controls.Add(this.btnRpClientes);
            this.Name = "FrmReportes";
            this.Text = "FrmReportes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRpClientes;
        private System.Windows.Forms.Button btnRpProductos;
        private System.Windows.Forms.Button btnRpFacturas;
    }
}