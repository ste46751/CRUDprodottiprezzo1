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

        public int dim;
        public Form1()
        {
            InitializeComponent();
            p = new Prodotto[100];

            dim = 0;

            //comandi Visibile per l'interfaccia grafica del PULSANTE MODIFICA, che vanno a nascondere celle quando non servono

            txt_modprezzo.Visible = false;
            lbl_modprezzo.Visible = false;
            txt_modnome.Visible = false;
            lbl_modnome.Visible = false;
            txt_prodottomod.Visible = false;
            lbl_vecchio.Visible = false;

            bttn_confermamod.Visible = false;
            bttn_cerca.Visible = false;

            //comandi Visibile per l'interfaccia grafica del PULSANTE MODIFICA, che vanno a nascondere celle quando non servono
            lbl_eliminaprod.Visible = false;
            txt_elimina.Visible = false;
            btt_confermaelimina.Visible = false;

            bttn_annulla.Visible = false;


        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        //FUNZIONE CHE SCRIVE L'OUTPUT PER LA LISTA
        public string prodString(Prodotto p)
        {
            return "Nome: " + p.Nome + " Prezzo: " + p.Prezzo.ToString();
        }

        //BOTTONE CHE SALVA I IL NOME E IL PREZZO DEL PRODOTTO
        private void bttn_aggiungi_Click(object sender, EventArgs e)
        {
            //se le text box sono vuote appare il messaggio a schermo fino a quando entrambi i campi non saranno pieni
            if (String.IsNullOrEmpty(txt_nome.Text) || String.IsNullOrEmpty(txt_prezzo.Text))
            {
                MessageBox.Show("Devi riempire tutti i campi per aggiungere un prodotto");
            }

            //quando le text box sono compilate i dati vengono salvati all'interno dell'array
            else
            {
                p[dim].Nome = txt_nome.Text;
                p[dim].Prezzo = Convert.ToInt32(txt_prezzo.Text);
                txt_nome.Text = ("");
                txt_prezzo.Text = ("");

                MessageBox.Show("Aggiunto");

                dim++;
                visualizza(p);
                somma(p);
            }

        }

        //BOTTONE CHE VISUALIZZA I PRODOTTI NELLA LISTA
        private void visualizza(Prodotto[]p)
        {
            lst_visual.Items.Clear();
            for (int i = 0; i < dim; i++)
            {
                lst_visual.Items.Add(prodString(p[i]));
            }
        }
        private void bttn_visuallizza_Click(object sender, EventArgs e)
        {
        }



        //Bottone modifica che fa apparire oggeti per le modifiche prima nascoste
        private void bttn_modifica_Click(object sender, EventArgs e)
        {
            txt_modprezzo.Visible = true;
            lbl_modprezzo.Visible = true;
            txt_modnome.Visible = true;
            lbl_modnome.Visible = true;
            txt_prodottomod.Visible = true;
            lbl_vecchio.Visible = true;

            bttn_confermamod.Visible = true;
            bttn_cerca.Visible = true;

            txt_prezzo.Enabled = false;
            txt_nome.Enabled = false;

            bttn_aggiungi.Enabled = false;
            

            bttn_annulla.Visible = true;

        }

        //Bottone cerca, una volta scritto il prodotto da cercare viene scritto l'attuale nome e prezzo
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
                //ciclo for per cercare il prodotto e stampare l'attuale nome e prezzo
                for (int i = 0; i < dim; i++)
                {
                    if (prodottomod == p[i].Nome)
                    {
                        txt_modnome.Text = p[i].Nome;
                        txt_modprezzo.Text = (p[i].Prezzo).ToString();
                        txt_prodottomod.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Prodotto non presente nella lista, controlla di averlo scritto correttamente");
                    }

                }
            }

        }
        //Bottone conferma che una volta premuto salva il contenuto delle celle e lo sovrascrive sui vecchi contenuti
        private void bttn_confermamod_Click(object sender, EventArgs e)
        {
            string prodottomod = txt_prodottomod.Text;
            //if che controlla se le celle sono vuote
            if (String.IsNullOrEmpty(txt_modnome.Text) || String.IsNullOrEmpty(txt_modprezzo.Text))
            {
                MessageBox.Show("Per continuare le modifiche devi inserire qualcosa nelle text box");
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

                //Riabilitazione di pulsanti e rimozione della visibilità degli oggetti dedicati alla modifica
                txt_modprezzo.Visible = false;
                lbl_modprezzo.Visible = false;
                txt_modnome.Visible = false;
                lbl_modnome.Visible = false;
                txt_prodottomod.Visible = false;
                lbl_vecchio.Visible = false;
                bttn_annulla.Visible = false;

                bttn_confermamod.Visible = false;
                bttn_cerca.Visible = false;
                txt_prezzo.Enabled = true;
                txt_nome.Enabled = true;
                bttn_aggiungi.Enabled = true;txt_prodottomod.Enabled = true;
                
            }
            visualizza(p);
        }
        private void bttn_eliminia_Click(object sender, EventArgs e)
        {
            lbl_eliminaprod.Visible = true;
            txt_elimina.Visible = true;
            btt_confermaelimina.Visible = true;

            bttn_annulla.Visible = true;
        }

        private void btt_confermaelimina_Click(object sender, EventArgs e)
        {
            string prodelim = txt_elimina.Text;
            //if che controlla se la cella è vuota
            if (String.IsNullOrEmpty(txt_elimina.Text))
            {
                MessageBox.Show("Per continuare le modifiche devi inserire qualcosa nelle text box");
            }
            else
            {
                //ciclo for che cerca il prodotto da eliminare
                for (int i = 0; i < dim; i++)
                {
                    if (prodelim == p[i].Nome)
                    {
                        //messaggio che chiede la conferma dell'eliminazione
                        const string message = "Eliminare il prodotto?";
                        const string caption = "Form Closing";
                        var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == System.Windows.Forms.DialogResult.Yes)
                        {
                            p[i].Nome = null;
                            p[i].Prezzo = 0;

                            dim--;
                        }
                        else
                        {
                            lbl_eliminaprod.Visible = false;
                            txt_elimina.Visible = false;
                            btt_confermaelimina.Visible = false;
                            bttn_annulla.Visible = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Prodotto non presente nella lista, controlla di averlo scritto correttamente");
                    }

                }

                txt_elimina.Text = "";
            }
            visualizza(p);
        }
        private void bttn_annulla_Click(object sender, EventArgs e)
        {
            txt_modprezzo.Visible = false;
            lbl_modprezzo.Visible = false;
            txt_modnome.Visible = false;
            lbl_modnome.Visible = false;
            txt_prodottomod.Visible = false;
            lbl_vecchio.Visible = false;
            bttn_cerca.Visible = false;
            bttn_confermamod.Visible = false;
            bttn_annulla.Visible = false;
            bttn_elimina.Visible=false;
            txt_elimina.Visible=false;  
            lbl_eliminaprod.Visible=false;

            bttn_confermamod.Visible = false;
            bttn_cerca.Visible = false;
            txt_prezzo.Enabled = true;
            txt_nome.Enabled = true;
            bttn_aggiungi.Enabled = true;bttn_elimina.Enabled = true;
            txt_prodottomod.Enabled = true;
        }

        private void bttn_OrdAlf_Click(object sender, EventArgs e)
        {
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
        }
        private void somma(Prodotto[]p)
        {
            float somma = 0;

            for(int i = 0; i < dim;i++)
            {
                somma += p[i].Prezzo;
            }

            lst_visual.Items.Add(somma);
        }
    }
}
