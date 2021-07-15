using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArkColourTracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ArkColourTracker.Form1Results.TrackerVariables.Trackers.TheForm = this;
            Form2Databases.Startup.Start.Go();
        }
    }
}
