﻿using System;
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
            //comandi Visibile per l'interfaccia grafica, che vanno a nascondere celle quando non servono



            txt_modprezzo.Visible = false;
            lbl_modprezzo.Visible = false;
            txt_modnome.Visible = false;
            lbl_modnome.Visible = false;
            txt_prodottomod.Visible = false;
            lbl_vecchio.Visible = false;

            bttn_confermamod.Visible = false;
            bttn_cerca.Visible = false;


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
            }

        }

        //BOTTONE CHE VISUALIZZA I PRODOTTI NELLA LISTA
        private void bttn_visuallizza_Click(object sender, EventArgs e)
        {
            lst_visual.Items.Clear();
            for (int i = 0; i < dim; i++)
            {
                lst_visual.Items.Add(prodString(p[i]));
            }

        }



        //Bottone modifica che fa apparire oggeti per le modifiche prima nascoste

        private void lbl_prezzo_Click(object sender, EventArgs e)
        {

        }

        //MOSTRA LA CELLE E I LABEL
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
            bttn_visuallizza.Enabled = false;

        }

        //Bottone cerca, una volta scritto il prodotto da cercare viene scritto l'attuale nome e prezzo
        private void bttn_cerca_Click(object sender, EventArgs e)
        {
            string prodottomod = txt_prodottomod.Text;
            if (String.IsNullOrEmpty(txt_prodottomod.Text))
            {
                MessageBox.Show("Per modificare devi inserire il nome di un prodotto");
            }
            else
            {
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
            if (String.IsNullOrEmpty(txt_modnome.Text) || String.IsNullOrEmpty(txt_modprezzo.Text))
            {
                MessageBox.Show("Per continuare le modifiche devi inserire qualcosa nelle text box");
            }
            else
            {
                for (int i = 0; i < dim; i++)
                {
                    if (prodottomod == p[i].Nome)
                    {
                        p[i].Nome = txt_modnome.Text;
                        p[i].Prezzo = Convert.ToInt32(txt_modprezzo.Text);
                    }

                }

                txt_modnome.Text = ("");
                txt_modprezzo.Text = ("");

                //Riabilitazione di pulsanti e rimozione della visibilità degli oggetti dedicati alla modifica
                txt_modprezzo.Visible = false;
                lbl_modprezzo.Visible = false;
                txt_modnome.Visible = false;
                lbl_modnome.Visible = false;
                txt_prodottomod.Visible = false;
                lbl_vecchio.Visible = false;

                bttn_confermamod.Visible = false;
                bttn_cerca.Visible = false;
                txt_prezzo.Enabled = true;
                txt_nome.Enabled = true;
                bttn_aggiungi.Enabled = true;
                bttn_visuallizza.Enabled = true;
                txt_prodottomod.Enabled = true;
            }





        }
        /*private void bttn_cerca_Click(object sender, EventArgs e)
        {
            string prodottomod = txt_prodottomod.Text;

            for (int i = 0; i < dim; i++)
            {
                if (p[i].Nome == prodottomod)
                {
                    txt_modnome.Text = p[i].Nome;
                    txt_modprezzo.Text = (p[i].Prezzo).ToString();
                }
                else
                { }
            }
            txt_prodottomod.Enabled = false;   
        }
        //PULSANTE CHE SALVA LE MODIFICHE
        private void bttn_confermamod_Click(object sender, EventArgs e)
        {
            string prodottomod = txt_prodottomod.Text;

            for (int i = 0; i < dim; i++)
            {
                
                    p[i].Nome = txt_modnome.Text;
                    p[i].Prezzo = Convert.ToInt32(txt_modprezzo.Text);
                
            }
            txt_modprezzo.Visible = false;
            lbl_modprezzo.Visible = false;
            txt_modnome.Visible = false;
            lbl_modnome.Visible = false;
            txt_prodottomod.Visible = false;
            lbl_vecchio.Visible = false;

            bttn_confermamod.Visible = false;
            bttn_cerca.Visible = false;

            txt_prezzo.Enabled = true;
            txt_nome.Enabled = true;
            txt_prodottomod.Enabled = true;

        }*/
        private void txt_modnome_TextChanged(object sender, EventArgs e)
        {

        }


        private void lst_visual_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /*private void lbl_prezzo_Click(object sender, EventArgs e)
        {

        }*/



    }
}
