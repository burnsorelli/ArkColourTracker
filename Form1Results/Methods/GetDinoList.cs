using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArkColourTracker.Form1Results;

namespace ArkColourTracker.Form1Results.Methods
{
    class GetDinoList
    {
        public static List<Objects.Dino> Get(string _type)
        {
            DataTable DinoDT = GetDatabase(_type);
            List<Objects.Dino> tmpAllDinos = GetDinoObjects(DinoDT, _type);
            return tmpAllDinos;
        }
        static DataTable GetDatabase(string _type)
        {
            string query = "Select * from " + _type +";";
            DataTable tmpDT = SQLITE.SQLiteConn.GetDT(query);
            return tmpDT;
        }

        static DataTable GetColourRegions(string _type)
        {
            string query = "Select * from DinoColourRegions where DinoType = '" + _type + "';";
            DataTable tmpDT = SQLITE.SQLiteConn.GetDT(query);
            return tmpDT;
        }

        static List<Objects.Dino> GetDinoObjects(DataTable _dinoDT, string _type)
        {
            DataTable colRegions = GetColourRegions(_type);
            List<Objects.Dino> tmpDinoList = new List<Objects.Dino>();
            string reg0Name = colRegions.Rows[0][9].ToString();
            string reg1Name = colRegions.Rows[0][10].ToString();
            string reg2Name = colRegions.Rows[0][11].ToString();
            string reg3Name = colRegions.Rows[0][12].ToString();
            string reg4Name = colRegions.Rows[0][13].ToString();
            string reg5Name = colRegions.Rows[0][14].ToString();
            foreach (DataRow _row in _dinoDT.Rows)
            {
                bool _male;
                if (_row[2].ToString() == "Male")
                {
                    _male = true;
                }
                else
                {
                    _male = false;
                }
                Objects.Dino tmpDino = new Objects.Dino(_row[1].ToString(), _type, _male, Convert.ToInt32(_row[3]),
                    Convert.ToInt32(_row[4]), Convert.ToInt32(_row[5]), Convert.ToInt32(_row[6]), Convert.ToInt32(_row[7]),
                    Convert.ToInt32(_row[8]), reg0Name, reg1Name, reg2Name, reg3Name, reg4Name, reg5Name);
                tmpDinoList.Add(tmpDino);
            }
            return tmpDinoList;
        }

    }
}
