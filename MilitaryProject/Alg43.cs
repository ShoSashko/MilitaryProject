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
    public partial class Alg43 : Form
    {
        public Alg43()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_Boxt.Text = (2 * Double.Parse(txt_BoxD.Text) / Double.Parse(txt_BoxV.Text) * (1 + 0.3 * Double.Parse(txt_BoxVв.Text) + Double.Parse(txt_Boxt1.Text))).ToString();
        }
    }
}
