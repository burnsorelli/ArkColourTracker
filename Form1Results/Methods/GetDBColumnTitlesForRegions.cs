using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArkColourTracker.Form1Results.Methods
{
    class GetDBColumnTitlesForRegions
    {
        public static List<string> Get(string _type)
        {
            DataTable dt = GetDT(_type);
            List<string> regionList = GetRegionTitles(dt);

            return regionList;
        }

        static DataTable GetDT(string _type)
        {
            string query = "Select * from DinoColourRegions Where DinoType = '" + _type + "'";
            DataTable dt = SQLITE.SQLiteConn.GetDT(query);
            return dt;
        }

        static List<string> GetRegionTitles(DataTable _dt)
        {
            List<string> regionsList = new List<string>();

            if (Convert.ToInt32(_dt.Rows[0][2]) == 1)
            {
                regionsList.Add(_dt.Columns[2].ColumnName);
            }
            if (Convert.ToInt32(_dt.Rows[0][3]) == 1)
            {
                regionsList.Add(_dt.Columns[3].ColumnName);
            }
            if (Convert.ToInt32(_dt.Rows[0][4]) == 1)
            {
                regionsList.Add(_dt.Columns[4].ColumnName);
            }
            if (Convert.ToInt32(_dt.Rows[0][5]) == 1)
            {
                regionsList.Add(_dt.Columns[5].ColumnName);
            }
            if (Convert.ToInt32(_dt.Rows[0][6]) == 1)
            {
                regionsList.Add(_dt.Columns[6].ColumnName);
            }
            if (Convert.ToInt32(_dt.Rows[0][7]) == 1)
            {
                regionsList.Add(_dt.Columns[7].ColumnName);
            }

            return regionsList;
        }
    }
}
