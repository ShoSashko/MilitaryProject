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
    public partial class Alg3k : Form
    {
        public Alg3k()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                txt14.Text = (Double.Parse(txt1.Text) - Double.Parse(txt2.Text)).ToString();
                txt17.Text = (Double.Parse(txt3.Text) - Double.Parse(txt4.Text)).ToString();
                txt15.Text = (Double.Parse(txt17.Text) - Double.Parse(txt2.Text)).ToString();
                txt16.Text = (Double.Parse(txt14.Text) - Double.Parse(txt15.Text)).ToString();
                txt18.Text = (Double.Parse(txt11.Text) * Double.Parse(txt12.Text)).ToString();
                txt19.Text = (Double.Parse(txt11.Text) * Double.Parse(txt13.Text)).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Не правильний формат вводу.");
            }
        }
    }
}
