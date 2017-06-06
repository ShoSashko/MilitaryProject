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
    public partial class Alg4 : Form
    {
        public Alg4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sumB = 0;
            string[] temp = Txt_boxLi.Text.Split(' ');
            for(int i = 0; i < temp.Length; i++)
            {
                sumB += Double.Parse(Txt_boxKc.Text) * Double.Parse(temp[i]);
            }
            txt_BoxLb.Text = sumB.ToString();

            double sumV = 0;
            string[] temp1 = Txt_boxVn.Text.Split(' ');
            for(int i = 0; i < temp1.Length; i++)
            {
                sumV += Double.Parse(temp1[i]);
            }
            txt_BoxVcp.Text = (sumV / temp1.Length).ToString();

            txt_BoxTвис.Text = (Double.Parse(txt_BoxLb.Text) / Double.Parse(txt_BoxVcp.Text)).ToString();

            txt_BoxTm.Text = (Double.Parse(Txt_boxTz.Text) + Double.Parse(txt_BoxTp.Text) + Double.Parse(txt_BoxTyz.Text)).ToString();
        }
    }
}
