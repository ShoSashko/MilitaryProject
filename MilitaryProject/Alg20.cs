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
    public partial class Alg20 : Form
    {
        public Alg20()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                txt_Boxt.Text = ((Double.Parse(Txt_BoxNm.Text) * Double.Parse(Txt_boxdM.Text) * 60) / Double.Parse(txt_BoxV.Text)).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Не правильний формат вводу.");
            }
        }

        private void Alg20_Load(object sender, EventArgs e)
        {

        }
    }
}
