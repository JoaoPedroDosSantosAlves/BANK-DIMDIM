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
    public partial class TelaMenu : Form
    {
        public TelaMenu()
        {
            InitializeComponent();
        }

        private void BtnExitMenu_Click(object sender, EventArgs e)
        {
            Form1 TelaLogin = new Form1();
            TelaLogin.Show();
            MessageBox.Show("Até logo");
            
        }

        private void BtnGoCadastro_Click(object sender, EventArgs e)
        {
            Cadastro TelaCadastroCliente = new Cadastro();
            TelaCadastroCliente.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadFornecedor TelaCadastroFornecedor = new CadFornecedor();
            TelaCadastroFornecedor.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CadFuncionarios TelaCadastroFuncionarios = new CadFuncionarios();
            TelaCadastroFuncionarios.Show();
        }
    }
}
