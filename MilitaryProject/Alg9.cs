﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilitaryProject
{
    public partial class Alg9 : Form
    {
        public Alg9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_Boxtктра.Text = (Double.Parse(Txt_boxTвбп.Text) - (Double.Parse(Txt_boxDвпб.Text) * 60) / Double.Parse(Txt_boxVвис.Text)).ToString();
        }
    }
}
