using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExempluMostenire
{
    class Casetofon : Radio

    {

        private int volumInitial;

        public Casetofon(string tip, int volumInitial) : base(tip)
        {
            
            this.volumInitial = volumInitial;
            
        }



        public void PlayCaseta( string numeCaseta)
        {
            
            Console.WriteLine($"Acum se aude :{numeCaseta}");
        }

        public void Stop()
        {
            Console.WriteLine("Caseta s-a oprit");
        }
    }
}
