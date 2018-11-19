namespace Biblioteka_w_Dotnet
{
    partial class Biblioteka
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
            this.groupBoxListaWypozyczajacych = new System.Windows.Forms.GroupBox();
            this.dgvListaWypozyczajacych = new System.Windows.Forms.DataGridView();
            this.groupBoxKsiazkiWypozyczone = new System.Windows.Forms.GroupBox();
            this.dgvKsiazkiWypozyczone = new System.Windows.Forms.DataGridView();
            this.groupBoxWyszukiwarka = new System.Windows.Forms.GroupBox();
            this.btnListaKsiazek = new System.Windows.Forms.Button();
            this.lblMiejscowosc = new System.Windows.Forms.Label();
            this.lblNazwisko = new System.Windows.Forms.Label();
            this.lblImie = new System.Windows.Forms.Label();
            this.btnUsunOsobe = new System.Windows.Forms.Button();
            this.btnEdytujOsobe = new System.Windows.Forms.Button();
            this.btnDodajOsobe = new System.Windows.Forms.Button();
            this.btnWyczysc = new System.Windows.Forms.Button();
            this.btnSzukaj = new System.Windows.Forms.Button();
            this.txtBoxMiejscowosc = new System.Windows.Forms.TextBox();
            this.txtBoxNazwisko = new System.Windows.Forms.TextBox();
            this.txtBoxImie = new System.Windows.Forms.TextBox();
            this.txtBoxDane = new System.Windows.Forms.TextBox();
            this.groupBoxListaWypozyczajacych.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaWypozyczajacych)).BeginInit();
            this.groupBoxKsiazkiWypozyczone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKsiazkiWypozyczone)).BeginInit();
            this.groupBoxWyszukiwarka.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxListaWypozyczajacych
            // 
            this.groupBoxListaWypozyczajacych.Controls.Add(this.dgvListaWypozyczajacych);
            this.groupBoxListaWypozyczajacych.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxListaWypozyczajacych.Location = new System.Drawing.Point(9, 11);
            this.groupBoxListaWypozyczajacych.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxListaWypozyczajacych.Name = "groupBoxListaWypozyczajacych";
            this.groupBoxListaWypozyczajacych.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxListaWypozyczajacych.Size = new System.Drawing.Size(620, 501);
            this.groupBoxListaWypozyczajacych.TabIndex = 0;
            this.groupBoxListaWypozyczajacych.TabStop = false;
            this.groupBoxListaWypozyczajacych.Text = "Lista Wypożyczających";
            // 
            // dgvListaWypozyczajacych
            // 
            this.dgvListaWypozyczajacych.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaWypozyczajacych.Location = new System.Drawing.Point(4, 26);
            this.dgvListaWypozyczajacych.Margin = new System.Windows.Forms.Padding(2);
            this.dgvListaWypozyczajacych.MultiSelect = false;
            this.dgvListaWypozyczajacych.Name = "dgvListaWypozyczajacych";
            this.dgvListaWypozyczajacych.RowTemplate.Height = 24;
            this.dgvListaWypozyczajacych.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaWypozyczajacych.Size = new System.Drawing.Size(608, 460);
            this.dgvListaWypozyczajacych.TabIndex = 1;
            this.dgvListaWypozyczajacych.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaWypozyczajacych_CellContentClick);
            // 
            // groupBoxKsiazkiWypozyczone
            // 
            this.groupBoxKsiazkiWypozyczone.Controls.Add(this.dgvKsiazkiWypozyczone);
            this.groupBoxKsiazkiWypozyczone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxKsiazkiWypozyczone.Location = new System.Drawing.Point(633, 11);
            this.groupBoxKsiazkiWypozyczone.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxKsiazkiWypozyczone.Name = "groupBoxKsiazkiWypozyczone";
            this.groupBoxKsiazkiWypozyczone.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxKsiazkiWypozyczone.Size = new System.Drawing.Size(620, 501);
            this.groupBoxKsiazkiWypozyczone.TabIndex = 1;
            this.groupBoxKsiazkiWypozyczone.TabStop = false;
            this.groupBoxKsiazkiWypozyczone.Text = "Książki wypożyczone przez zaznaczoną osobę";
            // 
            // dgvKsiazkiWypozyczone
            // 
            this.dgvKsiazkiWypozyczone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKsiazkiWypozyczone.Location = new System.Drawing.Point(5, 26);
            this.dgvKsiazkiWypozyczone.Margin = new System.Windows.Forms.Padding(2);
            this.dgvKsiazkiWypozyczone.Name = "dgvKsiazkiWypozyczone";
            this.dgvKsiazkiWypozyczone.RowTemplate.Height = 24;
            this.dgvKsiazkiWypozyczone.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKsiazkiWypozyczone.Size = new System.Drawing.Size(608, 459);
            this.dgvKsiazkiWypozyczone.TabIndex = 2;
            this.dgvKsiazkiWypozyczone.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKsiazkiWypozyczone_CellContentClick);
            // 
            // groupBoxWyszukiwarka
            // 
            this.groupBoxWyszukiwarka.Controls.Add(this.btnListaKsiazek);
            this.groupBoxWyszukiwarka.Controls.Add(this.lblMiejscowosc);
            this.groupBoxWyszukiwarka.Controls.Add(this.lblNazwisko);
            this.groupBoxWyszukiwarka.Controls.Add(this.lblImie);
            this.groupBoxWyszukiwarka.Controls.Add(this.btnUsunOsobe);
            this.groupBoxWyszukiwarka.Controls.Add(this.btnEdytujOsobe);
            this.groupBoxWyszukiwarka.Controls.Add(this.btnDodajOsobe);
            this.groupBoxWyszukiwarka.Controls.Add(this.btnWyczysc);
            this.groupBoxWyszukiwarka.Controls.Add(this.btnSzukaj);
            this.groupBoxWyszukiwarka.Controls.Add(this.txtBoxMiejscowosc);
            this.groupBoxWyszukiwarka.Controls.Add(this.txtBoxNazwisko);
            this.groupBoxWyszukiwarka.Controls.Add(this.txtBoxImie);
            this.groupBoxWyszukiwarka.Controls.Add(this.txtBoxDane);
            this.groupBoxWyszukiwarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxWyszukiwarka.Location = new System.Drawing.Point(13, 530);
            this.groupBoxWyszukiwarka.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxWyszukiwarka.Name = "groupBoxWyszukiwarka";
            this.groupBoxWyszukiwarka.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxWyszukiwarka.Size = new System.Drawing.Size(1240, 386);
            this.groupBoxWyszukiwarka.TabIndex = 2;
            this.groupBoxWyszukiwarka.TabStop = false;
            this.groupBoxWyszukiwarka.Text = "Wyszukiwarka";
            // 
            // btnListaKsiazek
            // 
            this.btnListaKsiazek.Location = new System.Drawing.Point(674, 229);
            this.btnListaKsiazek.Margin = new System.Windows.Forms.Padding(2);
            this.btnListaKsiazek.Name = "btnListaKsiazek";
            this.btnListaKsiazek.Size = new System.Drawing.Size(180, 50);
            this.btnListaKsiazek.TabIndex = 13;
            this.btnListaKsiazek.Text = "Wypożycz";
            this.btnListaKsiazek.UseVisualStyleBackColor = true;
            this.btnListaKsiazek.Click += new System.EventHandler(this.btnListaKsiazek_Click);
            // 
            // lblMiejscowosc
            // 
            this.lblMiejscowosc.AutoSize = true;
            this.lblMiejscowosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMiejscowosc.Location = new System.Drawing.Point(15, 238);
            this.lblMiejscowosc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMiejscowosc.Name = "lblMiejscowosc";
            this.lblMiejscowosc.Size = new System.Drawing.Size(153, 29);
            this.lblMiejscowosc.TabIndex = 12;
            this.lblMiejscowosc.Text = "Miejscowość";
            // 
            // lblNazwisko
            // 
            this.lblNazwisko.AutoSize = true;
            this.lblNazwisko.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNazwisko.Location = new System.Drawing.Point(15, 163);
            this.lblNazwisko.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNazwisko.Name = "lblNazwisko";
            this.lblNazwisko.Size = new System.Drawing.Size(117, 29);
            this.lblNazwisko.TabIndex = 11;
            this.lblNazwisko.Text = "Nazwisko";
            // 
            // lblImie
            // 
            this.lblImie.AutoSize = true;
            this.lblImie.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblImie.Location = new System.Drawing.Point(17, 93);
            this.lblImie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblImie.Name = "lblImie";
            this.lblImie.Size = new System.Drawing.Size(59, 29);
            this.lblImie.TabIndex = 10;
            this.lblImie.Text = "Imię";
            // 
            // btnUsunOsobe
            // 
            this.btnUsunOsobe.Location = new System.Drawing.Point(382, 310);
            this.btnUsunOsobe.Margin = new System.Windows.Forms.Padding(2);
            this.btnUsunOsobe.Name = "btnUsunOsobe";
            this.btnUsunOsobe.Size = new System.Drawing.Size(150, 50);
            this.btnUsunOsobe.TabIndex = 8;
            this.btnUsunOsobe.Text = "Usuń osobę";
            this.btnUsunOsobe.UseVisualStyleBackColor = true;
            // 
            // btnEdytujOsobe
            // 
            this.btnEdytujOsobe.Location = new System.Drawing.Point(205, 310);
            this.btnEdytujOsobe.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdytujOsobe.Name = "btnEdytujOsobe";
            this.btnEdytujOsobe.Size = new System.Drawing.Size(150, 50);
            this.btnEdytujOsobe.TabIndex = 7;
            this.btnEdytujOsobe.Text = "Edytuj osobę";
            this.btnEdytujOsobe.UseVisualStyleBackColor = true;
            // 
            // btnDodajOsobe
            // 
            this.btnDodajOsobe.Location = new System.Drawing.Point(20, 310);
            this.btnDodajOsobe.Margin = new System.Windows.Forms.Padding(2);
            this.btnDodajOsobe.Name = "btnDodajOsobe";
            this.btnDodajOsobe.Size = new System.Drawing.Size(150, 50);
            this.btnDodajOsobe.TabIndex = 6;
            this.btnDodajOsobe.Text = "Dodaj osobę";
            this.btnDodajOsobe.UseVisualStyleBackColor = true;
            // 
            // btnWyczysc
            // 
            this.btnWyczysc.Location = new System.Drawing.Point(674, 127);
            this.btnWyczysc.Margin = new System.Windows.Forms.Padding(2);
            this.btnWyczysc.Name = "btnWyczysc";
            this.btnWyczysc.Size = new System.Drawing.Size(180, 50);
            this.btnWyczysc.TabIndex = 5;
            this.btnWyczysc.Text = "Wyczyść";
            this.btnWyczysc.UseVisualStyleBackColor = true;
            // 
            // btnSzukaj
            // 
            this.btnSzukaj.Location = new System.Drawing.Point(674, 21);
            this.btnSzukaj.Margin = new System.Windows.Forms.Padding(2);
            this.btnSzukaj.Name = "btnSzukaj";
            this.btnSzukaj.Size = new System.Drawing.Size(180, 50);
            this.btnSzukaj.TabIndex = 4;
            this.btnSzukaj.Text = "Szukaj";
            this.btnSzukaj.UseVisualStyleBackColor = true;
            this.btnSzukaj.Click += new System.EventHandler(this.btnSzukaj_Click);
            // 
            // txtBoxMiejscowosc
            // 
            this.txtBoxMiejscowosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxMiejscowosc.Location = new System.Drawing.Point(185, 232);
            this.txtBoxMiejscowosc.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxMiejscowosc.Name = "txtBoxMiejscowosc";
            this.txtBoxMiejscowosc.Size = new System.Drawing.Size(305, 38);
            this.txtBoxMiejscowosc.TabIndex = 3;
            // 
            // txtBoxNazwisko
            // 
            this.txtBoxNazwisko.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxNazwisko.Location = new System.Drawing.Point(185, 157);
            this.txtBoxNazwisko.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxNazwisko.Name = "txtBoxNazwisko";
            this.txtBoxNazwisko.Size = new System.Drawing.Size(305, 38);
            this.txtBoxNazwisko.TabIndex = 2;
            // 
            // txtBoxImie
            // 
            this.txtBoxImie.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxImie.Location = new System.Drawing.Point(185, 87);
            this.txtBoxImie.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxImie.Name = "txtBoxImie";
            this.txtBoxImie.Size = new System.Drawing.Size(305, 38);
            this.txtBoxImie.TabIndex = 1;
            // 
            // txtBoxDane
            // 
            this.txtBoxDane.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxDane.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtBoxDane.Location = new System.Drawing.Point(99, 24);
            this.txtBoxDane.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxDane.Name = "txtBoxDane";
            this.txtBoxDane.Size = new System.Drawing.Size(551, 38);
            this.txtBoxDane.TabIndex = 0;
            this.txtBoxDane.Text = "Wprowadź imię, nazwisko lub miejscowość";
            this.txtBoxDane.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBoxDane_MouseClick);
            // 
            // Biblioteka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 941);
            this.Controls.Add(this.groupBoxWyszukiwarka);
            this.Controls.Add(this.groupBoxKsiazkiWypozyczone);
            this.Controls.Add(this.groupBoxListaWypozyczajacych);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Biblioteka";
            this.Text = "biblioteka";
            this.groupBoxListaWypozyczajacych.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaWypozyczajacych)).EndInit();
            this.groupBoxKsiazkiWypozyczone.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKsiazkiWypozyczone)).EndInit();
            this.groupBoxWyszukiwarka.ResumeLayout(false);
            this.groupBoxWyszukiwarka.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxListaWypozyczajacych;
        private System.Windows.Forms.GroupBox groupBoxKsiazkiWypozyczone;
        public System.Windows.Forms.DataGridView dgvListaWypozyczajacych;
        private System.Windows.Forms.DataGridView dgvKsiazkiWypozyczone;
        private System.Windows.Forms.GroupBox groupBoxWyszukiwarka;
        public System.Windows.Forms.Button btnListaKsiazek;
        private System.Windows.Forms.Label lblMiejscowosc;
        private System.Windows.Forms.Label lblNazwisko;
        private System.Windows.Forms.Label lblImie;
        private System.Windows.Forms.Button btnUsunOsobe;
        private System.Windows.Forms.Button btnEdytujOsobe;
        private System.Windows.Forms.Button btnDodajOsobe;
        private System.Windows.Forms.Button btnWyczysc;
        private System.Windows.Forms.Button btnSzukaj;
        private System.Windows.Forms.TextBox txtBoxMiejscowosc;
        private System.Windows.Forms.TextBox txtBoxNazwisko;
        private System.Windows.Forms.TextBox txtBoxImie;
        private System.Windows.Forms.TextBox txtBoxDane;
    }
}