using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace dobi
{
    internal class Magazyn
    {
        //Uzylem public aby zmienne mogly byc dostepne wszedzie
        public List<Produkt> produkty;
        public Adres adres;

        public Magazyn(List<Produkt> produkty, Adres adres)
        {
            this.produkty = produkty ?? new List<Produkt>();
            this.adres = adres;
        }
    }
}
