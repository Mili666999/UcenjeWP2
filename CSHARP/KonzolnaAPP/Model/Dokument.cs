﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonzolnaAPP.Model
{
    internal class Dokument:Entitet
    {
        public string Naziv { get; set; }
        //public string Lokacija { get; set; }
        public Djelatnik Djelatnik { get; set; }

        public override string ToString()
        {
            return Naziv + " - " + Djelatnik;
        }
    }
}
