using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArkColourTracker.Form1Results;


namespace ArkColourTracker.Form1Results.EventHandlers
{
    class SwitchUploadPanelClick
    {
        public static void Click(object sender, EventArgs e)
        {
            if (TrackerVariables.Trackers.CurrentActiveUploadPanel == TrackerVariables.Trackers.UploadResultsPanel)
            {
                TrackerVariables.Trackers.UploadResultsPanel.Visible = false;
                TrackerVariables.Trackers.CurrentActiveUploadPanel = TrackerVariables.Trackers.FindUselessPanel;
                TrackerVariables.Trackers.FindUselessPanel.Visible = true;
                TrackerVariables.Trackers.UploadTitlePanel.Text = Styling.MasterAppearance.AltUploadPanelTitleText;
            }
            else
            {
                TrackerVariables.Trackers.UploadResultsPanel.Visible = true;
                TrackerVariables.Trackers.FindUselessPanel.Visible = false;
                TrackerVariables.Trackers.UploadTitlePanel.Text = Styling.MasterAppearance.UploadPanelTitleText;
                TrackerVariables.Trackers.CurrentActiveUploadPanel = TrackerVariables.Trackers.UploadResultsPanel;
                TrackerVariables.Trackers.UselessResultsPanel.Controls.Clear();
            }
        }
    }
}
