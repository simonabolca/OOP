using FermaAnimalelor.Infrastructura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FermaAnimalelor
{
    abstract class Animal:Object
    {
        public bool AnimalHranit { get; private set; }

        public bool AnimalAdormit { get; private set; }

        public abstract string Rasa { get; }

        public abstract IHrana[] HranaPreferata { get;  }

        public abstract string  NumarDePicioare { get;}

       
        public bool AnimalIntratInAdapost { get; private set; }


        public void Mananca(IHrana hrana)
        {
            foreach (var mancare in HranaPreferata)
            {
                if (hrana.Denumire == mancare.Denumire)
                {
                    AnimalHranit = true;
                }
            }
           
        }

        public void Doarme()
        {
            if (AnimalHranit)
            {
                AnimalAdormit = true;
            }
           
        }

        public void IntraInAdapost()
        {
            if(AnimalHranit && AnimalAdormit)
            {
                AnimalIntratInAdapost = true;
            }
        }

        public abstract IResursa ColecteazaResurse();
    }
}
