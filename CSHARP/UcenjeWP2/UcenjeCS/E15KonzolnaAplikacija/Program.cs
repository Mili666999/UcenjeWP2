using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E15KonzolnaAplikacija
{
    internal class Program
    {
        public Program()
        {
            PozdravnaPoruka();
            Izbornik();
        }

        private void Izbornik()
        {
            Console.WriteLine("Izbornik");
            Console.WriteLine("1. rad s Smjerovima");
            Console.WriteLine("2. rad s Predavačima");
            Console.WriteLine("3. rad s Polaznicima");
            Console.WriteLine("4. rad s Grupama");
            Console.WriteLine("5. Izlaz iz programa");
            var Izbor = Pomocno.UcitajString("Unesite vaš izbor: ");
        }

        private void PozdravnaPoruka()
        {
            Console.WriteLine("***************************");
            Console.WriteLine("* EDUNOVA KONZOLNA APP V1 *");
            Console.WriteLine("***************************");
        }
    }
}
