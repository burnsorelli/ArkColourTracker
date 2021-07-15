using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArkColourTracker.Form1Results.TrackerVariables
{
    class Trackers
    {
        /* FORM */
        public static Form TheForm;
        /* PANELS */
        public static Panel ContainAllPanel = new Panel();
        public static Panel ColourPanel = new Panel();
        public static Panel DinosAllPanel = new Panel();
        public static Panel ColourDinoPanel = new Panel();
        public static Panel UploadPanel = new Panel();
        public static Panel ColourResultsPanel = new Panel();
        public static Panel DinosResultsPanel = new Panel();
        public static Panel ColourDinoResultsPanel = new Panel();
        public static Panel UploadResultsPanel = new Panel();
        public static Panel FindUselessPanel = new Panel();
        public static Panel CurrentActiveUploadPanel = new Panel();
        public static Label UploadTitlePanel = new Label();
        public static Panel UselessResultsPanel = new Panel();
        public static List<string> UselessList = new List<string>();

        public static List<int> ColourIDList = new List<int>();
        //public static List<Label> ColourPanelLabelsList = new List<Label>();
        public static List<Panel> ColourPanelPanelsList = new List<Panel>();
        //public static List<Objects.Vulture> DinoList = new List<Objects.Vulture>();
        public static List<Objects.Dino> DinoList = new List<Objects.Dino>();
        public static string DinoType;
    }
}
