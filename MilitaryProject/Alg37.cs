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
    public partial class Alg37 : Form
    {
        public Alg37()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double sumKP = 0;
                string[] helpPi = txt_BoxPi.Text.Split(' ');
                string[] helpKi = txt_BoxKi.Text.Split(' ');
                if (helpKi.Length == helpPi.Length)
                {
                    for (int i = 0; i < helpKi.Length; i++)
                    {
                        sumKP += Double.Parse(helpPi[i]) * Double.Parse(helpKi[i]);
                    }
                    txt_BoxНл.Text = sumKP.ToString();
                }
                else
                {
                    MessageBox.Show("Кількість значень Ki має бути рівна кількості значень Pi");
                }
                double sumKM = 0;
                string[] helpMi = txt_BoxMi.Text.Split(' ');

                if (helpKi.Length == helpMi.Length)
                {
                    for (int i = 0; i < helpKi.Length; i++)
                    {
                        sumKM += Double.Parse(helpKi[i]) * Double.Parse(helpMi[i]);
                    }
                }
                else
                {
                    MessageBox.Show("Кількість значень Ki має бути рівна кількості значень Mi");
                }
                txt_BoxКл.Text = (Double.Parse(txt_BoxНл.Text) / Double.Parse(txt_Boxt.Text)).ToString();

                txt_BoxКм.Text = (Double.Parse(txt_BoxНм.Text) / 20 * Double.Parse(txt_Boxt.Text)).ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("Невірний формат вводу");
            }
        }
    }
}
