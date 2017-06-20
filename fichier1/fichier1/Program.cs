using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace fichier1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Variables

            string mot1;
            string mot2;
            string mot3;
            string nomFichier;

            //Initialisations

            mot1 = "";
            mot2 = "";
            mot3 = "";
            nomFichier = "C:\\Users\\CDI\\OneDrive\\Visual Studio 2015\\Projects\\fichier1\\essais.txt";

            Console.WriteLine("Premier mot :");
            mot1 = Console.ReadLine();

            Console.WriteLine("Deuxieme mot :");
            mot2 = Console.ReadLine();

            Console.WriteLine("troisieme mot :");
            mot3 = Console.ReadLine();

            //sauvegarde

            Ecrire(mot1, mot2, mot3, nomFichier);

            Lire(nomFichier);

        }

        static void Ecrire(string mot1, string mot2, string mot3, string nomFichier)
        {

            if (!File.Exists(nomFichier))
            //throw new FileNotFoundException("Le fichier {0} n'existe pas", nomFichier);
            {
                FileStream fs = new FileStream(nomFichier, FileMode.OpenOrCreate);
            }

            string texte = mot1 + "," + mot2 + "," + mot3;

            //using (StreamWriter sw = new StreamWriter(nomFichier))
            {

                System.IO.StreamWriter file = new System.IO.StreamWriter(nomFichier);

                file.WriteLine(texte);

                file.Close();


            }

        }

        static void Lire(string nomFichier)
        {
            string texte;

            System.IO.StreamReader file = new System.IO.StreamReader(nomFichier);

            texte = file.ReadLine();

            file.Close();

            Afficher(texte);

        }
        static void Afficher(string texte)

        {
            Console.WriteLine(texte);
            Console.ReadLine();

        }
    }



}
