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
    class Form2PageLayoutStyle
    {
        static Panel containerPanel = new Panel();
        static Panel existingPanel = new Panel();
        static Panel addNewPanel = new Panel();

        public static void Style()
        {
            GetContainerPanel();
            GetChildPanels();
            AddColours();
            AddToControls();
            PassVariables();
        }

        static void GetContainerPanel()
        {
            containerPanel.Size = new Size(TrackerVariables.Trackers.DatabaseForm.Width -
                                           2 * MasterAppearance.HorPadding,
                                           TrackerVariables.Trackers.DatabaseForm.Height -
                                           2 * MasterAppearance.VertPadding);
            containerPanel.Location = new Point(MasterAppearance.HorPadding,
                                                MasterAppearance.VertPadding);
        }

        static void GetChildPanels()
        {
            existingPanel.Size = new Size((containerPanel.Width - 3 * MasterAppearance.InternalHPadd) / 2,
                                           (containerPanel.Height - 2 * MasterAppearance.InternalVPadd));
            existingPanel.Location = new Point(MasterAppearance.InternalHPadd,
                                               MasterAppearance.InternalVPadd);
            addNewPanel.Size = new Size(existingPanel.Width, existingPanel.Height);
            addNewPanel.Location = new Point(existingPanel.Location.X + existingPanel.Width + MasterAppearance.InternalHPadd,
                                             existingPanel.Location.Y);
        }

        static void AddToControls()
        {
            TrackerVariables.Trackers.DatabaseForm.Controls.Add(containerPanel);
            containerPanel.Controls.Add(existingPanel);
            containerPanel.Controls.Add(addNewPanel);
        }

        static void AddColours()
        {
            containerPanel.BackColor = Color.Blue;
            existingPanel.BackColor = Color.Red;
            addNewPanel.BackColor = Color.Yellow;
        }

        static void PassVariables()
        {
            TrackerVariables.Trackers.ExisitingDBPanel = existingPanel;
            TrackerVariables.Trackers.NewDBPanel = addNewPanel;
        }
    }
}
