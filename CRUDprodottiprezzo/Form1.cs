using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            p = new Prodotto[100];
            dim = 0;    
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bttn_aggiungi_Click(object sender, EventArgs e)
        {
            if(txt_nome.Text!=null || txt_prezzo!=null)
            {
                p[dim].Nome=txt_nome.Text;
                p[dim].Prezzo=Convert.ToInt32(txt_prezzo.Text);

                txt_nome.Text=(" ");
                txt_prezzo.Text=(" ");

                dim++;
            }
            else
            {
                Console.WriteLine("Celle piene");
            }

        }
    }
}
