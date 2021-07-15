using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArkColourTracker.Form1Results;

namespace ArkColourTracker.SQLITE
{
    class SQLiteAdd
    {
        //public static void Add(string _name, string _gender, int _body, int _head, int _face, int _tips)
        //{
        //    using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
        //    {
        //        cnn.Open();
        //        string _query = "Insert into My_Vultures (Dino_Name, Gender, Body, Head, Face, Tips) values" +
        //                        " (@Dino_Name, @Gender, @Body, @Head, @Face, @Tips)";
        //        using (SQLiteCommand cmd = new SQLiteCommand(_query, cnn))
        //        {
        //            cmd.Parameters.AddWithValue("@Dino_Name", _name);
        //            cmd.Parameters.AddWithValue("@Gender", _gender);
        //            cmd.Parameters.AddWithValue("@Body", _body);
        //            cmd.Parameters.AddWithValue("@Head", _head);
        //            cmd.Parameters.AddWithValue("@Face", _face);
        //            cmd.Parameters.AddWithValue("@Tips", _tips);

        //            cmd.ExecuteNonQuery();
        //        }


        //    }
        //}

        public static void Add(string _name, string _gender, int _region0 = 0, int _region1 = 0, int _region2 = 0, int _region3 = 0, int _region4 = 0, int _region5 = 0)
        {
            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Open();
                string _query = "Insert into " + Form1Results.TrackerVariables.Trackers.DinoType + " (Dino_Name, Gender, Region0, Region1, Region2, Region3, Region4, Region5) values" +
                                " (@Dino_Name, @Gender, @Region0, @Region1, @Region2, @Region3, @Region4, @Region5)";
                using (SQLiteCommand cmd = new SQLiteCommand(_query, cnn))
                {
                    cmd.Parameters.AddWithValue("@Dino_Name", _name);
                    cmd.Parameters.AddWithValue("@Gender", _gender);
                    cmd.Parameters.AddWithValue("@Region0", _region0);
                    cmd.Parameters.AddWithValue("@Region1", _region1);
                    cmd.Parameters.AddWithValue("@Region2", _region2);
                    cmd.Parameters.AddWithValue("@Region3", _region3);
                    cmd.Parameters.AddWithValue("@Region4", _region4);
                    cmd.Parameters.AddWithValue("@Region5", _region5);

                    cmd.ExecuteNonQuery();
                }


            }
        }

        private static string LoadConnectionString(string id = "MyConnString")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
