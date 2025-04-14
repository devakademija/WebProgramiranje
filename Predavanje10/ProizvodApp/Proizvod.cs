using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProizvodApp
{
    internal class Proizvod
    {
        //svojstva
        public string Naziv { get; set; }
        public double Cijena { get; set; }
        public double Marza { get; set; }
        public double Porez { get; set; }

        //metoda

        public double MPC()
        {
            return Cijena + Marza + Porez;
        }

    }
}
