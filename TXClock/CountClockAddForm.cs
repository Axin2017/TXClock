﻿using System;
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
    public partial class CountClockAddForm : Form
    {
        public string AddTime { get; set; }
        
        public CountClockAddForm()
        {
            InitializeComponent();
        }
    }
}