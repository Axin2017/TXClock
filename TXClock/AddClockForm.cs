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
using TXClock.Service;

namespace TXClock
{
    public partial class AddClockForm : Form
    {
        private MyClockForm pForm;
        public AddClockForm(MyClockForm pForm)
        {
            InitializeComponent();
            this.pForm = pForm;
            InitCombox();
        }

        private void InitCombox()
        {
            int[] hour = new int[24];
            int[] minute = new int[60];
            for (int i=0;i<hour.Length;i++)
            {
                hour[i] = i;
            }
            cbo_hour.DataSource = hour;
            for (int i = 0; i < minute.Length; i++)
            {
                minute[i] = i;
            }
            cbo_minute.DataSource = minute;
        }

        private void AddClockSave_btn_Click(object sender, EventArgs e)
        {
            string time = cbo_hour.SelectedItem.ToString() + ":" + cbo_minute.SelectedItem.ToString();
            GlobalClockTime gct = new GlobalClockTime();
            gct.Time = time;
            gct.Note = AddClockTipText_txt.Text;
            foreach (GlobalClockTime g in pForm.globalClock.TimeList)
            {
                if (g.Time == gct.Time)
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
