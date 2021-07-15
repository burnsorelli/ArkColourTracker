using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArkColourTracker.Form1Results;

namespace ArkColourTracker.Form1Results.Styling
{
    class MessageBoxYesNoStyle
    {
        public static bool Style(string _question)
        {
            bool result;

            DialogResult dialogResult = MessageBox.Show(_question, "Caution", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                result = true;
            }
            else
            {
                result = false;
            }

            return result;
        }
    }
}
