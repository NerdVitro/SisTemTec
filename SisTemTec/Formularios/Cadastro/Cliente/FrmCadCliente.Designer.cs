
namespace SisTemTec.Formularios.Cadastro.Cliente
{
    partial class FrmCadCliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxbNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxbNomeRazao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MskCpfCnpj = new System.Windows.Forms.MaskedTextBox();
            this.MskTxbNumero = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxbEmail = new System.Windows.Forms.TextBox();
            this.CkbJuridica = new System.Windows.Forms.CheckBox();
            this.CkbFisica = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxbEndereco = new System.Windows.Forms.TextBox();
            this.BtnLimparEstado = new System.Windows.Forms.Button();
            this.BtnConsultaEstado = new System.Windows.Forms.Button();
            this.PnlBotoes.SuspendLayout();
            this.PnlGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlGrid
            // 
            this.PnlGrid.Controls.Add(this.BtnLimparEstado);
            this.PnlGrid.Controls.Add(this.BtnConsultaEstado);
            this.PnlGrid.Controls.Add(this.label6);
            this.PnlGrid.Controls.Add(this.TxbEndereco);
            this.PnlGrid.Controls.Add(this.CkbFisica);
            this.PnlGrid.Controls.Add(this.CkbJuridica);
            this.PnlGrid.Controls.Add(this.label5);
            this.PnlGrid.Controls.Add(this.TxbEmail);
            this.PnlGrid.Controls.Add(this.MskTxbNumero);
            this.PnlGrid.Controls.Add(this.label4);
            this.PnlGrid.Controls.Add(this.MskCpfCnpj);
            this.PnlGrid.Controls.Add(this.label3);
            this.PnlGrid.Controls.Add(this.label2);
            this.PnlGrid.Controls.Add(this.TxbNomeRazao);
            this.PnlGrid.Controls.Add(this.label1);
            this.PnlGrid.Controls.Add(this.TxbNome);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nome";
            // 
            // TxbNome
            // 
            this.TxbNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxbNome.Location = new System.Drawing.Point(21, 40);
            this.TxbNome.Name = "TxbNome";
            this.TxbNome.Size = new System.Drawing.Size(619, 29);
            this.TxbNome.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(23, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nome Razão";
            // 
            // TxbNomeRazao
            // 
            this.TxbNomeRazao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxbNomeRazao.Location = new System.Drawing.Point(23, 193);
            this.TxbNomeRazao.Name = "TxbNomeRazao";
            this.TxbNomeRazao.Size = new System.Drawing.Size(619, 29);
            this.TxbNomeRazao.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(181, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "CPF/CNPJ";
            // 
            // MskCpfCnpj
            // 
            this.MskCpfCnpj.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MskCpfCnpj.Location = new System.Drawing.Point(186, 141);
            this.MskCpfCnpj.Mask = "000\\.000\\.000\\-00";
            this.MskCpfCnpj.Name = "MskCpfCnpj";
            this.MskCpfCnpj.Size = new System.Drawing.Size(214, 29);
            this.MskCpfCnpj.TabIndex = 2;
            // 
            // MskTxbNumero
            // 
            this.MskTxbNumero.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MskTxbNumero.Location = new System.Drawing.Point(23, 246);
            this.MskTxbNumero.Mask = "(99) 00000-0000";
            this.MskTxbNumero.Name = "MskTxbNumero";
            this.MskTxbNumero.Size = new System.Drawing.Size(214, 29);
            this.MskTxbNumero.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(22, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 21);
            this.label4.TabIndex = 14;
            this.label4.Text = "Número";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(21, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 21);
            this.label5.TabIndex = 17;
            this.label5.Text = "Email";
            // 
            // TxbEmail
            // 
            this.TxbEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxbEmail.Location = new System.Drawing.Point(21, 92);
            this.TxbEmail.Name = "TxbEmail";
            this.TxbEmail.Size = new System.Drawing.Size(619, 29);
            this.TxbEmail.TabIndex = 1;
            // 
            // CkbJuridica
            // 
            this.CkbJuridica.AutoSize = true;
            this.CkbJuridica.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CkbJuridica.Location = new System.Drawing.Point(25, 141);
            this.CkbJuridica.Name = "CkbJuridica";
            this.CkbJuridica.Size = new System.Drawing.Size(82, 25);
            this.CkbJuridica.TabIndex = 18;
            this.CkbJuridica.Text = "Jurídica";
            this.CkbJuridica.UseVisualStyleBackColor = true;
            this.CkbJuridica.CheckedChanged += new System.EventHandler(this.CkbJuridica_CheckedChanged);
            // 
            // CkbFisica
            // 
            this.CkbFisica.AutoSize = true;
            this.CkbFisica.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CkbFisica.Location = new System.Drawing.Point(113, 141);
            this.CkbFisica.Name = "CkbFisica";
            this.CkbFisica.Size = new System.Drawing.Size(67, 25);
            this.CkbFisica.TabIndex = 19;
            this.CkbFisica.Text = "Física";
            this.CkbFisica.UseVisualStyleBackColor = true;
            this.CkbFisica.CheckedChanged += new System.EventHandler(this.CkbFisica_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(23, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 21);
            this.label6.TabIndex = 21;
            this.label6.Text = "Endereço";
            // 
            // TxbEndereco
            // 
            this.TxbEndereco.Enabled = false;
            this.TxbEndereco.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxbEndereco.Location = new System.Drawing.Point(23, 298);
            this.TxbEndereco.Name = "TxbEndereco";
            this.TxbEndereco.Size = new System.Drawing.Size(485, 29);
            this.TxbEndereco.TabIndex = 20;
            // 
            // BtnLimparEstado
            // 
            this.BtnLimparEstado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnLimparEstado.Location = new System.Drawing.Point(611, 297);
            this.BtnLimparEstado.Name = "BtnLimparEstado";
            this.BtnLimparEstado.Size = new System.Drawing.Size(30, 29);
            this.BtnLimparEstado.TabIndex = 9;
            this.BtnLimparEstado.Text = "X";
            this.BtnLimparEstado.UseVisualStyleBackColor = true;
            this.BtnLimparEstado.Click += new System.EventHandler(this.BtnLimparEstado_Click);
            // 
            // BtnConsultaEstado
            // 
            this.BtnConsultaEstado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnConsultaEstado.Location = new System.Drawing.Point(514, 298);
            this.BtnConsultaEstado.Name = "BtnConsultaEstado";
            this.BtnConsultaEstado.Size = new System.Drawing.Size(91, 29);
            this.BtnConsultaEstado.TabIndex = 5;
            this.BtnConsultaEstado.Text = "Cadastrar";
            this.BtnConsultaEstado.UseVisualStyleBackColor = true;
            this.BtnConsultaEstado.Click += new System.EventHandler(this.BtnConsultaEstado_Click);
            // 
            // FrmCadCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 535);
            this.Name = "FrmCadCliente";
            this.Text = "FrmCadCliente";
            this.PnlBotoes.ResumeLayout(false);
            this.PnlGrid.ResumeLayout(false);
            this.PnlGrid.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxbNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxbNomeRazao;
        private System.Windows.Forms.MaskedTextBox MskCpfCnpj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox MskTxbNumero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox CkbFisica;
        private System.Windows.Forms.CheckBox CkbJuridica;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxbEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxbEndereco;
        private System.Windows.Forms.Button BtnLimparEstado;
        private System.Windows.Forms.Button BtnConsultaEstado;
    }
}