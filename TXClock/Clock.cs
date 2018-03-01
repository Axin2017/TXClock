using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Windows.Forms;
using System.Xml;
using TXClock.Enums;
using TXClock.Interface;
using TXClock.Model;
using TXClock.Service;
using TXDLL.Winform.Control;
using TXDLL.Winform.Model;

namespace TXClock
{
    public partial class Clock : TXTrayForm
    {
        int count=1;
        private ITimeService timeService;
        private XmlDocument globleDoc;
        private List<GlobalClockTime> globalClockTimeList;
        public Clock()
        {
            InitializeComponent();
            GlobalParamsConfig.Now = DateTime.Now;
            timeService = new TimeService();
            globalClockTimeList = new List<GlobalClockTime>();
            SetTrayInfoAndIcon();
            CheckConfigXml();
            LoadGlobalClock();
            SetTime();
            timer1.Start();
        }
        private void SetTime()
        {
            lb_timeNow.Text =  GlobalParamsConfig.Now.ToString("yyyy/MM/dd HH:mm:ss");
        }
        // 设置托盘图标程序信息和程序的图标
        private void SetTrayInfoAndIcon()
        {
            TXTrayAttribute trayAttr = new TXTrayAttribute();
            trayAttr.BalloonTipText = "qq994234999";
            trayAttr.BalloonTipTitle = "Axin Clock";
            trayAttr.Text = "Axin Clock is running";
            ResourceManager rm = new ResourceManager("TXClock.Clock", Assembly.GetExecutingAssembly());
            this.Icon = (Icon)rm.GetObject("$this.Icon");
            trayAttr.Icon = (Icon)rm.GetObject("TXNotifyIcon.Icon");
            SetTrayAttribute(trayAttr);
        }

