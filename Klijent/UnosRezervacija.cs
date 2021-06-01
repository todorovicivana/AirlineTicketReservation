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
    public partial class UnosRezervacija : Form
    {
        public UnosRezervacija()
        {
            InitializeComponent();
        }

        private void btnKreiraj_Click(object sender, EventArgs e)
        {
            KontrolerKorisnickogInterfejsa.KontrolerKI.KreirajRezervaciju(txtID, btnKreiraj, gbRezervacija, cmbPutnik, cmbLet,dgvGrid);
            lblVreme.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            KontrolerKorisnickogInterfejsa.KontrolerKI.DodajStavku(cmbLet, txtCena,txtUkupno);
            lblVreme.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            KontrolerKorisnickogInterfejsa.KontrolerKI.ObrisiStavku(dgvGrid,txtUkupno);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (KontrolerKorisnickogInterfejsa.KontrolerKI.SacuvajRezervaciju(dtpDatum, cmbPutnik)) this.Close();
        }

        private void cmbLet_SelectedIndexChanged(object sender, EventArgs e)
        {
            KontrolerKorisnickogInterfejsa.KontrolerKI.popuniVremePolaska(cmbLet, lblVreme);
        }

        private void UnosRezervacija_Load(object sender, EventArgs e)
        {
            lblVreme.Text = "";

        }

        private void gbRezervacija_Enter(object sender, EventArgs e)
        {

        }
    }
}
