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
    public partial class Alg50 : Form
    {
        public Alg50()
        {
            InitializeComponent();
        }

        private void Alg50_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                txt_BoxmKПІДСІСР.Text = ((Double.Parse(txt_BoxПНГУ.Text) * Double.Parse(txt_BoxLНГУ.Text) + Double.Parse(txt_BoxПНДУ.Text) * Double.Parse(txt_BoxLНДУ.Text)) / Double.Parse(txt_BoxMICP.Text) * Double.Parse(txt_BoxTC3.Text) - Double.Parse(txt_BoxNІCP.Text)).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid format");
            }
        }
    }
}
