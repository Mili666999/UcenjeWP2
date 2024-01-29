using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcenjeCS.E15KonzolnaAplikacija.Model;

namespace UcenjeCS.E15KonzolnaAplikacija
{
    internal class Program
    {
        private List<Smjer> Smjerovi;


        public Program()
        {
            Smjerovi = new List<Smjer>();
            PozdravnaPoruka();
            Izbornik();
        }


        private void PozdravnaPoruka()
        {
            Console.WriteLine("***************************");
            Console.WriteLine("* EDUNOVA KONZOLNA APP V1 *");
            Console.WriteLine("***************************");
        }


        private void Izbornik()
        {
            Console.WriteLine();
            Console.WriteLine("*Izbornik*");
            Console.WriteLine("1. rad sa Smjerovima");
            Console.WriteLine("2. rad s Predavačima");
            Console.WriteLine("3. rad s Polaznicima");
            Console.WriteLine("4. rad s Grupama");
            Console.WriteLine("5. IZLAZ iz programa");
            Console.WriteLine();
            OdabirStavkePocetnogIzbornika();

        }


        private void OdabirStavkePocetnogIzbornika()
        {

            switch (Pomocno.UcitajInt("Unesite vaš izbor: "))
            {
                case 1:
                    Console.WriteLine("*Rad sa SMJEROVIMA*");
                    IzbornikRadSaSmjerovima();
                    break;
                case 2:
                    Console.WriteLine("*Rad s PREDAVAČIMA*");
                    break;
                case 3:
                    Console.WriteLine("*Rad s POLAZNICIMA*");
                    break;
                case 4:
                    Console.WriteLine("*Rad s GRUPAMA*");
                    break;
                case 5:
                    Console.WriteLine("*IZLAZ iz programa*");
                    break;
                default:
                    Console.WriteLine("Krivi odabir");
                    Izbornik();
                    break;
            }
        }

        private void IzbornikRadSaSmjerovima()
        {
            Console.WriteLine();
            Console.WriteLine("1. PRIKAŽI sve smjerove");
            Console.WriteLine("2. DODAJ smjer");
            Console.WriteLine("3. UREDI smjer");
            Console.WriteLine("4. OBRIŠI smjer");
            Console.WriteLine("5. povratak na GLAVNI izbornik");
            Console.WriteLine();
            OdabirStavkeIzbornikSmjera();

        }


        private void OdabirStavkeIzbornikSmjera()
        {
            switch (Pomocno.UcitajInt("Odaberi stavku izbornika: "))
            {
                case 1:
                    Console.WriteLine("Prikaži sve smjerove");
                    PrikaziSmjerove();
                    IzbornikRadSaSmjerovima();
                    break;
                case 2:
                    Console.WriteLine("Dodaj smjer");
                    DodajSmjer();
                    break;
                case 3:
                    Console.WriteLine("Uredi smjer");
                    UrediSmjer();
                    break;
                case 4:
                    Console.WriteLine("Izbriši smjer");
                    IzbrisiSmjer();
                    break;
                case 5:
                    Izbornik();
                    break;
                default:
                    IzbornikRadSaSmjerovima();
                    break;

            }
        }


        private void IzbrisiSmjer()
        {
            PrikaziSmjerove();
            Smjerovi.RemoveAt(Pomocno.UcitajInt("Odaberi smjer za brisanje: ")-1);
            IzbornikRadSaSmjerovima();
        }


        private void UrediSmjer()
        {
            PrikaziSmjerove();
            var s = Smjerovi[Pomocno.UcitajInt("Odaberi smjer za promjenu: ")-1];
            s.Sifra = Pomocno.UcitajInt(s.Sifra + ", Unesi novu šifru: ");
            s.Naziv = Pomocno.UcitajString(s.Naziv + ", Unesi novi naziv: ");
            //Promjeniti ostale vrijednosti
            IzbornikRadSaSmjerovima();
        }


        private void PrikaziSmjerove()
        {
            var i = 0;
            Smjerovi.ForEach(s => 
            {
                Console.WriteLine(++i + ". " + s);
            });
            
        }


        private void DodajSmjer()
        {
            Smjerovi.Add(new Smjer()
            {
                Sifra = Pomocno.UcitajInt("Unesi šifru smjera: "),
                Naziv = Pomocno.UcitajString("Unesi naziv smjera: "),
                //Učitati ostale vrijednosti
                
            });
            IzbornikRadSaSmjerovima();

        }





    }
}
