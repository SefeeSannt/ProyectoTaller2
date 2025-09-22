using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion.Helpers;

namespace CapaPresentacion.vistas.Administrador
{
    public partial class frmInformeVentas : Form
    {
        public frmInformeVentas()
        {
            InitializeComponent();
        }

        private void txtDni_keyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.onlyInteger(sender, e, errIngresoDatos);
        }

        private void cbCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.noWrite(sender, e);
        }
    }
}
