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
    public partial class GlavnaForma : Form
    {
        public GlavnaForma()
        {
            InitializeComponent();
        }

        private void GlavnaForma_FormClosed(object sender, FormClosedEventArgs e)
        {
            KontrolerKorisnickogInterfejsa.KontrolerKI.kraj();
        }

        private void unosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UnosPutnika().ShowDialog();
        }

        private void pretragaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PretragaPutnika().ShowDialog();
        }

        private void unosTerminaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UnosRezervacija().ShowDialog();
        }

        private void pretragaTerminaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new PretragaRezervacija().ShowDialog();
            this.Show();
        }

        private void GlavnaForma_Load(object sender, EventArgs e)
        {
            this.Text = KontrolerKorisnickogInterfejsa.KontrolerKI.PrikaziZaposlenog();
        }

        private void pacijentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
