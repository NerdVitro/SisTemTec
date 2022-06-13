
namespace SisTemTec.Formularios.Cadastro.Estado
{
    partial class FrmEstado
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
            this.TxbNome = new System.Windows.Forms.TextBox();
            this.TxbSigla = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PnlBotoes.SuspendLayout();
            this.PnlFiltros.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlFiltros
            // 
            this.PnlFiltros.Controls.Add(this.label2);
            this.PnlFiltros.Controls.Add(this.label1);
            this.PnlFiltros.Controls.Add(this.TxbSigla);
            this.PnlFiltros.Controls.Add(this.TxbNome);
            this.PnlFiltros.Controls.SetChildIndex(this.TxbNome, 0);
            this.PnlFiltros.Controls.SetChildIndex(this.panel1, 0);
            this.PnlFiltros.Controls.SetChildIndex(this.TxbSigla, 0);
            this.PnlFiltros.Controls.SetChildIndex(this.label1, 0);
            this.PnlFiltros.Controls.SetChildIndex(this.label2, 0);
            // 
            // TxbNome
            // 
            this.TxbNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxbNome.Location = new System.Drawing.Point(36, 49);
            this.TxbNome.Name = "TxbNome";
            this.TxbNome.Size = new System.Drawing.Size(349, 29);
            this.TxbNome.TabIndex = 2;
            // 
            // TxbSigla
            // 
            this.TxbSigla.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxbSigla.Location = new System.Drawing.Point(413, 47);
            this.TxbSigla.Name = "TxbSigla";
            this.TxbSigla.Size = new System.Drawing.Size(107, 29);
            this.TxbSigla.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(36, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(413, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sigla";
            // 
            // FrmEstado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 543);
            this.Name = "FrmEstado";
            this.Text = "Gerenciar Cadastro Estado";
            this.PnlBotoes.ResumeLayout(false);
            this.PnlFiltros.ResumeLayout(false);
            this.PnlFiltros.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TxbNome;
        private System.Windows.Forms.TextBox TxbSigla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}