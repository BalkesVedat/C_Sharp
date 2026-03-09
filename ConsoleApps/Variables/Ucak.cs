using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    internal class Ucak
    {
        // property tanımlama ve oto encapsulation
        // 

        private double maxHiz = 200;

        private string marka;

        public string Marka
        {
            get { return marka; }
            set { marka = value; }
        }

        private double anlikHiz;

        public double AnlikHiz
        {
            get { return anlikHiz; }
            set
            {
                anlikHiz = value;

                if (anlikHiz < 0)
                    anlikHiz = 0;

                if (anlikHiz > maxHiz)
                    anlikHiz = maxHiz;
            }
        }

        public string Model { get; set; }

        private double fiyat;
        public double Fiyat
        {
            get { return fiyat; }
            set
            {
                if (value < 0)
                    fiyat = value * (-1);
                else
                    fiyat = value;
            }
        }

        public double Mil { get; set; }

        public int YolcuSayisi { get; set; }


    }
}
