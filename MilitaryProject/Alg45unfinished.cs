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
    public partial class Alg45unfinished : Form
    {
        public Alg45unfinished()
        {
            InitializeComponent();
        }

        private void Alg45_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                txt_BoxDНГУnm.Text = (Double.Parse(txt_BoxLНГУnm.Text) * Double.Parse(txt_BoxПНГУnm.Text)).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid format");
            }
           
        }
    }
}
