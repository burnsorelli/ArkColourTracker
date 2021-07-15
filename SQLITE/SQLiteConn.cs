using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace ArkColourTracker.SQLITE
{
    class SQLiteConn
    {
        private static string LoadConnectionString(string id = "MyConnString")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
        public static DataTable GetDT(string _query)
        {
            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                DataTable dt = new DataTable();
                SQLiteCommand cmd = new SQLiteCommand(_query, cnn);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                da.Fill(dt);

                return dt;
            }
        }

        //public static int GetInt(string _query)
        //{
        //    using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
        //    {
        //        DataTable dt = new DataTable();
        //        SQLiteCommand cmd = new SQLiteCommand(_query, cnn);
        //        SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
        //        da.Fill(dt);



        //        return intRes;
        //    }
        //}
    }
}
