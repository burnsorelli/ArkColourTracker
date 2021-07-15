using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArkColourTracker.Form1Results;


namespace ArkColourTracker.Form1Results.EventHandlers
{
    class UploadAddRowButtonClick
    {
        public static void Add(object sender, EventArgs e)
        {
            Styling.UploadPanelResultsStyle.AddRow();
        }
    }
}
