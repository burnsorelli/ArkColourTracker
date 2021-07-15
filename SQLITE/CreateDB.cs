using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArkColourTracker.SQLITE
{
    class CreateDB
    {
        public static void Create(DataRow _row)
        {
            List<string> regions = GetRegions(_row);
            string query = "CREATE TABLE IF NOT EXISTS " + _row[1].ToString();
            string tmpQuery = " (Dino_ID INTEGER PRIMARY KEY AUTOINCREMENT, Dino_Name STRING, Gender STRING," +
                "               Region0 INT, Region1 INT, Region2 INT, Region3 INT, Region4 INT, Region5 INT); ";
            //for (int i = 0; i < regions.Count; i++)
            //{
            //    tmpQuery += ", " + regions[i] + " INT";
            //}
            query += tmpQuery;
            //query += ");";
            CreateNew(query);

            //CheckIfAlreadyExists(_row[1].ToString());

            MessageBox.Show("Table succesfully created");
        }

        private static string LoadConnectionString(string id = "MyConnString")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
        static void CreateNew(string _query)
        {
            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(_query, cnn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
        

        static List<string> GetRegions(DataRow _row)
        {
            List<string> regions = new List<string>();
            regions.Add("Region_0");
            regions.Add("Region_1");
            regions.Add("Region_2");
            regions.Add("Region_3");
            regions.Add("Region_4");
            regions.Add("Region_5");


            
            return regions;
        }

    }
}
