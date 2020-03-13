using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRYTO_1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
        }

        private void criptografar_Click(object sender, EventArgs e)
        {
            textBox2.Text = string.Empty;
            for (int i=0; i < textBox1.Text.Length; i++)
            {
                int textoUsuario = (int)textBox1.Text[i];
                int textoCripto = textoUsuario + 255;
                textBox2.Text += Char.ConvertFromUtf32(textoCripto);
            }
        }

        private void descriptografar_Click(object sender, EventArgs e)
        {
            textBox3.Text = string.Empty;
            for (int i = 0; i < textBox2.Text.Length; i++)
            {
                int textoCripto = (int)textBox2.Text[i];
                int textoDecripto = textoCripto - 255;
                textBox3.Text += Char.ConvertFromUtf32(textoDecripto);
            }
        }
    }
}
