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
    public partial class Alg26 : Form
    {
        public Alg26()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                txt_BoxPМВ.Text = (Double.Parse(txt_BoxNМБ.Text) / Double.Parse(txt_BoxF.Text)).ToString();

                txt_BoxРТ.Text = (Double.Parse(txt_BoxNt.Text) / Double.Parse(txt_BoxF.Text)).ToString();

                txt_BoxРПТРТ.Text = (Double.Parse(txt_BoxNПТКР.Text) / Double.Parse(txt_BoxF.Text)).ToString();

                txt_BoxРГМ.Text = (Double.Parse(txt_BoxNГМ.Text) / Double.Parse(txt_BoxF.Text)).ToString();

                txt_BoxPМВЗ.Text = (Double.Parse(txt_BoxtDM.Text) / Double.Parse(txt_BoxF.Text)).ToString();

                txt_BoxPk.Text = (Double.Parse(txt_Boxmозбр.Text) / Double.Parse(txt_BoxF.Text)).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Не правильний формат вводу.");
            }
        }
    }
}
