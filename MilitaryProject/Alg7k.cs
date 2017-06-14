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
    public partial class Alg7k : Form
    {
        public Alg7k()
        {
            InitializeComponent();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                textBox14.Text = (Double.Parse(textBox3.Text) / Double.Parse(textBox4.Text)).ToString();
                textBox15.Text = (Double.Parse(textBox2.Text) / Double.Parse(textBox4.Text)).ToString();
                textBox12.Text = (Double.Parse(textBox11.Text) + Double.Parse(textBox14.Text)).ToString();
                textBox13.Text = (Double.Parse(textBox11.Text) + Double.Parse(textBox15.Text)).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Не правильний формат вводу.");
            }
        }
    }
}
