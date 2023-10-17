using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dobi
{
    internal class Produkt
    {

        //Uzylem public aby zmienne mogly byc dostepne wszedzie
        public string producent;
        public string produkt;
        public string kategoria;
        public int kod;
        public int cena; //cena w groszach
        public string opis;

        public Produkt(string producent, string produkt, string kategoria, int kod, int cena, string opis)
        {
            //przypisanie wartosci do zmiennych
            this.producent = producent;
            this.produkt = produkt;
            this.kategoria = kategoria;
            this.kod = kod;
            this.cena = cena;
            this.opis = opis;

        }
    }
}

