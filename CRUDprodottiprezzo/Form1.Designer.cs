namespace CRUDprodottiprezzo
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_prezzo = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_prezzo = new System.Windows.Forms.TextBox();
            this.bttn_aggiungi = new System.Windows.Forms.Button();
            this.bttn_visuallizza = new System.Windows.Forms.Button();
            this.lst_visual = new System.Windows.Forms.ListBox();
            this.bttn_modifica = new System.Windows.Forms.Button();
            this.txt_modnome = new System.Windows.Forms.TextBox();
            this.lbl_modnome = new System.Windows.Forms.Label();
            this.txt_modprezzo = new System.Windows.Forms.TextBox();
            this.lbl_modprezzo = new System.Windows.Forms.Label();
            this.txt_prodottomod = new System.Windows.Forms.TextBox();
            this.bttn_confermamod = new System.Windows.Forms.Button();
            this.lbl_vecchio = new System.Windows.Forms.Label();
            this.bttn_cerca = new System.Windows.Forms.Button();
            this.lbl_aiuto = new System.Windows.Forms.Label();
            this.btt_confermaelimina = new System.Windows.Forms.Button();
            this.lbl_eliminaprod = new System.Windows.Forms.Label();
            this.txt_elimina = new System.Windows.Forms.TextBox();
            this.bttn_eliminia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(21, 43);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(47, 16);
            this.lbl_nome.TabIndex = 0;
            this.lbl_nome.Text = "Nome:";
            this.lbl_nome.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lbl_nome.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_prezzo
            // 
            this.lbl_prezzo.AutoSize = true;
            this.lbl_prezzo.Location = new System.Drawing.Point(281, 43);
            this.lbl_prezzo.Name = "lbl_prezzo";
            this.lbl_prezzo.Size = new System.Drawing.Size(51, 16);
            this.lbl_prezzo.TabIndex = 1;
            this.lbl_prezzo.Text = "Prezzo:";
            this.lbl_prezzo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(24, 62);
            this.txt_nome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(100, 22);
            this.txt_nome.TabIndex = 2;
            // 
            // txt_prezzo
            // 
            this.txt_prezzo.Location = new System.Drawing.Point(285, 62);
            this.txt_prezzo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_prezzo.Name = "txt_prezzo";
            this.txt_prezzo.Size = new System.Drawing.Size(100, 22);
            this.txt_prezzo.TabIndex = 3;
            // 
            // bttn_aggiungi
            // 
            this.bttn_aggiungi.Location = new System.Drawing.Point(23, 126);
            this.bttn_aggiungi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttn_aggiungi.Name = "bttn_aggiungi";
            this.bttn_aggiungi.Size = new System.Drawing.Size(119, 36);
            this.bttn_aggiungi.TabIndex = 4;
            this.bttn_aggiungi.Text = "Aggiungi";
            this.bttn_aggiungi.UseVisualStyleBackColor = true;
            this.bttn_aggiungi.Click += new System.EventHandler(this.bttn_aggiungi_Click);
            // 
            // bttn_visuallizza
            // 
            this.bttn_visuallizza.Location = new System.Drawing.Point(164, 126);
            this.bttn_visuallizza.Margin = new System.Windows.Forms.Padding(4);
            this.bttn_visuallizza.Name = "bttn_visuallizza";
            this.bttn_visuallizza.Size = new System.Drawing.Size(117, 36);
            this.bttn_visuallizza.TabIndex = 5;
            this.bttn_visuallizza.Text = "Visualizza";
            this.bttn_visuallizza.UseVisualStyleBackColor = true;
            this.bttn_visuallizza.Click += new System.EventHandler(this.bttn_visuallizza_Click);
            // 
            // lst_visual
            // 
            this.lst_visual.FormattingEnabled = true;
            this.lst_visual.ItemHeight = 16;
            this.lst_visual.Location = new System.Drawing.Point(919, 43);
            this.lst_visual.Margin = new System.Windows.Forms.Padding(4);
            this.lst_visual.Name = "lst_visual";
            this.lst_visual.Size = new System.Drawing.Size(293, 340);
            this.lst_visual.TabIndex = 6;
            // 
            // bttn_modifica
            // 
            this.bttn_modifica.Location = new System.Drawing.Point(24, 196);
            this.bttn_modifica.Margin = new System.Windows.Forms.Padding(4);
            this.bttn_modifica.Name = "bttn_modifica";
            this.bttn_modifica.Size = new System.Drawing.Size(117, 36);
            this.bttn_modifica.TabIndex = 7;
            this.bttn_modifica.Text = "Modifica";
            this.bttn_modifica.UseVisualStyleBackColor = true;
            this.bttn_modifica.Click += new System.EventHandler(this.bttn_modifica_Click);
            // 
            // txt_modnome
            // 
            this.txt_modnome.Location = new System.Drawing.Point(508, 203);
            this.txt_modnome.Name = "txt_modnome";
            this.txt_modnome.Size = new System.Drawing.Size(100, 22);
            this.txt_modnome.TabIndex = 22;
            // 
            // lbl_modnome
            // 
            this.lbl_modnome.AutoSize = true;
            this.lbl_modnome.Location = new System.Drawing.Point(505, 183);
            this.lbl_modnome.Name = "lbl_modnome";
            this.lbl_modnome.Size = new System.Drawing.Size(87, 16);
            this.lbl_modnome.TabIndex = 8;
            this.lbl_modnome.Text = "Nuovo nome:";
            this.lbl_modnome.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // txt_modprezzo
            // 
            this.txt_modprezzo.Location = new System.Drawing.Point(641, 202);
            this.txt_modprezzo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_modprezzo.Name = "txt_modprezzo";
            this.txt_modprezzo.Size = new System.Drawing.Size(100, 22);
            this.txt_modprezzo.TabIndex = 11;
            // 
            // lbl_modprezzo
            // 
            this.lbl_modprezzo.AutoSize = true;
            this.lbl_modprezzo.Location = new System.Drawing.Point(641, 183);
            this.lbl_modprezzo.Name = "lbl_modprezzo";
            this.lbl_modprezzo.Size = new System.Drawing.Size(93, 16);
            this.lbl_modprezzo.TabIndex = 10;
            this.lbl_modprezzo.Text = "Nuovo prezzo:";
            this.lbl_modprezzo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // txt_prodottomod
            // 
            this.txt_prodottomod.Location = new System.Drawing.Point(164, 202);
            this.txt_prodottomod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_prodottomod.Name = "txt_prodottomod";
            this.txt_prodottomod.Size = new System.Drawing.Size(203, 22);
            this.txt_prodottomod.TabIndex = 12;
            // 
            // bttn_confermamod
            // 
            this.bttn_confermamod.Location = new System.Drawing.Point(772, 191);
            this.bttn_confermamod.Margin = new System.Windows.Forms.Padding(4);
            this.bttn_confermamod.Name = "bttn_confermamod";
            this.bttn_confermamod.Size = new System.Drawing.Size(117, 44);
            this.bttn_confermamod.TabIndex = 13;
            this.bttn_confermamod.Text = "Conferma le modifiche";
            this.bttn_confermamod.UseVisualStyleBackColor = true;
            this.bttn_confermamod.Click += new System.EventHandler(this.bttn_confermamod_Click);
            // 
            // lbl_vecchio
            // 
            this.lbl_vecchio.AutoSize = true;
            this.lbl_vecchio.Location = new System.Drawing.Point(160, 183);
            this.lbl_vecchio.Name = "lbl_vecchio";
            this.lbl_vecchio.Size = new System.Drawing.Size(210, 16);
            this.lbl_vecchio.TabIndex = 14;
            this.lbl_vecchio.Text = " Nome del prodotto da modificare:";
            this.lbl_vecchio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // bttn_cerca
            // 
            this.bttn_cerca.Location = new System.Drawing.Point(388, 202);
            this.bttn_cerca.Margin = new System.Windows.Forms.Padding(4);
            this.bttn_cerca.Name = "bttn_cerca";
            this.bttn_cerca.Size = new System.Drawing.Size(72, 30);
            this.bttn_cerca.TabIndex = 15;
            this.bttn_cerca.Text = "Cerca";
            this.bttn_cerca.UseVisualStyleBackColor = true;
            this.bttn_cerca.Click += new System.EventHandler(this.bttn_cerca_Click);
            // 
            // lbl_aiuto
            // 
            this.lbl_aiuto.AutoSize = true;
            this.lbl_aiuto.ForeColor = System.Drawing.Color.Red;
            this.lbl_aiuto.Location = new System.Drawing.Point(347, 135);
            this.lbl_aiuto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_aiuto.Name = "lbl_aiuto";
            this.lbl_aiuto.Size = new System.Drawing.Size(457, 16);
            this.lbl_aiuto.TabIndex = 16;
            this.lbl_aiuto.Text = "*dopo aver fatto delle modifiche cliccare su Visualizza per vederle nella lista";
            // 
            // btt_confermaelimina
            // 
            this.btt_confermaelimina.Location = new System.Drawing.Point(388, 273);
            this.btt_confermaelimina.Margin = new System.Windows.Forms.Padding(4);
            this.btt_confermaelimina.Name = "btt_confermaelimina";
            this.btt_confermaelimina.Size = new System.Drawing.Size(88, 30);
            this.btt_confermaelimina.TabIndex = 20;
            this.btt_confermaelimina.Text = "Conferma";
            this.btt_confermaelimina.UseVisualStyleBackColor = true;
            this.btt_confermaelimina.Click += new System.EventHandler(this.btt_confermaelimina_Click);
            // 
            // lbl_eliminaprod
            // 
            this.lbl_eliminaprod.Location = new System.Drawing.Point(160, 252);
            this.lbl_eliminaprod.Name = "lbl_eliminaprod";
            this.lbl_eliminaprod.Size = new System.Drawing.Size(210, 23);
            this.lbl_eliminaprod.TabIndex = 21;
            this.lbl_eliminaprod.Text = "Nome del prodotto da eliminare:";
            // 
            // txt_elimina
            // 
            this.txt_elimina.Location = new System.Drawing.Point(163, 277);
            this.txt_elimina.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_elimina.Name = "txt_elimina";
            this.txt_elimina.Size = new System.Drawing.Size(203, 22);
            this.txt_elimina.TabIndex = 18;
            // 
            // bttn_eliminia
            // 
            this.bttn_eliminia.Location = new System.Drawing.Point(23, 271);
            this.bttn_eliminia.Margin = new System.Windows.Forms.Padding(4);
            this.bttn_eliminia.Name = "bttn_eliminia";
            this.bttn_eliminia.Size = new System.Drawing.Size(117, 36);
            this.bttn_eliminia.TabIndex = 17;
            this.bttn_eliminia.Text = "Elimina";
            this.bttn_eliminia.UseVisualStyleBackColor = true;
            this.bttn_eliminia.Click += new System.EventHandler(this.bttn_eliminia_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 591);
            this.Controls.Add(this.btt_confermaelimina);
            this.Controls.Add(this.lbl_eliminaprod);
            this.Controls.Add(this.txt_elimina);
            this.Controls.Add(this.bttn_eliminia);
            this.Controls.Add(this.lbl_aiuto);
            this.Controls.Add(this.bttn_cerca);
            this.Controls.Add(this.lbl_vecchio);
            this.Controls.Add(this.bttn_confermamod);
            this.Controls.Add(this.txt_prodottomod);
            this.Controls.Add(this.txt_modprezzo);
            this.Controls.Add(this.lbl_modprezzo);
            this.Controls.Add(this.txt_modnome);
            this.Controls.Add(this.lbl_modnome);
            this.Controls.Add(this.bttn_modifica);
            this.Controls.Add(this.lst_visual);
            this.Controls.Add(this.bttn_visuallizza);
            this.Controls.Add(this.bttn_aggiungi);
            this.Controls.Add(this.txt_prezzo);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.lbl_prezzo);
            this.Controls.Add(this.lbl_nome);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "GestioneProdottiCRUD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_prezzo;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_prezzo;
        private System.Windows.Forms.Button bttn_aggiungi;
        private System.Windows.Forms.Button bttn_visuallizza;
        private System.Windows.Forms.ListBox lst_visual;
        private System.Windows.Forms.Button bttn_modifica;
        private System.Windows.Forms.TextBox txt_modnome;
        private System.Windows.Forms.Label lbl_modnome;
        private System.Windows.Forms.TextBox txt_modprezzo;
        private System.Windows.Forms.Label lbl_modprezzo;
        private System.Windows.Forms.TextBox txt_prodottomod;
        private System.Windows.Forms.Button bttn_confermamod;
        private System.Windows.Forms.Label lbl_vecchio;
        private System.Windows.Forms.Button bttn_cerca;
        private System.Windows.Forms.Label lbl_aiuto;
        private System.Windows.Forms.Button btt_confermaelimina;
        private System.Windows.Forms.Label lbl_eliminaprod;
        private System.Windows.Forms.TextBox txt_elimina;
        private System.Windows.Forms.Button bttn_eliminia;
    }
}

