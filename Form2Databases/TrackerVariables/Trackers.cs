using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArkColourTracker.Form2Databases.TrackerVariables
{
    class Trackers
    {
        public static Form DatabaseForm;
        public static Panel ExisitingDBPanel = new Panel();
        public static Panel ExistingDBResultsPanel = new Panel();
        public static Panel NewDBPanel = new Panel();
        public static ComboBox DinoChoiceCB = new ComboBox();
        public static List<string> AllPlayerCreatedDBs = new List<string>();
    }
}
