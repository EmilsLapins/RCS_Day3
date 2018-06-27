using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Rinka linijas - apkartmers un laukums
            //

            Console.WriteLine("Ieraksti radiusu: ");
            string RadiusX = Console.ReadLine();
            double RadiusY = Convert.ToDouble(RadiusX);

            Rinkis rinkis1 = new Rinkis();
            double rezultats = rinkis1.Apkartmers1(RadiusY);
            Console.WriteLine(rezultats + " ir rinka apkartmers.");

            double rezultats2 = rinkis1.Laukums1(RadiusY);
            Console.WriteLine(rezultats2 + " ir rinka laukums.");



            string vards, uzvards; // deklarejam vairakus mainigos
            Console.WriteLine("Ludzu ievadiet savu vardu!");
            vards = Console.ReadLine();

            Console.WriteLine("Ludzu ievadiet savu uzvardu!");
            uzvards = Console.ReadLine();

            IzvaditSveicienu(vards, uzvards);

            /////// Diametrs un Laukums
            Console.WriteLine("! Diametra un laukuma apreikinasana !");

            Console.WriteLine("Ieraksti radiusu: ");
            string Radius1 = Console.ReadLine();
            double Radius2 = Convert.ToDouble(Radius1);

            double Diametrs1 = RinkaLinija(Radius2);
            Console.WriteLine(Diametrs1 + " ir diametrs");


            double Laukums1 = RinkaLinija2(Radius2);
            Console.WriteLine(Laukums1 + " ir laukums");

            /////// Degvielas paterins

            Console.WriteLine("! Degvielas paterina apreikinasanas programma !");
            Console.WriteLine("Ievadi degvielas paterinu /100 km! ");
            string DegPat = Console.ReadLine();
            double DegPat2 = Convert.ToDouble(DegPat);

            Console.WriteLine("Ievadi degvielas cenu Eur/litrs! ");
            string DegCena = Console.ReadLine();
            double DegCena2 = Convert.ToDouble(DegCena);

            Console.WriteLine("Ievadi planoto distanci!");
            string Distance = Console.ReadLine();
            double Distance2 = Convert.ToDouble(Distance);

            Degviela degviela1 = new Degviela();
            double KopaIznak = degviela1.DegvielasPaterins(DegPat2, DegCena2, Distance2);
            Console.WriteLine(KopaIznak + " Eur bus jasamaksa");


            /////////////

            //Radam objektu no klases
            Console.WriteLine("! Jauns objekts un klase !");
            JaunaKlase objekts1 = new JaunaKlase();  // izsaucam konstruktoru

            JaunaKlase objekts2 = new JaunaKlase();

            int Vetiba = objekts1.Saskaitit(8, 5);
            objekts1.globals = 100 + 5;

            Console.WriteLine(objekts1.globals);
            Console.WriteLine(objekts2.globals);
            ////////

            // Matematika, Jauna klase
            Console.WriteLine("! jauna klase, Matematika !");
            Matematika matematika1 = new Matematika();
            int GalaRezultats = matematika1.AtnemamSkaitlus(20, 5);
            int GalaRezultats2 = matematika1.SaskaitamSkaitlus(20, 5);

            Console.WriteLine(GalaRezultats + " atnemsana done ");
            Console.WriteLine(GalaRezultats2 + " saskaitisana done ");






            Console.ReadLine();

        }

        static void IzvaditSveicienu(string a, string b)
        {
            Console.WriteLine("Sveiki " + a + " " + b + ", prieks tevi redzet!");
        }

        static double RinkaLinija(double a)
        {


            double Diametrs = 2 * a;

            return Diametrs;

        }

        static double RinkaLinija2(double a)
        {
            double Pi = 3.14;

            double Laukums = 2 * Pi * a;
            return Laukums;
        }

        

    }
}
