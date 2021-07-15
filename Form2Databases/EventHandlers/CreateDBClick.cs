using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArkColourTracker.Form2Databases.EventHandlers
{
    class CreateDBClick
    {
        public static void Click(Object sender, EventArgs e)
        {
            if (TrackerVariables.Trackers.DinoChoiceCB.SelectedIndex > -1)
            {
                if (TrackerVariables.Trackers.AllPlayerCreatedDBs.Contains(TrackerVariables.Trackers.DinoChoiceCB.SelectedItem.ToString()))
                {
                    MessageBox.Show("This database already exists");
                }
                else
                {
                    DataTable dt = Methods.GetDinoColourRegions.Get(TrackerVariables.Trackers.DinoChoiceCB.SelectedItem.ToString());
                    SQLITE.CreateDB.Create(dt.Rows[0]);
                    Methods.RefreshPage.Refresh();
                }
                
            }
            else
            {
                MessageBox.Show("Choose a dino type");
            }
        }
    }
}
