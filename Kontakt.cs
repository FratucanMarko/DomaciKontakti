using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Kontakt
    {
        private string ime;

        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }

        private string prezime;

        public string Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        }

        private string glavnibroj;

        public string GlavniBroj
        {
            get { return glavnibroj; }
            set { glavnibroj = value; }
        }

        private List<string> ostalibrojevi = new List<string>();

        public List<string> OstaliBrojevi
        {
            get { return ostalibrojevi; }
            set { ostalibrojevi = value; }
        }

        public Kontakt(string ime, string prezime, string glavnibroj)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.glavnibroj= glavnibroj;
        }

        public bool DodajBroj(string dodatniBroj)
        {
            if (dodatniBroj == glavnibroj)
            {
                return false;
            }

            foreach (var item in ostalibrojevi)
            {
                if (dodatniBroj == item)
                {
                    return false;
                }
            }
            ostalibrojevi.Add(dodatniBroj);
            return true;
            
        }

        public bool IzbrisiBroj(string dodatniBroj)
        {
            if (ostalibrojevi.Contains(dodatniBroj))
            {
                ostalibrojevi.Remove(dodatniBroj);
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            string str = "";
            str += ime;
            str += " ";
            str +=  prezime;
            str += " ";
            str += glavnibroj;
            str += " ";
            if (ostalibrojevi == null)
            {
                return str;
            }
            else
            {
                str += "[";
                for (int i = 0; i < ostalibrojevi.Count - 1; i++)
                {
                    str += ostalibrojevi[i];
                    str += ",";
                }
                str += ostalibrojevi[ostalibrojevi.Count - 1];
                str += "]";
                return str;
            }
        }

    }
}

