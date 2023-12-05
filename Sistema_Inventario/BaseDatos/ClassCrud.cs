using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Inventario.BaseDatos
{
    internal class ClassCrud : BaseDatos.ClassConexion
    {
        private SqlConnection connection;
        private string connectionString;

        
        
            Controladores.ClassMensajes mensaje = new Controladores.ClassMensajes();
            private SqlCommand com = new SqlCommand();
            private SqlDataReader reader;
            private DataTable recordset = new DataTable();

            public void executeQuery(string query, List<SqlParameter> parameters, string msg)
            {
                try
                {
                    using (com = new SqlCommand(query, ConSql_))
                    {
                        foreach (SqlParameter parameter in parameters)
                        {
                            if (!com.Parameters.Contains(parameter))
                            {
                                com.Parameters.Add(parameter);
                            }
                        }

                        ConSql_.Open();
                        com.ExecuteNonQuery();
                        com.Dispose();
                        ConSql_.Close();

                        if (!string.IsNullOrEmpty(msg))
                        {
                            mensaje.Exito(msg);
                        }
                    }
                }
                catch (SqlException Error)
                {
                    MessageBox.Show(Error.Message);
                }
                finally
                {
                    if (ConSql_.State == System.Data.ConnectionState.Open)
                    {
                        ConSql_.Close();
                    }
                }
            }

            public DataTable getInfo(string query, List<SqlParameter> parameters = null)
            {
                recordset = new DataTable();

                try
                {
                    using (com = new SqlCommand(query, ConSql_))
                    {
                        if (parameters != null)
                        {
                            foreach (SqlParameter parameter in parameters)
                            {
                                if (!com.Parameters.Contains(parameter))
                                {
                                    com.Parameters.Add(parameter);
                                }
                            }
                        }

                        ConSql_.Open();
                        reader = com.ExecuteReader();
                        recordset.Load(reader);
                        reader.Close();
                        com.Dispose();
                        ConSql_.Close();
                    }
                }
                catch (SqlException Error)
                {
                    MessageBox.Show(Error.Message);
                }
                finally
                {
                    if (ConSql_.State == System.Data.ConnectionState.Open)
                    {
                        ConSql_.Close();
                    }
                }

                return recordset;
            }
        }

    }
