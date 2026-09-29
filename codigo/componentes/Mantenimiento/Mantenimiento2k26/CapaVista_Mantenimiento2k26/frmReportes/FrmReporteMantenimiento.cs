using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista_Mantenimiento2k26.frmReportes
{
    public partial class FrmReporteMantenimiento : Form
    {
        public FrmReporteMantenimiento()
        {
            InitializeComponent();
        }

        private void FrmReporteMantenimiento_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
