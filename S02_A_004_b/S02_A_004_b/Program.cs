using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S02_A_004
{
    class Program
    {
        static void Main(string[] args)
        {
            //*******************************************************************
            //*                             MAIN                                *
            //*******************************************************************

            //Variables

            int etatMarital;
            int nbMioches;
            int salaire;
            double taux;

            // Initialisation variables

            etatMarital = 1;
            nbMioches = 0;
            salaire = 0;
            taux = 0;

            //saisie datas

            saisieInformationsMarital(etatMarital);
            saisieNbEnfants(nbMioches);
            saisieSalaire(salaire);

            //calule des taux

            definitionTaux(etatMarital, nbMioches, taux, salaire);

            //Affichage du resultat

            affichageTaux( taux);

            Console.WriteLine("{0}", nbMioches);

            Console.ReadLine();

        }

        static void saisieInformationsMarital(int etatMarital)
        {
            //*******************************************************************
            //*              Saisie des informations mariatal                   *
            //*******************************************************************

            string marital1;
            int marital;
            bool choixMarital;
            int choixBool;

            do
            {

                Console.WriteLine("Etat maritale de l'employé(e) :");
                Console.WriteLine("");
                Console.WriteLine("         Tapez \'1\' pour célibataire");
                Console.WriteLine("         Tapez \'2\' pour marié(e)");
                Console.WriteLine("         Tapez \'3\' pour veuf(ve)");
                Console.WriteLine("         Tapez \'4\' pour quitter");
                Console.WriteLine("");
                Console.WriteLine("Votre choix (1,2,3 ou 4) ? ");
                marital1 = Console.ReadLine();

                int.TryParse(marital1, out marital);
                choixBool = marital;
                choixMarital = verifierSaisieMarital(choixBool);

                if (!choixMarital)
                {
                    recommence();
                }


                Console.Clear();

                if (choixBool == 4)
                {
                    sortie();
                }

            } while (!choixMarital);

            etatMarital = marital;

        }
        private static void saisieNbEnfants( int nbMioche)
        {
            //*******************************************************************
            //*                  Saisie du nombre d'enfants                     *
            //*******************************************************************

            string nbEnfants;
            int numMioches;
            bool choixEnfants;
            int choixBool;

            numMioches = 0;

            do
            {


                Console.WriteLine("Combiens d'enfants à cet(te) employé(e) (Max 10) ?");
                nbEnfants = Console.ReadLine();

                int.TryParse(nbEnfants, out numMioches);

                choixBool = numMioches;
                choixEnfants = verifierSaisieNbEnfants(choixBool);

                if (!choixEnfants)

                {
                    recommence();
                }


            } while (!choixEnfants);

            Console.Clear();

            nbMioche = numMioches;


        }




        private static void definitionTaux( int etatMarital,  int nbMioches,  double taux,  int salaire)
        {
            //*******************************************************************
            //*                     Définition du taux                          *
            //*******************************************************************

            double tauxMarital;
            double majEnfants;
            int PLAFOND;

            tauxMarital = 0;
            majEnfants = 0;
            PLAFOND = 1800;

            //calcule du taux marital

            switch (etatMarital)
            {
                case 1:

                    tauxMarital = 0.2;
                    break;

                case 2:
                    tauxMarital = 0.25;
                    break;

                case 3:
                    tauxMarital = 0.25;
                    break;


            }

            //taux pas nb d'enfants

            majEnfants = nbMioches * 0.1;


            //taux final

            taux = majEnfants + tauxMarital;

            //Majoration plafond

            if (salaire < PLAFOND)
            {
                taux = taux + 0.1;
            }

            if (taux > 0.5)
            {
                taux = 0.5;
            }


        }

        private static void affichageTaux( double taux)
        {
            //*******************************************************************
            //*                      Affichage du taux                          *
            //*******************************************************************

            Console.Clear();
            Console.WriteLine("Le taux est {0}", taux);
            Console.ReadLine();
            sortie();
        }
        private static bool verifierSaisieMarital(int choixBool)
        {
            //*******************************************************************
            //*                 Vérifier la saisie maritale                     *
            //*******************************************************************

            return (choixBool > 0 & choixBool < 5);
        }
        private static bool verifierSaisieNbEnfants(int choixBool)
        {
            //*******************************************************************
            //*            Vérifier la saisie du nombre d'enfants               *
            //*******************************************************************

            return (choixBool > 0 & choixBool < 11);
        }
        private static void recommence()
        {
            //*******************************************************************
            //*                         Recommance                              *
            //*******************************************************************

            Console.WriteLine("Votre saise est incorrecte, veuillez recommencer svp en pressent une touche");
            Console.ReadLine();
            Console.Clear();
        }
        private static void saisieSalaire( int salaire)
        {
            //*******************************************************************
            //*                      Saisie du salaire                          *
            //*******************************************************************

            string bigSalaire;

            Console.WriteLine("Quelle est la salaire de cet(te) employé(e) ?");
            bigSalaire = Console.ReadLine();

            int.TryParse(bigSalaire, out salaire);

            if (salaire < 0)
            {
                recommence();
            }
        }
        private static void sortie()
        {
            //*******************************************************************
            //*                   Sortir de l'application                       *
            //*******************************************************************

            Environment.Exit(0);
        }
    }
}
