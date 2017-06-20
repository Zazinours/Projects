using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using salarie;
using System.Collections;


namespace gestion_de_listes
{
    class Program
    {
        
        static void Main(string[] args)
        {

           
           
        }

        public void CreerListeHeteroclite()
        {
            //
            decimal ValeurDecimal;
            int ValeurInt;
            string ChaineCara;
            double salaireNetCom;

            ValeurDecimal = 10;
            ValeurInt = 5;
            ChaineCara = "Chaine de caractères";
            salaireNetCom = 0;

            //Remplissage
            

            Salarie sal1 = new Salarie();
            sal1.Nom = "FUENTES";
            sal1.Prenom = "Sylvain";
            sal1.SalaireBrut = 700;
            sal1.TauxCS = 0.5;

            Commercial Com1 = new Commercial();
            Com1.Nom = "NomCom1";
            Com1.Prenom = "PrenomCom1";
            Com1.SalaireBrut = 2000;
            salaireNetCom = Com1.sNetCommercial();

            Commercial Com2 = new Commercial();
            Com2.Nom = "NomCom2";
            Com2.Prenom = "PrenomCom2";
            Com2.SalaireBrut = 2000;
            salaireNetCom = Com2.sNetCommercial();

            //

            ArrayList TabDyn = new ArrayList();
            
            TabDyn.Add(ValeurDecimal);
            TabDyn.Add(ValeurInt);
            TabDyn.Add(ChaineCara);
            TabDyn.Add(sal1);
            TabDyn.Add(Com1);
            TabDyn.Add(Com2);

               //
            int NbElementListe;
          
            //

            NbElementListe = TabDyn.Count;

            foreach (var num in TabDyn)
            {
                Console.WriteLine("{0}",num);
            }
            Console.ReadLine();
        }

            }
}

