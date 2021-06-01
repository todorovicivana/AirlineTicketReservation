using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Biblioteka;
using Sesija;

namespace SistemskeOperacije.RezervacijaSO
{
    public class UcitajListuPutnika : OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            return Broker.dajSesiju().dajSve(odo).OfType<Biblioteka.Putnik>().ToList<Biblioteka.Putnik>();
        }
    }
}
