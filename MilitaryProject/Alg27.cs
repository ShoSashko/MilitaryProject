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
    public partial class Alg27 : Form
    {
        public Alg27()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                txt_BoxM.Text = (Double.Parse(txt_BoxL.Text) / Double.Parse(Txt_Boxf.Text) * Double.Parse(Txt_boxN.Text)).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Не правильний формат вводу.");
            }
        }
    }
}
