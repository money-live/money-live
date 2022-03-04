using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Шифр_Вижинера
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number = 1039;
            textBox2.Clear();
            int a = textBox1.Text.Length;
            int b = textBox3.Text.Length;
            char [] key = new char[b];
            char[] mas = new char[a];
            for (int j = 0;j< b;j++)
            {
                key[j] = textBox3.Text[j];
            }
            for (int i = 0; i < a; i++)
             {
                mas[i] = textBox1.Text[i];
                if (mas[i] == ' ') textBox2.Text += "*";
                else
                textBox2.Text += (char)((((int)mas[i] - number + (int)key[i % b] - number) % 32) + number);
             }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            int q;
            int number = 1071;
            int a = textBox2.Text.Length;
            int b = textBox3.Text.Length;
            char[] mas = new char[a];
            char[] key = new char[b];
            for (int j = 0; j < b; j++)
            {
                key[j] = textBox3.Text[j];
            }
            for (int i = 0; i < a; i++)
            {
                mas[i] = textBox2.Text[i];
                q = (((int)mas[i] - number) - ((int)key[i % b] - number));
                if (q < 0) q += 32;
                if (q < 0) q += 32;
                if (q > 0) textBox1.Text += ((char)(q + number)).ToString();
                else
                    if (q == 0) textBox1.Text += 'я';
                else
                    textBox1.Text += ' ';
            }
        }
    }
}
