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
    public partial class Alg5k : Form
    {
        public Alg5k()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                txt15.Text = (20 / Double.Parse(txt9.Text)).ToString();
                txt16.Text = (0.0001 * Double.Parse(txt1.Text) * Double.Parse(txt2.Text) * Double.Parse(txt6.Text)).ToString();
                txt17.Text = ((Double.Parse(txt11.Text) * Double.Parse(txt13.Text)) / (Double.Parse(txt10.Text) * Double.Parse(txt15.Text) * Double.Parse(txt16.Text))).ToString();
                txt14.Text = (Double.Parse(txt12.Text) + Double.Parse(txt5.Text)).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Не правильний формат вводу.");
            }
        }
    }
}
