using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Biblioteka;

namespace SistemskeOperacije.PutnikSO
{
    public class ObrisiPutnika : OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            return Sesija.Broker.dajSesiju().obrisi(odo);
        }
    }
}
