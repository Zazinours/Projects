using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S02_A003_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            int a;
            int b;
            int[] tabA, tabB;


            //Affectations
            a = 10;
            b = a;
            tabA = new int[3] { 2, 5, 4 };
            tabB = tabA;

            //Manipulations
            b = b + 5;

            Console.WriteLine("a: {0} b: {1}",a,b);
            Console.WriteLine("");

            tabB[0] = 7;

            Console.WriteLine("tabA[0]: {0} tabB[0]: {1}", tabA[0], tabB[0]);
            
            Console.WriteLine("La modification du tableau tabB entraine la modification de tabA");
            Console.WriteLine("");



            Console.ReadLine();
        }
    }
}
