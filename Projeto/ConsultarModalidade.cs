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
    public partial class ConsultarModalidade : Form
    {
        public ConsultarModalidade()
        {
            InitializeComponent();
        
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            DAO_Conexao.con.Open();
            MySqlCommand insere = new MySqlCommand("select * from Modalidade where descricao ='"+ comboBox1.Text +"'", DAO_Conexao.con);
            MySqlDataReader mod = insere.ExecuteReader();
            mod.Read();
            txtAula.Text = mod.GetString("Aula").ToString();
            txtPreco.Text = mod.GetString("preco").ToString();
            txtQntdAl.Text = mod.GetString("Alunos").ToString();
            mod.Close();
            DAO_Conexao.con.Close();
        }

        private void ConsultarModalidade_Load(object sender, EventArgs e)
        {
            DAO_Conexao.con.Open();
            MySqlCommand insere = new MySqlCommand("Select descricao from Modalidade where Ativo = 0", DAO_Conexao.con);
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
