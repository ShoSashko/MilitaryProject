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
    public partial class Alg46 : Form
    {
        public Alg46()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                txt_BoxNДВМПnpj.Text = (Double.Parse(txt_BoxNДВМПj.Text) * Double.Parse(txt_BoxnHj.Text)).ToString();

                txt_BoxNМПnpj.Text = (Double.Parse(txt_BoxNбj.Text) * Double.Parse(txt_BoxnHj.Text)).ToString();

                txt_BoxNHГРj.Text = txt_BoxNДВМПnpj.Text;

                txt_BoxNІСВj.Text = (Double.Parse(txt_BoxmBj.Text) * Double.Parse(txt_BoxNМПnpj.Text)).ToString();

                txt_BoxQBj.Text = (1.5 * Double.Parse(txt_BoxNМПnpj.Text)).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid format");
            }
        }
    }
}
