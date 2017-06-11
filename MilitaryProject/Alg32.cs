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
    public partial class Alg32 : Form
    {
        public Alg32()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_BoxtXm.Text = (((Double.Parse(txt_Boxda.Text) * Double.Parse(txt_BoxXmp.Text)) + (Double.Parse(txt_Boxdp.Text) * Double.Parse(Txt_boxXma.Text))) / (Double.Parse(txt_Boxda.Text) + Double.Parse(txt_Boxdp.Text))).ToString();
            txt_BoxyYm.Text = (((Double.Parse(txt_Boxda.Text) * Double.Parse(txt_BoxYmp.Text)) + (Double.Parse(txt_Boxdp.Text) * Double.Parse(txt_BoxYma.Text))) / (Double.Parse(txt_Boxda.Text) + Double.Parse(txt_Boxdp.Text))).ToString();

        }

        private void Alg32_Load(object sender, EventArgs e)
        {

        }
    }
}
