/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2019-2020 BAHAR DÖNEMİ
**	
**				ÖĞRENCİ ADI............:EZGİ BAĞCIK
**
****************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //dosya islemleri icin eklendi.

namespace b191210071_ndpodev1
{
    class Program

    {
       //programin her yerinden erisilmesi icin tanimlanan degiskenler:
       public static int ogrenciSayisi = 0;
       public static double[] notlar = new double[1000];   //ogrencinin not ortalaması bilgisini tutan dizi.
       public static string[] bilgiler = new string[1000]; //ogrencinin ad soyad numara bilgilerini tutan dizi.
       public static string[] harfNotuBilgisi = new string[1000]; //ogrencinin harf notu bilgisini tutan dizi.

        public static double AAyuzdesi = 0;
        public static double BAyuzdesi = 0;
        public static double BByuzdesi = 0;
        public static double CByuzdesi = 0;
        public static double CCyuzdesi = 0;
        public static double DCyuzdesi = 0;
        public static double DDyuzdesi = 0;
        public static double FDyuzdesi = 0;
        public static double FFyuzdesi = 0;

        public static int AAsayisi = 0;
        public static int BAsayisi = 0;
        public static int BBsayisi = 0;
        public static int CBsayisi = 0;
        public static int CCsayisi = 0;
        public static int DCsayisi = 0;
        public static int DDsayisi = 0;
        public static int FDsayisi = 0;
        public static int FFsayisi = 0;
        static void dosyadanOku()
        {
            string dosya_yolu = @"C:\Users\Ezgi\Desktop\b191210071_odev1ndp\ndpliste_b191210071.txt"; //dosyanin konumu belirtilir ve stringe atanir.
            FileStream fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read); //FileStream sınıfından bir nesne olusturuldu.
            StreamReader oku = new StreamReader(fs);
            string yazi = oku.ReadLine(); //dosya satır satır okunuyor.

            string ad;
            string soyad;
            string no;
            double a;
            double b;
            double c;
            double d;

            string[] temp = new string[1000]; //textdeki her bir veriyi bir diziye atar. 

            while (yazi != null) //yazi bosluk olana kadar yani text bitene kadar donguye giriyor.
            {
                temp = yazi.Split(' '); //textdeki her bir veriyi dizinin elemani olarak tutar.

                //textdeki her bir veri icin gerekli donusumler yapilir.
                ad = temp[0];
                soyad = temp[1];
                no = temp[2];
                a = Convert.ToDouble(temp[3]);
                b = Convert.ToDouble(temp[4]);
                c = Convert.ToDouble(temp[5]);
                d = Convert.ToDouble(temp[6]);
                
                //alinan notlarin yuzde kac etkiledigi hesaplanir.
                double odev1 = (a * (0.2)); 
                double odev2 = (b * (0.1));
                double vize = (c * (0.2));
                double final = (d * (0.5));

                notlar[ogrenciSayisi] = odev1 + odev2 + vize + final; // her ogrencinin not bilgisi hesaplanir ve diziye atanir.
                bilgiler[ogrenciSayisi] = ad +" "+ soyad + " " + no + " "; // her ogrencinin bilgileri diziye atanir.

                ogrenciSayisi++;

               yazi = oku.ReadLine(); 

            }

            oku.Close();
            fs.Close();
        }

