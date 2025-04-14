using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlaseObjekti2
{
    internal class Osoba
    {

        private static int brojOsoba = 0;

        public static int DohvatiBrojOsoba()
        {
            return brojOsoba;
        }

        //defaultni konstruktor klase Osoba
        public Osoba()
        {
            brojOsoba++;
        }

        //parametrizirani konstruktor
        public Osoba(string ime, string prezime)
        {
            brojOsoba += 1;
            Ime = ime;
            Prezime = prezime;
        }

        //modifikator pristupa public omogućuje pristupanje svojstvima, metodama i događajima izvan definicije klase

        public string Ime { get; set; }
        public string Prezime { get; set; }

        //definiija metode
        public string PunoIme()
        {
            return Ime + " " + Prezime;
        }
    }
}
