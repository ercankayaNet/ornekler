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

namespace AnaMenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
                string girilen;
                int sayi;
                do
                {
                    girilen = Interaction.InputBox("Sayı Giriniz.", "Bilgi Girişi");
                }
                while (girilen == "" || !int.TryParse(girilen, out sayi));  //tryparse ile sayı olup olmadığını kontrol ediyoruz

                MessageBox.Show(sayi.ToString(), "Girdiğiniz Sayı", MessageBoxButtons.OK);
            }

            //button 4
            //Ekrandan okunan iki tam sayı (int) için basit işlemler yaparak ekrana sonuçları basan kod yazınız. Bu işlemler toplama, çıkarma, çarpma, bölme ve kalan işlemleridir.
            else if (((Button)sender).Name == "btn4")
            {
                string girilen1;
                int sayi1;
                do
                {
                    girilen1 = Interaction.InputBox("1. Sayıyı Giriniz.", "Bilgi Girişi");
                }
                while (girilen1 == "" || !int.TryParse(girilen1, out sayi1));   //tryparse ile sayı olup olmadığını kontrol ediyoruz

                string girilen2;
                int sayi2;
                do
                {
                    girilen2 = Interaction.InputBox("2. Sayıyı Giriniz.", "Bilgi Girişi");
                }
                while (girilen2 == "" || !int.TryParse(girilen2, out sayi2));   //tryparse ile sayı olup olmadığını kontrol ediyoruz

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
                string sonuclar="";
                string girilen1;
                int sayi1;
                do
                {
                    girilen1 = Interaction.InputBox("1. Sayıyı Giriniz.", "Bilgi Girişi");
                }
                while (girilen1 == "" || !int.TryParse(girilen1, out sayi1));   //tryparse ile sayı olup olmadığını kontrol ediyoruz

                string girilen2;
                int sayi2;
                do
                {
                    girilen2 = Interaction.InputBox("2. Sayıyı Giriniz.", "Bilgi Girişi");
                }
                while (girilen2 == "" || !int.TryParse(girilen2, out sayi2));   //tryparse ile sayı olup olmadığını kontrol ediyoruz
                //eşit mi değil mi kotrol ediyoruz
                if (sayi1 == sayi2)
                    sonuclar += sayi1 + " == " + sayi2 + "\n";
                else
                    sonuclar += sayi1 + " != " + sayi2 + "\n";
                // büyük mü küçük mü diye kontrol ediyoruz ama eşit de olabilirler o yüzden else if kullanıyoruz.
                if (sayi1 < sayi2)
                    sonuclar += sayi1 + " < " + sayi2 + "\n";
                else if (sayi1>sayi2)
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

            }

            //button 7
            else if (((Button)sender).Name == "btn7")
            {

            }

            //button 8
            else if (((Button)sender).Name == "btn8")
            {

            }

            //button 9
            else if (((Button)sender).Name == "btn9")
            {

            }

            //button 10
            else if (((Button)sender).Name == "btn10")
            {

            }

            //button 11
            else if (((Button)sender).Name == "btn11")
            {

            }

            //button 12
            else if (((Button)sender).Name == "btn12")
            {

            }

            //button 13
            else if (((Button)sender).Name == "btn13")
            {

            }

            //button 14
            else if (((Button)sender).Name == "btn14")
            {

            }

            //button 15
            else if (((Button)sender).Name == "btn15")
            {

            }

            //button 16
            else if (((Button)sender).Name == "btn16")
            {

            }

            //button 17
            else if (((Button)sender).Name == "btn17")
            {

            }

            //button 18
            else if (((Button)sender).Name == "btn18")
            {

            }

            //button 19
            else if (((Button)sender).Name == "btn19")
            {

            }

            //button 20
            else if (((Button)sender).Name == "btn20")
            {

            }


        }
    }
}
