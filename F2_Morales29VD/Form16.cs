﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F2_Morales29VD
{
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double m = Convert.ToDouble(textBox1.Text);
            double c = m * 100000000;
            label4.Text = c.ToString();
        }
    }
}
