using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Inventario.Controladores
{
    internal class ClassDatosUsuario
    {
        public static int IdUsuario;
        public static string Usuario;
        public static string Rol;

        public ClassDatosUsuario()
        {
        }

        public ClassDatosUsuario(int idUser_ ,string usuario_, string rol_)
        {
            IdUsuario = idUser_;
            Usuario = usuario_;
            Rol = rol_;
        }
    }

}
