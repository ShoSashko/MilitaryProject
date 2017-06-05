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
                Tools.Parsing("T D V Gk Gp tn" ,txt_BoxT.Text, txt_box_D.Text, txt_BoxV.Text, txt_BoxGk.Text, txt_BoxGp.Text, txt_Boxtn.Text);
                txt_BoxTвт.Text = (Tools.dictionary["T"] + (Tools.dictionary["D"] / Tools.dictionary["V"])).ToString();
                txt_BoxT.Text = " "; txt_box_D.Text = " "; txt_BoxV.Text = " "; txt_BoxGk.Text = " "; txt_BoxGp.Text = " "; txt_Boxtn.Text = " ";
            }
            else { MessageBox.Show("Condition isn't true"); }
        }
    }
}
