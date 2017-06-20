using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S002_A003_9
{
    class Program
    {
        static void Main(string[] args)
        {

            saisieValeur();
        }

        private static void saisieValeur()
        {

            string saisie;
            int val1;
            bool reponce;

            Console.WriteLine("Saisire un nombre :");
            saisie = Console.ReadLine();

            int.TryParse(saisie, out val1);
            reponce = paireImpaire(val1);

            Console.WriteLine("L'argument est {0}", reponce);
            Console.ReadLine();



        }

        private static bool paireImpaire(int val1)
        {
            return (val1 % 2 == 0);
        }
    }
}
