using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArkColourTracker.Form1Results;

namespace ArkColourTracker.Form1Results.EventHandlers
{
    class ClearUploadRows
    {
        public static void Clear(object sender, EventArgs e)
        {
            Styling.UploadPanelResultsStyle.ClearRows();
            Methods.MessageBoxYesNo.Get();

        }
    }
}
