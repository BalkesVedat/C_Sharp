using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    public enum Turler
    { 
        Sürüngen, 
        Kuş, 
        Böcek, 
        Memeli, 
        Bitki, 
        TekHücreli
    }


    internal class Canli
    {
        //Constructor
        public Canli()
        {

        }

        public Canli(Turler tur, string cinsi, byte ayakSayisi, bool yuzebilirMi, string ses)
        {
            Tur = tur;
            Cinsi = cinsi;
            AyakSayisi = ayakSayisi;
            YuzebilirMi = yuzebilirMi;
            Ses = ses;
        }

        //Property ler
        public Turler Tur { get; set; }
        public string Cinsi { get; set; }
        public byte AyakSayisi { get; set; }
        public bool YuzebilirMi { get; set; }
        public string Ses { get; set; }


        //Metodlar

        public void SesCikar()
        {
            Console.WriteLine(Ses);
        }

        public static string SesVer(Turler t)
        {
            string ses = "";

            switch (t)
            {
                case Turler.Memeli:
                    ses = "aaaaaa";
                    break;
                case Turler.Sürüngen:
                    ses = "Tıssss";
                    break;
                case Turler.Böcek:
                    ses = "Tıkır tıkır";
                    break;
                case Turler.Kuş:
                    ses = "Fiyuuu fiyuu";
                    break;

                default:
                    break;
            }
            return ses;
        }


    }
}
