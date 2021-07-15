using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using ArkColourTracker.Form2Databases.Appearance;

namespace ArkColourTracker.Form2Databases.Styling
{
    class ExistingListStyle
    {
        static List<Panel> allDBs = new List<Panel>();

        static DataTable dt = new DataTable();
        static Panel parentPanel = new Panel();
        static List<String> allDBsList = new List<string>();


        public static void Start()
        {
            parentPanel = TrackerVariables.Trackers.ExistingDBResultsPanel;
            parentPanel.Controls.Clear();
            Methods.GetAllDatabases.Get();
            allDBsList = TrackerVariables.Trackers.AllPlayerCreatedDBs;
            int count = 0;
            foreach(string _name in allDBsList)
            {
                CreatePanel(count, _name);
                count++;
            }
        }

        static void CreatePanel(int _count, string _name)
        {
            

            Panel containerPanel = new Panel();
            Label dBInfoLabel = new Label();
            Button chooseDBButton = new Button();
            Button deleteDBButton = new Button();
            int iHPad = MasterAppearance.InternalHPadd;
            int iVPad = MasterAppearance.InternalVPadd;
            int eVPad = MasterAppearance.VertPadding;

            int x = parentPanel.Width - 2 * iHPad - MasterAppearance.ScrollbarWidth;
            int y = MasterAppearance.DatabaseListHeight;
            
            containerPanel.Size = new Size(x, y);
            containerPanel.Location = new Point(iHPad,   iVPad + _count * 
                                        (MasterAppearance.DatabaseListHeight +
                                        eVPad));

            x = (containerPanel.Width - 4 * iHPad) / 2;
            y = MasterAppearance.DatabaseListHeight - 2 * iVPad; ;

            dBInfoLabel.Size = new Size(x, y);
            dBInfoLabel.Location = new Point(iHPad,
                                            iVPad);
            dBInfoLabel.Text = _name;
            dBInfoLabel.TextAlign = MasterAppearance.TitleFontAlign;

            x = dBInfoLabel.Width / 2;
            y = containerPanel.Height;
            //y = dBInfoLabel.Height;

            chooseDBButton.Size = new Size(x,y);
            chooseDBButton.Location = new Point(dBInfoLabel.Location.X + dBInfoLabel.Width + iHPad,
                                                0);
            chooseDBButton.Text = MasterAppearance.chooseDBButtonText;
            SetButtonsTextAlign(chooseDBButton);
            chooseDBButton.Click += (sender, EventArgs) => { EventHandlers.DBSelectClick.Click(sender, EventArgs, _name); };

            deleteDBButton.Size = new Size(x, y);
            deleteDBButton.Location = new Point(chooseDBButton.Location.X + chooseDBButton.Width + iHPad,
                                                chooseDBButton.Location.Y);
            deleteDBButton.Text = MasterAppearance.deleteDBButtonText;
            deleteDBButton.Click += (sender, EventArgs) => { EventHandlers.DeleteTableClick.Click(sender, EventArgs, _name); };
            SetButtonsTextAlign(deleteDBButton);

            AddColours(containerPanel, dBInfoLabel, chooseDBButton, deleteDBButton);
            AddToControls(containerPanel, dBInfoLabel, chooseDBButton, deleteDBButton);

        }
        
        static void AddColours(Panel _containerPanel, Label _infoLabel, Button _chooseButton, Button _deleteButton)
        {
            _containerPanel.BackColor = Color.Black;
            _infoLabel.BackColor = Color.White;
            _chooseButton.BackColor = Color.Green;
            _deleteButton.BackColor = Color.Red;
        }

        static void SetButtonsTextAlign(Button _button)
        {
            _button.TextAlign = MasterAppearance.TitleFontAlign;
            _button.Font = MasterAppearance.ButtonFont;
        }

        static void AddToControls(Panel _containerPanel, Label _infoLabel, Button _chooseButton, Button _deleteButton)
        {
            parentPanel.Controls.Add(_containerPanel);
            _containerPanel.Controls.Add(_infoLabel);
            _containerPanel.Controls.Add(_chooseButton);
            _containerPanel.Controls.Add(_deleteButton);
        }
    }
}
