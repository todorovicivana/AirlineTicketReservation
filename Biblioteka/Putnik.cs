using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;

namespace Biblioteka
{
    [Serializable]
    public class Putnik:OpstiDomenskiObjekat
    {
        #region Atributi

        public override string ToString()
        {
            return ime+" "+prezime;
        }

        string jmbgPutnika;
        string ime;
        string prezime;
        string brojPasosa;
        string kontaktTelefon;
      

        
        public string JmbgPutnika { get => jmbgPutnika; set => jmbgPutnika = value; }
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string BrojPasosa { get => brojPasosa; set => brojPasosa = value; }       
        public string KontaktTelefon { get => kontaktTelefon; set => kontaktTelefon = value; }
        
        #endregion

        #region ODO
        [Browsable(false)]
        public string tabela => "Putnik";
        [Browsable(false)]
        public string kljuc => "JMBGPutnika";
        [Browsable(false)]
        public string uslovJedan => "JMBGPutnika='" + jmbgPutnika+"'";
        [Browsable(false)]
        public string USLOV = "";
        [Browsable(false)]
        public string uslovVise => USLOV;
        [Browsable(false)]
        public string azuriranje => "Ime='" + Ime + "', Prezime='" + Prezime + "', BrojPasosa='" + BrojPasosa + "', KontakTelefon='"+KontaktTelefon+"'";
        [Browsable(false)]
        public string upisivanje => " values ('"+jmbgPutnika+"','"+ime+"','"+prezime+"','"+brojPasosa+"','"+kontaktTelefon+"')";
        public OpstiDomenskiObjekat napuni(DataRow red)
        {
            Putnik p = new Putnik();

            p.JmbgPutnika = red["JMBGPutnika"].ToString();
            p.Ime = red["Ime"].ToString();
            p.Prezime = red["Prezime"].ToString();
            p.BrojPasosa = red["BrojPasosa"].ToString();
            p.KontaktTelefon = red["KontakTelefon"].ToString();

            return p;
        }
        #endregion
    }
}
