using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Biblioteka;
using Sesija;

namespace SistemskeOperacije.PutnikSO
{
    public class ZapamtiPutnika : OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
           
            return Broker.dajSesiju().izmeni(odo);
        }
    }
}