        static void harfNotları()
        {
            
            for (int i = 0; i < ogrenciSayisi; i++) //Herbir ogrencinin harf notlarini bulmak icin kullanilan dongudur.Ogrencilerin aldiği harf notu bilgisi de buraya diziye atanir.
            {                                      //for dongusu icinde hangi harf notundan kac tane var onun sayisi da kosula sokulup bulunur.
                if (notlar[i] >= 90)
                {
                    AAsayisi++;
                    harfNotuBilgisi[i] = "AA";

                }
                else if (notlar[i] <= 89.99 && notlar[i] >= 85)
                {
                    BAsayisi++;
                    harfNotuBilgisi[i] = "BA";
                }
                else if (notlar[i] <= 84.99 && notlar[i] >= 80)
                {
                    BBsayisi++;
                    harfNotuBilgisi[i] = "BB";
                }
                else if (notlar[i] <= 79.99 && notlar[i] >= 75)
                {
                    CBsayisi++;
                    harfNotuBilgisi[i] = "CB";
                }
                else if (notlar[i] <= 74.99 && notlar[i] >= 65)
                {
                    CCsayisi++;
                    harfNotuBilgisi[i] = "CC";
                }
                else if (notlar[i] <= 64.99 && notlar[i] >= 58)
                {
                    DCsayisi++;
                    harfNotuBilgisi[i] = "DC";
                }
                else if (notlar[i] <= 57.99 && notlar[i] >= 50)
                {
                    DDsayisi++;
                    harfNotuBilgisi[i] = "DD";
                }
                else if (notlar[i] <= 49.99 && notlar[i] >= 40)
                {
                    FDsayisi++;
                    harfNotuBilgisi[i] = "FD";
                }
                else if (notlar[i] <= 39.99)
                {
                    FFsayisi++;
                    harfNotuBilgisi[i] = "FF";
                }
            }
           
            //Ogrencilerin totalde yuzde kac harf notu aldıklarini hesaplariz.
            AAyuzdesi = 100 * AAsayisi / ogrenciSayisi;
            BAyuzdesi = 100 * BAsayisi / ogrenciSayisi;
            BByuzdesi = 100 * BBsayisi / ogrenciSayisi;
            CByuzdesi = 100 * CBsayisi / ogrenciSayisi;
            CCyuzdesi = 100 * CCsayisi / ogrenciSayisi;
            DCyuzdesi = 100 * DCsayisi / ogrenciSayisi;
            DDyuzdesi = 100 * DDsayisi / ogrenciSayisi;
            FDyuzdesi = 100 * FDsayisi / ogrenciSayisi;
            FFyuzdesi = 100 * FFsayisi / ogrenciSayisi;

        }
       static void dosyaYaz()
        {
            string dosya_yolu2 = @"C:\Users\Ezgi\Desktop\b191210071_odev1ndp\ndpyeniliste_b191210071.txt"; //dosyanin acilacagi konumu belirtilir ve stringe atanir.
            FileStream fs2 = new FileStream(dosya_yolu2, FileMode.OpenOrCreate, FileAccess.Write); //Filestram sinifindan nesne olusturulur.
            StreamWriter yaz = new StreamWriter(fs2);
         
            yaz.WriteLine("*****OGRENCILERIN ORTALAMA VE HARF NOTU BİLGİLERİ*****");
            yaz.WriteLine();

            for (int i = 0; i < ogrenciSayisi; i++) //Herbir ogrencinin bilgilerini not ortalamasini ve harf notu bilgisini dosyaya yazdiran dongudur.
            {
                yaz.WriteLine(bilgiler[i] + notlar[i]+" " +harfNotuBilgisi[i]);
            }

            //dosyaya harf notlarinin sayisi ve yüzdeleri yazdiririlir.
            yaz.WriteLine();
            yaz.WriteLine();
            yaz.WriteLine("***HARF NOTU SAYILARI***        ***HARF NOTU YUZDELERI*** ");
            yaz.WriteLine();
            yaz.WriteLine("AA Sayisi : " + AAsayisi + "                   AA  : " + "%" + AAyuzdesi);   
            yaz.WriteLine("BA Sayisi : " + BAsayisi + "                   BA  : " + "%" + BAyuzdesi);
            yaz.WriteLine("BB Sayisi : " + BBsayisi + "                   BB  : " + "%" + BByuzdesi);
            yaz.WriteLine("CB Sayisi : " + CBsayisi + "                   CB  : " + "%" + CByuzdesi);
            yaz.WriteLine("CC Sayisi : " + CCsayisi + "                   CC  : " + "%" + CCyuzdesi);
            yaz.WriteLine("DC Sayisi : " + DCsayisi + "                   DC  : " + "%" + DCyuzdesi);
            yaz.WriteLine("DD Sayisi : " + DDsayisi + "                   DD  : " + "%" + DDyuzdesi);
            yaz.WriteLine("FD Sayisi : " + FDsayisi + "                   FD  : " + "%" + FDyuzdesi);
            yaz.WriteLine("FF Sayisi : " + FFsayisi + "                   FF  : " + "%" + FFyuzdesi);
            yaz.Flush();
            yaz.Close();
            fs2.Close();
        }
        static void ekranaYaz()
        {
            Console.WriteLine("*****OGRENCILERIN ORTALAMA VE HARF NOTU BİLGİLERİ****");
            Console.WriteLine();
            for (int i = 0; i < ogrenciSayisi; i++) //Herbir ogrencinin bilgilerini not ortalamasini ve harf notu bilgisini ekrana yazdiran dongudur.
            {
                Console.WriteLine(bilgiler[i] + notlar[i] + " " + harfNotuBilgisi[i]);
            }

            //ekrana harf notlarinin sayisi ve yüzdeleri yazdiririlir.
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("***HARF NOTU SAYILARI***        ***HARF NOTU YUZDELERI*** ");
            Console.WriteLine();
            Console.WriteLine("AA Sayisi : " + AAsayisi + "                   AA  : " + "%"+ AAyuzdesi);
            Console.WriteLine("BA Sayisi : " + BAsayisi + "                   BA  : " + "%"+ BAyuzdesi);
            Console.WriteLine("BB Sayisi : " + BBsayisi + "                   BB  : " + "%"+ BByuzdesi);
            Console.WriteLine("CB Sayisi : " + CBsayisi + "                   CB  : " + "%"+ CByuzdesi);
            Console.WriteLine("CC Sayisi : " + CCsayisi + "                   CC  : " + "%"+CCyuzdesi);
            Console.WriteLine("DC Sayisi : " + DCsayisi + "                   DC  : " + "%"+ DCyuzdesi);
            Console.WriteLine("DD Sayisi : " + DDsayisi + "                   DD  : " + "%"+ DDyuzdesi);
            Console.WriteLine("FD Sayisi : " + FDsayisi + "                   FD  : " + "%"+FDyuzdesi);
            Console.WriteLine("FF Sayisi : " + FFsayisi + "                   FF  : " + "%"+ FFyuzdesi);
       
        }
        static void Main(string[] args)
        { //fonksiyonlar cagirilir.
           dosyadanOku(); 
           harfNotları();
           dosyaYaz();
           ekranaYaz();
          Console.ReadKey();
        }

    }
}
