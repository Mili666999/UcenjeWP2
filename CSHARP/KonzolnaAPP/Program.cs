

using KonzolnaAPP.Model;

namespace KonzolnaAPP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new Program();
        }


        private List<Djelatnik> Djelatnici;
        private List<Dokument> Dokumenti;


        public Program()
        {
            Dokumenti = new List<Dokument>();
            Djelatnici = new List<Djelatnik>();
            PozdravnaPoruka();
            Izbornik();

        }


        private void PozdravnaPoruka()
        {
            Console.WriteLine("*******************");
            Console.WriteLine("*DJELATNICI APP V1*");
            Console.WriteLine("*******************");
        }

        //Glavni izbornik ******************************************
        private void Izbornik()
        {
            Console.WriteLine();
            Console.WriteLine("***IZBORNIK***");
            Console.WriteLine();
            Console.WriteLine("1. Djelatnici");
            Console.WriteLine("2. Dokumenti");
            Console.WriteLine("3. Fotografije");
            Console.WriteLine("4. IZLAZ iz programa");
            OdabirStavkePocetnogIzbornika();
        }

        private void OdabirStavkePocetnogIzbornika()
        {
            switch (Pomocno.UcitajInt("Unesi stavku izbornika: "))
            {
                case 1:
                    Console.WriteLine("Rad s djelatnicima");
                    IzbornikRadSDjelatnicima();
                    break;
                case 2:
                    Console.WriteLine("Rad s dokumentima");
                    IzbornikRadSDokumentima();
                    break;
                case 3:
                    Console.WriteLine("Rad s fotografijama");
                    IzbornikRadSFotografijama();
                    break;
                case 4:
                    Console.WriteLine("Izlaz iz programa");
                    break;
                default:
                    Console.WriteLine("Krivi odabir");
                    Izbornik();
                    break;
            }
        }

        //Djelatnici **********************************************
        private void IzbornikRadSDjelatnicima()
        {
            Console.WriteLine();
            Console.WriteLine("***DJELATNICI***");
            Console.WriteLine();
            Console.WriteLine("1. Prikaži sve djelatnike");
            Console.WriteLine("2. Dodaj djelatnika");
            Console.WriteLine("3. Uredi djelatnika");
            Console.WriteLine("4. Izbriši djelatnika");
            Console.WriteLine("5. Povratak na glavni izbornik");
            OdabirStavkeIzbornikDjelatnika();
        }

        private void OdabirStavkeIzbornikDjelatnika()
        {
            switch (Pomocno.UcitajInt("Odaberi stavku izbornika: "))
            {
                case 1:
                    Console.WriteLine("Prikaži sve djelatnike");
                    PrikaziSveDjelatnike();
                    break;
                case 2:
                    Console.WriteLine("Dodaj djelatnika");
                    DodajDjelatnika();
                    break;
                case 3:
                    Console.WriteLine("Uredi djelatnika");
                    UrediDjelatnika();
                    break;
                case 4:
                    Console.WriteLine("Izbriši djelatnika");
                    IzbrisiDjelatnika();
                    break;
                case 5:
                    Izbornik();
                    break;
                default:
                    Console.WriteLine("Krivi odabir");
                    OdabirStavkeIzbornikDjelatnika();
                    break;
            }
        }

        private void PrikaziSveDjelatnike()
        {
            var i = 0;
            Djelatnici.ForEach(dj => {
                Console.WriteLine(++i + ". " + dj);
            });
            Console.WriteLine("**********************");
            IzbornikRadSDjelatnicima();
        }

        private void DodajDjelatnika()
        {
            Djelatnici.Add(new Djelatnik()
            {
                Id = Pomocno.UcitajInt("Unesi šifru djelatnika: "),
                Ime = Pomocno.UcitajString("Unesi ime djelatnika: "),
                Prezime = Pomocno.UcitajString("Unesi prezime djelatnika: "),
                Kontakt = Pomocno.UcitajString("Unesi kontakt djelatnika: "),
                Oib = Pomocno.UcitajString("Unesi OIB djelatnika: "),
                Iban = Pomocno.UcitajString("Unesi IBAN djelatnika: ")
            });
            IzbornikRadSDjelatnicima();
        }

        private void UrediDjelatnika()
        {
            PrikaziSveDjelatnike();
            var dj = Djelatnici[Pomocno.UcitajInt("Odaberi djelatnika za promjenu: ")-1];
            dj.Id = Pomocno.UcitajInt(dj.Id + ", Unesi novu šifru: ");
            dj.Ime = Pomocno.UcitajString(dj.Ime + ", Unesi novo ime: ");
            dj.Prezime = Pomocno.UcitajString(dj.Prezime + ", Unesi novo prezime: ");
            dj.Kontakt = Pomocno.UcitajString(dj.Kontakt + ", Unesi novi kontakt: ");
            dj.Oib = Pomocno.UcitajString(dj.Oib + ", Unesi novi OIB: ");
            dj.Iban = Pomocno.UcitajString(dj.Iban + ", Unesi novi IBAN: ");
            IzbornikRadSDjelatnicima();
        }

        private void IzbrisiDjelatnika()
        {
            PrikaziSveDjelatnike();
            Djelatnici.RemoveAt(Pomocno.UcitajInt("Unesi djelatnika za brisanje: ")-1);
            IzbornikRadSDjelatnicima();
        }

        //Dokumenti ***********************************************
        private void IzbornikRadSDokumentima()
        {
            Console.WriteLine();
            Console.WriteLine("***DOKUMENTI***");
            Console.WriteLine();
            Console.WriteLine("1. Prikaži sve dokumente");
            Console.WriteLine("2. Dodaj dokument");
            Console.WriteLine("3. Uredi dokument");
            Console.WriteLine("4. Izbriši dokument");
            Console.WriteLine("5. Povratak na glavni izbornik");
            OdabirStavkeIzbornikDokumenta();
        }

        private void OdabirStavkeIzbornikDokumenta()
        {
            switch (Pomocno.UcitajInt("Odaberi stavku izbornika: "))
            {
                case 1:
                    Console.WriteLine("Prikaži sve dokumente");
                    PrikaziSveDokumente();
                    break;
                case 2:
                    Console.WriteLine("Dodaj dokument");
                    DodajDokument();
                    break;
                case 3:
                    Console.WriteLine("Uredi dokument");
                    UrediDokument();
                    break;
                case 4:
                    Console.WriteLine("Izbriši dokument");
                    IzbrisiDokument();
                    break;
                case 5:
                    Izbornik();
                    break;
                default:
                    Console.WriteLine("Krivi odabir");
                    OdabirStavkeIzbornikDokumenta();
                    break;
            }
        }

        private void PrikaziSveDokumente()
        {
            var i = 0;
            Dokumenti.ForEach(dok => {
                Console.WriteLine(++i + ". " + dok);
            });
            Console.WriteLine("**********************");
            IzbornikRadSDokumentima();
        }

        private void DodajDokument()
        {
            Dokumenti.Add(new Dokument()
            {
                Id = Pomocno.UcitajInt("Unesi šifru dokumenta: "),
                Naziv = Pomocno.UcitajString("Unesi ime dokumenta: "),                
            });
            IzbornikRadSDokumentima();
        }

        private void UrediDokument()
        {
            PrikaziSveDokumente();
            var dok = Dokumenti[Pomocno.UcitajInt("Odaberi dokumnt za promjenu: ") - 1];
            dok.Id = Pomocno.UcitajInt(dok.Id + ", Unesi novu šifru: ");
            dok.Naziv = Pomocno.UcitajString(dok.Naziv + ", Unesi novi naziv: ");
            IzbornikRadSDokumentima(); ;
        }

        private void IzbrisiDokument()
        {
            PrikaziSveDokumente();
            Dokumenti.RemoveAt(Pomocno.UcitajInt("Unesi dokument za brisanje: ") - 1);
            IzbornikRadSDokumentima();
        }


        //Fotografije *********************************************
        private void IzbornikRadSFotografijama()
        {
            Console.WriteLine();
            Console.WriteLine("***FOTOGRAFIJE***");
            Console.WriteLine();
            Console.WriteLine("1. Prikaži sve fotografije");
            Console.WriteLine("2. Dodaj fotografiju");
            Console.WriteLine("3. Uredi fotografiju");
            Console.WriteLine("4. Izbriši fotografiju");
            Console.WriteLine("5. Povratak na glavni izbornik");
            OdabirStavkeIzbornikFotografija();
        }

        private void OdabirStavkeIzbornikFotografija()
        {
            throw new NotImplementedException();
        }
    }
}
