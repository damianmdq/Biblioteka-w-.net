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
            this.btnEdytujOsobe = new System.Windows.Forms.Button();
            this.btnUsunOsobe = new System.Windows.Forms.Button();
            this.btnWyczysc = new System.Windows.Forms.Button();
            this.lblImie = new System.Windows.Forms.Label();
            this.btnDodajOsobe = new System.Windows.Forms.Button();
            this.btnSzukaj = new System.Windows.Forms.Button();
            this.txtBoxMiejscowosc = new System.Windows.Forms.TextBox();
            this.txtBoxNazwisko = new System.Windows.Forms.TextBox();
            this.txtBoxImie = new System.Windows.Forms.TextBox();
            this.txtBoxDane = new System.Windows.Forms.TextBox();
            this.tabControlBiblioteka = new System.Windows.Forms.TabControl();
            this.tabPageWypozyczenia = new System.Windows.Forms.TabPage();
            this.tabPageKsiazki = new System.Windows.Forms.TabPage();
            this.groupBoxEdytor = new System.Windows.Forms.GroupBox();
            this.btnSzukajKsiazki = new System.Windows.Forms.Button();
            this.txtBoxSzukajKsiazki = new System.Windows.Forms.TextBox();
            this.btnUsunKsiazke = new System.Windows.Forms.Button();
            this.btnEdytujKsiazke = new System.Windows.Forms.Button();
            this.btnDodajKsiazke = new System.Windows.Forms.Button();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblOpis = new System.Windows.Forms.Label();
            this.lblTytul = new System.Windows.Forms.Label();
            this.lblKategoria = new System.Windows.Forms.Label();
            this.lblIloscWBibliotece = new System.Windows.Forms.Label();
            this.lblPosiadanaIlosc = new System.Windows.Forms.Label();
            this.lblRokWydania = new System.Windows.Forms.Label();
            this.lblWydawnictwo = new System.Windows.Forms.Label();
            this.txtBoxIloscWBibliotece = new System.Windows.Forms.TextBox();
            this.txtBoxRokWydania = new System.Windows.Forms.TextBox();
            this.txtBoxPosiadanaIlosc = new System.Windows.Forms.TextBox();
            this.txtBoxAutor = new System.Windows.Forms.TextBox();
            this.txtBoxWydawnictwo = new System.Windows.Forms.TextBox();
            this.txtBoxOpis = new System.Windows.Forms.TextBox();
            this.txtBoxTytul = new System.Windows.Forms.TextBox();
            this.txtBoxKategoria = new System.Windows.Forms.TextBox();
            this.groupBoxKsiazki = new System.Windows.Forms.GroupBox();
            this.dgvKsiazki = new System.Windows.Forms.DataGridView();
            this.tabPageUzytkownicy = new System.Windows.Forms.TabPage();
            this.groupBoxListaWypozyczajacych.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaWypozyczajacych)).BeginInit();
            this.groupBoxKsiazkiWypozyczone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKsiazkiWypozyczone)).BeginInit();
            this.groupBoxWyszukiwarka.SuspendLayout();
            this.tabControlBiblioteka.SuspendLayout();
            this.tabPageWypozyczenia.SuspendLayout();
            this.tabPageKsiazki.SuspendLayout();
            this.groupBoxEdytor.SuspendLayout();
            this.groupBoxKsiazki.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKsiazki)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxListaWypozyczajacych
            // 
            this.groupBoxListaWypozyczajacych.AutoSize = true;
            this.groupBoxListaWypozyczajacych.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxListaWypozyczajacych.Controls.Add(this.dgvListaWypozyczajacych);
            this.groupBoxListaWypozyczajacych.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxListaWypozyczajacych.Location = new System.Drawing.Point(5, 5);
            this.groupBoxListaWypozyczajacych.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxListaWypozyczajacych.Name = "groupBoxListaWypozyczajacych";
            this.groupBoxListaWypozyczajacych.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxListaWypozyczajacych.Size = new System.Drawing.Size(516, 278);
            this.groupBoxListaWypozyczajacych.TabIndex = 0;
            this.groupBoxListaWypozyczajacych.TabStop = false;
            this.groupBoxListaWypozyczajacych.Text = "Lista Wypożyczających";
            // 
            // dgvListaWypozyczajacych
            // 
            this.dgvListaWypozyczajacych.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaWypozyczajacych.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListaWypozyczajacych.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaWypozyczajacych.Location = new System.Drawing.Point(4, 26);
            this.dgvListaWypozyczajacych.Margin = new System.Windows.Forms.Padding(2);
            this.dgvListaWypozyczajacych.MultiSelect = false;
            this.dgvListaWypozyczajacych.Name = "dgvListaWypozyczajacych";
            this.dgvListaWypozyczajacych.RowTemplate.Height = 24;
            this.dgvListaWypozyczajacych.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaWypozyczajacych.Size = new System.Drawing.Size(508, 226);
            this.dgvListaWypozyczajacych.TabIndex = 1;
            this.dgvListaWypozyczajacych.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaWypozyczajacych_CellContentClick);
            // 
            // groupBoxKsiazkiWypozyczone
            // 
            this.groupBoxKsiazkiWypozyczone.AutoSize = true;
            this.groupBoxKsiazkiWypozyczone.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxKsiazkiWypozyczone.Controls.Add(this.dgvKsiazkiWypozyczone);
            this.groupBoxKsiazkiWypozyczone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxKsiazkiWypozyczone.Location = new System.Drawing.Point(525, 5);
            this.groupBoxKsiazkiWypozyczone.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxKsiazkiWypozyczone.Name = "groupBoxKsiazkiWypozyczone";
            this.groupBoxKsiazkiWypozyczone.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxKsiazkiWypozyczone.Size = new System.Drawing.Size(506, 278);
            this.groupBoxKsiazkiWypozyczone.TabIndex = 1;
            this.groupBoxKsiazkiWypozyczone.TabStop = false;
            this.groupBoxKsiazkiWypozyczone.Text = "Książki wypożyczone przez zaznaczoną osobę";
            // 
            // dgvKsiazkiWypozyczone
            // 
            this.dgvKsiazkiWypozyczone.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKsiazkiWypozyczone.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvKsiazkiWypozyczone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKsiazkiWypozyczone.Location = new System.Drawing.Point(1, 26);
            this.dgvKsiazkiWypozyczone.Margin = new System.Windows.Forms.Padding(2);
            this.dgvKsiazkiWypozyczone.Name = "dgvKsiazkiWypozyczone";
            this.dgvKsiazkiWypozyczone.RowTemplate.Height = 24;
            this.dgvKsiazkiWypozyczone.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKsiazkiWypozyczone.Size = new System.Drawing.Size(501, 226);
            this.dgvKsiazkiWypozyczone.TabIndex = 2;
            this.dgvKsiazkiWypozyczone.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKsiazkiWypozyczone_CellContentClick);
            // 
            // groupBoxWyszukiwarka
            // 
            this.groupBoxWyszukiwarka.AutoSize = true;
            this.groupBoxWyszukiwarka.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxWyszukiwarka.Controls.Add(this.btnListaKsiazek);
            this.groupBoxWyszukiwarka.Controls.Add(this.lblMiejscowosc);
            this.groupBoxWyszukiwarka.Controls.Add(this.lblNazwisko);
            this.groupBoxWyszukiwarka.Controls.Add(this.btnEdytujOsobe);
            this.groupBoxWyszukiwarka.Controls.Add(this.btnUsunOsobe);
            this.groupBoxWyszukiwarka.Controls.Add(this.btnWyczysc);
            this.groupBoxWyszukiwarka.Controls.Add(this.lblImie);
            this.groupBoxWyszukiwarka.Controls.Add(this.btnDodajOsobe);
            this.groupBoxWyszukiwarka.Controls.Add(this.btnSzukaj);
            this.groupBoxWyszukiwarka.Controls.Add(this.txtBoxMiejscowosc);
            this.groupBoxWyszukiwarka.Controls.Add(this.txtBoxNazwisko);
            this.groupBoxWyszukiwarka.Controls.Add(this.txtBoxImie);
            this.groupBoxWyszukiwarka.Controls.Add(this.txtBoxDane);
            this.groupBoxWyszukiwarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxWyszukiwarka.Location = new System.Drawing.Point(9, 287);
            this.groupBoxWyszukiwarka.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxWyszukiwarka.Name = "groupBoxWyszukiwarka";
            this.groupBoxWyszukiwarka.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxWyszukiwarka.Size = new System.Drawing.Size(665, 263);
            this.groupBoxWyszukiwarka.TabIndex = 2;
            this.groupBoxWyszukiwarka.TabStop = false;
            this.groupBoxWyszukiwarka.Text = "Wyszukiwarka";
            // 
            // btnListaKsiazek
            // 
            this.btnListaKsiazek.Location = new System.Drawing.Point(481, 131);
            this.btnListaKsiazek.Margin = new System.Windows.Forms.Padding(2);
            this.btnListaKsiazek.Name = "btnListaKsiazek";
            this.btnListaKsiazek.Size = new System.Drawing.Size(180, 41);
            this.btnListaKsiazek.TabIndex = 13;
            this.btnListaKsiazek.Text = "Wypożycz";
            this.btnListaKsiazek.UseVisualStyleBackColor = true;
            this.btnListaKsiazek.Click += new System.EventHandler(this.btnListaKsiazek_Click);
            // 
            // lblMiejscowosc
            // 
            this.lblMiejscowosc.AutoSize = true;
            this.lblMiejscowosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMiejscowosc.Location = new System.Drawing.Point(15, 164);
            this.lblMiejscowosc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMiejscowosc.Name = "lblMiejscowosc";
            this.lblMiejscowosc.Size = new System.Drawing.Size(119, 24);
            this.lblMiejscowosc.TabIndex = 12;
            this.lblMiejscowosc.Text = "Miejscowość";
            // 
            // lblNazwisko
            // 
            this.lblNazwisko.AutoSize = true;
            this.lblNazwisko.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNazwisko.Location = new System.Drawing.Point(15, 115);
            this.lblNazwisko.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNazwisko.Name = "lblNazwisko";
            this.lblNazwisko.Size = new System.Drawing.Size(90, 24);
            this.lblNazwisko.TabIndex = 11;
            this.lblNazwisko.Text = "Nazwisko";
            // 
            // btnEdytujOsobe
            // 
            this.btnEdytujOsobe.Location = new System.Drawing.Point(247, 196);
            this.btnEdytujOsobe.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdytujOsobe.Name = "btnEdytujOsobe";
            this.btnEdytujOsobe.Size = new System.Drawing.Size(150, 41);
            this.btnEdytujOsobe.TabIndex = 7;
            this.btnEdytujOsobe.Text = "Edytuj osobę";
            this.btnEdytujOsobe.UseVisualStyleBackColor = true;
            // 
            // btnUsunOsobe
            // 
            this.btnUsunOsobe.Location = new System.Drawing.Point(469, 196);
            this.btnUsunOsobe.Margin = new System.Windows.Forms.Padding(2);
            this.btnUsunOsobe.Name = "btnUsunOsobe";
            this.btnUsunOsobe.Size = new System.Drawing.Size(150, 41);
            this.btnUsunOsobe.TabIndex = 8;
            this.btnUsunOsobe.Text = "Usuń osobę";
            this.btnUsunOsobe.UseVisualStyleBackColor = true;
            // 
            // btnWyczysc
            // 
            this.btnWyczysc.Location = new System.Drawing.Point(481, 78);
            this.btnWyczysc.Margin = new System.Windows.Forms.Padding(2);
            this.btnWyczysc.Name = "btnWyczysc";
            this.btnWyczysc.Size = new System.Drawing.Size(180, 41);
            this.btnWyczysc.TabIndex = 5;
            this.btnWyczysc.Text = "Wyczyść";
            this.btnWyczysc.UseVisualStyleBackColor = true;
            // 
            // lblImie
            // 
            this.lblImie.AutoSize = true;
            this.lblImie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblImie.Location = new System.Drawing.Point(36, 74);
            this.lblImie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblImie.Name = "lblImie";
            this.lblImie.Size = new System.Drawing.Size(45, 24);
            this.lblImie.TabIndex = 10;
            this.lblImie.Text = "Imię";
            // 
            // btnDodajOsobe
            // 
            this.btnDodajOsobe.Location = new System.Drawing.Point(31, 196);
            this.btnDodajOsobe.Margin = new System.Windows.Forms.Padding(2);
            this.btnDodajOsobe.Name = "btnDodajOsobe";
            this.btnDodajOsobe.Size = new System.Drawing.Size(150, 41);
            this.btnDodajOsobe.TabIndex = 6;
            this.btnDodajOsobe.Text = "Dodaj osobę";
            this.btnDodajOsobe.UseVisualStyleBackColor = true;
            // 
            // btnSzukaj
            // 
            this.btnSzukaj.Location = new System.Drawing.Point(481, 21);
            this.btnSzukaj.Margin = new System.Windows.Forms.Padding(2);
            this.btnSzukaj.Name = "btnSzukaj";
            this.btnSzukaj.Size = new System.Drawing.Size(180, 41);
            this.btnSzukaj.TabIndex = 4;
            this.btnSzukaj.Text = "Szukaj";
            this.btnSzukaj.UseVisualStyleBackColor = true;
            this.btnSzukaj.Click += new System.EventHandler(this.btnSzukaj_Click);
            // 
            // txtBoxMiejscowosc
            // 
            this.txtBoxMiejscowosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxMiejscowosc.Location = new System.Drawing.Point(162, 160);
            this.txtBoxMiejscowosc.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxMiejscowosc.Name = "txtBoxMiejscowosc";
            this.txtBoxMiejscowosc.Size = new System.Drawing.Size(254, 32);
            this.txtBoxMiejscowosc.TabIndex = 3;
            // 
            // txtBoxNazwisko
            // 
            this.txtBoxNazwisko.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxNazwisko.Location = new System.Drawing.Point(162, 115);
            this.txtBoxNazwisko.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxNazwisko.Name = "txtBoxNazwisko";
            this.txtBoxNazwisko.Size = new System.Drawing.Size(254, 32);
            this.txtBoxNazwisko.TabIndex = 2;
            // 
            // txtBoxImie
            // 
            this.txtBoxImie.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxImie.Location = new System.Drawing.Point(162, 70);
            this.txtBoxImie.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxImie.Name = "txtBoxImie";
            this.txtBoxImie.Size = new System.Drawing.Size(254, 32);
            this.txtBoxImie.TabIndex = 1;
            // 
            // txtBoxDane
            // 
            this.txtBoxDane.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxDane.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtBoxDane.Location = new System.Drawing.Point(99, 24);
            this.txtBoxDane.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxDane.Name = "txtBoxDane";
            this.txtBoxDane.Size = new System.Drawing.Size(352, 32);
            this.txtBoxDane.TabIndex = 0;
            this.txtBoxDane.Text = "Wprowadź imię, nazwisko lub miejscowość";
            this.txtBoxDane.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBoxDane_MouseClick);
            // 
            // tabControlBiblioteka
            // 
            this.tabControlBiblioteka.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlBiblioteka.Controls.Add(this.tabPageWypozyczenia);
            this.tabControlBiblioteka.Controls.Add(this.tabPageKsiazki);
            this.tabControlBiblioteka.Controls.Add(this.tabPageUzytkownicy);
            this.tabControlBiblioteka.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabControlBiblioteka.HotTrack = true;
            this.tabControlBiblioteka.Location = new System.Drawing.Point(-3, -2);
            this.tabControlBiblioteka.Multiline = true;
            this.tabControlBiblioteka.Name = "tabControlBiblioteka";
            this.tabControlBiblioteka.SelectedIndex = 0;
            this.tabControlBiblioteka.Size = new System.Drawing.Size(1040, 595);
            this.tabControlBiblioteka.TabIndex = 3;
            // 
            // tabPageWypozyczenia
            // 
            this.tabPageWypozyczenia.Controls.Add(this.groupBoxListaWypozyczajacych);
            this.tabPageWypozyczenia.Controls.Add(this.groupBoxKsiazkiWypozyczone);
            this.tabPageWypozyczenia.Controls.Add(this.groupBoxWyszukiwarka);
            this.tabPageWypozyczenia.Location = new System.Drawing.Point(4, 4);
            this.tabPageWypozyczenia.Name = "tabPageWypozyczenia";
            this.tabPageWypozyczenia.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageWypozyczenia.Size = new System.Drawing.Size(1032, 558);
            this.tabPageWypozyczenia.TabIndex = 0;
            this.tabPageWypozyczenia.Text = "Wypożyczenia";
            this.tabPageWypozyczenia.UseVisualStyleBackColor = true;
            // 
            // tabPageKsiazki
            // 
            this.tabPageKsiazki.Controls.Add(this.groupBoxEdytor);
            this.tabPageKsiazki.Controls.Add(this.groupBoxKsiazki);
            this.tabPageKsiazki.Location = new System.Drawing.Point(4, 4);
            this.tabPageKsiazki.Name = "tabPageKsiazki";
            this.tabPageKsiazki.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageKsiazki.Size = new System.Drawing.Size(1032, 558);
            this.tabPageKsiazki.TabIndex = 1;
            this.tabPageKsiazki.Text = "Książki";
            this.tabPageKsiazki.UseVisualStyleBackColor = true;
            // 
            // groupBoxEdytor
            // 
            this.groupBoxEdytor.Controls.Add(this.btnSzukajKsiazki);
            this.groupBoxEdytor.Controls.Add(this.txtBoxSzukajKsiazki);
            this.groupBoxEdytor.Controls.Add(this.btnUsunKsiazke);
            this.groupBoxEdytor.Controls.Add(this.btnEdytujKsiazke);
            this.groupBoxEdytor.Controls.Add(this.btnDodajKsiazke);
            this.groupBoxEdytor.Controls.Add(this.lblAutor);
            this.groupBoxEdytor.Controls.Add(this.lblOpis);
            this.groupBoxEdytor.Controls.Add(this.lblTytul);
            this.groupBoxEdytor.Controls.Add(this.lblKategoria);
            this.groupBoxEdytor.Controls.Add(this.lblIloscWBibliotece);
            this.groupBoxEdytor.Controls.Add(this.lblPosiadanaIlosc);
            this.groupBoxEdytor.Controls.Add(this.lblRokWydania);
            this.groupBoxEdytor.Controls.Add(this.lblWydawnictwo);
            this.groupBoxEdytor.Controls.Add(this.txtBoxIloscWBibliotece);
            this.groupBoxEdytor.Controls.Add(this.txtBoxRokWydania);
            this.groupBoxEdytor.Controls.Add(this.txtBoxPosiadanaIlosc);
            this.groupBoxEdytor.Controls.Add(this.txtBoxAutor);
            this.groupBoxEdytor.Controls.Add(this.txtBoxWydawnictwo);
            this.groupBoxEdytor.Controls.Add(this.txtBoxOpis);
            this.groupBoxEdytor.Controls.Add(this.txtBoxTytul);
            this.groupBoxEdytor.Controls.Add(this.txtBoxKategoria);
            this.groupBoxEdytor.Location = new System.Drawing.Point(12, 285);
            this.groupBoxEdytor.Name = "groupBoxEdytor";
            this.groupBoxEdytor.Size = new System.Drawing.Size(1014, 267);
            this.groupBoxEdytor.TabIndex = 1;
            this.groupBoxEdytor.TabStop = false;
            this.groupBoxEdytor.Text = "Edytor";
            // 
            // btnSzukajKsiazki
            // 
            this.btnSzukajKsiazki.Location = new System.Drawing.Point(516, 22);
            this.btnSzukajKsiazki.Margin = new System.Windows.Forms.Padding(2);
            this.btnSzukajKsiazki.Name = "btnSzukajKsiazki";
            this.btnSzukajKsiazki.Size = new System.Drawing.Size(114, 38);
            this.btnSzukajKsiazki.TabIndex = 24;
            this.btnSzukajKsiazki.Text = "Szukaj";
            this.btnSzukajKsiazki.UseVisualStyleBackColor = true;
            this.btnSzukajKsiazki.Click += new System.EventHandler(this.btnSzukajKsiazki_Click);
            // 
            // txtBoxSzukajKsiazki
            // 
            this.txtBoxSzukajKsiazki.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxSzukajKsiazki.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtBoxSzukajKsiazki.Location = new System.Drawing.Point(133, 25);
            this.txtBoxSzukajKsiazki.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxSzukajKsiazki.Name = "txtBoxSzukajKsiazki";
            this.txtBoxSzukajKsiazki.Size = new System.Drawing.Size(352, 32);
            this.txtBoxSzukajKsiazki.TabIndex = 23;
            this.txtBoxSzukajKsiazki.Text = "Wprowadź dane ksiązki, którą chcesz wyszukać";
            this.txtBoxSzukajKsiazki.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBoxSzukajKsiazki_MouseClick);
            // 
            // btnUsunKsiazke
            // 
            this.btnUsunKsiazke.Location = new System.Drawing.Point(380, 218);
            this.btnUsunKsiazke.Name = "btnUsunKsiazke";
            this.btnUsunKsiazke.Size = new System.Drawing.Size(140, 38);
            this.btnUsunKsiazke.TabIndex = 22;
            this.btnUsunKsiazke.Text = "Usuń książkę";
            this.btnUsunKsiazke.UseVisualStyleBackColor = true;
            this.btnUsunKsiazke.Click += new System.EventHandler(this.btnUsunKsiazke_Click);
            // 
            // btnEdytujKsiazke
            // 
            this.btnEdytujKsiazke.Location = new System.Drawing.Point(212, 218);
            this.btnEdytujKsiazke.Name = "btnEdytujKsiazke";
            this.btnEdytujKsiazke.Size = new System.Drawing.Size(140, 38);
            this.btnEdytujKsiazke.TabIndex = 21;
            this.btnEdytujKsiazke.Text = "Edytuj książkę";
            this.btnEdytujKsiazke.UseVisualStyleBackColor = true;
            this.btnEdytujKsiazke.Click += new System.EventHandler(this.btnEdytujKsiazke_Click);
            // 
            // btnDodajKsiazke
            // 
            this.btnDodajKsiazke.Location = new System.Drawing.Point(48, 218);
            this.btnDodajKsiazke.Name = "btnDodajKsiazke";
            this.btnDodajKsiazke.Size = new System.Drawing.Size(137, 38);
            this.btnDodajKsiazke.TabIndex = 20;
            this.btnDodajKsiazke.Text = "Dodaj książkę";
            this.btnDodajKsiazke.UseVisualStyleBackColor = true;
            this.btnDodajKsiazke.Click += new System.EventHandler(this.btnDodajKsiazke_Click);
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(376, 143);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(55, 24);
            this.lblAutor.TabIndex = 19;
            this.lblAutor.Text = "Autor";
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Location = new System.Drawing.Point(376, 81);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(49, 24);
            this.lblOpis.TabIndex = 18;
            this.lblOpis.Text = "Opis";
            // 
            // lblTytul
            // 
            this.lblTytul.AutoSize = true;
            this.lblTytul.Location = new System.Drawing.Point(96, 141);
            this.lblTytul.Name = "lblTytul";
            this.lblTytul.Size = new System.Drawing.Size(54, 24);
            this.lblTytul.TabIndex = 17;
            this.lblTytul.Text = "Tytuł";
            // 
            // lblKategoria
            // 
            this.lblKategoria.AutoSize = true;
            this.lblKategoria.Location = new System.Drawing.Point(77, 81);
            this.lblKategoria.Name = "lblKategoria";
            this.lblKategoria.Size = new System.Drawing.Size(89, 24);
            this.lblKategoria.TabIndex = 16;
            this.lblKategoria.Text = "Kategoria";
            // 
            // lblIloscWBibliotece
            // 
            this.lblIloscWBibliotece.AutoSize = true;
            this.lblIloscWBibliotece.Location = new System.Drawing.Point(821, 143);
            this.lblIloscWBibliotece.Name = "lblIloscWBibliotece";
            this.lblIloscWBibliotece.Size = new System.Drawing.Size(153, 24);
            this.lblIloscWBibliotece.TabIndex = 15;
            this.lblIloscWBibliotece.Text = "Ilość w bibliotece";
            // 
            // lblPosiadanaIlosc
            // 
            this.lblPosiadanaIlosc.AutoSize = true;
            this.lblPosiadanaIlosc.Location = new System.Drawing.Point(833, 81);
            this.lblPosiadanaIlosc.Name = "lblPosiadanaIlosc";
            this.lblPosiadanaIlosc.Size = new System.Drawing.Size(141, 24);
            this.lblPosiadanaIlosc.TabIndex = 14;
            this.lblPosiadanaIlosc.Text = "Posiadana ilość";
            // 
            // lblRokWydania
            // 
            this.lblRokWydania.AutoSize = true;
            this.lblRokWydania.Location = new System.Drawing.Point(595, 143);
            this.lblRokWydania.Name = "lblRokWydania";
            this.lblRokWydania.Size = new System.Drawing.Size(117, 24);
            this.lblRokWydania.TabIndex = 13;
            this.lblRokWydania.Text = "Rok wydania";
            // 
            // lblWydawnictwo
            // 
            this.lblWydawnictwo.AutoSize = true;
            this.lblWydawnictwo.Location = new System.Drawing.Point(586, 81);
            this.lblWydawnictwo.Name = "lblWydawnictwo";
            this.lblWydawnictwo.Size = new System.Drawing.Size(126, 24);
            this.lblWydawnictwo.TabIndex = 12;
            this.lblWydawnictwo.Text = "Wydawnictwo";
            // 
            // txtBoxIloscWBibliotece
            // 
            this.txtBoxIloscWBibliotece.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxIloscWBibliotece.Location = new System.Drawing.Point(794, 169);
            this.txtBoxIloscWBibliotece.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxIloscWBibliotece.Name = "txtBoxIloscWBibliotece";
            this.txtBoxIloscWBibliotece.Size = new System.Drawing.Size(201, 32);
            this.txtBoxIloscWBibliotece.TabIndex = 11;
            // 
            // txtBoxRokWydania
            // 
            this.txtBoxRokWydania.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxRokWydania.Location = new System.Drawing.Point(536, 169);
            this.txtBoxRokWydania.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxRokWydania.Name = "txtBoxRokWydania";
            this.txtBoxRokWydania.Size = new System.Drawing.Size(254, 32);
            this.txtBoxRokWydania.TabIndex = 10;
            // 
            // txtBoxPosiadanaIlosc
            // 
            this.txtBoxPosiadanaIlosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxPosiadanaIlosc.Location = new System.Drawing.Point(794, 107);
            this.txtBoxPosiadanaIlosc.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxPosiadanaIlosc.Name = "txtBoxPosiadanaIlosc";
            this.txtBoxPosiadanaIlosc.Size = new System.Drawing.Size(201, 32);
            this.txtBoxPosiadanaIlosc.TabIndex = 9;
            // 
            // txtBoxAutor
            // 
            this.txtBoxAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxAutor.Location = new System.Drawing.Point(278, 169);
            this.txtBoxAutor.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxAutor.Name = "txtBoxAutor";
            this.txtBoxAutor.Size = new System.Drawing.Size(254, 32);
            this.txtBoxAutor.TabIndex = 8;
            // 
            // txtBoxWydawnictwo
            // 
            this.txtBoxWydawnictwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxWydawnictwo.Location = new System.Drawing.Point(536, 107);
            this.txtBoxWydawnictwo.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxWydawnictwo.Name = "txtBoxWydawnictwo";
            this.txtBoxWydawnictwo.Size = new System.Drawing.Size(254, 32);
            this.txtBoxWydawnictwo.TabIndex = 7;
            // 
            // txtBoxOpis
            // 
            this.txtBoxOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxOpis.Location = new System.Drawing.Point(278, 107);
            this.txtBoxOpis.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxOpis.Name = "txtBoxOpis";
            this.txtBoxOpis.Size = new System.Drawing.Size(254, 32);
            this.txtBoxOpis.TabIndex = 6;
            // 
            // txtBoxTytul
            // 
            this.txtBoxTytul.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxTytul.Location = new System.Drawing.Point(5, 169);
            this.txtBoxTytul.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxTytul.Name = "txtBoxTytul";
            this.txtBoxTytul.Size = new System.Drawing.Size(269, 32);
            this.txtBoxTytul.TabIndex = 5;
            // 
            // txtBoxKategoria
            // 
            this.txtBoxKategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxKategoria.Location = new System.Drawing.Point(8, 107);
            this.txtBoxKategoria.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxKategoria.Name = "txtBoxKategoria";
            this.txtBoxKategoria.Size = new System.Drawing.Size(266, 32);
            this.txtBoxKategoria.TabIndex = 4;
            // 
            // groupBoxKsiazki
            // 
            this.groupBoxKsiazki.Controls.Add(this.dgvKsiazki);
            this.groupBoxKsiazki.Location = new System.Drawing.Point(3, 3);
            this.groupBoxKsiazki.Name = "groupBoxKsiazki";
            this.groupBoxKsiazki.Size = new System.Drawing.Size(1050, 276);
            this.groupBoxKsiazki.TabIndex = 0;
            this.groupBoxKsiazki.TabStop = false;
            this.groupBoxKsiazki.Text = "Książki";
            // 
            // dgvKsiazki
            // 
            this.dgvKsiazki.AllowUserToAddRows = false;
            this.dgvKsiazki.AllowUserToDeleteRows = false;
            this.dgvKsiazki.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKsiazki.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvKsiazki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKsiazki.Location = new System.Drawing.Point(17, 27);
            this.dgvKsiazki.Margin = new System.Windows.Forms.Padding(2);
            this.dgvKsiazki.Name = "dgvKsiazki";
            this.dgvKsiazki.ReadOnly = true;
            this.dgvKsiazki.RowTemplate.Height = 24;
            this.dgvKsiazki.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKsiazki.Size = new System.Drawing.Size(1007, 239);
            this.dgvKsiazki.TabIndex = 1;
            this.dgvKsiazki.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKsiazki_CellClick);
            // 
            // tabPageUzytkownicy
            // 
            this.tabPageUzytkownicy.Location = new System.Drawing.Point(4, 4);
            this.tabPageUzytkownicy.Name = "tabPageUzytkownicy";
            this.tabPageUzytkownicy.Size = new System.Drawing.Size(1032, 558);
            this.tabPageUzytkownicy.TabIndex = 2;
            this.tabPageUzytkownicy.Text = "Użytkownicy";
            this.tabPageUzytkownicy.UseVisualStyleBackColor = true;
            // 
            // Biblioteka
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1064, 602);
            this.Controls.Add(this.tabControlBiblioteka);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1280, 788);
            this.MinimumSize = new System.Drawing.Size(880, 488);
            this.Name = "Biblioteka";
            this.Text = "biblioteka";
            this.groupBoxListaWypozyczajacych.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaWypozyczajacych)).EndInit();
            this.groupBoxKsiazkiWypozyczone.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKsiazkiWypozyczone)).EndInit();
            this.groupBoxWyszukiwarka.ResumeLayout(false);
            this.groupBoxWyszukiwarka.PerformLayout();
            this.tabControlBiblioteka.ResumeLayout(false);
            this.tabPageWypozyczenia.ResumeLayout(false);
            this.tabPageWypozyczenia.PerformLayout();
            this.tabPageKsiazki.ResumeLayout(false);
            this.groupBoxEdytor.ResumeLayout(false);
            this.groupBoxEdytor.PerformLayout();
            this.groupBoxKsiazki.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKsiazki)).EndInit();
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
        private System.Windows.Forms.TabControl tabControlBiblioteka;
        private System.Windows.Forms.TabPage tabPageWypozyczenia;
        private System.Windows.Forms.TabPage tabPageKsiazki;
        private System.Windows.Forms.TabPage tabPageUzytkownicy;
        private System.Windows.Forms.GroupBox groupBoxKsiazki;
        private System.Windows.Forms.GroupBox groupBoxEdytor;
        private System.Windows.Forms.Button btnUsunKsiazke;
        private System.Windows.Forms.Button btnEdytujKsiazke;
        private System.Windows.Forms.Button btnDodajKsiazke;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.Label lblTytul;
        private System.Windows.Forms.Label lblKategoria;
        private System.Windows.Forms.Label lblIloscWBibliotece;
        private System.Windows.Forms.Label lblPosiadanaIlosc;
        private System.Windows.Forms.Label lblRokWydania;
        private System.Windows.Forms.Label lblWydawnictwo;
        private System.Windows.Forms.TextBox txtBoxIloscWBibliotece;
        private System.Windows.Forms.TextBox txtBoxRokWydania;
        private System.Windows.Forms.TextBox txtBoxPosiadanaIlosc;
        private System.Windows.Forms.TextBox txtBoxAutor;
        private System.Windows.Forms.TextBox txtBoxWydawnictwo;
        private System.Windows.Forms.TextBox txtBoxOpis;
        private System.Windows.Forms.TextBox txtBoxTytul;
        private System.Windows.Forms.TextBox txtBoxKategoria;
        private System.Windows.Forms.DataGridView dgvKsiazki;
        private System.Windows.Forms.Button btnSzukajKsiazki;
        private System.Windows.Forms.TextBox txtBoxSzukajKsiazki;
    }
}