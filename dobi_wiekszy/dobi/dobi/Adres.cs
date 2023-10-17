using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dobi
{
    internal class Adres
    {
        //Uzylem public aby zmienne mogly byc dostepne wszedzie
        public string ulica;
        public string kodPocztowy;
        public string miejscowosc;
        public string numerPosesji;
        public string numerLokalu;

        public Adres(string ulica, string kodPocztowy, string miejscowosc, string numerPosesji, string numerLokalu)
        {
            //przypisanie wartosci do zmiennych
            this.ulica = ulica;
            this.kodPocztowy = kodPocztowy;
            this.miejscowosc = miejscowosc;
            this.numerPosesji = numerPosesji;
            this.numerLokalu = numerLokalu;

        }
    }
}
