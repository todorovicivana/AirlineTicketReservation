using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using Biblioteka;
using Sesija;
using System.Threading;
using SistemskeOperacije.Zaposleni;
using SistemskeOperacije.PutnikSO;
using SistemskeOperacije.RezervacijaSO;

namespace Server
{
    public class Obrada
    {
        BinaryFormatter formater;
        NetworkStream tok;

        public Obrada(NetworkStream tok)
        {
            this.tok = tok;
            formater = new BinaryFormatter();

            ThreadStart ts = obradiKlijenta;
            Thread nit = new Thread(ts);
            nit.Start();
        }

        public void obradiKlijenta() 
        {
            try
            {
                int operacija = 0;
                while (operacija != (int)Operacije.Kraj)
                {
                    TransferKlasa transfer = formater.Deserialize(tok) as TransferKlasa;
                    switch (transfer.Operacija)
                    {
                        case Operacije.NadjiZaposlenog:
                            NadjiZaposlenog nz = new NadjiZaposlenog();
                            transfer.Rezultat = nz.izvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;



                        case Operacije.ZapamtiPutnika:
                            ZapamtiPutnika zp = new ZapamtiPutnika();
                            transfer.Rezultat = zp.izvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.KreirajPutnika:
                            KreirajPutnika kp = new KreirajPutnika();
                            transfer.Rezultat = kp.izvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.ObrisiPutnika:
                            ObrisiPutnika op = new ObrisiPutnika();
                            transfer.Rezultat = op.izvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.PretraziPutnike:
                            PretraziPutnike ppe = new PretraziPutnike();
                            transfer.Rezultat = ppe.izvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.UcitajPutnika:
                            UcitajPutnika up = new UcitajPutnika();
                            transfer.Rezultat = up.izvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.UcitajListuPutnika:
                            UcitajListuPutnika ulp = new UcitajListuPutnika();
                            transfer.Rezultat = ulp.izvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.UcitajListuLetova:
                            UcitajListuLetova uli = new UcitajListuLetova();
                            transfer.Rezultat = uli.izvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.KreirajRezervaciju:
                            KreirajRezervaciju kre = new KreirajRezervaciju();
                            transfer.Rezultat = kre.izvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.ZapamtiRezervaciju:
                            ZapamtiRezervaciju zre = new ZapamtiRezervaciju();
                            transfer.Rezultat = zre.izvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.PretraziRezervacije:
                            PretraziRezervacije pre = new PretraziRezervacije();
                            transfer.Rezultat = pre.izvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.UcitajRezervaciju:
                            UcitajRezervaciju ure = new UcitajRezervaciju();
                            transfer.Rezultat = ure.izvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.ObrisiRezervaciju:
                            ObrisiRezervaciju ore = new ObrisiRezervaciju();
                            transfer.Rezultat = ore.izvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;



                        case Operacije.Kraj:
                            operacija = 1;
                            Server.listaTokova.Remove(tok);
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (Exception)
            {

                try
                {
                    Server.listaTokova.Remove(tok);
                }
                catch (Exception)
                {

                   
                }
            }
        }
    }
}
