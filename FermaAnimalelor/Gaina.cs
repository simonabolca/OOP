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
    class Gaina : Animal
    {
        public override string Rasa => "gaina";

        public override string NumarDePicioare => "2";

        public override IHrana[] HranaPreferata => new IHrana[] { new Cereale() };

        public override IResursa ColecteazaResurse()
        {
            return new Oua();
        }
    }
}
