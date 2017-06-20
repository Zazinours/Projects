using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S02_A005
{
    class Program
    {
        static void Main(string[] args)
        {
            //╔══════════════════════════════════════════════════════════════════╗
            //║                                                                  ║
            //║                     PROGRAMME DE TRI                             ║
            //║                         S02 A-005                                ║
            //║                   Sylvain FUENTES 2017                           ║
            //║                                                                  ║
            //╚══════════════════════════════════════════════════════════════════╝

            //Variables


            //Initialisation


            //Travaux

            depart();


        }
        static void depart()
        {
            //╔══════════════════════════════════════════════════════════════════╗
            //║                                                                  ║
            //║                       Départ du programme                        ║
            //║                                                                  ║
            //╚══════════════════════════════════════════════════════════════════╝

            //Variables

            string choixUtilisateur;

            //Initialisation

            choixUtilisateur = "";

            //Travaux

            dialogue();
            recuperationChoix(choixUtilisateur);

        }

        //╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗
        //║                                                                                                                                    ║
        //║                                                    TRAITEMENT DE L'INTERFACE                                                       ║
        //║                                                                                                                                    ║
        //╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝


        static void dialogue()
        {

            //╔══════════════════════════════════════════════════════════════════╗
            //║                                                                  ║
            //║                     Interface utilisateur                        ║
            //║                                                                  ║
            //╚══════════════════════════════════════════════════════════════════╝

            //Variables

            string choix;

            //Initialisation


            //Travaux

            effacerConsole();

            Console.WriteLine("╔══════════════════════════════════════════╗");
            Console.WriteLine("║       Exercies d'Algorithme tris         ║");
            Console.WriteLine("║──────────────────────────────────────────║");
            Console.WriteLine("║                                          ║");
            Console.WriteLine("║ Tapez B pour effecturer le tri Bulle     ║");
            Console.WriteLine("║ Tapez S pour effecturer le tri Sélection ║");
            Console.WriteLine("║                                          ║");
            Console.WriteLine("╚══════════════════════════════════════════╝");
            Console.WriteLine("");
            Console.WriteLine("  Tapez F pour sortir du programme");
            Console.WriteLine("");
            Console.WriteLine("  Votre choix ? ");

        }

        static void recuperationChoix(string choixUtilisateur)
        {

            //╔══════════════════════════════════════════════════════════════════╗
            //║                                                                  ║
            //║               Récupération des choix utilisateur                 ║
            //║                                                                  ║
            //╚══════════════════════════════════════════════════════════════════╝


            //Variables

            string recupChoix;

            //Initialisation

            recupChoix = "";

            //Travaux

            recupChoix = Console.ReadLine();
            choixUtilisateur = recupChoix;

            conformiteChoixUtilisateur(choixUtilisateur);

        }

        static void conformiteChoixUtilisateur(string choixUtilisateur)
        {
            //╔══════════════════════════════════════════════════════════════════╗
            //║                                                                  ║
            //║          Tests de conformité des choix utilisateurs              ║
            //║                                                                  ║
            //╚══════════════════════════════════════════════════════════════════╝

            //Variables

            string testConformiteChoix = choixUtilisateur.ToUpper();

            //Initialisation



            //Travaux

            choixUtilisateur = testConformiteChoix;

            traitementChoix(choixUtilisateur);

        }
        static void traitementChoix(string choixUtilisateur)
        {
            //╔══════════════════════════════════════════════════════════════════╗
            //║                                                                  ║
            //║               Traitement des choix utilisateur                   ║
            //║                                                                  ║
            //╚══════════════════════════════════════════════════════════════════╝

            //Variables

            string traitementChoix;

            //Initialisation

            traitementChoix = choixUtilisateur.ToUpper();

            //Travaux

            if (traitementChoix=="F")
            {
                effacerConsole();

                Console.WriteLine("Merci d'avoir utilisé cette application");

                attenteTouche();

                QuitterProgramme();

            }

            effacerConsole();
            int[] tab0 = creationTableau();
            affichageTableau(tab0);

            switch (traitementChoix)
            {
                case "B":

                    triBulle(tab0);

                    break;

                case "S":

                    triSelection(tab0);

                    break;

                /*case "F":

                    effacerConsole();

                    Console.WriteLine("Merci d'avoir utilisé cette application");

                    attenteTouche();

                    QuitterProgramme();

                    break;*/

                default:

                    depart();

                    break;
            }



        }

        static void QuitterProgramme()
        {
            //╔══════════════════════════════════════════════════════════════════╗
            //║                                                                  ║
            //║                      Quitter le programme                        ║
            //║                                                                  ║
            //╚══════════════════════════════════════════════════════════════════╝

            //Variables


            //Initialisation


            //Travaux

            Environment.Exit(0);

        }
        static void effacerConsole()
        {
            //╔══════════════════════════════════════════════════════════════════╗
            //║                                                                  ║
            //║                         Effacer console                          ║
            //║                                                                  ║
            //╚══════════════════════════════════════════════════════════════════╝

            //Variables


            //Initialisation


            //Travaux

            Console.Clear();

        }
        static void attenteTouche()
        {
            //╔══════════════════════════════════════════════════════════════════╗
            //║                                                                  ║
            //║                      Attente d'une touche                        ║
            //║                                                                  ║
            //╚══════════════════════════════════════════════════════════════════╝

            //Variables


            //Initialisation


            //Travaux

            Console.WriteLine("");
            Console.WriteLine("  Pressez une < TOUCHE > pour sortir");
            Console.ReadLine();
        }

        //╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗
        //║                                                                                                                                    ║
        //║                                                       TRAITEMENT DES TRIS                                                          ║
        //║                                                                                                                                    ║
        //╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝

        static void triBulle(int[] tab0)
        {
            //╔══════════════════════════════════════════════════════════════════╗
            //║                                                                  ║
            //║                          Tri bulle                               ║
            //║                                                                  ║
            //╚══════════════════════════════════════════════════════════════════╝

            //Variables

            int NBMAX;
            int gauche;
            int droite;
            int compteur;
            int tabTampon;
            int cycle;

            //Initialisation

            NBMAX = tab0.Length;
            compteur = 0;
            tabTampon = 0;
            cycle = 0;

            //Travaux

            //afficheHautTableau(tab0);

            while (compteur < NBMAX - 1)
            {

                gauche = tab0[compteur];
                droite = tab0[compteur + 1];

                if (gauche > droite)
                {

                    tabTampon = droite;
                    tab0[compteur + 1] = gauche;
                    tab0[compteur] = tabTampon;

                    if (compteur != 0)
                    {

                        compteur = --compteur;

                    }

                    affichageTableau(tab0);


                    cycle = ++cycle;
                }
                else
                {
                    compteur = ++compteur;
                    cycle = ++cycle;
                }
            }


            Console.WriteLine("");
            Console.WriteLine("Nombre de cycle : {0}", cycle);

            attenteTouche();
            depart();

        }
        static void triSelection(int[] tab0)
        {
            //╔══════════════════════════════════════════════════════════════════╗
            //║                                                                  ║
            //║                        Tri par sélection                         ║
            //║                                                                  ║
            //╚══════════════════════════════════════════════════════════════════╝

            //Variables

            int numCar;     //nb de valeur de tab0
            int index;      //Emplacement de la valeur à traiter
            int indexFin;   //Index de tabFin
            int valNum;     //Valeur à traiter
            int NbTabTri;   //Nb de valeur de tabTri
            int NbTabFin;   //Nb de valeur de tabFin
            int cycle;
            int j;

            //Initialisation

            indexFin = 0;
            index = 0;
            valNum = 0;
            NbTabTri = tab0.Length;
            NbTabFin = NbTabTri;
            numCar = NbTabTri;
            cycle = 0;
            j = 0;

            //Création de deux tableaux, un pour le tri et l'autre pour la construction du nouveau tableau

            int[] tabTri = new int[numCar];
            int[] tabFin = new int[numCar];

            //Travaux

            tabTri = (int[])tab0.Clone();

            for (int i = 0; i < numCar; i++)
            {
                // Détermine la plus petit valeur de tabTri

                valNum = tabTri.Min();

                for (int y = 0; y < NbTabTri; y++)
                {
                    if (tabTri[y] == valNum)
                    {
                        index = y + 1;
                        break;
                    }

                }

                tabFin[indexFin] = valNum;

                // Reforme le tableau tabTri

                j = index - 1;


                while (j < NbTabTri - 1)
                {

                    tabTri[j] = tabTri[j + 1];

                    j = ++j;
                    cycle = ++cycle;
                }


                tabTri[j] = 666;
                indexFin = ++indexFin;
                NbTabTri = --NbTabTri;

                affichageTableau(tabFin);

            }




            Console.WriteLine("Nombre de cycle : {0}", cycle);

            attenteTouche();
            depart();


        }

        //╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗
        //║                                                                                                                                    ║
        //║                                                      GESTION DES TABLEAUX                                                          ║
        //║                                                                                                                                    ║
        //╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝

        static int[] creationTableau()
        {
            //╔══════════════════════════════════════════════════════════════════╗
            //║                                                                  ║
            //║                      Création du tableau                         ║
            //║                                                                  ║
            //╚══════════════════════════════════════════════════════════════════╝

            //Variables

            int nbValeur;
            string questionNb;
            Random rnd = new Random();
            int valRnd;

            //Initialisation

            nbValeur = 10;
            questionNb = "";

            //Travaux

            Console.WriteLine("Nombre de données du tableau :");
            questionNb = Console.ReadLine();

            int.TryParse(questionNb, out nbValeur);

            int[] tabNew = new int[nbValeur];

            //Initialisation tableau

            for (int i = 0; i < nbValeur; i++)
            {

                valRnd = rnd.Next(0, 100);
                tabNew[i] = valRnd;

            }

            effacerConsole();

            return tabNew;

        }

        static void affichageTableau(int[] tab0)

        {
            //╔══════════════════════════════════════════════════════════════════╗
            //║                                                                  ║
            //║                      Afficher le tableau                         ║
            //║                                                                  ║
            //╚══════════════════════════════════════════════════════════════════╝

            //Variables

            int longTab;
            StringBuilder sb = new StringBuilder();

            string carPlus;

            //Initialisation

            longTab = tab0.Length;
            carPlus = "";


            // tableau

            sb.Append(" ");


            for (int i = 0; i < longTab; i++)
            {

                sb.Append(tab0[i] + " ");

            }



            Console.WriteLine("{0}", sb);


        }

    }
}

