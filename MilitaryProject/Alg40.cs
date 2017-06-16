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
    public partial class Alg40 : Form
    {
        public Alg40()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                txt_BoxNN.Text = (Double.Parse(txt_BoxD.Text) * Double.Parse(txt_BoxP.Text) * Double.Parse(txt_Boxn.Text)).ToString();
            }
            catch (Exception f)
            {
                
                MessageBox.Show("Invalid format {0}",f.Message);
            }
            
        }
    }
}
