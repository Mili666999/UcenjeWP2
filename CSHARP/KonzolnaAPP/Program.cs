

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


        public Program()
        {
            Djelatnici = new List<Djelatnik>();
            PozdravnaPoruka();
            Izbornik();

        }

        private void Izbornik()
        {
            Console.WriteLine();
            Console.WriteLine("***IZBORNIK***");
            Console.WriteLine();
            Console.WriteLine("1. Djelatnici");
            Console.WriteLine("2. Dokumenti");
            Console.WriteLine("3. Fotografije");
            OdabirStavkePocetnogIzbornika();
        }

        private void OdabirStavkePocetnogIzbornika()
        {
            switch (Pomocno.UcitajInt("Unesi izbor: "))
            {
                case 1:
                    Console.WriteLine("Rad s djelatnicima");
                    break;
                case 2:
                    Console.WriteLine("Rad s dokumentima");
                    break;
                case 3:
                    Console.WriteLine("Rad s fotografijama");
                    break;
            }
        }


        private void PozdravnaPoruka()
        {
            Console.WriteLine("*******************");
            Console.WriteLine("*DJELATNICI APP V1*");
            Console.WriteLine("*******************");
        }
    }
}
