using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler
            //Console.WriteLine("***** Ürün Fiyat Listesi *****");
            //Console.WriteLine();
            //double orangePrice, applePrice, strawberryPrice, potatoPrice, tomatoPrice;
            //orangePrice = 20.74;
            //applePrice = 12.85;
            //strawberryPrice = 30.99;
            //potatoPrice = 10.99;
            //tomatoPrice = 15.99;

            //Console.WriteLine("----Portakal Birim Fiyatı: " + orangePrice+" TL");
            //Console.WriteLine("----Elma Birim Fiyatı: " + applePrice + " TL");
            //Console.WriteLine("----Çilek Birim Fiyatı: " + strawberryPrice + " TL");
            //Console.WriteLine("----Patates Birim Fiyatı: " + potatoPrice + " TL");
            //Console.WriteLine("----Domates Birim Fiyatı: " + tomatoPrice + " TL");

            //double orangeGram, appleGram, strawberryGram, potatoGram, tomatoGram;
            //orangeGram = 1.253;
            //appleGram = 2.750;
            //strawberryGram = 1.970;
            //potatoGram = 4.506;
            //tomatoGram = 2.995;

            //double orangeTotalPrice, appleTotalPrice, strawberryTotalPrice, potatoTotalPrice, tomatoTotalPrice,totalPrice;

            //orangeTotalPrice = orangeGram * orangePrice;
            //appleTotalPrice = appleGram * applePrice;
            //strawberryTotalPrice = strawberryGram * strawberryPrice;
            //potatoTotalPrice = potatoGram * potatoPrice;
            //tomatoTotalPrice = tomatoGram * tomatoPrice;

            //totalPrice = orangeTotalPrice + appleTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;
            //Console.WriteLine();
            //Console.WriteLine("Alınan Ürün: Elma - Birim Fiyatı: " + applePrice + " TL - Gramaj: " + appleGram + " - Toplam Fiyat: " + appleTotalPrice + " TL");
            //Console.WriteLine("Alınan Ürün: Portakal - Birim Fiyatı: " + orangePrice + " TL - Gramaj: " + orangeGram + " - Toplam Fiyat: " + orangeTotalPrice + " TL");
            //Console.WriteLine("Alınan Ürün: Cilek - Birim Fiyatı: " + strawberryPrice + " TL - Gramaj: " + strawberryGram + " - Toplam Fiyat: " + strawberryTotalPrice + " TL");
            //Console.WriteLine("Alınan Ürün: Patates - Birim Fiyatı: " + potatoPrice + " TL - Gramaj: " + potatoGram + " - Toplam Fiyat: " + potatoTotalPrice + " TL");
            //Console.WriteLine("Alınan Ürün: Domates - Birim Fiyatı: " + tomatoPrice + " TL - Gramaj: " + tomatoGram + " - Toplam Fiyat: " + tomatoTotalPrice + " TL");
            //Console.WriteLine();
            //Console.WriteLine("Toplam Fiyat: " + totalPrice + " TL");



            #endregion

            #region Char Değişkenler
            //char symbol = 'a';

            //Console.WriteLine(symbol);





            #endregion


            #region Klayveden Veri Girişleri String Değişkenler
            //Console.WriteLine("***** Csharp Hava Yolları *****");
            //Console.WriteLine();

            //string passangerName,passangerSurname,passangerAge,passangerDistrict,passangerCity,passangerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passangerName = Console.ReadLine();

            //Console.WriteLine();

            //Console.Write("Yolcu Soyadı: ");
            //passangerSurname = Console.ReadLine();
            //Console.WriteLine();

            //Console.Write("Yolcu Yaşı: ");
            //passangerAge = Console.ReadLine();

            //Console.WriteLine();

            //Console.Write("Yolcu İli: ");
            //passangerCity = Console.ReadLine();

            //Console.WriteLine();

            //Console.Write("Yolcu İlçesi: ");
            //passangerDistrict = Console.ReadLine();

            //Console.WriteLine();

            //Console.Write("Yolcu Kimlik Numarası: ");
            //passangerIdentityNumber = Console.ReadLine();


            //Console.WriteLine("-------------------------");

            //Console.WriteLine("Yolcu Kimlik Numarası: " + passangerIdentityNumber + " Yolcu Ad Soyad: " +passangerName +" "+ passangerSurname +
            //    "  Yolcu Yaşı: " + passangerAge + " " + passangerDistrict + "/" +passangerCity );


            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //int shoesCount,computerCount,chairCount,tvCount,shoesPrice,computerPrice,chairPrice,tvPrice,totalPrice;
            //shoesPrice = 2000;
            //computerPrice = 20500;
            //chairPrice = 3500;
            //tvPrice = 13000;


            //Console.WriteLine("***** AVM - ALIŞVERİŞ *****");
            //Console.WriteLine();

            //Console.Write("Almış olduğunuz ayakkabı sayısını giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.WriteLine();

            //Console.Write("Almış olduğunuz bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.WriteLine();

            //Console.Write("Almış olduğunuz koltuk sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.WriteLine();

            //Console.Write("Almış olduğunuz tv sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //Console.WriteLine();

            //Console.WriteLine("-------------------------");
            //Console.WriteLine("Ödenecek Tutar: " + (shoesCount * shoesPrice + computerCount * computerPrice + chairCount * chairPrice + tvCount * tvPrice) + " TL");





            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri
            //double exam1, exam2, exam3, average;
            //Console.WriteLine("***** Sınav Sonucu Ortalaması Hesaplama *****");
            //Console.WriteLine();
            //Console.Write("1. Sınav puanınızı giriniz: ");
            //exam1=double.Parse(Console.ReadLine());
            //Console.WriteLine();
            //Console.Write("2. Sınav puanınızı giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());
            //Console.WriteLine();
            //Console.Write("3. Sınav puanınızı giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());
            //Console.WriteLine();

            //average = (exam1 + exam2 + exam3) / 3.0;
            //Console.WriteLine("Ortalamanız: "+average);




            #endregion

            #region kLavyeden Karakter Girişleri

            char gender;
            Console.Write("Lütfen cinsiyet seçiniz: ");
            gender=char.Parse(Console.ReadLine());
            Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender);
            #endregion

            Console.Read();
        }
    }
}
