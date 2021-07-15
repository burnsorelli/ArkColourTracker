using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArkColourTracker.Form1Results;

namespace ArkColourTracker.Form1Results.Styling
{
    class DinosAllResultsPanelStyle
    {
        static DataTable vultDT;
        static DataGridView dataGridVult;
        static Panel vulturesPanel;
        static int columnWidth;
        public static void GetDataGridData(string _type)
        {
            dataGridVult = new DataGridView();
            vulturesPanel = TrackerVariables.Trackers.DinosResultsPanel;
            vultDT = Methods.GetDinoDT.Get(_type);

            if(vultDT.Rows.Count > 0)
            {
                
                //List<string> headers = GetHeaders(vultDT, _type);
                DataTable newDT = DeleteRedundantColumns(vultDT);
                dataGridVult.DataSource = newDT;
                

                //dataGridVult.DataSource = vultDT;
                vulturesPanel.Controls.Add(dataGridVult);
                GetColumnWidth();
                GetDataGridStyle(_type);
            }

            
        }

        static void GetDataGridStyle(string _type)
        {
            dataGridVult.AutoGenerateColumns = false;
            dataGridVult.Size = new Size(vulturesPanel.Width,
                                         vulturesPanel.Height);
            //dataGridVult.Size = new Size(MasterAppearance.VNumberColumns * columnWidth + MasterAppearance.ScrollbarWidth,
            //                             vulturesPanel.Height);
            //dataGridVult.Size = new Size(MasterAppearance.VNumberColumns * columnWidth + MasterAppearance.ScrollbarWidth,
            //                             vulturesPanel.Height - 3 * MasterAppearance.InternalVPadd -
            //                             MasterAppearance.TitlePanelHeight);
            dataGridVult.Location = new Point(0, 0);
            //AddColumns();
            dataGridVult.ReadOnly = true;
            foreach (DataGridViewColumn _col in dataGridVult.Columns)
            {
                _col.Width = columnWidth;
            }
            dataGridVult.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridVult.RowHeadersVisible = false;
            dataGridVult.AllowUserToAddRows = false;
            ChangeHeaders(dataGridVult, _type);
        }

        static void ChangeHeaders(DataGridView _dgv, string _type)
        {
            List<string> headers = Methods.GetColourRegionsForDino.Get(_type);
            for (int i = 0; i < headers.Count; i++)
            {
                _dgv.Columns[3 + i].HeaderText = headers[i];
            }
            //return _dgv ;
        }

        static DataTable DeleteRedundantColumns(DataTable _dt)
        {
            List<string> columnList = new List<string>();
            if(_dt.Rows[0][3].ToString() == "0")
            {
                columnList.Add(_dt.Columns[3].ColumnName.ToString());
            }
            if (_dt.Rows[0][4].ToString() == "0")
            {
                columnList.Add(_dt.Columns[4].ColumnName.ToString());
            }
            if (_dt.Rows[0][5].ToString() == "0")
            {
                columnList.Add(_dt.Columns[5].ColumnName.ToString());
            }
            if (_dt.Rows[0][6].ToString() == "0")
            {
                columnList.Add(_dt.Columns[6].ColumnName.ToString());
            }
            if (_dt.Rows[0][7].ToString() == "0")
            {
                columnList.Add(_dt.Columns[7].ColumnName.ToString());
            }
            if (_dt.Rows[0][8].ToString() == "0")
            {
                columnList.Add(_dt.Columns[8].ColumnName.ToString());
            }

            foreach(string _colName in columnList)
            {
                _dt.Columns.Remove(_colName);
            }

            return _dt;
        }

        

        
        static void GetColumnWidth()
        {
            int numberColumns = dataGridVult.Columns.Count;
            //columnWidth = (dataGridVult.Width - SystemInformation.VerticalScrollBarWidth) / numberColumns;

            columnWidth = (vulturesPanel.Width - SystemInformation.VerticalScrollBarWidth - 1) / numberColumns;
            //columnWidth = (vulturesPanel.Width -
            //               MasterAppearance.ScrollbarWidth) / MasterAppearance.VNumberColumns;
        }
    }
}
