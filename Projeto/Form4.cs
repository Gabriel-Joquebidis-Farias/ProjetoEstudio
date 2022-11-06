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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Aluno al = new Aluno(txtCPF.Text);
            if (e.KeyChar == 13)
            {
                if (al.consultarAluno())
                {
                    if (al.excluir())
                    {
                        MessageBox.Show("Aluno excluido");
                    }
                }
            }
        }
    }
}
