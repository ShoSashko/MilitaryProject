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
    public partial class Algorythm3 : Form
    {
        public Algorythm3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                txt_Boxt.Text = (((Double.Parse(Txt_boxD.Text) / Double.Parse(Txt_boxV.Text)) + (Double.Parse(Txt_boxN.Text) - 1) / Double.Parse(Txt_boxNum.Text)) * 24 + Double.Parse(Txt_boxD1.Text) / Double.Parse(Txt_boxV1.Text) + Double.Parse(Txt_boxD2.Text) / Double.Parse(Txt_boxV2.Text) + Double.Parse(Txt_boxt0.Text)).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Не правильний формат вводу.");
            }
        }
    }
}
