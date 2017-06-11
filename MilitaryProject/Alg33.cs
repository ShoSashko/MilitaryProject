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
    public partial class Alg33 : Form
    {
        public Alg33()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_BoxtD.Text = Math.Sqrt(Math.Pow((Double.Parse(txt_BoxXnn.Text) - Double.Parse(Txt_boxXm.Text)), 2) + Math.Pow((Double.Parse(txt_BoxYnn.Text) - Double.Parse(txt_BoxYm.Text)), 2)).ToString();

            txt_Boxfi.Text = Math.Atan((Double.Parse(txt_BoxYnn.Text) - Double.Parse(txt_BoxYm.Text)) / (Double.Parse(txt_BoxXnn.Text) - Double.Parse(Txt_boxXm.Text))).ToString();
        }
    }
}
