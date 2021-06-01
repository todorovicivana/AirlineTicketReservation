using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;

namespace Biblioteka
{
    [Serializable]
    public class Let:OpstiDomenskiObjekat
    {
        public override string ToString()
        {
          
            return nazivLeta;
        }

        int letID;
        DateTime vremePolaska;
        DateTime vremeDolaska;
        TimeSpan trajanjeLeta;
        string klasa;
        int brRaspolozivihMesta;
        string nazivLeta;

        public int LetID { get => letID; set => letID = value; }
        public DateTime VremePolaska { get => vremePolaska; set => vremePolaska = value; }
        public DateTime VremeDolaska { get => vremeDolaska; set => vremeDolaska = value; }
        public TimeSpan TrajanjeLeta { get => trajanjeLeta; set => trajanjeLeta = value; }
        public string Klasa { get => klasa; set => klasa = value; }
        public int BrRaspolozivihMesta { get => brRaspolozivihMesta; set => brRaspolozivihMesta = value; }
        public string NazivLeta { get => nazivLeta; set => nazivLeta = value; }

        #region ODO
        [Browsable(false)]
        public string tabela => "Let";
        [Browsable(false)]
        public string kljuc => "LetID";
        [Browsable(false)]
        public string uslovJedan => "LetID=" + LetID;
        [Browsable(false)]
        public string USLOV = "";
        [Browsable(false)]
        public string uslovVise => USLOV;
        [Browsable(false)]
        public string azuriranje => "BrojRaspolozivihMesta="+brRaspolozivihMesta;
        [Browsable(false)]
        public string upisivanje => null;

       

        public OpstiDomenskiObjekat napuni(DataRow red)
        {
            Let l = new Let();

            l.LetID = Convert.ToInt32(red["LetID"]);
            l.Klasa = red["Klasa"].ToString();
            l.brRaspolozivihMesta = Convert.ToInt32(red["BrojRaspolozivihMesta"]);
            l.VremePolaska = Convert.ToDateTime(red["VremePolaska"]);
            l.NazivLeta = red["NazivLeta"].ToString();

            return l;
        }
        #endregion
    }
}
