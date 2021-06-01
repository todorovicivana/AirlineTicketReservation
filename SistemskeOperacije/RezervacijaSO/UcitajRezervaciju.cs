using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Biblioteka;
using Sesija;

namespace SistemskeOperacije.RezervacijaSO
{
    public class UcitajRezervaciju : OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            Rezervacija r = odo as Rezervacija;
            r.Putnik = Broker.dajSesiju().dajZaUslovJedan(r.Putnik) as Biblioteka.Putnik;
            r.Zaposleni = Broker.dajSesiju().dajZaUslovJedan(r.Zaposleni) as Biblioteka.Zaposleni;

            StavkaRezervacije s = new StavkaRezervacije();
            s.USLOV = " RezervacijaID =" + r.RezervacijaID;

            List<StavkaRezervacije> lista = Broker.dajSesiju().dajSveZaUslovVise(s).OfType<StavkaRezervacije>().ToList<StavkaRezervacije>();

            foreach (StavkaRezervacije st in lista)
            {
                st.Let = Broker.dajSesiju().dajZaUslovJedan(st.Let) as Let;
                r.ListaStavki.Add(st);
            }

            return r;
        }
    }
}
