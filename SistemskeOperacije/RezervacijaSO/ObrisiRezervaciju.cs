using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Biblioteka;
using Sesija;

namespace SistemskeOperacije.RezervacijaSO
{
    public class ObrisiRezervaciju : OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            Rezervacija r = odo as Rezervacija;
            Broker.dajSesiju().obrisi(odo);
            foreach (StavkaRezervacije st in r.ListaStavki)
            {               
                Let l = Broker.dajSesiju().dajZaUslovJedan(st.Let) as Let;
                l.BrRaspolozivihMesta++;
                Broker.dajSesiju().izmeni(l);
            }
            return true;
        }
    }
}
