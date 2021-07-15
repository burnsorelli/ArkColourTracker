using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArkColourTracker.Form2Databases.Appearance
{
    class MasterAppearance
    {
        public static int FormWidth = 1400;
        public static int FormHeight = 1000;
        public static string DBFormTitle = "Open or Create New Database";
        public static int InternalHPadd = 2;
        public static int InternalVPadd = 2;
        public static int TitlePanelHeight = 25;
        public static string ExistingDBTitle = "List of all existing databases";
        public static Font TitleFont = new Font("Ariel", 16);
        public static ContentAlignment TitleFontAlign = ContentAlignment.MiddleCenter;
        public static string NewDBTitle = "Create new database";
        public static string NewDBInstructions = "Choose dino from dropdown";
        public static int NewDBInstructionHeight = 50;
        public static int UButtonHeight = 40;
        public static int UButtonWidth = 100;
        public static string NewDBCreateButtonText = "Create new Database";
        public static string NewDBGetDinoQuery = "Select DinoType from DinoColourRegions where CanBreed = 1";
        public static int HorPadding = 5;
        public static int VertPadding = 5;
        public static int DatabaseListHeight = 25;
        public static string chooseDBButtonText = "Select";
        public static string deleteDBButtonText = "Delete";
        public static int ExistingListPadding = 30;
        public static int ScrollbarWidth = 17;
        public static Font ButtonFont = new Font("Ariel", 10, FontStyle.Bold);
        public static Font NewDBInstructionFont = new Font("Ariel", 12);
    }
}
