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
    public partial class Alg2k : Form
    {
        public Alg2k()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                res.Text = (Double.Parse(txt1.Text) * Double.Parse(txt4.Text) + Double.Parse(txt2.Text) * Double.Parse(txt5.Text) + Double.Parse(txt3.Text) * Double.Parse(txt6.Text)).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Не правильний формат вводу.");
            }
        }
    }
}
