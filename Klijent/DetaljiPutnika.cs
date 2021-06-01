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
    public partial class DetaljiPutnika : Form
    {
        public DetaljiPutnika()
        {
            InitializeComponent();
        }

        private void DetaljiPacijenta_Load(object sender, EventArgs e)
        {
            KontrolerKorisnickogInterfejsa.KontrolerKI.PopuniPoljaPutnik(txtJMBG, txtPasos, txtIme, txtPrezime, txtTelefon);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (KontrolerKorisnickogInterfejsa.KontrolerKI.ZapamtiPutnika(txtIme,txtPrezime,txtTelefon,txtJMBG,txtPasos)) this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (KontrolerKorisnickogInterfejsa.KontrolerKI.ObrisiPutnika()) this.Close();
        }
    }
}
