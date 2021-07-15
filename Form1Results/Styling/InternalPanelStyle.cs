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
    class InternalPanelStyle
    {
        
        static Panel containerPanel = new Panel();
        static Panel altResultsPanel = new Panel();
        //static Label titleLabel = new Label();
        //static Panel resultsPanel = new Panel();
        static int hPadd = Styling.MasterAppearance.InternalHPadd;
        static int vPadd = Styling.MasterAppearance.InternalVPadd;
        public static Panel Style(Panel _container, String _titleText, bool _switchButton = false)
        {
            if(_container.Controls.Count > 0)
            {
                _container.Controls.Clear();
            }
            //Panel containerPanel = new Panel();
            Label titleLabel = new Label();
            Panel resultsPanel = new Panel();

            containerPanel = _container;
            GetChildPanels(_titleText, titleLabel, resultsPanel, _switchButton);
            AddToControls(titleLabel, resultsPanel);
            return resultsPanel;
        }

        static void GetChildPanels(String _titleText, Label _titleLabel, Panel _resultsPanel, bool _switchButton)
        {
            GetTitleLabel(_titleText, _titleLabel, _switchButton);
            GetResultsPanel(_resultsPanel, _titleLabel, _switchButton);
            if (_switchButton)
            {
                AddSwitchButton(_titleLabel);
            }

        }

        static void GetTitleLabel(string _titleText, Label _titleLabel, bool _uploadPanel)
        {
            _titleLabel.Text = _titleText;
            _titleLabel.Font = Styling.MasterAppearance.TitleFont;
            _titleLabel.TextAlign = Styling.MasterAppearance.TitleFontAlign;
            _titleLabel.Location = new Point(hPadd, vPadd);
            _titleLabel.Size = new Size(containerPanel.Width - 2 * hPadd,
                                        Styling.MasterAppearance.TitlePanelHeight);
            _titleLabel.BackColor = MasterAppearance.TitleColour;
            if (_uploadPanel)
            {
                TrackerVariables.Trackers.UploadTitlePanel = _titleLabel;
            }
        }

        static void GetResultsPanel(Panel _resultsPanel, Label _titleLabel, bool _uplaodPanel = false)
        {
            _resultsPanel.Location = new Point(_titleLabel.Location.X,
                                                _titleLabel.Location.Y + _titleLabel.Height +
                                                vPadd);
            _resultsPanel.Size = new Size(_titleLabel.Width, containerPanel.Height - _titleLabel.Height -
                                            3 * vPadd);
            _resultsPanel.BackColor = MasterAppearance.ResultPanelColour;
            _resultsPanel.AutoScroll = true;
            if (_uplaodPanel)
            {
                altResultsPanel.Location = _resultsPanel.Location;
                altResultsPanel.Size = _resultsPanel.Size;
                altResultsPanel.BackColor = _resultsPanel.BackColor;
                altResultsPanel.Visible = false;
                containerPanel.Controls.Add(altResultsPanel);
                TrackerVariables.Trackers.FindUselessPanel = altResultsPanel;
            }
        }

        static void AddSwitchButton(Label _titleLabel)
        {
            Button switchButton = new Button();
            switchButton.Size = new Size(MasterAppearance.UButtonWidth,
                                            _titleLabel.Height - 2 * vPadd);
            switchButton.Location = new Point(_titleLabel.Width - switchButton.Width - hPadd,
                                                vPadd);
            switchButton.Text = MasterAppearance.USwitchButtonText;
            switchButton.Font = MasterAppearance.USwitchButtonFont;
            switchButton.TextAlign = MasterAppearance.TitleFontAlign;
            switchButton.Click += EventHandlers.SwitchUploadPanelClick.Click;
            _titleLabel.Controls.Add(switchButton);
        }

        static void AddToControls(Label _titleLabel, Panel _resultsPanel)
        {
            containerPanel.Controls.Add(_titleLabel);
            containerPanel.Controls.Add(_resultsPanel);
        }
    }
}
