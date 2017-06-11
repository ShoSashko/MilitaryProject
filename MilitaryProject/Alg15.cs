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
    public partial class Alg15 : Form
    {
        public Alg15()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                txt_Boxtppрк.Text = ((Double.Parse(Txt_boxДрррк.Text) * 60) / Double.Parse(Txt_boxVрозг.Text)).ToString();

                txt_Boxtррвк.Text = (((Double.Parse(Txt_boxДррвк.Text) - Double.Parse(Txt_boxДрррк.Text)) * 60) / Double.Parse(Txt_boxVрозг.Text)).ToString();

                txt_Boxtpвб.Text = (((Double.Parse(txt_BoxДвб.Text) - Double.Parse(Txt_boxДррвк.Text)) * 90) / Double.Parse(Txt_boxVрозг.Text)).ToString();

                txt_BoxТс.Text = (Double.Parse(Txt_boxTвб.Text) - Double.Parse(txt_Boxtpвб.Text) - Double.Parse(txt_Boxtррвк.Text) - Double.Parse(txt_Boxtppрк.Text)).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Не правильний формат вводу.");
            }
        }
    }
}
