using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArkColourTracker.Form1Results;

namespace ArkColourTracker.Form1Results.EventHandlers
{
    class ColourPanelColourClick
    {
        public static void Click(object sender, EventArgs e, Color _colour, string _name, string _id)
        {
            List<Objects.Dino> tmpList = Methods.GetDinoForColourList.GetListDinosWithColour(Convert.ToInt32(_id));
            Styling.ColourDinoResultsPanelStyle.AddData(tmpList, _colour, _name, _id);
        }
    }
}
