using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Inventario.Controladores
{
    internal class ClassMensajes
    {
        public void Aviso(string mensaje)
        {
            MessageBoxButtons opciones = MessageBoxButtons.OK;
            MessageBoxIcon icono = MessageBoxIcon.Warning;
            MessageBox.Show(mensaje, "Atencion", opciones, icono);

        }
        public void Exito(string mensaje)
        {
            MessageBoxButtons opciones = MessageBoxButtons.OK;
            MessageBoxIcon icono = MessageBoxIcon.Information;
            MessageBox.Show(mensaje, "Atendion", opciones, icono);

        }

        public bool Confirmar(string msg)
        {
            bool respuesta = false;
            MessageBoxButtons opciones = MessageBoxButtons.YesNo;
            MessageBoxIcon icono = MessageBoxIcon.Question;
            if (MessageBox.Show(msg, "Confirmar", opciones, icono) == DialogResult.Yes)
            {
                respuesta = true;
            }
            else
            {

            }
            return respuesta;
        }
    }
}
