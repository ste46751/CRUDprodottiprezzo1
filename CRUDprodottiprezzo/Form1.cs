using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CRUDprodottiprezzo.Form1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CRUDprodottiprezzo
{
    public partial class Form1 : Form
    {
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
            dim = 0;   
            p = new Prodotto[100];

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
            return "Nome:" + p.Nome + " Prezzo:" + p.Prezzo.ToString();
        }
        
        //BOTTONE CHE SALVA I IL NOME E IL PREZZO DEL PRODOTTO
        private void bttn_aggiungi_Click(object sender, EventArgs e)
        {
            p[dim].Nome=txt_nome.Text;
            p[dim].Prezzo=Convert.ToInt32(txt_prezzo.Text);
            txt_nome.Text=(" ");
            txt_prezzo.Text=(" ");

            MessageBox.Show("Aggiunto");
            dim++;

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

        }
        private void bttn_cerca_Click(object sender, EventArgs e)
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
        }
        private void txt_modnome_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
