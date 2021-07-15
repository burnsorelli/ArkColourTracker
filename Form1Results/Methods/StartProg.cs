using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArkColourTracker.Form1Results;

namespace ArkColourTracker.Form1Results.Methods
{
    class StartProg
    {
        public static void Start(string _type)
        {
            Styling.FormStyle.Style();
            Styling.PageLayout.Style();
            TrackerVariables.Trackers.DinoType = _type;
            TrackerVariables.Trackers.DinoList = Methods.GetDinoList.Get(_type);
            TrackerVariables.Trackers.ColourResultsPanel = Styling.InternalPanelStyle.Style(TrackerVariables.Trackers.ColourPanel,
                                             Styling.MasterAppearance.ColourPanelTitleText);
            TrackerVariables.Trackers.DinosResultsPanel = Styling.InternalPanelStyle.Style(TrackerVariables.Trackers.DinosAllPanel,
                                             Styling.MasterAppearance.VulturesPanelTitleText);
            TrackerVariables.Trackers.ColourDinoResultsPanel = Styling.InternalPanelStyle.Style(TrackerVariables.Trackers.ColourDinoPanel,
                                             Styling.MasterAppearance.ColourVulturesPanelTitleText);
            TrackerVariables.Trackers.UploadResultsPanel = Styling.InternalPanelStyle.Style(TrackerVariables.Trackers.UploadPanel,
                                             Styling.MasterAppearance.UploadPanelTitleText, true);

            Methods.GetAllColours.Get();
            
            UpdateInfo(_type);
        }

        public static void UpdateInfo(string _type)
        {
            
            Methods.GetDinoForColourList.Get();
            Styling.DinosAllResultsPanelStyle.GetDataGridData(_type);
            Styling.UploadPanelResultsStyle.Style();
            Styling.UploadPanelUselessStyle.Style();
        }
    }
}
