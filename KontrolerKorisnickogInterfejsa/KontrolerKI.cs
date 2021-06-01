using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Komunikacija;
using Biblioteka;
using System.Windows.Forms;


namespace KontrolerKorisnickogInterfejsa
{
    public class KontrolerKI
    {
        public static Komunikacija.Komunikacija komunikacija;
        public static Zaposleni zaposleni;
        public static Putnik putnik;
        public static Let let;
        public static Rezervacija rezervacija;

        public static bool poveziSeNaServer()
        {
            komunikacija = new Komunikacija.Komunikacija();
            return komunikacija.poveziSeNaServer();
        }

        public static bool ObrisiRezervaciju()
        {
            object rez = komunikacija.ObrisiRezervaciju(rezervacija);

            if (rez == null)
            {
                MessageBox.Show("Sistem ne moze da obrise rezervaciju!");
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je obrisao rezervaciju!");
                return true;
            }
        }

        public static void popuniPoljaRezervacija(DateTimePicker dtpDatum, ComboBox cmbLet, ComboBox cmbPutnik, TextBox txtCena, TextBox txtUkupno, DataGridView dgvGrid)
        {
            dtpDatum.Value = rezervacija.DatumIsticanja;
            popuniComboLet(cmbLet);
            popuniComboPutnik(cmbPutnik);
            cmbPutnik.Text = rezervacija.Putnik.ToString();
            txtCena.Text = "0.00";
            txtUkupno.Text = rezervacija.UkupnaCena.ToString("N02");
            dgvGrid.DataSource = rezervacija.ListaStavki;
        }

        public static void popuniVremePolaska(ComboBox cmbLet, Label lblVreme)
        {
            try
            {
                Let l = cmbLet.SelectedItem as Let;
                lblVreme.Text = " Vreme polaska: " + l.VremePolaska.ToString("dd-MMM-yy HH:mm");
            }
            catch (Exception)
            {

                
            }
        }

        public static void PopuniPoljaPutnik(TextBox txtJMBG, TextBox txtPasos, TextBox txtIme, TextBox txtPrezime, TextBox txtTelefon)
        {
            txtIme.Text = putnik.Ime;
            txtJMBG.Text = putnik.JmbgPutnika;
            txtPasos.Text = putnik.BrojPasosa;
            txtPrezime.Text = putnik.Prezime;
            txtTelefon.Text = putnik.KontaktTelefon;
        }

