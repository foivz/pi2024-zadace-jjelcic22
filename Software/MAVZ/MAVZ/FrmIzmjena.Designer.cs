namespace MAVZ
{
    partial class FrmIzmjena
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
            this.cbOdabir = new System.Windows.Forms.ComboBox();
            this.numId = new System.Windows.Forms.TextBox();
            this.txtLinija = new System.Windows.Forms.TextBox();
            this.txtVrijemeDol = new System.Windows.Forms.TextBox();
            this.txtVrijemePol = new System.Windows.Forms.TextBox();
            this.lbId = new System.Windows.Forms.Label();
            this.lbLinija = new System.Windows.Forms.Label();
            this.lbVrijemeDol = new System.Windows.Forms.Label();
            this.lbVrijemePol = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.btnIzbrisi = new System.Windows.Forms.Button();
            this.lbNaslovU = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbOdabir
            // 
            this.cbOdabir.FormattingEnabled = true;
            this.cbOdabir.Location = new System.Drawing.Point(57, 37);
            this.cbOdabir.Name = "cbOdabir";
            this.cbOdabir.Size = new System.Drawing.Size(376, 24);
            this.cbOdabir.TabIndex = 0;
            this.cbOdabir.SelectedIndexChanged += new System.EventHandler(this.cbOdabir_SelectedIndexChanged);
            // 
            // numId
            // 
            this.numId.Location = new System.Drawing.Point(187, 160);
            this.numId.Name = "numId";
            this.numId.Size = new System.Drawing.Size(246, 22);
            this.numId.TabIndex = 1;
            // 
            // txtLinija
            // 
            this.txtLinija.Location = new System.Drawing.Point(186, 230);
            this.txtLinija.Name = "txtLinija";
            this.txtLinija.Size = new System.Drawing.Size(246, 22);
            this.txtLinija.TabIndex = 2;
            // 
            // txtVrijemeDol
            // 
            this.txtVrijemeDol.Location = new System.Drawing.Point(186, 367);
            this.txtVrijemeDol.Name = "txtVrijemeDol";
            this.txtVrijemeDol.Size = new System.Drawing.Size(246, 22);
            this.txtVrijemeDol.TabIndex = 4;
            // 
            // txtVrijemePol
            // 
            this.txtVrijemePol.Location = new System.Drawing.Point(186, 292);
            this.txtVrijemePol.Name = "txtVrijemePol";
            this.txtVrijemePol.Size = new System.Drawing.Size(246, 22);
            this.txtVrijemePol.TabIndex = 3;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbId.Location = new System.Drawing.Point(56, 165);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(29, 16);
            this.lbId.TabIndex = 6;
            this.lbId.Text = "ID : ";
            // 
            // lbLinija
            // 
            this.lbLinija.AutoSize = true;
            this.lbLinija.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbLinija.Location = new System.Drawing.Point(57, 237);
            this.lbLinija.Name = "lbLinija";
            this.lbLinija.Size = new System.Drawing.Size(44, 16);
            this.lbLinija.TabIndex = 7;
            this.lbLinija.Text = "Linija: ";
            // 
            // lbVrijemeDol
            // 
            this.lbVrijemeDol.AutoSize = true;
            this.lbVrijemeDol.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbVrijemeDol.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVrijemeDol.Location = new System.Drawing.Point(57, 374);
            this.lbVrijemeDol.Name = "lbVrijemeDol";
            this.lbVrijemeDol.Size = new System.Drawing.Size(114, 16);
            this.lbVrijemeDol.TabIndex = 9;
            this.lbVrijemeDol.Text = "Vrijeme dolaska : ";
            // 
            // lbVrijemePol
            // 
            this.lbVrijemePol.AutoSize = true;
            this.lbVrijemePol.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbVrijemePol.Location = new System.Drawing.Point(57, 296);
            this.lbVrijemePol.Name = "lbVrijemePol";
            this.lbVrijemePol.Size = new System.Drawing.Size(108, 16);
            this.lbVrijemePol.TabIndex = 8;
            this.lbVrijemePol.Text = "Vrijeme polaska:";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(136, 88);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(206, 26);
            this.btnDodaj.TabIndex = 10;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAzuriraj.Location = new System.Drawing.Point(482, 374);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(93, 34);
            this.btnAzuriraj.TabIndex = 11;
            this.btnAzuriraj.Text = "Ažuriraj";
            this.btnAzuriraj.UseVisualStyleBackColor = false;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnIzbrisi.Location = new System.Drawing.Point(607, 374);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(98, 34);
            this.btnIzbrisi.TabIndex = 12;
            this.btnIzbrisi.Text = "Izbriši";
            this.btnIzbrisi.UseVisualStyleBackColor = false;
            this.btnIzbrisi.Click += new System.EventHandler(this.btnIzbrisi_Click);
            // 
            // lbNaslovU
            // 
            this.lbNaslovU.AutoSize = true;
            this.lbNaslovU.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbNaslovU.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNaslovU.Location = new System.Drawing.Point(549, 55);
            this.lbNaslovU.Name = "lbNaslovU";
            this.lbNaslovU.Size = new System.Drawing.Size(112, 38);
            this.lbNaslovU.TabIndex = 13;
            this.lbNaslovU.Text = "MAVZ";
            // 
            // FrmIzmjena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(744, 440);
            this.Controls.Add(this.lbNaslovU);
            this.Controls.Add(this.btnIzbrisi);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.lbVrijemeDol);
            this.Controls.Add(this.lbVrijemePol);
            this.Controls.Add(this.lbLinija);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.txtVrijemeDol);
            this.Controls.Add(this.txtVrijemePol);
            this.Controls.Add(this.txtLinija);
            this.Controls.Add(this.numId);
            this.Controls.Add(this.cbOdabir);
            this.Name = "FrmIzmjena";
            this.Text = "Izmjena";
            this.Load += new System.EventHandler(this.FrmIzmjena_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbOdabir;
        private System.Windows.Forms.TextBox numId;
        private System.Windows.Forms.TextBox txtLinija;
        private System.Windows.Forms.TextBox txtVrijemeDol;
        private System.Windows.Forms.TextBox txtVrijemePol;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label lbLinija;
        private System.Windows.Forms.Label lbVrijemeDol;
        private System.Windows.Forms.Label lbVrijemePol;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnAzuriraj;
        private System.Windows.Forms.Button btnIzbrisi;
        private System.Windows.Forms.Label lbNaslovU;
    }
}