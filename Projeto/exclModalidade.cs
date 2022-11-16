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
        }

        private void exclModalidade_Load(object sender, EventArgs e)
        {
            DAO_Conexao.con.Open();
            MySqlCommand selectDesc = new MySqlCommand("Select descricao from Modalidade where ativa=1", DAO_Conexao.con);
            MySqlDataReader res = selectDesc.ExecuteReader();
            comboBox1.Items.Clear();
            while (res.Read())
            {
                comboBox1.Items.Add(res.GetString("descricao"));
                comboBox1.Text = res[0].ToString();
            }
            DAO_Conexao.con.Close();
        }
    }
}
