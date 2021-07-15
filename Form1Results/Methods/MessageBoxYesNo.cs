using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArkColourTracker.Form1Results;

namespace ArkColourTracker.Form1Results.Methods
{
    class MessageBoxYesNo
    {
        public static bool Get(string _question = "Continue")
        {
            bool result;

            result = Styling.MessageBoxYesNoStyle.Style(_question);

            return result;
        }
    }
}
