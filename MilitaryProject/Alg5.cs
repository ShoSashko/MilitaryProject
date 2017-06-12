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
    public partial class Alg5 : Form
    {
        public Alg5()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Alg5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                textBox12.Text = (Double.Parse(textBox7.Text) / (Double.Parse(textBox3.Text) * Double.Parse(textBox6.Text) * Double.Parse(textBox2.Text))).ToString(); //4.210
                textBox11.Text = (Double.Parse(textBox5.Text) / (Double.Parse(textBox4.Text) + Double.Parse(textBox9.Text) + Double.Parse(textBox8.Text))).ToString(); //4.211
            }
            catch (Exception)
            {
                MessageBox.Show("Не правильний формат вводу.");
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
