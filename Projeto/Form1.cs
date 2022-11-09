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
    public partial class estudio : Form
    {
        public estudio()
        {
            InitializeComponent();

            if (DAO_Conexao.getConexao("143.106.241.3", "cl201271", "cl201271", "cl*01022006"))
                Console.WriteLine("Conectado");
            else
                Console.WriteLine("Erro de Conexão");
        }

        private void Estúdio_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tipo = DAO_Conexao.login(txtLogin.Text, txtSenha.Text);
            if (tipo == 0)
                MessageBox.Show("Usuário/Senha inválidos");
            if (tipo == 1)
            {
                MessageBox.Show("Usuário ADM");
                groupBox1.Visible = false;
                menuStrip1.Enabled = true;
            }
            if (tipo == 2)
            {
                MessageBox.Show("Usuário Restrito");
                groupBox1.Visible = false;
                menuStrip1.Enabled = true;
                cadastrarLoginToolStripMenuItem.Enabled = false; //única opção que o user restrito não terá acesso
            }
        }

        private void cadastrarLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 cad_login = new Form3();
            cad_login.MdiParent = this;
            cad_login.Show();
        }

        private void cadastrarAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 cadAluno = new Form2();
            cadAluno.MdiParent = this;
            cadAluno.Show();
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void excluirAlunoiToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void modalidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarModalidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadModalidade cad = new cadModalidade();
            cad.MdiParent = this;
            cad.Show();
        }

        private void excluirModalidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exclModalidade excl = new exclModalidade();
            excl.MdiParent = this;
            excl.Show();
        }

        private void consultarModadlidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarModalidade consulta = new ConsultarModalidade();
            consulta.MdiParent = this;
            consulta.Show();
        }

        private void atualizarModalidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
