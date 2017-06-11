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
    public partial class Alg14 : Form
    {
        public Alg14()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                txt_Boxta.Text = ((Double.Parse(Txt_boxDa.Text) * 60) / Double.Parse(txt_BoxVa.Text)).ToString();

                txt_Boxtp.Text = (Double.Parse(txt_Boxta.Text) + (Double.Parse(Txt_boxDp.Text) * 90) / Double.Parse(Txt_boxV.Text)).ToString();

                txt_Boxtб.Text = (Double.Parse(txt_Boxtp.Text) + (Double.Parse(txt_Boxtб.Text) * 60) / Double.Parse(Txt_boxV.Text)).ToString();

                txt_Boxtpp.Text = (Double.Parse(txt_Boxtб.Text) + (Double.Parse(txt_BoxDpp.Text) * 60) / Double.Parse(Txt_boxV.Text)).ToString();

                txt_BoxИ.Text = (Double.Parse(txt_Boxtpp.Text) + (Double.Parse(Txt_boxDИ.Text) * 60) / Double.Parse(Txt_boxV.Text)).ToString();

                txt_Boxtвит.Text = (Double.Parse(txt_BoxИ.Text) + (Double.Parse(txt_BoxD.Text) * 90) / Double.Parse(Txt_boxV.Text)).ToString();

                txt_Boxtu.Text = (Double.Parse(txt_Boxtвит.Text) - (Double.Parse(txt_BoxГк.Text) + Double.Parse(txt_Boxdk.Text) * 90) / Double.Parse(Txt_boxV.Text)).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Не правильний формат вводу.");
            }

        }
    }
}
