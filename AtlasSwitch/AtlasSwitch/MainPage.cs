﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtlasSwitch
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void QtsBtn_Click(object sender, EventArgs e)
        {
            Quotes qtswin = new Quotes();
            qtswin.MdiParent = this;
            qtswin.Show();
        }
    }
}
