using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArkColourTracker.Form2Databases.Startup
{
    class Start
    {
        public static void Go()
        {
            Form DatabaseForm = new Form2();
            TrackerVariables.Trackers.DatabaseForm = DatabaseForm;
            DatabaseForm.Show();


            StyleAll();
        }



        static void StyleAll() 
        {
            Form2Databases.Styling.Form2Style.Style();
            Form2Databases.Styling.Form2PageLayoutStyle.Style();
            Form2Databases.Styling.ExistingDBPanelStyle.Style();
            Form2Databases.Styling.NewDBPanelStyle.Style();

            FillDatabase();
        }

        static void FillDatabase()
        {
            Styling.ExistingListStyle.Start();
        }
    }
}
