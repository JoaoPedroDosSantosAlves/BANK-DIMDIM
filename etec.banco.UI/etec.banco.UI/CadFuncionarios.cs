﻿using System;
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
    public partial class CadFuncionarios : Form
    {
        public CadFuncionarios()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Form1 TelaLogin = new Form1();
            TelaLogin.Show();
            this.Hide();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            TelaMenu telaMenu = new TelaMenu();
            telaMenu.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (todostextboxpreenchidos())
            {
                MessageBox.Show(" Cadastro Feito com Sucesso");
                textBox8.Text = "";
                textBox7.Text = "";
                textBox6.Text = "";
                textBox1.Text = "";
                textBox5.Text = "";
                textBox4.Text = "";
                textBox3.Text = "";
                textBox2.Text = "";
                textBox9.Text = "";
                comboBox1.Text = "";
            }
            else
            {
                MessageBox.Show("Todos campos precisam estar todos preenchidos");
                textBox8.Focus();
            }
            bool
           todostextboxpreenchidos()
            {
                return textBox8.Text != "" && textBox1.Text != "" && textBox4.Text != "" &&
                 textBox3.Text != "" && textBox7.Text != "" && textBox6.Text != "" &&
                 textBox5.Text != "" && textBox2.Text != "" && textBox9.Text != "";
                  
            }
        }

    }
}