using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    abstract class Document
    {
        public string DosyaAd { get; set; } // 1 - Encapsulation - Kapsülleme - Property ile kontrollü field kullanımı
        public string Path { get; set; }
        public double Boyutu { get; set; }
        string Uzanti { get; set; }

        public abstract void Yaz(); //abstraction
        //{
        //    Console.WriteLine("Doküman yazdırıldı.");
        //}

        public abstract void Oku();

    }

    class PDFDocument:Document // Inheritance - Kalıtım
    {
        public string Password { get; set; }

        public override void Oku() // abstraction - override
        {
            Console.WriteLine("PDF okundu");
        }

        public override void Yaz() // abstraction - override
        {
            Console.WriteLine("PDF Dosyası yazdırıldı.");
        }
    }

    class WordDocument:Document
    {
        public string Password { get; set; }
        public override void Yaz()
        {
            Console.WriteLine("Word Doküman yazdırıldı.");
        }

        public override void Oku()
        {
            Console.WriteLine("Word Doküman okundu.");
        }

    }

    class TxtDocument:Document
    {
        public override void Oku()
        {
            throw new NotImplementedException();
        }

        public override void Yaz()
        {
            Console.WriteLine("TXT Doküman yazdırıldı.");
        }
    }

    class XLSDocument:Document
    {
        public string Password { get; set; }

        public override void Oku()
        {
            throw new NotImplementedException();
        }

        public override void Yaz()
        {
            Console.WriteLine("XLS Doküman yazdırıldı.");
        }
    }

    class JPGDocument:Document
    {
        public override void Oku()
        {
            throw new NotImplementedException();
        }

        public override void Yaz()
        {
            Console.WriteLine("JPG Doküman yazdırıldı.");
        }
    }

    class XMLDocument : TxtDocument
    {
        public new void Yaz()
        {
            Console.WriteLine("XML Doküman yazdırıldı.");
        }

    }

    class PPTDocument : Document
    {
        public override void Oku()
        {
            throw new NotImplementedException();
        }

        public override void Yaz()
        {
            throw new NotImplementedException();
        }
    }


    internal class Program
    {
        public static void Yazdir(Document d)
        {
            d.Yaz();      
        }


        static void Main(string[] args)
        {
            //Document d1 = new Document();

            //d1.Yaz();

            PDFDocument pdf1 = new PDFDocument();

            pdf1.DosyaAd = "dsasdas";
            pdf1.Yaz();

            TxtDocument txt1 = new TxtDocument();

            txt1.Yaz();


            //Polimorphism - Polimorfizm - Çok Biçimlilik

            Program.Yazdir(pdf1);
            Program.Yazdir(txt1);
            Program.Yazdir(new JPGDocument());

            Document ddd = new WordDocument();

            Program.Yazdir(ddd);

            TxtDocument xxx = new XMLDocument();

            Program.Yazdir(xxx);

            ArrayList liste = new ArrayList();

            liste.Add(21);
            liste.Add("sdfdsfdsf");
            liste.Add(true);
            liste.Add(pdf1);



        }
    }
}
