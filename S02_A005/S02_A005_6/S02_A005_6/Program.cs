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

            Console.WriteLine("╔═════════════════════════════════════════════╗");
            Console.WriteLine("║       Exercies d'Algorithme de tris         ║");
            Console.WriteLine("║─────────────────────────────────────────────║");
            Console.WriteLine("║                                             ║");
            Console.WriteLine("║ Tapez B pour effecturer le tri Bulle        ║");
            Console.WriteLine("║ Tapez S pour effecturer le tri Sélection    ║");
            Console.WriteLine("║ Tapez P pour effecturer le tri Permutation  ║");
            Console.WriteLine("║ Tapez C pour effecturer le tri par Comptage ║");
            Console.WriteLine("║                                             ║");
            Console.WriteLine("╚═════════════════════════════════════════════╝");
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

            if (traitementChoix == "F")
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
                    depart();

                    break;

                case "S":

                    triSelection(ref tab0);
                    depart();

                    break;

                case "P":


                    triPermutation(tab0);
                    depart();

                    break;

                case "C":

                    triSelection(ref tab0);
                    triComptage(tab0);
                    depart();

                    break;

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

        static void affichageNbCycle(int cycle)
        {
            //╔══════════════════════════════════════════════════════════════════╗
            //║                                                                  ║
            //║                     Affichage des cycles                         ║
            //║                                                                  ║
            //╚══════════════════════════════════════════════════════════════════╝

            //Variables


            //Initialisation


            //Travaux

            Console.WriteLine("");
            Console.WriteLine("Nombre de cycle : {0}", cycle);

            attenteTouche();
            //depart();

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

            affichageNbCycle(cycle);

        }

        static void triSelection(ref int[] tab0)
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

                tab0 = (int[])tabFin.Clone();

                affichageTableau(tab0);

            }

            affichageNbCycle(cycle);


        }

        static void triPermutation(int[] tab0)
        {
            //╔══════════════════════════════════════════════════════════════════╗
            //║                                                                  ║
            //║                       Tri par permutations                       ║
            //║                                                                  ║
            //╚══════════════════════════════════════════════════════════════════╝


            //Variables

            int nbVal;
            int j;
            int tampon;
            int cycle;



            //Initialisation

            nbVal = tab0.Length;
            int[] tabPerm = new int[nbVal];
            tabPerm = (int[])tab0.Clone();
            j = 0;
            tampon = 0;
            cycle = 0;

            //Travaux

            //affichageTableau(tabPerm);

            while (j < nbVal - 1)
            {
                cycle = ++cycle;

                if (tabPerm[j] > tabPerm[j + 1])
                {
                    tampon = tabPerm[j + 1];
                    tabPerm[j + 1] = tabPerm[j];
                    tabPerm[j] = tampon;
                    affichageTableau(tabPerm);
                    j = -1;

                }

                j = ++j;


            }

            affichageNbCycle(cycle);

        }

        static void triComptage(int[] tab0)
        {
            //╔══════════════════════════════════════════════════════════════════╗
            //║                                                                  ║
            //║                         Tri par Comptage                         ║
            //║                                                                  ║
            //╚══════════════════════════════════════════════════════════════════╝


            //Variables

            int nbVal;
            int tampon;
            int cycle;
            int valCar;
            int nbCar;
            int index;
            int j;
            int pas;

            StringBuilder valDebut = new StringBuilder();
            StringBuilder valFin = new StringBuilder();

            //Initialisation des variables

            nbVal = tab0.Length;
            tampon = 0;
            valCar = 0;
            cycle = 0;
            nbCar = 0;
            index = 0;
            j = 0;
            pas = 0;



            //Travaux

            //effacerConsole();

            // Création des tables

            int[] tabComp = new int[nbVal];
            int[] tabFinal = new int[nbVal];
            int[] tabVal = new int[nbVal];

            tabComp = (int[])tab0.Clone();

            affichageTableau(tabComp);

            //attenteTouche();

            // Etape 2 : comptage

            while (index < nbVal - 1)

            {

                tampon = tabComp[index];

                /*while (tampon == tabComp[index + j])
                {
                    j = ++j;
                }*/


                while (tampon == tabComp[index + j])
                {

                    j = ++j;
                }



                tabVal[pas] = tampon;
                tabFinal[pas] = j;
                index = index + j;
                j = 0;
                pas = ++pas;



            }

            //Affiche les tables

            valDebut.Append("tabFinal" + "\t");
            valFin.Append("tabVal" + "\t\t");

            for (int i = 0; i < nbVal - 1; i++)
            {
                valDebut.Append(tabFinal[i] + "\t");
                valFin.Append(tabVal[i] + "\t");
            }

            Console.WriteLine("");
            Console.WriteLine("{0}", valDebut);
            Console.WriteLine("{0}", valFin);

            affichageNbCycle(cycle);
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

