using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstruktori
{
    internal class Osoba
    {
        // 1. svojstva
        public string Ime { get; set; }
        public string Prezime { get; set; }

        // 2. Konstruktori
        public Osoba() { }

        public Osoba (string ime)
        {
            Ime = ime;
        }

        public Osoba (string ime, string prezime) 
        {
            this.Ime = ime; // kljucna rijec this mi je ovdje nepotrebna jer se nalazim unutar moje klase
            this.Prezime = prezime;
        }

        public Osoba(string naziv, bool prezime)
        {
            if (prezime) //prezime == true
            {
                Prezime = naziv;
            }
            else
            {
                Ime = naziv;
            }
        }
    }
}
