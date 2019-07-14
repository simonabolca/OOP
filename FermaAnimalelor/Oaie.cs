using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FermaAnimalelor.Hrana;
using FermaAnimalelor.Infrastructura;
using FermaAnimalelor.Resurse;

namespace FermaAnimalelor
{
    class Oaie : Animal
    {
        public override string Rasa => "oaie";

        public override string NumarDePicioare => "4";

        public override IHrana[] HranaPreferata => new IHrana[] { new Fan() };

        public override IResursa ColecteazaResurse()
        {
            return new Lapte();
        }
    }
}
