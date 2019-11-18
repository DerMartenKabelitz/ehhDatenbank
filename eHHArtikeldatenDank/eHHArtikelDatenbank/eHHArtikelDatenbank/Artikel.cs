using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHHArtikelDatenbank
{
    public class Artikel
    {
        public string Artikelnummer { get; set; }
        public string Bezeichnung { get; set; }
        public string Preis { get; set; }

        public Artikel(string artikelnummer, string bezeichnung, string preis)
        {
            Artikelnummer = artikelnummer;
            Bezeichnung = bezeichnung;
            Preis = preis;
        }

        public Artikel()
        {

        }
    }
}
