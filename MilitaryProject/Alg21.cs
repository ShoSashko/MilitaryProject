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
    public partial class Alg21 : Form
    {
        public Alg21()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                txt_Boxtc.Text = (Double.Parse(txt_Boxt1.Text) + Double.Parse(txt_Boxt2.Text) + Double.Parse(txt_Boxt3.Text)).ToString();
                txt_Boxtn.Text = (Double.Parse(txt_Boxt11.Text) + Double.Parse(txt_Boxt22.Text) + Double.Parse(txt_Boxt33.Text)).ToString();

                txt_Boxtз.Text = ((Double.Parse(txt_BoxD.Text) + Double.Parse(txt_Boxtc.Text) * Double.Parse(txt_BoxVc.Text) + Double.Parse(txt_Boxtn.Text) * Double.Parse(txt_BoxVn.Text)) / (Double.Parse(txt_BoxVc.Text) + Double.Parse(txt_BoxVn.Text))).ToString();

                txt_Boxlp.Text = (Double.Parse(txt_BoxVc.Text) * (Double.Parse(txt_Boxtз.Text) - Double.Parse(txt_Boxtn.Text))).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Не правильний формат вводу.");
            }

        }

        private void Alg21_Load(object sender, EventArgs e)
        {

        }
    }
}
