using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Inventario.Controladores
{
    internal class ClassDatosUsuario
    {
        public static string Usuario;
        public static string Rol;

        public ClassDatosUsuario()
        {
        }

        public ClassDatosUsuario(string usuario_, string rol_)
        {
            Usuario = usuario_;
            Rol = rol_;
        }
    }

}
