using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FermaAnimalelor
{
    interface IAdapost
    {
        int Capacitate { get; set; }

        int NumardeAnimale { get; set; }

        void AdaugaAnimalInAdapost();

        //void AdaugaAnimalInAdapost();

    }
}
