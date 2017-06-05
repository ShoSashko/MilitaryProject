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
    public partial class Alg6 : Form
    {
        public Alg6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox7.Text = (Double.Parse(textBox1.Text) * Double.Parse(textBox2.Text) * Double.Parse(textBox3.Text) * Double.Parse(textBox4.Text) / (Double.Parse(textBox5.Text) * Double.Parse(textBox6.Text)) ).ToString(); //4.167
        }
    }
}
