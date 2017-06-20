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
            int valTab;

            Console.WriteLine("Valeur avant appel méthode modification valeur {0}", tabS[0]);
            Console.WriteLine("");

            modifierTabValeur(ref tabS);
            Console.WriteLine("modifierTabValeur");
            Console.WriteLine("Valeur après appel méthode modification valeur {0}", tabS[0]);
            Console.WriteLine("");
            Console.WriteLine("La valeur de tabS[0] a été modifier de 1 à 8");
            Console.WriteLine("");

            modifierTabValeur2(ref tabS);
            Console.WriteLine("modifierTabValeur2");
            Console.WriteLine("Valeur après appel méthode modification valeur {0}", tabS[0]);
            Console.WriteLine("");
            Console.WriteLine("La valeur de tabS[0] a été modifier de 1 à 9");
            Console.WriteLine("");

            for (int i = 0; i < 2; i++)
            {

                valTab = tabS[i];
                Console.WriteLine("Valeur de tabS[{0}] {1}", i,valTab);

            }

            Console.WriteLine("");
            Console.WriteLine("Ls valeurs de tabS ont été modifiés par l'usage de la reférence");
            Console.WriteLine("");

            Console.ReadLine();

        }

        private static void modifierTabValeur(ref int[] tabO)
        {

            tabO[0] = 8;
        }
        private static void modifierTabValeur2(ref int[] tabO)
        {
            tabO[0] = 8;
            tabO = new int[] { 9, 10, 11 };
        }
    }
}