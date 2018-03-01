using System;
using System.Windows.Forms;
using System.Xml;
using TXClock.Enums;
using TXClock.Model;

namespace TXClock
{
    public partial class GlobalClockEditTimeForm : MyClockForm
    {
        private GlobalClockEditForm editForm;
        RadioButton[] typeRb;
        CheckBox[] weekCb;
        public GlobalClockEditTimeForm(XmlNode xmlNode,GlobalClockEditForm editForm)
        {
            InitializeComponent();
            this.editForm = editForm;
            this.globalClock = new GlobalClock();
            globalClock.InitFromXmlNode(xmlNode);
            typeRb = new RadioButton[] { GlobalClockEditType_rb1 , GlobalClockEditType_rb2, GlobalClockEditType_rb3};
            weekCb = new CheckBox[] { GlobalClockEditWeek_cb0, GlobalClockEditWeek_cb1, GlobalClockEditWeek_cb2, GlobalClockEditWeek_cb3, GlobalClockEditWeek_cb4, GlobalClockEditWeek_cb5, GlobalClockEditWeek_cb6};
            InitClock();
        }
        private void InitClock()
        {
            GlobalClockEditTag_txt.Text = globalClock.Tag;
            InitTimeGrid();
            typeRb[(int)globalClock.ClockType].Checked = true;
            foreach (WeekType wt in globalClock.WeekList)
            {
                weekCb[(int)wt].Checked = true;
            }
            if (globalClock.ClockType==GlobalClockType.everyDay)
            {
                for (int i = 0; i < weekCb.Length; i++)
                {
                    weekCb[i].Enabled = false;
                }
            }
        }
        public void InitTimeGrid()
        {
            foreach (GlobalClockTime gct in globalClock.TimeList)
            {
                DataGridViewRow row = new DataGridViewRow();
                DataGridViewTextBoxCell timeCell = new DataGridViewTextBoxCell();
                timeCell.Value = gct.Time;
                row.Cells.Add(timeCell);
                DataGridViewTextBoxCell tipCell = new DataGridViewTextBoxCell();
                row.Cells.Add(tipCell);
                tipCell.Value = gct.Note;
                DataGridViewButtonCell deleteCell = new DataGridViewButtonCell();
                deleteCell.Value = "删除";
                row.Cells.Add(deleteCell);
                GlobalClockEdit_grv.Rows.Add(row);
            }
        }
        public override void ReloadData()
        {
            GlobalClockEdit_grv.Rows.Clear();
            InitTimeGrid();
        }

        private void GlobalClockEditType_rb1_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < weekCb.Length; i++)
            {
                weekCb[i].Enabled = !GlobalClockEditType_rb1.Checked;
                weekCb[i].Checked= GlobalClockEditType_rb1.Checked;
            }
        }

        private void GlobalClockEdit_grv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (e.ColumnIndex == 2)
            {
                globalClock.TimeList.RemoveAt(rowIndex);
                GlobalClockEdit_grv.Rows.RemoveAt(rowIndex);
            }
        }

        private void GlobalClockEditAdd_btn_Click(object sender, EventArgs e)
        {
            AddClockForm addForm = new AddClockForm(this);
            addForm.ShowDialog();
        }

        private void GlobalClockEditSave_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(GlobalClockEditTag_txt.Text) || GlobalClockEdit_grv.Rows.Count == 0)
            {
                MessageBox.Show("请输入闹钟标签或者添加至少一个时间");
            }
            else
            {
                XmlDocument doc = TXDLL.Tools.XmlTools.GetXmlByPath(GlobalParamsConfig.GlobalClockXmlPath);
                GlobalClock newClock = new GlobalClock();
                newClock.Tag = GlobalClockEditTag_txt.Text;
                foreach (DataGridViewRow dr in GlobalClockEdit_grv.Rows)
                {
                    GlobalClockTime gct = new GlobalClockTime();
                    gct.Note = dr.Cells["tag"].Value.ToString();
                    gct.Time = dr.Cells["time"].Value.ToString();
                    gct.ParantTag = GlobalClockEditTag_txt.Text;
                    gct.Enable = true;
                    newClock.TimeList.Add(gct);
                }
                if (GlobalClockEditType_rb1.Checked)
                {
                    newClock.ClockType = GlobalClockType.everyDay;
                }
                else if (GlobalClockEditType_rb2.Checked)
                {
                    newClock.ClockType = GlobalClockType.custom;
                }
                else
                {
                    newClock.ClockType = GlobalClockType.once;
                }
                for (int i = 0; i < weekCb.Length; i++)
                {
                    if (weekCb[i].Checked)
                    {
                        newClock.WeekList.Add((WeekType)Enum.ToObject(typeof(WeekType), i));
                    }
                }
                if (globalClock.WeekList.Count == 0 && globalClock.ClockType == GlobalClockType.custom)
                {
                    MessageBox.Show("自定义模式必须选择星期!");
                    return;
                }
                globalClock.DeleteFromXmlNode(doc);
                newClock.SaveToXmlNode(doc);
                editForm.ReLoadGlobalClock();
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
    }
}
