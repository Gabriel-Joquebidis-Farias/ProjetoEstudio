using MySql.Data.MySqlClient;
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
    public partial class AtualizarModalidade : Form
    {
        Modalidade modalidade = new Modalidade();
        public AtualizarModalidade()
        {
            InitializeComponent();
            MySqlDataReader resultado = modalidade.consultarTodasModalidades();
            while(resultado.Read()){
                comboBox1.Items.Add(resultado["descricao"].ToString());
            }
            DAO_Conexao.con.Close();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Modalidade mod = new Modalidade(comboBox1.Text, float.Parse(txtPreco.Text), Convert.ToInt32(txtAlunos.Text), Convert.ToInt32(txtAulas.Text));
            if (mod.atualizar())
            {
                MessageBox.Show("Modalidade atualizada");
            }
            else
            {
                MessageBox.Show("Erro");
            }
        }
        

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void AtualizarModalidade_Load(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            Modalidade mod = new Modalidade(comboBox1.Text);
            MySqlDataReader resu = mod.consultarModalidade();
            while (resu.Read())
            {
                txtAlunos.Text = resu["Alunos"].ToString();
                txtAulas.Text = resu["Aula"].ToString();
                txtPreco.Text = resu["preco"].ToString();
            }
            DAO_Conexao.con.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
