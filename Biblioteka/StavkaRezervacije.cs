using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;

namespace Biblioteka
{
    [Serializable]
    public class StavkaRezervacije:OpstiDomenskiObjekat
    {
        int rezervacijaID;
        int redniBroj;
        double cena;
        Let let;

        [Browsable(false)]
        public int RezervacijaID { get => rezervacijaID; set => rezervacijaID = value; }
        public int RedniBroj { get => redniBroj; set => redniBroj = value; }
        public Let Let { get => let; set => let = value; }
        public double Cena { get => cena; set => cena = value; }
      


        #region ODO
        [Browsable(false)]
        public string tabela => "StavkaRezervacije";
        [Browsable(false)]
        public string kljuc => "";
        [Browsable(false)]
        public string uslovJedan => "";
        [Browsable(false)]
        public string USLOV = "";
        [Browsable(false)]
        public string uslovVise => USLOV;
        [Browsable(false)]
        public string azuriranje => "";
        [Browsable(false)]
        public string upisivanje => " values (" + RezervacijaID + ","+redniBroj+"," + cena + "," + Let.LetID + ")";


        public OpstiDomenskiObjekat napuni(DataRow red)
        {
            StavkaRezervacije s = new StavkaRezervacije();

            s.RezervacijaID = Convert.ToInt32(red["RezervacijaID"]);
            s.RedniBroj = Convert.ToInt32(red["RedniBroj"]);
            s.Cena =Convert.ToDouble( red["Cena"]);            
            s.Let = new Let();
            s.Let.LetID = Convert.ToInt32(red["LetID"]);

            return s;
        }
        #endregion
    }
}
