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
    public partial class cadastrarTurmas : Form
    {
        public cadastrarTurmas()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
{
            
            int mo = Convert.ToInt32(txtMod.Text);
            String prog = txtProf.Text;
            String dia = txtDia.Text;
            String hora = txtHora.Text;

            Turma tur = new Turma(mo, prog, dia, hora);
            if (tur.cadastrarTurma())
            {
                MessageBox.Show("Cadastrado");
            }
            else
            {
                MessageBox.Show("Erro");
            }
            comboBox1.Items.Clear();
            comboBox1.Refresh();
            txtDia.Text = "";
            txtHora.Text = "";
            txtMod.Text = "";
            txtProf.Text = "";
            Modalidade mod = new Modalidade();
            MySqlDataReader r = mod.consultarTodasModalidades();
            while (r.Read())
            {
                comboBox1.Items.Add(r["descricao"].ToString());
            }
            DAO_Conexao.con.Close();
        }
    
        private void cadastrarTurmas_LocationChanged(object sender, EventArgs e)
        {

        }

        private void cadastrarTurmas_Load(object sender, EventArgs e)
        {
            Modalidade mod = new Modalidade();
            MySqlDataReader r = mod.consultarTodasModalidades();
            while (r.Read())
            {
                comboBox1.Items.Add(r["descricao"].ToString());
            }
            DAO_Conexao.con.Close();
            txtMod.Visible = false;
            txtMod.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int moda = 0;
            Modalidade mod = new Modalidade(comboBox1.Text);
            MySqlDataReader r = mod.consultarModalidade();
            if (r.Read())
            {
                moda = Convert.ToInt32(r["idModalidade"]);
            }
            DAO_Conexao.con.Close();
            txtMod.Text = moda.ToString();
        }
    }
}
