using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Pisica pisica = new Pisica();
            pisica.AfiseazaStarea();

            pisica.Joaca();
            Console.WriteLine("Starea dupa joaca");
            pisica.AfiseazaStarea();



            Console.ReadKey();
        }
    }
}
