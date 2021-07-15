using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArkColourTracker.Form1Results;

namespace ArkColourTracker.Form1Results.Methods
{
    class GetDinoDT
    {
        public static DataTable Get(string _type)
        {
            DataTable vultDT = GetDatabase(_type);
            return vultDT;
        }

        static DataTable GetDatabase(string _type)
        {
            string query = "Select * from " + _type + ";";
            DataTable tmpDT = SQLITE.SQLiteConn.GetDT(query);
            return tmpDT;
        }
    }
}
