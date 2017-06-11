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
    public partial class Alg25 : Form
    {
        public Alg25()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_BoxNцзрозб.Text = (Double.Parse(Txt_Boxn.Text) * Double.Parse(Txt_boxKбвф.Text)).ToString();



            double temp = 0;
            for (int i = 0; i < Int32.Parse(Txt_Boxn.Text); i++)
            {
                temp += Double.Parse(txt_BoxNцзрозб.Text);
            }

            txt_BoxNц.Text = temp.ToString();
        }
    }
}
