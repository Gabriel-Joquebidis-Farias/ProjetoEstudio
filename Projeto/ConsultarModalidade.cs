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
            MySqlCommand descri = new MySqlCommand("Select * from Modalidade where descricao ='" + comboBox1.Text + "'", DAO_Conexao.con);
            MySqlDataReader insere = descri.ExecuteReader();
            insere.Read();

            txtPreco.Text = insere.GetString("preco").ToString();
            txtQntdAl.Text = insere.GetString("Alunos").ToString();
            txtAula.Text = insere.GetString("Aula").ToString();

            insere.Close();
            DAO_Conexao.con.Close();
        }

        private void ConsultarModalidade_Load(object sender, EventArgs e)
        {
            DAO_Conexao.con.Open();
            MySqlCommand selectDesc = new MySqlCommand("Select Modalidade from Estudio_Modalidade where ativa=1", DAO_Conexao.con);
            MySqlDataReader res = selectDesc.ExecuteReader();

            comboBox1.Items.Clear();
            while (res.Read())
            {
                comboBox1.Items.Add(res.GetString("descricao"));
                comboBox1.Text = res[0].ToString();
            }

            res.Close();
            DAO_Conexao.con.Close();
        }
    }
}
