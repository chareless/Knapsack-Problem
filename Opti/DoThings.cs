using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opti
{
    class DoThings
    {
        public static List<Cisim> cisim = new List<Cisim>();

        public void cisimOlustur(int deger, int kg, string name)
        {
            cisimCount++;
            cisim.Add(new Cisim() { deger = deger, kg = kg, name = name });
            
        }

        public static int cisimCount = 0;

        public void randomCreate(int count,int degerSinir,int kiloSinir)
        {
            Random rand = new Random();
            for(int i=0;i<count;i++)
            {
                cisimOlustur(rand.Next(1,degerSinir+1), rand.Next(1,kiloSinir+1), "Cisim" + (i+1));
            }
        }
    }
}
