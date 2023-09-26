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
            this.SuspendLayout();
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(16, 35);
            this.lbl_nome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(38, 13);
            this.lbl_nome.TabIndex = 0;
            this.lbl_nome.Text = "Nome:";
            this.lbl_nome.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lbl_nome.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_prezzo
            // 
            this.lbl_prezzo.AutoSize = true;
            this.lbl_prezzo.Location = new System.Drawing.Point(16, 86);
            this.lbl_prezzo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_prezzo.Name = "lbl_prezzo";
            this.lbl_prezzo.Size = new System.Drawing.Size(42, 13);
            this.lbl_prezzo.TabIndex = 1;
            this.lbl_prezzo.Text = "Prezzo:";
            this.lbl_prezzo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(18, 50);
            this.txt_nome.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(76, 20);
            this.txt_nome.TabIndex = 2;
            // 
            // txt_prezzo
            // 
            this.txt_prezzo.Location = new System.Drawing.Point(18, 102);
            this.txt_prezzo.Margin = new System.Windows.Forms.Padding(2);
            this.txt_prezzo.Name = "txt_prezzo";
            this.txt_prezzo.Size = new System.Drawing.Size(76, 20);
            this.txt_prezzo.TabIndex = 3;
            // 
            // bttn_aggiungi
            // 
            this.bttn_aggiungi.Location = new System.Drawing.Point(18, 134);
            this.bttn_aggiungi.Margin = new System.Windows.Forms.Padding(2);
            this.bttn_aggiungi.Name = "bttn_aggiungi";
            this.bttn_aggiungi.Size = new System.Drawing.Size(89, 29);
            this.bttn_aggiungi.TabIndex = 4;
            this.bttn_aggiungi.Text = "Aggiungi";
            this.bttn_aggiungi.UseVisualStyleBackColor = true;
            this.bttn_aggiungi.Click += new System.EventHandler(this.bttn_aggiungi_Click);
            // 
            // bttn_visuallizza
            // 
            this.bttn_visuallizza.Location = new System.Drawing.Point(19, 168);
            this.bttn_visuallizza.Name = "bttn_visuallizza";
            this.bttn_visuallizza.Size = new System.Drawing.Size(88, 29);
            this.bttn_visuallizza.TabIndex = 5;
            this.bttn_visuallizza.Text = "Visualizza";
            this.bttn_visuallizza.UseVisualStyleBackColor = true;
            this.bttn_visuallizza.Click += new System.EventHandler(this.bttn_visuallizza_Click);
            // 
            // lst_visual
            // 
            this.lst_visual.FormattingEnabled = true;
            this.lst_visual.Location = new System.Drawing.Point(348, 41);
            this.lst_visual.Name = "lst_visual";
            this.lst_visual.Size = new System.Drawing.Size(180, 225);
            this.lst_visual.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.lst_visual);
            this.Controls.Add(this.bttn_visuallizza);
            this.Controls.Add(this.bttn_aggiungi);
            this.Controls.Add(this.txt_prezzo);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.lbl_prezzo);
            this.Controls.Add(this.lbl_nome);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

