using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SQLite;

namespace WebApp2
{
    public static class Dbconnection
    {
        private static string connectionString = "C:/Users/Kanaki/source/repos/WebApp2/bin/WebApp2.db";
        static readonly SQLiteConnection con = new SQLiteConnection($"Data Source={connectionString};");
        public static SQLiteConnection GetConnection()
        {
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
            return con;



        }
    }
}