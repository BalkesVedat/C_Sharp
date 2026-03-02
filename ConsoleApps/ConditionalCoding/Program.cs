using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalCoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //const - constant - sabit
            const double usd = 43.5, eur = 53, pound = 60, tl = 1 , kdv=0.2; 
            
            double price,receiptPrice; // variable - değişken
            string control,secim;

            Console.Write("Lütfen Satış Tutarını Giriniz:");
            goto ilerle;

        tekrar:
            Console.Write("Lütfen geçerli bir satış tutarı giriniz:");
        ilerle:
            control = Console.ReadLine();

            //if (control.Length == 0)
            //{
            //    Console.Clear();
            //    goto tekrar;
            //}

            //if (control == string.Empty)
            //{
            //    Console.Clear();
            //    goto tekrar;
            //}

            bool isSuccess = double.TryParse(control, out price);

            if (!isSuccess)
            {
                Console.Clear();
                Console.Beep();
                goto tekrar;
            }


        paraSec:
            Console.WriteLine("Lütfen para birimini seçiniz:");
            Console.WriteLine("1 - EUR");
            Console.WriteLine("2 - USD");
            Console.WriteLine("3 - GBP");
            Console.WriteLine("4 - TL");
            Console.Write("Seçiminiz ? (1/2/3/4) :");

            secim = Console.ReadLine();

            /*
            if (secim == "1") // nested if
            {
                receiptPrice = price * eur;
            }
            else if (secim == "2")
            {
                receiptPrice = price * usd;
            }
            else if (secim == "3")
            {
                receiptPrice = price * pound;
            }
            else if (secim == "4")
            {
                receiptPrice = price * tl;
            }
            else 
            {
                Console.Clear();
                Console.Beep();
                goto paraSec;
            }
            */

            switch (secim)
            {
                case "1":
                    receiptPrice = price * eur;
                    break;
                case "2":
                    receiptPrice = price * usd;
                    break;
                case "3":
                    receiptPrice = price * pound;
                    break;
                case "4":
                    receiptPrice = price * tl;
                    break;
                default:
                    Console.Clear();
                    Console.Beep();
                    goto paraSec; 
            }

            Console.WriteLine("Satış Tutarı:" + receiptPrice);
            Console.WriteLine("KDV Tutarı:" + receiptPrice * kdv);
            Console.WriteLine("KDV Dahil Satış Tutarı:" + receiptPrice*(1+kdv));

            Console.ReadKey();

        }
    }
}
