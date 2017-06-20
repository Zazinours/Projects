using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S02_A001_1_2
{
    class Program
    {
        static void Main(string[] args)
        {


            afficheValeurs(demandeValeurs());


        }


        static int demandeValeurs()

        {
            string val1;
            int valeur;

            Console.WriteLine("Valeur ? ");
            val1 = Console.ReadLine();
            int.TryParse(val1, out valeur);

            
            return valeur;


        }

        static void afficheValeurs(int valeur)

        {
            String touche;
            int a = valeur;
            int somme;
            touche = "O";
            somme = 0;

            do
            {

                
                Console.WriteLine("Une autre valeure (O/N) ? ");
                touche=(Console.ReadLine());


                if (touche == "O")
                {
                    demandeValeurs();
                    somme = somme + valeur;
                    valeur = 0;
                }
                
            } while (touche == "O");

            somme = somme + valeur;

            Console.WriteLine("la somme des valeurs est ");
            Console.WriteLine(somme);
            Console.WriteLine(Console.ReadLine());
        }

    }

}
