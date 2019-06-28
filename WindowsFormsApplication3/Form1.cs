using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            string slovo = textBox2.Text;
            char[] simvols = new char[slovo.Length];
            int[] mas_num = new int[slovo.Length];
            int sdvig = Convert.ToInt32(textBox5.Text);

            for (int i = 0; i < slovo.Length; i++)
            {
                simvols[i] = slovo[i];
                mas_num[i] = (int)simvols[i] + sdvig;
                if (mas_num[i] > 1103)
                {
                    mas_num[i] -= 32;
                }
                else
                    if (mas_num[i] < 1072)
                    mas_num[i] += 32;

                simvols[i] = (char)mas_num[i];
                textBox3.Text += simvols[i];
            }    
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            string slovo = textBox2.Text;
            char[] simvols = new char[slovo.Length];
            int[] mas_num = new int[slovo.Length];
            int sdvig = Convert.ToInt32(textBox5.Text);

            for (int i = 0; i < slovo.Length; i++)
            {
                simvols[i] = slovo[i];
                mas_num[i] = (int)simvols[i] - sdvig;
                if (mas_num[i] > 1103)
                {
                    mas_num[i] -= 32;
                }
                else
                    if (mas_num[i] < 1072)
                    mas_num[i] += 32;

                simvols[i] = (char)mas_num[i];
                textBox3.Text += simvols[i];
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            string slovo = textBox4.Text;
            char[] simvols = new char[slovo.Length];
            int[] mas_num = new int[slovo.Length];
            int sdvig = 0;
            int k = 0;
            while (k < 31)
            {
                sdvig++;
                for (int i = 0; i < slovo.Length; i++)
                {
                    simvols[i] = slovo[i];
                    mas_num[i] = (int)simvols[i] - sdvig;
                    if (mas_num[i] > 1103)
                    {
                        mas_num[i] -= 32;
                    }
                    else
                        if (mas_num[i] < 1072)
                        mas_num[i] += 32;

                    simvols[i] = (char)mas_num[i];
                    textBox1.Text += simvols[i] ;
                }
                textBox1.Text += "  сдвиг <-- на " + sdvig.ToString() + "\r\n";
                k++;
            }
        }
    }
}
