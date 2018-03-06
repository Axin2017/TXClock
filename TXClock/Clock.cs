using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Resources;
using System.Windows.Forms;
using System.Xml;
using TXClock.Enums;
using TXClock.Model;
using TXClock.Service;
using TXDLL.Winform.Control;
using TXDLL.Winform.Model;

namespace TXClock
{
    public partial class Clock : TXTrayForm
    {
        #region 闹钟属性
        private List<GlobalClockTime> globalClockTimeList;
        #endregion
        #region 倒计时属性
        private List<CountClock> countClockList;
        private bool allStop = false;
        #endregion
        public Clock()
        {
            InitializeComponent();
            SetTrayInfoAndIcon();
            try
            {
                XmlService.CheckXml();
                XmlService.InitXml();
            }
            catch(Exception ex)
            {
                MessageBox.Show("初始化配置文件失败!"+ex.Message);
            }
            try
            {
                ParamsConfig.Now = DateTime.Now;
                SetTime();
                #region 闹钟初始化
                globalClockTimeList = new List<GlobalClockTime>();
                LoadGlobalClock();
                #endregion
                #region 倒计时初始化
                countClockList = new List<CountClock>();
                LoadCountClock();
                #endregion
                #region 设置初始化
                LoadSetting();
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show("初始化失败!" + ex.Message);
                TXDLL.Tools.LogTools.WriteLog(ex.ToString(), "error");
            }
            timer1.Start();
        }
        /// <summary>
        /// 设置界面额的时间
        /// </summary>
        private void SetTime()
        {
            lb_timeNow.Text =  ParamsConfig.Now.ToString("yyyy/MM/dd HH:mm:ss");
            lb_timeNow1.Text= ParamsConfig.Now.ToString("yyyy/MM/dd HH:mm:ss");
        }
        /// <summary>
        /// 设置托盘图标程序信息和程序的图标
        /// </summary>
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
        /// <summary>
        /// 加载设置
        /// </summary>
        private void LoadSetting()
        {
            XmlDocument configXml = XmlService.ConfigXml;
            string isStartWithWindows = TXDLL.Tools.XmlTools.GetInnerTextByUniqueTagName(configXml, "IsStart");
            string isMessage = TXDLL.Tools.XmlTools.GetInnerTextByUniqueTagName(configXml, "IsMessage");
            string isDialog = TXDLL.Tools.XmlTools.GetInnerTextByUniqueTagName(configXml, "IsDialog");
            if (isMessage == "1")
            {
                rbt_message.Checked = true;
            }
            if (isStartWithWindows == "1")
            {
                cbk_startWithWds.Checked = true;
            }
            if (isDialog == "1")
            {
                rbt_dialog.Checked = true;
            }
        }

        #region 加载闹钟
        private void LoadGlobalClock()
        {
            XmlNodeList clockNodeList = XmlService.GlobalClockXml.GetElementsByTagName("Clock");
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
                DataGridViewTextBoxCell enable = new DataGridViewTextBoxCell();
                enable.Value = gct.Enable ? "是" : "否";
                enable.ReadOnly = false;
                row.Cells.Add(enable);
                DataGridViewTextBoxCell clockType = new DataGridViewTextBoxCell();
                clockType.Value = GlobalClockTypeToChinese(gct.ParentClock.ClockType);
                row.Cells.Add(clockType);
                DataGridViewTextBoxCell note = new DataGridViewTextBoxCell();
                note.Value = gct.Note;
                row.Cells.Add(note);
                if (!gct.Enable)
                {
                    row.DefaultCellStyle.BackColor= Color.LightGray;
                }
                ClockGlobalGrd_grd.Rows.Add(row);
            }
        }
        public void ReLoadGlobalClock()
        {
            ClockGlobalGrd_grd.Rows.Clear();
            globalClockTimeList.Clear();
            LoadGlobalClock();
        }
        #endregion
        #region 全局闹钟类型和字符换的转换
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
        #endregion
        
        //启用或者禁用
        private void ClockGlobalGrd_grd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (ClockGlobalGrd_grd.Columns[e.ColumnIndex].Name == "enable" && rowIndex!=-1)
            {
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
            ParamsConfig.Now = DateTime.Now;
            SetTime();
            try
            {
                UpdateTimeInGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("出现运行错误!"+ex.Message);
                TXDLL.Tools.LogTools.WriteLog(ex.ToString(), "error");
            }
        }
        
