using System;
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
    public partial class Alg17 : Form
    {
        public Alg17()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_Boxtn.Text = (Double.Parse(Txt_BoxT.Text) - (Double.Parse(Txt_boxDвих.Text) * 60) / Double.Parse(txt_BoxVвит.Text)).ToString();

        }
    }
}
