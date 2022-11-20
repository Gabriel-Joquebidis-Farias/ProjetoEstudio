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
        public AtualizarModalidade()
        {
            InitializeComponent();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Modalidade mod = new Modalidade(comboBox1.SelectedItem.ToString(), Convert.ToDouble(txtPreco.Text), Convert.ToInt32(txtAlunos.Text), Convert.ToInt32(txtAulas.Text));
            if (mod.atualizar())
            {
                MessageBox.Show("Modalidade atualizada");
            }
            else
            {
                MessageBox.Show("Erro");
            }
        }
        public void comboAtualiza()
        {
            DAO_Conexao.con.Open();
            MySqlCommand insere = new MySqlCommand("Select descricao from Modalidade where Ativo=0", DAO_Conexao.con);
            MySqlDataReader m = insere.ExecuteReader();
            comboBox1.Items.Clear();
            while (m.Read())
            {
                comboBox1.Items.Add(m.GetString("descricao"));
                comboBox1.Text = m[0].ToString();
            }
            m.Close();
            DAO_Conexao.con.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void AtualizarModalidade_Load(object sender, EventArgs e)
        {
            comboAtualiza();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand insere = new MySqlCommand("select * from Modalidade where descricao like '" + comboBox1.Text + "'", DAO_Conexao.con);
                MySqlDataReader m = insere.ExecuteReader();
                m.Read();
                txtAlunos.Text = m.GetString("Alunos").ToString();
                txtAulas.Text = m.GetString("Aula").ToString();
                txtPreco.Text = m.GetString("preco").ToString();
            }
            catch(MySqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
        }
    }
}
