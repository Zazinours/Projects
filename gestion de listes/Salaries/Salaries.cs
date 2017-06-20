using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;
using salarie;
using System.Collections;

namespace Salaries
{
    class Program
    {
        static void Main(string[] args)
        {

            CreerListeHeteroclite();


        }
        public static void CreerListeHeteroclite()
        {
       
            Salarie listeSalaries = new Salarie();

            listeSalaries.Add (new Salarie() { Matricule = "12XXX12", Nom = "Bost", Prenom = "Vincent" });
            
        }
    

    }



}
