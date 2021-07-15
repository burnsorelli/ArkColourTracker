using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using ArkColourTracker.Form1Results;

namespace ArkColourTracker.Form1Results.Methods
{
    class AddToDB
    {
        public static void Add(List<Panel> _rowsOnPage)
        {
            foreach (Panel _panel in _rowsOnPage)
            {
                TextBox nameLabel = _panel.Controls[0] as TextBox;
                ComboBox genderCB = _panel.Controls[1] as ComboBox;
                //TextBox bodyLabel = _panel.Controls[2] as TextBox;
                //TextBox headLabel = _panel.Controls[3] as TextBox;
                //TextBox faceLabel = _panel.Controls[4] as TextBox;
                //TextBox tipsLabel = _panel.Controls[5] as TextBox;

                string name = nameLabel.Text;
                string gender;
                if (genderCB.SelectedIndex == 0)
                {
                    gender = "Male";
                }
                else { gender = "Female"; }
                //int body = Convert.ToInt32(bodyLabel.Text);
                //int head = Convert.ToInt32(headLabel.Text);
                //int face = Convert.ToInt32(faceLabel.Text);
                //int tips = Convert.ToInt32(tipsLabel.Text);

                //SQLITE.SQLiteAdd.Add(name, gender, body, head, face, tips);

                int reg0 = 0;
                int reg1 = 0;
                int reg2 = 0;
                int reg3 = 0;
                int reg4 = 0;
                int reg5 = 0;

                foreach (TextBox _tb in _panel.Controls.OfType<TextBox>())
                {
                    if(_tb.Name == "Region0")
                    {
                        reg0 = Convert.ToInt32(_tb.Text);
                    }
                    if (_tb.Name == "Region1")
                    {
                        reg1 = Convert.ToInt32(_tb.Text);
                    }
                    if (_tb.Name == "Region2")
                    {
                        reg2 = Convert.ToInt32(_tb.Text);
                    }
                    if (_tb.Name == "Region3")
                    {
                        reg3 = Convert.ToInt32(_tb.Text);
                    }
                    if (_tb.Name == "Region4")
                    {
                        reg4 = Convert.ToInt32(_tb.Text);
                    }
                    if (_tb.Name == "Region5")
                    {
                        reg5 = Convert.ToInt32(_tb.Text);
                    }
                }
                SQLITE.SQLiteAdd.Add(name, gender, reg0, reg1, reg2, reg3, reg4, reg5);
            }
        }
    }
}
