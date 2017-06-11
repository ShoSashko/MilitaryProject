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
    public partial class Alg22FM : Form
    {
        public Alg22FM()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                txt_Boxtn.Text = (Double.Parse(Txt_BoxT.Text) - (Double.Parse(Txt_boxDp.Text) * 60) / Double.Parse(txt_BoxVвис.Text)).ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("Не правильний формат вводу.");
            }
        }
    }
}
