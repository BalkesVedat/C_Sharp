using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace Variables
{
    class Book
    {
        //constructor method
        public Book()
        {
            Console.WriteLine("Default Constructor metodu çalıştı.");
        }

        public Book(int iD, string name, string auth)
        {
            bookID = iD;
            bookName = name;
            author = auth;
            Console.WriteLine(true);
        }

        //Field (alan) : class değişkenleri
        public int bookID;
        public string bookName;
        public string author;
        public int pages;
        public string bookType; // db den 1,2,3 gibi datası geliyorsa int olmalı.
        public string publisher;

        //kullanıcı tanımlı metodlar

        public void GetInfo()
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("ID:{0} Kitap Adı:{1} Yazarı:{2} Sayfa Sayısı:{3} Türü:{4} Yayınevi:{5}", bookID, bookName, author, pages, bookType, publisher);
        }

        public string GetAuthor()
        {
            return author;
        }


        public bool isAuthorExist()
        {
            if (author != null && author.Length > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    partial class Computer
    {
        public static double Compute(double number1, double number2, char oprt)
        {
            double result = 0;

            switch (oprt)
            {
                case '*':
                    result = number1 * number2;
                    break;
                case '+':
                    result = number1 + number2;
                    break;
                case '-':
                    result = number1 - number2;
                    break;
                case '/':
                    if (number2 != 0)
                        result = number1 / number2;
                    break;
                default:
                    break;
            }
            return result;
        }


    }

    #region Öncekiler
    public struct Student
    {
        public int studentID;
        public string studentNameSurname;
        public double avgPoint;
        public int status;
    }

    public enum StudentStatus
    {
        Active = 1,
        Deleted = 0,
        Freezed = 2,
        Graduated = 3
    }

    public enum Gender
    {
        Female,
        Male
    }

    public enum Color
    {
        White = 0,
        Blue = 5,
        Red = 1,
        Green = 3,
        Yellow = 10,
        Black = 20
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Değişkenler: Bir bilgiyi geçici olarak hafıza tutmak için kullanılan nesnelerdir. Değişken tanımlanırken içerisinde ne tür veri tutulacağı belirtilmelidir. 
            Değişken Tipleri :
            1 - Değer Tipli Değişkenler (Value Type) Stack kısmında veri tutar.
                a) Sayısal Tipler: byte, short, int, long, decimal, double, float.
                b) Mantıksal değer tipi (boolean) 
                    bool
                c) Enum - enumeration - numaralandırma
                d) Struct - Yapı - Complex - usertype - kullanıcı tanımlı tipler
                e) char - tek karakterlik metin.
            2 - Referans Tipli Değişkenler (Reference Type) Heap te veriyi tutar, stack te verinin bulunduğu heap alanı adresini tutar.
                string, array, class, delegate, interface
             */

            //Değer Tipleri:

            //Numeric Types
            //-----------------------------------------------------

            //    byte examPoint = 75;  //Camel Casing Notation

            //    short orderAmount = 5000;

            //    // orderAmount = 75000; overflow error
            //    orderAmount = short.MaxValue;

            //    int intOrderAmount = 7500000;

            //    double unitPrice = 7.89;

            //    bool isActive = false;

            //    bool certainOrder = true;

            //    char unicodeGender = '₿';

            //    char unicodeCode = (char)8383;

            //    char gender = 'K';

            //    char code = (char)65;

            //    //struct
            //    //-------------------------------------------------
            //    //İçerisinde birden fazla değer taşıyabilen özel bir tipe ihtiyaç duyulduğunda struct olarak bu özel tipi (User Defined Type) yaratabiliriz. Verilerini stack te tutar. Bu nedenle 16 byte tan fazla değer taşıması önerilmez. Bu durumda struct yerine, reference tipli olan class nesnesi kullanımı önerilir. Struct, class tan hızlı çalışır.


            //    Student student = new Student();

            //    student.studentID = 1;
            //    student.studentNameSurname = "Ali Kılıç";
            //    student.avgPoint = 75.33;
            //    student.status = Convert.ToInt32(StudentStatus.Graduated);

            //    Console.WriteLine(student.studentNameSurname);
            //    Console.WriteLine((StudentStatus)student.status);

            //    Console.WriteLine(gender);
            //    Console.WriteLine(code);

            //    //Enum:
            //    //-----------------------------------------------
            //    //Rakamsal verileri ifadeye dönüştürür. Proje içinde rakamlarla bir bilgiyi tutmak yerine enum ile anlamlı ifadelere dönüştürerek kullanabiliriz. Bu sayede yazdığımız kodların daha kolay yorumlanabilir ve anlaşılır olması sağlanır. enum içinde tanımlanan her ifade için bir rakam karşılığı atanır. Eğer rakam ataması yapılmazsa bu ifadelere sıfır dan başlanarak, ya da bir üstteki ifadenin değeri 1 arttırılarak otomatik atanır.

            //    //2- Referans Tipleri
            //    //
            //    // string : karakter katarı. program içerisinde string değişkenlere değer atanırken "" içerisinde yazılır.

            //    string name = "Ali";

            //    string productName = "Bardak";

            //    name = productName;

            //    productName = "Tabak";

            //    Console.WriteLine("ad:" + name);
            //    Console.WriteLine("ürün:" + productName);

            //    //Arrays: - Diziler
            //    // İçerisinde aynı tipte birden fazla değer taşıyabilen değişken yapılarıdır.

            //    int productCost = 1500;

            //    int[] productIDs = new int[] { 1, 5, 25, 528, 1590, 15980 };

            //    string[] cities = { "İstanbul", "Ankara", "İzmir", "Adana", "Kars" };

            //    char[] chars = { 'A', 'B', 'C', '9' };

            //    string word = "ABC9";

            //    string[] studentNames = new string[10];

            //    int orderNo = 1;

            //    studentNames[9] = "Ali";
            //    studentNames[0] = "Ayşe";
            //    studentNames[orderNo] = "Oğuzhan";

            //label:
            //    Console.WriteLine(studentNames[orderNo - 1]);

            //    orderNo++;

            //    if (orderNo <= 10)
            //        goto label;

            //    Console.WriteLine("----------------------");

            //    char[] list = new char[50];

            //    Random rastgele = new Random();

            //    int i = 0;

            //label2:
            //    list[i] = (char)(rastgele.Next(32, 126));
            //    i++;

            //    if (i < list.Length)
            //        goto label2;

            //    Console.WriteLine("--------------------------");

            //    for (int j = 0; j < list.Length; j++)
            //    {
            //        Console.WriteLine(list[j]);
            //    }

            //    string[] colors = { "Siyah", "Beyaz", "Kırmızı", "Mavi", "Sarı", "Yeşil" };

            //    for (int k = 0; k < colors.Length ; k++)
            //    {
            //        Console.WriteLine(colors[k]);
            //    }

            //    Array.Sort(colors);
            //    Console.WriteLine("-----------------------");

            //    for (int k = 0; k < colors.Length; k++)
            //    {
            //        Console.WriteLine(colors[k]);
            //    }

            //    Array.Reverse(colors);
            //    Console.WriteLine("-----------------------");

            //    for (int k = 0; k < colors.Length; k++)
            //    {
            //        Console.WriteLine(colors[k]);
            //    }

            //    double[] prices = new double[10];

            //    int[] cityCodes = new int[81];
            //    string[] cityNames = new string[81];

            //    Console.WriteLine("--------------------------------");

            //    //INPUT : Kullanıcıdan değer alma
            //    //----------------------------------------------

            //    int tryCount = 0;

            //retry:

            //    // alternatif
            //    //if (tryCount>3)
            //    //{
            //    //    Console.WriteLine("sdşfoskdfş lksşdflkşsldkf şskfş");
            //    //    Console.ReadKey();
            //    //    goto bitir;
            //    //}

            //    try
            //    {
            //        Console.Write("Kullanıcı Adını Giriniz:");
            //        string userName = Console.ReadLine();

            //        Console.Write("Şifrenizi Giriniz:");
            //        int password = Convert.ToInt32(Console.ReadLine());
            //    }
            //    catch (Exception ex)
            //    {
            //        tryCount++;
            //        Console.WriteLine("Bir hata oluştu. " + ex.Message + " Lütfen bilgilerinizi kontrol edip tekrar giriniz.");

            //        Console.ReadKey();
            //        Console.Clear();

            //        if (tryCount < 3)
            //            goto retry;
            //        else
            //        { 
            //            Console.WriteLine("Maksimum Deneme sayısını aştınız.");
            //            Console.ReadKey();
            //            goto bitir;
            //        }
            //    }

            //    Console.WriteLine("Bitti. Çıkış için bir tuşa basın.");

            //bitir:
            //    Console.ReadKey(); 
            #endregion


            //---------------------------------------

            // CLASS : Sınıf : Referans tipli, kullanıcı tanımlı yapılardır. Kendi özel tipimizi class ile yaratabiliriz. Referans tipli oldukları için datalarını belleğin heap bölgesinde saklarlar. Bu nedenle büyük data taşıyan yapıları, struct yerine class ile tanımlarız.

            //    Book b1 = new Book();

            //    b1.bookID = 1;
            //    b1.bookName = "Test";
            //    //b1.author = "Vedat";
            //    b1.bookType = "Polisiye";
            //    b1.publisher = "ffffff";
            //    b1.pages = 192;


            //    Book b2 = new Book();

            //    b2.bookID = 2;
            //    b2.bookName = "Cin Ali";
            //    b2.pages = 5;

            //    b2 = b1;

            //    Console.WriteLine(b2.bookName);

            //    b1.bookName = "Vadideki Zambak";

            //    Console.WriteLine(b2.bookName);
            //    Console.WriteLine(b1.bookName);

            //    string marka = "abcxyz";

            //    Console.WriteLine("-------------------");

            //    Book b3 = new Book(3, "hgfd", "Vedat");

            //    Console.WriteLine(b3.bookName);

            //    b1.GetInfo();

            //    b2.GetInfo();

            //    b3.GetInfo();

            //    string gelen = b1.GetAuthor();

            //    if (gelen != null && gelen.Length > 0)
            //    {
            //        //Console.WriteLine(gelen);
            //    }
            //    else
            //    {
            //        Console.WriteLine(b1.bookName + " isimli kitabın yazar adı girilmemiş.");

            //        Console.WriteLine("{0} isimli kitabın yazar adı girilmemiş.", b1.bookName);

            //        Console.WriteLine($"{b1.bookName} isimli kitabın yazar adı girilmemiş.");

            //        //string metin = "";
            //        //metin += b1.bookName;
            //        //metin += " ";
            //        //metin += "isimli kitabın yazar adı girilmemiş.";
            //        //Console.WriteLine(metin);

            //        StringBuilder sb = new StringBuilder();

            //        sb.Append(b1.bookName);
            //        sb.Append(" ");
            //        sb.Append("isimli kitabın yazar adı girilmemiş.");

            //        Console.WriteLine(sb.ToString());

            //    }

            //    if (b1.isAuthorExist())
            //    {
            //        Console.WriteLine(b1.GetAuthor());
            //    }

            //    Computer c1 = new Computer();

            //    double result = c1.Multiply(25, 55);
            //    Console.WriteLine($"Sonuc:{result}");

            //    //TODO: Kullanıcıdan alınan 2 sayıyı, yine kullanıcının girdiği operatöre göre hesaplayacak programı yaz.


            //    result = Computer.Compute(25, 55, '+');

            //    Console.WriteLine($"Sonuc:{result}");

            //    // Kullanıcıdan alınan değerlere göre hesaplama yapan program:
            //    double dblNumber1 = 0, dblNumber2 = 0, dblResult = 0;
            //    char oprt;

            //retry1:
            //    Console.Write("1. Sayıyı Giriniz:");
            //    bool isSuccess = double.TryParse(Console.ReadLine(), out dblNumber1);

            //    if(!isSuccess)
            //        goto retry1;

            //    retry2:
            //    Console.Write("2. Sayıyı Giriniz:");
            //    isSuccess = double.TryParse(Console.ReadLine(), out dblNumber2);

            //    if (!isSuccess)
            //        goto retry2;

            //    retry3:
            //    Console.Write("İşlem Seçiniz [+, -, *, /] :");
            //    isSuccess = char.TryParse(Console.ReadLine(), out oprt);

            //    //oprt = (char)Console.Read();

            //    if (!isSuccess)
            //        goto retry3;

            //    if (oprt != '+' && oprt != '-' && oprt != '*' && oprt != '/')
            //        goto retry3;

            //        dblResult = Computer.Compute(dblNumber1, dblNumber2, oprt);

            //    Console.WriteLine($"{dblNumber1}{oprt}{dblNumber2}={dblResult}");

            // Araba.Test(); // static tanımlansaydı bu şekilde çalıştırılabilirdi.

            //Araba ferrari = new Araba();



            //ferrari.Hizlan();
            //ferrari.Hizlan();
            //ferrari.Hizlan();
            //ferrari.Hizlan();

            ////  ferrari.anlikHiz = 250;
            //ferrari.Test();



            Ucak u = new Ucak();

            u.Marka = "Boeing";

            Console.WriteLine(u.Marka);
            Console.WriteLine(u.AnlikHiz);

            ConsoleKeyInfo key;

            do
            {
                key = Console.ReadKey();
                if (key.Key == ConsoleKey.UpArrow)
                {
                    u.AnlikHiz += 20;
                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    u.AnlikHiz -= 20;
                }

                Console.WriteLine(u.AnlikHiz);

            } while (key.Key != ConsoleKey.Escape);


            //u.AnlikHiz = 150;
            //Console.WriteLine(u.AnlikHiz);
            //u.AnlikHiz += 80;
            //Console.WriteLine(u.AnlikHiz);
            //u.AnlikHiz -= 500;
            //Console.WriteLine(u.AnlikHiz);

            //do
            //{
            //   ConsoleKeyInfo ki = Console.ReadKey();

            //    Console.WriteLine(ki.Key +"-" + ki.KeyChar + " - " + ki.ToString());
            //} while (true);

            u.Marka = "Airbus";
            u.Model = "A300";
            u.Fiyat = -6545646;

            double ff = u.Fiyat;

            Console.WriteLine(u.Fiyat);


            Canli c1 = new Canli();

            c1.Tur = Turler.Kuş;
            c1.Cinsi = "Penguen";
            c1.AyakSayisi = 2;
            c1.YuzebilirMi = true;
            c1.Ses = Canli.SesVer(Turler.Kuş);

            c1.SesCikar();

            Canli c2 = new Canli(Turler.Sürüngen, "Kobra", 0, true, Canli.SesVer(Turler.Sürüngen));

            c2.SesCikar();

            Canli c3 = new Canli() 
            {
                Tur=Turler.Böcek, 
                Ses= Canli.SesVer(Turler.Böcek), 
                Cinsi="Hamam Böceği",
                AyakSayisi=6,
                YuzebilirMi=true
            };

            c3.SesCikar();

            Console.WriteLine(Canli.SesVer(Turler.Sürüngen)); 

            Console.ReadKey();
        }
    }
}
