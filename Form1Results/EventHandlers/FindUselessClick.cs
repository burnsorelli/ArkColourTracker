using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArkColourTracker.Form1Results;

namespace ArkColourTracker.Form1Results.EventHandlers
{
    class FindUselessClick
    {
        public static void Click(object sender, EventArgs e)
        {
            Methods.GetUseless.Get();
        }
    }
}
