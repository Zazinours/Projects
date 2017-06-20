using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S02_A003_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables

            
            string saisie;

            //Saisie d'une valeure

            Console.WriteLine("Saisissez une valeur entière : ");
            saisie=Console.ReadLine();

            //Appel de la fonction Convertions

            Conversions(saisie);

                }


        static void Conversions(string saisie)

        {
            int a;
            int a2;
            short b;
            long c;
                        
            // string saisie -> int a

            int.TryParse(saisie, out a);
            Console.WriteLine("La variable saisie est convertit en entier dans a ({0})",a);

            //Int a -> short b

            a2 = a;
            a2 = ++a2;
            b = Convert.ToInt16(a2);
            //b = (short)a;
            Console.WriteLine("La variable a est post incrémenter de 1 puis convertit (explicite) en short dans b ({0})",b);

            //int a -> long c

            a2 = a;
            a2 = --a2;
            c = (long)a2;
            Console.WriteLine("La variable a est pré incrémenter de 1 puis convertit (explicite) en entier long dans c ({0})", c);
            Console.ReadLine();
                        
        }

    }
}
