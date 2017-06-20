using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Xml;
using System.Web;
using System.Runtime.Serialization;

namespace SalarieDll
{
    [Serializable()]
    [XmlInclude(typeof(Commercial))]
    public class SalarieS : List<Salarie>
    {
        public new void Add(Salarie salarie)
        {
            //if (!IfExists(salarie))
            //{
            //    base.Add(salarie);
            //}

            if (!Contains(salarie))
            {
                base.Add(salarie);
            }

        }
         
        private bool IfExists(Salarie sal)
        {
            foreach (Salarie item in this)
            {
                if (item.Equals(sal))
                {
                    return true;
                }

            } return false;
            
        }


        public Salarie Extraire(string matricule)
        {
            foreach (Salarie item in this)
            {
                if (item.Matricule==matricule)
                {
                    return item;
                }
            }  return null;

            
        }

        public SalarieS() { }


        //methode qui supprime l element dont le matricule est fournit
        public void Remove(string matricule)
        {
            base.Remove(Extraire(matricule));

        }

        public void SaveBinary()

        {
            string nomFichier;
            nomFichier = @"C:\Users\CDI\OneDrive\Visual Studio 2015\Projects\SalarieS\Salaries.dat";

            FileStream fs = new FileStream(nomFichier, FileMode.CreateNew);

            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, this);
            fs.Close();
            

        }
        public void LoadBinary()

        {
            string nomFichier;
            nomFichier = @"C:\Users\CDI\OneDrive\Visual Studio 2015\Projects\SalarieS\Salaries.dat";

            FileStream fs = new FileStream(nomFichier, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            this.AddRange(bf.Deserialize(fs) as SalarieS);
            fs.Close();
           

        }

        public void SaveXML()

        {
            string nomFichier = @"C:\Users\CDI\OneDrive\Visual Studio 2015\Projects\SalarieS\Salaries.xml";

            FileStream filestream = new FileStream(nomFichier, FileMode.CreateNew);
            XmlTextWriter xmlTW = new XmlTextWriter(filestream, Encoding.UTF8);
            XmlSerializer xmlS = new XmlSerializer(base.GetType());
            xmlS.Serialize(xmlTW, this);
            filestream.Close();
            xmlTW.Close();

        }
        public void LoadXML()

        {
            string nomFichier = @"C:\Users\CDI\OneDrive\Visual Studio 2015\Projects\SalarieS\Salaries.xml";

            FileStream filestream;
            XmlTextReader xmlTR;
            XmlSerializer xmlS;

            filestream = new FileStream(nomFichier, FileMode.Open);
            xmlTR = new XmlTextReader(filestream);
            xmlS = new XmlSerializer(this.GetType());
            base.AddRange(xmlS.Deserialize(xmlTR) as SalarieS);
            xmlTR.Close();
            filestream.Close();

        }

        public void SaveJson()
        {
            //string nomFichier = @"C:\Users\CDI\OneDrive\Visual Studio 2015\Projects\SalarieS\Salaries.json";
            //FileStream filestream = new FileStream(nomFichier, FileMode.Create);
            //DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(FileStream));
            //ser = WriteObjet(filestream, this.GetType());
            //filestream.Close();

        }

        public void LoadJson()

        {



        }

    }
}

 //-----------------------------------------------------------------------------------------------

        

     