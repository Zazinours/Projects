using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S02_A001_1_2
{
    class Program
    {
        static void Main(string[] args)
        {

            
            afficheValeurs(demandeValeurs());


        }


        static int[] demandeValeurs()

        {
            int[] valeur = new int[2];
            string val1;
            string val2;

            Console.WriteLine("Valeur 1 :");
            val1 = Console.ReadLine();
            int.TryParse(val1, out valeur[0]);

            Console.WriteLine("Valeur 2 :");
            val2 = Console.ReadLine();
            int.TryParse(val2, out valeur[1]);

            return valeur;
            

        }

       static void afficheValeurs(int[] bob)

        {

            int[] a = bob;
            int val1=a[0];
            int val2=a[1];
            int val3 = val1 + val2;
            
            Console.WriteLine("Les valeurs sont {0} et {1}",val1,val2);
            Console.WriteLine("La somme est {0} ", val3);
            Console.WriteLine(Console.ReadLine());

            
     }

     }

}
