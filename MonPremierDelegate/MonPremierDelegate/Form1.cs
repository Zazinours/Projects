using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestThread
{
    class Program
    {
        //Mon delegate aura exactement la même signature que ma méthode !
        delegate bool PremierDelegate(string i);

        static void Main(string[] args)
        {
            //Je crée une variable a qui contiendra la méthode Test.
            PremierDelegate a = new PremierDelegate(Test);

            //Au lieu d'appeler Test, je vais appeler a, ce qui me donnera le
            //même résultat !
            bool resultat = a("Ceci est un test qui est négatif !");
            bool res2 = a("Positif");
            if (resultat)
            {
                MessageBox.Show(a.ToString());
            }
            if (res2)
            {
                MessageBox.Show(a.ToString());

            }

        }

        static public bool Test(string test)
        {
            return test.Length < 15;
        }
    }
}
