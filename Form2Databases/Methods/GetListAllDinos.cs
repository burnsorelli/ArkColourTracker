using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArkColourTracker.Form2Databases.Appearance;

namespace ArkColourTracker.Form2Databases.Methods
{
    class GetListAllDinos
    {
        static string query;

        public static List<String> GetDinos()
        {
            query = MasterAppearance.NewDBGetDinoQuery;
            List<string> dinoList = new List<string>();

            DataTable dinos = SQLITE.SQLiteConn.GetDT(query);

            foreach (DataRow _row in dinos.Rows)
            {
                dinoList.Add(_row[0].ToString());
            }


            return dinoList;
        }
    }
}
