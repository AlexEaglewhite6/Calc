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
    public partial class Form2 : Form
    {
         public int a = 1, b = 11;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text)+1;
            }
            catch (Exception)
            {
                a = 1; b = 11;
            }
            
            this.Close();
        }
    }
}
