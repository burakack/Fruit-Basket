using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meyvesepeti
{
    public partial class Form1 : Form
    {
        interface IMeyve
        {
            int vitamina { set; get; }
            int vitaminc { set; get; }
        }
        /*meyvelerimi 3lu gruplara ayiriyorum bu gruplarin adi narenciye ve katimeyveler
        bu sayede her meyvenin nesnesinin uretildigi sinifinin icinde tekrar tekrar aynı kodla agirlik ve verim degerlerini olusturmayacagim.*/
        abstract class Narenciye : IMeyve
        {
            public int agirlik;
            public int verim;
            abstract public int vitamina { get; set; }
            abstract public int vitaminc { get; set; }
            /*turetilmis siniflarda tekrar tekrar kod yazmamak icin bu parent sinifin 
            olusma anında agirlik ve verimi rastgele olarak olusturuyorum sonucta narenciyeler 
            sinifinin uyeleri icin bu degerler ayni sekilde uretilmeli*/
            public Narenciye()
            {
                Random rastgele = new Random();
                agirlik = rastgele.Next(70, 120);
                verim = rastgele.Next(30, 70);
                
            }
        }
        abstract class KatiMeyve : IMeyve
        {
            public int agirlik;
            public int verim;
            abstract public int vitamina { get; set; }
            abstract public int vitaminc { get; set; }
            /*turetilmis siniflarda tekrar tekrar kod yazmamak icin bu parent sinifin 
            olusma anında agirlik ve verimi rastgele olarak olusturuyorum sonucta katimeyveler 
            sinifinin uyeleri icin bu degerler ayni sekilde uretilmeli*/
            public KatiMeyve()
            {
                Random rastgele = new Random();
                agirlik = rastgele.Next(70, 120);
                verim = rastgele.Next(80, 95);
            }
        }
        class Portakal : Narenciye, IMeyve
        {
            private int _vitamina;
            public override int vitamina
            {
                get
                {
                    return _vitamina;
                }
                set
                {
                    _vitamina = value;
                }
            }
            private int _vitaminc;
            public override int vitaminc
            {
                get
                {
                    return _vitaminc;
                }
                set
                {
                    _vitaminc = value;
                }
            }
            public Portakal()
            {
                vitamina = 225;
                vitaminc = 45;
            }
        }
        class Mandalina : Narenciye, IMeyve
        {
            private int _vitamina;
            public override int vitamina
            {
                get
                {
                    return _vitamina;
                }
                set
                {
                    _vitamina = value;
                }
            }
            private int _vitaminc;
            public override int vitaminc
            {
                get
                {
                    return _vitaminc;
                }
                set
                {
                    _vitaminc = value;
                }
            }
            public Mandalina()
            {
                vitamina = 681;
                vitaminc = 26;
            }
        }
        class Greyfurt : Narenciye, IMeyve
        {
            private int _vitamina;
            public override int vitamina
            {
                get
                {
                    return _vitamina;
                }
                set
                {
                    _vitamina = value;
                }
            }
            private int _vitaminc;
            public override int vitaminc
            {
                get
                {
                    return _vitaminc;
                }
                set
                {
                    _vitaminc = value;
                }
            }
            public Greyfurt()
            {
                vitamina = 3;
                vitaminc = 44;
            }
        }
        class Elma : KatiMeyve, IMeyve
        {
            private int _vitamina;
            public override int vitamina
            {
                get
                {
                    return _vitamina;
                }
                set
                {
                    _vitamina = value;
                }
            }
            private int _vitaminc;
            public override int vitaminc
            {
                get
                {
                    return _vitaminc;
                }
                set
                {
                    _vitaminc = value;
                }
            }
            public Elma()
            {
                vitamina = 54;
                vitaminc = 5;
            }
        }
        class Armut : KatiMeyve, IMeyve
        {
            private int _vitamina;
            public override int vitamina
            {
                get
                {
                    return _vitamina;
                }
                set
                {
                    _vitamina = value;
                }
            }
            private int _vitaminc;
            public override int vitaminc
            {
                get
                {
                    return _vitaminc;
                }
                set
                {
                    _vitaminc = value;
                }
            }
            public Armut()
            {
                vitamina = 25;
                vitaminc = 5;
            }
        }
        class Cilek : KatiMeyve, IMeyve
        {
            private int _vitamina;
            public override int vitamina
            {
                get
                {
                    return _vitamina;
                }
                set
                {
                    _vitamina = value;
                }
            }
            private int _vitaminc;
            public override int vitaminc
            {
                get
                {
                    return _vitaminc;
                }
                set
                {
                    _vitaminc = value;
                }
            }
            public Cilek()
            {
                vitamina = 12;
                vitaminc = 60;
            }
        }
        abstract class Sikacak
        {
            abstract public int vitaminaSikacak { get; set;}
            abstract public int vitamincSikacak { get; set; }
            abstract public int sivi { get; set; }
            abstract public int pure { get; set; }
        }
        class Sivisikacagi : Sikacak
        {
            int _vitaminaSikacak;
            override public int vitaminaSikacak
            {
                get { return _vitaminaSikacak; }
                set { _vitaminaSikacak = value; }
            }
            int _vitamincSikacak;
            override public int vitamincSikacak
            {
                get { return _vitamincSikacak; }
                set { _vitamincSikacak = value; }
            }
            int _sıvı;
            override public int sivi
            {
                get { return _sıvı; }
                set { _sıvı = value; }
            }
            int _pure;
            override public int pure
            {
                get { return _pure; }
                set { _pure = value; }
            }
            public void SikNarenciye(Narenciye meyve)
            {
                //meyvenin 100 grsinda bulunan vitamin degerlerinden toplam vitamin degerlerini hesapliyoruz
                vitaminaSikacak = meyve.vitamina * meyve.agirlik / 100;
                vitamincSikacak = meyve.vitaminc * meyve.agirlik / 100;
                //meyvenin verim degerlerinden sıvı ve pureyi hesapliyoruz
                sivi = meyve.agirlik * 100 / meyve.verim;
                pure = meyve.agirlik * meyve.verim / 100;
            }
        }
        class KatiSikacagi : Sikacak
        {
            int _vitaminaSikacak;
            override public int vitaminaSikacak
            {
                get { return this._vitaminaSikacak; }
                set { _vitaminaSikacak = value; }
            }
            int _vitamincSikacak;
            override public int vitamincSikacak
            {
                get { return _vitamincSikacak; }
                set { _vitamincSikacak = value; }
            }
            int _sivi;
            override public int sivi
            {
                get { return _sivi; }
                set { _sivi = value; }
            }
            int _pure;
            override public int pure
            {
                get { return _pure; }
                set { _pure = value; }
            }
            public void SikKatiMeyve(KatiMeyve meyve)
            {
                //meyvenin 100 grsinda bulunan vitamin degerlerinden ve agirliktan toplam vitamin degerlerini hesapliyoruz
                vitaminaSikacak = meyve.vitamina * meyve.agirlik / 100;
                vitamincSikacak = meyve.vitaminc * meyve.agirlik / 100;
                //meyvenin agirlik verim degerlerinden sivi ve pureyi hesapliyoruz
                sivi = meyve.agirlik * meyve.verim / 100;
                pure = meyve.agirlik * 100 / meyve.verim;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BaslaButton_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            sıvısıkacak.Checked = false;
            katısıkacak.Checked = false;
            //oyunu tekrar oynayacak iseniz eski degerleri silmek icin
            agirliksonuclabel.Text = "0";
            vitaminasonuclabel.Text = "0";
            vitamincsonuclabel.Text = "0";
            puresonuclabel.Text = "0";
            sivisonuclabel.Text = "0";
            tagirliksonuclabel.Text = "0";
            tvitaminasonuclabel.Text = "0";
            tvitamincsonuclabel.Text = "0";
            tpuresonuclabel.Text = "0";
            tsivisonuclabel.Text = "0";

        }
        private int _sureToplam=0;
        public int SureToplam
        {
            set { _sureToplam = value; }
            get {return _sureToplam; }
        }
        private int _toplamAgirlik=0;
        public int ToplamAgirlik
        {
            set { _toplamAgirlik = value; }
            get { return _toplamAgirlik; }
        }
        private int _toplamaVitamin=0;
        public int ToplamaVitamin
        {
            set { _toplamaVitamin = value; }
            get { return _toplamaVitamin; }
        }
        private int _toplamcVitamin=0;
        public int ToplamcVitamin
        {
            set { _toplamcVitamin = value; }
            get { return _toplamcVitamin; }
        }
        private int _toplamSivi = 0;
        public int ToplamSivi
        {
            set { _toplamSivi = value; }
            get { return _toplamSivi; }
        }
        private int _toplamPure=0;
        public int ToplamPure
        {
            set { _toplamPure = value; }
            get { return _toplamPure; }
        }
        private void ToplamTimer_Tick(object sender, EventArgs e)
        {
            SureToplam++;
            surelabel.Text = SureToplam.ToString();
            if (SureToplam % 6==0)
            {
                //6 saniyelik periyotlarla meyve sıkacagımız icin 10 kere yeni meyve olusacak
                Sivisikacagi sıkacaksıvı = new Sivisikacagi();
                KatiSikacagi sıkacakkatı = new KatiSikacagi();
                //1->Portakal 2->Mandalina 3->Greyfurt 4->Elma 5->Armut 6->Cilek
                switch (RastgeleMeyve)
                {
                    /*caselarin her biri once meyveyi olusturuyor sonra checkbox dogru secildiyse 
                     labela yazdiriyor ve toplam degiskenlerine ekliyor yanlissa uyari mesaji yazdiriyor  */
                    case 0:
                        {
                            Portakal portakal = new Portakal();
                            if (sıvısıkacak.Checked)
                            {
                                sıkacaksıvı.SikNarenciye(portakal);
                                agirliksonuclabel.Text = portakal.agirlik.ToString();
                                vitaminasonuclabel.Text = sıkacaksıvı.vitaminaSikacak.ToString();
                                vitamincsonuclabel.Text = sıkacaksıvı.vitamincSikacak.ToString();
                                puresonuclabel.Text = sıkacaksıvı.pure.ToString();
                                sivisonuclabel.Text = sıkacaksıvı.sivi.ToString();
                                ToplamAgirlik += Int32.Parse(agirliksonuclabel.Text);
                                ToplamaVitamin += Int32.Parse(vitaminasonuclabel.Text);
                                ToplamcVitamin += Int32.Parse(vitamincsonuclabel.Text);
                                ToplamPure += Int32.Parse(puresonuclabel.Text);
                                ToplamSivi += Int32.Parse(sivisonuclabel.Text);

                                uyarilabel.Text = "";
                                sıvısıkacak.Checked = false;
                            }
                            else if (katısıkacak.Checked)
                            {
                                uyarilabel.Text = "Yanlış sıkacağı seçtiniz!";
                            }
                            break;
                        }
                    case 1:
                        {
                            Mandalina mandalina = new Mandalina();
                            if (sıvısıkacak.Checked)
                            {
                                sıkacaksıvı.SikNarenciye(mandalina);
                                agirliksonuclabel.Text = mandalina.agirlik.ToString();
                                vitaminasonuclabel.Text = sıkacaksıvı.vitaminaSikacak.ToString();
                                vitamincsonuclabel.Text = sıkacaksıvı.vitamincSikacak.ToString();
                                puresonuclabel.Text = sıkacaksıvı.pure.ToString();
                                sivisonuclabel.Text = sıkacaksıvı.sivi.ToString();
                                ToplamAgirlik += Int32.Parse(agirliksonuclabel.Text);
                                ToplamaVitamin += Int32.Parse(vitaminasonuclabel.Text);
                                ToplamcVitamin += Int32.Parse(vitamincsonuclabel.Text);
                                ToplamPure += Int32.Parse(puresonuclabel.Text);
                                ToplamSivi += Int32.Parse(sivisonuclabel.Text);
                                uyarilabel.Text = "";
                                sıvısıkacak.Checked = false;
                            }
                            else if (katısıkacak.Checked)
                            {
                                uyarilabel.Text = "Yanlış sıkacağı seçtiniz!";
                                katısıkacak.Checked = false;
                            }
                            break;
                        }
                    case 2:
                        {
                            Greyfurt greyfurt = new Greyfurt();
                            if (sıvısıkacak.Checked)
                            {
                                sıkacaksıvı.SikNarenciye(greyfurt);
                                agirliksonuclabel.Text = greyfurt.agirlik.ToString();
                                vitaminasonuclabel.Text = sıkacaksıvı.vitaminaSikacak.ToString();
                                vitamincsonuclabel.Text = sıkacaksıvı.vitamincSikacak.ToString();
                                puresonuclabel.Text = sıkacaksıvı.pure.ToString();
                                sivisonuclabel.Text = sıkacaksıvı.sivi.ToString();
                                ToplamAgirlik += Int32.Parse(agirliksonuclabel.Text);
                                ToplamaVitamin += Int32.Parse(vitaminasonuclabel.Text);
                                ToplamcVitamin += Int32.Parse(vitamincsonuclabel.Text);
                                ToplamPure += Int32.Parse(puresonuclabel.Text);
                                ToplamSivi += Int32.Parse(sivisonuclabel.Text);
                                uyarilabel.Text = "";
                                sıvısıkacak.Checked = false;
                            }
                            else if (katısıkacak.Checked)
                            {
                                uyarilabel.Text = "Yanlış sıkacağı seçtiniz!";
                                katısıkacak.Checked = false;
                            }
                            break;
                        }
                    case 3:
                        {
                            Elma elma = new Elma();
                            if (katısıkacak.Checked)
                            {
                                sıkacakkatı.SikKatiMeyve(elma);
                                agirliksonuclabel.Text = elma.agirlik.ToString();
                                vitaminasonuclabel.Text = sıkacakkatı.vitaminaSikacak.ToString();
                                vitamincsonuclabel.Text = sıkacakkatı.vitamincSikacak.ToString();
                                puresonuclabel.Text = sıkacakkatı.pure.ToString();
                                sivisonuclabel.Text = sıkacakkatı.sivi.ToString();
                                ToplamAgirlik += Int32.Parse(agirliksonuclabel.Text);
                                ToplamaVitamin += Int32.Parse(vitaminasonuclabel.Text);
                                ToplamcVitamin += Int32.Parse(vitamincsonuclabel.Text);
                                ToplamPure += Int32.Parse(puresonuclabel.Text);
                                ToplamSivi += Int32.Parse(sivisonuclabel.Text);
                                uyarilabel.Text = "";
                                katısıkacak.Checked = false;
                            }
                            else if (sıvısıkacak.Checked)
                            {
                                uyarilabel.Text = "Yanlış sıkacağı seçtiniz!";
                                sıvısıkacak.Checked = false;
                            }
                            break;
                        }
                    case 4:
                        {
                            Armut armut = new Armut();
                            if (katısıkacak.Checked)
                            {
                                sıkacakkatı.SikKatiMeyve(armut);
                                agirliksonuclabel.Text = armut.agirlik.ToString();
                                vitaminasonuclabel.Text = sıkacakkatı.vitaminaSikacak.ToString();
                                vitamincsonuclabel.Text = sıkacakkatı.vitamincSikacak.ToString();
                                puresonuclabel.Text = sıkacakkatı.pure.ToString();
                                sivisonuclabel.Text = sıkacakkatı.sivi.ToString();
                                ToplamAgirlik += Int32.Parse(agirliksonuclabel.Text);
                                ToplamaVitamin += Int32.Parse(vitaminasonuclabel.Text);
                                ToplamcVitamin += Int32.Parse(vitamincsonuclabel.Text);
                                ToplamPure += Int32.Parse(puresonuclabel.Text);
                                ToplamSivi += Int32.Parse(sivisonuclabel.Text);
                                uyarilabel.Text = "";
                                katısıkacak.Checked = false;
                            }
                            else if (sıvısıkacak.Checked)
                            {
                                uyarilabel.Text = "Yanlış sıkacağı seçtiniz!";
                                sıvısıkacak.Checked = false;
                            }
                            break;
                        }
                    case 5:
                        {
                            Cilek cilek = new Cilek();
                            if (katısıkacak.Checked)
                            {
                                sıkacakkatı.SikKatiMeyve(cilek);
                                agirliksonuclabel.Text = cilek.agirlik.ToString();
                                vitaminasonuclabel.Text = sıkacakkatı.vitaminaSikacak.ToString();
                                vitamincsonuclabel.Text = sıkacakkatı.vitamincSikacak.ToString();
                                puresonuclabel.Text = sıkacakkatı.pure.ToString();
                                sivisonuclabel.Text = sıkacakkatı.sivi.ToString();
                                ToplamAgirlik += Int32.Parse(agirliksonuclabel.Text);
                                ToplamaVitamin += Int32.Parse(vitaminasonuclabel.Text);
                                ToplamcVitamin += Int32.Parse(vitamincsonuclabel.Text);
                                ToplamPure += Int32.Parse(puresonuclabel.Text);
                                ToplamSivi += Int32.Parse(sivisonuclabel.Text);
                                uyarilabel.Text = "";
                                katısıkacak.Checked = false;
                            }
                            else if (sıvısıkacak.Checked)
                            {
                                uyarilabel.Text = "Yanlış sıkacağı seçtiniz!";
                                sıvısıkacak.Checked = false;
                            }
                            break;
                        }
                }
                //toplam degerleri labellara yazdirma
                tagirliksonuclabel.Text  = ToplamAgirlik.ToString();
                tvitaminasonuclabel.Text = ToplamaVitamin.ToString();
                tvitamincsonuclabel.Text = ToplamcVitamin.ToString();
                tpuresonuclabel.Text = ToplamPure.ToString();
                tsivisonuclabel.Text = ToplamSivi.ToString();
            }
            /*sure dolduysa timerları durduruyoruz islemlerimizi bu timerlarin
            ticklerine gore yaptigimiz icin program durmus oluyor*/
            if (SureToplam == 60)
            {
                SureToplam = 0;
                timer1.Stop();
                timer2.Stop();
            }
        }
        private int _sureMeyve =6;
        public int SureMeyve
        {
            get { return _sureMeyve; }
            set { _sureMeyve = value; }
        }
        //gosterilecek meyveleri secmemizi saglayan degisken 6 saniyede 1 yeni deger uretiyor
        Random Rastgele = new Random();
        private int _rastgeleMeyve;
        public int RastgeleMeyve
        {
            get { return _rastgeleMeyve; }
            set { _rastgeleMeyve = value; }
        }
        private void MeyveTimer_Tick(object sender, EventArgs e)
        {
            if(SureMeyve % 6==0)
            {
                RastgeleMeyve = Rastgele.Next(0, 6);
                resimler.Image = resimlist.Images[RastgeleMeyve];
            }
            SureMeyve--;
            if (SureMeyve == 0)
                SureMeyve = 6;
            suremeyvelabel.Text = SureMeyve.ToString();
        }
    }
}
