using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TXClock
{
    public partial class GlobalClockEditTimeInRowForm : Form
    {
        private DataGridViewRow row;
        public GlobalClockEditTimeInRowForm(DataGridViewRow row)
        {
            InitializeComponent();
            this.row = row;
            InitComBox();
        }

        private void InitComBox()
        {
            string time = row.Cells["time"].Value.ToString();
            string[] timeArray = time.Split(':');
            int[] hour = new int[24];
            int[] minute = new int[60];
            for (int i = 0; i < hour.Length; i++)
            {
                hour[i] = i;
            }
            cbo_hour.DataSource = hour;
            cbo_hour.SelectedIndex = int.Parse(timeArray[0]);
            for (int i = 0; i < minute.Length; i++)
            {
                minute[i] = i;
            }
            cbo_minute.DataSource = minute;
            cbo_minute.SelectedIndex = int.Parse(timeArray[1]);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string time = cbo_hour.SelectedItem.ToString() + ":" + cbo_minute.SelectedItem.ToString();
            row.Cells["time"].Value = time;
            this.Close();
        }
    }
}
