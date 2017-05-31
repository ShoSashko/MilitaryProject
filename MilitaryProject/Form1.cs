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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void розрахунокТривалостіМаршрутуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Algorytm1 task1 = new Algorytm1();
            task1.Show();
        }
    }
}
