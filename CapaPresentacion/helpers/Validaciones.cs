using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Helpers
{
    public static class Validaciones
    {
        public static void onlyLetters(object sender, KeyPressEventArgs e, ErrorProvider error)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
                error.SetError((Control)sender, "Solo se permiten letras");
            }
        }

        public static void onlyNumbers(object sender, KeyPressEventArgs e, ErrorProvider error)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
                error.SetError((Control)sender, "Solo se permiten numeros");
            }
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
                error.SetError((Control)sender, "Solo se permite un punto decimal");
            }
        }

        public static void onlyInteger(object sender, KeyPressEventArgs e, ErrorProvider error)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                error.SetError((Control)sender, "Solo se permiten numeros enteros");
            }
        }

        public static void noWrite(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

    }
}
