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
    public partial class Algorytm2 : Form
    {
        public Algorytm2()
        {
            InitializeComponent();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double sumI = 0;
                double sumV = 0;

                //start D
                string[] ValueI = Txt_boxIi.Text.Split(' ');
                for (int i = 0; i < ValueI.Length; i++)
                {
                    sumI += Double.Parse(ValueI[i]);
                }
                txt_BoxD.Text = sumI.ToString();
                // Completed D

                // start Td
                string[] ValueV = Txt_boxVi.Text.Split(' ');
                for (int i = 0; i < ValueV.Length; i++)
                {
                    sumV += Double.Parse(ValueV[i]);
                }
                txt_BoxTd.Text = (sumI / sumV).ToString();
                //Completed Td

                //start V

                txt_BoxV.Text = sumV.ToString();

                //completed V

                //start t
                txt_Boxt.Text = ((Double.Parse(Txt_boxGk.Text) - Double.Parse(Txt_boxGp.Text)) / 0.6 * Double.Parse(txt_BoxV.Text) + Double.Parse(Txt_boxTn.Text)).ToString();

                //completed t
            }
            catch (Exception)
            {
                MessageBox.Show("Не правильний формат вводу.");
            }
            //Warning Km
        }

        private void Algorytm2_Load(object sender, EventArgs e)
        {

        }
    }
}
