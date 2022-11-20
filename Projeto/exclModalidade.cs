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
    public partial class exclModalidade : Form
    {
        public exclModalidade()
        {
            InitializeComponent();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Modalidade mod = new Modalidade(comboBox1.SelectedItem.ToString());
            if (mod.excluir())
            {
                MessageBox.Show("Excluido com sucesso ");
            }
            else
            {
                MessageBox.Show("Erro");
            }
            comboAtualiza();
        }

        private void exclModalidade_Load(object sender, EventArgs e)
        {
            comboAtualiza();
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
    }
}
