
namespace SisTemTec.Formularios.Cadastro.Cidade
{
    partial class FrmCidade
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
            this.TbxEstado = new System.Windows.Forms.TextBox();
            this.BtnConsultaEstado = new System.Windows.Forms.Button();
            this.BtnLimparEstado = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxbCidade = new System.Windows.Forms.TextBox();
            this.PnlBotoes.SuspendLayout();
            this.PnlFiltros.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlBotoes
            // 
            this.PnlBotoes.Size = new System.Drawing.Size(122, 535);
            // 
            // PnlFiltros
            // 
            this.PnlFiltros.Controls.Add(this.label2);
            this.PnlFiltros.Controls.Add(this.TxbCidade);
            this.PnlFiltros.Controls.Add(this.label1);
            this.PnlFiltros.Controls.Add(this.BtnLimparEstado);
            this.PnlFiltros.Controls.Add(this.BtnConsultaEstado);
            this.PnlFiltros.Controls.Add(this.TbxEstado);
            this.PnlFiltros.Size = new System.Drawing.Size(762, 117);
            this.PnlFiltros.Controls.SetChildIndex(this.panel1, 0);
            this.PnlFiltros.Controls.SetChildIndex(this.TbxEstado, 0);
            this.PnlFiltros.Controls.SetChildIndex(this.BtnConsultaEstado, 0);
            this.PnlFiltros.Controls.SetChildIndex(this.BtnLimparEstado, 0);
            this.PnlFiltros.Controls.SetChildIndex(this.label1, 0);
            this.PnlFiltros.Controls.SetChildIndex(this.TxbCidade, 0);
            this.PnlFiltros.Controls.SetChildIndex(this.label2, 0);
            // 
            // BtnFiltrar
            // 
            this.BtnFiltrar.Location = new System.Drawing.Point(4, 46);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(605, 0);
            // 
            // BtnSair
            // 
            this.BtnSair.Location = new System.Drawing.Point(6, 459);
            // 
            // TbxEstado
            // 
            this.TbxEstado.Enabled = false;
            this.TbxEstado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TbxEstado.Location = new System.Drawing.Point(28, 22);
            this.TbxEstado.Name = "TbxEstado";
            this.TbxEstado.Size = new System.Drawing.Size(431, 29);
            this.TbxEstado.TabIndex = 2;
            // 
            // BtnConsultaEstado
            // 
            this.BtnConsultaEstado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnConsultaEstado.Location = new System.Drawing.Point(465, 22);
            this.BtnConsultaEstado.Name = "BtnConsultaEstado";
            this.BtnConsultaEstado.Size = new System.Drawing.Size(91, 29);
            this.BtnConsultaEstado.TabIndex = 3;
            this.BtnConsultaEstado.Text = "Pesquisar";
            this.BtnConsultaEstado.UseVisualStyleBackColor = true;
            this.BtnConsultaEstado.Click += new System.EventHandler(this.BtnConsultaEstado_Click);
            // 
            // BtnLimparEstado
            // 
            this.BtnLimparEstado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnLimparEstado.Location = new System.Drawing.Point(562, 22);
            this.BtnLimparEstado.Name = "BtnLimparEstado";
            this.BtnLimparEstado.Size = new System.Drawing.Size(30, 29);
            this.BtnLimparEstado.TabIndex = 4;
            this.BtnLimparEstado.Text = "X";
            this.BtnLimparEstado.UseVisualStyleBackColor = true;
            this.BtnLimparEstado.Click += new System.EventHandler(this.BtnLimparEstado_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(28, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Estado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(28, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cidade";
            // 
            // TxbCidade
            // 
            this.TxbCidade.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxbCidade.Location = new System.Drawing.Point(28, 73);
            this.TxbCidade.Name = "TxbCidade";
            this.TxbCidade.Size = new System.Drawing.Size(431, 29);
            this.TxbCidade.TabIndex = 6;
            // 
            // FrmCidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 535);
            this.Name = "FrmCidade";
            this.Text = "FrmCidade";
            this.PnlBotoes.ResumeLayout(false);
            this.PnlFiltros.ResumeLayout(false);
            this.PnlFiltros.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnConsultaEstado;
        private System.Windows.Forms.TextBox TbxEstado;
        private System.Windows.Forms.Button BtnLimparEstado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxbCidade;
    }
}