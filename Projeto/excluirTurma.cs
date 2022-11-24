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
    public partial class excluirTurma : Form
    {
        public excluirTurma()
        {
            InitializeComponent();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int m = 0;
            Modalidade mod = new Modalidade(comboBoxModal.Text);
            MySqlDataReader re= mod.consultarModalidade();
            if (re.Read())
            {
                m = Convert.ToInt32(re["idModalidade"]);
            }
            DAO_Conexao.con.Close();

            String dia = comboBoxDias.Text;
            String hora = comboBoxHora.Text;
            Turma tur = new Turma(m,dia,hora);
            if (tur.excluirTurma())
            {
                MessageBox.Show("Sucesso");
                comboBoxModal.Items.Clear();
                comboBoxDias.Items.Clear();
                comboBoxHora.Items.Clear();

                comboBoxModal.Refresh();
                comboBoxDias.Refresh();
                comboBoxHora.Refresh();
            }
            else
            {
                MessageBox.Show("Erro");
            }
            

            Modalidade mod1 = new Modalidade();
            MySqlDataReader resultado = mod1.consultarTodasModalidades();
            while (resultado.Read())
            {
                comboBoxModal.Items.Add(resultado["descricao"].ToString());
            }
            DAO_Conexao.con.Close();
        }

        private void excluirTurma_Load(object sender, EventArgs e)
        {
            Modalidade mod = new Modalidade();
            MySqlDataReader r = mod.consultarTodasModalidades();
            while (r.Read())
            {
                comboBoxModal.Items.Add(r["descricao"].ToString());
            }
            DAO_Conexao.con.Close();
        }

        private void comboBoxModal_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxDias.Items.Clear();
            int mod=0;
            Modalidade modali = new Modalidade(comboBoxModal.Text);
            MySqlDataReader resultado = modali.consultarModalidade();
            if (resultado.Read())
            {
                mod = Convert.ToInt32(resultado["idModalidade"]);
            }
            DAO_Conexao.con.Close();
            Turma tur = new Turma(mod);
            MySqlDataReader r = tur.consultaTurma();
            if (r.Read())
            {
                comboBoxDias.Items.Add(r["diasemanaTurma"].ToString());
            }
            DAO_Conexao.con.Close();

            comboBoxDias.Refresh();
        }

        private void comboBoxDias_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxHora.Items.Clear();
            String diaS;
            int Modalida = 0;
            Modalidade mod = new Modalidade(comboBoxModal.Text);
            MySqlDataReader resultado = mod.consultarModalidade();
            if (resultado.Read())
            {
                Modalida = Convert.ToInt32(resultado["idModalidade"]);
            }
            DAO_Conexao.con.Close();
            diaS = comboBoxDias.Text;

            Turma tur1 = new Turma(diaS, Modalida);
            MySqlDataReader resul = tur1.consultaTurmaDia();
            while (resul.Read())
            {
                comboBoxHora.Items.Add(resul["horaTurma"].ToString());
            }DAO_Conexao.con.Close();
        }
    }
}
