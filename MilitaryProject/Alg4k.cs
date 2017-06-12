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
    public partial class Alg4k : Form
    {
        public Alg4k()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                txt18.Text = (Double.Parse(txt1.Text) * (Double.Parse(txt2.Text) - Double.Parse(txt3.Text))).ToString();
                txt20.Text = (Double.Parse(txt5.Text) * Double.Parse(txt18.Text)).ToString();
                txt19.Text = (1 / Double.Parse(txt20.Text)).ToString();
                txt21.Text = (Double.Parse(txt6.Text) / Double.Parse(txt18.Text)).ToString();
                txt22.Text = (Double.Parse(txt7.Text) / Double.Parse(txt8.Text)).ToString();
                txt24.Text = ((Double.Parse(txt18.Text) / Double.Parse(txt9.Text)) * (Double.Parse(txt12.Text) / Double.Parse(txt10 .Text))).ToString();
                txt23.Text = (Double.Parse(txt19.Text) * Double.Parse(txt21.Text) * Double.Parse(txt22.Text) * Double.Parse(txt24.Text)).ToString();
                txt25.Text = (0.8 * 100 / Double.Parse(txt12.Text)).ToString();
                txt26.Text = (Double.Parse(txt14.Text) / Double.Parse(txt15.Text)).ToString();
                txt27.Text = (Double.Parse(txt19.Text) * Double.Parse(txt22.Text)).ToString();
                txt28.Text = ((2 * 3.1415 * Double.Parse(txt16.Text)) / Double.Parse(txt17.Text)).ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("Не правильний формат вводу.");
            }
        }
    }
}
