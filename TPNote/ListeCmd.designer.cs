namespace TPNote
{
    partial class ListeCmd
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_RechercheNom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_RecherchePrenom = new System.Windows.Forms.TextBox();
            this.cmb_RechercheCouleur = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_RechercheModele = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(49, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(708, 308);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(351, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Liste des commandes";
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(951, 2);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(22, 22);
            this.btn_Close.TabIndex = 14;
            this.btn_Close.Text = "X";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cmb_RechercheModele);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cmb_RechercheCouleur);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_RecherchePrenom);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_RechercheNom);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(763, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 308);
            this.panel1.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Recherche";
            // 
            // txt_RechercheNom
            // 
            this.txt_RechercheNom.Location = new System.Drawing.Point(7, 55);
            this.txt_RechercheNom.Name = "txt_RechercheNom";
            this.txt_RechercheNom.Size = new System.Drawing.Size(177, 20);
            this.txt_RechercheNom.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nom client :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Prénom client :";
            // 
            // txt_RecherchePrenom
            // 
            this.txt_RecherchePrenom.Location = new System.Drawing.Point(7, 104);
            this.txt_RecherchePrenom.Name = "txt_RecherchePrenom";
            this.txt_RecherchePrenom.Size = new System.Drawing.Size(177, 20);
            this.txt_RecherchePrenom.TabIndex = 3;
            // 
            // cmb_RechercheCouleur
            // 
            this.cmb_RechercheCouleur.FormattingEnabled = true;
            this.cmb_RechercheCouleur.Location = new System.Drawing.Point(7, 151);
            this.cmb_RechercheCouleur.Name = "cmb_RechercheCouleur";
            this.cmb_RechercheCouleur.Size = new System.Drawing.Size(177, 21);
            this.cmb_RechercheCouleur.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Couleur Voiture :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Modèle Voiture :";
            // 
            // cmb_RechercheModele
            // 
            this.cmb_RechercheModele.FormattingEnabled = true;
            this.cmb_RechercheModele.Location = new System.Drawing.Point(7, 201);
            this.cmb_RechercheModele.Name = "cmb_RechercheModele";
            this.cmb_RechercheModele.Size = new System.Drawing.Size(177, 21);
            this.cmb_RechercheModele.TabIndex = 7;
            // 
            // ListeCmd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(974, 438);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListeCmd";
            this.Text = "ListeCmd";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_RecherchePrenom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_RechercheNom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_RechercheModele;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_RechercheCouleur;
    }
}