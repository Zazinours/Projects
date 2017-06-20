using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using salarie;


namespace GestionSalaries
{
    class GestionSalaries
    {
        static void Main(string[] args)
        {

            //╔══════════════════════════════════════════════════════════════════╗
            //║                                                                  ║
            //║                         Gestion Salarie                          ║
            //║                                                                  ║
            //╚══════════════════════════════════════════════════════════════════╝

            //Variables


            //Initialisation

            Salarie sal1 = new Salarie();

            double salaireNetOrigin;

            sal1.DateNaissance = new DateTime(1974, 02, 27);
            sal1.Nom = "FUENTES";
            sal1.Matricule = "01FUE02";
            sal1.Prenom = "Sylvain";
            sal1.SalaireNet = 1800;
            salaireNetOrigin = 1800;
            sal1.TauxCS = 0.5;


            Salarie sal2 = new Salarie(sal1);

            //Matricule

            Console.WriteLine("Matricule : {0}", sal1.Matricule);
            Console.WriteLine("Date de naissance : {0}", sal1.DateNaissance);
            Console.WriteLine("Nom : {0}", sal1.Nom);
            Console.WriteLine("Prenom : {0}", sal1.Prenom);
            Console.WriteLine("Taux CS : {0}", sal1.TauxCS);
            Console.WriteLine("Salaire net : {0}", sal1.SalaireNet);

            sal2.SalaireNet = salaireNetOrigin;
            sal2.Matricule = "01FUE02";

            Console.WriteLine("");
            Console.WriteLine("Matricule : {0}", sal2.Matricule);
            Console.WriteLine("Date de naissance : {0}", sal2.DateNaissance);
            Console.WriteLine("Nom : {0}", sal2.Nom);
            Console.WriteLine("Prenom : {0}", sal2.Prenom);
            Console.WriteLine("Taux CS : {0}", sal2.TauxCS);
            Console.WriteLine("Salaire net : {0}", sal2.SalaireNet);



            //Subtitution et equals

            salarieV2 test = new salarieV2();
            test.Nom = "Fuentes";
            test.Matricule = "01FUE02";
            
            Console.WriteLine("");
            Console.WriteLine("test de l'héritage :{0}", test.Nom);

                      
            if (sal1.Equals(sal2))
            {
                Console.WriteLine("La comparaison de {0} et {1} est TRUE", sal1.Matricule, sal2.Matricule);
            }
            else
            {
                Console.WriteLine("La comparaison de {0} et {1} est FALSE", sal1.Matricule, sal2.Matricule);
            }

            //commercial

            Commercial sComNet = new Commercial();
            sComNet.SalaireBrut = 1200;
            sComNet.TauxCS = 0.4;
            sComNet.ChiffreAffaire = 10000;
            sComNet.Commission = 0.1;
            
            Console.WriteLine("");
            Console.WriteLine("Salaire Brut : {0}",sComNet.SalaireBrut);
            Console.WriteLine("Taux CS : {0}", sComNet.TauxCS);
            Console.WriteLine("Chiffre d'affaire : {0}", sComNet.ChiffreAffaire);
            Console.WriteLine("Commission : {0}", sComNet.Commission);
            Console.WriteLine("le salaire net est de : {0}", sComNet.SalaireNet.ToString());

            

            //
            Console.ReadLine();
        }


    }
}
