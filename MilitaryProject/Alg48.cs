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
    public partial class Alg48 : Form
    {
        public Alg48()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                txt_BoxГ.Text = ((Double.Parse(txt_BoxK.Text) - 1) * Double.Parse(txt_Boxl.Text) + Double.Parse(txt_BoxK.Text) * Double.Parse(txt_Boxв.Text)).ToString();


                txt_BoxТ.Text = (60 * Double.Parse(txt_BoxГ.Text) / Double.Parse(txt_BoxV.Text)).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid format");
            }
            }
    }
}
