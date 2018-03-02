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
using TXClock.Enums;
using TXClock.Model;

namespace TXClock
{
    public partial class GlobalClockAddForm : MyClockForm
    {
        CheckBox[] weekCb;
        private Clock clock;
        public GlobalClockAddForm(Clock clock)
        {
            InitializeComponent();
            weekCb = new CheckBox[] { GlobalClockAddAdd_cb0, GlobalClockAddAdd_cb1, GlobalClockAddAdd_cb2, GlobalClockAddAdd_cb3, GlobalClockAddAdd_cb4, GlobalClockAddAdd_cb5, GlobalClockAddAdd_cb6 };
            this.clock = clock;
            globalClock = new GlobalClock();
            foreach (CheckBox box in weekCb)
            {
                box.Checked = GlobalClockAddAdd_rb1.Checked;
            }
        }

        public override void ReloadData()
        {
            GlobalClockAdd_grv.Rows.Clear();
            foreach (GlobalClockTime gct in globalClock.TimeList)
            {
                DataGridViewRow row = new DataGridViewRow();
                DataGridViewTextBoxCell timeCell = new DataGridViewTextBoxCell();
                timeCell.Value = gct.Time;
                row.Cells.Add(timeCell);
                DataGridViewTextBoxCell tagCell = new DataGridViewTextBoxCell();
                row.Cells.Add(tagCell);
                tagCell.Value = gct.Note;
                DataGridViewButtonCell deleteCell = new DataGridViewButtonCell();
                deleteCell.Value = "删除";
                row.Cells.Add(deleteCell);
                GlobalClockAdd_grv.Rows.Add(row);
            }
        }

        private void GlobalClockAddAdd_btn_Click(object sender, EventArgs e)
        {
            AddClockForm addForm = new AddClockForm(this);
            addForm.ShowDialog();
        }

        private void GlobalClockAdd_grv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (e.ColumnIndex==2 && rowIndex != -1)
            {
                GlobalClockAdd_grv.Rows.RemoveAt(rowIndex);
            }
        }

        private void GlobalClockAddSave_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(GlobalClockAddTag_txt.Text) || GlobalClockAdd_grv.Rows.Count == 0)
            {
                MessageBox.Show("请输入闹钟标签或者添加至少一个时间");
            }
            else if (CheckTagExists(GlobalClockAddTag_txt.Text))
            {
                MessageBox.Show("该标签已存在，请输入新标签");
            }
            else
            {
                GlobalClock globalClock = new GlobalClock();
                globalClock.Tag = GlobalClockAddTag_txt.Text;
                foreach (DataGridViewRow dr in GlobalClockAdd_grv.Rows)
                {
                    GlobalClockTime gct = new GlobalClockTime();
                    gct.Note = dr.Cells["tag"].Value.ToString();
                    gct.Time = dr.Cells["time"].Value.ToString();
                    gct.ParantTag = GlobalClockAddTag_txt.Text;
                    gct.Enable = true;
                    globalClock.TimeList.Add(gct);
                }
                if (GlobalClockAddAdd_rb1.Checked)
                {
                    globalClock.ClockType = GlobalClockType.everyDay;
                }else if (GlobalClockAddAdd_rb2.Checked)
                {
                    globalClock.ClockType = GlobalClockType.custom;
                }else
                {
                    globalClock.ClockType = GlobalClockType.once;
                }

                for (int i = 0; i < weekCb.Length; i++)
                {
                    if (weekCb[i].Checked)
                    {
                        globalClock.WeekList.Add((WeekType)Enum.ToObject(typeof(WeekType), i));
                    }
                }
                if (globalClock.WeekList.Count == 0 && globalClock.ClockType == GlobalClockType.custom)
                {
                    MessageBox.Show("自定义模式必须选择星期!");
                    return;
                }
                XmlDocument doc = GetGlobalClockXml();
                globalClock.SaveToXmlNode(doc);
                clock.ReLoadGlobalClock();
                this.Close();
            }
        }

        private bool CheckTagExists(string tag)
        {
            bool exists = false;
            XmlDocument globalXml = TXDLL.Tools.XmlTools.GetXmlByPath(GlobalParamsConfig.GlobalClockXmlPath);
            XmlNodeList clockNodeList = globalXml.GetElementsByTagName("Clock");
            for (int i = 0; i < clockNodeList.Count; i++)
            {
                if (clockNodeList[i].Attributes["tag"].Value.ToString() == tag)
                {
                    exists = true;
                    break;
                }
            }
            return exists;
        }

        private XmlDocument GetGlobalClockXml()
        {
            return TXDLL.Tools.XmlTools.GetXmlByPath(GlobalParamsConfig.GlobalClockXmlPath);
        }

        private void GlobalClockAddAdd_rb1_CheckedChanged(object sender, EventArgs e)
        {
            foreach (CheckBox box in weekCb)
            {
                box.Enabled = !GlobalClockAddAdd_rb1.Checked;
                box.Checked = GlobalClockAddAdd_rb1.Checked;
            }
        }

    }
}
