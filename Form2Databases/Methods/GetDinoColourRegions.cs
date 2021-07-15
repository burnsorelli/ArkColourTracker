using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArkColourTracker.Form2Databases.Methods
{
    class GetDinoColourRegions
    {
        public static DataTable Get(string _dino)
        {
            string query = "Select * from DinoColourRegions where DinoType = '" + _dino + "'";
            DataTable dt = SQLITE.SQLiteConn.GetDT(query);
            return dt;
        }
    }
}
