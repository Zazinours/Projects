using salarie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalarieTest
{
    class SalarieTest
    {
        static void Main(string[] args)
        {

            //╔══════════════════════════════════════════════════════════════════╗
            //║                                                                  ║
            //║                      Tester Gestion Salarie                      ║
            //║                                                                  ║
            //╚══════════════════════════════════════════════════════════════════╝

            //Variables


            //Initialisation

            Salarie sal1 = new Salarie();

            sal1.DateNaissance = new DateTime(1974, 02, 27);
            sal1.Nom = "FUENTES";
            sal1.Matricule = "01FUE02";
            sal1.Prenom = "Sylvain";
            sal1.SalaireNet = 1800;
            sal1.TauxCS = 0.6;

            //Matricule

            Console.WriteLine("Test du matricule");
            sal1.Matricule = "01FUE02";
            Console.WriteLine("Attendu : {0} | Obtenu :{1}", "01FUE02",sal1.Matricule);
            sal1.Matricule = "01FUE0";
            Console.WriteLine("Attendu : {0} | Obtenu :{1}", "01FUE0", sal1.Matricule);
            sal1.Matricule = "FUE0201";
            Console.WriteLine("Attendu : {0} | Obtenu :{1}", "FUE0201", sal1.Matricule);
            sal1.Matricule = "ADFUE00";
            Console.WriteLine("Attendu : {0} | Obtenu :{1}", "ADFUE00", sal1.Matricule);

            //Date de naissance

            Console.WriteLine("");
            Console.WriteLine("Date de naissance");
            sal1.DateNaissance = new DateTime (1800,05,25);
            Console.WriteLine("Attendu : {0} | Obtenu :{1}","25/05/1800", sal1.DateNaissance);
            sal1.DateNaissance = new DateTime(2015, 05, 25);
            Console.WriteLine("Attendu : {0} | Obtenu :{1}","25/05/2015", sal1.DateNaissance);
            sal1.DateNaissance = new DateTime(1974, 02, 02);
            Console.WriteLine("Attendu : {0} | Obtenu :{1}","02/02/1974", sal1.DateNaissance);

            //Nom

            Console.WriteLine("");
            Console.WriteLine("Nom");
            sal1.Nom = "";
            Console.WriteLine("Attendu : {0} | Obtenu :{1}", "", sal1.Nom);
            sal1.Nom = " ";
            Console.WriteLine("Attendu : {0} | Obtenu :{1}", " ", sal1.Nom);
            sal1.Nom = "*";
            Console.WriteLine("Attendu : {0} | Obtenu :{1}", "*", sal1.Nom);
            sal1.Nom = "fuentes";
            Console.WriteLine("Attendu : {0} | Obtenu :{1}", "fuentes", sal1.Nom);
            sal1.Nom = "FUENTES";
            Console.WriteLine("Attendu : {0} | Obtenu :{1}", "FUENTES", sal1.Nom);
            sal1.Nom = "Fuentes";
            Console.WriteLine("Attendu : {0} | Obtenu :{1}", "Fuentes", sal1.Nom);
            sal1.Nom = "fUENTES";
            Console.WriteLine("Attendu : {0} | Obtenu :{1}", "fUENTES", sal1.Nom);
            sal1.Nom = "*fUENTES";
            Console.WriteLine("Attendu : {0} | Obtenu :{1}", "*fUENTES", sal1.Nom);
            sal1.Nom = "0fUENTES";
            Console.WriteLine("Attendu : {0} | Obtenu :{1}", "0fUENTES", sal1.Nom);
            sal1.Nom = "AbcdefghijklmnopqrstuvwxyzABCD";
            Console.WriteLine("Attendu : {0} | Obtenu :{1}", "AbcdefghijklmnopqrstuvwxyzABCD", sal1.Nom);
            sal1.Nom = "AbcdefghijklmnopqrstuvwxyzABCDE";
            Console.WriteLine("Attendu : {0} | Obtenu :{1}", "AbcdefghijklmnopqrstuvwxyzABCDE", sal1.Nom);
            
            //prenom

            Console.WriteLine("");
            Console.WriteLine("Prenom");
            sal1.Prenom = "";
            Console.WriteLine("Attendu : {0} | Obtenu :{1}", "", sal1.Prenom);
            sal1.Prenom = " ";
            Console.WriteLine("Attendu : {0} | Obtenu :{1}", " ", sal1.Prenom);
            sal1.Prenom = "*";
            Console.WriteLine("Attendu : {0} | Obtenu :{1}", "*", sal1.Prenom);
            sal1.Prenom = "fuentes";
            Console.WriteLine("Attendu : {0} | Obtenu :{1}", "fuentes", sal1.Prenom);
            sal1.Prenom = "FUENTES";
            Console.WriteLine("Attendu : {0} | Obtenu :{1}", "FUENTES", sal1.Prenom);
            sal1.Prenom = "Fuentes";
            Console.WriteLine("Attendu : {0} | Obtenu :{1}", "Fuentes", sal1.Prenom);
            sal1.Prenom = "fUENTES";
            Console.WriteLine("Attendu : {0} | Obtenu :{1}", "fUENTES", sal1.Prenom);
            sal1.Prenom = "*fUENTES";
            Console.WriteLine("Attendu : {0} | Obtenu :{1}", "*fUENTES", sal1.Prenom);
            sal1.Prenom = "0fUENTES";
            Console.WriteLine("Attendu : {0} | Obtenu :{1}", "0fUENTES", sal1.Prenom);
            sal1.Prenom = "AbcdefghijklmnopqrstuvwxyzABCD";
            Console.WriteLine("Attendu : {0} | Obtenu :{1}", "AbcdefghijklmnopqrstuvwxyzABCD", sal1.Prenom);
            sal1.Prenom = "AbcdefghijklmnopqrstuvwxyzABCDE";
            Console.WriteLine("Attendu : {0} | Obtenu :{1}", "AbcdefghijklmnopqrstuvwxyzABCDE", sal1.Prenom);
            //Taux CS

            Console.WriteLine("");
            Console.WriteLine("Taux CS");
            sal1.TauxCS = 0;
            Console.WriteLine("Attendu : {0} | Obtenu :{1}", 0, sal1.TauxCS);
            sal1.TauxCS = 0.4;
            Console.WriteLine("Attendu : {0} | Obtenu :{1}", 0.4, sal1.TauxCS);
            sal1.TauxCS = 0.7;
            Console.WriteLine("Attendu : {0} | Obtenu :{1}", 0.7, sal1.TauxCS);
            sal1.TauxCS = -5;
            Console.WriteLine("Attendu : {0} | Obtenu :{1}", -5, sal1.TauxCS);

            //salaire

            Console.WriteLine("");
            Console.WriteLine("Salaire net");
            sal1.SalaireNet = 0;
            Console.WriteLine("Attendu : {0} | Obtenu :{1}", 0, sal1.SalaireNet);

            //commercial

            Commercial sComNet = new Commercial();
            sComNet.SalaireBrut = 1200;
            sComNet.TauxCS = 0.4;
            sComNet.ChiffreAffaire = 10000;
            sComNet.Commission = 0.1;

            Console.WriteLine("");
            Console.WriteLine("Salaire Brut : {0}", sComNet.SalaireBrut);
            Console.WriteLine("Taux CS : {0}", sComNet.TauxCS);
            Console.WriteLine("Chiffre d'affaire : {0}", sComNet.ChiffreAffaire);
            Console.WriteLine("Commission : {0}", sComNet.Commission);
            Console.WriteLine("le salaire net est de : {0}", sComNet.SalaireNet.ToString());
            Console.ReadLine();
        }
        
   
    }
}
