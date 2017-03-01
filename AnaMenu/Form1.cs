using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Collections;

namespace AnaMenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // ekrandan inputbox ile sayi alıp almadığımızı kotrol amaçlı fonksiyondur. Sayı olmadığı sürece inputbox sayı istiyor.
        public int sayiKontrol(int sira)
        {
            string girilen;
            int sayi;
            do
            {
                if (sira != 0)
                    girilen = Interaction.InputBox(sira + ". Sayıyı Giriniz.", "Bilgi Girişi");
                else
                    girilen = Interaction.InputBox("Sayı Giriniz.", "Bilgi Girişi");
            }
            while (girilen == "" || !int.TryParse(girilen, out sayi));   //tryparse ile sayı olup olmadığını kontrol ediyoruz
            return sayi;
        }

        public int sayiKontrol(string sira)
        {
            string girilen;
            int sayi;
            do
            {
                girilen = Interaction.InputBox(sira + " Sayısını Giriniz.", "Bilgi Girişi");
            }
            while (girilen == "" || !int.TryParse(girilen, out sayi));   //tryparse ile sayı olup olmadığını kontrol ediyoruz
            return sayi;
        }

        public void Button_Click(object sender, EventArgs e)
        {
            //button 1
            //Ekrana "Merhaba Dünya!" Bastırmak
            if (((Button)sender).Name == "btn1")
            {
                MessageBox.Show("Merhaba dünya!", "Merhaba", MessageBoxButtons.OK);
            }

            //button 2
            //Bir tam sayı değişkeni (int) tanımlayarak içerisine ilk değer atayın ve ekrana değerini basınız.
            else if (((Button)sender).Name == "btn2")
            {
                int sayi = 1907;
                MessageBox.Show(sayi.ToString(), "Sayi", MessageBoxButtons.OK);
            }

            //button 3
            //Ekrandan bir sayi okuyup bu sayıyı ekrana geri basınız.
            else if (((Button)sender).Name == "btn3")
            {
                MessageBox.Show(sayiKontrol(0).ToString(), "Girdiğiniz Sayı", MessageBoxButtons.OK);
            }

            //button 4
            //Ekrandan okunan iki tam sayı (int) için basit işlemler yaparak ekrana sonuçları basan kod yazınız. Bu işlemler toplama, çıkarma, çarpma, bölme ve kalan işlemleridir.
            else if (((Button)sender).Name == "btn4")
            {
                int sayi1 = sayiKontrol(1);

                int sayi2 = sayiKontrol(2);

                string sonuclar = "Toplama : " + sayi1.ToString() + " + " + sayi2.ToString() + " = " + (sayi1 + sayi2).ToString() + "\n" +
                                 "Çıkarma : " + sayi1.ToString() + " - " + sayi2.ToString() + " = " + (sayi1 - sayi2).ToString() + "\n" +
                                 "Çarpma : " + sayi1.ToString() + " * " + sayi2.ToString() + " = " + (sayi1 * sayi2).ToString() + "\n" +
                                 "Bölme : " + sayi1.ToString() + " / " + sayi2.ToString() + " = " + (Convert.ToDouble(sayi1) / Convert.ToDouble(sayi2)).ToString();
                MessageBox.Show(sonuclar, "Sonuçlar", MessageBoxButtons.OK);
            }

            //button 5
            //Klavyeden iki sayı alarak bu sayıları mantıksal olarak karşılaştıran kod örneğini yazınız. Kullanılacak olan operatörler şunlardır: == , != , < , > , <= , >=
            else if (((Button)sender).Name == "btn5")
            {
                string sonuclar = "";
                int sayi1 = sayiKontrol(1);
                int sayi2 = sayiKontrol(2);

                //eşit mi değil mi kotrol ediyoruz
                if (sayi1 == sayi2)
                    sonuclar += sayi1 + " == " + sayi2 + "\n";
                else
                    sonuclar += sayi1 + " != " + sayi2 + "\n";
                // büyük mü küçük mü diye kontrol ediyoruz ama eşit de olabilirler o yüzden else if kullanıyoruz.
                if (sayi1 < sayi2)
                    sonuclar += sayi1 + " < " + sayi2 + "\n";
                else if (sayi1 > sayi2)
                    sonuclar += sayi1 + " > " + sayi2 + "\n";
                //
                if (sayi1 <= sayi2)
                    sonuclar += sayi1 + " <= " + sayi2 + "\n";
                else
                    sonuclar += sayi1 + " >= " + sayi2 + "\n";
                MessageBox.Show(sonuclar, "Sonuçlar", MessageBoxButtons.OK);
            }

            //button 6
            //Klavyeden üç sayı alarak mantık bağlaçlarını kullanan örnek bir kod yazınız. Örneğin okunan sayılar a, b ve c olsun. 
            //Sırasıyla, a'nın b ve c arasında olup olmadığını, a'nın b'ye eşit ve aynı zamanda c'den küçük olup olmadığını a'nın b'den veya 
            //c'den büyük olup olmadığını üç sayının birbirine eşit olup olmadığını kontrol edip ekrana basan kodu yazınız.
            else if (((Button)sender).Name == "btn6")
            {

                string sonuclar = "";
                int a = sayiKontrol("a");
                int b = sayiKontrol("b");
                int c = sayiKontrol("c");

                //b<a<c , c<a<b
                //b>a>c , c>a>b
                if ((b < a && a < c) || (c < a && a < b) || (b > a && a > c) || (c > a && a > b))
                    sonuclar += a + " Sayısı " + b + " ile " + c + " arasındadır. \n";


                if (a == b && a < c)
                    sonuclar += a + " = " + b + "  ve  " + a + " < " + c + "\n";

                if (a > b || a > c)
                {
                    if (a > b && a > c)
                        sonuclar += a + " > " + b + "  ve  " + a + " > " + c + "\n";
                    else if (a > c)
                        sonuclar += a + " > " + c + "\n";
                    else
                        sonuclar += a + " > " + b + "\n";

                }

                if (a == b && a == c)
                    sonuclar += a + " = " + b + " = " + c;
                MessageBox.Show(sonuclar, "Sonuçlar", MessageBoxButtons.OK);

            }

            //button 7
            //Klavyeden 3 sayı okuyarak bu sayılardan en büyüğünü veya en küçüğünü ekrana yazan kodu yazınız.
            else if (((Button)sender).Name == "btn7")
            {
                int buyuk;
                int kucuk;
                int sayi1 = sayiKontrol(1);
                int sayi2 = sayiKontrol(2);
                int sayi3 = sayiKontrol(3);

                if (sayi1 > sayi2)
                {
                    if (sayi1 > sayi3)
                        buyuk = sayi3;
                    else
                        buyuk = sayi1;

                    if (sayi2 > sayi3)
                        kucuk = sayi3;
                    else
                        kucuk = sayi2;
                }
                else
                {
                    if (sayi2 > sayi3)
                        buyuk = sayi2;
                    else
                        buyuk = sayi3;

                    if (sayi1 > sayi3)
                        kucuk = sayi3;
                    else
                        kucuk = sayi1;
                }
                MessageBox.Show("Büyük sayı = " + buyuk + "\n" + "Küçük sayı = " + kucuk);


            }

            //button 8
            //Klavyeden 0 ile 100 arasında bir sayı okuyarak harf karşılığını bulunuz (A: 90 - 100, B: 80 -90, C:70-80 arası ve F: 70'in altı olarak kabul edebilirsiniz).
            else if (((Button)sender).Name == "btn8")
            {
                string sonuc = "";
                int sayi = sayiKontrol(1);
                if (!(sayi >= 0) || !(sayi < 100))
                {
                    sayi = sayiKontrol(1);
                }
                if (sayi < 100 && sayi > 90)
                    sonuc = "A";
                else if (sayi < 90 && sayi > 80)
                    sonuc = "B";
                else if (sayi < 80 && sayi > 70)
                    sonuc = "C";
                else if (sayi < 70)
                    sonuc = "F";
                else
                    sonuc = "Tekrar Deneyiniz";
                MessageBox.Show(sonuc, "Sonuç", MessageBoxButtons.OK);
            }

            //button 9
            //1'den 10'a kadar olan ardışık sayıları ekrana bastıran kodu yazınız.
            else if (((Button)sender).Name == "btn9")
            {
                int i = 1;
                MessageBox.Show(i + " - " + (i + 1) + " - " + (i + 2) + " - " + (i + 3) + " - " + (i + 4) + " - " +
                                        (i + 5) + " - " + (i + 6) + " - " + (i + 7) + " - " + (i + 8) + " - " + (i + 9));
            }

            //button 10
            //100'den 0'a kadar 13'e tam bölünebilen sayıları ekrana yazdırınız (büyükten küçüğe).
            else if (((Button)sender).Name == "btn10")
            {
                int i;
                string sonuclar = "";
                for (i = 100; i > 12; i--)
                {
                    if (i % 13 == 0)
                        sonuclar += i + "\n";
                }
                MessageBox.Show(sonuclar, "Sonuç", MessageBoxButtons.OK);
            }

            //button 11
            //Ekrana 4 kolon şeklinde aşağıdaki serileri bastırınız: 1. Kolonda: 1'den 100'e kadar olan 15'in katları 
            //2. Kolonda: 1'den 30'a kadar olan 5'in katları 3. Kolonda 100'den 50'ye kadar olan 10'un katları 4. Kolonda 2'den 64'e kadar olan 2'nin üstleri
            else if (((Button)sender).Name == "btn11")
            {
                ArrayList kolon1 = new ArrayList();
                ArrayList kolon2 = new ArrayList();
                ArrayList kolon3 = new ArrayList();
                ArrayList kolon4 = new ArrayList();
                string sonuc = "";
                int i, buyukluk = 0;
                for (i = 1; i < 100; i++)
                {
                    if (i % 15 == 0)
                        kolon1.Add(i);
                }
                for (i = 1; i < 30; i++)
                {
                    if (i % 5 == 0)
                        kolon2.Add(i);
                }
                for (i = 100; i > 50; i--)
                {
                    if (i % 10 == 0)
                        kolon3.Add(i);
                }

                for (int k = 1; k < 10; k++)
                {
                    double us = Math.Pow(2, Convert.ToDouble(k));
                    if (us >= 2 && us <= 64)
                        kolon4.Add(us);
                }


                if (buyukluk < kolon1.Count)
                    buyukluk = kolon1.Count;
                if (buyukluk < kolon2.Count)
                    buyukluk = kolon2.Count;
                if (buyukluk < kolon3.Count)
                    buyukluk = kolon3.Count;
                if (buyukluk < kolon4.Count)
                    buyukluk = kolon4.Count;

                for (i = 0; i < buyukluk; i++)
                {
                    //kolon1
                    if (i < kolon1.Count)
                    {
                        sonuc += kolon1[i] + "    ";
                    }
                    else
                        sonuc += "        ";
                    //kolon2
                    if (i < kolon2.Count)
                    {
                        sonuc += kolon2[i] + "    ";
                    }
                    else
                        sonuc += "        ";
                    //kolon3
                    if (i < kolon3.Count)
                    {
                        sonuc += kolon3[i] + "    ";
                    }
                    else
                        sonuc += "        ";

                    //kolon4
                    if (i < kolon4.Count)
                    {
                        sonuc += kolon4[i] + "    ";
                    }
                    else
                        sonuc += "        ";

                    sonuc += "\n";
                }
                MessageBox.Show(sonuc, "Sonuç", MessageBoxButtons.OK);
            }


            //button 12
            //Fibonacci serisinin ilk iki elemanı 1'dir ve diğer elemanları, 
            //kendisinden önce gelen son iki elemanın toplamıdır. Klavyeden bir sayı okuyarak, girilen sayı kadar fibonacci serisinin elemanını ekrana bastıran kodu yazınız.
            else if (((Button)sender).Name == "btn12")
            {
                ArrayList fibonacci = new ArrayList();
                fibonacci.Add(1);
                fibonacci.Add(1);
                string sonuc = "";
                int sayi = sayiKontrol(1);
                int i = 0;
                if (sayi == 0)
                    sonuc = " ";
                else if (sayi == 1)
                    sonuc = "1";
                else if (sayi == 2)
                    sonuc = "1-1";
                else if (sayi > 2)
                {
                    for (i = 0; i < sayi - 2; i++)
                    {
                        fibonacci.Add(Convert.ToUInt64(fibonacci[i]) + Convert.ToUInt64(fibonacci[i + 1]));
                    }
                    for (i = 0; i < fibonacci.Count; i++)
                    {
                        sonuc += fibonacci[i] + "  ";
                    }
                }
                MessageBox.Show(sonuc, "Sonuç", MessageBoxButtons.OK);

            }

            //button 13
            //Ekrana çarpım tablosunu bastıran kodu yazınız.
            else if (((Button)sender).Name == "btn13")
            {

            }

            //button 14
            //Verilen boyutlarda kare bir matris oluşturun ve sadece diyagonu (köşegeni) 1 diğer bütün elemanları 0 olarak ekrana basın.
            else if (((Button)sender).Name == "btn14")
            {

            }

            //button 15
            //Ters köşegeni (anti-diagon) 1 olan ve diğer bütün elemanları 0 olan matrisi ekrana bastırınız.
            else if (((Button)sender).Name == "btn15")
            {

            }

            //button 16
            //Verilen boyuttaki bir kare matrisin içerisine salyangoz (helezon) şeklinde ardışık sayıları yerleştiriniz.
            else if (((Button)sender).Name == "btn16")
            {

            }

            //button 17
            //Verilen bir sayının faktoriyelini döndüren fonkisyonu yazınız (iteratif, döngü ile)
            else if (((Button)sender).Name == "btn17")
            {

            }

            //button 18
            //Verilen bir sayının faktöriyelini özyineli (recursive) olarak hespalayan fonksiyonu yazınız.
            else if (((Button)sender).Name == "btn18")
            {

            }

            //button 19
            //Verilen iki sayının kombinasyonunu bulan kodu yazınız. Hatırlatma C(n,r) = n! / (r!(n-r)!)
            else if (((Button)sender).Name == "btn19")
            {

            }

            //button 20
            //Kullanıcıdan bir tarihi gün, ay ve yıl şeklinde alıp bu tarihi ay, gün, yıl ve yıl, ay, gün sıralarına çevirerek yazan bir kod yazınız.
            else if (((Button)sender).Name == "btn20")
            {

            }

            //button 21
            //Kullanıcıdan a,b ve c sayılarını okuyarak aşağıdaki işlemi yapan kodu yazınız a'nın karesi +b'nin karesi +3c
            else if (((Button)sender).Name == "btn21")
            {

            }

            //button 22
            //Kullanıcıdan bugünün’ün tarihini ve kaç yaşında olduğunu alarak doğum tarihini yıl olarak bulan kod yazınız.
            else if (((Button)sender).Name == "btn22")
            {

            }

            //button 23
            //Kullanıcıdan iki tarih okuyarak bu tarihler arasında kaç gün geçtiğini hesaplaya kodu yazınız.
            //Örnek olarak kendi doğum tarihinizi ve bugünün tarihini girerek kaç gündür yaşadığınızı hesaplayınız.
            else if (((Button)sender).Name == "btn23")
            {

            }

            //button 24
            //Bir işçinin işi bitirme süresini ve toplam işçi sayısını alarak, işin bitme süresini hesaplayan kodu yazınız.
            //Örneğin, Bir işçi bir işi 10 günde yapabilmektedir. Buna göre 2 işçi aynı işi kaç günde yapar?
            else if (((Button)sender).Name == "btn24")
            {

            }

            //button 25
            //Bir dik üçgenin iki dik kenarını alarak hipotenüsünü hesaplayan kod yazınız.
            //(Yardım: karekök almak için, C ve C++ dillerinde math.h dosyasını include ederek (#include ) sqrt() fonksiyonunu kullanabilirsiniz. 
            //Basitçe int x = sqrt(16); satırı sonrasında x değeri 4 olur) JAVA dilinde ise Math.sqrt() fonksiyonu kullanılabilir.
            //Basitçe int x= Math.sqrt(16); satırından sonra x değeri 4 olur)
            else if (((Button)sender).Name == "btn25")
            {

            }

            //button 26
            //Bir dik üçgenin iki dik kenarı girildiğinde, bu üçgenin alanını ve çevresini hesaplayan kodu yazınız.
            else if (((Button)sender).Name == "btn26")
            {

            }

            //button 27
            //Mesafeyi ve hızı alıp süreyi hesaplayan bir kod yazınız. Örneğin: İstanbul ile Ankara arası 400km olarak ölçülmektedir. 
            //Bu yolu ortalama 120 km/saat hızla giden bir araç ne kadar sürede hedefe varır?
            else if (((Button)sender).Name == "btn27")
            {

            }

            //button 28
            //Kullanıcıdan üç adet sayı alarak bu sayıların bir dik üçgenin kenar uzunlukları olup olmadığını hesaplatan bir kod yazınız
            //(Yardım: Bir üçgenin dik olduğunu anlamak için a2+b2=c2 pisagor bağlantısından yararlanabilirsiniz)
            else if (((Button)sender).Name == "btn28")
            {

            }

            //button 29
            //Okunan bir sayı kadar satır ve sütüna sahip bir dik üçgeni ekrana bastırınız.
            else if (((Button)sender).Name == "btn29")
            {

            }

            //button 30
            //Üstteki sorusundaki üçgeni ters kenara dayalı olarak basan kodu yaıznız.
            else if (((Button)sender).Name == "btn30")
            {

            }

        }
    }
}
