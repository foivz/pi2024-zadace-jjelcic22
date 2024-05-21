namespace MAVZ
{
    partial class FrmPretrazitelj
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
            this.txtSearchB = new System.Windows.Forms.TextBox();
            this.dvgVozniRed = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dvgVozniRed)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearchB
            // 
            this.txtSearchB.Location = new System.Drawing.Point(34, 35);
            this.txtSearchB.Name = "txtSearchB";
            this.txtSearchB.Size = new System.Drawing.Size(554, 22);
            this.txtSearchB.TabIndex = 1;
            this.txtSearchB.TextChanged += new System.EventHandler(this.txtSearchB_TextChanged);
            // 
            // dvgVozniRed
            // 
            this.dvgVozniRed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgVozniRed.Location = new System.Drawing.Point(34, 98);
            this.dvgVozniRed.Name = "dvgVozniRed";
            this.dvgVozniRed.RowHeadersWidth = 51;
            this.dvgVozniRed.RowTemplate.Height = 24;
            this.dvgVozniRed.Size = new System.Drawing.Size(553, 203);
            this.dvgVozniRed.TabIndex = 0;
            this.dvgVozniRed.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FrmPretrazitelj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(624, 384);
            this.Controls.Add(this.dvgVozniRed);
            this.Controls.Add(this.txtSearchB);
            this.Name = "FrmPretrazitelj";
            this.Text = "Pretrazivanje";
            this.Load += new System.EventHandler(this.FrmPretrazitelj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgVozniRed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearchB;
        private System.Windows.Forms.DataGridView dvgVozniRed;
    }
}