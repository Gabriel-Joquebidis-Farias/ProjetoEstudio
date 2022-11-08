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
    public partial class cadModalidade : Form
    {
        public cadModalidade()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Modalidade mod = new Modalidade(txtDescri.Text, float.Parse(txtPreco.Text), int.Parse(ttxtQntdAl.Text), int.Parse(txtAulas.Text));
            if (mod.CadastrarModalidade())
            {
                MessageBox.Show("Cadastrado");
            }
            else
            {
                MessageBox.Show("ERRO");
            }
        }
    }
}
