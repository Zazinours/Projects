using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S002_A003_8
{
    class Program
    {
        static void Main(string[] args)
        {
            moulinette();

        }

        static void permuteValeur1(string val1, string val2)
        {

            string val3;

            val3 = val2;
            val2 = val1;
            val1 = val3;
                        
        }
        static void permuteValeur2(ref string val1, ref string val2)
        {
            string val3;

            val3 = val2;
            val2 = val1;
            val1 = val3;

        }
        static void moulinette()
        {

            string valeur1;
            string valeur2;

            valeur1 = "aaaa";
            valeur2 = "bbbb";

            Console.WriteLine("Tentative de permutation par valeur");
            Console.WriteLine("valeur1 de depart : {0} | valeur2 de depart : {1}", valeur1, valeur2);
            
            permuteValeur1(valeur1, valeur2);

            Console.WriteLine("valeur1 permutée : {0} | valeur2 permutée : {1}",valeur1, valeur2);

            Console.WriteLine("");

            Console.WriteLine("Tentative de permutation par reférence");
            Console.WriteLine("valeur1 de depart : {0} | valeur2 de depart : {1}", valeur1, valeur2);

            permuteValeur2(ref valeur1, ref valeur2);

            Console.WriteLine("valeur1 permutée : {0} | valeur2 permutée : {1}", valeur1, valeur2);

            Console.WriteLine("");
            Console.WriteLine("La permutation par reférence à fonctionnée !");



            Console.ReadLine();
        }
    }
}
