using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibTeam04.Data.Framework
{
    public static class LocalSettings
    {
        public static string GetConnectionString()
        {
            string connectionString = "Trusted_Connection=True;";
            //string connectionString = "user id = pxluser;";
            //connectionString += "Password = pxluser;";
            connectionString += $@"Server=DESKTOP-JEALUUV\SQLEXPRESS;";
            connectionString += $"Database=DB_Tuintje";
            return connectionString;
        }
    }
}
