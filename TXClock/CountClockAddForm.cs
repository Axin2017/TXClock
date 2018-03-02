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
        public CountClockAddForm(Clock clock)
        {
            InitializeComponent();
            this.clock = clock;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string tag = txt_tag.Text;
            string time = txt_time.Text;
            string note = txt_note.Text;
            if (string.IsNullOrEmpty(tag) || string.IsNullOrEmpty(time))
            {
                MessageBox.Show("标签或者时间必填!");
                return;
            }
            if (!TimeService.IsCountClockTime(time))
            {
                MessageBox.Show("时间格式不正确，例子： 00:05:20表示0小时5分20秒,目前只能最多到小时");
                return;
            }
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
