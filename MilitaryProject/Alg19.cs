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
    public partial class Alg19 : Form
    {
        public Alg19()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                txt_BoxGk.Text = ((Double.Parse(Txt_BoxNm.Text) * Double.Parse(Txt_boxdM.Text) + (Double.Parse(txt_BoxNk.Text) - 1 * Double.Parse(txt_BoxdK.Text))) / 1000).ToString();

                txt_Boxt.Text = ((Double.Parse(txt_BoxGk.Text) + Double.Parse(txt_BoxD.Text)) / Double.Parse(txt_BoxV.Text)).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Не правильний формат вводу.");
            }
        }
    }
}
