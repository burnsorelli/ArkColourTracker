using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArkColourTracker.Form2Databases.Appearance;

namespace ArkColourTracker.Form2Databases.Styling
{
    class ExistingDBPanelStyle
    {
        static Label titleLabel = new Label();
        static Panel resultsPanel = new Panel();
        static Panel containerPanel;

        public static void Style()
        {
            containerPanel = TrackerVariables.Trackers.ExisitingDBPanel;
            GetChildPanels();
            AddToControls();
            AddColours();
            PassVariables();
        }

        static void GetChildPanels()
        {
            titleLabel.Size = new Size(containerPanel.Width - 2 * MasterAppearance.InternalHPadd,
                                       MasterAppearance.TitlePanelHeight);
            titleLabel.Location = new Point(MasterAppearance.InternalHPadd, MasterAppearance.InternalVPadd);
            titleLabel.Text = MasterAppearance.ExistingDBTitle;
            titleLabel.TextAlign = MasterAppearance.TitleFontAlign;
            titleLabel.Font = MasterAppearance.TitleFont;

            resultsPanel.Size = new Size(titleLabel.Width - 2 * MasterAppearance.ExistingListPadding,
                                         containerPanel.Height - titleLabel.Height - 2 * MasterAppearance.ExistingListPadding);
            resultsPanel.Location = new Point(MasterAppearance.InternalHPadd + MasterAppearance.ExistingListPadding,
                                              titleLabel.Height + 2 * MasterAppearance.InternalVPadd + MasterAppearance.ExistingListPadding);
            resultsPanel.AutoScroll = true;
            //resultsPanel.Size = new Size(titleLabel.Width,
            //                             containerPanel.Height - titleLabel.Height - 3 * MasterAppearance.InternalVPadd);
            //resultsPanel.Location = new Point(MasterAppearance.InternalHPadd,
            //                                  titleLabel.Height + 2 * MasterAppearance.InternalVPadd);
        }
        static void AddToControls()
        {
            containerPanel.Controls.Add(titleLabel);
            containerPanel.Controls.Add(resultsPanel);
        }

        static void AddColours()
        {
            titleLabel.BackColor = Color.AliceBlue;
            resultsPanel.BackColor = Color.Aquamarine;
        }

        static void PassVariables()
        {
            TrackerVariables.Trackers.ExistingDBResultsPanel = resultsPanel;
        }
    }
}
