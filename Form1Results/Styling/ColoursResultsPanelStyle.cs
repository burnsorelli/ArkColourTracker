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
    class ColoursResultsPanelStyle
    {
        public static void GetEachLine(Color _colour, int _count, string _colName, int _colID)
        {
            int hPadd = Styling.MasterAppearance.InternalHPadd;
            int vPadd = Styling.MasterAppearance.InternalVPadd;
            int scrollbarWidth = Styling.MasterAppearance.ScrollbarWidth;
            int lineHeight = Styling.MasterAppearance.ColourLineHeight;
            int labelWidth = ((TrackerVariables.Trackers.ColourPanel.Width - 9 * hPadd) / 10);
            int panelWidth = TrackerVariables.Trackers.ColourPanel.Width - ((labelWidth + hPadd) * 6 + hPadd);

            Label colourLabel = new Label();
            colourLabel.Size = new Size((labelWidth * 3) - scrollbarWidth, lineHeight);
            colourLabel.Location = new Point(hPadd,
                                             (_count - 1) * lineHeight + (_count) * vPadd);
            colourLabel.Click += (sender, EventArgs) => { EventHandlers.ColourPanelColourClick.Click(sender, EventArgs, _colour, _colName, _colID.ToString()); };
            colourLabel.BackColor = _colour;

            Label colourText = new Label();
            colourText.Size = new Size(labelWidth * 2, lineHeight);
            colourText.Location = new Point(colourLabel.Location.X + colourLabel.Width + hPadd,
                                            colourLabel.Location.Y);
            colourText.Text = _colName;

            Label colourID = new Label();
            colourID.Size = new Size(labelWidth, lineHeight);
            colourID.Location = new Point(colourText.Location.X + colourText.Width + hPadd,
                                          colourText.Location.Y);
            colourID.Text = _colID.ToString();

            Panel regionsPanel = new Panel();
            regionsPanel.Size = new Size(panelWidth, lineHeight);
            regionsPanel.Location = new Point(colourID.Location.X + colourID.Width + hPadd,
                                              colourID.Location.Y);
            regionsPanel.BackColor = Color.Green;
            regionsPanel.Name = _colID.ToString();

            //Label body = new Label();
            //body.Size = new Size(labelWidth, lineHeight);
            //body.Location = new Point(colourID.Location.X + colourID.Width + hPadd,
            //                              colourID.Location.Y);
            //body.Name = "Body" + _colID;
            //body.TextAlign = ContentAlignment.MiddleCenter;
            //body.BackColor = Styling.MasterAppearance.WhiteColour;

            //Label head = new Label();
            //head.Size = new Size(labelWidth, lineHeight);
            //head.Location = new Point(body.Location.X + body.Width + hPadd,
            //                              body.Location.Y);
            //head.Name = "Head" + _colID;
            //head.TextAlign = ContentAlignment.MiddleCenter;
            //head.BackColor = Styling.MasterAppearance.WhiteColour;

            //Label face = new Label();
            //face.Size = new Size(labelWidth, lineHeight);
            //face.Location = new Point(head.Location.X + head.Width + hPadd,
            //                              head.Location.Y);
            //face.Name = "Face" + _colID;
            //face.TextAlign = ContentAlignment.MiddleCenter;
            //face.BackColor = Styling.MasterAppearance.WhiteColour;

            //Label tips = new Label();
            //tips.Size = new Size(labelWidth, lineHeight);
            //tips.Location = new Point(face.Location.X + face.Width + hPadd,
            //                              face.Location.Y);
            //tips.Name = "Tips" + _colID;
            //tips.TextAlign = ContentAlignment.MiddleCenter;
            //tips.BackColor = Styling.MasterAppearance.WhiteColour;

            AddToControls(colourLabel);
            AddToControls(colourText);
            AddToControls(colourID);
            //AddToControls(body);
            //AddToControls(head);
            //AddToControls(face);
            //AddToControls(tips);

            //TrackerVariables.Trackers.ColourPanelLabelsList.Add(body);
            //TrackerVariables.Trackers.ColourPanelLabelsList.Add(head);
            //TrackerVariables.Trackers.ColourPanelLabelsList.Add(face);
            //TrackerVariables.Trackers.ColourPanelLabelsList.Add(tips);

            TrackerVariables.Trackers.ColourPanelPanelsList.Add(regionsPanel);

            AddPanelToControls(regionsPanel);
            GetBodyPartLabels(regionsPanel);

        }

        static void GetBodyPartLabels(Panel _bodyPartsContainer)
        {
            List<string> regionsList = Methods.GetColourRegionsForDino.Get(TrackerVariables.Trackers.DinoType);

            for (int i = 0; i < regionsList.Count; i++)
            {
                CreateLabels(i, _bodyPartsContainer, regionsList[i], regionsList.Count);
            }
            //if(TrackerVariables.Trackers.DinoList.Count > 0)
            //{
            //    Objects.Dino tmpDino = TrackerVariables.Trackers.DinoList[0];
            //    List<string> regNames = new List<string>();
            //    if (tmpDino.Reg0Active)
            //    {
            //        regNames.Add(tmpDino.Reg0Name);
            //    }
            //    if (tmpDino.Reg1Active)
            //    {
            //        regNames.Add(tmpDino.Reg0Name);
            //    }
            //    if (tmpDino.Reg2Active)
            //    {
            //        regNames.Add(tmpDino.Reg0Name);
            //    }
            //    if (tmpDino.Reg3Active)
            //    {
            //        regNames.Add(tmpDino.Reg0Name);
            //    }
            //    if (tmpDino.Reg4Active)
            //    {
            //        regNames.Add(tmpDino.Reg0Name);
            //    }
            //    if (tmpDino.Reg5Active)
            //    {
            //        regNames.Add(tmpDino.Reg0Name);
            //    }

            //    for (int i = 0; i < regNames.Count; i++)
            //    {
            //        CreateLabels(i, _bodyPartsContainer, regNames[i], regNames.Count);
            //    }
            //}
            //else
            //{
            //    CreateNoDinosLabel(_bodyPartsContainer);
            //}
        }

        static void CreateLabels(int _count, Panel _containerP, string _name, int _numberLabels)
        {
            int width = GetLabelWidth(_numberLabels, _containerP);
            int hPadd = MasterAppearance.InternalHPadd;
            Label tmpLabel = new Label();
            tmpLabel.Size = new Size(width, _containerP.Height);
            tmpLabel.Location = new Point(hPadd + (_count * (width + hPadd)),
                                          0);
            tmpLabel.Name = _name;
            tmpLabel.TextAlign = ContentAlignment.MiddleCenter;
            tmpLabel.BackColor = Styling.MasterAppearance.WhiteColour;
            _containerP.Controls.Add(tmpLabel);
        }

        static void CreateNoDinosLabel(Panel _containerPanel)
        {
            int hPadd = MasterAppearance.InternalHPadd;
            Label noDinoMessage = new Label();
            noDinoMessage.Text = MasterAppearance.NoDinoText;
            noDinoMessage.TextAlign = ContentAlignment.MiddleCenter;
            noDinoMessage.Size = new Size(_containerPanel.Width - 2 * hPadd,
                                          _containerPanel.Height);
            noDinoMessage.Location = new Point(hPadd, 0);
            _containerPanel.Controls.Add(noDinoMessage);
        }

        static int GetLabelWidth(int _count, Panel _containerP)
        {
            int width;

            width = (_containerP.Width - (_count + 1) * MasterAppearance.InternalHPadd) / _count;

            return width;
        }

        static void AddToControls(Label _label)
        {
            TrackerVariables.Trackers.ColourResultsPanel.Controls.Add(_label);
        }

        static void AddPanelToControls(Panel _panel)
        {
            TrackerVariables.Trackers.ColourResultsPanel.Controls.Add(_panel);
        }
    }
}
