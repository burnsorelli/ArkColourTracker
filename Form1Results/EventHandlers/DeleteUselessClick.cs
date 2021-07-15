using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArkColourTracker.Form1Results;

namespace ArkColourTracker.Form1Results.EventHandlers
{
    class DeleteUselessClick
    {
        public static void Click(object sender, EventArgs e)
        {
            if (TrackerVariables.Trackers.UselessList.Count > 0)
            {
                foreach (string _name in TrackerVariables.Trackers.UselessList)
                {
                    SQLITE.DeleteRows.Delete(_name);
                }
                TrackerVariables.Trackers.UselessList.Clear();
                Methods.StartProg.UpdateInfo(TrackerVariables.Trackers.DinoType);
            }
            else
            {
                MessageBox.Show("Nothing to delete");
            }
        }
    }
}
