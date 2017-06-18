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
    public partial class Alg51 : Form
    {
        public Alg51()
        {
            InitializeComponent();
        }

        private void Alg51_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                txt_BoxNям.Text = (Double.Parse(txt_BoxNk.Text) * Double.Parse(txt_BoxBik.Text)).ToString();

                txt_BoxLМВЗ.Text = (Double.Parse(txt_BoxNд.Text) * Double.Parse(txt_BoxBiд.Text) + Double.Parse(txt_BoxNk.Text) * Double.Parse(txt_BoxBik.Text)).ToString();

                
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid format");
            }
        }
    }
}
