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
            if (comboBox1.SelectedIndex == 0)
                tipo = 1; 
            else if (comboBox1.SelectedIndex == 1)
                tipo = 2; 
            if (DAO_Conexao.CadLogin(textBox1.Text, maskedTextBox1.Text, tipo)) 
                MessageBox.Show("Cadastro realizado com sucesso");
            else
                MessageBox.Show("Erro de cadastro");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
