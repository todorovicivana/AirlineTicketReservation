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
    public partial class PretragaPutnika : Form
    {
        public PretragaPutnika()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            KontrolerKorisnickogInterfejsa.KontrolerKI.PretraziPutnike(txtFilter, dataGridView1);
        }

        private void PretragaPacijenata_Load(object sender, EventArgs e)
        {
            KontrolerKorisnickogInterfejsa.KontrolerKI.PretraziPutnike(txtFilter, dataGridView1);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (KontrolerKorisnickogInterfejsa.KontrolerKI.UcitajPutnika(dataGridView1)) new DetaljiPutnika().ShowDialog();
            textBox1_TextChanged(sender, e);
        }
    }
}
