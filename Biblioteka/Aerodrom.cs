using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;

namespace Biblioteka
{
    [Serializable]
    public class Aerodrom:OpstiDomenskiObjekat
    {
        #region Atributi
        public override string ToString()
        {
            return nazivAerodroma;
        }

        int aerodromID;
        string nazivAerodroma;
        string nazivMesta;

        public int AerodromID { get => aerodromID; set => aerodromID = value; }
        public string NazivAerodroma { get => nazivAerodroma; set => nazivAerodroma = value; }
        public string NazivMesta { get => nazivMesta; set => nazivMesta = value; }
        #endregion

        #region ODO
        [Browsable(false)]
        public string tabela => "Aerodrom";
        [Browsable(false)]
        public string kljuc => "AerodromID";
        [Browsable(false)]
        public string uslovJedan => "AerodromID=" + aerodromID;
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
            Aerodrom a = new Aerodrom();

            a.AerodromID= Convert.ToInt32(red["AerodromID"]);
            a.NazivAerodroma= red["NazivAerodroma"].ToString();
            a.NazivMesta = red["NazivMesta"].ToString();
          
            return a;
        }
        #endregion
    }
}
