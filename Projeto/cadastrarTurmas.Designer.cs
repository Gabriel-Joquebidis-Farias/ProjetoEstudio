
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
            this.txtHora = new System.Windows.Forms.MaskedTextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtDia = new System.Windows.Forms.TextBox();
            this.txtProf = new System.Windows.Forms.TextBox();
            this.lbHora = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbProf = new System.Windows.Forms.Label();
            this.lbModalidade = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtMod = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.txtMod);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.txtHora);
            this.groupBox1.Controls.Add(this.btnCadastrar);
            this.groupBox1.Controls.Add(this.txtDia);
            this.groupBox1.Controls.Add(this.txtProf);
            this.groupBox1.Controls.Add(this.lbHora);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbProf);
            this.groupBox1.Controls.Add(this.lbModalidade);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.Color.MediumBlue;
            this.groupBox1.Location = new System.Drawing.Point(27, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(540, 271);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Turma";
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(140, 160);
            this.txtHora.Mask = "00:00";
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(64, 20);
            this.txtHora.TabIndex = 10;
            this.txtHora.ValidatingType = typeof(System.DateTime);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(36, 217);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(483, 26);
            this.btnCadastrar.TabIndex = 8;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtDia
            // 
            this.txtDia.Location = new System.Drawing.Point(140, 122);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(326, 20);
            this.txtDia.TabIndex = 6;
            // 
            // txtProf
            // 
            this.txtProf.Location = new System.Drawing.Point(140, 86);
            this.txtProf.Name = "txtProf";
            this.txtProf.Size = new System.Drawing.Size(361, 20);
            this.txtProf.TabIndex = 5;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dia da Semana:";
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
            // lbModalidade
            // 
            this.lbModalidade.AutoSize = true;
            this.lbModalidade.Location = new System.Drawing.Point(51, 57);
            this.lbModalidade.Name = "lbModalidade";
            this.lbModalidade.Size = new System.Drawing.Size(65, 13);
            this.lbModalidade.TabIndex = 0;
            this.lbModalidade.Text = "Modalidade:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(140, 57);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(361, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtMod
            // 
            this.txtMod.Location = new System.Drawing.Point(6, 54);
            this.txtMod.Name = "txtMod";
            this.txtMod.Size = new System.Drawing.Size(40, 20);
            this.txtMod.TabIndex = 12;
            // 
            // cadastrarTurmas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 318);
            this.Controls.Add(this.groupBox1);
            this.Name = "cadastrarTurmas";
            this.Text = "cadastrarTurmas";
            this.Load += new System.EventHandler(this.cadastrarTurmas_Load);
            this.LocationChanged += new System.EventHandler(this.cadastrarTurmas_LocationChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtDia;
        private System.Windows.Forms.TextBox txtProf;
        private System.Windows.Forms.Label lbHora;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbProf;
        private System.Windows.Forms.Label lbModalidade;
        private System.Windows.Forms.MaskedTextBox txtHora;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtMod;
    }
}