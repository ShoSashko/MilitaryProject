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
    public partial class Alg18 : Form
    {
        public Alg18()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_Boxti.Text = (Double.Parse(Txt_BoxTi1.Text) + (Double.Parse(Txt_boxdi.Text) * 60) / Double.Parse(txt_BoxV.Text)).ToString();

            txt_Boxtii.Text = (Double.Parse(txt_Boxti.Text) + (Double.Parse(txt_BoxGi.Text) * 60) / Double.Parse(txt_BoxV.Text)).ToString();
        }
    }
}
