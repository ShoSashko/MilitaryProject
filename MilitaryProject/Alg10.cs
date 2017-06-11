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
    public partial class Alg10 : Form
    {
        public Alg10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                txt_Boxti.Text = (Double.Parse(txt_BoxTin.Text) + (Double.Parse(Txt_boxdi.Text) * 60) / Double.Parse(Txt_boxV.Text)).ToString();

                txt_BoxTiii.Text = (Double.Parse(txt_Boxti.Text) + Double.Parse(Txt_boxГi.Text) * 60 / Double.Parse(Txt_boxV.Text)).ToString();

                txt_BoxTn.Text = (Double.Parse(Txt_boxT.Text) - (Double.Parse(Txt_boxDв.Text) * 60) / Double.Parse(txt_BoxVв.Text)).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Не правильний формат вводу.");
            }
        }
    }
}
