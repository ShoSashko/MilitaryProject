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

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Algorytm2 task2 = new Algorytm2();
            task2.Show();
        }

        private void роToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Algorythm3 task3 = new Algorythm3();
            task3.Show();
        }

        private void розрахунокЧасуЗміниПозиційрайонівРозташуванняToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void алгоритмРозрахункуОчікуваногоЧасуЗустрічіТаВіддаленняЙмовірногоРубежуЗустрічіЗПротивникомToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void алгоритмРозрахункуПоВогневомуУраженнюПротивникаУЗустрічномуБоюToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
        }

        private void потребаПальногоНаМаршToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FuelCalculate fuelC = new FuelCalculate();
            fuelC.Show();
        }

        private void розрахунокПотребиАвтомобілівДляВиконанняОбсягівПеревезеньМатеріальнотехнічнихЗасобівБригадиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alg5 alg5 = new Alg5();
            alg5.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
