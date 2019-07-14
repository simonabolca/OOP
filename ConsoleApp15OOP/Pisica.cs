using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15OOP
{

    class Pisica
    {
        private int foame = 50 ;
        private int fericire = 20;
        private int energie= 60 ;

        public int Foame { get { return foame; } }

        public int Fericire { get { return fericire; } }

        public int Energie { get { return energie; } }

        public void Hraneste()
        {
            foame = 5;
            energie += 10;
        }

        public void Joaca()
        {
            fericire += 10;

            if(fericire > 100)
            {
                fericire = 100;
            }
            energie -= 10;
        }

        public void Doarme()
        {
            energie = 99;
        }

        public void AfiseazaStarea()
        {
            Console.WriteLine($"Foame: {foame}");
            Console.WriteLine($"Fericire: {fericire}");
            Console.WriteLine($"Energie: {energie}");
        }
    }

}
