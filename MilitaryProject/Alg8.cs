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
    public partial class Alg8 : Form
    {
        public Alg8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_Boxtn.Text = (Double.Parse(Txt_boxT.Text) - (Double.Parse(Txt_boxDв.Text) * 60) / Double.Parse(Txt_boxVв.Text)).ToString();
        }
    }
}
