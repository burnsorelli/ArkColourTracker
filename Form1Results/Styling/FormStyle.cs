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
    class FormStyle
    {
        static Form theForm;
        public static void Style()
        {
            theForm = TrackerVariables.Trackers.TheForm;
            theForm.Size = new Size(Styling.MasterAppearance.FormWidth,
                                    Styling.MasterAppearance.FormHeight);
            theForm.Text = Styling.MasterAppearance.FormTitle;
        }
    }
}
