
namespace estudio
{
    partial class ConsultarModalidade
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
            this.lbDesc = new System.Windows.Forms.Label();
            this.lbPreco = new System.Windows.Forms.Label();
            this.lbQntdAl = new System.Windows.Forms.Label();
            this.lbAula = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.txtAula = new System.Windows.Forms.TextBox();
            this.txtQntdAl = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.txtDesc);
            this.groupBox1.Controls.Add(this.txtPreco);
            this.groupBox1.Controls.Add(this.txtQntdAl);
            this.groupBox1.Controls.Add(this.txtAula);
            this.groupBox1.Controls.Add(this.btnAtualizar);
            this.groupBox1.Controls.Add(this.lbAula);
            this.groupBox1.Controls.Add(this.lbQntdAl);
            this.groupBox1.Controls.Add(this.lbPreco);
            this.groupBox1.Controls.Add(this.lbDesc);
            this.groupBox1.Location = new System.Drawing.Point(28, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(513, 270);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modalidade:";
            // 
            // lbDesc
            // 
            this.lbDesc.AutoSize = true;
            this.lbDesc.Location = new System.Drawing.Point(40, 65);
            this.lbDesc.Name = "lbDesc";
            this.lbDesc.Size = new System.Drawing.Size(58, 13);
            this.lbDesc.TabIndex = 0;
            this.lbDesc.Text = "Descrição:";
            // 
            // lbPreco
            // 
            this.lbPreco.AutoSize = true;
            this.lbPreco.Location = new System.Drawing.Point(40, 102);
            this.lbPreco.Name = "lbPreco";
            this.lbPreco.Size = new System.Drawing.Size(38, 13);
            this.lbPreco.TabIndex = 1;
            this.lbPreco.Text = "Preço:";
            // 
            // lbQntdAl
            // 
            this.lbQntdAl.AutoSize = true;
            this.lbQntdAl.Location = new System.Drawing.Point(40, 142);
            this.lbQntdAl.Name = "lbQntdAl";
            this.lbQntdAl.Size = new System.Drawing.Size(83, 13);
            this.lbQntdAl.TabIndex = 2;
            this.lbQntdAl.Text = "Qntd de Alunos:";
            // 
            // lbAula
            // 
            this.lbAula.AutoSize = true;
            this.lbAula.Location = new System.Drawing.Point(40, 181);
            this.lbAula.Name = "lbAula";
            this.lbAula.Size = new System.Drawing.Size(77, 13);
            this.lbAula.TabIndex = 3;
            this.lbAula.Text = "Qntd de Aulas:";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAtualizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAtualizar.Location = new System.Drawing.Point(43, 222);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(425, 23);
            this.btnAtualizar.TabIndex = 4;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            // 
            // txtAula
            // 
            this.txtAula.Location = new System.Drawing.Point(129, 181);
            this.txtAula.Name = "txtAula";
            this.txtAula.Size = new System.Drawing.Size(327, 20);
            this.txtAula.TabIndex = 5;
            // 
            // txtQntdAl
            // 
            this.txtQntdAl.Location = new System.Drawing.Point(129, 142);
            this.txtQntdAl.Name = "txtQntdAl";
            this.txtQntdAl.Size = new System.Drawing.Size(327, 20);
            this.txtQntdAl.TabIndex = 6;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(104, 99);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(352, 20);
            this.txtPreco.TabIndex = 7;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(104, 62);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(352, 20);
            this.txtDesc.TabIndex = 8;
            // 
            // ConsultarModalidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 322);
            this.Controls.Add(this.groupBox1);
            this.Name = "ConsultarModalidade";
            this.Text = "ConsultarModalidade";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtQntdAl;
        private System.Windows.Forms.TextBox txtAula;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Label lbAula;
        private System.Windows.Forms.Label lbQntdAl;
        private System.Windows.Forms.Label lbPreco;
        private System.Windows.Forms.Label lbDesc;
    }
}