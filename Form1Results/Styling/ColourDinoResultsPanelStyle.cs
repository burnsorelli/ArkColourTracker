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
    class ColourDinoResultsPanelStyle
    {
        static Panel resultsPanel = new Panel();
        public static void AddData(List<Objects.Dino> _dList, Color _colour, String _colourName, string _colourID)
        {
            resultsPanel = TrackerVariables.Trackers.ColourDinoResultsPanel;
            resultsPanel.Controls.Clear();

            Label colourBox = new Label();
            colourBox.BackColor = _colour;
            colourBox.Size = new Size(MasterAppearance.CVColourLabelWidth,
                                      MasterAppearance.CVTitleLabelsHeight);
            colourBox.Location = new Point(MasterAppearance.InternalHPadd,
                                           MasterAppearance.InternalVPadd);

            Label colourName = new Label();
            colourName.Text = _colourName;
            colourName.Size = new Size(MasterAppearance.CVColourNameLabelWidth,
                                       MasterAppearance.CVTitleLabelsHeight);
            colourName.Location = new Point(colourBox.Location.X + colourBox.Width +
                                            MasterAppearance.InternalHPadd,
                                            colourBox.Location.Y);
            colourName.Font = MasterAppearance.CVHeaderFont;
            colourName.TextAlign = MasterAppearance.TitleFontAlign;

            Label colourID = new Label();
            colourID.Text = _colourID;
            colourID.Size = new Size(MasterAppearance.CVColourIDLabelWidth,
                                     MasterAppearance.CVTitleLabelsHeight);
            colourID.Location = new Point(colourName.Location.X + colourName.Width +
                                          MasterAppearance.InternalHPadd,
                                          colourName.Location.Y);
            colourID.Font = MasterAppearance.CVHeaderFont;
            colourID.TextAlign = MasterAppearance.TitleFontAlign;


            resultsPanel.Controls.Add(colourBox);
            resultsPanel.Controls.Add(colourName);
            resultsPanel.Controls.Add(colourID);

            if (_dList.Count > 0)
            {
                int count = 0;
                foreach (Objects.Dino _dino in _dList)
                {
                    string gender;
                    if (_dino.Male == true)
                    {
                        gender = "Male";
                    }
                    else
                    {
                        gender = "Female";
                    }

                    Label nameTitle = new Label();
                    nameTitle.Text = "Name: ";
                    nameTitle.Size = new Size(MasterAppearance.CVVultureDetailsWidth,
                                              MasterAppearance.CVVultureDetailsHeight);
                    nameTitle.Location = new Point(MasterAppearance.InternalHPadd,
                                                   (colourBox.Location.Y + colourBox.Height + MasterAppearance.InternalVPadd) +
                                                    MasterAppearance.CVVultureDetailsHeight * count);
                    resultsPanel.Controls.Add(nameTitle);

                    Label nameLabel = new Label();
                    nameLabel.Text = _dino.Name;
                    nameLabel.Size = new Size(MasterAppearance.CVVultureDetailsWidth,
                                              MasterAppearance.CVVultureDetailsHeight);
                    nameLabel.Location = new Point(nameTitle.Location.X + nameTitle.Width + MasterAppearance.InternalHPadd,
                                                   nameTitle.Location.Y);
                    resultsPanel.Controls.Add(nameLabel);

                    Label genderTitle = new Label();
                    genderTitle.Text = "Gender: ";
                    genderTitle.Size = new Size(MasterAppearance.CVVultureDetailsWidth,
                                                MasterAppearance.CVVultureDetailsHeight);
                    genderTitle.Location = new Point(nameLabel.Location.X + nameLabel.Width + MasterAppearance.InternalHPadd,
                                                     nameLabel.Location.Y);
                    resultsPanel.Controls.Add(genderTitle);

                    Label genderLabel = new Label();
                    genderLabel.Text = gender;
                    genderLabel.Size = new Size(MasterAppearance.CVVultureDetailsWidth,
                                                MasterAppearance.CVVultureDetailsHeight);
                    genderLabel.Location = new Point(genderTitle.Location.X + genderTitle.Width + MasterAppearance.InternalHPadd,
                                                     genderTitle.Location.Y);
                    resultsPanel.Controls.Add(genderLabel);

                    /* NEEDS CHANGING */

                    Label lastLabel = genderLabel;

                    if (_dino.Reg0Active)
                    {
                        lastLabel = CreateLabels(_dino.Reg0Name, _dino.Region0.ToString(), lastLabel, _colourID);
                    }

                    if (_dino.Reg1Active)
                    {
                        lastLabel = CreateLabels(_dino.Reg1Name, _dino.Region1.ToString(), lastLabel, _colourID);
                    }

                    if (_dino.Reg2Active)
                    {
                        lastLabel = CreateLabels(_dino.Reg2Name, _dino.Region2.ToString(), lastLabel, _colourID);
                    }

                    if (_dino.Reg3Active)
                    {
                        lastLabel = CreateLabels(_dino.Reg3Name, _dino.Region3.ToString(), lastLabel, _colourID);
                    }

                    if (_dino.Reg4Active)
                    {
                        lastLabel = CreateLabels(_dino.Reg4Name, _dino.Region4.ToString(), lastLabel, _colourID);
                    }

                    if (_dino.Reg5Active)
                    {
                        lastLabel = CreateLabels(_dino.Reg5Name, _dino.Region5.ToString(), lastLabel, _colourID);
                    }


                    count++;
                }
            }
        }
        static Label CreateLabels(string _labelTitle, string _labelResult, Label _lastLabel, string _colourID)
        {
            Label title = new Label();
            title.Text = _labelTitle;
            title.Size = new Size(MasterAppearance.CVVultureDetailsWidth,
                                              MasterAppearance.CVVultureDetailsHeight);
            title.Location = new Point(_lastLabel.Location.X + _lastLabel.Width + MasterAppearance.InternalHPadd,
                                       _lastLabel.Location.Y);

            Label amount = new Label();
            amount.Text = _labelResult;
            amount.Size = new Size(MasterAppearance.CVVultureDetailsWidth,
                                              MasterAppearance.CVVultureDetailsHeight);
            amount.Location = new Point(title.Location.X + title.Width + MasterAppearance.InternalHPadd,
                                        title.Location.Y);

            if(_labelResult == _colourID)
            {
                amount.BackColor = MasterAppearance.CVHighlightColour;
            }

            resultsPanel.Controls.Add(title);
            resultsPanel.Controls.Add(amount);

            return amount;
        }
    }
}
