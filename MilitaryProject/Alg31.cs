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
    public partial class Alg31 : Form
    {
        public Alg31()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                txt_Boxxц.Text = (Double.Parse(Txt_boxD.Text) * Math.Cos(Double.Parse(txt_BoxA.Text))).ToString();

                txt_Boxyц.Text = (Double.Parse(Txt_boxD.Text) * Math.Sin(Double.Parse(txt_BoxA.Text))).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Не правильний формат вводу.");
            }
        }

        private void Alg31_Load(object sender, EventArgs e)
        {

        }
    }
}
