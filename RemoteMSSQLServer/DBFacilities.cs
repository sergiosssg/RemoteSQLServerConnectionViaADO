using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteMSSQLServer
{
    public partial class DBFacilities
    {
        public static string GetConnectionString()
        {
            DbConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder["Data Source"] = @"xplandev\DEVMAIN";         //  Office setting string for development  MS SQL DB in interprise server
            //builder["Data Source"] = "localhost";               //  Office setting string for local MS SQL DB
            //builder["Data Source"] = @"localhost\SQLExpress";   //  Home setting string for local MS SQL DB


            builder["Database"] = "SM";                            //  Office setting string for development  MS SQL DB in interprise server
            //builder["Database"] = "sampd_cexs";                  //  Office and Home setting string for local MS SQL DB

            builder["integrated Security"] = "true";

            return builder.ConnectionString;
        }
    }
}
