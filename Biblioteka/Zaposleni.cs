using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;

namespace Biblioteka
{
    [Serializable]
    public class Zaposleni:OpstiDomenskiObjekat
    {
        #region Atributi
        public override string ToString()
        {
            return Ime+" "+Prezime;
        }

       

        int zaposleniID;
        string ime;
        string prezime;
        string korisnickaSifra;
        string korisnickoIme;

        public int ZaposleniID { get => zaposleniID; set => zaposleniID = value; }
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string KorisnickaSifra { get => korisnickaSifra; set => korisnickaSifra = value; }
        public string KorisnickoIme { get => korisnickoIme; set => korisnickoIme = value; }

        #endregion
        #region ODO
        [Browsable(false)]
        public string tabela => "Zaposleni";
        [Browsable(false)]
        public string kljuc => "ZaposleniID";
        [Browsable(false)]
        public string uslovJedan => "ZaposleniID="+zaposleniID;
        [Browsable(false)]
        public string USLOV = "";
        [Browsable(false)]
        public string uslovVise => USLOV;
        [Browsable(false)]
        public string azuriranje => null;
        [Browsable(false)]
        public string upisivanje => null;
        public OpstiDomenskiObjekat napuni(DataRow red)
        {
            Zaposleni z = new Zaposleni();

            z.ZaposleniID = Convert.ToInt32(red["ZaposleniID"]);
            z.Ime = red["Ime"].ToString();
            z.Prezime = red["Prezime"].ToString();
            z.KorisnickaSifra = red["KorisnickaSifra"].ToString();
            z.KorisnickoIme = red["KorisnickoIme"].ToString();

            return z;
        }
        #endregion
    }
}
