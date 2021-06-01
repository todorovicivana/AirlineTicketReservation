using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Server
{
    public partial class FormaServer : Form
    {
        Server s;
        public FormaServer()
        {
            s = new Server();
            InitializeComponent();
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnPokreni_Click(object sender, EventArgs e)
        {
            s = new Server();
            if (s.pokreniServer())
            {
                lblStatus.Text = "Status: Server je pokrenut!";
                lblStatus.ForeColor = Color.Green;
                btnPokreni.Enabled = false;
                btnZaustavi.Enabled = true;

            }
        }

        private void btnZaustavi_Click(object sender, EventArgs e)
        {
            if (Server.listaTokova.Count > 0)
            {
                MessageBox.Show("Server se ne moze zaustaviti! Jos uvek je neko ulogovan!");
                return;
            }
            if (s.ZaustaviServer())
            {
                lblStatus.Text = "Status: Server nije pokrenut!";
                lblStatus.ForeColor = Color.Red;
                btnPokreni.Enabled = true;
                btnZaustavi.Enabled = false;
            }
        }
    }
}
