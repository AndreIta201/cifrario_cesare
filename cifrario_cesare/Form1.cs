using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            int chiave = Convert.ToInt32(textBox2.Text), somma = 0;
            string frase = textBox1.Text;

            for (int i = 0; i < frase.Length; i++)
            {
                

                foreach (char s in frase)
                {
                    if (s == ' ')
                    {

                    }
                    int cifra = Convert.ToInt32(frase[i]);

                    if (cifra >= 97 && cifra <= 122)
                    {
                        cifra -= 96;
                        cifra += chiave;
                    }
                    else if (cifra > 122)
                    {
                        cifra -= 26 + chiave;
                    }
                    else if (cifra >= 65 && cifra <= 90)
                    {
                        cifra -= 64;
                        cifra += chiave;
                    }
                    i += cifra;
                    lbl_cifrario.Text = Convert.ToString(i);
                }



                

            }
        }
    }
}
