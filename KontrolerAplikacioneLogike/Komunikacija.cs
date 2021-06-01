using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.Net.Sockets;
using Biblioteka;

namespace Komunikacija
{
    public class Komunikacija
    {
        TcpClient klijent;
        BinaryFormatter formater;
        NetworkStream tok;

        public bool poveziSeNaServer()
        {
            try
            {
                klijent = new TcpClient("127.0.0.1", 20000);
                tok = klijent.GetStream();
                formater = new BinaryFormatter();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }


        public void kraj() 
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.Kraj;
            formater.Serialize(tok, transfer);
        }

        public Object NadjiZaposlenog(Zaposleni z)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.NadjiZaposlenog;
            transfer.TransferObjekat = z;
            formater.Serialize(tok, transfer);

            return (formater.Deserialize(tok) as TransferKlasa).Rezultat;
        }

        public Object ZapamtiPutnika(Putnik p)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.ZapamtiPutnika;
            transfer.TransferObjekat = p;
            formater.Serialize(tok, transfer);

            return (formater.Deserialize(tok) as TransferKlasa).Rezultat;
        }

        public Object KreirajPutnika(Putnik p)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.KreirajPutnika;
            transfer.TransferObjekat = p;
            formater.Serialize(tok, transfer);

            return (formater.Deserialize(tok) as TransferKlasa).Rezultat;
        }



        public Object PretraziPutnike(Putnik p)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.PretraziPutnike;
            transfer.TransferObjekat = p;
            formater.Serialize(tok, transfer);

            return (formater.Deserialize(tok) as TransferKlasa).Rezultat;
        }

        public Object UcitajPutnika(Putnik p)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.UcitajPutnika;
            transfer.TransferObjekat = p;
            formater.Serialize(tok, transfer);

            return (formater.Deserialize(tok) as TransferKlasa).Rezultat;
        }

        public Object ObrisiPutnika(Putnik p)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.ObrisiPutnika;
            transfer.TransferObjekat = p;
            formater.Serialize(tok, transfer);

            return (formater.Deserialize(tok) as TransferKlasa).Rezultat;
        }

        public Object UcitajListuPutnika()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.UcitajListuPutnika;
            transfer.TransferObjekat = new Putnik();
            formater.Serialize(tok, transfer);

            return (formater.Deserialize(tok) as TransferKlasa).Rezultat;
        }

        public Object UcitajListuLetova()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.UcitajListuLetova;
            transfer.TransferObjekat = new Let();
            formater.Serialize(tok, transfer);

            return (formater.Deserialize(tok) as TransferKlasa).Rezultat;
        }

        public Object KreirajRezervaciju()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.KreirajRezervaciju;
            transfer.TransferObjekat = new Rezervacija();
            formater.Serialize(tok, transfer);

            return (formater.Deserialize(tok) as TransferKlasa).Rezultat;
        }

        public Object ZapamtiRezervaciju(Rezervacija p)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.ZapamtiRezervaciju;
            transfer.TransferObjekat = p;
            formater.Serialize(tok, transfer);

            return (formater.Deserialize(tok) as TransferKlasa).Rezultat;
        }

        public Object PretraziRezervacije(Rezervacija p)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.PretraziRezervacije;
            transfer.TransferObjekat = p;
            formater.Serialize(tok, transfer);

            return (formater.Deserialize(tok) as TransferKlasa).Rezultat;
        }

        public Object UcitajRezervaciju(Rezervacija p)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.UcitajRezervaciju;
            transfer.TransferObjekat = p;
            formater.Serialize(tok, transfer);

            return (formater.Deserialize(tok) as TransferKlasa).Rezultat;
        }

        public Object ObrisiRezervaciju(Rezervacija p)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.ObrisiRezervaciju;
            transfer.TransferObjekat = p;
            formater.Serialize(tok, transfer);

            return (formater.Deserialize(tok) as TransferKlasa).Rezultat;
        }

    }
}
