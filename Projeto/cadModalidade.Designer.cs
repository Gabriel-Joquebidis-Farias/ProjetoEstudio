
namespace estudio
{
    partial class cadModalidade
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
            this.lbAulas = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.ttxtQntdAl = new System.Windows.Forms.TextBox();
            this.txtAulas = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.txtAulas);
            this.groupBox1.Controls.Add(this.ttxtQntdAl);
            this.groupBox1.Controls.Add(this.txtPreco);
            this.groupBox1.Controls.Add(this.txtDesc);
            this.groupBox1.Controls.Add(this.btnCadastrar);
            this.groupBox1.Controls.Add(this.lbAulas);
            this.groupBox1.Controls.Add(this.lbQntdAl);
            this.groupBox1.Controls.Add(this.lbPreco);
            this.groupBox1.Controls.Add(this.lbDesc);
            this.groupBox1.Location = new System.Drawing.Point(26, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 296);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastrar Modalidade";
            // 
            // lbDesc
            // 
            this.lbDesc.AutoSize = true;
            this.lbDesc.Location = new System.Drawing.Point(35, 79);
            this.lbDesc.Name = "lbDesc";
            this.lbDesc.Size = new System.Drawing.Size(58, 13);
            this.lbDesc.TabIndex = 0;
            this.lbDesc.Text = "Descriçao:";
            // 
            // lbPreco
            // 
            this.lbPreco.AutoSize = true;
            this.lbPreco.Location = new System.Drawing.Point(35, 118);
            this.lbPreco.Name = "lbPreco";
            this.lbPreco.Size = new System.Drawing.Size(38, 13);
            this.lbPreco.TabIndex = 1;
            this.lbPreco.Text = "Preço:";
            // 
            // lbQntdAl
            // 
            this.lbQntdAl.AutoSize = true;
            this.lbQntdAl.Location = new System.Drawing.Point(35, 159);
            this.lbQntdAl.Name = "lbQntdAl";
            this.lbQntdAl.Size = new System.Drawing.Size(83, 13);
            this.lbQntdAl.TabIndex = 2;
            this.lbQntdAl.Text = "Qntd de Alunos:";
            // 
            // lbAulas
            // 
            this.lbAulas.AutoSize = true;
            this.lbAulas.Location = new System.Drawing.Point(35, 202);
            this.lbAulas.Name = "lbAulas";
            this.lbAulas.Size = new System.Drawing.Size(77, 13);
            this.lbAulas.TabIndex = 3;
            this.lbAulas.Text = "Qntd de Aulas:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCadastrar.Location = new System.Drawing.Point(38, 242);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(388, 29);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(102, 79);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(324, 20);
            this.txtDesc.TabIndex = 5;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(102, 118);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(324, 20);
            this.txtPreco.TabIndex = 6;
            // 
            // ttxtQntdAl
            // 
            this.ttxtQntdAl.Location = new System.Drawing.Point(124, 152);
            this.ttxtQntdAl.Name = "ttxtQntdAl";
            this.ttxtQntdAl.Size = new System.Drawing.Size(302, 20);
            this.ttxtQntdAl.TabIndex = 7;
            // 
            // txtAulas
            // 
            this.txtAulas.Location = new System.Drawing.Point(124, 195);
            this.txtAulas.Name = "txtAulas";
            this.txtAulas.Size = new System.Drawing.Size(302, 20);
            this.txtAulas.TabIndex = 8;
            // 
            // cadModalidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 343);
            this.Controls.Add(this.groupBox1);
            this.Name = "cadModalidade";
            this.Text = "cadModalidade";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbAulas;
        private System.Windows.Forms.Label lbQntdAl;
        private System.Windows.Forms.Label lbPreco;
        private System.Windows.Forms.Label lbDesc;
        private System.Windows.Forms.TextBox txtAulas;
        private System.Windows.Forms.TextBox ttxtQntdAl;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Button btnCadastrar;
    }
}