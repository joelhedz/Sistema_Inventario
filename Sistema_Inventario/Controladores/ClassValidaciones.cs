using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Sistema_Inventario.Controladores
{
    internal class ClassValidaciones
    {
        public int contError;

        public void ValidarText(ErrorProvider error,TextBox text)
        {
            if(text.Text == "")
            {
                error.SetError(text, "Campo Obligatorio");
                text.Focus();
                contError++;
                return;
            }
        }

        public void validarTel(ErrorProvider error, MaskedTextBox tel)
        {
            if (tel.Text == "")
            {
                error.SetError(tel, "Campo Obligatorio");
                tel.Focus();
                contError++;
                return;
            }
        }

        public void validarEmail(ErrorProvider error, TextBox email)
        {
            string emailString =  email.Text;
            if (!Regex.IsMatch(emailString,@"^[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,6}$"))
            {
                error.SetError(email, "Formato de correo incorrecto");
                email.Focus();
                contError++;
                return;
            }
            else if(email.Text == "")
            {
                error.SetError(email, "Campo Obligatorio");
                email.Focus();
                contError++;
                return;
            }   
        }
    }
}
