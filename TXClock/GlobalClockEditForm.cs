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

namespace TXClock
{
    public partial class GlobalClockEditForm : Form
    {
        private Clock clock;
        public GlobalClockEditForm(Clock clock)
        {
            InitializeComponent();
            this.clock = clock;
            LoadGlobalClock();
        }
        public void LoadGlobalClock()
        {
            XmlDocument globalXml = TXDLL.Tools.XmlTools.GetXmlByPath(GlobalParamsConfig.GlobalClockXmlPath);
            XmlNodeList clockNodeList = globalXml.GetElementsByTagName("Clock");
            List<GlobalClock> globalClockList = new List<GlobalClock>();
            foreach (XmlNode clockNode in clockNodeList)
            {
                GlobalClock globalClock = new GlobalClock();
                globalClock.InitFromXmlNode(clockNode);
                globalClockList.Add(globalClock);
            }
            foreach (GlobalClock gc in globalClockList)
            {
                DataGridViewRow row = new DataGridViewRow();
                DataGridViewTextBoxCell tag = new DataGridViewTextBoxCell();
                tag.Value = gc.Tag;
                row.Cells.Add(tag);
                DataGridViewButtonCell edit = new DataGridViewButtonCell();
                edit.Value = "编辑";
                row.Cells.Add(edit);
                DataGridViewButtonCell delete = new DataGridViewButtonCell();
                delete.Value = "删除";
                row.Cells.Add(delete);
                GlobalClockEdit_grv.Rows.Add(row);
            }
        }
        public void ReLoadGlobalClock()
        {
            GlobalClockEdit_grv.Rows.Clear();
            LoadGlobalClock();
        }

        private void GlobalClockEdit_grv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (e.ColumnIndex == 1 && rowIndex != -1)//edit
            {
                EditClock(GlobalClockEdit_grv.Rows[rowIndex].Cells["tag"].Value.ToString());
            }
            else if (e.ColumnIndex == 2 && rowIndex != -1)//delete
            {
                DeleteClock(GlobalClockEdit_grv.Rows[rowIndex].Cells["tag"].Value.ToString());
            }
        }

        private void DeleteClock(string tag)
        {
            if (MessageBox.Show("确认删除" + tag + "吗", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                XmlDocument globalXml = TXDLL.Tools.XmlTools.GetXmlByPath(GlobalParamsConfig.GlobalClockXmlPath);
                GlobalClock globalClock = new GlobalClock();
                globalClock.Tag = tag;
                globalClock.DeleteFromXmlNode(globalXml);
                MessageBox.Show("删除成功!");
                ReLoadGlobalClock();
            }
        }

        private void EditClock(string tag)
        {
            XmlDocument globalXml = TXDLL.Tools.XmlTools.GetXmlByPath(GlobalParamsConfig.GlobalClockXmlPath);
            XmlNodeList clockNodeList = globalXml.GetElementsByTagName("Clock");
            for (int i = 0; i < clockNodeList.Count; i++)
            {
                if (clockNodeList[i].Attributes["tag"].Value.ToString() == tag)
                {
                    GlobalClockEditTimeForm gcetf = new GlobalClockEditTimeForm(clockNodeList[i], this);
                    gcetf.ShowDialog();
                    break;
                }
            }
        }

        private void GlobalClockAdd_btn_Click(object sender, EventArgs e)
        {
            clock.ReLoadGlobalClock();
            this.Close();
        }
    }
}
