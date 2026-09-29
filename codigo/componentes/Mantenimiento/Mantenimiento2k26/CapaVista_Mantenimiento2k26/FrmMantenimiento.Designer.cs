namespace CapaVista_Mantenimiento2k26
{
    partial class FrmMantenimiento
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
            this.navegador1 = new CapaVista_Navegador.Navegador();
            this.BtnImprimirReporte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(11, 11);
            this.navegador1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1078, 90);
            this.navegador1.TabIndex = 0;
            // 
            // BtnImprimirReporte
            // 
            this.BtnImprimirReporte.BackColor = System.Drawing.Color.IndianRed;
            this.BtnImprimirReporte.ForeColor = System.Drawing.Color.White;
            this.BtnImprimirReporte.Location = new System.Drawing.Point(1017, 106);
            this.BtnImprimirReporte.Name = "BtnImprimirReporte";
            this.BtnImprimirReporte.Size = new System.Drawing.Size(63, 57);
            this.BtnImprimirReporte.TabIndex = 1;
            this.BtnImprimirReporte.Text = "Imprimir Reporte";
            this.BtnImprimirReporte.UseVisualStyleBackColor = false;
            this.BtnImprimirReporte.Click += new System.EventHandler(this.BtnImprimirReporte_Click);
            // 
            // FrmMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 749);
            this.Controls.Add(this.BtnImprimirReporte);
            this.Controls.Add(this.navegador1);
            this.Name = "FrmMantenimiento";
            this.Text = "FrmMantenimiento";
            this.ResumeLayout(false);

        }

        #endregion

        private CapaVista_Navegador.Navegador navegador1;
        private System.Windows.Forms.Button BtnImprimirReporte;
    }
}