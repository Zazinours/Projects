using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalarieDll;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Globalization;

namespace Serialisation
{
    class ProgSerialisation
    {

        public static SalarieS listeSalaries = new SalarieS();
        static void Main(string[] args)
        {

            Programme();

        }
        static void Programme()
        {

            //╔══════════════════════════════════════════════════════════════════╗
            //║                                                                  ║
            //║                      Programme pricipal                          ║
            //║                                                                  ║
            //╚══════════════════════════════════════════════════════════════════╝

            //Variables

            string nomFichier;
            string Texte;
            string choixUtilisateur;

            //Initialisations

            choixUtilisateur = "";

            nomFichier = @"C:\Users\CDI\OneDrive\Visual Studio 2015\Projects\SalarieS\Salaries.cvs";
            Texte = "";



            listeSalaries.Add(new Salarie() { Matricule = "12XXX10", Nom = "Bost", Prenom = "Vincent" });
            listeSalaries.Add(new Salarie() { Matricule = "12XXX11", Nom = "Tartempion", Prenom = "Gilbert" });
            listeSalaries.Add(new Salarie() { Matricule = "12XXX12", Nom = "Bitenbois", Prenom = "Raoul" });
            listeSalaries.Add(new Salarie() { Matricule = "12XXX13", Nom = "Lembrouille", Prenom = "Didier" });
            listeSalaries.Add(new Salarie() { Matricule = "12XXX14", Nom = "Huildar", Prenom = "Rachid" });
            listeSalaries.Add(new Commercial() { Matricule = "12XXX19", Nom = "Huildar", Prenom = "Rachid" });
            listeSalaries.Add(new Commercial() { Matricule = "", Nom = "", Prenom = "" });


            // Dialogues

            dialogue();
            recuperationChoix(choixUtilisateur);
            conformiteChoixUtilisateur(choixUtilisateur);

            // 

        }
        #region Lecture / Ecriture du fichier
        static void SaveText(string Texte, string nomFichier)

        {

            if (!File.Exists(nomFichier))

            {
                FileStream fs = new FileStream(nomFichier, FileMode.OpenOrCreate);
                fs.Close();
            }

            string textSvg;

            textSvg = Texte;

            System.IO.StreamWriter file = new System.IO.StreamWriter(nomFichier);

            file.Write(textSvg);

            file.Close();

        }

        static string loadText(string nomFichier)
        {
            string Texte;
            Texte = "";

            System.IO.StreamReader file = new System.IO.StreamReader(nomFichier);

            while (file.EndOfStream == false)
            {
                if (Texte == "")
                {
                    Texte = file.ReadLine();
                }
                else
                {
                    Texte = Texte + ";\n;" + file.ReadLine();
                }


            }




            file.Close();


            return Texte;


        }


        #endregion

        #region Gestion console et utilisateur
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
            Console.WriteLine("║       Exercies de sérialisation          ║");
            Console.WriteLine("║──────────────────────────────────────────║");
            Console.WriteLine("║                                          ║");
            Console.WriteLine("║ Tapez C pour écrire un fichier CVS       ║");
            Console.WriteLine("║ Tapez D pour lire un fichier CVS         ║");
            Console.WriteLine("║ Tapez B pour écrire un fichier Binaire   ║");
            Console.WriteLine("║ Tapez A pour lire un fichier Binaire     ║");
            Console.WriteLine("║ Tapez X pour un écrire un fichier XML    ║");
            Console.WriteLine("║ Tapez Z pour lire un fichier XML         ║");
            Console.WriteLine("║ Tapez J pour un écrire un fichier JSON   ║");
            Console.WriteLine("║ Tapez i pour lire un fichier JSON        ║");
            Console.WriteLine("║                                          ║");
            Console.WriteLine("╚══════════════════════════════════════════╝");
            Console.WriteLine("");
            Console.WriteLine("  Tapez Q pour sortir du programme");
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
            string nomFichier;

            //Initialisation

            traitementChoix = choixUtilisateur.ToUpper();

            //Travaux

            nomFichier = "C:\\Users\\CDI\\OneDrive\\Visual Studio 2015\\Projects\\SalarieS\\Salaries.cvs";

            switch (traitementChoix)
            {
                case "C":
                    #region Ecrire CVS



                    string Texte;


                    Texte = "";

                    foreach (Salarie sal in listeSalaries)

                    {
                        if (Texte == "")
                        {
                            Texte = sal.ToString();
                        }
                        else
                        {
                            Texte = Texte + "\n" + sal.ToString();
                        }



                    }

                    SaveText(Texte, nomFichier);

                    Programme();

                    #endregion 
                    break;

                case "D":
                    #region Lire CVS


                    Texte = "";

                    Texte = loadText(nomFichier);

                    Console.WriteLine("");
                    Console.WriteLine(Texte);
                    Console.WriteLine("");

                    // Traitements

                    string value = Texte;
                    char delimiter = '\n';
                    string mat;
                    string nomSal;

                    mat = "";
                    nomSal = "";


                    string[] substrings = value.Split(delimiter);


                    foreach (var item in substrings)
                    {


                        string[] mots = value.Split(';');
                        string matMot;
                        string nomMot;
                        string prenomMot;
                        int sBrutMot;
                        string salBrutMot;
                        string tauxCSMot;


                        nomMot = mots[0];
                        prenomMot = mots[1];
                        matMot = mots[3];
                        salBrutMot = mots[4];
                        sBrutMot = int.Parse(salBrutMot,CultureInfo.CurrentCulture); //normalisation culture
                        tauxCSMot = mots[5];

                        //listeSalaries.Add(new Salarie() { Nom = nomMot, Prenom = prenomMot, Matricule = matMot, SalaireBrut=sBrutMot,TauxCS=tauxCSMot });
                        listeSalaries.Add(new Salarie() { Nom = nomMot, Prenom = prenomMot, Matricule = matMot, SalaireBrut = sBrutMot });

                    }
                    Programme();

                    #endregion

                    break;

                case "B":
                    #region Ecrire Binaire

                    listeSalaries.SaveBinary();
                    Programme();

                    #endregion
                    break;
                case "A":
                    #region Lire Binaire

                    listeSalaries.LoadBinary();
                    Programme();


                    #endregion


                    break;

                case "X":
                    #region Ecrire XML

                    listeSalaries.SaveXML();
                    Programme();

                    #endregion


                    break;
                case "Z":
                    #region Lire XML

                    listeSalaries.LoadXML();
                    Programme();

                    #endregion


                    break;

                case "J":
                    #region Ecrire JSON

                    listeSalaries.SaveJson();
                    Programme();

                    #endregion


                    break;
                case "I":
                    #region Lire JSON

                    listeSalaries.LoadJson();
                    Programme();

                    #endregion


                    break;

                case "Q": 
                    #region Quitter

                    effacerConsole();

                    Console.WriteLine("Merci d'avoir utilisé cette application");

                    attenteTouche();

                    QuitterProgramme();

                    #endregion


                    break;


            }



        }
        #endregion

        static void EffacerListe()
        {
            listeSalaries.Clear();
        }
    }
}

