using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Biblioteka;
using Sesija;

namespace SistemskeOperacije.RezervacijaSO
{
    public class KreirajRezervaciju : OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            Rezervacija r = odo as Rezervacija;
            r.RezervacijaID = Broker.dajSesiju().dajSifru(r);
            Broker.dajSesiju().sacuvaj(r);
            return r;
        }
    }
}
