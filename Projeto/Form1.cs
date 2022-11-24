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
            if (Application.OpenForms.OfType<Form3>().Count() == 0)
            {
                Form3 cad_login = new Form3();
                cad_login.MdiParent = this;
                cad_login.Show();
            }
        }

        private void cadastrarAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Form2>().Count() == 0)
            {
                Form2 cadAluno = new Form2();
                cadAluno.MdiParent = this;
                cadAluno.Show();
            }
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
            if (Application.OpenForms.OfType<cadModalidade>().Count() == 0)
            {
                cadModalidade cad = new cadModalidade();
                cad.MdiParent = this;
                cad.Show();
            }

        }

        private void excluirModalidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<exclModalidade>().Count() == 0)
            {
                exclModalidade excl = new exclModalidade();
                excl.MdiParent = this;
                excl.Show();
            }
        }

        private void consultarModadlidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<ConsultarModalidade>().Count() == 0)
            {
                ConsultarModalidade consulta = new ConsultarModalidade();
                consulta.MdiParent = this;
                consulta.Show();
            }
        }

        private void atualizarModalidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<AtualizarModalidade>().Count() == 0)
            {
                AtualizarModalidade atualizar = new AtualizarModalidade();
                atualizar.MdiParent = this;
                atualizar.Show();
            }
        }

        private void cadastrarTurmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<cadastrarTurmas>().Count() == 0)
            {
                cadastrarTurmas cadTur = new cadastrarTurmas();
                cadTur.MdiParent = this;
                cadTur.Show();
            }
        }

        private void excluirTurmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<excluirTurma>().Count() == 0)
            {
                excluirTurma exc = new excluirTurma();
                exc.MdiParent= this;
                exc.Show();
            }

        }
    }
}
