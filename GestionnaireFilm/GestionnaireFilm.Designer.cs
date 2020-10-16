namespace GestionnaireFilm
{
    partial class GestionnaireFilm
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
            this.BtnFilm = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.BtnADD = new System.Windows.Forms.Button();
            this.checkBoxFilm = new System.Windows.Forms.CheckBox();
            this.checkBoxRealisateur = new System.Windows.Forms.CheckBox();
            this.checkBoxProducteur = new System.Windows.Forms.CheckBox();
            this.checkBoxActeur = new System.Windows.Forms.CheckBox();
            this.CmbLang = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // BtnFilm
            // 
            this.BtnFilm.Location = new System.Drawing.Point(23, 113);
            this.BtnFilm.Name = "BtnFilm";
            this.BtnFilm.Size = new System.Drawing.Size(107, 23);
            this.BtnFilm.TabIndex = 0;
            this.BtnFilm.Text = "Films";
            this.BtnFilm.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(172, 115);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(148, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // BtnADD
            // 
            this.BtnADD.Location = new System.Drawing.Point(23, 168);
            this.BtnADD.Name = "BtnADD";
            this.BtnADD.Size = new System.Drawing.Size(107, 27);
            this.BtnADD.TabIndex = 2;
            this.BtnADD.Text = "Ajout";
            this.BtnADD.UseVisualStyleBackColor = true;
            this.BtnADD.Click += new System.EventHandler(this.BtnADD_Click);
            // 
            // checkBoxFilm
            // 
            this.checkBoxFilm.AutoSize = true;
            this.checkBoxFilm.Location = new System.Drawing.Point(172, 178);
            this.checkBoxFilm.Name = "checkBoxFilm";
            this.checkBoxFilm.Size = new System.Drawing.Size(44, 17);
            this.checkBoxFilm.TabIndex = 3;
            this.checkBoxFilm.Text = "Film";
            this.checkBoxFilm.UseVisualStyleBackColor = true;
            // 
            // checkBoxRealisateur
            // 
            this.checkBoxRealisateur.AutoSize = true;
            this.checkBoxRealisateur.Location = new System.Drawing.Point(265, 178);
            this.checkBoxRealisateur.Name = "checkBoxRealisateur";
            this.checkBoxRealisateur.Size = new System.Drawing.Size(79, 17);
            this.checkBoxRealisateur.TabIndex = 4;
            this.checkBoxRealisateur.Text = "Realisateur";
            this.checkBoxRealisateur.UseVisualStyleBackColor = true;
            // 
            // checkBoxProducteur
            // 
            this.checkBoxProducteur.AutoSize = true;
            this.checkBoxProducteur.Location = new System.Drawing.Point(379, 178);
            this.checkBoxProducteur.Name = "checkBoxProducteur";
            this.checkBoxProducteur.Size = new System.Drawing.Size(78, 17);
            this.checkBoxProducteur.TabIndex = 5;
            this.checkBoxProducteur.Text = "Producteur";
            this.checkBoxProducteur.UseVisualStyleBackColor = true;
            // 
            // checkBoxActeur
            // 
            this.checkBoxActeur.AutoSize = true;
            this.checkBoxActeur.Location = new System.Drawing.Point(510, 178);
            this.checkBoxActeur.Name = "checkBoxActeur";
            this.checkBoxActeur.Size = new System.Drawing.Size(57, 17);
            this.checkBoxActeur.TabIndex = 6;
            this.checkBoxActeur.Text = "Acteur";
            this.checkBoxActeur.UseVisualStyleBackColor = true;
            // 
            // CmbLang
            // 
            this.CmbLang.FormattingEnabled = true;
            this.CmbLang.Location = new System.Drawing.Point(645, 32);
            this.CmbLang.Name = "CmbLang";
            this.CmbLang.Size = new System.Drawing.Size(110, 21);
            this.CmbLang.TabIndex = 7;
            this.CmbLang.SelectedIndexChanged += new System.EventHandler(this.ComboBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(520, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "selectionner la langue";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(23, 243);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(587, 180);
            this.panel1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbLang);
            this.Controls.Add(this.checkBoxActeur);
            this.Controls.Add(this.checkBoxProducteur);
            this.Controls.Add(this.checkBoxRealisateur);
            this.Controls.Add(this.checkBoxFilm);
            this.Controls.Add(this.BtnADD);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.BtnFilm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnFilm;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button BtnADD;
        private System.Windows.Forms.CheckBox checkBoxFilm;
        private System.Windows.Forms.CheckBox checkBoxRealisateur;
        private System.Windows.Forms.CheckBox checkBoxProducteur;
        private System.Windows.Forms.CheckBox checkBoxActeur;
        private System.Windows.Forms.ComboBox CmbLang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}

