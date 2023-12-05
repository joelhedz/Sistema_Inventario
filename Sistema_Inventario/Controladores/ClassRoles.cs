using Sistema_Inventario.BaseDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Inventario.Controladores
{
    internal class ClassRoles 
    {
        private static DataTable dtFunciones_Roles = new DataTable();
        private string Rol = Controladores.ClassDatosUsuario.Rol;
        //Se crea un metodo para cargar los botones del menu, segun el rol del usuario
        public void AlCargarForm(
            Panel  panelName,
            Button Bitacora, 
            Button Cliente, 
            Button Compras, 
            Button Fatura, 
            Button Productos, 
            Button Proveedores,
            Button Usuario,
            Button Ventas)
        {
            panelName.Controls.Add(Bitacora);

            List<String> Formulario = new List<String>();
            Formulario.Add("FORMPROVEEDOR");
            Formulario.Add("FORMUSUARIO");
            Formulario.Add("FORMVENTAS");
            Formulario.Add("FORMCOMPRAS");
            Formulario.Add("FORMFACTURA");
            Formulario.Add("FORMCLIENTES");
            Formulario.Add("FORMBITACORA");
            Formulario.Add("FORMPRODUCTOS");


            Dictionary<Button, String> DicBotones = new Dictionary<Button, String>()
            {
                {Bitacora,"FORMBITACORA"},
                {Cliente,"FORMCLIENTES"},
                {Compras,"FORMCOMPRAS"},
                {Fatura,"FORMFACTURA"},
                {Productos,"FORMPRODUCTOS"},
                {Proveedores,"FORMPROVEEDOR"},
                {Usuario,"FORMUSUARIO"},
                {Ventas,"FORMVENTAS"}

            };

            //Se valida si el usuario tiene permiso para ver el formulario
            List<SqlParameter> Params = new List<SqlParameter>();
            Params.Add(new SqlParameter("@rolcode", Rol));

            BaseDatos.ClassCrud crud = new BaseDatos.ClassCrud();
            
            String Query = "SELECT func.funcDescripcion, funRol.funcEst " +
                "FROM funciones_roles as funRol " +
                "iNNER jOIN funciones as func " +
                "on func.funcCod=funRol.funcCod " +
                "WHERE rolesCod = @rolcode";
            dtFunciones_Roles = crud.getInfo(Query, Params);

            //Se recorre el listado de formularios y se valida si el usuario tiene permiso para verlo
            foreach (DataRow dr in dtFunciones_Roles.Rows)
            {
                string funCod = dr["funcDescripcion"].ToString();

                if (Formulario.Contains(funCod) && dr["funcEst"].ToString() == "ACT")
                {
                    foreach (var dicBotones in DicBotones)
                    {
                        var boton = dicBotones.Key;
                        var botonName = dicBotones.Value;

                        if(botonName == funCod)
                        {
                            boton.Visible = true;
                        }
                        

                    }
                    
                }
                
            }
            PosicionarBoton(panelName, Bitacora, Cliente, Compras, Fatura, Productos, Proveedores, Usuario, Ventas);


        }

        //Se crea un metodo para posicionar los botones en el panel
        private  void PosicionarBoton(Panel panel, params Button[] botones)
        {
            int x = -3;
            int y = 87;

            foreach (var boton in botones)
            {
               if(boton.Visible == true)
                {
                    boton.Location = new System.Drawing.Point(x, y);
                    y += boton.Height;
                    panel.Controls.Add(boton);
                }
            }
        }


        //Se crea un metodo para cargar los botones del formulario, segun el rol del usuario
        public void BotonesAccesos(Button ButtonNuevo_,Button ButtonGuardar,Button ButtonEditar ,Button ButtonEliminaroEstado,Button ButtonConfirmar, DataGridView Dgv_Name, Button ButtonReportes = null)
        {
            List<String> Mode = new List<String>();
            Mode.Add("GUARDAR");
            Mode.Add("ELIMINAR");
            Mode.Add("ACTUALIZAR");
            Mode.Add("LECTURA");
            Mode.Add("REPORTES");   

            ButtonNuevo_.Visible = false;
            ButtonGuardar.Visible = false;
            ButtonEditar.Visible = false;
            ButtonEliminaroEstado.Visible = false;
            ButtonConfirmar.Visible = false;
            Dgv_Name.Enabled = false;
            if(ButtonReportes != null)
            {
                ButtonReportes.Visible = false;
            }

            foreach (DataRow dr in dtFunciones_Roles.Rows)
            {
                string Funcion = dr["funcDescripcion"].ToString();
                if (Mode.Contains(Funcion) && dr["funcEst"].ToString() == "ACT")
                {
                    if (Funcion == "ELIMINAR")
                    {
                        ButtonEliminaroEstado.Visible = true;
                    }
                    if (Funcion == "GUARDAR")
                    {
                        ButtonNuevo_.Visible = true;
                        ButtonGuardar.Visible = true;
                        
                    }
                    if (Funcion == "ACTUALIZAR")
                    {
                        ButtonEditar.Visible = true;
                        ButtonConfirmar.Visible = true;
                    }
                    if (Funcion == "LECTURA")
                    {
                        Dgv_Name.Enabled = true;
                    }
                    if (ButtonReportes != null)
                    {
                        if (Funcion == "REPORTES")
                        {
                            ButtonReportes.Visible = false;
                        }
                    }
                }
            
            }
        }
    }
}
