using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {
        int a, b, c, i = 0;
        char cc;
        Random r = new Random();
        Form2 f2 = new Form2();

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            b = Convert.ToInt32(textBox1.Text);
            comp();
            } catch(Exception)
            {
                Clear();
                textBox1.Focus();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            cc = '-';
            try { SaveAndClear(); } catch(Exception) { }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cc = '*';
            try { SaveAndClear(); } catch (Exception) { }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cc = '/';
            try { SaveAndClear(); } catch (Exception) { }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            cc = '^';
            try { SaveAndClear(); } catch (Exception) { }
        }

        private void Clear()
        {
            a = 0; b = 0; c = 0;  cc = '+'; textBox1.Clear(); label1.Text = "";
        }
        private void button7_Click(object sender, EventArgs e)
        {
            Clear();
            textBox1.Focus();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = Convert.ToString(r.Next(f2.a, f2.b));
            textBox1.Focus();
        }

        private void button8_MouseDown(object sender, MouseEventArgs e)
        {
            if( e.Button == MouseButtons.Right)
            {
                f2.ShowDialog();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comp ()
        {
            switch (cc)
            {
                case '+':
                    c = a + b;
                    break;
                case '-':
                    c = a - b;
                    break;
                case '*':
                    c = a * b;
                    break;
                case '/':
                    try
                    {
                        c = a / b;
                    }
                    catch (DivideByZeroException)
                    {
                        MessageBox.Show("Делить на 0 нельзя");
                    }
                    break;
                case '^':
                    c = Convert.ToInt32(Math.Pow(a, b));
                    break;
            }
            textBox1.Text = c.ToString();
            label1.Text = Convert.ToString(c);
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            cc = '+';
            try { SaveAndClear(); } catch (Exception) { }
        }
        private void SaveAndClear()
        {
            i++;
            if (i > 1)
            {
                b = Convert.ToInt32(textBox1.Text);
                i = 1;
                comp();
            }
            a = Convert.ToInt32(textBox1.Text);
            label1.Text = a.ToString();
            textBox1.Clear();
            textBox1.Focus();
        }
    }
}
