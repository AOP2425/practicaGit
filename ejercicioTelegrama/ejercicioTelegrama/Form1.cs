using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicioTelegrama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string textoTelegrama =  textBox2.Text.Trim();

            char tipoTelegrama = radioButton1.Checked ? 'u' : 'o';
            int numPalabras = 0;
            double coste;

            //Leo el telegrama  
            textoTelegrama = textBox1.Text;
            string[] palabras = textoTelegrama.Split(new[] { ' ' });
            numPalabras = palabras.Length;

            // telegrama urgente? 
            if (radioButton1.Checked)
            {
                tipoTelegrama = 'u';
            }
            if (radioButton2.Checked)
            {
                tipoTelegrama = 'o';
            }
            //Obtengo el número de palabras que forma el telegrama  
            numPalabras = textoTelegrama.Length;

            //Si el telegrama es ordinario 
            if (tipoTelegrama == 'o')
            {
                if (numPalabras <= 10)
                {
                    coste = 2.5;
                }
                else
                {
                    coste = 2.5 + 0.5 * (numPalabras - 10);
                }
            }
            else
            //Si el telegrama es urgente 
            {
                if (tipoTelegrama == 'u')
                {
                    if (numPalabras <= 10)
                    {
                        coste = 5;
                    }
                    else
                    {
                        coste = 5 + 0.75 * (numPalabras - 10);
                    }
                }
                else
                {
                    coste = 0;
                }
            }
            textBox2.Text = coste.ToString() + " euros";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

