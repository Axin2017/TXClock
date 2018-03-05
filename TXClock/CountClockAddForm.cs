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
    public partial class CountClockAddForm : Form
    {
        private Clock clock;
        public bool IsOnce { set; get; }
        public CountClockAddForm(Clock clock)
        {
            InitializeComponent();
            this.clock = clock;
            InitCombox();
        }
        private void InitCombox()
        {
            int[] hour = new int[24];
            int[] minute = new int[60];
            int[] second = new int[60];
            for (int i = 0; i < hour.Length; i++)
            {
                hour[i] = i;
            }
            cbo_hour.DataSource = hour;
            for (int i = 0; i < minute.Length; i++)
            {
                minute[i] = i;
                second[i] = i;
            }
            cbo_minute.DataSource = minute;
            cbo_second.DataSource = second;
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            string tag = txt_tag.Text;
            string time = cbo_hour.SelectedItem.ToString() + ":" + cbo_minute.SelectedItem.ToString() + ":" + cbo_second.SelectedItem.ToString();
            string note = txt_note.Text;
            if (string.IsNullOrEmpty(tag) || string.IsNullOrEmpty(time))
            {
                MessageBox.Show("标签或者时间必填!");
                return;
            }
            if (IsOnce)
            {
                clock.AddRowToCountingClock(tag, time, note);
            } else {
                if (CheckTagExists(tag))
                {
                    MessageBox.Show("该标签已存在!");
                    return;
                }
                CountClock cc = new CountClock();
                cc.Tag = tag;
                cc.Time = time;
                cc.Note = note;
                cc.SaveToXmlNode(TXDLL.Tools.XmlTools.GetXmlByPath(GlobalParamsConfig.CountClockXmlPath));
                clock.ReloadCountClockGrid();
            }
            this.Close();
        }
        private bool CheckTagExists(string tag)
        {
            bool exists = false;
            XmlDocument countXml = TXDLL.Tools.XmlTools.GetXmlByPath(GlobalParamsConfig.CountClockXmlPath);
            XmlNodeList clockNodeList = countXml.GetElementsByTagName("Clock");
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
