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
    public partial class Alg36 : Form
    {
        public Alg36()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)

        {
            try
            {
                txt_BoxКПІДСІСР.Text = ((Double.Parse(txt_BoxПНГУ.Text) * Double.Parse(txt_BoxLНГУД.Text) + Double.Parse(txt_BoxПНДУ.Text) * Double.Parse(txt_BoxLНДУД.Text)) / (Double.Parse(txt_BoxМІСР.Text) * Double.Parse(txt_BoxТСЗ.Text)) - Double.Parse(txt_BoxNІСР.Text)).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Невірний формат вводу.");
            }
            }
    }
}
