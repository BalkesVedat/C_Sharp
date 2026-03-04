using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Ders Notları
            /*
                Döngüler: Bir işlemin 1 den fazla kere çalışması gerektiğinde. Aynı kodu tekrar yazmak gereksiz kod tekrarına, güncelleme sorunlarına, performans sorunlarına ve kod karmaşasına neden olur. Aynı kodu arka arkaya aynen yazıp çalıştırmak yerine, ilgili kodu 1 den fazla çalıştırmayı sağlayan mekanizma kurulmalıdır. Bu mekanizmalara yazılım dilinde döngü (loop) denir.
            Döngü çeşitleri:
            1- FOR döngüsü: Bir kodun belli bir adette tekrarlanması gerektiğinde kullanmak için idealdir. Döngü çeşitleri içinde en hızlı çalışanıdır.
            2- WHILE döngüsü: Bir kodun belli bir koşula bağlı olarak belirsiz sayıda çalışması gerektiğinde idealdir. Kod ilk çalışmada koşul kontrolü yapılmayacak ise DO...WHILE versiyonu kullanılabilir.
            3- FOREACH döngüsü: Bir kolleksiyondaki (liste, dizi) her bir eleman için bir işlem yapılacak ise bu döngü tipi idealdir. 



            */
            #endregion

            #region for döngüsü
            // FOR DÖNGÜSÜ:
            //-----------------------------------------------

            // ekrana 10 kez "merhaba" yazdır.

            //    for (int i = 0; i < 10; i++)
            //    {
            //        Console.WriteLine("Merhaba");
            //    }

            //    // ekrana 1-10 arası sayıları yazdır.

            //    for (int i = 0; i < 10; i++)
            //    {
            //        Console.WriteLine(i + 1 + " vedat");
            //    }

            //    // girilen 2 değer arası tek sayıları beyaz, çift sayıları kırmızı yazdır

            //    Console.Write("Başlangıç değeri:");
            //    int startValue = 0, endValue = 0;
            //    bool success = int.TryParse(Console.ReadLine(), out startValue);


            //    Console.Write("Bitiş değeri:");
            //    success = int.TryParse(Console.ReadLine(), out endValue);

            //    //Değişkenlerin değerinin değiştirilmesi gerekirse:
            //    if (startValue > endValue)
            //    {
            //        int temp = 0;
            //        temp = endValue;
            //        endValue = startValue;
            //        startValue = temp;
            //    }


            //    for (int i = startValue; i <= endValue; i++)
            //    {
            //        if (i % 2 == 1)
            //        {
            //            Console.BackgroundColor = ConsoleColor.White;
            //            Console.ForegroundColor = ConsoleColor.Black;
            //            //Console.Clear();
            //            Console.WriteLine(i);

            //            System.Threading.Thread.Sleep(100);
            //        }
            //        else
            //        {
            //            Console.BackgroundColor = ConsoleColor.Red;
            //            Console.ForegroundColor = ConsoleColor.White;
            //            //Console.Clear();

            //            Console.WriteLine(i);

            //            System.Threading.Thread.Sleep(100);
            //        }
            //    }

            //    Console.WriteLine("------------------------");

            //    Console.Write("Başlangıç değeri:");
            //    startValue = 0; endValue = 0;
            //    success = int.TryParse(Console.ReadLine(), out startValue);

            //    Console.Write("Bitiş değeri:");
            //    success = int.TryParse(Console.ReadLine(), out endValue);

            //    for (int i = startValue; ; )
            //    {
            //        if (startValue < endValue)
            //        {
            //            if (i > endValue)
            //            {
            //                goto bitir;
            //            }
            //        }
            //        else
            //        {
            //            if (i < endValue)
            //            {
            //                goto bitir;
            //            }
            //        }

            //        if (i % 2 == 1)
            //        {
            //            Console.BackgroundColor = ConsoleColor.White;
            //            Console.ForegroundColor = ConsoleColor.Black;
            //            //Console.Clear();
            //            Console.WriteLine(i);
            //            System.Threading.Thread.Sleep(100);
            //        }
            //        else
            //        {
            //            Console.BackgroundColor = ConsoleColor.Red;
            //            Console.ForegroundColor = ConsoleColor.White;
            //            //Console.Clear();
            //            Console.WriteLine(i);
            //            System.Threading.Thread.Sleep(100);
            //        }

            //        // sayıların değerine göre artan ya da azalan sıralamada çalışması istenirse:
            //        if (startValue < endValue)
            //            i++;
            //        else
            //            i--;
            //    }
            //bitir:
            //
            //

            //int[] status = { 1, 0, 0, 1, 1, 1, 1, 0, 1, 0, 1, 1, 1, 1, 0,1,1,1,1,0,1};

            //for (int i = 0; i < status.Length; i++) 
            //{
            //    if (status[i] == 0)
            //       continue;// atla ve sonraki ile devam et. 
            //    // break; kodu keser ve sonlandırır.
            //    else
            //        Console.WriteLine(i + ". müşteriye mail gönderildi.");
            //}

            #endregion

            #region While döngüsü
            //double dblNumber1 = 0;
            //double dblNumber2 = 0;
            //double sonuc = 0;
            //string oprt, cevap = "E";

            //while (cevap.ToUpper() == "E")
            //{
            //    Console.Write("1.Sayıyı gir:");

            //    bool x = double.TryParse(Console.ReadLine(), out dblNumber1);

            //oprtTekrar:
            //    Console.Write("İşlem giriniz(+,-,*,/):");
            //    oprt = Console.ReadLine();

            //    if (oprt != "+" && oprt != "-" && oprt != "/" && oprt != "*")
            //    {
            //        goto oprtTekrar;
            //    }

            //    Console.Write("2.Sayıyı gir:");

            //    x = double.TryParse(Console.ReadLine(), out dblNumber2);

            //    switch (oprt)
            //    {
            //        case "+":
            //            sonuc = dblNumber1 + dblNumber2;
            //            break;
            //        case "-":
            //            sonuc = dblNumber1 - dblNumber2;
            //            break;
            //        case "*":
            //            sonuc = dblNumber1 * dblNumber2;
            //            break;
            //        case "/":
            //            if (dblNumber2 == 0)
            //                sonuc = 0;
            //            else
            //                sonuc = dblNumber1 / dblNumber2;
            //            break;
            //    }

            //    Console.WriteLine(dblNumber1 + oprt + dblNumber2 + "=" + sonuc);

            //    do
            //    {
            //        Console.Write("Yeni hesaplama yapmak ister misiniz? (E/H) :  ");

            //        cevap = Console.ReadLine();
            //    } while (cevap.ToUpper() != "E" && cevap.ToUpper() != "H");


            //}


            //Console.WriteLine("-----------------------------");

            //int counter = 16;

            //while (counter <= 15)
            //{
            //    Console.WriteLine(counter + ". işlem yapıldı.");
            //    counter++;
            //}

            //Console.WriteLine("---------------------------");

            //do
            //{
            //    Console.WriteLine(counter + ". işlem yapıldı.");
            //    counter++;

            //} while (counter <= 15);


            #endregion

            #region Örnekler

            //1-10 arası sayıların karesini ekrana yazan program

            //for (int i = 1; i < 10; i++)
            //{
            //    Console.WriteLine(i + " in karesi :" + i * i);
            //}

            // ekrandan öğrenci sayısını alıp, her bir  öğrenci için girilen notların toplamını ve ortalamasını hesaplayan program.

            //    double toplam = 0;
            //    double deger = 0;
            //    bool ok;
            //    int s = 1;
            //    int ogrenciSayisi = 0;

            //tekrar:
            //    Console.Write("Öğrenci Sayısını Giriniz:");
            //    ok = int.TryParse(Console.ReadLine(), out ogrenciSayisi);

            //    if (!ok)
            //        goto tekrar;

            //    for (; s <= ogrenciSayisi; s++)
            //    {
            //        Console.Write(s + ". sayıyı giriniz:");
            //        ok = double.TryParse(Console.ReadLine(), out deger);
            //        toplam += deger;
            //    }

            //    Console.WriteLine("Toplam:" + toplam);
            //    Console.WriteLine("Ortalama:" + toplam / (s-1));



            //kullanıcı devam etmek istediği müddetçe not girişi yapan ve giriş bittikten sonra toplam ve ortalamayı gösteren program.

            //int t = 1;
            //double deger = 0;
            //bool donusumSonucu;
            //double toplam = 0;
            //string cevap;

            //do
            //{
            //yeniden:
            //    Console.Write(t + ". notu giriniz:");
            //    donusumSonucu = double.TryParse(Console.ReadLine(), out deger);

            //    if (!donusumSonucu || deger <0 || deger > 100)
            //    {
            //        goto yeniden;
            //    }

            //    toplam += deger;

            //tekrar:
            //    Console.Write("Yeni not girmek istiyor musunuz? (E/H)");
            //    cevap = Console.ReadLine();

            //    if (cevap.ToUpper() != "E" && cevap.ToUpper() != "H")
            //    {
            //        goto tekrar;
            //    }

            //    t++;
            //} while (cevap.ToUpper() == "E");

            //Console.WriteLine("Öğrenci Sayısı : " + (t-1));
            //Console.WriteLine("Toplam         : " + toplam);
            //Console.WriteLine("Ortalama       : " +  toplam / (t-1) );



            #endregion


            #region Foreach döngüsü
            // FOREACH Döngüsü

            string[] ogrenciListesi = {"Jeyhun", "Ayşe", "Oğuzhan", "Muhammed", "Kübra"};

            foreach (string item in ogrenciListesi) 
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("--------------------------------------");
            // Tek karakter tek karakter yazdırmak için.

            foreach (string item in ogrenciListesi)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    Console.Write(item[i]);
                    System.Threading.Thread.Sleep(200);
                }
                Console.WriteLine("");
            }

            object[] veriler = {"vedat", 213, 55.88,'c',true};

            ArrayList data = new ArrayList() {"aaaaa",true,'x'};

            data.Add("jkjkkk");
            data.Add(324);
            data.Add(234.55);

            foreach (var item in veriler)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("-----------------------");

            double toplam=0;

            foreach (var item in data)
            {
                double deger = 0;
                bool kontrol = double.TryParse(item.ToString(), out deger);

                if (kontrol)
                {
                    toplam += deger;
                }
                else
                {
                    Console.WriteLine("dönüştürülemeyen değer:" + item.ToString());
                }
            }

            Console.WriteLine("Toplam:" + toplam);

            #endregion

            Console.ReadKey();

        }
    }
}
