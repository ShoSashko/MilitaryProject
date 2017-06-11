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
    public partial class Alg7 : Form
    {
        public Alg7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                txt_BoxtrezВитяг.Text = (Double.Parse(Txt_boxLВитяг.Text) / Double.Parse(Txt_boxVвитяг.Text)).ToString();

                txt_BoxTруху.Text = (Double.Parse(Txt_boxS.Text) / Double.Parse(Txt_boxVсер.Text)).ToString();

                txt_Boxtвтяг.Text = ((Double.Parse(Txt_boxГк.Text) - Double.Parse(txt_BoxГр.Text) / Double.Parse(Txt_boxVвтяг.Text))).ToString();

                txt_BoxTС3.Text = ((Double.Parse(txt_BoxtrezВитяг.Text) + Double.Parse(txt_BoxTруху.Text)) + Double.Parse(txt_Boxtвтяг.Text)).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Не правильний формат вводу.");
            }
        }
    }
}
