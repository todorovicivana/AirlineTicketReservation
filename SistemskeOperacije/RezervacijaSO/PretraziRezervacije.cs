using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Biblioteka;
using Sesija;

namespace SistemskeOperacije.RezervacijaSO
{
    public class PretraziRezervacije : OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            Rezervacija r = new Rezervacija();
            r.USLOV = " UkupnaCena is null";
            Broker.dajSesiju().obrisiZaUslovVise(r);
            return Broker.dajSesiju().dajSveZaUslovVise(odo).OfType<Rezervacija>().ToList<Rezervacija>();
        }
    }
}
