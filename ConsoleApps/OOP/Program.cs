using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{

    #region OOP Ders Notları

    /*
      OOP - Object Oriented Programming - Nesneye Dayalı Programlama
    
    Programın içinde kullanılan değişenlerin, metodların ve yapıların daha düzenli yaratılabilmesini ve kullanılabilmesini sağlar. Kod tekrarını engeller. Kodların daha sade ve sağlıklı olmasını sağlar.
    OOP KONULARI:
    1- Encapsulation : Kapsülleme
    Bir class içindeki fieldlara (class değişkenleri), class dışında erişimi kısıtlamak için kullanılır. field lar private olarak işaretlenir ve  bu fildlara dışarıdan erişim kapatılır. Fieldlara erişerek veri atama ya da okuma için dışarıdan erişime açık metodlar ya da public property'ler (getter - setter) kullanılır. Bu sayede erişim kontrollü hale gelir. Metod içinde ilave kontroller yapılarak verinin sağlıklı olarak iletimi garanti edilir. İstenmeyen kodlar dışarıya kapatılır.

     2- Inheritance : Kalıtım
        Bir class, başka bir class tan özellik ve diğer içeriklerini devralabilir. Ata sınıf içerisindeki bütün public elemanlar devralan sınıfa aktarılır. class alt_sinif: ata_sinif şeklinde tanımlanır. Ata sınıfa base class, alt sınıfa da derived class (türemiş sınıf) da denir. Bu işleme miras alma da denir.
    3- Polimorphism - Polimorfizm - Çok biçimlilik
        Bir sınıfın, ata sınıfları gibi davranabilmesi durumudur. Alt sınıflar içerisinde kendilerine özelliştirilmiş metodlara sahipse, ister ata sınıftaki aynı metodu, isterlerse kendi özelliştirilmiş (override) metodlarını çalıştırabilirler. Duruma göre ata sınıf gibi, duruma göre kendi sımıfları gibi çalıştırılabilmeleri durumudur. Bu konuya "object" sınıfı örnek gösterilebilir. C# ta bütün tipler, "object" tipinden türetilmişlerdir. Yani int, string, enum, struct, class, ... tüm tipler aynı zamanda birer object tir ve object yerine de kullanılabilirler. 

    4 - Abstraction - Soyutlama
        Ata sınıf içindeki metodun kendi görevi olmayacak ve kendisinden türetilen alt sınıflarda ezilerek (override) özelleştirilmeleri gerekecek ise, ata sınıftaki metod soyut metod (abstract) olarak tanımlanır. 
    örneğin: public abstract void Oku(); şeklinde tanımlanırlar. (*)(*)(*) Abstract bir metodun gövdesi ({}) olmaz. Sadece alt sınıflarda yazılması gereken bir metodun tarifi (şablonu) niteliğindedir. (*) Alt sınıfta override edilerek yeniden yazılması zorunludur.
    örneğin: public override void Oku() {..kodlar...;}
    (*)  Eğer bir class içinde abstract bir nesne varsa, class ta abstract olmak zorundadır.
    örneğin: public abstract class Document {....}  gibi yazılmalıdır.
    (*) abstract olarak işaretlenmiş bir class tan nesne örneği alınamaz. Sadece bir şablon niteliğindedir ve kendisinden alt sınıfların türetilmesinde kullanılır.
    örneğin :  Document doc = new Document();  yazılamaz.

    */

    #endregion


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
