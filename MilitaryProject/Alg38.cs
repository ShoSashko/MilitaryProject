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
    public partial class Alg38 : Form
    {
        public Alg38()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                txt_BoxLIМВЗ.Text = (Double.Parse(txt_BoxЩЗМВЗ.Text) * Double.Parse(txt_BoxLф.Text) * Double.Parse(txt_BoxКтд.Text)).ToString();

                txt_BoxNісвII.Text = (Double.Parse(txt_BoxLIМВЗ.Text) / (Double.Parse(txt_BoxВІСВ.Text) * Double.Parse(txt_BoxТн.Text))).ToString();

                txt_BoxQІБПII.Text = (1000 * Double.Parse(txt_BoxRібд.Text) * Double.Parse(txt_BoxLIМВЗ.Text)).ToString();

                txt_BoxdNібн.Text = (Double.Parse(txt_BoxLIМВЗ.Text) * Double.Parse(txt_BoxНбтт.Text)).ToString();

                txt_Boxgm.Text = (Double.Parse(txt_BoxdNібн.Text) / Double.Parse(txt_BoxNбіт.Text) * Double.Parse(txt_Boxgw.Text)).ToString();

                txt_Boxt.Text = (Double.Parse(txt_Boxgm.Text) / Double.Parse(txt_Boxgw.Text)).ToString();

                txt_BoxQєпб.Text = (Double.Parse(txt_BoxdNібн.Text) * Double.Parse(txt_BoxQнєрб.Text)).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid format");
            }

        }
    }
}
