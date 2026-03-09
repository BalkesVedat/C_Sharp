using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    internal class Araba
    {
        //field ile tanımlama ve manuel encapsulation

        public string marka;
        public string model;
        public double km = 0;
        public double fiyat =0;
        private double maxSurat = 200;
        private double anlikHiz = 0;


        public double GetHiz()
        {
            return anlikHiz;
        }

        public void setHiz(double value)
        { 
            anlikHiz += value;

            if (anlikHiz > maxSurat)
                anlikHiz = maxSurat;

            if (anlikHiz < 0 )
                anlikHiz = 0;             
        }

        public void Hizlan()
        {
            if (anlikHiz + 20 > maxSurat)
                anlikHiz = maxSurat;
            else
                anlikHiz += 20;
        }

        public void Yavasla()
        {
            if (anlikHiz - 20 < 0)
                anlikHiz = 0;
            else
                anlikHiz -= 20;
        }


        public void Test()
        {
            Console.WriteLine("Araba Test");
        }

        
    }
}
