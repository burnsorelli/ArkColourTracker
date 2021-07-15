using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArkColourTracker.Form1Results;


namespace ArkColourTracker.Form1Results.EventHandlers
{
    class UploadButtonClick
    {
        public static void Upload(object sender, EventArgs e, List<Panel> _rowsOnPage)
        {
            bool isGood = Methods.CheckUploadInfo.Check(_rowsOnPage);
            if (isGood)
            {
                bool isSure = Methods.MessageBoxYesNo.Get(Styling.MasterAppearance.UMsgBxText);
                if (isSure)
                {
                    Methods.AddToDB.Add(_rowsOnPage);
                    MessageBox.Show(_rowsOnPage.Count + " row(s) added to database");
                    Styling.UploadPanelResultsStyle.ClearRows();
                    //Methods.StartProg.UpdateInfo(TrackerVariables.Trackers.DinoType);
                    Methods.StartProg.Start(TrackerVariables.Trackers.DinoType);
                }

            }
            else
            {
                MessageBox.Show("The data is incomplete");
            }
        }
    }
}
