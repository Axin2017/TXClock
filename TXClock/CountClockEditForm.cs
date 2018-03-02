using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            XmlDocument countXml = TXDLL.Tools.XmlTools.GetXmlByPath(GlobalParamsConfig.CountClockXmlPath);
            XmlNodeList clockNodeList = countXml.GetElementsByTagName("Clock");
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
            bool valid= true;
            foreach (DataGridViewRow row in grv_countClock.Rows)
            {
                if (!TimeService.IsCountClockTime(row.Cells["cell_allTime"].Value.ToString()))
                {
                    valid = false;
                    break;
                }
            }
            if (!valid)
            {
                MessageBox.Show("时间格式不正确，例子： 00:05:20表示0小时5分20秒,目前只能最多到小时");
            }else
            {
                XmlDocument countXml = TXDLL.Tools.XmlTools.GetXmlByPath(GlobalParamsConfig.CountClockXmlPath);
                //先删除再添加
                XmlNode countClock = countXml.SelectSingleNode("CountClock");
                countClock.RemoveAll();
                countXml.Save(GlobalParamsConfig.CountClockXmlPath);
                foreach (DataGridViewRow row in grv_countClock.Rows)
                {
                    CountClock cc = new CountClock();
                    cc.Tag = row.Cells["cell_tag"].Value.ToString();
                    cc.Time= row.Cells["cell_allTime"].Value.ToString();
                    cc.Note= row.Cells["cell_note"].Value.ToString();
                    cc.SaveToXmlNode(countXml);
                }

                clock.ReloadCountClockGrid();
                this.Close();
            }
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
            }
        }
    }
}
