using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{

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

            byte examPoint = 75;  //Camel Casing Notation

            short orderAmount = 5000;

            // orderAmount = 75000; overflow error
            orderAmount = short.MaxValue;

            int intOrderAmount = 7500000;

            double unitPrice = 7.89;

            bool isActive = false;

            bool certainOrder = true;

            char unicodeGender = '₿';

            char unicodeCode = (char)8383;

            char gender = 'K';

            char code = (char)65;

            //struct
            //-------------------------------------------------
            //İçerisinde birden fazla değer taşıyabilen özel bir tipe ihtiyaç duyulduğunda struct olarak bu özel tipi (User Defined Type) yaratabiliriz. Verilerini stack te tutar. Bu nedenle 16 byte tan fazla değer taşıması önerilmez. Bu durumda struct yerine, reference tipli olan class nesnesi kullanımı önerilir. Struct, class tan hızlı çalışır.


            Student student = new Student();

            student.studentID = 1;
            student.studentNameSurname = "Ali Kılıç";
            student.avgPoint = 75.33;
            student.status = Convert.ToInt32(StudentStatus.Graduated);

            Console.WriteLine(student.studentNameSurname);
            Console.WriteLine((StudentStatus)student.status);

            Console.WriteLine(gender);
            Console.WriteLine(code);

            //Enum:
            //-----------------------------------------------
            //Rakamsal verileri ifadeye dönüştürür. Proje içinde rakamlarla bir bilgiyi tutmak yerine enum ile anlamlı ifadelere dönüştürerek kullanabiliriz. Bu sayede yazdığımız kodların daha kolay yorumlanabilir ve anlaşılır olması sağlanır. enum içinde tanımlanan her ifade için bir rakam karşılığı atanır. Eğer rakam ataması yapılmazsa bu ifadelere sıfır dan başlanarak, ya da bir üstteki ifadenin değeri 1 arttırılarak otomatik atanır.

            //2- Referans Tipleri
            //
            // string : karakter katarı. program içerisinde string değişkenlere değer atanırken "" içerisinde yazılır.

            string name = "Ali";

            string productName = "Bardak";

            name = productName;

            productName = "Tabak";

            Console.WriteLine("ad:" + name);
            Console.WriteLine("ürün:" + productName);

            //Arrays: - Diziler
            // İçerisinde aynı tipte birden fazla değer taşıyabilen değişken yapılarıdır.

            int productCost = 1500;

            int[] productIDs = new int[] { 1, 5, 25, 528, 1590, 15980 };

            string[] cities = { "İstanbul", "Ankara", "İzmir", "Adana", "Kars" };

            char[] chars = { 'A', 'B', 'C', '9' };

            string word = "ABC9";

            string[] studentNames = new string[10];

            int orderNo = 1;

            studentNames[9] = "Ali";
            studentNames[0] = "Ayşe";
            studentNames[orderNo] = "Oğuzhan";

        label:
            Console.WriteLine(studentNames[orderNo - 1]);

            orderNo++;

            if (orderNo <= 10)
                goto label;

            Console.WriteLine("----------------------");

            char[] list = new char[50];

            Random rastgele = new Random();

            int i = 0;

        label2:
            list[i] = (char)(rastgele.Next(32, 126));
            i++;

            if (i < list.Length)
                goto label2;

            Console.WriteLine("--------------------------");

            for (int j = 0; j < list.Length; j++)
            {
                Console.WriteLine(list[j]);
            }

            string[] colors = { "Siyah", "Beyaz", "Kırmızı", "Mavi", "Sarı", "Yeşil" };

            for (int k = 0; k < colors.Length ; k++)
            {
                Console.WriteLine(colors[k]);
            }

            Array.Sort(colors);
            Console.WriteLine("-----------------------");
            
            for (int k = 0; k < colors.Length; k++)
            {
                Console.WriteLine(colors[k]);
            }

            Array.Reverse(colors);
            Console.WriteLine("-----------------------");

            for (int k = 0; k < colors.Length; k++)
            {
                Console.WriteLine(colors[k]);
            }

            double[] prices = new double[10];

            int[] cityCodes = new int[81];
            string[] cityNames = new string[81];

            Console.WriteLine("--------------------------------");

            //INPUT : Kullanıcıdan değer alma
            //----------------------------------------------

            int tryCount = 0;

        retry:

            // alternatif
            //if (tryCount>3)
            //{
            //    Console.WriteLine("sdşfoskdfş lksşdflkşsldkf şskfş");
            //    Console.ReadKey();
            //    goto bitir;
            //}

            try
            {
                Console.Write("Kullanıcı Adını Giriniz:");
                string userName = Console.ReadLine();

                Console.Write("Şifrenizi Giriniz:");
                int password = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                tryCount++;
                Console.WriteLine("Bir hata oluştu. " + ex.Message + " Lütfen bilgilerinizi kontrol edip tekrar giriniz.");

                Console.ReadKey();
                Console.Clear();

                if (tryCount < 3)
                    goto retry;
                else
                { 
                    Console.WriteLine("Maksimum Deneme sayısını aştınız.");
                    Console.ReadKey();
                    goto bitir;
                }
            }

            Console.WriteLine("Bitti. Çıkış için bir tuşa basın.");

        bitir:
            Console.ReadKey();

        }
    }
}
