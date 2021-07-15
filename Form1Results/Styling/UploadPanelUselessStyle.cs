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
    class UploadPanelUselessStyle
    {
        static Panel uselessPanel;
        static Panel uselessResultsPanel;

        public static void Style()
        {

            uselessPanel = TrackerVariables.Trackers.FindUselessPanel;
            if(uselessPanel.Controls.Count > 0)
            {
                uselessPanel.Controls.Clear();
            }
            GetUploadChildren();
        }
        static void GetUploadChildren()
        {
            Button findUselessButton = new Button();
            findUselessButton.Text = MasterAppearance.UselessButtonText;
            findUselessButton.Size = new Size(MasterAppearance.UButtonWidth,
                                              MasterAppearance.UButtonHeight);
            findUselessButton.Location = new Point(uselessPanel.Width - findUselessButton.Width - MasterAppearance.InternalHPadd,
                                                   MasterAppearance.InternalVPadd);
            findUselessButton.Click += EventHandlers.FindUselessClick.Click;
            uselessPanel.Controls.Add(findUselessButton);

            Button deleteUselessButton = new Button();
            deleteUselessButton.Text = MasterAppearance.UselessDeleteButtonText;
            deleteUselessButton.Size = new Size(MasterAppearance.UButtonWidth,
                                              MasterAppearance.UButtonHeight);
            deleteUselessButton.Location = new Point(uselessPanel.Width - findUselessButton.Width - MasterAppearance.InternalHPadd,
                                                   2 * MasterAppearance.InternalVPadd + findUselessButton.Height);
            deleteUselessButton.Click += EventHandlers.DeleteUselessClick.Click;
            uselessPanel.Controls.Add(deleteUselessButton);

            uselessResultsPanel = new Panel();
            uselessResultsPanel.Size = new Size(uselessPanel.Width - findUselessButton.Width - 3 * MasterAppearance.InternalHPadd,
                                                uselessPanel.Height - 2 * MasterAppearance.InternalVPadd);
            uselessResultsPanel.Location = new Point(MasterAppearance.InternalHPadd,
                                                     MasterAppearance.InternalVPadd);
            //uselessResultsPanel.BackColor = Color.BlueViolet;

            uselessResultsPanel.Controls.Clear();

            uselessPanel.Controls.Add(uselessResultsPanel);
            TrackerVariables.Trackers.UselessResultsPanel = uselessResultsPanel;
        }
        public static void GetResults(List<string> _uselessList)
        {
            int countCol = 0;
            int countRow = 0;
            int width = GetLabelWidth();
            foreach (string _name in _uselessList)
            {
                Label tmpLabel = new Label();
                tmpLabel.Text = _name.ToString();
                tmpLabel.BackColor = MasterAppearance.UselessResultsColour;
                tmpLabel.Size = new Size(width,
                                         MasterAppearance.UselessResultsLabelHeight);
                tmpLabel.TextAlign = MasterAppearance.TitleFontAlign;
                if (countCol + 1 <= MasterAppearance.UselessResultsLabelsPerPanel)
                {
                    tmpLabel.Location = new Point(MasterAppearance.InternalHPadd + countCol * (tmpLabel.Width + MasterAppearance.InternalHPadd),
                                              MasterAppearance.InternalVPadd + countRow * (tmpLabel.Height + MasterAppearance.InternalVPadd));
                    countCol++;
                }
                else
                {
                    countCol = 0;
                    countRow += 1;
                    tmpLabel.Location = new Point(MasterAppearance.InternalHPadd + countCol * (tmpLabel.Width + MasterAppearance.InternalHPadd),
                                              MasterAppearance.InternalVPadd + countRow * (tmpLabel.Height + MasterAppearance.InternalVPadd));
                    countCol++;
                }


                uselessResultsPanel.Controls.Add(tmpLabel);
            }
        }
        static int GetLabelWidth()
        {
            int width = (uselessResultsPanel.Width - (MasterAppearance.UselessResultsLabelsPerPanel + 1) * MasterAppearance.InternalHPadd) / MasterAppearance.UselessResultsLabelsPerPanel;
            return width;
        }
    }
}
