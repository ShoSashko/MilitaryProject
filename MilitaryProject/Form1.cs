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
            Alg13 alg13 = new Alg13();
            alg13.Show();
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

        private void розрахунокВизначенняМожливостейЗЕвакуаціїРакетноартилерійськогоОзброєнняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alg6 alg6 = new Alg6();
            alg6.Show();
        }

        private void розрахунокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alg4 alg4 = new Alg4();
            alg4.Show();
        }

        private void розрахунокМаневренихМожливостейЗєднаньЧастинТаПідрозділівToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alg7 alg7 = new Alg7();

            alg7.Show();
        }

        private void розрахункиЧасуВиходуПохідноїОхорониНаВихіднийРубіжДляЙогоЗахопленняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alg8 alg8 = new Alg8();
            alg8.Show();
        }

        private void розрахункиЧасуВиходуДругогоЕшелонурезервуПротивникаНаРубіжКонтратакиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alg9 alg9 = new Alg9();
            alg9.Show();
        }

        private void розрахункиЧасуНаРозгортанняПротивникаВБойовийПорядокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alg10 alg10 = new Alg10();
            alg10.Show();
        }

        private void очікуванийЧасЗустрічіІВідстаньІмовірногоРубежуЗустрічіЗПротивникомToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alg11 alg11 = new Alg11();
            alg11.Show();
        }

        private void очікуванийЧасІШвидкістьРухуПриПереслідуванніПротивникаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alg12 alg12 = new Alg12();
            alg12.Show();
        }

        private void розрахунокЧасуНаВисуванняІРозгортанняПідрозділівДляПереходуВАтакуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alg14 alg14 = new Alg14();
            alg14.Show();
        }

        private void алгоритмРозрахункуВводуВБійДругогоЕшелонурезервуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alg15 alg15 = new Alg15();
            alg15.Show();
        }
    }
}
