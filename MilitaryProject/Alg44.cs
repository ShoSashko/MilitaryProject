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
    public partial class Alg44 : Form
    {
        public Alg44()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                txt_Boxt.Text = (((Double.Parse(txt_BoxD.Text) + Double.Parse(txt_BoxN.Text) * Double.Parse(txt_Boxdd.Text)) * 0.06) / (Double.Parse(txt_BoxtV.Text) * Double.Parse(txt_Boxnn.Text))).ToString();

                txt_BoxN.Text = ((Double.Parse(txt_Boxt.Text) * Double.Parse(txt_BoxtV.Text) * Double.Parse(txt_Boxnn.Text) - 0.6 * Double.Parse(txt_BoxD.Text)) / 0.06 * Double.Parse(txt_Boxdd.Text)).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid format");
            }
            }
    }
}
