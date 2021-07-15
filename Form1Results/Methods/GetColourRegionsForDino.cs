using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArkColourTracker.Form1Results.Methods
{
    class GetColourRegionsForDino
    {
        public static List<string> Get(string _type)
        {
            DataTable dt = GetDT(_type);
            List<string> regionList = GetListRegions(dt);

            return regionList;
        }

        static DataTable GetDT(string _type)
        {
            string query = "Select * from DinoColourRegions Where DinoType = '" + _type + "'";
            DataTable dt = SQLITE.SQLiteConn.GetDT(query);
            return dt;
        }

        static List<string> GetListRegions(DataTable _dt)
        {
            List<string> regionsList = new List<string>();

            if(Convert.ToInt32(_dt.Rows[0][2]) == 1)
            {
                regionsList.Add(_dt.Rows[0][9].ToString());
            }
            if (Convert.ToInt32(_dt.Rows[0][3]) == 1)
            {
                regionsList.Add(_dt.Rows[0][10].ToString());
            }
            if (Convert.ToInt32(_dt.Rows[0][4]) == 1)
            {
                regionsList.Add(_dt.Rows[0][11].ToString());
            }
            if (Convert.ToInt32(_dt.Rows[0][5]) == 1)
            {
                regionsList.Add(_dt.Rows[0][12].ToString());
            }
            if (Convert.ToInt32(_dt.Rows[0][6]) == 1)
            {
                regionsList.Add(_dt.Rows[0][13].ToString());
            }
            if (Convert.ToInt32(_dt.Rows[0][7]) == 1)
            {
                regionsList.Add(_dt.Rows[0][14].ToString());
            }

            return regionsList;
        }
    }
}
