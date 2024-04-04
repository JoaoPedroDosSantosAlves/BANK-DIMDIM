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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            {
                if (txtUsuario.Text == "")
                {
                    MessageBox.Show("Usuário é obrigatório");
                }
                else if (txtSenha.Text == "")
                {
                    MessageBox.Show("Senha é obrigatória");
                }
                else
                {
                    if (txtUsuario.Text == "esteves" && txtSenha.Text == "1245e" ||
                        txtUsuario.Text == "jobs" && txtSenha.Text=="468r")
                    {
                        MessageBox.Show("Seja bem-vindo!");
                        TelaMenu Telamenu = new TelaMenu();
                        Telamenu.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou Senha inválidos!");
                    }
                }
            }

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
