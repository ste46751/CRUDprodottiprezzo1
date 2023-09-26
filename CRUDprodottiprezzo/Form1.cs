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
    }
}
