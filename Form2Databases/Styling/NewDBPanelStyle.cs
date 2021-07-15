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
    class NewDBPanelStyle
    {
        static Label titleLabel = new Label();
        static Panel resultsPanel = new Panel();
        static Panel containerPanel;

        static Label instructionLabel = new Label();
        static ComboBox dinoChoiceCombo = new ComboBox();
        static Button createDBButton = new Button();

        public static void Style()
        {
            containerPanel = TrackerVariables.Trackers.NewDBPanel;
            GetChildPanels();
            GetGrandChildPanels();
            AddToControls();
            AddColours();
            AddColoursGC();
            PassVariables();
        }

        static void GetChildPanels()
        {
            titleLabel.Size = new Size(containerPanel.Width - 2 * MasterAppearance.InternalHPadd,
                                       MasterAppearance.TitlePanelHeight);
            titleLabel.Location = new Point(MasterAppearance.InternalHPadd, MasterAppearance.InternalVPadd);
            titleLabel.Text = MasterAppearance.NewDBTitle;
            titleLabel.TextAlign = MasterAppearance.TitleFontAlign;
            titleLabel.Font = MasterAppearance.TitleFont;

            resultsPanel.Size = new Size(titleLabel.Width,
                                         containerPanel.Height - titleLabel.Height - 3 * MasterAppearance.InternalVPadd);
            resultsPanel.Location = new Point(MasterAppearance.InternalHPadd,
                                              titleLabel.Height + 2 * MasterAppearance.InternalVPadd);
        }

        static void AddToControls()
        {
            containerPanel.Controls.Add(titleLabel);
            containerPanel.Controls.Add(resultsPanel);
            resultsPanel.Controls.Add(instructionLabel);
            resultsPanel.Controls.Add(dinoChoiceCombo);
            resultsPanel.Controls.Add(createDBButton);
        }

        static void AddColours()
        {
            titleLabel.BackColor = Color.AliceBlue;
            resultsPanel.BackColor = Color.Aquamarine;
        }

        static void GetGrandChildPanels()
        {
            instructionLabel.Text = MasterAppearance.NewDBInstructions;
            instructionLabel.Size = new Size(resultsPanel.Width - 2 * MasterAppearance.InternalHPadd,
                                             MasterAppearance.NewDBInstructionHeight);
            instructionLabel.Location = new Point(MasterAppearance.InternalHPadd,
                                                  MasterAppearance.InternalVPadd);
            instructionLabel.Font = MasterAppearance.NewDBInstructionFont;
            instructionLabel.TextAlign = MasterAppearance.TitleFontAlign;

            dinoChoiceCombo.Location = new Point(resultsPanel.Width/2 - dinoChoiceCombo.Width/2,
                                                 instructionLabel.Location.Y + instructionLabel.Height + MasterAppearance.InternalVPadd);
            //dinoChoiceCombo.Location = new Point(MasterAppearance.InternalHPadd,
            //                                     instructionLabel.Location.Y + instructionLabel.Height + MasterAppearance.InternalVPadd);
            List<string> dinoList = Methods.GetListAllDinos.GetDinos();
            foreach (string _dino in dinoList)
            {
                dinoChoiceCombo.Items.Add(_dino);
            }

            
            //createDBButton.Location = new Point(MasterAppearance.InternalHPadd,
            //                                    dinoChoiceCombo.Location.Y + dinoChoiceCombo.Height + MasterAppearance.InternalVPadd);
            createDBButton.Size = new Size(MasterAppearance.UButtonWidth, MasterAppearance.UButtonHeight);
            createDBButton.Location = new Point(resultsPanel.Width / 2 - createDBButton.Width / 2,
                                                dinoChoiceCombo.Location.Y + dinoChoiceCombo.Height + MasterAppearance.InternalVPadd);
            createDBButton.Text = MasterAppearance.NewDBCreateButtonText;
            createDBButton.Click += EventHandlers.CreateDBClick.Click;
        }
        static void PassVariables()
        {
            TrackerVariables.Trackers.DinoChoiceCB = dinoChoiceCombo;
        }

        static void AddColoursGC()
        {
            instructionLabel.BackColor = Color.AliceBlue;

        }
    }
}
