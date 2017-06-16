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
            Alg21 alg21 = new Alg21();
            alg21.Show();
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

        private void розрахунокПідйомуВійськовихЗапасівРечовогоМайнаДляЗдійсненняМаршуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alg1k alg1 = new Alg1k();
            alg1.Show();
        }

        private void розрахунокВизначенняОбємуПідвезенняподачіРакетІБоєприпасівРіБВПідрозділиМеханізованоїБригадиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alg3k alg3 = new Alg3k();
            alg3.Show();
        }

        private void розрахунокВизначенняПотребиВЕвакуаціїРакетноартилерійськогоОзброєнняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alg2k alg2 = new Alg2k();
            alg2.Show();
        }

        private void розрахункиАерозольногодимовогоМаскуванняРубежівToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alg4k alg4 = new Alg4k();
            alg4.Show();
        }

        private void розрахункиЧасуПеретинуЗониРадіоактивногоЗараженняПоЗаданійЗоніОпроміненняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alg5k alg5 = new Alg5k();
            alg5.Show();
        }

        private void алгоритмРозрахункуТривалостіВтягуванняПохідноїКолониВРайонЗосередженняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alg16 alg16 = new Alg16();
            alg16.Show();
        }

        private void алгоритмРозрахункуТривалостіВисуванняПохідноїКолониДоВихідногоРубежупунктуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alg17 alg17 = new Alg17();
            alg17.Show();
        }

        private void алгоритмРозрахункуЧасуПроходженняВихідногоРубежупунктуРубежупунктуРегулюванняГоловоюТаХвостомПохідноїКолониToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alg18 alg18 = new Alg18();
            alg18.Show();
        }

        private void алгоритмРозрахункуГлибиниПохідногоПорядкуЩоСкладаєтьсяЗДекількохПохіднихКолонToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alg19 alg19 = new Alg19();
            alg19.Show();

        }

        private void алгоритмРозрахункуТривалостіПодоланняВузькихМісцьДілянокМаршрутуЩоВажкоДолаютьсяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alg20 alg20 = new Alg20();
            alg20.Show();
        }

        private void алгоритмРозрахункуЧасуНеобхідногоДляВисуванняТаВиходуНаРубежівихіднийРегулюванняРозгортанняВБатальйонніРотніВзводніКолониРубіжПереходуВАтакуТаРубіжСпішуванняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alg22FM alg22 = new Alg22FM();
            alg22.Show();
        }

        private void розрахунокВогневихМожливостейСвоїхВійськПоНанесеннюУраженняЗВогневихРубежівToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alg23 alg23 = new Alg23();
            alg23.Show();
        }

        private void розрахунокПоВогневомуУраженнюПротивникаПриПроведеніКонтратакиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alg24 alg24 = new Alg24();
            alg24.Show();
        }

        private void розрахунокВогневихМожливостейСвоїхВійськПоНанесеннюУраженняЗВогневихРубежівПриВідбиттіКонтратакПротивникаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alg25 alg25 = new Alg25();
            alg25.Show();
        }

        private void розрахунокВогневихМожливостейСвоїхВійськПоВизначеннюЩільностіСилІЗасобівНа1КмФронтуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alg26 alg26 = new Alg26();
            alg26.Show();
        }

        private void ураженняПідрозділівПохідноїОхорониПротивникаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alg27 alg27 = new Alg27();
            alg27.Show();
        }

        private void розрахунокЧасуНаРозгортанняВогневихЗасобівартилерійськихПідрозділівУЗустрічномуБоюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alg28 alg28 = new Alg28();
            alg28.Show();
        }

        private void алгоритмРозрахункуТривалостіЗміниВогневихПозиційрайонівРозташуванняЗасобамиППОToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alg30 alg30 = new Alg30();
            alg30.Show();
        }

        private void визначенняПоточнихКоординатБойовоїМашиниПриПроведенніЦілерозподілуТаЦілевказуванніToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alg32 alg32 = new Alg32();
            alg32.Show();
        }

        private void визначенняВідстаніДоПунктуПризначенняТаКутаНаНьогоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alg33 alg33 = new Alg33();
            alg33.Show();
        }

        private void розрахункиЧасуНаЗмінуВогневихПозиційАртилерієюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alg29 alg29 = new Alg29();
            alg29.Show();
        }

        private void розрахункиЗонРадіоактивногоХімічногоЗараженняТаПодоланняДілянокЗараженняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alg6k alg6 = new Alg6k();
            alg6.Show();
        }

        private void розрахунокЧасуОрганізаціїТаВеденняІнженерноїРозвідкиОбєктуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alg7k alg7 = new Alg7k();
            alg7.Show();
        }

        private void розрахунокОбсягуІнженернихЗаходівМаскуванняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alg8k alg = new Alg8k();
            alg.Show();
        }

        private void розрахунокНеобхідноїКількостіІнженернорозвідувальнихПідрозділівToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alg35 alg35 = new Alg35();
            alg35.Show();
        }

        private void розрахункиЗОрганізаціїТаВеденняІнженерноїРозвідкиОбєктуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alg34 alg34 = new Alg34();
            alg34.Show();
        }

        private void розрахунокКількостіСилІЗасобівДляІнженерногоОбладнанняМісцевостіToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alg36 alg36 = new Alg36();
            alg36.Show();
        }

        private void алгоритмРозрахункуКількостіСилТаЗасобівДляФортифікаційногоОбладнанняСмугирайонуОборониToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alg37 alg37 = new Alg37();
            alg37.Show();
        }

        private void розрахунокЧасткиУчастіІнженернихЗагородженьУВогневомуУраженніПротивникаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alg38 alg38 = new Alg38();
            alg38.Show();
        }

        private void розрахунокМожливостейЩодоУлаштуванняМВЗІзВрахуваннямЕфективностіТаМожливостейПротивникаПоЇхПодоланнюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alg39 alg39 = new Alg39();
            alg39.Show();
        }

        private void розрахунокЩодоПроробленняПроходівВДистанційновстановленихІУЗвичайнихМінновибуховихЗагородженняхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alg46 alg46 = new Alg46();
            alg46.Show();
        }

        private void розрахунокСтворенняІнженернихЗагородженьНаТанконебезпечнихНапрямкахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alg45unfinished alg45 = new Alg45unfinished();
            alg45.Show();
        }

        private void розрахунокЧасуНеобхідногоДляПереправиТанківЧерезБрідІПідВодоюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alg44 alg44 = new Alg44();
            alg44.Show();
        }

        private void розрахунокЧасуНеобхідногоДляРейсуПереправочнихЗасобівToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alg43 alg43 = new Alg43();
            alg43.Show();
        }

        private void розрахунокЧасуНеобхідногоДляПереправиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alg42 alg42 = new Alg42();
            alg42.Show();
        }

        private void методикаРозрахункуНаПереправуПриФорсуванніВоднихПерешкодToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alg41 alg41 = new Alg41);
            alg41.Show();
        }

        private void розрахунокКількостіМінДляОблаштуванняМінновибуховихЗагородженьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alg40 alg40 = new Alg40();
            alg40.Show();
        }
    }
}
