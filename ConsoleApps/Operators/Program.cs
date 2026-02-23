using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Operatörler : kodumuzun içinde aritmetik işlemler, karşılaştırma işlemleri, kontrol işlemleri yaparken kullandığımız sembollerdir.

            /* 
            1. Aritmetik operatörler : +,-,*,/,%
                + sayıların arasına konulduğunda "toplama" operatörüdür. ifadelerden biri sayı değil ise o zaman "birleştirme" operatörü olarak çalışır.
                % mod alma operatörüdür. 1. sayının 2. sayıya bölümünden artan değeri verir. 10 % 7 = 3
            2. Atama operatörü : =
                a = b şeklinde kullanılır. = işaretinin sağındaki bilgi, soldaki nedneye değer olarak atanır.
                    a = 5;
                    b = 100;

                    c = a * b;
            3. Karşılaştırma operatörleri: <,<=,>,>=,==,!=,===
                a = 5;
                b = 100;
                c = 5.0;
                d = "5";
                a<=b; // true
                a!=b; //true
                a==b; //false
                a==c; //true
                a===c; //false
                a===d; //false
            karşılaştırma operatörleri, sağına ve soluna yazılan değerleri kontrol eder ve kontrol ettiği duruma göre, durumun gerçek olması durumunda "true", değilse "false" sonucunu üretir.
            4. Birleşik işlem operatörleri : ++, --, +=, -=, *=, /=  
            
            a=5; b=100; c=20;

            a++; b--; c+=a; (c = c + a)

            a (6) ; b (99) ; c (26)

            ++: yanına konulduğu nesnenin değerini 1 arttırır.
            ... diğerleri de aynı mantık.


            */

            Console.WriteLine(125 + 222); // toplama
          Console.WriteLine(125 + "adet"); //birleştirme
          Console.WriteLine("Bu bir" + " metindir");
          Console.WriteLine(10%7);

           int a = 5;
           int b = 100;
           int c = a * b;
            a += b;
            b *= 3;
            a++;

            Console.WriteLine("c: "+c);
            Console.WriteLine("a: "+a);
            Console.WriteLine("b: "+b);

            a++;
            Console.WriteLine("a: "+a);
        }
    }
}
