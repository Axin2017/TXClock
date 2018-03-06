using System;
using System.Windows.Forms;

namespace TXClock
{
    public partial class CountClockEditTimeForm : Form
    {
        private DataGridViewRow row;
        public CountClockEditTimeForm(DataGridViewRow row)
        {
            InitializeComponent();
            this.row = row;
            InitComBox();
        }

        private void InitComBox()
        {
            string time = row.Cells["cell_allTime"].Value.ToString();
            string[] timeArray = time.Split(':');
            int[] hour = new int[24];
            int[] minute = new int[60];
            int[] second = new int[60];
            for (int i = 0; i < hour.Length; i++)
            {
                hour[i] = i;
            }
            cbo_hour.DataSource = hour;
            cbo_hour.SelectedIndex = int.Parse(timeArray[0]);
            for (int i = 0; i < minute.Length; i++)
            {
                minute[i] = i;
                second[i] = i;
            }
            cbo_minute.DataSource = minute;
            cbo_minute.SelectedIndex = int.Parse(timeArray[1]);
            cbo_second.DataSource = second;
            cbo_second.SelectedIndex = int.Parse(timeArray[2]);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string time = cbo_hour.SelectedItem.ToString() + ":" + cbo_minute.SelectedItem.ToString() + ":" + cbo_second.SelectedItem.ToString();
            row.Cells["cell_allTime"].Value = time;
            this.Close();
        }
    }
}
