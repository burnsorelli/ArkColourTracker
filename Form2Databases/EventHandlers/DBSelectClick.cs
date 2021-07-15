using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArkColourTracker.Form2Databases.EventHandlers
{
    class DBSelectClick
    {
        public static void Click(Object sender, EventArgs e, string _type)
        {
            //MessageBox.Show(_type);
            ArkColourTracker.Form1Results.Methods.StartProg.Start(_type);
        }
    }
}
