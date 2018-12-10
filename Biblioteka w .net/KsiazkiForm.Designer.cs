namespace Biblioteka_w_Dotnet
{
    partial class KsiazkiForm
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
            this.dgvKsiazki = new System.Windows.Forms.DataGridView();
            this.btnWypozycz = new System.Windows.Forms.Button();
            this.btnAnuluj = new System.Windows.Forms.Button();
            this.btnSzukaj = new System.Windows.Forms.Button();
            this.txtBoxSzukaj = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKsiazki)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKsiazki
            // 
            this.dgvKsiazki.AllowUserToAddRows = false;
            this.dgvKsiazki.AllowUserToDeleteRows = false;
            this.dgvKsiazki.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKsiazki.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvKsiazki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKsiazki.Location = new System.Drawing.Point(9, 10);
            this.dgvKsiazki.Margin = new System.Windows.Forms.Padding(2);
            this.dgvKsiazki.Name = "dgvKsiazki";
            this.dgvKsiazki.ReadOnly = true;
            this.dgvKsiazki.RowTemplate.Height = 24;
            this.dgvKsiazki.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKsiazki.Size = new System.Drawing.Size(682, 248);
            this.dgvKsiazki.TabIndex = 0;
            // 
            // btnWypozycz
            // 
            this.btnWypozycz.Location = new System.Drawing.Point(122, 366);
            this.btnWypozycz.Margin = new System.Windows.Forms.Padding(2);
            this.btnWypozycz.Name = "btnWypozycz";
            this.btnWypozycz.Size = new System.Drawing.Size(114, 41);
            this.btnWypozycz.TabIndex = 1;
            this.btnWypozycz.Text = "Wypożycz";
            this.btnWypozycz.UseVisualStyleBackColor = true;
            this.btnWypozycz.Click += new System.EventHandler(this.btnWypozycz_Click);
            // 
            // btnAnuluj
            // 
            this.btnAnuluj.Location = new System.Drawing.Point(380, 358);
            this.btnAnuluj.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnuluj.Name = "btnAnuluj";
            this.btnAnuluj.Size = new System.Drawing.Size(114, 41);
            this.btnAnuluj.TabIndex = 2;
            this.btnAnuluj.Text = "Anuluj";
            this.btnAnuluj.UseVisualStyleBackColor = true;
            this.btnAnuluj.Click += new System.EventHandler(this.btnAnuluj_Click);
            // 
            // btnSzukaj
            // 
            this.btnSzukaj.Location = new System.Drawing.Point(540, 285);
            this.btnSzukaj.Margin = new System.Windows.Forms.Padding(2);
            this.btnSzukaj.Name = "btnSzukaj";
            this.btnSzukaj.Size = new System.Drawing.Size(98, 41);
            this.btnSzukaj.TabIndex = 3;
            this.btnSzukaj.Text = "Szukaj";
            this.btnSzukaj.UseVisualStyleBackColor = true;
            this.btnSzukaj.Click += new System.EventHandler(this.btnSzukaj_Click);
            // 
            // txtBoxSzukaj
            // 
            this.txtBoxSzukaj.Location = new System.Drawing.Point(76, 297);
            this.txtBoxSzukaj.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxSzukaj.Name = "txtBoxSzukaj";
            this.txtBoxSzukaj.Size = new System.Drawing.Size(398, 20);
            this.txtBoxSzukaj.TabIndex = 4;
            // 
            // KsiazkiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 431);
            this.Controls.Add(this.txtBoxSzukaj);
            this.Controls.Add(this.btnSzukaj);
            this.Controls.Add(this.btnAnuluj);
            this.Controls.Add(this.btnWypozycz);
            this.Controls.Add(this.dgvKsiazki);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "KsiazkiForm";
            this.Text = "Biblioteka";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKsiazki)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKsiazki;
        private System.Windows.Forms.Button btnAnuluj;
        private System.Windows.Forms.Button btnSzukaj;
        private System.Windows.Forms.TextBox txtBoxSzukaj;
        public System.Windows.Forms.Button btnWypozycz;
    }
}