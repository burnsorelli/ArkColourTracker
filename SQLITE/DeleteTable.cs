using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Configuration;
using System.Windows.Forms;

namespace ArkColourTracker.SQLITE
{
    class DeleteTable
    {
        public static void Delete(String _tableName)
        {
            if (CheckSure())
            {
                string query = "DROP table " + _tableName;
                using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    cnn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(query, cnn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
                Form2Databases.Methods.RefreshPage.Refresh();
            }
            
        }

        private static string LoadConnectionString(string id = "MyConnString")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        static bool CheckSure()
        {
            bool sure = false;

            DialogResult dialogResult = MessageBox.Show("Delete Table", "Cancel", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                sure = true;
            }

            return sure;
        }
    }
}
