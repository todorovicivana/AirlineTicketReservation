namespace Klijent
{
    partial class UnosRezervacija
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnosRezervacija));
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnKreiraj = new System.Windows.Forms.Button();
            this.gbRezervacija = new System.Windows.Forms.GroupBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblVreme = new System.Windows.Forms.Label();
            this.txtUkupno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.dgvGrid = new System.Windows.Forms.DataGridView();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbLet = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbPutnik = new System.Windows.Forms.ComboBox();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbRezervacija.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "RezervacijaID";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(102, 17);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(65, 22);
            this.txtID.TabIndex = 1;
            // 
            // btnKreiraj
            // 
            this.btnKreiraj.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKreiraj.Location = new System.Drawing.Point(200, 17);
            this.btnKreiraj.Name = "btnKreiraj";
            this.btnKreiraj.Size = new System.Drawing.Size(176, 23);
            this.btnKreiraj.TabIndex = 2;
            this.btnKreiraj.Text = "Kreiraj rezervaciju";
            this.btnKreiraj.UseVisualStyleBackColor = true;
            this.btnKreiraj.Click += new System.EventHandler(this.btnKreiraj_Click);
            // 
            // gbRezervacija
            // 
            this.gbRezervacija.Controls.Add(this.pictureBox6);
            this.gbRezervacija.Controls.Add(this.pictureBox5);
            this.gbRezervacija.Controls.Add(this.pictureBox4);
            this.gbRezervacija.Controls.Add(this.pictureBox3);
            this.gbRezervacija.Controls.Add(this.pictureBox2);
            this.gbRezervacija.Controls.Add(this.pictureBox1);
            this.gbRezervacija.Controls.Add(this.lblVreme);
            this.gbRezervacija.Controls.Add(this.txtUkupno);
            this.gbRezervacija.Controls.Add(this.label3);
            this.gbRezervacija.Controls.Add(this.button3);
            this.gbRezervacija.Controls.Add(this.dgvGrid);
            this.gbRezervacija.Controls.Add(this.txtCena);
            this.gbRezervacija.Controls.Add(this.label7);
            this.gbRezervacija.Controls.Add(this.button2);
            this.gbRezervacija.Controls.Add(this.button1);
            this.gbRezervacija.Controls.Add(this.label6);
            this.gbRezervacija.Controls.Add(this.cmbLet);
            this.gbRezervacija.Controls.Add(this.label5);
            this.gbRezervacija.Controls.Add(this.cmbPutnik);
            this.gbRezervacija.Controls.Add(this.dtpDatum);
            this.gbRezervacija.Controls.Add(this.label4);
            this.gbRezervacija.Controls.Add(this.label2);
            this.gbRezervacija.Enabled = false;
            this.gbRezervacija.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRezervacija.Location = new System.Drawing.Point(25, 52);
            this.gbRezervacija.Name = "gbRezervacija";
            this.gbRezervacija.Size = new System.Drawing.Size(509, 517);
            this.gbRezervacija.TabIndex = 3;
            this.gbRezervacija.TabStop = false;
            this.gbRezervacija.Text = "Podaci o rezervaciji";
            this.gbRezervacija.Enter += new System.EventHandler(this.gbRezervacija_Enter);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Klijent.Properties.Resources.Apps_preferences_system_time_icon;
            this.pictureBox6.Location = new System.Drawing.Point(261, 149);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(16, 16);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox6.TabIndex = 26;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Klijent.Properties.Resources.coins_icon;
            this.pictureBox5.Location = new System.Drawing.Point(20, 434);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(16, 16);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox5.TabIndex = 25;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Klijent.Properties.Resources.coins_icon;
            this.pictureBox4.Location = new System.Drawing.Point(20, 178);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(16, 16);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 24;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Klijent.Properties.Resources._42586_airplane_icon__1_;
            this.pictureBox3.Location = new System.Drawing.Point(20, 149);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(16, 16);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Klijent.Properties.Resources.User_blue_icon1;
            this.pictureBox2.Location = new System.Drawing.Point(18, 66);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 16);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Klijent.Properties.Resources.calendar_icon;
            this.pictureBox1.Location = new System.Drawing.Point(18, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // lblVreme
            // 
            this.lblVreme.AutoSize = true;
            this.lblVreme.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVreme.Location = new System.Drawing.Point(283, 151);
            this.lblVreme.Name = "lblVreme";
            this.lblVreme.Size = new System.Drawing.Size(86, 14);
            this.lblVreme.TabIndex = 20;
            this.lblVreme.Text = "Vreme polaska:";
            // 
            // txtUkupno
            // 
            this.txtUkupno.Location = new System.Drawing.Point(127, 433);
            this.txtUkupno.Name = "txtUkupno";
            this.txtUkupno.ReadOnly = true;
            this.txtUkupno.Size = new System.Drawing.Size(136, 22);
            this.txtUkupno.TabIndex = 18;
            this.txtUkupno.Text = "0.00";
            this.txtUkupno.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 436);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 14);
            this.label3.TabIndex = 19;
            this.label3.Text = "Ukupan iznos:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(138, 477);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(247, 34);
            this.button3.TabIndex = 17;
            this.button3.Text = "Sacuvaj rezervaciju";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dgvGrid
            // 
            this.dgvGrid.AllowUserToAddRows = false;
            this.dgvGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGrid.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrid.Location = new System.Drawing.Point(20, 260);
            this.dgvGrid.Name = "dgvGrid";
            this.dgvGrid.Size = new System.Drawing.Size(467, 154);
            this.dgvGrid.TabIndex = 16;
            // 
            // txtCena
            // 
            this.txtCena.Location = new System.Drawing.Point(105, 175);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(136, 22);
            this.txtCena.TabIndex = 13;
            this.txtCena.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 14);
            this.label7.TabIndex = 14;
            this.label7.Text = "Cena:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(286, 231);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Obrisi stavku";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Dodaj stavku";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Unos stavki rezervacije";
            // 
            // cmbLet
            // 
            this.cmbLet.FormattingEnabled = true;
            this.cmbLet.Location = new System.Drawing.Point(105, 148);
            this.cmbLet.Name = "cmbLet";
            this.cmbLet.Size = new System.Drawing.Size(136, 22);
            this.cmbLet.TabIndex = 10;
            this.cmbLet.SelectedIndexChanged += new System.EventHandler(this.cmbLet_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.Location = new System.Drawing.Point(49, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Let:";
            // 
            // cmbPutnik
            // 
            this.cmbPutnik.FormattingEnabled = true;
            this.cmbPutnik.Location = new System.Drawing.Point(138, 65);
            this.cmbPutnik.Name = "cmbPutnik";
            this.cmbPutnik.Size = new System.Drawing.Size(337, 22);
            this.cmbPutnik.TabIndex = 8;
            // 
            // dtpDatum
            // 
            this.dtpDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatum.Location = new System.Drawing.Point(138, 39);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(337, 22);
            this.dtpDatum.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "Putnik: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "Datum isteka:";
            // 
            // UnosRezervacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 575);
            this.Controls.Add(this.gbRezervacija);
            this.Controls.Add(this.btnKreiraj);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UnosRezervacija";
            this.Text = "Unos rezervacije";
            this.Load += new System.EventHandler(this.UnosRezervacija_Load);
            this.gbRezervacija.ResumeLayout(false);
            this.gbRezervacija.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnKreiraj;
        private System.Windows.Forms.GroupBox gbRezervacija;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dgvGrid;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbLet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbPutnik;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUkupno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblVreme;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}