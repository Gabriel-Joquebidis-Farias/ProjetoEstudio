
namespace estudio
{
    partial class Form3
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
            this.txtSenha = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.btnCadasUser = new System.Windows.Forms.Button();
            this.lbTipo = new System.Windows.Forms.Label();
            this.lbSenha = new System.Windows.Forms.Label();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.txtSenha);
            this.groupBox1.Controls.Add(this.comboBoxTipo);
            this.groupBox1.Controls.Add(this.txtUsuario);
            this.groupBox1.Controls.Add(this.btnCadasUser);
            this.groupBox1.Controls.Add(this.lbTipo);
            this.groupBox1.Controls.Add(this.lbSenha);
            this.groupBox1.Controls.Add(this.lbUsuario);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(481, 181);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(103, 76);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(318, 22);
            this.txtSenha.TabIndex = 7;
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Items.AddRange(new object[] {
            "Admininstrador",
            "Restrito"});
            this.comboBoxTipo.Location = new System.Drawing.Point(103, 111);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(318, 24);
            this.comboBoxTipo.TabIndex = 6;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(103, 36);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(318, 22);
            this.txtUsuario.TabIndex = 4;
            this.txtUsuario.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnCadasUser
            // 
            this.btnCadasUser.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCadasUser.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCadasUser.Location = new System.Drawing.Point(118, 146);
            this.btnCadasUser.Name = "btnCadasUser";
            this.btnCadasUser.Size = new System.Drawing.Size(256, 29);
            this.btnCadasUser.TabIndex = 3;
            this.btnCadasUser.Text = "Cadastrar";
            this.btnCadasUser.UseVisualStyleBackColor = false;
            this.btnCadasUser.Click += new System.EventHandler(this.btnCadasUser_Click);
            // 
            // lbTipo
            // 
            this.lbTipo.AutoSize = true;
            this.lbTipo.Location = new System.Drawing.Point(41, 117);
            this.lbTipo.Name = "lbTipo";
            this.lbTipo.Size = new System.Drawing.Size(38, 16);
            this.lbTipo.TabIndex = 2;
            this.lbTipo.Text = "Tipo:";
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.Location = new System.Drawing.Point(38, 76);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(49, 16);
            this.lbSenha.TabIndex = 1;
            this.lbSenha.Text = "Senha:";
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Location = new System.Drawing.Point(38, 36);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(57, 16);
            this.lbUsuario.TabIndex = 0;
            this.lbUsuario.Text = "Usuário:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(504, 205);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form3";
            this.Text = "Cadastrar Usuário";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox txtSenha;
        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button btnCadasUser;
        private System.Windows.Forms.Label lbTipo;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.Label lbUsuario;
    }
}