        public static bool UcitajRezervaciju(DataGridView dataGridView1)
        {
            try
            {
                rezervacija = dataGridView1.CurrentRow.DataBoundItem as Rezervacija;

                rezervacija = komunikacija.UcitajRezervaciju(rezervacija) as Rezervacija;

                if (rezervacija == null)
                {
                    MessageBox.Show("Sistem ne moze da prikaze podatke o odabranoj rezervaciji!");
                    return false;
                }
                else
                {
                    MessageBox.Show("Odabrana rezervacija je prikazana!");
                    return true;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Niste odabrali rezervaciju!");
                return false;
            }
        }

        public static void PretraziRezervacije(ComboBox cmbPutnik, DataGridView dataGridView1)
        {
            rezervacija = new Rezervacija();
            rezervacija.Putnik = cmbPutnik.SelectedItem as Putnik;
            if (rezervacija.Putnik == null)
            {
                MessageBox.Show("Niste odabrali putnika!");
                return;
            }

            rezervacija.USLOV = " PutnikID= '" + rezervacija.Putnik.JmbgPutnika + "'";

            dataGridView1.DataSource = komunikacija.PretraziRezervacije(rezervacija);

            List<Rezervacija> lista = komunikacija.PretraziRezervacije(rezervacija) as List<Rezervacija>;
            if (lista == null || lista.Count == 0)
            {
                MessageBox.Show("Sistem ne moze da nadje rezervacije po zadatoj vrednosti!");
            }
            else
            {
                MessageBox.Show("Sistem je nasao rezervacije po zadatoj vrednosti!");
            }
        }

        public static bool ObrisiPutnika()
        {
            object rez = komunikacija.ObrisiPutnika(putnik);

            if (rez != null)
            {
                MessageBox.Show("Sistem je obrisao putnika!");
                return true;
            }
            else
            {
                MessageBox.Show("Sistem ne moze da obrise putnika!");
                return false;
            }
        }

        public static string PrikaziZaposlenog()
        {
            return "Zaposleni: " + zaposleni.ToString() + ", Vreme prijave: " + DateTime.Now.ToString("hh:mm tt");
        }

        public static void PretraziPutnike(TextBox txtFilter, DataGridView dataGridView1)
        {
            putnik = new Putnik();

            putnik.USLOV = "Ime like '"+txtFilter.Text+ "%' or Prezime like '" + txtFilter.Text + "%' or BrojPasosa like '" + txtFilter.Text + "%' or KontakTelefon like '" + txtFilter.Text + "%' or JMBGPutnika like '" + txtFilter.Text + "%'";

            //List<Putnik> lista = komunikacija.PretraziPutnike(putnik) as List<Putnik>;
            //if (lista == null || lista.Count == 0)
            //{
            //    MessageBox.Show("Sistem ne moze da nadje putnike po zadatoj vrednosti!");
            //}
            //else
            //{
            //    MessageBox.Show("Sistem je nasao putnike po zadatoj vrednosti!");
            //}

            dataGridView1.DataSource = komunikacija.PretraziPutnike(putnik);
        }

        public static bool UcitajPutnika(DataGridView dataGridView1)
        {
            try
            {
                putnik = dataGridView1.CurrentRow.DataBoundItem as Putnik;

                putnik = komunikacija.UcitajPutnika(putnik) as Putnik;

                if (putnik == null)
                {
                    MessageBox.Show("Sistem ne moze da prikaze podatke o odabranom putniku!");
                    return false;
                }
                else
                {
                    MessageBox.Show("Odabrani putnik je prikazan!");
                    return true;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Niste odabrali putnika za prikaz!");
                return false;
            }
        }

        public static void KreirajRezervaciju(TextBox txtID, Button btnKreiraj, GroupBox gbRezervacija, ComboBox cmbPutnik, ComboBox cmbLet, DataGridView dgvGrid)
        {
            rezervacija = komunikacija.KreirajRezervaciju() as Rezervacija;
            if (rezervacija == null)
            {
                MessageBox.Show("Sistem ne moze da kreira novu rezervaciju!");
            }
            else
            {
                txtID.Text = rezervacija.RezervacijaID.ToString();
                gbRezervacija.Enabled = true;
                btnKreiraj.Enabled = false;
                dgvGrid.DataSource = rezervacija.ListaStavki;
                popuniComboLet(cmbLet);
                popuniComboPutnik(cmbPutnik);
                rezervacija.Zaposleni = zaposleni;
                MessageBox.Show("Sistem je kreirao novu rezervaciju!");
            }
        }

        public static bool SacuvajRezervaciju(DateTimePicker dtpDatum, ComboBox cmbPutnik)
        {
            try
            {
                rezervacija.DatumIsticanja =dtpDatum.Value;
            }
            catch (Exception)
            {

                MessageBox.Show("Datum nije ispravno unet!");
                return false;
            }

            if (rezervacija.DatumIsticanja.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Rezervacija mora biti u buducnosti!");
                return false;
            }

            rezervacija.Putnik = cmbPutnik.SelectedItem as Putnik;
            if (rezervacija.Putnik == null)
            {
                MessageBox.Show("Niste odabrali putnika!");
                return false;
            }

            if(rezervacija.ListaStavki.Count<1)
            {
                MessageBox.Show("Unesite barem jednu stavku!");
                return false;
            }

            object rez = komunikacija.ZapamtiRezervaciju(rezervacija);

            if (rez == null)
            {
                MessageBox.Show("Sistem ne moze da zapamti rezervaciju!");
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je zapamtio rezervaciju!");
                return true;
            }
        }

        public static void ObrisiStavku(DataGridView dgvGrid,TextBox txtUkupno)
        {
            try
            {
                StavkaRezervacije s = dgvGrid.CurrentRow.DataBoundItem as StavkaRezervacije;
                rezervacija.ListaStavki.Remove(s);

                int i = 1;
                foreach (StavkaRezervacije st in rezervacija.ListaStavki)
                {
                    st.RedniBroj = i;
                    i++;
                }

                rezervacija.UkupnaCena -= s.Cena;
                txtUkupno.Text = rezervacija.UkupnaCena.ToString("N02");
            }
            catch (Exception)
            {

                MessageBox.Show("Niste odabrali stavku za brisanje!");
            }
        }

        public static void DodajStavku(ComboBox cmbLet, TextBox txtCena, TextBox txtUkupno)
        {
            StavkaRezervacije st = new StavkaRezervacije();
            st.RezervacijaID = rezervacija.RezervacijaID;
            st.RedniBroj = rezervacija.ListaStavki.Count + 1;
            st.Let = cmbLet.SelectedItem as Let;
            if (st.Let == null)
            {
                MessageBox.Show("Niste odabrali let!");
                return;
            }

            if (st.Let.BrRaspolozivihMesta < 1)
            {
                MessageBox.Show("Nema raspolozivih mesta na letu!");
                return;
            }

            try
            {
                st.Cena = Convert.ToDouble(txtCena.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Cena nije ispravno uneta!");
                return;
            }

            if (st.Cena < 0)
            {
                MessageBox.Show("Cena nije ispravno uneta!");
                return;
            }

            rezervacija.UkupnaCena += st.Cena;
            txtUkupno.Text = rezervacija.UkupnaCena.ToString("N02");

            foreach (StavkaRezervacije str in rezervacija.ListaStavki)
            {
                if (st.Let.LetID == str.Let.LetID)
                {
                    MessageBox.Show("Ne mozete ponovo da rezervisete isti let!");
                    return;
                }
            }

            rezervacija.ListaStavki.Add(st);

            popuniComboLet(cmbLet);
            txtCena.Clear();
        }

        public static void popuniComboLet(ComboBox combo)
        {
            combo.Items.Clear();
            foreach (Let l in komunikacija.UcitajListuLetova() as List<Let>)
                {
                combo.Items.Add(l);
            }
            combo.Text = "Izaberite let!";
        }

        public static void popuniComboPutnik(ComboBox combo)
        {
            combo.Items.Clear();
            foreach (Putnik p in komunikacija.UcitajListuPutnika() as List<Putnik>)
            {
                combo.Items.Add(p);
            }
            combo.Text = "Izaberite putnika!";
        }

       
        public static bool KreirajPutnika(TextBox txtIme, TextBox txtPrezime, TextBox txtTelefon, TextBox txtJMBG, TextBox txtPasos)
        {
          
            putnik = new Putnik();
            putnik.Ime = txtIme.Text;
            if (string.IsNullOrEmpty(putnik.Ime))
            {
                MessageBox.Show("Niste uneli ime putnika!");
                return false;
            }
            putnik.Prezime = txtPrezime.Text;
            if (string.IsNullOrEmpty(putnik.Prezime))
            {
                MessageBox.Show("Niste uneli prezime putnika!");
                return false;
            }
            putnik.BrojPasosa = txtPasos.Text;
            if (string.IsNullOrEmpty(putnik.BrojPasosa))
            {
                MessageBox.Show("Niste uneli broj pasosa putnika!");
                return false;
            }
            try
            {
                long lo = Convert.ToInt64(putnik.BrojPasosa);
            }
            catch (Exception)
            {
                MessageBox.Show("Broj pasosa mora sadrzati cifre!");
                return false;
            }
            putnik.KontaktTelefon = txtTelefon.Text;
            putnik.JmbgPutnika = txtJMBG.Text;

            if (putnik.JmbgPutnika.Length != 13)
            {
                MessageBox.Show("JMBG nije ispravno unet!");
                return false;
            }

            try
            {
                long l = Convert.ToInt64(putnik.JmbgPutnika);
            }
            catch (Exception)
            {
                MessageBox.Show("JMBG mora sadrzati cifre!");
                return false;
            }



            Object rez = komunikacija.KreirajPutnika(putnik);

            if (rez == null)
            {
                MessageBox.Show("Sistem ne moze da zapamti novog putnika!");
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je zapamtio novog putnika!");
                return true;
            }
        }

        public static bool ZapamtiPutnika(TextBox txtIme, TextBox txtPrezime, TextBox txtTelefon, TextBox txtJMBG, TextBox txtPasos)
        {

           
            putnik.Ime = txtIme.Text;
            if (string.IsNullOrEmpty(putnik.Ime))
            {
                MessageBox.Show("Niste uneli ime putnika!");
                return false;
            }
            putnik.Prezime = txtPrezime.Text;
            if (string.IsNullOrEmpty(putnik.Prezime))
            {
                MessageBox.Show("Niste uneli prezime putnika!");
                return false;
            }
            putnik.BrojPasosa = txtPasos.Text;
            if (string.IsNullOrEmpty(putnik.BrojPasosa))
            {
                MessageBox.Show("Niste uneli broj pasosa putnika!");
                return false;
            }
            try
            {
                long lo = Convert.ToInt64(putnik.BrojPasosa);
            }
            catch (Exception)
            {
                MessageBox.Show("Broj pasosa mora sadrzati cifre!");
                return false;
            }
            putnik.KontaktTelefon = txtTelefon.Text;
           

            Object rez = komunikacija.ZapamtiPutnika(putnik);

            if (rez == null)
            {
                MessageBox.Show("Sistem ne moze da zapamti putnika!");
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je zapamtio putnika!");
                return true;
            }
        }

        public static void kraj()
        {
            komunikacija.kraj();
        }

        public static bool NadjiZaposlenog(TextBox txtUser, TextBox txtPass)
        {
            zaposleni = new Zaposleni();
            zaposleni.USLOV = "KorisnickaSifra='"+txtPass.Text+"' and KorisnickoIme='"+txtUser.Text+"'";

            zaposleni = komunikacija.NadjiZaposlenog(zaposleni) as Zaposleni;

            if (zaposleni == null)
            {
                MessageBox.Show("Sistem ne moze da pronadje zaposlenog sa unetim podacima!");
                return false;
            }
            else
            {
                MessageBox.Show("Uspesno ste se prijavili na sistem!");
                return true;
            }
        }
    }
}
