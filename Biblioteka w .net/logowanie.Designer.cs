namespace Biblioteka_w_Dotnet
{
    partial class logowanie
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblHaslo = new System.Windows.Forms.Label();
            this.btnZaloguj = new System.Windows.Forms.Button();
            this.btnZakoncz = new System.Windows.Forms.Button();
            this.txtBoxLogin = new System.Windows.Forms.TextBox();
            this.txtBoxHaslo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLogin.Location = new System.Drawing.Point(92, 80);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(57, 24);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Login";
            // 
            // lblHaslo
            // 
            this.lblHaslo.AutoSize = true;
            this.lblHaslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblHaslo.Location = new System.Drawing.Point(92, 185);
            this.lblHaslo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHaslo.Name = "lblHaslo";
            this.lblHaslo.Size = new System.Drawing.Size(62, 24);
            this.lblHaslo.TabIndex = 1;
            this.lblHaslo.Text = "Hasło";
            // 
            // btnZaloguj
            // 
            this.btnZaloguj.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZaloguj.Location = new System.Drawing.Point(141, 284);
            this.btnZaloguj.Margin = new System.Windows.Forms.Padding(2);
            this.btnZaloguj.Name = "btnZaloguj";
            this.btnZaloguj.Size = new System.Drawing.Size(106, 52);
            this.btnZaloguj.TabIndex = 2;
            this.btnZaloguj.Text = "Zaloguj";
            this.btnZaloguj.UseVisualStyleBackColor = true;
            this.btnZaloguj.Click += new System.EventHandler(this.btnZaloguj_Click);
            // 
            // btnZakoncz
            // 
            this.btnZakoncz.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZakoncz.Location = new System.Drawing.Point(367, 284);
            this.btnZakoncz.Margin = new System.Windows.Forms.Padding(2);
            this.btnZakoncz.Name = "btnZakoncz";
            this.btnZakoncz.Size = new System.Drawing.Size(106, 52);
            this.btnZakoncz.TabIndex = 3;
            this.btnZakoncz.Text = "Zakończ";
            this.btnZakoncz.UseVisualStyleBackColor = true;
            this.btnZakoncz.Click += new System.EventHandler(this.btnZakoncz_Click);
            // 
            // txtBoxLogin
            // 
            this.txtBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxLogin.Location = new System.Drawing.Point(223, 80);
            this.txtBoxLogin.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxLogin.Name = "txtBoxLogin";
            this.txtBoxLogin.Size = new System.Drawing.Size(197, 29);
            this.txtBoxLogin.TabIndex = 4;
            // 
            // txtBoxHaslo
            // 
            this.txtBoxHaslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxHaslo.Location = new System.Drawing.Point(223, 185);
            this.txtBoxHaslo.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxHaslo.Name = "txtBoxHaslo";
            this.txtBoxHaslo.Size = new System.Drawing.Size(197, 29);
            this.txtBoxHaslo.TabIndex = 5;
            this.txtBoxHaslo.UseSystemPasswordChar = true;
            // 
            // logowanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.txtBoxHaslo);
            this.Controls.Add(this.txtBoxLogin);
            this.Controls.Add(this.btnZakoncz);
            this.Controls.Add(this.btnZaloguj);
            this.Controls.Add(this.lblHaslo);
            this.Controls.Add(this.lblLogin);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "logowanie";
            this.Text = "Biblioteka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblHaslo;
        private System.Windows.Forms.Button btnZaloguj;
        private System.Windows.Forms.Button btnZakoncz;
        private System.Windows.Forms.TextBox txtBoxLogin;
        private System.Windows.Forms.TextBox txtBoxHaslo;
    }
}

