using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace estudio
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnCadasUser_Click(object sender, EventArgs e)
        {
            int tipo = 0;
            if (comboBoxTipo.SelectedIndex == 0)
                tipo = 1; 
            else if (comboBoxTipo.SelectedIndex == 1)
                tipo = 2; 
            if (DAO_Conexao.CadLogin(txtUsuario.Text, txtSenha.Text, tipo)) 
                MessageBox.Show("Cadastro realizado com sucesso");
            else
                MessageBox.Show("Erro de cadastro");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
