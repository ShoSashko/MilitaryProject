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
    public partial class Algorytm1 : Form
    {
        public Algorytm1()
        {
            InitializeComponent();
        }

        private void btn_exe_Click(object sender, EventArgs e)
        {
            if(Int32.Parse(txt_BoxGk.Text) > Int32.Parse(txt_BoxGp.Text))
            {
                txt_BoxTвт.Text = (Int32.Parse(txt_BoxT.Text) + Double.Parse(txt_box_D.Text) / Double.Parse(txt_BoxV.Text) + ((Double.Parse(txt_BoxGk.Text) - Double.Parse(txt_BoxGp.Text)) / 0.6 * Double.Parse(txt_BoxV.Text)) * Double.Parse(txt_Boxtn.Text)).ToString();

                txt_BoxtRez.Text = (Double.Parse(txt_box_D.Text) / Double.Parse(txt_BoxV.Text) + Double.Parse(txt_Boxtn.Text) + Double.Parse(txt_BoxTвт.Text)).ToString();
            }
        }
    }
}
