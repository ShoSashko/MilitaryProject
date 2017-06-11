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
    public partial class Alg24 : Form
    {
        public Alg24()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // number should be equal 
                double help = 0;

                string[] partNi = Txt_BoxNi.Text.Split(' ');
                string[] partni = Txt_boxnsmalli.Text.Split(' ');
                string[] partmi = txt_Boxmi.Text.Split(' ');

                for (int i = 0; i < partNi.Length; i++)
                {
                    help += (Double.Parse(partNi[i]) * Double.Parse(partni[i])) / Double.Parse(partmi[i]);

                }
                txt_BoxM.Text = help.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Не правильний формат вводу.");
            }
        }
    }
}
