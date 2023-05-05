using System.Diagnostics;
using System.Reflection.Metadata;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kontakt marko = new Kontakt("marko","fratucan","3456134");
            marko.DodajBroj("142442");
            Console.WriteLine(marko);
            marko.DodajBroj("142442");
            Console.WriteLine(marko);
            marko.DodajBroj("345376");
            marko.DodajBroj("978645");
            Console.WriteLine(marko);

            Kontakt pera = new Kontakt("petar", "padejski", "6956721");
            pera.DodajBroj("9726562");
            Console.WriteLine(pera);

            Adresar a = new Adresar();
            a.Dodaj(marko);
            a.Dodaj(pera);
            string shareFajl = @"D:\DOCUNENTS\0\Documents\Visual Studio 2022\Projekti\ConsoleApp12\bin\Debug\net6.0\fajl1.txt";
            a.Share(shareFajl, "3456134");

            string shareFajl1 = @"D:\DOCUNENTS\0\Documents\Visual Studio 2022\Projekti\ConsoleApp12\bin\Debug\net6.0\fajl1.txt";
            a.Share(shareFajl1, "00000");

            string backupFajl = @"D:\DOCUNENTS\0\Documents\Visual Studio 2022\Projekti\ConsoleApp12\bin\Debug\net6.0\fajl2.txt";
            a.Backup(backupFajl);

            string receiveFajl = @"D:\DOCUNENTS\0\Documents\Visual Studio 2022\Projekti\ConsoleApp12\bin\Debug\net6.0\fajl3.txt";
            a.Receive(receiveFajl);

        }
    }
}