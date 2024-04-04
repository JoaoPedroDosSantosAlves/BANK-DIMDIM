using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace etec.banco.UI
{
    public partial class Cadastro : Form
    {
        private InfoCadastrais infoo;
        public Cadastro()
            
        {
            InitializeComponent();
            infoo= new InfoCadastrais();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 TelaLogin = new Form1();
            TelaLogin.Show();
            this.Hide();
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            TelaMenu telaMenu = new TelaMenu();
            telaMenu.Show();
            this.Hide();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
            
            if (todostextboxpreenchidos())
            {
                MessageBox.Show(" Cadastro Feito com Sucesso");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                textBox9.Text = "";
            }
            else
            {
                MessageBox.Show("Todos campos precisam estar todos preenchidos");
                textBox1.Focus();
            }
            bool
           todostextboxpreenchidos()
            {
                return textBox1.Text != "" && textBox4.Text != ""
                    && textBox6.Text != "" && textBox7.Text != ""
                  && textBox2.Text != "" && textBox3.Text != "" 
                  && textBox5.Text != "" && textBox8.Text != "" && textBox9.Text != "";
            }
        }

    }
}
