using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitHubUzduotis
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 32)
            {
                e.Handled = true;
            }
        }


        int[] Skaiciai = new int[10]; // Masyvas
        int n = 0; // Masyvo elementu skaičius

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                if (Int32.TryParse(richTextBox1.Text, out Skaiciai[n]))
                {

                    n++;
                    label5.Text = Skaiciai[0] + " ";
                    label4.Text = "Įvesta skaičių: " + 1 + " (trūksta: 9)";
                    for (int i = 1; i < n; i++)
                    {
                        int t = 10 - n;
                        label5.Text += (Skaiciai[i] + " ");
                        label4.Text = "Įvesta skaičių: " + n + " (trūksta: " + t + ")";

                    }
                    if (n == 10)
                    {
                        button2.Text = "Išvalyti masyva";
                        label4.ForeColor = System.Drawing.Color.Green;
                        label4.Text = "Ivedėte 10 skaičių i masyva!";

                        int i = 0;
                        int sum = 0;
                        while (true)
                        {
                            sum += Skaiciai[i];
                            i++;
                            if (i == n) break;
                        }
                        label6.Text = "Suma= " + sum;
                        label6.Visible = true;
                    }

                }
            }
            catch (IndexOutOfRangeException) { n = 0; label5.Text = " "; richTextBox1.Clear(); label6.Text = " "; button2.Text = "Prideti elementa"; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var PiestiEgle = string.Empty;
            int Eilutes = int.Parse(textBox1.Text);
            for (int i = 0; i < Eilutes; i++)
            {
                for (int j = 0; j < Eilutes - i; j++)
                {
                    PiestiEgle += " ";
                }
                for (int k = 0; k <= i; k++)
                {
                    PiestiEgle += "* ";
                }
                PiestiEgle += "\n";
            }

            richTextBox2.Text = PiestiEgle;
        }
    }
}
