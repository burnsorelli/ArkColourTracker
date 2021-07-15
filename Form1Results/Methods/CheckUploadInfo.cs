using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArkColourTracker.Form1Results;

namespace ArkColourTracker.Form1Results.Methods
{
    class CheckUploadInfo
    {
        public static bool Check(List<Panel> _rowsOnPage)
        {
            bool isGood = true;

            if (_rowsOnPage.Count > 0)
            {
                foreach (Panel _panel in _rowsOnPage)
                {
                    if (_panel.Controls["Name"].Text == "")
                    {
                        isGood = false;
                        break;
                    }

                    ComboBox tmpLB = (ComboBox)_panel.Controls["Gender"];
                    if (tmpLB.SelectedIndex == -1)
                    {
                        isGood = false;
                        break;
                    }

                    List<TextBox> regionsTB = new List<TextBox>();
                    int numberRegions = _panel.Controls.Count - 2;
                    for (int i = 2; i < numberRegions; i++)
                    {
                        if(_panel.Controls[i].Text == "")
                        {
                            isGood = false;
                            break;
                        }
                    }
                    //if (_panel.Controls["Body"].Text == "")
                    //{
                    //    isGood = false;
                    //    break;
                    //}
                    //if (_panel.Controls["Head"].Text == "")
                    //{
                    //    isGood = false;
                    //    break;
                    //}
                    //if (_panel.Controls["Face"].Text == "")
                    //{
                    //    isGood = false;
                    //    break;
                    //}
                    //if (_panel.Controls["Tips"].Text == "")
                    //{
                    //    isGood = false;
                    //    break;
                    //}
                }
            }
            else
            {
                isGood = false;
            }
            return isGood;
        }
    }
}
