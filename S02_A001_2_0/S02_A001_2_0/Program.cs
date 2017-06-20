using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S02_A001_2_0
{
    class Program
    {
        static void Main(string[] args)
        {

            //Variables

            int nbCarTexte;
            int nbCarDroite;
            string stg;
            string gauche;
            string droite;

            //Moulinette

            gauche = " ";
            droite = " ";

            //valChar = ' '; 
            

            stg = demandeTexte();

            Console.WriteLine("Le texte a comparer est {0} ", stg);
            //Console.WriteLine(Console.ReadLine());



            // formatage de la chaine

            stg = convertirChaineSansAccent(stg);
            stg = formatageTexte(stg);
            nbCarTexte = stg.Length;

            // Prendre à gauche

            for (int i = 0; i < (nbCarTexte / 2); i++)

            {

                gauche = gauche + stg[i];

            }

            gauche = gauche.Replace(" ", "");

            //prendre la droite

            if (nbCarTexte % 2 != 0)
            {
                nbCarDroite = (nbCarTexte / 2)+1 ;
            }
            else
            {
                nbCarDroite = (nbCarTexte / 2);
            }

            for (int i = nbCarTexte; i > nbCarDroite; i--)

            {
                droite = droite + stg[i - 1];
            }

            droite = droite.Replace(" ", "");

            Console.WriteLine("{0} {1} {2}", gauche, droite, stg);

            comparaison(gauche, droite, stg);


            // ******************** FONCTIONS

        }
        static string demandeTexte()
        {

            string texte;

            // demande le texte

            Console.WriteLine("Entrée votre texte :");
            texte = Console.ReadLine();

            //

            return texte;

        }
        static string convertirChaineSansAccent(string stg)
        {
            string cara;

            cara = stg;

            // Déclaration de variables

            string accent = "ÀÁÂÃÄÅàáâãäåÒÓÔÕÖØòóôõöøÈÉÊËèéêëÌÍÎÏìíîïÙÚÛÜùúûüÿÑñÇç";
            string sansAccent = "AAAAAAaaaaaaOOOOOOooooooEEEEeeeeIIIIiiiiUUUUuuuuyNnCc";

            // Conversion des chaines en tableaux de caractères
            char[] tableauSansAccent = sansAccent.ToCharArray();
            char[] tableauAccent = accent.ToCharArray();

            // Pour chaque accent
            for (int i = 0; i < accent.Length; i++)
            {
                // Remplacement de l'accent par son équivalent sans accent dans la chaîne de caractères
                cara = cara.Replace(tableauAccent[i].ToString(), tableauSansAccent[i].ToString());
            }

            // Retour du résultat

            //Console.WriteLine("{0}", cara);

            return cara;
        }
        static string formatageTexte(string stg)
        {
            string texte;
            texte = stg;

            stg = stg.ToUpper();
            stg = stg.Replace(" ", "");
            stg = convertirChaineSansAccent(stg);
            return texte;
        }
        static void comparaison(string gauche, string droite, string stg)
        {
            Console.WriteLine("{0} {1} {2}", gauche, droite, stg);

            bool equal = gauche == droite;

            if (equal == true)
            {
                Console.WriteLine("{0} est un palindrome !", stg);
            }
            else
            {
                Console.WriteLine("{0} n'est pas un palindrome !", stg);
            }

            Console.ReadLine();
        }


    }



}

