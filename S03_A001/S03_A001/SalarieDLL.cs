using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salarie
{
    public class Salarie
    {

        string _matricule = string.Empty;
        string _nom = string.Empty;
        string _prenom = string.Empty;
        double _SalaireBrut;
        double _TauxCS;
        DateTime _DateNaissance;

        public void Add(Salarie salarie)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// chaîne representant l'objet instancié
        /// </summary>
        /// <retunrs>Valeurs des propriétés de l'objet</retunrs>
        public override string ToString()
        {
            return string.Format(@"{0} Euros", this.SalaireNet);
        }

        /*/// <summary>
        /// Détermine si un objet équivaut au salarié considéré
        /// </summary>
        /// <param name="sal">Objet</param>
        /// <return>Vrai si égaux</return>
        public override bool Equals(object obj)
        {
            Salarie stSalarie = obj as Salarie;
            if (stSalarie == null) return false;
            if (this._DateNaissance == stSalarie.DateNaissance && this._nom == stSalarie._nom) return true;
            else return false;

        }*/



        public string Matricule

        {
            get
            {
                return _matricule;
            }

            set
            {
                int nbCar;

                nbCar = value.Length;

                if (nbCar == 7)
                {

                    if (char.IsDigit(value, 0) &&
                                char.IsDigit(value, 1) &&
                                char.IsLetter(value, 2) &&
                                char.IsLetter(value, 3) &&
                                char.IsLetter(value, 4) &&
                                char.IsDigit(value, 5) &&
                                char.IsDigit(value, 6))

                    {

                        _matricule = value;

                    }

                }
                else
                {
                    _matricule = "";
                }



            }
        }

        public virtual string Nom
        {
            get
            {
                return _nom;
            }

            set
            {
                int nbCar;

                nbCar = value.Length;

                if (nbCar != 0 && nbCar < 31)
                {

                    if (char.IsLetter(value, 0) && char.IsUpper(value, 0))

                    {
                        _nom = value;

                    }
                    else

                    {
                        _nom = "";
                    }

                }

                else
                {
                    _nom = "";
                }



            }
        }

        public string Prenom
        {
            get
            {
                return _prenom;
            }

            set
            {
                int nbCar;

                nbCar = value.Length;

                if (nbCar != 0 && nbCar < 31)
                {

                    if (char.IsLetter(value, 0) && char.IsUpper(value, 0))

                    {
                        _prenom = value;

                    }
                    else

                    {
                        _prenom = "";
                    }

                }

                else
                {
                    _prenom = "";
                }

            }
        }

        public virtual double SalaireNet
        {
            get
            {
                return SalaireBrut * _TauxCS;
            }

            set
            {
                SalaireBrut = value;
            }
        }

        public double TauxCS
        {
            get
            {
                return _TauxCS;
            }

            set
            {
                double tauxMax;

                tauxMax = 0.6;

                if (value < tauxMax && value > 0)

                {
                    _TauxCS = value;
                }

                else

                {
                    _TauxCS = 0;
                }

            }



        }

        public DateTime DateNaissance
        {
            get
            {
                return _DateNaissance;
            }

            set
            {

                if (value.Year > 1900 && value.Year < (DateTime.Now.Year - 15))

                {
                    _DateNaissance = value;
                }
            }

        }

        public double SalaireBrut
        {
            get
            {
                return _SalaireBrut;
            }

            set
            {
                _SalaireBrut = value;
            }
        }

        //constructeur de recopie

        public Salarie(Salarie recopieSalarie)

        {

            this.Nom = recopieSalarie.Nom;
            this.Prenom = recopieSalarie.Prenom;
            this.TauxCS = recopieSalarie.TauxCS;
            this.SalaireNet = recopieSalarie.SalaireNet;
            this.DateNaissance = recopieSalarie.DateNaissance;
        }

        //constructeur par defaut

        public Salarie()
        {


        }

        //constructeur d'initialisation

        public Salarie(string Nom, string Prenom, string Matricule)
        {

            this.Nom = Nom;
            this.Prenom = Prenom;
            this.Matricule = Matricule;


        }

        public override int GetHashCode()
        {
            return _matricule.GetHashCode();
        }
        public override bool Equals(object obj)
        {

            Salarie matriculeV2 = obj as Salarie;

            if (matriculeV2 == null)
            {
                return false;
            }

            if (Matricule == matriculeV2.Matricule)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
    public class salarieV2 : Salarie
    {
        public salarieV2() : base()
        {

        }

        public override string Nom
        {
            set
            {
                base.Nom = value;
            }
            get
            {
                return base.Nom.ToUpper();
            }
        }
    }

    public class Commercial : Salarie
    {
        double _chiffreAffaire;
        double _commission;
        public Commercial() : base() { }

        public double ChiffreAffaire
        {
            get
            {
                return _chiffreAffaire;
            }

            set
            {
                _chiffreAffaire = value;
            }
        }

        public double Commission
        {
            get
            {
                return _commission;
            }

            set
            {
                _commission = value;
            }
        }

        public override double SalaireNet
        {
            get
            {
                return base.SalaireNet + (_commission * _chiffreAffaire);
            }
        }

        public double sNetCommercial()
        {
            throw new NotImplementedException();
        }

        public double sNetCommercial(double chiffreAffaire, double commission,double salaire)
        {
            double cAffaire;
            double com;
            
            cAffaire = chiffreAffaire;
            com = commission;

            salaire = salaire  + (com * cAffaire);

            return salaire;

        }
        
    }

    public class Salaries : Salarie
    {

                        

    }
}


