﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExempluMostenire
{
    class Radio
    {

        public int Frecventa { get; private set; }

        public int Volum { get; private set; }

        protected string tehnologie;

        public Radio( string tip)
        {
            tehnologie = tip;
        }


        public void SeteazaVolum(int volum)
        {
            Volum = volum;
        }

        public void SeteazaFrecventa(int frecventa)
        {
            Frecventa = frecventa;
        }
    }
}
