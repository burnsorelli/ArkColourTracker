using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArkColourTracker.Form2Databases.Methods
{
    class GetAllDatabases
    {
        public static void Get()
        {
            TrackerVariables.Trackers.AllPlayerCreatedDBs.Clear();
            List<String> dbList = new List<string>();

            string query = "select name from sqlite_master where type='table'";
            DataTable dt = SQLITE.SQLiteConn.GetDT(query);
            foreach(DataRow _row in dt.Rows)
            {
                if(_row[0].ToString() != "Colours" &&
                    _row[0].ToString() != "DinoColourRegions" &&
                    _row[0].ToString() != "sqlite_sequence")
                {
                    dbList.Add(_row[0].ToString());
                }
            }
            TrackerVariables.Trackers.AllPlayerCreatedDBs = dbList;
            
        }
    }
}
