
namespace estudio
{
    partial class excluirTurma
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
            this.groupBoxExcluir = new System.Windows.Forms.GroupBox();
            this.comboBoxModal = new System.Windows.Forms.ComboBox();
            this.comboBoxDias = new System.Windows.Forms.ComboBox();
            this.comboBoxHora = new System.Windows.Forms.ComboBox();
            this.lbMod = new System.Windows.Forms.Label();
            this.lbDias = new System.Windows.Forms.Label();
            this.lbHora = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.groupBoxExcluir.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxExcluir
            // 
            this.groupBoxExcluir.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBoxExcluir.Controls.Add(this.btnExcluir);
            this.groupBoxExcluir.Controls.Add(this.lbHora);
            this.groupBoxExcluir.Controls.Add(this.lbDias);
            this.groupBoxExcluir.Controls.Add(this.lbMod);
            this.groupBoxExcluir.Controls.Add(this.comboBoxHora);
            this.groupBoxExcluir.Controls.Add(this.comboBoxDias);
            this.groupBoxExcluir.Controls.Add(this.comboBoxModal);
            this.groupBoxExcluir.Location = new System.Drawing.Point(27, 29);
            this.groupBoxExcluir.Name = "groupBoxExcluir";
            this.groupBoxExcluir.Size = new System.Drawing.Size(503, 271);
            this.groupBoxExcluir.TabIndex = 0;
            this.groupBoxExcluir.TabStop = false;
            this.groupBoxExcluir.Text = "Excluir Turma";
            // 
            // comboBoxModal
            // 
            this.comboBoxModal.FormattingEnabled = true;
            this.comboBoxModal.Location = new System.Drawing.Point(132, 55);
            this.comboBoxModal.Name = "comboBoxModal";
            this.comboBoxModal.Size = new System.Drawing.Size(328, 21);
            this.comboBoxModal.TabIndex = 0;
            // 
            // comboBoxDias
            // 
            this.comboBoxDias.FormattingEnabled = true;
            this.comboBoxDias.Location = new System.Drawing.Point(132, 99);
            this.comboBoxDias.Name = "comboBoxDias";
            this.comboBoxDias.Size = new System.Drawing.Size(328, 21);
            this.comboBoxDias.TabIndex = 1;
            // 
            // comboBoxHora
            // 
            this.comboBoxHora.FormattingEnabled = true;
            this.comboBoxHora.Location = new System.Drawing.Point(132, 143);
            this.comboBoxHora.Name = "comboBoxHora";
            this.comboBoxHora.Size = new System.Drawing.Size(328, 21);
            this.comboBoxHora.TabIndex = 2;
            // 
            // lbMod
            // 
            this.lbMod.AutoSize = true;
            this.lbMod.Location = new System.Drawing.Point(45, 58);
            this.lbMod.Name = "lbMod";
            this.lbMod.Size = new System.Drawing.Size(65, 13);
            this.lbMod.TabIndex = 3;
            this.lbMod.Text = "Modalidade:";
            // 
            // lbDias
            // 
            this.lbDias.AutoSize = true;
            this.lbDias.Location = new System.Drawing.Point(29, 102);
            this.lbDias.Name = "lbDias";
            this.lbDias.Size = new System.Drawing.Size(90, 13);
            this.lbDias.TabIndex = 4;
            this.lbDias.Text = "Dias Da Semana:";
            // 
            // lbHora
            // 
            this.lbHora.AutoSize = true;
            this.lbHora.Location = new System.Drawing.Point(77, 143);
            this.lbHora.Name = "lbHora";
            this.lbHora.Size = new System.Drawing.Size(33, 13);
            this.lbHora.TabIndex = 5;
            this.lbHora.Text = "Hora:";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(32, 201);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(428, 23);
            this.btnExcluir.TabIndex = 6;
            this.btnExcluir.Text = "Exluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // excluirTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 332);
            this.Controls.Add(this.groupBoxExcluir);
            this.Name = "excluirTurma";
            this.Text = "excluirTurma";
            this.groupBoxExcluir.ResumeLayout(false);
            this.groupBoxExcluir.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxExcluir;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label lbHora;
        private System.Windows.Forms.Label lbDias;
        private System.Windows.Forms.Label lbMod;
        private System.Windows.Forms.ComboBox comboBoxHora;
        private System.Windows.Forms.ComboBox comboBoxDias;
        private System.Windows.Forms.ComboBox comboBoxModal;
    }
}