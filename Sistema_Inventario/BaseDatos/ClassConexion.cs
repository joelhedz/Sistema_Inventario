using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Sistema_Inventario.BaseDatos
{
    internal class ClassConexion : BaseDatos.ClassDatosSql
    {

        public static string ConnectionString = "Server=" + ServerNam_ + ";Database=" + DB_ + ";User id=" + user_ + ";Password=" + pswd_ + ";";

        private static SqlConnection ConSql = new SqlConnection(ConnectionString);

        public static SqlConnection ConSql_
        {
            get { return ConSql; }
            set { ConSql = value; }
        }

        public static void OpenConnection()
        {
            try
            {
                ConSql.Open();
            }
            catch (SqlException Error)
            {
                MessageBox.Show(Error.Message);
            }
        }

        public static void CloseConnection()
        {
            try
            {
                ConSql.Close();
            }
            catch (SqlException Error)
            {
                MessageBox.Show(Error.Message);
            }
        }

        public static void EndConnection()
        {
            if (ConSql.State == System.Data.ConnectionState.Open)
            {
                ConSql.Close();
            }
        }
    }
}

