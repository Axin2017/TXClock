using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;
using TXClock.Model;
using TXClock.Service;

namespace TXClock
{
    public partial class CountClockEditForm : Form
    {
        private Clock clock;
        private List<CountClock> countClockList;
        public CountClockEditForm(Clock clock)
        {
            InitializeComponent();
            this.clock = clock;
            countClockList = new List<CountClock>();
            LoadCountClock();
        }
        

        private void LoadCountClock()
        {
            XmlNodeList clockNodeList = XmlService.CountClockXml.GetElementsByTagName("Clock");
            foreach (XmlNode clockNode in clockNodeList)
            {
                CountClock countClock = new CountClock();
                countClock.InitFromXmlNode(clockNode);
                countClockList.Add(countClock);
            }
            InitCountClockGrid(countClockList);
        }
        private void InitCountClockGrid(List<CountClock> countClockList)
        {
            foreach (CountClock cc in countClockList)
            {
                DataGridViewRow row = new DataGridViewRow();
                DataGridViewTextBoxCell tag = new DataGridViewTextBoxCell();
                tag.Value = cc.Tag;
                row.Cells.Add(tag);
                DataGridViewTextBoxCell time = new DataGridViewTextBoxCell();
                time.Value = cc.Time;
                row.Cells.Add(time);
                DataGridViewTextBoxCell note = new DataGridViewTextBoxCell();
                note.Value = cc.Note;
                row.Cells.Add(note);
                DataGridViewButtonCell delete = new DataGridViewButtonCell();
                delete.Value = "删除";
                row.Cells.Add(delete);
                grv_countClock.Rows.Add(row);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            //先删除再添加
            XmlNode countClock = XmlService.CountClockXml.SelectSingleNode("CountClock");
            countClock.RemoveAll();
            XmlService.SaveCountClockXml();
            foreach (DataGridViewRow row in grv_countClock.Rows)
            {
                CountClock cc = new CountClock();
                cc.Tag = row.Cells["cell_tag"].Value.ToString();
                cc.Time = row.Cells["cell_allTime"].Value.ToString();
                cc.Note = row.Cells["cell_note"].Value.ToString();
                cc.SaveToXmlNode();
            }
            clock.ReloadCountClockGrid();
            this.Close();
        }

        private void grv_countClock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex!=-1)
            {
                if (grv_countClock.Columns[e.ColumnIndex].Name=="cell_delete")
                {
                    grv_countClock.Rows.RemoveAt(rowIndex);
                }
                if (grv_countClock.Columns[e.ColumnIndex].Name == "cell_allTime")
                {
                    EditTimeInRow(grv_countClock.Rows[rowIndex]);
                }
            }
        }

        private void EditTimeInRow(DataGridViewRow row)
        {
            CountClockEditTimeForm editForm = new CountClockEditTimeForm(row);
            editForm.ShowDialog();
        }
    }
}
