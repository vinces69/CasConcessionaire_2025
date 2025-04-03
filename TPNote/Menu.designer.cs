namespace TPNote
{
    partial class Menu
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.commandeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesCommandesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pn_SousFormulaire = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.pn_SousFormulaire.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.commandeToolStripMenuItem,
            this.listeDesCommandesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(990, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // commandeToolStripMenuItem
            // 
            this.commandeToolStripMenuItem.Name = "commandeToolStripMenuItem";
            this.commandeToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.commandeToolStripMenuItem.Text = "Commande";
            this.commandeToolStripMenuItem.Click += new System.EventHandler(this.commandeToolStripMenuItem_Click);
            // 
            // listeDesCommandesToolStripMenuItem
            // 
            this.listeDesCommandesToolStripMenuItem.Name = "listeDesCommandesToolStripMenuItem";
            this.listeDesCommandesToolStripMenuItem.Size = new System.Drawing.Size(133, 20);
            this.listeDesCommandesToolStripMenuItem.Text = "Liste des commandes";
            this.listeDesCommandesToolStripMenuItem.Click += new System.EventHandler(this.listeDesCommandesToolStripMenuItem_Click);
            // 
            // pn_SousFormulaire
            // 
            this.pn_SousFormulaire.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pn_SousFormulaire.Controls.Add(this.pictureBox1);
            this.pn_SousFormulaire.Location = new System.Drawing.Point(0, 27);
            this.pn_SousFormulaire.Name = "pn_SousFormulaire";
            this.pn_SousFormulaire.Size = new System.Drawing.Size(990, 478);
            this.pn_SousFormulaire.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Image = global::TPNote.Properties.Resources.logo_cars_mobi_hires1;
            this.pictureBox1.Location = new System.Drawing.Point(196, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(568, 373);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 505);
            this.Controls.Add(this.pn_SousFormulaire);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pn_SousFormulaire.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem commandeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesCommandesToolStripMenuItem;
        private System.Windows.Forms.Panel pn_SousFormulaire;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

