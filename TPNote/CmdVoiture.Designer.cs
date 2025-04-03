namespace TPNote
{
    partial class CmdVoiture
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
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_Modèle = new System.Windows.Forms.ComboBox();
            this.lbl_Modele = new System.Windows.Forms.Label();
            this.Couleur = new System.Windows.Forms.Label();
            this.cmb_Couleur = new System.Windows.Forms.ComboBox();
            this.pn_client = new System.Windows.Forms.Panel();
            this.btn_Valider = new System.Windows.Forms.Button();
            this.txt_prenom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rb_normal = new System.Windows.Forms.RadioButton();
            this.rb_prenium = new System.Windows.Forms.RadioButton();
            this.lbl_fini = new System.Windows.Forms.Label();
            this.chb_Enrgconduite = new System.Windows.Forms.CheckBox();
            this.chb_brouillard = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chb_Chien = new System.Windows.Forms.CheckBox();
            this.chb_CoffreToit = new System.Windows.Forms.CheckBox();
            this.btn_Close = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pn_client.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(160, 51);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(216, 20);
            this.txt_nom.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom : ";
            // 
            // cmb_Modèle
            // 
            this.cmb_Modèle.FormattingEnabled = true;
            this.cmb_Modèle.Location = new System.Drawing.Point(217, 94);
            this.cmb_Modèle.Name = "cmb_Modèle";
            this.cmb_Modèle.Size = new System.Drawing.Size(177, 21);
            this.cmb_Modèle.TabIndex = 2;
            // 
            // lbl_Modele
            // 
            this.lbl_Modele.AutoSize = true;
            this.lbl_Modele.Location = new System.Drawing.Point(131, 94);
            this.lbl_Modele.Name = "lbl_Modele";
            this.lbl_Modele.Size = new System.Drawing.Size(42, 13);
            this.lbl_Modele.TabIndex = 3;
            this.lbl_Modele.Text = "Modèle";
            // 
            // Couleur
            // 
            this.Couleur.AutoSize = true;
            this.Couleur.Location = new System.Drawing.Point(131, 132);
            this.Couleur.Name = "Couleur";
            this.Couleur.Size = new System.Drawing.Size(43, 13);
            this.Couleur.TabIndex = 5;
            this.Couleur.Text = "Couleur";
            // 
            // cmb_Couleur
            // 
            this.cmb_Couleur.FormattingEnabled = true;
            this.cmb_Couleur.Location = new System.Drawing.Point(217, 132);
            this.cmb_Couleur.Name = "cmb_Couleur";
            this.cmb_Couleur.Size = new System.Drawing.Size(177, 21);
            this.cmb_Couleur.TabIndex = 4;
            // 
            // pn_client
            // 
            this.pn_client.Controls.Add(this.label2);
            this.pn_client.Controls.Add(this.btn_Valider);
            this.pn_client.Controls.Add(this.txt_prenom);
            this.pn_client.Controls.Add(this.label3);
            this.pn_client.Controls.Add(this.txt_nom);
            this.pn_client.Controls.Add(this.label1);
            this.pn_client.Location = new System.Drawing.Point(497, 40);
            this.pn_client.Name = "pn_client";
            this.pn_client.Size = new System.Drawing.Size(425, 200);
            this.pn_client.TabIndex = 6;
            // 
            // btn_Valider
            // 
            this.btn_Valider.Location = new System.Drawing.Point(160, 146);
            this.btn_Valider.Name = "btn_Valider";
            this.btn_Valider.Size = new System.Drawing.Size(128, 23);
            this.btn_Valider.TabIndex = 10;
            this.btn_Valider.Text = "Valider la commande";
            this.btn_Valider.UseVisualStyleBackColor = true;
            this.btn_Valider.Click += new System.EventHandler(this.btn_Valider_Click);
            // 
            // txt_prenom
            // 
            this.txt_prenom.Location = new System.Drawing.Point(160, 84);
            this.txt_prenom.Name = "txt_prenom";
            this.txt_prenom.Size = new System.Drawing.Size(216, 20);
            this.txt_prenom.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Prénom : ";
            // 
            // rb_normal
            // 
            this.rb_normal.AutoSize = true;
            this.rb_normal.Location = new System.Drawing.Point(217, 182);
            this.rb_normal.Name = "rb_normal";
            this.rb_normal.Size = new System.Drawing.Size(58, 17);
            this.rb_normal.TabIndex = 7;
            this.rb_normal.TabStop = true;
            this.rb_normal.Text = "Normal";
            this.rb_normal.UseVisualStyleBackColor = true;
            // 
            // rb_prenium
            // 
            this.rb_prenium.AutoSize = true;
            this.rb_prenium.Location = new System.Drawing.Point(309, 182);
            this.rb_prenium.Name = "rb_prenium";
            this.rb_prenium.Size = new System.Drawing.Size(63, 17);
            this.rb_prenium.TabIndex = 8;
            this.rb_prenium.TabStop = true;
            this.rb_prenium.Text = "Prenium";
            this.rb_prenium.UseVisualStyleBackColor = false;
            // 
            // lbl_fini
            // 
            this.lbl_fini.AutoSize = true;
            this.lbl_fini.Location = new System.Drawing.Point(131, 182);
            this.lbl_fini.Name = "lbl_fini";
            this.lbl_fini.Size = new System.Drawing.Size(47, 13);
            this.lbl_fini.TabIndex = 9;
            this.lbl_fini.Text = "Finission";
            // 
            // chb_Enrgconduite
            // 
            this.chb_Enrgconduite.AutoSize = true;
            this.chb_Enrgconduite.Location = new System.Drawing.Point(18, 22);
            this.chb_Enrgconduite.Name = "chb_Enrgconduite";
            this.chb_Enrgconduite.Size = new System.Drawing.Size(144, 17);
            this.chb_Enrgconduite.TabIndex = 10;
            this.chb_Enrgconduite.Text = "Enregistreur de conduite ";
            this.chb_Enrgconduite.UseVisualStyleBackColor = true;
            // 
            // chb_brouillard
            // 
            this.chb_brouillard.AutoSize = true;
            this.chb_brouillard.Location = new System.Drawing.Point(178, 22);
            this.chb_brouillard.Name = "chb_brouillard";
            this.chb_brouillard.Size = new System.Drawing.Size(116, 17);
            this.chb_brouillard.TabIndex = 11;
            this.chb_brouillard.Text = "Phare antibrouillard";
            this.chb_brouillard.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chb_Chien);
            this.groupBox1.Controls.Add(this.chb_CoffreToit);
            this.groupBox1.Controls.Add(this.chb_brouillard);
            this.groupBox1.Controls.Add(this.chb_Enrgconduite);
            this.groupBox1.Location = new System.Drawing.Point(116, 215);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 102);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // chb_Chien
            // 
            this.chb_Chien.AutoSize = true;
            this.chb_Chien.Location = new System.Drawing.Point(178, 59);
            this.chb_Chien.Name = "chb_Chien";
            this.chb_Chien.Size = new System.Drawing.Size(102, 17);
            this.chb_Chien.TabIndex = 13;
            this.chb_Chien.Text = "Grille pare-chien";
            this.chb_Chien.UseVisualStyleBackColor = true;
            // 
            // chb_CoffreToit
            // 
            this.chb_CoffreToit.AutoSize = true;
            this.chb_CoffreToit.Location = new System.Drawing.Point(18, 59);
            this.chb_CoffreToit.Name = "chb_CoffreToit";
            this.chb_CoffreToit.Size = new System.Drawing.Size(86, 17);
            this.chb_CoffreToit.TabIndex = 12;
            this.chb_CoffreToit.Text = "Coffre de toit";
            this.chb_CoffreToit.UseVisualStyleBackColor = true;
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(952, -2);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(22, 22);
            this.btn_Close.TabIndex = 13;
            this.btn_Close.Text = "X";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(196, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "Client";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(230, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 31);
            this.label4.TabIndex = 14;
            this.label4.Text = "Voiture";
            // 
            // CmdVoiture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(974, 438);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_fini);
            this.Controls.Add(this.rb_prenium);
            this.Controls.Add(this.rb_normal);
            this.Controls.Add(this.pn_client);
            this.Controls.Add(this.Couleur);
            this.Controls.Add(this.cmb_Couleur);
            this.Controls.Add(this.lbl_Modele);
            this.Controls.Add(this.cmb_Modèle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CmdVoiture";
            this.Text = "CmdVoiture";
            this.pn_client.ResumeLayout(false);
            this.pn_client.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_Modèle;
        private System.Windows.Forms.Label lbl_Modele;
        private System.Windows.Forms.Label Couleur;
        private System.Windows.Forms.ComboBox cmb_Couleur;
        private System.Windows.Forms.Panel pn_client;
        private System.Windows.Forms.RadioButton rb_normal;
        private System.Windows.Forms.RadioButton rb_prenium;
        private System.Windows.Forms.Label lbl_fini;
        private System.Windows.Forms.CheckBox chb_Enrgconduite;
        private System.Windows.Forms.CheckBox chb_brouillard;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chb_Chien;
        private System.Windows.Forms.CheckBox chb_CoffreToit;
        private System.Windows.Forms.TextBox txt_prenom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Valider;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}