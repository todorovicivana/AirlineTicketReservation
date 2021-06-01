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
    public partial class PretragaRezervacija : Form
    {
        public PretragaRezervacija()
        {
            InitializeComponent();
        }

        private void PretragaRezervacija_Load(object sender, EventArgs e)
        {
            KontrolerKorisnickogInterfejsa.KontrolerKI.popuniComboPutnik(cmbPutnik);
        }

        private void cmbPutnik_SelectedIndexChanged(object sender, EventArgs e)
        {
            KontrolerKorisnickogInterfejsa.KontrolerKI.PretraziRezervacije(cmbPutnik, dataGridView1);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (KontrolerKorisnickogInterfejsa.KontrolerKI.UcitajRezervaciju(dataGridView1)) new DetaljiRezervacije().ShowDialog();
            cmbPutnik_SelectedIndexChanged(sender, e);
        }
    }
}
