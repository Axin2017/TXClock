using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using TXDLL.Tools;

namespace TXClock
{
    public partial class BaseSettingForm : Form
    {
        public BaseSettingForm()
        {
            InitializeComponent();
            XmlDocument configXml = XmlTools.GetXmlByPath(GlobalParamsConfig.ConfigXmlPath);
            string isStartWithWindows = XmlTools.GetInnerTextByUniqueTagName(configXml, "IsStart");
            string isMessage= XmlTools.GetInnerTextByUniqueTagName(configXml, "IsMessage");
            string isDialog= XmlTools.GetInnerTextByUniqueTagName(configXml, "IsDialog");
            if (isMessage=="1")
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

        private void cbk_startWithWds_CheckedChanged(object sender, EventArgs e)
        {
            if (cbk_startWithWds.Checked)
            {
                XmlTools.UpdateInnerTextByUniqueTagName(GlobalParamsConfig.ConfigXmlPath, "IsStart", "1");
                SystemTools.SetProgramAutoRun(GlobalParamsConfig.ApplicationKey, PathTools.AppRootPath+@"\TXClock.exe");
            }else
            {
                XmlTools.UpdateInnerTextByUniqueTagName(GlobalParamsConfig.ConfigXmlPath, "IsStart", "0");
                SystemTools.CancelProgramAutoRun(GlobalParamsConfig.ApplicationKey);
            }
        }

        private void rbt_message_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_message.Checked)
            {
                XmlTools.UpdateInnerTextByUniqueTagName(GlobalParamsConfig.ConfigXmlPath, "IsMessage", "1");
            }
            else
            {
                XmlTools.UpdateInnerTextByUniqueTagName(GlobalParamsConfig.ConfigXmlPath, "IsMessage", "0");
            }
        }


        private void rbt_dialog_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_dialog.Checked)
            {
                XmlTools.UpdateInnerTextByUniqueTagName(GlobalParamsConfig.ConfigXmlPath, "IsDialog", "1");
            }
            else
            {
                XmlTools.UpdateInnerTextByUniqueTagName(GlobalParamsConfig.ConfigXmlPath, "IsDialog", "0");
            }
        }

    }
}
