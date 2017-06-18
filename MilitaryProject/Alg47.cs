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
    public partial class Alg47 : Form
    {
        public Alg47()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(Int32.Parse(txt_BoxШвТеч.Text) <= 2)
                {
                    txt_BoxT.Text = ((2 * Double.Parse(txt_BoxB.Text) / Double.Parse(txt_BoxVt.Text)) + Double.Parse(txt_Boxtnp.Text)).ToString();

                }
                else
                {
                    txt_BoxT.Text = ((2 * Double.Parse(txt_BoxB.Text) / Double.Parse(txt_BoxVt.Text) * (1 + Double.Parse(txt_BoxKзн.Text)) + Double.Parse(txt_Boxtnp.Text))).ToString(); 
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid format");
            }
        }
    }
}