        private void UpdateTimeInGrid()
        {
            #region 闹钟
            //每分钟刷新一次，防止有误差
            bool refresh = false;
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
                        TimeSpan newTimeSpan = TimeService.GetGlobalClockLeftTime(time, nowGct.ClockType, nowGct.WeekList);
                        row.Cells["leftTime"].Value = newTimeSpan.ToString().Replace(".", "天 ");
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
            #endregion
            #region 倒计时
            if (allStop!=true) {
                foreach (DataGridViewRow row in grv_countingClock.Rows)
                {
                    if (row.Cells["cell_enable"].Value.ToString() == "是")
                    {
                        string time = row.Cells["cell_leftTime"].Value.ToString();
                        string[] timeArray = time.Split(':');
                        TimeSpan sp = new TimeSpan(int.Parse(timeArray[0]), int.Parse(timeArray[1]), int.Parse(timeArray[2]));
                        sp = sp.Add(new TimeSpan(0, 0, -1));
                        row.Cells["cell_leftTime"].Value = (sp.Days * 24 + sp.Hours).ToString() + ":" + sp.Minutes + ":" + sp.Seconds;
                        if (sp <= TimeSpan.Parse("00:00:00"))
                        {
                            CountClockRun(row);
                        }
                    }
                }
            }
            #endregion
        }
        //触发闹钟
        private void GlobalClockRun(DataGridViewRow row)
        {
            if (row.Cells["clockType"].Value.ToString() == GlobalClockTypeToChinese(GlobalClockType.once))
            {
                GlobalClockTime gct = new GlobalClockTime();
                gct.ParantTag = row.Cells["tag"].Value.ToString();
                gct.Time = row.Cells["time"].Value.ToString();
                gct.DeleteOnceTime();
            }
            string tag = row.Cells["tag"].Value.ToString();
            string note = row.Cells["note"].Value.ToString();
            ClockRun(tag, note);
        }
        //触发倒计时
        private void CountClockRun(DataGridViewRow row)
        {
            string tag = row.Cells["cell_countingTag"].Value.ToString();
            string note = row.Cells["cell_countingNote"].Value.ToString();
            grv_countingClock.Rows.Remove(row);
            ClockRun(tag, note);
        }

        private void ClockRun(string tag,string note)
        {
            if (string.IsNullOrEmpty(note))
            {
                note = tag;
            }
            XmlDocument configXml = XmlService.ConfigXml;
            if (TXDLL.Tools.XmlTools.GetInnerTextByUniqueTagName(configXml, "IsMessage") == "1")
            {
                ShowBalloonTip(tag, note, 2000);
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

        private void btn_addCountClock_Click(object sender, EventArgs e)
        {
            CountClockAddForm countAddForm = new CountClockAddForm(this);
            countAddForm.ShowDialog();
        }
        #region 加载常用倒计时
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
                DataGridViewButtonCell startCount = new DataGridViewButtonCell();
                startCount.Value = "计时";
                row.Cells.Add(startCount);
                grv_countClock.Rows.Add(row);
            }
        }
        public void ReloadCountClockGrid()
        {
            grv_countClock.Rows.Clear();
            countClockList.Clear();
            LoadCountClock();
        }
        #endregion
        private void btn_editCountClock_Click(object sender, EventArgs e)
        {
            CountClockEditForm countEditForm = new CountClockEditForm(this);
            countEditForm.ShowDialog();
        }

