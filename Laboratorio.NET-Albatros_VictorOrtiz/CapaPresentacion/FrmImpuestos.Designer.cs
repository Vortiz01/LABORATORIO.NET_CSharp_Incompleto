
namespace CapaPresentacion
{
    partial class FrmImpuestos
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
            this.dgvImpuesto = new System.Windows.Forms.DataGridView();
            this.btnRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImpuesto)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvImpuesto
            // 
            this.dgvImpuesto.AllowUserToAddRows = false;
            this.dgvImpuesto.AllowUserToDeleteRows = false;
            this.dgvImpuesto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImpuesto.Location = new System.Drawing.Point(0, 0);
            this.dgvImpuesto.Name = "dgvImpuesto";
            this.dgvImpuesto.ReadOnly = true;
            this.dgvImpuesto.Size = new System.Drawing.Size(319, 286);
            this.dgvImpuesto.TabIndex = 1;
            this.dgvImpuesto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvImpuesto_CellDoubleClick);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(99, 291);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(111, 31);
            this.btnRegresar.TabIndex = 2;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // FrmImpuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 328);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.dgvImpuesto);
            this.Name = "FrmImpuestos";
            this.Text = "FrmImpuestos";
            this.Load += new System.EventHandler(this.FrmImpuestos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvImpuesto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRegresar;
        public System.Windows.Forms.DataGridView dgvImpuesto;
    }
}