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
    public partial class Algorythm3 : Form
    {
        public Algorythm3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tools.Parsing("D V N n D1 V1 D2 V2 t0", Txt_boxD.Text, Txt_boxV.Text, Txt_boxN.Text, Txt_boxNum.Text, Txt_boxD1.Text, Txt_boxV1.Text, Txt_boxD2.Text, Txt_boxV2.Text, Txt_boxt0.Text);
            txt_Boxt.Text = ((Tools.dictionary["D"] / Tools.dictionary["V"]) + ((Tools.dictionary["N"] - 1) / Tools.dictionary["n"]) * 24 + Tools.dictionary["D1"] / Tools.dictionary["V1"] + Tools.dictionary["D2"] / Tools.dictionary["V2"] + Tools.dictionary["t0"]).ToString(); 
        }
    }
}
