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
            WindowState = FormWindowState.Maximized;

            Modalidade cad = new Modalidade();
            MySqlDataReader r = cad.consultarModalidade();
            while (r.Read())
            {
                comboBox1.Items.Add(r["descricaoModalidade"].ToString());
            }
            DAO_Conexao.con.Close();
        
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Modalidade modalidade = new Modalidade(Convert.ToString(comboBox1.SelectedItem));
            if (modalidade.excluir())
                MessageBox.Show("Excluído com sucesso");
            else
                MessageBox.Show("Ocorreu um erro!");
        }

        private void ConsultarModalidade_Load(object sender, EventArgs e)
        {

        }
    }
}
