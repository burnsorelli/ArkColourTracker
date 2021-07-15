using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArkColourTracker.Form1Results;

namespace ArkColourTracker.Form1Results.Methods
{
    class GetUseless
    {
        static List<int> completedColours = new List<int>();
        static List<Objects.Dino> uselessList = new List<Objects.Dino>();

        public static void Get()
        {
            //TrackerVariables.Trackers.UselessList.Clear();
            completedColours = GetCompletedColours();
            uselessList = GetListUseless();
            if (uselessList.Count > 0)
            {
                ReturnResults();
            }
            GetNameListTrackers();
        }
        static List<int> GetCompletedColours()
        {
            List<int> colList = new List<int>();
            foreach (Objects.Dino _dino in TrackerVariables.Trackers.DinoList)
            {
                List<int> tmpList = new List<int>();
                if (_dino.Reg0Active) { tmpList.Add(Convert.ToInt32(_dino.Region0)); }
                if (_dino.Reg1Active) { tmpList.Add(Convert.ToInt32(_dino.Region1)); }
                if (_dino.Reg2Active) { tmpList.Add(Convert.ToInt32(_dino.Region2)); }
                if (_dino.Reg3Active) { tmpList.Add(Convert.ToInt32(_dino.Region3)); }
                if (_dino.Reg4Active) { tmpList.Add(Convert.ToInt32(_dino.Region4)); }
                if (_dino.Reg5Active) { tmpList.Add(Convert.ToInt32(_dino.Region5)); }

                if(!tmpList.Any(o => o != tmpList[0]))
                {
                    if (!colList.Contains(tmpList[0]))
                    {
                        colList.Add(tmpList[0]);
                    }
                }

                
            }
            return colList;
        }

        static List<Objects.Dino> GetListUseless()
        {
            List<Objects.Dino> tmpUselessList = new List<Objects.Dino>();
            foreach (Objects.Dino _dino in TrackerVariables.Trackers.DinoList)
            {
                List<int> tmpList = new List<int>();
                if (_dino.Reg0Active) { tmpList.Add(Convert.ToInt32(_dino.Region0)); }
                if (_dino.Reg1Active) { tmpList.Add(Convert.ToInt32(_dino.Region1)); }
                if (_dino.Reg2Active) { tmpList.Add(Convert.ToInt32(_dino.Region2)); }
                if (_dino.Reg3Active) { tmpList.Add(Convert.ToInt32(_dino.Region3)); }
                if (_dino.Reg4Active) { tmpList.Add(Convert.ToInt32(_dino.Region4)); }
                if (_dino.Reg5Active) { tmpList.Add(Convert.ToInt32(_dino.Region5)); }
                if (!tmpList.Any(o => o != tmpList[0]))
                {

                }
                else
                {
                    bool necessary = false;
                    for (int i = 0; i < tmpList.Count; i++)
                    {
                        if (!completedColours.Contains(tmpList[i]))
                        {
                            necessary = true;
                            break;
                        }
                    }
                    if (!necessary)
                    {
                        tmpUselessList.Add(_dino);
                    }
                }

                
            }
            return tmpUselessList;
        }
        static void ReturnResults()
        {
            Styling.UploadPanelUselessStyle.GetResults(GetText());
        }

        static List<string> GetText()
        {
            List<string> tmpUselessList = new List<string>();
            foreach (Objects.Dino _vulture in uselessList)
            {
                tmpUselessList.Add(_vulture.Name);
            }
            return tmpUselessList;
        }
        static void GetNameListTrackers()
        {
            TrackerVariables.Trackers.UselessList.Clear();
            foreach (Objects.Dino _vulture in uselessList)
            {
                TrackerVariables.Trackers.UselessList.Add(_vulture.Name);
            }
        }
    }
}
