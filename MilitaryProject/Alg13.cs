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
    public partial class Alg13 : Form
    {
        public Alg13()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_Boxt.Text = ((Double.Parse(Txt_BoxD.Text) * 60) / Double.Parse(Txt_boxV.Text) + Double.Parse(txt_Boxt1.Text) + Double.Parse(txt_Boxt2.Text)).ToString();
        }

    }
}
