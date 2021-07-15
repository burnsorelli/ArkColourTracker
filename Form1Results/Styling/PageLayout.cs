using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArkColourTracker.Form1Results;

namespace ArkColourTracker.Form1Results.Styling
{
    class PageLayout
    {
        static Panel containerPanel = new Panel();
        static Panel coloursPanel = new Panel();
        static Panel dinosPanel = new Panel();
        static Panel colourVultPanel = new Panel();
        static Panel uploadPanel = new Panel();
        public static void Style()
        {
            containerPanel.Size = GetContainerSize();
            GetChildPanelSizePosition();
            GetColours();

            AddToControls();
            PassVariables();
        }

        static Size GetContainerSize()
        {
            int containerWidth = TrackerVariables.Trackers.TheForm.ClientSize.Width;
            int containerHeight = TrackerVariables.Trackers.TheForm.ClientSize.Height;
            Size tmpSize = new Size(containerWidth, containerHeight);
            return tmpSize;
        }

        static void GetChildPanelSizePosition()
        {
            int hPadd = Styling.MasterAppearance.HorPadding;
            int vPadd = Styling.MasterAppearance.VertPadding;
            coloursPanel.Location = new Point(hPadd, vPadd);
            int width = Styling.MasterAppearance.ColourPanelWidth;
            int height = Styling.MasterAppearance.ColourPanelHeight;
            coloursPanel.Size = new Size(width, height);

            dinosPanel.Location = new Point(coloursPanel.Width + 2 * hPadd,
                                               vPadd);
            dinosPanel.Size = new Size(containerPanel.Width - coloursPanel.Width - 3 * hPadd,
                                          coloursPanel.Height);

            colourVultPanel.Location = new Point(hPadd,
                                                 coloursPanel.Height + 2 * vPadd);
            colourVultPanel.Size = new Size(coloursPanel.Width,
                                            containerPanel.Height - coloursPanel.Height - 3 * vPadd);

            uploadPanel.Location = new Point(colourVultPanel.Width + 2 * hPadd,
                                             dinosPanel.Height + 2 * vPadd);
            uploadPanel.Size = new Size(dinosPanel.Width,
                                        containerPanel.Height - coloursPanel.Height - 3 * vPadd);
        }

        static void PassVariables()
        {
            TrackerVariables.Trackers.ContainAllPanel = containerPanel;
            TrackerVariables.Trackers.ColourPanel = coloursPanel;
            TrackerVariables.Trackers.DinosAllPanel = dinosPanel;
            TrackerVariables.Trackers.ColourDinoPanel = colourVultPanel;
            TrackerVariables.Trackers.UploadPanel = uploadPanel;
        }

        static void GetColours()
        {
            Color panelColour = Styling.MasterAppearance.PanelColour;
            coloursPanel.BackColor = panelColour;
            dinosPanel.BackColor = panelColour;
            colourVultPanel.BackColor = panelColour;
            uploadPanel.BackColor = panelColour;
        }

        static void AddToControls()
        {
            if(containerPanel.Controls.Count > 0)
            {
                containerPanel.Controls.Clear();
            }
            containerPanel.Controls.Add(coloursPanel);
            containerPanel.Controls.Add(dinosPanel);
            containerPanel.Controls.Add(colourVultPanel);
            containerPanel.Controls.Add(uploadPanel);
            TrackerVariables.Trackers.TheForm.Controls.Add(containerPanel);

        }
    }
}
