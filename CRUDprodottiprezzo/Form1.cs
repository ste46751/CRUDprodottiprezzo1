using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static CRUDprodottiprezzo.Form1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace CRUDprodottiprezzo
{
    public partial class Form1 : Form
    {
        //inizializzazione della struct Prodotto e creazione del vettore
        public struct Prodotto
        {
            public string Nome;
            public float Prezzo;
        }
        public Prodotto[] p;
        public int dim = 0;

         
        public Form1()
        {
            InitializeComponent();

            p = new Prodotto[100];
            
            //comandi Enabled per l'interfaccia grafica del PULSANTE MODIFICA, che vanno a nascondere celle quando non servono

            bttn_modifica.Enabled = false;

            txt_modprezzo.Enabled = false;
            lbl_modprezzo.Enabled = false;
            txt_modnome.Enabled = false;
            lbl_modnome.Enabled = false;
            txt_prodottomod.Enabled = false;
            lbl_vecchio.Enabled = false;

            bttn_confermamod.Enabled = false;
            bttn_cerca.Enabled = false;

            //comandi Enabled per l'interfaccia grafica del PULSANTE ELIMINA, che vanno a nascondere celle quando non servono

            bttn_elimina.Enabled = false;
            
            lbl_eliminaprod.Enabled = false;
            txt_elimina.Enabled = false;
            bttn_confermaelimina.Enabled = false;

            bttn_annulla.Enabled = false;

            //Pulsanti disabilitati quando non sono presenti prodotti nella lista
            bttn_OrdAlf.Enabled = false;
            bttn_max.Enabled = false;
            bttn_min.Enabled = false;
            bttn_sottraiPerc.Enabled = false;
            bttn_sommaPerc.Enabled = false;
            bttn_salva.Enabled = false;

            txt_maxmin.Enabled = false;
        }
        
        //PULSANTE AGGIUNGI, salva il nome del prodotto e il suo prezzo nella struct
        private void bttn_aggiungi_Click(object sender, EventArgs e)
        {
            string numero=txt_prezzo.Text;
            bool controllo=int.TryParse(numero, out _);//TryParse converte un numero da stringa a intero, se non riesce da controllo==false
            //se le text box sono vuote appare il messaggio appare schermo fino a quando entrambi i campi non saranno pieni
            if (String.IsNullOrEmpty(txt_nome.Text) || String.IsNullOrEmpty(txt_prezzo.Text))
            {
                MessageBox.Show("Devi riempire tutti i campi per aggiungere un prodotto");
            }
            //se sono presenti lettere nel campo dedicato al prezzo non permette di continuare
            else if(controllo==false)
            {
                MessageBox.Show("Non puoi inserire lettere in questo campo");
                txt_prezzo.Text = ("");
            }
            //quando le text box sono compilate i dati vengono salvati all'interno dell'array
            else
            {
                p[dim].Nome = txt_nome.Text;
                p[dim].Prezzo = Convert.ToInt32(txt_prezzo.Text);
                txt_nome.Text = ("");
                txt_prezzo.Text = ("");

                MessageBox.Show("Prodotto aggiunto alla lista");

                dim++;

                //attivazione dei pulsanti prima disattivati perchè non presenti prodotti
                bttn_modifica.Enabled = true;
                bttn_elimina.Enabled = true;
                bttn_OrdAlf.Enabled = true;
                bttn_max.Enabled = true;
                bttn_min.Enabled = true;
                bttn_sottraiPerc.Enabled = true;
                bttn_sommaPerc.Enabled = true;
                
                bttn_salva.Enabled = true;

                visualizza(p);
                somma(p);
            }
        }
        //FUNZIONE CHE SCRIVE L'OUTPUT PER LA LISTA
        public string prodString(Prodotto p)
        {
            return "Nome: " + p.Nome + " Prezzo: " + p.Prezzo.ToString();
        }
        //FUNZIONE VISUALIZZA, stampa il nome e il prezzo del prodotto nella List Box
        private void visualizza(Prodotto[]p)
        {
            lst_visual.Items.Clear();

            for (int i = 0; i < dim; i++)
            {
                lst_visual.Items.Add(prodString(p[i]));
            }
        }
        //PULSANTE MODIFICA, rende utilizzabili gli strumenti per la modifica
        private void bttn_modifica_Click(object sender, EventArgs e)
        {
            if(dim>0)
            {
                txt_modprezzo.Enabled = true;
                lbl_modprezzo.Enabled = true;
                txt_modnome.Enabled = true;
                lbl_modnome.Enabled = true;
                txt_prodottomod.Enabled = true;
                lbl_vecchio.Enabled = true;

                bttn_confermamod.Enabled = true;
                bttn_cerca.Enabled = true;

                txt_prezzo.Enabled = false;
                txt_nome.Enabled = false;
                

                bttn_aggiungi.Enabled = false;
                bttn_annulla.Enabled = true;
            }
            else
            {
                MessageBox.Show("Non ci sono prodotti nella lista");
            }
        }
        //PULSANTE CERCA, una volta scritto il nome del prodotto da cercare viene scritto l'attuale nome e prezzo
        private void bttn_cerca_Click(object sender, EventArgs e)
        {
            string prodottomod = txt_prodottomod.Text;
            //if che controlla se la cella è vuota
            if (String.IsNullOrEmpty(txt_prodottomod.Text))
            {
                MessageBox.Show("Per modificare devi inserire il nome di un prodotto");
            }
            else
            {
                bool esiste = false;

                //ciclo for per cercare il prodotto e stampare l'attuale nome e prezzo
                for (int i = 0; i < dim; i++)
                {
                    //controllo dell'esistenza del prodotto nella lista
                    if (prodottomod == p[i].Nome)
                    {
                        esiste= true;
                    }
                    if (esiste == true)
                    {
                        txt_modnome.Text = p[i].Nome;
                        txt_modprezzo.Text = (p[i].Prezzo).ToString();
                        
                        txt_prodottomod.Enabled = false;
                    }
                }
                //se non presente messaggio a schermo
                if(esiste==false)
                {
                    MessageBox.Show("Non esiste un prodotto con questo nome.\nContolla di aver scritto il nome correttamente");
                }
            }
        }
        //PULSANTE CONFERMA, una volta premuto salva il contenuto delle celle e lo sovrascrive sui vecchi contenuti
        private void bttn_confermamod_Click(object sender, EventArgs e)
        {
            string numero = txt_modprezzo.Text;
            bool controllo = int.TryParse(numero, out _);
            string prodottomod = txt_prodottomod.Text;
            //ciclo if che controlla se le celle sono vuote
            if (String.IsNullOrEmpty(txt_modnome.Text) || String.IsNullOrEmpty(txt_modprezzo.Text))
            {
                MessageBox.Show("Per continuare le modifiche devi inserire qualcosa nelle text box");
            }
            //se sono presenti lettere nel campo dedicato al prezzo non permette di continuare
            else if (controllo == false)
            {
                MessageBox.Show("Non puoi inserire lettere in questo campo");
                
            }
            else 
            {
                //ciclo for per modificare i vecchi contenuti 
                for (int i = 0; i < dim; i++)
                {
                    if (prodottomod == p[i].Nome)
                    {
                        p[i].Nome = txt_modnome.Text;
                        p[i].Prezzo = Convert.ToInt32(txt_modprezzo.Text);
                        
                    }
                }

                //svuotamento delle celle
                txt_modnome.Text = ("");
                txt_modprezzo.Text = ("");
                txt_prodottomod.Text = "";

                //Riabilitazione di pulsanti e disabilitazione degli oggetti dedicati alla modifica
                txt_modprezzo.Enabled = false;
                lbl_modprezzo.Enabled = false;
                txt_modnome.Enabled = false;
                lbl_modnome.Enabled = false;
                txt_prodottomod.Enabled = false;
                lbl_vecchio.Enabled = false;
                txt_prezzo.Enabled = true;
                txt_nome.Enabled = true;
                txt_prodottomod.Enabled = false;

                bttn_annulla.Enabled = false;
                bttn_confermamod.Enabled = false;
                bttn_cerca.Enabled = false;
                bttn_aggiungi.Enabled = true;
                
                
            }
            visualizza(p);
            somma(p);
        }
        //PULSANTE ELIMINA, abilità gli strumenti per l'eliminazione
        private void bttn_eliminia_Click(object sender, EventArgs e)
        {
            lbl_eliminaprod.Enabled = true;
            txt_elimina.Enabled = true;

            bttn_confermaelimina.Enabled = true;
            bttn_annulla.Enabled = true;
        }
        //PULSANTE CONFERMA ELIMINAZIONE
        private void bttn_confermaelimina_Click(object sender, EventArgs e)
        {
            string prodelim = txt_elimina.Text;
            //if che controlla se la cella è vuota
            if(dim==0)
            {
                MessageBox.Show("Non ci sono prodotti nella lista");
            }
            else if (String.IsNullOrEmpty(txt_elimina.Text))
            {
                MessageBox.Show("Per continuare le modifiche devi inserire qualcosa nelle text box");
            }
            else
            {
                bool esiste = false;
                //ciclo for che cerca il prodotto da eliminare
                for (int i = 0; i < dim; i++)
                {
                    if (prodelim == p[i].Nome)
                    {
                        esiste=true;
                    }
                    //se esiste nella lista si procede all'eliminazione
                    if(esiste==true)
                    {
                        //messaggio che chiede la conferma dell'eliminazione
                        const string message = "Eliminare il prodotto?";
                        const string caption = "Form Closing";
                        var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        //se il risultato è uguale Sì il prodotto viene definitivamente eliminato dalla lista
                        if (result == System.Windows.Forms.DialogResult.Yes)
                        {
                            p[i].Nome = null;
                            p[i].Prezzo = 0;

                            dim--;

                            lbl_eliminaprod.Enabled = false;
                            txt_elimina.Enabled = false;

                            bttn_confermaelimina.Enabled = false;
                            bttn_annulla.Enabled = false;
                        }
                        //altrimenti gli strumenti di eliminazione vengono disabilitati
                        else
                        {
                            lbl_eliminaprod.Enabled = false;
                            txt_elimina.Enabled = false;
                            bttn_confermaelimina.Enabled = false;
                            bttn_annulla.Enabled = false;
                        }
                    }
                }
                if(esiste==false)
                {
                    MessageBox.Show("Non esiste un prodotto con questo nome.\nContolla di aver scritto il nome correttamente");
                }
                txt_elimina.Text = "";
            }
            visualizza(p);
            somma(p);
        }
        //PULSANTE ANNULLA, permette in qualsiasi di annullare l'azione che si sta compiendo
        private void bttn_annulla_Click(object sender, EventArgs e)
        {
            txt_modprezzo.Enabled = false;
            lbl_modprezzo.Enabled = false;
            txt_modnome.Enabled = false;
            lbl_modnome.Enabled = false;
            txt_prodottomod.Enabled = false;
            lbl_vecchio.Enabled = false;
            txt_elimina.Enabled = false;
            lbl_eliminaprod.Enabled = false;
            txt_prezzo.Enabled = true;
            txt_nome.Enabled = true;
            txt_prodottomod.Enabled = false;

            bttn_cerca.Enabled = false;
            bttn_confermamod.Enabled = false;
            bttn_annulla.Enabled = false;
            bttn_confermamod.Enabled = false;
            bttn_cerca.Enabled = false;
            bttn_confermaelimina.Enabled=false;
            bttn_aggiungi.Enabled = true;
            bttn_elimina.Enabled = true;

            txt_elimina.Text = "";
            txt_prodottomod.Text = "";
            txt_modnome.Text = "";
            txt_modprezzo.Text = "";
        }

        //ORDINAMENTO ALFABETICO
        private void bttn_OrdAlf_Click(object sender, EventArgs e)
        {
            if (dim == 0)
            {
                MessageBox.Show("Non ci sono prodotti nella lista");
            }
            //ordinamento BubbleSort che sfrutta la funzione CompareTo per confrontare i nomi dei prodotti
            for (int i = 0; i < dim; i++)
            {
                for (int j = i + 1; j < dim; j++)
                {
                    if (p[i].Nome.CompareTo(p[j].Nome) > 0)
                    {
                        string scelta = p[i].Nome;
                        p[i].Nome = p[j].Nome;
                        p[j].Nome = scelta;

                        float n = p[i].Prezzo;
                        p[i].Prezzo = p[j].Prezzo;
                        p[j].Prezzo = n;
                    }
                }
            }
            visualizza(p);
            somma(p);
        }
        //SOMMA TOTALE DEI PRODOTTI
        private void somma(Prodotto[]p)
        {
            float som = 0;

            for (int i = 0; i < dim;i++)
            {
                som += p[i].Prezzo;
            }
            lst_totEsconto.Items.Clear();
            lst_totEsconto.Items.Add("Prezzo totale:"+som);
        }
        //SOMMA DELLA PERCENTUALE
        private void sommaPerc_Click(object sender, EventArgs e)
        {
            if (dim == 0)
            {
                MessageBox.Show("Non ci sono prodotti nella lista");
            }
            else if (String.IsNullOrEmpty(txt_sconto.Text))
            {
                MessageBox.Show("Devi inserire un valore nelle text box");
            }
            else
            {
                int sconto;
                sconto = int.Parse(txt_sconto.Text);
                if (sconto < 0)
                {
                    MessageBox.Show("Devi inserire un valore positivo");
                }
                {
                    for (int i = 0; i < dim; i++)
                    {
                        p[i].Prezzo = p[i].Prezzo + (p[i].Prezzo / 100) * sconto;
                    }
                    somma(p);
                    txt_sconto.Text = "";
                }
            }
        }
        //SOTTRAZIONE DELLA PERCENTUALE
        private void bttn_sottraiPerc_Click(object sender, EventArgs e)
        {
            if (dim == 0)
            {
                MessageBox.Show("Non ci sono prodotti nella lista");
            }
            else if (String.IsNullOrEmpty(txt_sconto.Text))
            {
                MessageBox.Show("Devi inserire un valore nelle text box");
            }
            else 
            {
                int sconto;
                sconto = int.Parse(txt_sconto.Text);

                if (sconto < 0)
                {
                    MessageBox.Show("Devi inserire un valore positivo");
                }
                {
                    for (int i = 0; i < dim; i++)
                    {
                        p[i].Prezzo = p[i].Prezzo - (p[i].Prezzo / 100) * sconto;
                    }
                    somma(p);
                    txt_sconto.Text = "";
                }
                
            }
        }
        //NUMERO MASSIMO
        private void bttn_max_Click(object sender, EventArgs e)
        {
            

            if (dim == 0)
            {
                MessageBox.Show("Non ci sono prodotti nella lista");
            }
            else
            {
                float max = p[0].Prezzo;
                for (int i = 0; i < dim; i++)
                    {
                        if (p[i].Prezzo > max)
                        {
                             max = p[i].Prezzo;
                        }
                }
                txt_maxmin.Clear();
                txt_maxmin.Text = max.ToString();
            }
        }
        //NUMERO MINIMO
        private void bttn_min_Click(object sender, EventArgs e)
        {
            if (dim == 0)
            {
                MessageBox.Show("Non ci sono prodotti nella lista");
            }
            else
            {
                float min = p[0].Prezzo;
                for (int i = 0; i < dim; i++)
                {
                    if (p[i].Prezzo < min)
                    {
                        min = p[i].Prezzo;
                    }
                }
                txt_maxmin.Clear();
                txt_maxmin.Text = min.ToString();
            }
        }

        private void bttn_salva_Click(object sender, EventArgs e)
        {
            if (dim == 0)
            {
                MessageBox.Show("Non ci sono prodotti nella lista");
            }
            else
            {
                StreamWriter sw = new StreamWriter(@"Lista.txt");

                for (int i = 0; i < dim; i++)
                {
                    sw.WriteLine(p[i].Nome + ";" + p[i].Prezzo);
                }

                sw.Close();

                MessageBox.Show("La lista dei prodotti è stata salvata nel file Lista");
            }
        }

        private void bttn_leggi_Click(object sender, EventArgs e)

        {   
            StreamReader sr = new StreamReader(@"ElencoProdotti.txt");
            string linea = sr.ReadToEnd();
            string[] l = linea.Split();
            

            for (int i = 0; i < l.Length; i++)
            {
                lst_visual.Items.Add(l[i]);
            }
            sr.Close();
            
        }
    }
}
