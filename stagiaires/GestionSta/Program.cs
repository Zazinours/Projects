using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using stagiaires;

namespace GestionStagiaire
{
    class Program
    {
        static void Main(string[] args)
        {
            Stagiaire stab1 = new Stagiaire();
            Stagiaire stag2 = stab1;
            stag2.DateNaissance = new DateTime(1974, 02, 27);
            stag2.Nom = "Sylvain";

            Console.WriteLine("Age de {0} est {1}", stag2.Nom, stag2.Age);
            Console.ReadLine();

        }
    }
}
