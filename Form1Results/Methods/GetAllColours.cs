using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArkColourTracker.Form1Results;


namespace ArkColourTracker.Form1Results.Methods
{
    class GetAllColours
    {
        public static void Get()
        {
            if (TrackerVariables.Trackers.ColourPanelPanelsList.Count > 0)
            {
                TrackerVariables.Trackers.ColourPanelPanelsList.Clear();
            }
            List<int> colourIDList = new List<int>();
            int count = 1;
            string query = "select * from Colours;";
            DataTable Colours = SQLITE.SQLiteConn.GetDT(query);
            foreach (DataRow _row in Colours.Rows)
            {
                Color _colour = ColorTranslator.FromHtml(_row[2].ToString());
                Styling.ColoursResultsPanelStyle.GetEachLine(_colour, count, _row[1].ToString(), Convert.ToInt32(_row[3]));
                colourIDList.Add(Convert.ToInt32(_row[3]));
                count++;
            }
            TrackerVariables.Trackers.ColourIDList = colourIDList;
        }
    }
}
