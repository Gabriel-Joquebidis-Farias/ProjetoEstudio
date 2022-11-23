
namespace estudio
{
    partial class AtualizarTurma
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnatualizar = new System.Windows.Forms.Button();
            this.comboBoxDesc = new System.Windows.Forms.ComboBox();
            this.lbDesc = new System.Windows.Forms.Label();
            this.lbPreco = new System.Windows.Forms.Label();
            this.lbqntdAl = new System.Windows.Forms.Label();
            this.lbqntdAu = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtAlunos = new System.Windows.Forms.TextBox();
            this.txtAulas = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.txtAulas);
            this.groupBox1.Controls.Add(this.txtAlunos);
            this.groupBox1.Controls.Add(this.txtPreco);
            this.groupBox1.Controls.Add(this.lbqntdAu);
            this.groupBox1.Controls.Add(this.lbqntdAl);
            this.groupBox1.Controls.Add(this.lbPreco);
            this.groupBox1.Controls.Add(this.lbDesc);
            this.groupBox1.Controls.Add(this.comboBoxDesc);
            this.groupBox1.Controls.Add(this.btnatualizar);
            this.groupBox1.Location = new System.Drawing.Point(24, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 311);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modalidades";
            // 
            // btnatualizar
            // 
            this.btnatualizar.Location = new System.Drawing.Point(15, 254);
            this.btnatualizar.Name = "btnatualizar";
            this.btnatualizar.Size = new System.Drawing.Size(517, 26);
            this.btnatualizar.TabIndex = 0;
            this.btnatualizar.Text = "Atualizar";
            this.btnatualizar.UseVisualStyleBackColor = true;
            // 
            // comboBoxDesc
            // 
            this.comboBoxDesc.FormattingEnabled = true;
            this.comboBoxDesc.Location = new System.Drawing.Point(125, 56);
            this.comboBoxDesc.Name = "comboBoxDesc";
            this.comboBoxDesc.Size = new System.Drawing.Size(370, 21);
            this.comboBoxDesc.TabIndex = 1;
            // 
            // lbDesc
            // 
            this.lbDesc.AutoSize = true;
            this.lbDesc.Location = new System.Drawing.Point(55, 59);
            this.lbDesc.Name = "lbDesc";
            this.lbDesc.Size = new System.Drawing.Size(58, 13);
            this.lbDesc.TabIndex = 2;
            this.lbDesc.Text = "Descrição:";
            // 
            // lbPreco
            // 
            this.lbPreco.AutoSize = true;
            this.lbPreco.Location = new System.Drawing.Point(75, 108);
            this.lbPreco.Name = "lbPreco";
            this.lbPreco.Size = new System.Drawing.Size(38, 13);
            this.lbPreco.TabIndex = 3;
            this.lbPreco.Text = "Preço:";
            // 
            // lbqntdAl
            // 
            this.lbqntdAl.AutoSize = true;
            this.lbqntdAl.Location = new System.Drawing.Point(24, 156);
            this.lbqntdAl.Name = "lbqntdAl";
            this.lbqntdAl.Size = new System.Drawing.Size(89, 13);
            this.lbqntdAl.TabIndex = 4;
            this.lbqntdAl.Text = "Qntde de Alunos:";
            // 
            // lbqntdAu
            // 
            this.lbqntdAu.AutoSize = true;
            this.lbqntdAu.Location = new System.Drawing.Point(24, 200);
            this.lbqntdAu.Name = "lbqntdAu";
            this.lbqntdAu.Size = new System.Drawing.Size(83, 13);
            this.lbqntdAu.TabIndex = 5;
            this.lbqntdAu.Text = "Qntde de Aulas:";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(125, 105);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(370, 20);
            this.txtPreco.TabIndex = 6;
            // 
            // txtAlunos
            // 
            this.txtAlunos.Location = new System.Drawing.Point(125, 153);
            this.txtAlunos.Name = "txtAlunos";
            this.txtAlunos.Size = new System.Drawing.Size(370, 20);
            this.txtAlunos.TabIndex = 7;
            // 
            // txtAulas
            // 
            this.txtAulas.Location = new System.Drawing.Point(125, 197);
            this.txtAulas.Name = "txtAulas";
            this.txtAulas.Size = new System.Drawing.Size(370, 20);
            this.txtAulas.TabIndex = 8;
            // 
            // AtualizarTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 368);
            this.Controls.Add(this.groupBox1);
            this.Name = "AtualizarTurma";
            this.Text = "Consultar Modalidade";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnatualizar;
        private System.Windows.Forms.TextBox txtAulas;
        private System.Windows.Forms.TextBox txtAlunos;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label lbqntdAu;
        private System.Windows.Forms.Label lbqntdAl;
        private System.Windows.Forms.Label lbPreco;
        private System.Windows.Forms.Label lbDesc;
        private System.Windows.Forms.ComboBox comboBoxDesc;
    }
}