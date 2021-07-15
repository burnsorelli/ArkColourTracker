using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArkColourTracker.Form2Databases.EventHandlers
{
    class DeleteTableClick
    {
        public static void Click(Object sender, EventArgs e, string _tableName)
        {
            SQLITE.DeleteTable.Delete(_tableName);
        }
    }
}
