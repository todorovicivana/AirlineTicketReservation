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
    public partial class UnosPutnika : Form
    {
        public UnosPutnika()
        {
            InitializeComponent();
        }

        private void UnosPacijenta_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (KontrolerKorisnickogInterfejsa.KontrolerKI.KreirajPutnika(txtIme, txtPrezime, txtTelefon, txtJMBG,txtPasos)) this.Close();
        }
    }
}
