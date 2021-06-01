using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Biblioteka;
using Sesija;

namespace SistemskeOperacije.RezervacijaSO
{
    public class ZapamtiRezervaciju : OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            Rezervacija r = odo as Rezervacija;
            Broker.dajSesiju().izmeni(r);

            StavkaRezervacije s = new StavkaRezervacije();
            s.USLOV = " RezervacijaID =" + r.RezervacijaID;
            Broker.dajSesiju().obrisiZaUslovVise(s);

            foreach (StavkaRezervacije st in r.ListaStavki)
            {
                st.RezervacijaID = r.RezervacijaID;
                Broker.dajSesiju().sacuvaj(st);
                Let l = Broker.dajSesiju().dajZaUslovJedan(st.Let) as Let;
                l.BrRaspolozivihMesta--;
                Broker.dajSesiju().izmeni(l);
            }

            return true;
        }
    }
}
