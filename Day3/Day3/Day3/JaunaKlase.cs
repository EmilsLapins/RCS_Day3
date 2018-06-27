using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class JaunaKlase
    {

        public int globals = 20;
        private int lokalsKlasei = 3;


        public int Saskaitit(int a, int b) // public, jo mes varesim pieklut sij funkcijai arpus klases
        {  
            int rezultats = a + b;
            // Teksts();
            Console.WriteLine(globals);
            globals = globals + 9;
            
            return rezultats;
            
        }

        private void Teksts()              // Sai funkcijai mes varam pieklut tikai no sis klases ^
        {
            Console.WriteLine("Debug teksts");
        }

    }
}
