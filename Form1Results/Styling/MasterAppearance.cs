using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArkColourTracker.Form1Results;

namespace ArkColourTracker.Form1Results.Styling
{
    class MasterAppearance
    {
        /* FORM ATTRIBUTES */
        public static int FormWidth = 1400;
        public static int FormHeight = 1000;
        public static string FormTitle = "Ark Dino Colour Checker";

        /* PAGE LAYOUT */
        public static int HorPadding = 5;
        public static int VertPadding = 5;
        public static int InternalHPadd = 2;
        public static int InternalVPadd = 2;
        public static int ColourPanelWidth = 800;
        public static int ColourPanelHeight = 500;
        public static int TitlePanelHeight = 25;
        public static Font TitleFont = new Font("Ariel", 16);
        public static ContentAlignment TitleFontAlign = ContentAlignment.MiddleCenter;
        public static int ScrollbarWidth = 17;
        /* COLOURS */
        public static Color PanelColour = Color.DarkGray;
        public static Color TitleColour = Color.LightGray;
        public static Color ResultPanelColour = Color.AliceBlue;
        public static Color WhiteColour = Color.White;
        /* COLOUR PANEL */
        public static String ColourPanelTitleText = "All Colours";
        public static int ColourLineHeight = 20;
        public static Color CAllColoursFound = Color.Cornsilk;
        /* VULTURES PANEL */
        public static String VulturesPanelTitleText = "All Dinos";
        public static int VNumberColumns = 7;
        /* COLOUR VULTURES PANEL */
        public static String ColourVulturesPanelTitleText = "All Dinos With Chosen Colour";
        public static string NoDinoText = "You have no dinos in database";
        public static int CVColourLabelWidth = 100;
        public static int CVTitleLabelsHeight = 30;
        public static int CVColourNameLabelWidth = 100;
        public static int CVColourIDLabelWidth = 50;
        public static int CVVultureDetailsWidth = 50;
        public static int CVVultureDetailsHeight = 20;
        public static Color CVHighlightColour = Color.LightGray;
        public static Font CVHeaderFont = new Font("Ariel", 14);
        /* UPLOAD PANEL */
        public static String UploadPanelTitleText = "Upload New Dinos";
        public static String AltUploadPanelTitleText = "Find Useless Dinos";
        public static int URowHeight = 25;
        public static int UTitleRowHeight = 35;
        public static int UButtonWidth = 100;
        public static int UButtonHeight = 40;
        public static string UMsgBxText = "Upload all rows?";
        public static string USwitchButtonText = "SWITCH";
        public static Font USwitchButtonFont = new Font("Ariel", 8);
        /* USELESS PANEL */
        public static string UselessButtonText = "Find all useless";
        public static string UselessDeleteButtonText = "Delete all useless";

        public static Color UselessResultsColour = Color.PaleVioletRed;
        //public static int UselessResultsLabelWidth = 60;
        public static int UselessResultsLabelHeight = 20;
        public static int UselessResultsLabelsPerPanel = 6;
    }
}
