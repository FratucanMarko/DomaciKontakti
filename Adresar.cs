﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Adresar
    {
        Dictionary<string, Kontakt> kontakti = new Dictionary<string, Kontakt>();

        public bool Dodaj(Kontakt k)
        {
            if (kontakti.ContainsKey(k.GlavniBroj))
                return false;

            kontakti.Add(k.GlavniBroj, k);
            return true;
        }
        public bool Dodaj(string ime, string prezime, string glavniBroj)
        {
            Kontakt k1 = new Kontakt(ime, prezime, glavniBroj);
            Dodaj(k1);
            return true;
        }
        public bool Blokiraj(string broj)
        {
            if (!kontakti.ContainsKey(broj))
                return false;

            kontakti.Remove(broj);
            return true;
        }

        public bool Share(string file, string glavniBroj)
        {
            StreamWriter sw = new StreamWriter(file);
            try
            {
                sw.WriteLine(kontakti[glavniBroj]);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                sw.Close();
            }
            return true;
        }

        public bool Receive(string file)
        {
            StreamReader sr = new StreamReader(file);
            string line;
            try
            {
                line = sr.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                sr.Close();
            }
            return true;
        }

        public bool Backup(string file)
        {
            string s = "";
            foreach (KeyValuePair<string, Kontakt> item in kontakti)
            {
                s += $"{kontakti[item.Key]} \n";
            }
            StreamWriter sw = new StreamWriter(file);
            try
            {
                sw.WriteLine(s);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                sw.Close();
            }
            return true;
        }
    }
}
