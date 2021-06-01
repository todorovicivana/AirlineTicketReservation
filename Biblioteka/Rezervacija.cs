using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;

namespace Biblioteka
{
    [Serializable]
    public class Rezervacija : OpstiDomenskiObjekat
    {
        int rezervacijaID;
        DateTime datumIsticanja;
        double ukupnaCena;
        Putnik putnik;
        Zaposleni zaposleni;
        BindingList<StavkaRezervacije> listaStavki;

        public int RezervacijaID { get => rezervacijaID; set => rezervacijaID = value; }
        public DateTime DatumIsticanja { get => datumIsticanja; set => datumIsticanja = value; }
        public double UkupnaCena { get => ukupnaCena; set => ukupnaCena = value; }
        [Browsable(false)]
        public Putnik Putnik { get => putnik; set => putnik = value; }
        [Browsable(false)]
        public Zaposleni Zaposleni { get => zaposleni; set => zaposleni = value; }
        public BindingList<StavkaRezervacije> ListaStavki { get => listaStavki; set => listaStavki = value; }

        public Rezervacija()
        {
            listaStavki = new BindingList<StavkaRezervacije>();
        }


        #region ODO
        [Browsable(false)]
        public string tabela => "Rezervacija";
        [Browsable(false)]
        public string kljuc => "RezervacijaID";
        [Browsable(false)]
        public string uslovJedan => "RezervacijaID=" + RezervacijaID;
        [Browsable(false)]
        public string USLOV = "";
        [Browsable(false)]
        public string uslovVise => USLOV;
        [Browsable(false)]
        public string azuriranje => "DatumIsticanja='" + datumIsticanja.ToString("yyyy-MM-dd HH:mm:ss") + "', UkupnaCena="+ukupnaCena+", PutnikID='"+putnik.JmbgPutnika+"', ZaposleniID="+zaposleni.ZaposleniID+"";
        [Browsable(false)]
        public string upisivanje => "(RezervacijaID) values (" + RezervacijaID + ")";
        public OpstiDomenskiObjekat napuni(DataRow red)
        {
            Rezervacija r = new Rezervacija();

            r.rezervacijaID = Convert.ToInt32(red["RezervacijaID"]);
            r.datumIsticanja = Convert.ToDateTime(red["DatumIsticanja"]);
            r.ukupnaCena = Convert.ToDouble(red["UkupnaCena"]);
            r.Putnik = new Putnik();
            r.putnik.JmbgPutnika = red["PutnikID"].ToString();
            r.Zaposleni = new Zaposleni();
            r.zaposleni.ZaposleniID = Convert.ToInt32(red["ZaposleniID"]);


            return r;
        }
        #endregion

    }
}
