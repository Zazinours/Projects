using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalarieDll;
using System.IO;


namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            SalarieS listeSalaries = new SalarieS();

            listeSalaries.Add(new Salarie() { Matricule = "12XXX12", Nom = "bost", Prenom = "vincent" });
            listeSalaries.Add(new Salarie() { Matricule = "12XXX13", Nom = "tartempion", Prenom = "gilbert" });
            listeSalaries.Add(new Salarie() { Matricule = "12XXX12", Nom = "bost", Prenom = "vincent" });
            Console.WriteLine("Attendu true {0}", 2 == listeSalaries.Count);


            //Sauvegardes

            string nomFichier;
            string Texte;

            nomFichier = "C:\\Users\\CDI\\OneDrive\\Visual Studio 2015\\Projects\\SalarieS\\Salaries.cvs";
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

            // Effacement liste

            listeSalaries.Clear();

            //Salarie salASupprimmer1 = listeSalaries.Extraire("12XXX13");
            //listeSalaries.Remove(salASupprimmer1);
            //Salarie salASupprimmer2 = listeSalaries.Extraire("12XXX12");
            //listeSalaries.Remove(salASupprimmer2);


            // Recupération Liste

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
                sBrutMot = int.Parse(salBrutMot);
                tauxCSMot = mots[5];

                //listeSalaries.Add(new Salarie() { Nom = nomMot, Prenom = prenomMot, Matricule = matMot, SalaireBrut=sBrutMot,TauxCS=tauxCSMot });
                listeSalaries.Add(new Salarie() { Nom = nomMot, Prenom = prenomMot, Matricule = matMot, SalaireBrut = sBrutMot });



            }

            // Réaffichage

            Console.WriteLine("");
            Console.WriteLine("Resultat récupération liste :");

            //foreach (Salarie sal in listeSalaries)

            //{

            //    Texte = sal.ToString();

            //    Console.WriteLine("{0}",Texte);

            //}

            string sal1;
            

            for (int i = 0; i < 1; i++)
            {
                sal1 = listeSalaries[i].ToString();
                Console.WriteLine("{0}", sal1.ToString());
            }

            //Console.WriteLine("{0}", sal2);

            // Fin de programme

            Console.ReadLine();



        }

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

        static void SaveBinary(string nomFichier)

        {
            
           

        }
        static string LoadBinary(string nomFichier)

        {
            string Texte;
            Texte = "";


            return Texte;

        }

        static void SaveXML(string nomFichier)

        {
            


        }
        static string LoadXML(string nomFichier)

        {
            string Texte;
            Texte = "";


            return Texte;

        }

    }
}
