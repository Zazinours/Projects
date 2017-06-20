using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonPremierProjet
{
    class Program
    {

        static string Resultat="Prout";
        static void Main(string[] args)
        {
            int entier;
            char caractere;

            string chaineAcquise;
            Console.WriteLine("Bonjour les CDI {0} de {1}", "2017", "Brive");
            Console.WriteLine(Console.ReadLine());
            chaineAcquise = AcquerirChaine();

            if (chaineAcquise == string.Empty)
            {
                Console.WriteLine("Chaine vide");
            }

            else
            {
                Console.WriteLine();
            }
            Console.WriteLine(Console.ReadLine());
        }

        static string AcquerirChaine()
        {
            string maPhrase;
            Console.WriteLine("Merci de communiquer une phrase");
            maPhrase = Console.ReadLine();
            return maPhrase;

        }
    }
}
