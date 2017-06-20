using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stagiaires
{
    public class Stagiaire
    {
        string _nom = string.Empty;
        DateTime _dateNaissance;
        int _taille;

        public int Age
        {

            get
            {

                return DateTime.Now.Subtract(_dateNaissance).Days / 365;
            }
        }

       

        public string Nom
        {
            get

            {
                return _nom.ToUpper();
            }

            set
            {

                if (isNomValide(value))
                {
                    _nom = value;
                }

            }

        }

        public DateTime DateNaissance
        {
            get
            {
                return _dateNaissance;
            }

            set
            {
                _dateNaissance = value;
            }
        }

        public int Taille
        {
            get
            {
                return _taille;
            }

            set
            {

                _taille = value;
            }
        }

        public static bool isNomValide(string nom)
        {

            foreach (char item in nom)
            {

                if (!char.IsLetter(item))

                {
                    return false;
                }



            }
            return true;
        }
    }

}

