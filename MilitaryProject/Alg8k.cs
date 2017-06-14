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
    public partial class Alg8k : Form
    {
        public Alg8k()
        {
            InitializeComponent();
        }

        private void Alg8k_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                textBox12.Text = (Double.Parse(textBox1.Text) * (1 - Double.Parse(textBox5.Text)) - Double.Parse(textBox2.Text)).ToString();
                textBox13.Text = (Double.Parse(textBox3.Text) * (Double.Parse(textBox5.Text) / Double.Parse(textBox4.Text))).ToString();
                textBox14.Text = ((Double.Parse(textBox12.Text) / Double.Parse(textBox6.Text))).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Не правильний формат вводу.");
            }
        }
    }
}
