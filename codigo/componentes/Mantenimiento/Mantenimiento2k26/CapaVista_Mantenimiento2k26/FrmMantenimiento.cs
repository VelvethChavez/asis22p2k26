using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista_Mantenimiento2k26
{
    public partial class FrmMantenimiento : Form
    {
        public FrmMantenimiento()
        {
            InitializeComponent();
            navegador1.NavegadorMetConfigurar("tblbodegas", 4, 5);

        }

        private void BtnImprimirReporte_Click(object sender, EventArgs e)
        {
            frmReportes.FrmReporteMantenimiento reporte = new frmReportes.FrmReporteMantenimiento();
            reporte.Show();
        }
    }
}
