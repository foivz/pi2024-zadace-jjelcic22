namespace MAVZ
{
    partial class FrmIzbornik
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnIzmjena = new System.Windows.Forms.Button();
            this.lbNaslov = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(156, 185);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(152, 27);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Pretraživanje stavke";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnIzmjena
            // 
            this.btnIzmjena.Location = new System.Drawing.Point(156, 126);
            this.btnIzmjena.Name = "btnIzmjena";
            this.btnIzmjena.Size = new System.Drawing.Size(152, 27);
            this.btnIzmjena.TabIndex = 2;
            this.btnIzmjena.Text = "Izmjeni stavke";
            this.btnIzmjena.UseVisualStyleBackColor = true;
            this.btnIzmjena.Click += new System.EventHandler(this.btnIzmjena_Click);
            // 
            // lbNaslov
            // 
            this.lbNaslov.AutoSize = true;
            this.lbNaslov.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbNaslov.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNaslov.Location = new System.Drawing.Point(186, 49);
            this.lbNaslov.Name = "lbNaslov";
            this.lbNaslov.Size = new System.Drawing.Size(83, 31);
            this.lbNaslov.TabIndex = 3;
            this.lbNaslov.Text = "MAVZ";
            this.lbNaslov.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmIzbornik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(502, 303);
            this.Controls.Add(this.lbNaslov);
            this.Controls.Add(this.btnIzmjena);
            this.Controls.Add(this.btnSearch);
            this.Name = "FrmIzbornik";
            this.Text = "FrmIzbornik";
            this.Load += new System.EventHandler(this.FrmIzbornik_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnIzmjena;
        private System.Windows.Forms.Label lbNaslov;
    }
}