
namespace estudio
{
    partial class cadastrarTurmas
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
            this.lbModalidade = new System.Windows.Forms.Label();
            this.lbProf = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbHora = new System.Windows.Forms.Label();
            this.txtmod = new System.Windows.Forms.TextBox();
            this.txtProf = new System.Windows.Forms.TextBox();
            this.txtDia = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Modalidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.btnCadastrar);
            this.groupBox1.Controls.Add(this.txtDia);
            this.groupBox1.Controls.Add(this.txtProf);
            this.groupBox1.Controls.Add(this.txtmod);
            this.groupBox1.Controls.Add(this.lbHora);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbProf);
            this.groupBox1.Controls.Add(this.lbModalidade);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.Color.MediumBlue;
            this.groupBox1.Location = new System.Drawing.Point(27, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(540, 456);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Turma";
            // 
            // lbModalidade
            // 
            this.lbModalidade.AutoSize = true;
            this.lbModalidade.Location = new System.Drawing.Point(51, 57);
            this.lbModalidade.Name = "lbModalidade";
            this.lbModalidade.Size = new System.Drawing.Size(65, 13);
            this.lbModalidade.TabIndex = 0;
            this.lbModalidade.Text = "Modalidade:";
            // 
            // lbProf
            // 
            this.lbProf.AutoSize = true;
            this.lbProf.Location = new System.Drawing.Point(62, 89);
            this.lbProf.Name = "lbProf";
            this.lbProf.Size = new System.Drawing.Size(54, 13);
            this.lbProf.TabIndex = 1;
            this.lbProf.Text = "Professor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dia da Semana:";
            // 
            // lbHora
            // 
            this.lbHora.AutoSize = true;
            this.lbHora.Location = new System.Drawing.Point(83, 167);
            this.lbHora.Name = "lbHora";
            this.lbHora.Size = new System.Drawing.Size(33, 13);
            this.lbHora.TabIndex = 3;
            this.lbHora.Text = "Hora:";
            // 
            // txtmod
            // 
            this.txtmod.Location = new System.Drawing.Point(140, 50);
            this.txtmod.Name = "txtmod";
            this.txtmod.Size = new System.Drawing.Size(379, 20);
            this.txtmod.TabIndex = 4;
            // 
            // txtProf
            // 
            this.txtProf.Location = new System.Drawing.Point(140, 86);
            this.txtProf.Name = "txtProf";
            this.txtProf.Size = new System.Drawing.Size(361, 20);
            this.txtProf.TabIndex = 5;
            // 
            // txtDia
            // 
            this.txtDia.Location = new System.Drawing.Point(140, 122);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(326, 20);
            this.txtDia.TabIndex = 6;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(36, 217);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(483, 26);
            this.btnCadastrar.TabIndex = 8;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Modalidade});
            this.dataGridView1.Location = new System.Drawing.Point(55, 261);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(446, 176);
            this.dataGridView1.TabIndex = 9;
            // 
            // Modalidade
            // 
            this.Modalidade.HeaderText = "Modalidade";
            this.Modalidade.Name = "Modalidade";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(140, 160);
            this.maskedTextBox1.Mask = "00:00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(121, 20);
            this.maskedTextBox1.TabIndex = 10;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // cadastrarTurmas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 507);
            this.Controls.Add(this.groupBox1);
            this.Name = "cadastrarTurmas";
            this.Text = "cadastrarTurmas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtDia;
        private System.Windows.Forms.TextBox txtProf;
        private System.Windows.Forms.TextBox txtmod;
        private System.Windows.Forms.Label lbHora;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbProf;
        private System.Windows.Forms.Label lbModalidade;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modalidade;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}