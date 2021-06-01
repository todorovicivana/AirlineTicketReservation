namespace Klijent
{
    partial class GlavnaForma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GlavnaForma));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pacijentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.terminaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosTerminaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaTerminaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pacijentToolStripMenuItem,
            this.terminaToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Klijent.Properties.Resources._42586_airplane_icon1;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Klijent.Properties.Resources._17_171149_travel_insurance_clipart_health_service_traveler_cartoon_png;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // pacijentToolStripMenuItem
            // 
            this.pacijentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosToolStripMenuItem,
            this.pretragaToolStripMenuItem});
            this.pacijentToolStripMenuItem.Image = global::Klijent.Properties.Resources._17_171149_travel_insurance_clipart_health_service_traveler_cartoon_png1;
            this.pacijentToolStripMenuItem.Name = "pacijentToolStripMenuItem";
            resources.ApplyResources(this.pacijentToolStripMenuItem, "pacijentToolStripMenuItem");
            this.pacijentToolStripMenuItem.Click += new System.EventHandler(this.pacijentToolStripMenuItem_Click);
            // 
            // unosToolStripMenuItem
            // 
            this.unosToolStripMenuItem.Name = "unosToolStripMenuItem";
            resources.ApplyResources(this.unosToolStripMenuItem, "unosToolStripMenuItem");
            this.unosToolStripMenuItem.Click += new System.EventHandler(this.unosToolStripMenuItem_Click);
            // 
            // pretragaToolStripMenuItem
            // 
            this.pretragaToolStripMenuItem.Name = "pretragaToolStripMenuItem";
            resources.ApplyResources(this.pretragaToolStripMenuItem, "pretragaToolStripMenuItem");
            this.pretragaToolStripMenuItem.Click += new System.EventHandler(this.pretragaToolStripMenuItem_Click);
            // 
            // terminaToolStripMenuItem
            // 
            this.terminaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosTerminaToolStripMenuItem,
            this.pretragaTerminaToolStripMenuItem});
            this.terminaToolStripMenuItem.Image = global::Klijent.Properties.Resources._42586_airplane_icon__1_1;
            this.terminaToolStripMenuItem.Name = "terminaToolStripMenuItem";
            resources.ApplyResources(this.terminaToolStripMenuItem, "terminaToolStripMenuItem");
            // 
            // unosTerminaToolStripMenuItem
            // 
            this.unosTerminaToolStripMenuItem.Name = "unosTerminaToolStripMenuItem";
            resources.ApplyResources(this.unosTerminaToolStripMenuItem, "unosTerminaToolStripMenuItem");
            this.unosTerminaToolStripMenuItem.Click += new System.EventHandler(this.unosTerminaToolStripMenuItem_Click);
            // 
            // pretragaTerminaToolStripMenuItem
            // 
            this.pretragaTerminaToolStripMenuItem.Name = "pretragaTerminaToolStripMenuItem";
            resources.ApplyResources(this.pretragaTerminaToolStripMenuItem, "pretragaTerminaToolStripMenuItem");
            this.pretragaTerminaToolStripMenuItem.Click += new System.EventHandler(this.pretragaTerminaToolStripMenuItem_Click);
            // 
            // GlavnaForma
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GlavnaForma";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GlavnaForma_FormClosed);
            this.Load += new System.EventHandler(this.GlavnaForma_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pacijentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem terminaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosTerminaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaTerminaToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
    }
}