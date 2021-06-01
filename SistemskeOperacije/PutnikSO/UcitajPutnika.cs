using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Biblioteka;
using Sesija;

namespace SistemskeOperacije.PutnikSO
{
    public class UcitajPutnika : OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            Biblioteka.Putnik p = odo as Biblioteka.Putnik;
           
            return p;
        }
    }
}
