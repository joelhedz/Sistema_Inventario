using Sistema_Inventario.Controladores;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Inventario.BaseDatos
{
    
    internal class ClassBitacora
    {
        BaseDatos.ClassCrud crud = new BaseDatos.ClassCrud();
        Controladores.ClassDatosUsuario datosUsuario = new Controladores.ClassDatosUsuario();
        public void InsertarBitacora(string accion)
        {
            DateTime fecha = DateTime.Now.Date;
            string fechanow = fecha.ToString("yyyy-MM-dd");
            List<SqlParameter> parametros2 = new List<SqlParameter>();
            parametros2.Add(new SqlParameter("@usuario", ClassDatosUsuario.IdUsuario));
            parametros2.Add(new SqlParameter("@accion", accion));
            parametros2.Add(new SqlParameter("@fecha", fecha));
            string sql = "INSERT INTO bitacora (fecha_hora, tipo_de_Evento, usercode) VALUES (@fecha,@accion,@usuario)";
            crud.executeQuery(sql, parametros2,"");
            
        }
 

    }
}
