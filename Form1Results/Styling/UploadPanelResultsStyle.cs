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
    class UploadPanelResultsStyle
    {
        static Panel uploadPanel;
        static List<Panel> rowsOnPage = new List<Panel>();
        static List<string> colourRegions = new List<string>();
        public static void Style()
        {
            uploadPanel = TrackerVariables.Trackers.UploadResultsPanel;
            GetUploadChildren();
            TrackerVariables.Trackers.CurrentActiveUploadPanel = uploadPanel;
            rowsOnPage.Clear();
        }
        static void GetUploadChildren()
        {
            Label nameTitleLabel = new Label();
            Label genderTitleLabel = new Label();
            //Label bodyTitleLabel = new Label();
            //Label headTitleLabel = new Label();
            //Label faceTitleLabel = new Label();
            //Label tipsTitleLabel = new Label();

            Button addLineButton = new Button();
            Button clearButton = new Button();
            Button uploadButton = new Button();


            int heightChildTitles = MasterAppearance.UTitleRowHeight;
            colourRegions = Methods.GetColourRegionsForDino.Get(TrackerVariables.Trackers.DinoType);
            int widthLabel = GetWidthLabels(colourRegions);

            nameTitleLabel.Text = "Name";
            nameTitleLabel.Location = new Point(MasterAppearance.InternalHPadd,
                                                MasterAppearance.InternalVPadd);
            nameTitleLabel.Size = new Size(widthLabel, heightChildTitles);
            uploadPanel.Controls.Add(nameTitleLabel);

            genderTitleLabel.Text = "Gender";
            genderTitleLabel.Location = new Point(nameTitleLabel.Location.X + nameTitleLabel.Width + MasterAppearance.InternalHPadd, MasterAppearance.InternalVPadd);
            genderTitleLabel.Size = new Size(widthLabel, heightChildTitles);
            uploadPanel.Controls.Add(genderTitleLabel);

            GetVariableLabels(colourRegions, genderTitleLabel);


            addLineButton.Text = "Add Row";
            addLineButton.Size = new Size(MasterAppearance.UButtonWidth,
                                          MasterAppearance.UButtonHeight);
            addLineButton.Location = new Point(uploadPanel.Width - MasterAppearance.UButtonWidth - MasterAppearance.InternalHPadd,
                                               MasterAppearance.InternalVPadd);
            addLineButton.Click += EventHandlers.UploadAddRowButtonClick.Add;
            uploadPanel.Controls.Add(addLineButton);

            clearButton.Text = "Clear";
            clearButton.Size = new Size(MasterAppearance.UButtonWidth,
                                        MasterAppearance.UButtonHeight);
            clearButton.Location = new Point(addLineButton.Location.X,
                                             addLineButton.Location.Y + addLineButton.Height + MasterAppearance.InternalVPadd);
            clearButton.Click += EventHandlers.ClearUploadRows.Clear;
            uploadPanel.Controls.Add(clearButton);

            uploadButton.Text = "Upload";
            uploadButton.Size = new Size(MasterAppearance.UButtonWidth,
                                        MasterAppearance.UButtonHeight);
            uploadButton.Location = new Point(clearButton.Location.X,
                                              clearButton.Location.Y + clearButton.Height + MasterAppearance.InternalVPadd);
            uploadButton.Click += (sender, EventArgs) => EventHandlers.UploadButtonClick.Upload(sender, EventArgs, rowsOnPage);
            uploadPanel.Controls.Add(uploadButton);
        }

        static void GetVariableLabels(List<string> _colourRegions, Label _lastLabel)
        {
            int hPadd = MasterAppearance.InternalHPadd;
            int xPos = _lastLabel.Location.X + _lastLabel.Width + hPadd;
            int yPos = _lastLabel.Location.Y;

            //List<string> columnHeaders = Methods.GetDBColumnTitlesForRegions.Get(TrackerVariables.Trackers.DinoType);


            for (int i = 0; i < _colourRegions.Count; i++)
            {
                Label tmpLabel = new Label();
                tmpLabel.Text = _colourRegions[i];
                tmpLabel.Size = new Size(_lastLabel.Width, _lastLabel.Height);
                tmpLabel.Location = new Point(xPos, yPos);
                //tmpLabel.Name = columnHeaders[i];
                uploadPanel.Controls.Add(tmpLabel);
                xPos += tmpLabel.Width + hPadd;
            }
        }
        static int GetWidthLabels(List<string> _colourRegions)
        {
            int hPadd = MasterAppearance.InternalHPadd;
            int buttWidth = MasterAppearance.UButtonWidth;
            int labelNumber = _colourRegions.Count + 2;
            int width = (uploadPanel.Width - (buttWidth + 2 * hPadd) - hPadd*(labelNumber +1))/
                         labelNumber;
            return width;
        }
        public static void AddRow()
        {
            Panel tmpP = new Panel();
            TextBox tmpNameTextBox = new TextBox();
            ComboBox tmpGenderListBox = new ComboBox();
            TextBox tmpBodyTextBox = new TextBox();
            TextBox tmpHeadTextBox = new TextBox();
            TextBox tmpFaceTextBox = new TextBox();
            TextBox tmpTipsTextBox = new TextBox();
            ListBoxElements(tmpGenderListBox);
            
            tmpP.Size = new Size(uploadPanel.Width - MasterAppearance.UButtonWidth - 3 * MasterAppearance.InternalVPadd,
                                 MasterAppearance.URowHeight);
            tmpP.Location = new Point(MasterAppearance.InternalHPadd, MasterAppearance.UTitleRowHeight + 2 * MasterAppearance.InternalVPadd +
                                      rowsOnPage.Count * (tmpP.Height + MasterAppearance.InternalVPadd));
            tmpP.BackColor = Color.DarkKhaki;
            uploadPanel.Controls.Add(tmpP);

            Size boxSize = GetAddRowLabelWidth(tmpP);

            tmpNameTextBox.Size = boxSize;

            tmpNameTextBox.Location = new Point(MasterAppearance.InternalHPadd, MasterAppearance.InternalVPadd);
            tmpNameTextBox.Name = "Name";
            tmpP.Controls.Add(tmpNameTextBox);

            tmpGenderListBox.Size = boxSize;

            tmpGenderListBox.Location = new Point(tmpNameTextBox.Location.X +
                                                  tmpNameTextBox.Width + MasterAppearance.InternalHPadd,
                                                  MasterAppearance.InternalVPadd);
            tmpGenderListBox.Name = "Gender";
            tmpP.Controls.Add(tmpGenderListBox);

            GetAddRowVariableLabels(tmpP, tmpGenderListBox);


            rowsOnPage.Add(tmpP);
        }

        static Size GetAddRowLabelWidth(Panel _container)
        {
            int width = (_container.Width - (colourRegions.Count + 3) * MasterAppearance.InternalHPadd) /
                         (colourRegions.Count + 2);
            int height = _container.Height - 2 * MasterAppearance.InternalVPadd;
            Size size = new Size(width, height);
            return size;
        }

        static void GetAddRowVariableLabels(Panel _container, ComboBox _cb)
        {
            int posX = _cb.Location.X + _cb.Width + MasterAppearance.InternalHPadd;
            int posY = MasterAppearance.InternalVPadd;
            List<string> columnHeaders = Methods.GetDBColumnTitlesForRegions.Get(TrackerVariables.Trackers.DinoType);

            for (int i = 0; i < colourRegions.Count; i++)
            {
                TextBox tmpTB = new TextBox();
                tmpTB.Location = new Point(posX, posY);
                tmpTB.Size = new Size( _cb.Width, _cb.Height);
                tmpTB.Name = columnHeaders[i];
                _container.Controls.Add(tmpTB);
                posX += tmpTB.Width + MasterAppearance.InternalHPadd;
            }
        }
        

        public static void ClearRows()
        {
            foreach (Panel _panel in rowsOnPage)
            {
                uploadPanel.Controls.Remove(_panel);
            }
            rowsOnPage.Clear();
        }
        static void ListBoxElements(ComboBox _listbox)
        {
            _listbox.Items.Add("Male");
            _listbox.Items.Add("Female");
        }
    }
}
