﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Inventario.BaseDatos
{
    internal class ClassDatosSql
    {
        private static string SERVERNAME = "HP-JOEL";
        private static string DATABASE = "alphaInventary";
        private static string USER = "JoelHerndz";
        private static string PASSWORD = "joel13";

        public static string ServerNam_
        {
            get { return SERVERNAME; }
            set { SERVERNAME = value; }
        }

        public static string DB_
        {
            get { return DATABASE; }
            set { DATABASE = value; }
        }

        public static string user_
        {
            get { return USER; }
            set { USER = value; }
        }

        public static string pswd_
        {
            get { return PASSWORD; }
            set { PASSWORD = value; }
        }
    }
}
