using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Klijent
{
    public partial class DetaljiRezervacije : Form
    {
        public DetaljiRezervacije()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (KontrolerKorisnickogInterfejsa.KontrolerKI.ObrisiRezervaciju()) this.Close();
        }

        private void DetaljiRezervacije_Load(object sender, EventArgs e)
        {
            KontrolerKorisnickogInterfejsa.KontrolerKI.popuniPoljaRezervacija(dtpDatum, cmbLet, cmbPutnik, txtCena, txtUkupno, dgvGrid);
            lblVreme.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            KontrolerKorisnickogInterfejsa.KontrolerKI.DodajStavku(cmbLet, txtCena, txtUkupno);
            lblVreme.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KontrolerKorisnickogInterfejsa.KontrolerKI.ObrisiStavku(dgvGrid, txtUkupno);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (KontrolerKorisnickogInterfejsa.KontrolerKI.SacuvajRezervaciju(dtpDatum, cmbPutnik))this.Close();
        }

        private void cmbLet_SelectedIndexChanged(object sender, EventArgs e)
        {
            KontrolerKorisnickogInterfejsa.KontrolerKI.popuniVremePolaska(cmbLet, lblVreme);
        }
    }
}