        #region 加载闹钟
        public void LoadGlobalClock()
        {
            XmlDocument globalXml = TXDLL.Tools.XmlTools.GetXmlByPath(GlobalParamsConfig.GlobalClockXmlPath);
            this.globleDoc = globalXml;
            XmlNodeList clockNodeList = globalXml.GetElementsByTagName("Clock");
            List<GlobalClockTime> enableGlobalClockTimeList = new List<GlobalClockTime>();
            List<GlobalClockTime> disenableGlobalClockTimeList = new List<GlobalClockTime>();
            foreach (XmlNode clockNode in clockNodeList)
            {
                GlobalClock globalClock = new GlobalClock();
                globalClock.InitFromXmlNode(clockNode);
                foreach (GlobalClockTime gct in globalClock.TimeList)
                {
                    if (gct.Enable)
                    {
                        enableGlobalClockTimeList.Add(gct);
                    }
                    else
                    {
                        disenableGlobalClockTimeList.Add(gct);
                    }
                    globalClockTimeList.Add(gct);
                }
            }
            InitGlobalClockGrid(enableGlobalClockTimeList);
            InitGlobalClockGrid(disenableGlobalClockTimeList);
            ClockGlobalGrd_grd.ClearSelection();
        }
        private void InitGlobalClockGrid(List<GlobalClockTime> globalClockTimeList)
        {
            globalClockTimeList.Sort();
            foreach (GlobalClockTime gct in globalClockTimeList)
            {
                DataGridViewRow row = new DataGridViewRow();
                DataGridViewTextBoxCell tag = new DataGridViewTextBoxCell();
                tag.Value = gct.ParantTag;
                row.Cells.Add(tag);
                DataGridViewTextBoxCell time = new DataGridViewTextBoxCell();
                time.Value = gct.Time;
                row.Cells.Add(time);
                DataGridViewTextBoxCell leftTime = new DataGridViewTextBoxCell();
                leftTime.Value = gct.Enable? gct.LeftTime.ToString().Replace(".", "天 "):"未启用";
                row.Cells.Add(leftTime);
                DataGridViewTextBoxCell note = new DataGridViewTextBoxCell();
                note.Value = gct.Note;
                row.Cells.Add(note);
                DataGridViewTextBoxCell clockType = new DataGridViewTextBoxCell();
                clockType.Value = GlobalClockTypeToChinese(gct.ParentClock.ClockType);
                row.Cells.Add(clockType);
                DataGridViewTextBoxCell enable = new DataGridViewTextBoxCell();
                enable.Value = gct.Enable?"是":"否";
                enable.ReadOnly = false;
                row.Cells.Add(enable);
                if (!gct.Enable)
                {
                    row.DefaultCellStyle.BackColor= Color.LightGray;
                }
                ClockGlobalGrd_grd.Rows.Add(row);
            }
        }
        #endregion
        private string GlobalClockTypeToChinese(GlobalClockType type)
        {
            string typeStr = string.Empty;
            switch (type)
            {
                case GlobalClockType.custom:
                    typeStr = "自定义";
                    break;
                case GlobalClockType.everyDay:
                    typeStr = "每天";
                    break;
                case GlobalClockType.once:
                    typeStr = "一次性";
                    break;
                default:
                    typeStr = "未知类型";
                    break;
            }
            return typeStr;
        }
        private GlobalClockType ChineseToGlobalClockType(string type)
        {
            GlobalClockType gct = GlobalClockType.everyDay;
            switch (type)
            {
                case "自定义":
                    gct = GlobalClockType.custom;
                    break;
                case "一次性":
                    gct = GlobalClockType.once;
                    break;
            }
            return gct;
        }
        public void ReLoadGlobalClock()
        {
            ClockGlobalGrd_grd.Rows.Clear();
            globalClockTimeList.Clear();
            LoadGlobalClock();
        }
        //检测配置文件完整性
        private void CheckConfigXml()
        {
            if (!File.Exists(GlobalParamsConfig.GlobalClockXmlPath))
            {
                XmlDocument xmldoc = new XmlDocument();
                XmlDeclaration xmldecl = xmldoc.CreateXmlDeclaration("1.0", "utf-8", null);
                xmldoc.AppendChild(xmldecl);
                XmlElement GlobalClock = xmldoc.CreateElement("GlobalClock");
                xmldoc.AppendChild(GlobalClock);
                xmldoc.Save(GlobalParamsConfig.GlobalClockXmlPath);
            }
            if (!File.Exists(GlobalParamsConfig.ConfigXmlPath))
            {
                XmlDocument xmldoc = new XmlDocument();
                XmlDeclaration xmldecl = xmldoc.CreateXmlDeclaration("1.0", "utf-8", null);
                xmldoc.AppendChild(xmldecl);
                XmlElement Config = xmldoc.CreateElement("Config");
                xmldoc.AppendChild(Config);
                XmlElement IsMessage = xmldoc.CreateElement("IsMessage");
                IsMessage.InnerText = "1";
                Config.AppendChild(IsMessage);
                XmlElement IsDialog = xmldoc.CreateElement("IsDialog");
                IsDialog.InnerText = "0";
                Config.AppendChild(IsDialog);
                XmlElement IsStart = xmldoc.CreateElement("IsStart");
                IsStart.InnerText = "0";
                Config.AppendChild(IsStart);
                xmldoc.Save(GlobalParamsConfig.ConfigXmlPath);
            }
        }
        //启用或者禁用
        private void ClockGlobalGrd_grd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ClockGlobalGrd_grd.Columns[e.ColumnIndex].Name == "enable")
            {
                int rowIndex = e.RowIndex;
                GlobalClockTime gct = new GlobalClockTime();
                gct.ParantTag = ClockGlobalGrd_grd.Rows[rowIndex].Cells["tag"].Value.ToString();
                gct.Time = ClockGlobalGrd_grd.Rows[rowIndex].Cells["time"].Value.ToString();
                bool isCheck = ClockGlobalGrd_grd.Rows[rowIndex].Cells["enable"].Value.ToString()=="是";
                gct.UpdateState(!isCheck);
                ClockGlobalGrd_grd.Rows[rowIndex].Cells["enable"].Value=isCheck?"否":"是";
                ReLoadGlobalClock();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            GlobalParamsConfig.Now = DateTime.Now;
            SetTime();
            UpdateTimeInGrid();
            if (count>=60)
            {
                count = 0;
            }
        }

        
        private void UpdateTimeInGrid()
        {
            //每分钟刷新一次，防止有误差
            bool refresh = count%60==0;
            foreach (DataGridViewRow row in ClockGlobalGrd_grd.Rows)
            {
                if (row.Cells["enable"].Value.ToString() == "是")
                {
                    string tag = row.Cells["tag"].Value.ToString();
                    string time = row.Cells["time"].Value.ToString();
                    GlobalClock nowGct = null;
                    foreach (GlobalClockTime gct in globalClockTimeList)
                    {
                        if (gct.ParantTag == tag)
                        {
                            nowGct = gct.ParentClock;
                            break;
                        }
                    }
                    if (nowGct == null)//按道理来说不会有这种情况,这种情况直接刷新
                    {
                        refresh = true;
                    }
                    else
                    {
                        TimeSpan newTimeSpan = timeService.GetLeftTime(time, nowGct.ClockType, nowGct.WeekList);
                        row.Cells["leftTime"].Value = newTimeSpan.ToString();
                        if (newTimeSpan <= TimeSpan.Parse("00:00:01"))
                        {
                            GlobalClockRun(row);
                            refresh = true;
                        }
                    }
                }
            }
            if (refresh)
            {
                ReLoadGlobalClock();
            }
        }
        //触发闹钟
        private void GlobalClockRun(DataGridViewRow row)
        {
            XmlDocument configXml = TXDLL.Tools.XmlTools.GetXmlByPath(GlobalParamsConfig.ConfigXmlPath);
            if (row.Cells["clockType"].Value.ToString() == GlobalClockTypeToChinese(GlobalClockType.once))
            {
                GlobalClockTime gct = new GlobalClockTime();
                gct.ParantTag = row.Cells["tag"].Value.ToString();
                gct.Time = row.Cells["time"].Value.ToString();
                gct.DeleteOnceTime();
            }
            string tag = row.Cells["tag"].Value.ToString();
            string note = row.Cells["note"].Value.ToString();
            if (string.IsNullOrEmpty(note))
            {
                note = tag;
            }
            if (TXDLL.Tools.XmlTools.GetInnerTextByUniqueTagName(configXml, "IsMessage")=="1")
            {
                ShowBalloonTip(tag,note,2000);
            }
            else if (TXDLL.Tools.XmlTools.GetInnerTextByUniqueTagName(configXml, "IsDialog") == "1")
            {
                DialogTip dt = new DialogTip(tag, note);
                dt.ShowDialog();
            }
        }

       
        private void btn_addGlobalClock_Click(object sender, EventArgs e)
        {
            GlobalClockAddForm addForm = new GlobalClockAddForm(this);
            addForm.ShowDialog();
        }

        private void btn_editGlobalClock_Click(object sender, EventArgs e)
        {
            GlobalClockEditForm editForm = new GlobalClockEditForm(this);
            editForm.ShowDialog(this);
        }

        private void Setting_tsmi_Click(object sender, EventArgs e)
        {
            BaseSettingForm settingForm = new BaseSettingForm();
            settingForm.ShowDialog();
        }
    }
}
