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
            this.btt_confermaelimina = new System.Windows.Forms.Button();
            this.lbl_eliminaprod = new System.Windows.Forms.Label();
            this.txt_elimina = new System.Windows.Forms.TextBox();
            this.bttn_elimina = new System.Windows.Forms.Button();
            this.bttn_annulla = new System.Windows.Forms.Button();
            this.bttn_OrdAlf = new System.Windows.Forms.Button();
            this.lst_totEsconto = new System.Windows.Forms.ListBox();
            this.bttn_sommaPerc = new System.Windows.Forms.Button();
            this.txt_sconto = new System.Windows.Forms.TextBox();
            this.lbl_sconto = new System.Windows.Forms.Label();
            this.bttn_sottraiPerc = new System.Windows.Forms.Button();
            this.txt_maxmin = new System.Windows.Forms.TextBox();
            this.bttn_max = new System.Windows.Forms.Button();
            this.bttn_min = new System.Windows.Forms.Button();
            this.bttn_salva = new System.Windows.Forms.Button();
            this.bttn_leggi = new System.Windows.Forms.Button();
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
            this.bttn_aggiungi.Location = new System.Drawing.Point(771, 55);
            this.bttn_aggiungi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttn_aggiungi.Name = "bttn_aggiungi";
            this.bttn_aggiungi.Size = new System.Drawing.Size(119, 36);
            this.bttn_aggiungi.TabIndex = 4;
            this.bttn_aggiungi.Text = "Aggiungi";
            this.bttn_aggiungi.UseVisualStyleBackColor = true;
            this.bttn_aggiungi.Click += new System.EventHandler(this.bttn_aggiungi_Click);
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
            this.bttn_modifica.Location = new System.Drawing.Point(24, 124);
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
            this.txt_modnome.Location = new System.Drawing.Point(508, 130);
            this.txt_modnome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_modnome.Name = "txt_modnome";
            this.txt_modnome.Size = new System.Drawing.Size(100, 22);
            this.txt_modnome.TabIndex = 22;
            // 
            // lbl_modnome
            // 
            this.lbl_modnome.AutoSize = true;
            this.lbl_modnome.Location = new System.Drawing.Point(505, 110);
            this.lbl_modnome.Name = "lbl_modnome";
            this.lbl_modnome.Size = new System.Drawing.Size(87, 16);
            this.lbl_modnome.TabIndex = 8;
            this.lbl_modnome.Text = "Nuovo nome:";
            this.lbl_modnome.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // txt_modprezzo
            // 
            this.txt_modprezzo.Location = new System.Drawing.Point(641, 130);
            this.txt_modprezzo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_modprezzo.Name = "txt_modprezzo";
            this.txt_modprezzo.Size = new System.Drawing.Size(100, 22);
            this.txt_modprezzo.TabIndex = 11;
            // 
            // lbl_modprezzo
            // 
            this.lbl_modprezzo.AutoSize = true;
            this.lbl_modprezzo.Location = new System.Drawing.Point(641, 112);
            this.lbl_modprezzo.Name = "lbl_modprezzo";
            this.lbl_modprezzo.Size = new System.Drawing.Size(93, 16);
            this.lbl_modprezzo.TabIndex = 10;
            this.lbl_modprezzo.Text = "Nuovo prezzo:";
            this.lbl_modprezzo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // txt_prodottomod
            // 
            this.txt_prodottomod.Location = new System.Drawing.Point(164, 130);
            this.txt_prodottomod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_prodottomod.Name = "txt_prodottomod";
            this.txt_prodottomod.Size = new System.Drawing.Size(203, 22);
            this.txt_prodottomod.TabIndex = 12;
            // 
            // bttn_confermamod
            // 
            this.bttn_confermamod.Location = new System.Drawing.Point(771, 119);
            this.bttn_confermamod.Margin = new System.Windows.Forms.Padding(4);
            this.bttn_confermamod.Name = "bttn_confermamod";
            this.bttn_confermamod.Size = new System.Drawing.Size(118, 44);
            this.bttn_confermamod.TabIndex = 13;
            this.bttn_confermamod.Text = "Conferma le modifiche";
            this.bttn_confermamod.UseVisualStyleBackColor = true;
            this.bttn_confermamod.Click += new System.EventHandler(this.bttn_confermamod_Click);
            // 
            // lbl_vecchio
            // 
            this.lbl_vecchio.AutoSize = true;
            this.lbl_vecchio.Location = new System.Drawing.Point(160, 112);
            this.lbl_vecchio.Name = "lbl_vecchio";
            this.lbl_vecchio.Size = new System.Drawing.Size(210, 16);
            this.lbl_vecchio.TabIndex = 14;
            this.lbl_vecchio.Text = " Nome del prodotto da modificare:";
            this.lbl_vecchio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // bttn_cerca
            // 
            this.bttn_cerca.Location = new System.Drawing.Point(389, 126);
            this.bttn_cerca.Margin = new System.Windows.Forms.Padding(4);
            this.bttn_cerca.Name = "bttn_cerca";
            this.bttn_cerca.Size = new System.Drawing.Size(72, 30);
            this.bttn_cerca.TabIndex = 15;
            this.bttn_cerca.Text = "Cerca";
            this.bttn_cerca.UseVisualStyleBackColor = true;
            this.bttn_cerca.Click += new System.EventHandler(this.bttn_cerca_Click);
            // 
            // btt_confermaelimina
            // 
            this.btt_confermaelimina.Location = new System.Drawing.Point(389, 186);
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
            this.lbl_eliminaprod.Location = new System.Drawing.Point(161, 165);
            this.lbl_eliminaprod.Name = "lbl_eliminaprod";
            this.lbl_eliminaprod.Size = new System.Drawing.Size(211, 23);
            this.lbl_eliminaprod.TabIndex = 21;
            this.lbl_eliminaprod.Text = "Nome del prodotto da eliminare:";
            // 
            // txt_elimina
            // 
            this.txt_elimina.Location = new System.Drawing.Point(164, 190);
            this.txt_elimina.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_elimina.Name = "txt_elimina";
            this.txt_elimina.Size = new System.Drawing.Size(203, 22);
            this.txt_elimina.TabIndex = 18;
            // 
            // bttn_elimina
            // 
            this.bttn_elimina.Location = new System.Drawing.Point(25, 183);
            this.bttn_elimina.Margin = new System.Windows.Forms.Padding(4);
            this.bttn_elimina.Name = "bttn_elimina";
            this.bttn_elimina.Size = new System.Drawing.Size(117, 36);
            this.bttn_elimina.TabIndex = 17;
            this.bttn_elimina.Text = "Elimina";
            this.bttn_elimina.UseVisualStyleBackColor = true;
            this.bttn_elimina.Click += new System.EventHandler(this.bttn_eliminia_Click);
            // 
            // bttn_annulla
            // 
            this.bttn_annulla.Location = new System.Drawing.Point(772, 183);
            this.bttn_annulla.Margin = new System.Windows.Forms.Padding(4);
            this.bttn_annulla.Name = "bttn_annulla";
            this.bttn_annulla.Size = new System.Drawing.Size(118, 36);
            this.bttn_annulla.TabIndex = 23;
            this.bttn_annulla.Text = "Annulla";
            this.bttn_annulla.UseVisualStyleBackColor = true;
            this.bttn_annulla.Click += new System.EventHandler(this.bttn_annulla_Click);
            // 
            // bttn_OrdAlf
            // 
            this.bttn_OrdAlf.Location = new System.Drawing.Point(24, 244);
            this.bttn_OrdAlf.Margin = new System.Windows.Forms.Padding(4);
            this.bttn_OrdAlf.Name = "bttn_OrdAlf";
            this.bttn_OrdAlf.Size = new System.Drawing.Size(188, 36);
            this.bttn_OrdAlf.TabIndex = 24;
            this.bttn_OrdAlf.Text = "Ordina alfabaticamente";
            this.bttn_OrdAlf.UseVisualStyleBackColor = true;
            this.bttn_OrdAlf.Click += new System.EventHandler(this.bttn_OrdAlf_Click);
            // 
            // lst_totEsconto
            // 
            this.lst_totEsconto.FormattingEnabled = true;
            this.lst_totEsconto.ItemHeight = 16;
            this.lst_totEsconto.Location = new System.Drawing.Point(919, 390);
            this.lst_totEsconto.Margin = new System.Windows.Forms.Padding(4);
            this.lst_totEsconto.Name = "lst_totEsconto";
            this.lst_totEsconto.Size = new System.Drawing.Size(293, 84);
            this.lst_totEsconto.TabIndex = 25;
            // 
            // bttn_sommaPerc
            // 
            this.bttn_sommaPerc.Location = new System.Drawing.Point(742, 317);
            this.bttn_sommaPerc.Margin = new System.Windows.Forms.Padding(4);
            this.bttn_sommaPerc.Name = "bttn_sommaPerc";
            this.bttn_sommaPerc.Size = new System.Drawing.Size(147, 36);
            this.bttn_sommaPerc.TabIndex = 26;
            this.bttn_sommaPerc.Text = "Somma percentuale";
            this.bttn_sommaPerc.UseVisualStyleBackColor = true;
            this.bttn_sommaPerc.Click += new System.EventHandler(this.sommaPerc_Click);
            // 
            // txt_sconto
            // 
            this.txt_sconto.AcceptsReturn = true;
            this.txt_sconto.Location = new System.Drawing.Point(688, 388);
            this.txt_sconto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_sconto.Name = "txt_sconto";
            this.txt_sconto.Size = new System.Drawing.Size(118, 22);
            this.txt_sconto.TabIndex = 28;
            // 
            // lbl_sconto
            // 
            this.lbl_sconto.AutoSize = true;
            this.lbl_sconto.Location = new System.Drawing.Point(714, 365);
            this.lbl_sconto.Name = "lbl_sconto";
            this.lbl_sconto.Size = new System.Drawing.Size(52, 16);
            this.lbl_sconto.TabIndex = 27;
            this.lbl_sconto.Text = "Sconto:";
            this.lbl_sconto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // bttn_sottraiPerc
            // 
            this.bttn_sottraiPerc.Location = new System.Drawing.Point(601, 317);
            this.bttn_sottraiPerc.Margin = new System.Windows.Forms.Padding(4);
            this.bttn_sottraiPerc.Name = "bttn_sottraiPerc";
            this.bttn_sottraiPerc.Size = new System.Drawing.Size(140, 36);
            this.bttn_sottraiPerc.TabIndex = 29;
            this.bttn_sottraiPerc.Text = "Sottrai percentuale";
            this.bttn_sottraiPerc.UseVisualStyleBackColor = true;
            this.bttn_sottraiPerc.Click += new System.EventHandler(this.bttn_sottraiPerc_Click);
            // 
            // txt_maxmin
            // 
            this.txt_maxmin.Location = new System.Drawing.Point(247, 388);
            this.txt_maxmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_maxmin.Name = "txt_maxmin";
            this.txt_maxmin.Size = new System.Drawing.Size(120, 22);
            this.txt_maxmin.TabIndex = 30;
            // 
            // bttn_max
            // 
            this.bttn_max.Location = new System.Drawing.Point(163, 317);
            this.bttn_max.Margin = new System.Windows.Forms.Padding(4);
            this.bttn_max.Name = "bttn_max";
            this.bttn_max.Size = new System.Drawing.Size(140, 36);
            this.bttn_max.TabIndex = 32;
            this.bttn_max.Text = "Prezzo più alto";
            this.bttn_max.UseVisualStyleBackColor = true;
            this.bttn_max.Click += new System.EventHandler(this.bttn_max_Click);
            // 
            // bttn_min
            // 
            this.bttn_min.Location = new System.Drawing.Point(304, 317);
            this.bttn_min.Margin = new System.Windows.Forms.Padding(4);
            this.bttn_min.Name = "bttn_min";
            this.bttn_min.Size = new System.Drawing.Size(147, 36);
            this.bttn_min.TabIndex = 31;
            this.bttn_min.Text = "Prezzo più basso";
            this.bttn_min.UseVisualStyleBackColor = true;
            this.bttn_min.Click += new System.EventHandler(this.bttn_min_Click);
            // 
            // bttn_salva
            // 
            this.bttn_salva.Location = new System.Drawing.Point(24, 476);
            this.bttn_salva.Margin = new System.Windows.Forms.Padding(4);
            this.bttn_salva.Name = "bttn_salva";
            this.bttn_salva.Size = new System.Drawing.Size(136, 36);
            this.bttn_salva.TabIndex = 33;
            this.bttn_salva.Text = "Salva lista su file";
            this.bttn_salva.UseVisualStyleBackColor = true;
            this.bttn_salva.Click += new System.EventHandler(this.bttn_salva_Click);
            // 
            // bttn_leggi
            // 
            this.bttn_leggi.Location = new System.Drawing.Point(207, 476);
            this.bttn_leggi.Margin = new System.Windows.Forms.Padding(4);
            this.bttn_leggi.Name = "bttn_leggi";
            this.bttn_leggi.Size = new System.Drawing.Size(136, 36);
            this.bttn_leggi.TabIndex = 34;
            this.bttn_leggi.Text = "Leggi file";
            this.bttn_leggi.UseVisualStyleBackColor = true;
            this.bttn_leggi.Click += new System.EventHandler(this.bttn_leggi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 591);
            this.Controls.Add(this.bttn_leggi);
            this.Controls.Add(this.bttn_salva);
            this.Controls.Add(this.bttn_max);
            this.Controls.Add(this.bttn_min);
            this.Controls.Add(this.txt_maxmin);
            this.Controls.Add(this.bttn_sottraiPerc);
            this.Controls.Add(this.txt_sconto);
            this.Controls.Add(this.lbl_sconto);
            this.Controls.Add(this.bttn_sommaPerc);
            this.Controls.Add(this.lst_totEsconto);
            this.Controls.Add(this.bttn_OrdAlf);
            this.Controls.Add(this.bttn_annulla);
            this.Controls.Add(this.btt_confermaelimina);
            this.Controls.Add(this.lbl_eliminaprod);
            this.Controls.Add(this.txt_elimina);
            this.Controls.Add(this.bttn_elimina);
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
        private System.Windows.Forms.Button btt_confermaelimina;
        private System.Windows.Forms.Label lbl_eliminaprod;
        private System.Windows.Forms.TextBox txt_elimina;
        private System.Windows.Forms.Button bttn_elimina;
        private System.Windows.Forms.Button bttn_annulla;
        private System.Windows.Forms.Button bttn_OrdAlf;
        private System.Windows.Forms.ListBox lst_totEsconto;
        private System.Windows.Forms.Button bttn_sommaPerc;
        private System.Windows.Forms.TextBox txt_sconto;
        private System.Windows.Forms.Label lbl_sconto;
        private System.Windows.Forms.Button bttn_sottraiPerc;
        private System.Windows.Forms.TextBox txt_maxmin;
        private System.Windows.Forms.Button bttn_max;
        private System.Windows.Forms.Button bttn_min;
        private System.Windows.Forms.Button bttn_salva;
        private System.Windows.Forms.Button bttn_leggi;
    }
}

