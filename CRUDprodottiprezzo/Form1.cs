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
        public int dim = 100;
        public Form1()
        {
            InitializeComponent();
        }
        public string Scrivi(Prodotto p)
        {
            
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bttn_aggiungi_Click(object sender, EventArgs e)
        {

        }
    }
}