        private void grv_countClock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex!=-1 && grv_countClock.Columns[e.ColumnIndex].Name == "cell_startCount")
            {
                string tagStr = grv_countClock.Rows[rowIndex].Cells["cell_tag"].Value.ToString();
                string leftTimeStr = grv_countClock.Rows[rowIndex].Cells["cell_allTime"].Value.ToString();
                string noteStr= grv_countClock.Rows[rowIndex].Cells["cell_note"].Value.ToString();
                AddRowToCountingClock(tagStr, leftTimeStr, noteStr);
            }
        }

        public void AddRowToCountingClock(string tagStr, string leftTimeStr, string noteStr)
        {
            DataGridViewRow row = new DataGridViewRow();
            DataGridViewTextBoxCell tag = new DataGridViewTextBoxCell();
            tag.Value = tagStr;
            row.Cells.Add(tag);
            DataGridViewTextBoxCell time = new DataGridViewTextBoxCell();
            time.Value = leftTimeStr;
            row.Cells.Add(time);
            DataGridViewTextBoxCell enable = new DataGridViewTextBoxCell();
            enable.Value = "是";
            row.Cells.Add(enable);
            DataGridViewButtonCell delete = new DataGridViewButtonCell();
            delete.Value = "删除";
            row.Cells.Add(delete);
            DataGridViewTextBoxCell note = new DataGridViewTextBoxCell();
            note.Value = noteStr;
            row.Cells.Add(note);
            grv_countingClock.Rows.Add(row);
        }

        private void grv_countingClock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex != -1 && grv_countingClock.Columns[e.ColumnIndex].Name == "cell_enable")
            {
                if (grv_countingClock.Rows[rowIndex].Cells["cell_enable"].Value.ToString()=="是")
                {
                    SetCountingClockEnable(grv_countingClock.Rows[rowIndex], false);
                }
                else
                {
                    SetCountingClockEnable(grv_countingClock.Rows[rowIndex], true);
                }
            }
            else if (rowIndex != -1 && grv_countingClock.Columns[e.ColumnIndex].Name == "cell_delete")
            {
                grv_countingClock.Rows.RemoveAt(rowIndex);
            }
        }

        private void SetCountingClockEnable(DataGridViewRow row,bool enable)
        {
            if (enable)
            {
                row.Cells["cell_enable"].Value = "是";
                row.DefaultCellStyle.BackColor = Color.White;
            }else
            {
                row.Cells["cell_enable"].Value = "否";
                row.DefaultCellStyle.BackColor = Color.LightGray;
            }
        }

        private void StartAllCount_btn_Click(object sender, EventArgs e)
        {
            allStop = true;
            foreach (DataGridViewRow row in grv_countingClock.Rows)
            {
                SetCountingClockEnable(row, false);
            }
        }

        private void StopAllCount_btn_Click(object sender, EventArgs e)
        {
            allStop = false;
            foreach (DataGridViewRow row in grv_countingClock.Rows)
            {
                SetCountingClockEnable(row, true);
            }
        }

        private void btn_addOnceCountClock_Click(object sender, EventArgs e)
        {
            CountClockAddForm countAddForm = new CountClockAddForm(this);
            countAddForm.IsOnce = true;
            countAddForm.ShowDialog();
        }
        #region 设置
        private void cbk_startWithWds_CheckedChanged(object sender, EventArgs e)
        {
            if (cbk_startWithWds.Checked)
            {
                TXDLL.Tools.XmlTools.UpdateInnerTextByUniqueTagName(ParamsConfig.ConfigXmlPath, "IsStart", "1");
                TXDLL.Tools.SystemTools.SetProgramAutoRun(ParamsConfig.ApplicationKey, TXDLL.Tools.PathTools.AppRootPath + @"TXClock.exe");
            }
            else
            {
                TXDLL.Tools.XmlTools.UpdateInnerTextByUniqueTagName(ParamsConfig.ConfigXmlPath, "IsStart", "0");
                TXDLL.Tools.SystemTools.CancelProgramAutoRun(ParamsConfig.ApplicationKey);
            }
        }

        private void rbt_message_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_message.Checked)
            {
                TXDLL.Tools.XmlTools.UpdateInnerTextByUniqueTagName(ParamsConfig.ConfigXmlPath, "IsMessage", "1");
            }
            else
            {
                TXDLL.Tools.XmlTools.UpdateInnerTextByUniqueTagName(ParamsConfig.ConfigXmlPath, "IsMessage", "0");
            }
        }

        private void rbt_dialog_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_dialog.Checked)
            {
                TXDLL.Tools.XmlTools.UpdateInnerTextByUniqueTagName(ParamsConfig.ConfigXmlPath, "IsDialog", "1");
            }
            else
            {
                TXDLL.Tools.XmlTools.UpdateInnerTextByUniqueTagName(ParamsConfig.ConfigXmlPath, "IsDialog", "0");
            }
        }
        #endregion
    }
}
