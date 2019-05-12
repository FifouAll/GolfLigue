namespace GolfForms
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.lv_clubs = new System.Windows.Forms.ListView();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_lon = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_lat = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_effectifs = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_courriel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_tel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_ville = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_cp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_rue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_nom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_code = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.lv_lestrous = new System.Windows.Forms.ListView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.tb_par = new System.Windows.Forms.TextBox();
            this.tb_distance = new System.Windows.Forms.TextBox();
            this.tb_numero = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lb_clubactuel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(46, 40);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(641, 447);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.lv_clubs);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(633, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Clubs";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(320, 7);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Liste";
            // 
            // lv_clubs
            // 
            this.lv_clubs.Location = new System.Drawing.Point(323, 23);
            this.lv_clubs.Name = "lv_clubs";
            this.lv_clubs.Size = new System.Drawing.Size(252, 167);
            this.lv_clubs.TabIndex = 2;
            this.lv_clubs.UseCompatibleStateImageBehavior = false;
            this.lv_clubs.View = System.Windows.Forms.View.List;
            this.lv_clubs.SelectedIndexChanged += new System.EventHandler(this.lv_clubs_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Fiche Club";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.tb_lon);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.tb_lat);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.tb_effectifs);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tb_courriel);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tb_tel);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tb_ville);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tb_cp);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tb_rue);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tb_nom);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tb_code);
            this.panel1.Location = new System.Drawing.Point(22, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 366);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Valider";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 251);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Longitude";
            // 
            // tb_lon
            // 
            this.tb_lon.Location = new System.Drawing.Point(111, 251);
            this.tb_lon.Name = "tb_lon";
            this.tb_lon.Size = new System.Drawing.Size(100, 20);
            this.tb_lon.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Latitude";
            // 
            // tb_lat
            // 
            this.tb_lat.Location = new System.Drawing.Point(111, 225);
            this.tb_lat.Name = "tb_lat";
            this.tb_lat.Size = new System.Drawing.Size(100, 20);
            this.tb_lat.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Effectifs";
            // 
            // tb_effectifs
            // 
            this.tb_effectifs.Location = new System.Drawing.Point(111, 199);
            this.tb_effectifs.Name = "tb_effectifs";
            this.tb_effectifs.Size = new System.Drawing.Size(100, 20);
            this.tb_effectifs.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Courriel";
            // 
            // tb_courriel
            // 
            this.tb_courriel.Location = new System.Drawing.Point(111, 173);
            this.tb_courriel.Name = "tb_courriel";
            this.tb_courriel.Size = new System.Drawing.Size(100, 20);
            this.tb_courriel.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Téléphone";
            // 
            // tb_tel
            // 
            this.tb_tel.Location = new System.Drawing.Point(111, 147);
            this.tb_tel.Name = "tb_tel";
            this.tb_tel.Size = new System.Drawing.Size(100, 20);
            this.tb_tel.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ville";
            // 
            // tb_ville
            // 
            this.tb_ville.Location = new System.Drawing.Point(111, 121);
            this.tb_ville.Name = "tb_ville";
            this.tb_ville.Size = new System.Drawing.Size(100, 20);
            this.tb_ville.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Code postal";
            // 
            // tb_cp
            // 
            this.tb_cp.Location = new System.Drawing.Point(111, 95);
            this.tb_cp.Name = "tb_cp";
            this.tb_cp.Size = new System.Drawing.Size(100, 20);
            this.tb_cp.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Rue";
            // 
            // tb_rue
            // 
            this.tb_rue.Location = new System.Drawing.Point(111, 69);
            this.tb_rue.Name = "tb_rue";
            this.tb_rue.Size = new System.Drawing.Size(100, 20);
            this.tb_rue.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nom";
            // 
            // tb_nom
            // 
            this.tb_nom.Location = new System.Drawing.Point(111, 43);
            this.tb_nom.Name = "tb_nom";
            this.tb_nom.Size = new System.Drawing.Size(100, 20);
            this.tb_nom.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Code";
            // 
            // tb_code
            // 
            this.tb_code.Location = new System.Drawing.Point(111, 17);
            this.tb_code.Name = "tb_code";
            this.tb_code.Size = new System.Drawing.Size(100, 20);
            this.tb_code.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.lv_lestrous);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.lb_clubactuel);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(633, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Trous";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(350, 56);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(50, 13);
            this.label17.TabIndex = 3;
            this.label17.Text = "Les trous";
            // 
            // lv_lestrous
            // 
            this.lv_lestrous.Location = new System.Drawing.Point(353, 81);
            this.lv_lestrous.Name = "lv_lestrous";
            this.lv_lestrous.Size = new System.Drawing.Size(211, 110);
            this.lv_lestrous.TabIndex = 2;
            this.lv_lestrous.UseCompatibleStateImageBehavior = false;
            this.lv_lestrous.View = System.Windows.Forms.View.List;
            this.lv_lestrous.SelectedIndexChanged += new System.EventHandler(this.lv_lestrous_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.tb_par);
            this.panel2.Controls.Add(this.tb_distance);
            this.panel2.Controls.Add(this.tb_numero);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Location = new System.Drawing.Point(32, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(237, 256);
            this.panel2.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(110, 164);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Valider";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tb_par
            // 
            this.tb_par.Location = new System.Drawing.Point(110, 108);
            this.tb_par.Name = "tb_par";
            this.tb_par.Size = new System.Drawing.Size(100, 20);
            this.tb_par.TabIndex = 5;
            // 
            // tb_distance
            // 
            this.tb_distance.Location = new System.Drawing.Point(110, 75);
            this.tb_distance.Name = "tb_distance";
            this.tb_distance.Size = new System.Drawing.Size(100, 20);
            this.tb_distance.TabIndex = 4;
            // 
            // tb_numero
            // 
            this.tb_numero.Location = new System.Drawing.Point(110, 39);
            this.tb_numero.Name = "tb_numero";
            this.tb_numero.Size = new System.Drawing.Size(100, 20);
            this.tb_numero.TabIndex = 3;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(32, 115);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 13);
            this.label16.TabIndex = 2;
            this.label16.Text = "PAR";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(32, 75);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "Distance";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(32, 39);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Numéro";
            // 
            // lb_clubactuel
            // 
            this.lb_clubactuel.AutoSize = true;
            this.lb_clubactuel.Location = new System.Drawing.Point(29, 20);
            this.lb_clubactuel.Name = "lb_clubactuel";
            this.lb_clubactuel.Size = new System.Drawing.Size(69, 13);
            this.lb_clubactuel.TabIndex = 0;
            this.lb_clubactuel.Text = "Club actuel : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 573);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_lon;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_lat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_effectifs;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_courriel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_tel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_ville;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_cp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_rue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_nom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_code;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListView lv_clubs;
        private System.Windows.Forms.Label lb_clubactuel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tb_par;
        private System.Windows.Forms.TextBox tb_distance;
        private System.Windows.Forms.TextBox tb_numero;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ListView lv_lestrous;
        private System.Windows.Forms.Label label17;
    }
}

