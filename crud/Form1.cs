using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crud
{
    
    public partial class Form1 : Form
    {
        public string[] animali = new string[1000];
        public int[] prezzo = new int[1000];
        public int dim = 0;
        public int dimen = 0;
        public int posizione;
        public string ca;
        public int somma;
        public int som = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Aggiun(animali,ref dim,textBox1.Text);
            Stampa(textBox1.Text);
        }
      
        private void button2_Click(object sender, EventArgs e)
        {
            Eliminato(animali,ref dim, textBox1.Text);
            
        }

       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            Stampo(textBox1.Text);
            Prezzo(prezzo, ref dimen, textBox1.Text);
        }

        //funzioni di servizio
        public void Aggiun(string[] animali,ref int dim, string ani)//funzione di Aggiunta
        {
            animali[dim] = ani;
            dim++;
        }
        public void Prezzo(int[] prezzo, ref int dimen, string soldi)//funzione di Aggiunta
        {
            prezzo[dimen] = int.Parse(soldi);
            dimen++;
        }

        public void Eliminato(string[] animali,ref int dim, string estinto)//funzione per eliminare un'animale
        {

            this.listView1.Items.Clear();
            this.listView2.Items.Clear();
            for (int i=posizione-1;i<dim; i++)
            {
                animali[i] = animali[i + 1];

            }
            dim--;
            Stampa(ca);
            
        }
        
      
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void Stampa(string ani)//funzione stampa 
        {
            this.listView1.Items.Add(ani);
           
        }
        public void Stampo(string soldi)//funzione stampa del prezzo
        {
            this.listView2.Items.Add(soldi);

        }
        
        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void somm(int[]prezzo,ref int dimen,ref int somma)
        {   Sta(ref  somma);
            for (int i=0;i<dimen;i++)
            {
                
                somma = prezzo[i] + prezzo[i + 1];
                i++;
            }
            
        }
        public void Sta(ref int somma)//funzione stampa del prezzo
        {
            this.listView4.Items.Add(somma.ToString());

        }
    }
}
