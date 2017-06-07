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
    public partial class Alg11 : Form
    {
        public Alg11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_Boxtв.Text = (Double.Parse(Txt_BoxD.Text)/(Double.Parse(txt_BoxVн.Text) - Double.Parse(Txt_boxVn.Text))).ToString();

            txt_BoxLp.Text = (Double.Parse(txt_Boxtв.Text) * Double.Parse(txt_BoxVн.Text)).ToString();
        }
    }
}
