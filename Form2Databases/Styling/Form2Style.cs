using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArkColourTracker.Form2Databases.Styling
{
    class Form2Style
    {
        static Form dbForm;
        public static void Style()
        {
            dbForm = TrackerVariables.Trackers.DatabaseForm;
            dbForm.Size = new Size(Appearance.MasterAppearance.FormWidth,
                                    Appearance.MasterAppearance.FormHeight);
            dbForm.Text = Appearance.MasterAppearance.DBFormTitle;
            //Styling.Form2.PageLayout.Style();
            //Styling.Form2.ExistingDatabasePanelStyle.Style();
            //Styling.Form2.NewDatabasePanelStyle.Style();
        }
    }
}
