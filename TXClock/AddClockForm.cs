using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TXClock.Model;

namespace TXClock
{
    public partial class AddClockForm : Form
    {
        private MyClockForm pForm;
        public AddClockForm(MyClockForm pForm)
        {
            InitializeComponent();
            this.pForm = pForm;
        }

        private void AddClockSave_btn_Click(object sender, EventArgs e)
        {
            string time = AddClockTime_txt.Text;
            if (!time.Contains(":") || time.Split(':').Length!=2)
            {
                MessageBox.Show("时间格式不正确，例子： 05:20表示上午五点二十");
            }else
            {
                GlobalClockTime gct = new GlobalClockTime();
                gct.Time = time;
                gct.Note = AddClockTipText_txt.Text;
                foreach (GlobalClockTime g in pForm.globalClock.TimeList)
                {
                    if (g.Time==gct.Time)
                    {
                        MessageBox.Show("已经有一个相同的时间了，请修改!");
                        return;
                    }
                }
                pForm.globalClock.TimeList.Add(gct);
                pForm.ReloadData();
                this.Close();
            }
        }
    }
}
