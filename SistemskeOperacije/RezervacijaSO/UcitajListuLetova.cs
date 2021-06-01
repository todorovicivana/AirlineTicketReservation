using Biblioteka;
using Sesija;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemskeOperacije.RezervacijaSO
{
    public class UcitajListuLetova:OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            return Broker.dajSesiju().dajSve(odo).OfType<Biblioteka.Let>().ToList<Biblioteka.Let>();
        }
    }
}
