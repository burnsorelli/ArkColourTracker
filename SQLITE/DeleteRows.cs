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
    class DeleteRows
    {
        public static void Delete(string _name)
        {
            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Open();
                string _query = "DELETE FROM "+ Form1Results.TrackerVariables.Trackers.DinoType +" WHERE Dino_Name = @Dino_Name";
                using (SQLiteCommand cmd = new SQLiteCommand(_query, cnn))
                {
                    cmd.Parameters.AddWithValue("@Dino_Name", _name);

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
