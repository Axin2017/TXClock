using System;
using System.Windows.Forms;

namespace TXClock
{
    public partial class DialogTip : Form
    {
        public DialogTip(string title,string content)
        {
            InitializeComponent();
            this.Text = title;
            this.lb_note.Text = content;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
