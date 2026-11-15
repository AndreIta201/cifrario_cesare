using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cifrario_cesare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_cifra_Click(object sender, EventArgs e)
        {
            int chiave = Convert.ToInt32(txt_chiave.Text);
            string frase = txt_n1.Text;
            char[] frase_cifrata = frase.ToCharArray();

            for (int i = 0; i < frase.Length; i++)
            {
                char c = frase_cifrata[i];
                {
                    if (c >= 'a' && c <= 'z')
                    {
                        frase_cifrata[i] = (char)(((c - 'a' + chiave) % 26) + 'a');
                    }
                    else if (c >= 'A' && c <= 'Z')
                    {
                        frase_cifrata[i] = (char)(((c - 'A' + chiave) % 26) + 'A');
                    }
                    lbl_cifrario.Text = new string(frase_cifrata); 
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int chiave = Convert.ToInt32(txt_chiave2.Text);
            string frase = txt_n2.Text;
            char[] frase_decifrata = frase.ToCharArray();

            chiave = chiave % 26;
            for (int i = 0; i < frase.Length; i++)
            {
                char c = frase_decifrata[i];
                if (c >= 'a' && c <= 'z')
                {
                    frase_decifrata[i] = (char)(((c - 'a' - chiave + 26) % 26) + 'a');
                }
                else if (c >= 'A' && c <= 'Z')
                {
                    frase_decifrata[i] = (char)(((c - 'A' - chiave + 26) % 26) + 'A');
                }
            }
            lbl_decripta.Text = new string(frase_decifrata);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string frase = txt_n3.Text, chiave = txt_parola.Text;
            int j = 0;
            char[] frase_cifrata = frase.ToCharArray();
            chiave = chiave.ToLower();

            for (int i = 0; i < frase.Length; i++)
            {
                char c = frase_cifrata[i];
                {

                    if (c >= 'a' && c <= 'z')
                    {

                        frase_cifrata[i] = (char)(((c - 'a' + chiave[j % chiave.Length] - 'a') % 26) + 'a');
                        j++;
                    }
                    else if (c >= 'A' && c <= 'Z')
                    {
                        
                        frase_cifrata[i] = (char)(((c - 'A' + chiave[j % chiave.Length] - 'a') % 26) + 'A');
                        j++;
                    }

                }
            }
            lbl_criptaggio_parola.Text = new string(frase_cifrata);
        }

        private void btn_decripta2_Click(object sender, EventArgs e)
        {
            string frase = txt_n4.Text, chiave = txt_decriptaggio_parola.Text;
            int j = 0;
            char[] frase_cifrata = frase.ToCharArray();
            chiave = chiave.ToLower();

            for (int i = 0; i < frase.Length; i++)
            {
                char c = frase_cifrata[i];
                {

                    if (c >= 'a' && c <= 'z')
                    {

                        frase_cifrata[i] = (char)(((c - 'a' - (chiave[j % chiave.Length] - 'a') + 26) % 26) + 'a');
                        j++;
                    }
                    else if (c >= 'A' && c <= 'Z')
                    {

                        frase_cifrata[i] = (char)(((c - 'A' - (chiave[j % chiave.Length] - 'a') + 26) % 26) + 'A');
                        j++;
                    }

                }
            }
            lbl_decriptaggio_parola.Text = new string(frase_cifrata);
        }
    }
}
