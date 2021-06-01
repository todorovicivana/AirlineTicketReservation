using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Biblioteka;
using Sesija;

namespace SistemskeOperacije.PutnikSO
{
    public class PretraziPutnike : OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            return Broker.dajSesiju().dajSveZaUslovVise(odo).OfType<Biblioteka.Putnik>().ToList<Biblioteka.Putnik>();
        }
    }
}
