using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArkColourTracker.Form1Results;

namespace ArkColourTracker.Form1Results.Methods
{
    class GetDinoForColourList
    {
        public static void Get()
        {
            foreach (int _colourID in TrackerVariables.Trackers.ColourIDList)
            {
                
                List<Label> LabelList = GetLabel1(_colourID);
                List<Objects.Dino> possibleDinos = GetListDinosWithColour(_colourID);

                if (possibleDinos.Count > 0)
                {


                    foreach (Objects.Dino _dino in possibleDinos)
                    {

                        List<int> StatColoursList = GetStatColours(_dino);

                        if (CheckPureColour(_dino, _colourID))
                        {
                            for (int i = 0; i < StatColoursList.Count; i++)
                            {
                                LabelList[i].Text = _dino.Name;
                                LabelList[i].BackColor = Styling.MasterAppearance.CAllColoursFound;
                            }
                            break;
                        }
                        else
                        {
                            List<Objects.Dino> ChosenDinos = GetBestDino(StatColoursList, possibleDinos, _colourID);
                            for (int i = 0; i < StatColoursList.Count; i++)
                            {
                                if (ChosenDinos[i] != null)
                                {
                                    LabelList[i].Text = ChosenDinos[i].Name;
                                }

                            }
                        }

                    }

                }

            }
        }
        static bool CheckPureColour(Objects.Dino _possibleD, int _colourID)
        {
            bool isPure = false;
            Objects.Dino dino = _possibleD;
            List<int> colList = new List<int>();
            
            if (dino.Reg0Active) { colList.Add(Convert.ToInt32(dino.Region0)); }
            if (dino.Reg1Active) { colList.Add(Convert.ToInt32(dino.Region1)); }
            if (dino.Reg2Active) { colList.Add(Convert.ToInt32(dino.Region2)); }
            if (dino.Reg3Active) { colList.Add(Convert.ToInt32(dino.Region3)); }
            if (dino.Reg4Active) { colList.Add(Convert.ToInt32(dino.Region4)); }
            if (dino.Reg5Active) { colList.Add(Convert.ToInt32(dino.Region5)); }

            if(!colList.Any(o => o != colList[0]))
            {
                isPure = true;
            }
               
            
            return isPure;
        }
        public static List<Objects.Dino> GetListDinosWithColour(int _colourID)
        {
            List<Objects.Dino> tmpList = new List<Objects.Dino>();
            foreach (Objects.Dino _dino in TrackerVariables.Trackers.DinoList)
            {
                if((_dino.Reg0Active && _dino.Region0 == _colourID) ||
                   (_dino.Reg1Active && _dino.Region1 == _colourID) ||
                   (_dino.Reg2Active && _dino.Region2 == _colourID) ||
                   (_dino.Reg3Active && _dino.Region3 == _colourID) ||
                   (_dino.Reg4Active && _dino.Region4 == _colourID) ||
                   (_dino.Reg5Active && _dino.Region5 == _colourID)
                    )
                {
                    tmpList.Add(_dino);
                }
                

            }
            return tmpList;
        }
        
        static Panel GetPanel(int _colourID)
        {
            Panel tmpPanel = TrackerVariables.Trackers.ColourPanelPanelsList.Find(x => x.Name == _colourID.ToString());

            return tmpPanel;
        }

        static List<Label> GetLabel1(int _colourID)
        {
            Panel containerPanel = GetPanel(_colourID);

            List<Label> labelList = containerPanel.Controls.OfType<Label>().ToList();

            return labelList;
        } 

        static List<int> GetStatColours(Objects.Dino _dino)
        {
            List<int> statColour = new List<int>();
            if (_dino.Reg0Active)
            {
                statColour.Add(Convert.ToInt32(_dino.Region0));
            }
            if (_dino.Reg1Active)
            {
                statColour.Add(Convert.ToInt32(_dino.Region1));
            }
            if (_dino.Reg2Active)
            {
                statColour.Add(Convert.ToInt32(_dino.Region2));
            }
            if (_dino.Reg3Active)
            {
                statColour.Add(Convert.ToInt32(_dino.Region3));
            }
            if (_dino.Reg4Active)
            {
                statColour.Add(Convert.ToInt32(_dino.Region4));
            }
            if (_dino.Reg5Active)
            {
                statColour.Add(Convert.ToInt32(_dino.Region5));
            }
            return statColour;
        }

        static List<Objects.Dino> GetBestDino(List<int> statList, List<Objects.Dino> _list, int _colourID)
        {
            List<Objects.Dino> ChosenDino = new List<Objects.Dino>();
            for (int i = 0; i < statList.Count; i++)
            {
                Objects.Dino selectedDino = null;
                //int CurrentStat = i;
                int CurrentCount = 0;
                int Count;
                foreach (Objects.Dino _dino in _list)
                {
                    statList = GetStatColours(_dino);
                    Count = 0;
                    if (statList[i] == _colourID)
                    {
                        Count++;

                    }
                    if (Count > 0)
                    {
                        for (int x = 0; x < statList.Count - 1; x++)
                        {
                            if (statList[(i + 1) % statList.Count] == _colourID)
                            {
                                Count++;
                            }
                        }
                        if (Count > CurrentCount)
                        {
                            CurrentCount = Count;
                            selectedDino = _dino;
                        }
                    }

                }
                ChosenDino.Add(selectedDino);
                //ChosenVultures[i] = selectedVulture;
            }
            return ChosenDino;
        }
    }
}
