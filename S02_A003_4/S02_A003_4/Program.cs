using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S02_A003_4
{
    class Program
    {
        static void Main(string[] args)
        {
            argumentValeur();
        }

        private static void argumentValeur()
        {
            int s = 3;
            Console.WriteLine("Valeur avant appel méthode modification valeur {0}", s);
            modifierValeur(s);
            Console.WriteLine("Valeur après appel methode modification valeur {0}", s);
            Console.WriteLine("");
            Console.WriteLine("la valeur s n'a subi aucune modification");

            Console.ReadLine();

        }
        private static void modifierValeur(int o)
        {

            o = 4;
        }
    }
}
