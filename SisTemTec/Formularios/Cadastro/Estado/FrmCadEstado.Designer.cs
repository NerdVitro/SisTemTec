
namespace SisTemTec.Formularios.Cadastro.Estado
{
    partial class FrmCadEstado
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxbSigla = new System.Windows.Forms.TextBox();
            this.TxbNome = new System.Windows.Forms.TextBox();
            this.PnlBotoes.SuspendLayout();
            this.PnlGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlBotoes
            // 
            this.PnlBotoes.Size = new System.Drawing.Size(123, 450);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(7, 380);
            // 
            // PnlGrid
            // 
            this.PnlGrid.Controls.Add(this.label2);
            this.PnlGrid.Controls.Add(this.label1);
            this.PnlGrid.Controls.Add(this.TxbSigla);
            this.PnlGrid.Controls.Add(this.TxbNome);
            this.PnlGrid.Size = new System.Drawing.Size(677, 450);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(431, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Sigla";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(54, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nome";
            // 
            // TxbSigla
            // 
            this.TxbSigla.Location = new System.Drawing.Point(431, 87);
            this.TxbSigla.Name = "TxbSigla";
            this.TxbSigla.Size = new System.Drawing.Size(107, 23);
            this.TxbSigla.TabIndex = 7;
            // 
            // TxbNome
            // 
            this.TxbNome.Location = new System.Drawing.Point(54, 87);
            this.TxbNome.Name = "TxbNome";
            this.TxbNome.Size = new System.Drawing.Size(349, 23);
            this.TxbNome.TabIndex = 6;
            // 
            // FrmCadEstado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "FrmCadEstado";
            this.Text = "FrmCadEstado";
            this.PnlBotoes.ResumeLayout(false);
            this.PnlGrid.ResumeLayout(false);
            this.PnlGrid.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxbSigla;
        private System.Windows.Forms.TextBox TxbNome;
    }
}