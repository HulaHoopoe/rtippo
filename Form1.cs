﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContractsList
{
    // 

    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }


        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
