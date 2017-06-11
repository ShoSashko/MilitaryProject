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
    public partial class Alg29 : Form
    {
        public Alg29()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_Boxt.Text = ((60 * Double.Parse(Txt_boxD.Text)) / Double.Parse(txt_BoxV.Text) + Double.Parse(txt_Boxt1.Text) + Double.Parse(txt_Boxt1.Text)).ToString();


        }
    }
}
