﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Biblioteka;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sesija
{
    public class Broker
    {
        SqlConnection konekcija;
        SqlTransaction transakcija;


        public static Broker instanca;

        public static Broker dajSesiju() 
        {
            if (instanca == null)
            {
                instanca = new Broker();
            }
            return instanca;
        }

        public void otvoriKonekciju()
        {
            try
            {
                konekcija = new SqlConnection(@"Data Source=DESKTOP-S2KSRJO\SQLEXPRESS;Initial Catalog=RezervacijaAvioKarataBaza;Integrated Security=True");
                konekcija.Open();
            }
            catch (Exception)
            {

                MessageBox.Show("Neuspesna konekcija!");
            }
        }

        public void zatvoriKonekciju()
        {
            try
            {

                konekcija.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Nije moguce zatvoriti konekciju!");
            }
        }

        public void zapocniTransakciju()
        {
            try
            {
                transakcija = konekcija.BeginTransaction();
            }
            catch (Exception)
            {

                MessageBox.Show("Neuspesna transakcija!");
            }
        }

        public void ponistiTransakciju()
        {
            try
            {
                transakcija.Rollback();
            }
            catch (Exception)
            {

                MessageBox.Show("Neuspesno ponistavanje!");
            }
        }

        public void potvrdiTransakciju()
        {
            try
            {
                transakcija.Commit();
            }
            catch (Exception)
            {

                MessageBox.Show("Neuspesna potvrda transakcije!");
            }
        }


        public List<OpstiDomenskiObjekat> dajSve(OpstiDomenskiObjekat odo)
        {
            string upit = "SELECT * FROM " + odo.tabela;
            SqlDataReader citac = null;
            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);
            try
            {
                citac = komanda.ExecuteReader();
                DataTable tabela = new DataTable();
                tabela.Load(citac);
                List<OpstiDomenskiObjekat> lista = new List<OpstiDomenskiObjekat>();
                foreach (DataRow red in tabela.Rows)
                {
                    OpstiDomenskiObjekat pom = odo.napuni(red);
                    lista.Add(pom);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u radu sa bazom!");
            }
            finally
            {
                if (citac != null)
                {
                    citac.Close();
                }
            }
        }

        public List<OpstiDomenskiObjekat> dajSveZaUslovVise(OpstiDomenskiObjekat odo)
        {
            string upit = "SELECT * FROM " + odo.tabela + " WHERE " + odo.uslovVise;
            SqlDataReader citac = null;
            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);
            try
            {
                citac = komanda.ExecuteReader();
                DataTable tabela = new DataTable();
                tabela.Load(citac);
                List<OpstiDomenskiObjekat> lista = new List<OpstiDomenskiObjekat>();
                foreach (DataRow red in tabela.Rows)
                {
                    OpstiDomenskiObjekat pom = odo.napuni(red);
                    lista.Add(pom);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u radu sa bazom!");
            }
            finally
            {
                if (citac != null)
                {
                    citac.Close();
                }
            }
        }


       
        public OpstiDomenskiObjekat dajZaUslovJedan(OpstiDomenskiObjekat odo)
        {
            string upitniString = "SELECT * FROM " + odo.tabela + " WHERE " + odo.uslovJedan;
            SqlDataReader reader = null;
            SqlCommand komanda = new SqlCommand(upitniString, konekcija, transakcija);
            try
            {
                reader = komanda.ExecuteReader();
                DataTable tabela = new DataTable();
                tabela.Load(reader);
                DataRow red;
                if (tabela.Rows.Count == 0)
                {
                    return null;
                }
                else
                {
                    red = tabela.Rows[0];
                }
                return odo.napuni(red);
            }
            catch (Exception)
            {
                throw new Exception("Greska u radu sa bazom!");
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }
        }

        public OpstiDomenskiObjekat dajZaUslovVise(OpstiDomenskiObjekat odo)
        {
            string upitniString = "SELECT * FROM " + odo.tabela + " WHERE " + odo.uslovVise;
            ;
            SqlDataReader reader = null;
            SqlCommand komanda = new SqlCommand(upitniString, konekcija, transakcija);
            try
            {
                reader = komanda.ExecuteReader();
                DataTable tabela = new DataTable();
                tabela.Load(reader);
                DataRow red;
                if (tabela.Rows.Count == 0)
                {
                    return null;
                }
                else
                {
                    red = tabela.Rows[0];
                }
                return odo.napuni(red);
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u radu sa bazom!");
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }
        }

        public int izmeni(OpstiDomenskiObjekat odo)
        {
            string upit = "UPDATE " + odo.tabela + " SET " + odo.azuriranje + " WHERE " + odo.uslovJedan;
            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);
            try
            {
                return komanda.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Greska u radu sa bazom!");
            }
        }

        public int sacuvaj(OpstiDomenskiObjekat odo)
        {
            string upit = "INSERT INTO " + odo.tabela + " " + odo.upisivanje;
            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);
            try
            {
                return komanda.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Greska u radu sa bazom!");
            }
        }

        public int obrisi(OpstiDomenskiObjekat odo)
        {
            string upit = "DELETE FROM " + odo.tabela + " WHERE " + odo.uslovJedan;
            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);
            try
            {
                return komanda.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Greska u radu sa bazom!");
            }
        }

        public int obrisiZaUslovVise(OpstiDomenskiObjekat odo)
        {
            string upit = "DELETE FROM " + odo.tabela + " WHERE " + odo.uslovVise;
            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);
            try
            {
                return komanda.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Greska u radu sa bazom!");
            }
        }

        public int dajSifru(OpstiDomenskiObjekat odo)
        {
            string upit = "SELECT MAX(" + odo.kljuc + ") FROM " + odo.tabela;
            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);
            try
            {
                Object o = komanda.ExecuteScalar();
                if (o == DBNull.Value) return 1;
                else return Convert.ToInt32(o) + 1;
               
            }
            catch (Exception)
            {
                throw;
            }
        }
           
    }
}
