using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S002_A003_6
{
    class Program
    {
        static void Main(string[] args)
        {
            argumentValeur();
        }

        private static void argumentValeur()
        {
            int[] tabS = new int[3] { 1, 4, 6 };

            Console.WriteLine("Valeur avant appel méthode modification valeur {0}", tabS[0]);
            modifierTabValeur(tabS);
            Console.WriteLine("Valeur après appel méthode modification valeur {0}", tabS[0]);
            Console.WriteLine("");
            Console.WriteLine("La valeur de tabS[0] a été modifier de 1 à 8");
            Console.ReadLine();

        }

        private static void modifierTabValeur(int[] tabO)
        {

            tabO[0] = 8;
        }
    }
}
