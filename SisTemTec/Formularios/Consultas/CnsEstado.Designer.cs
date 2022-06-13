
namespace SisTemTec.Formularios.Consultas
{
    partial class CnsEstado
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
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TxbSigla);
            this.panel1.Controls.Add(this.TxbNome);
            this.panel1.Size = new System.Drawing.Size(666, 100);
            this.panel1.Controls.SetChildIndex(this.BtnFiltrar, 0);
            this.panel1.Controls.SetChildIndex(this.BtnSelecionar, 0);
            this.panel1.Controls.SetChildIndex(this.TxbNome, 0);
            this.panel1.Controls.SetChildIndex(this.TxbSigla, 0);
            this.panel1.Controls.SetChildIndex(this.label1, 0);
            this.panel1.Controls.SetChildIndex(this.label2, 0);
            // 
            // BtnFiltrar
            // 
            this.BtnFiltrar.Location = new System.Drawing.Point(516, 7);
            // 
            // BtnSelecionar
            // 
            this.BtnSelecionar.Location = new System.Drawing.Point(516, 49);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(389, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Sigla";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nome";
            // 
            // TxbSigla
            // 
            this.TxbSigla.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxbSigla.Location = new System.Drawing.Point(389, 39);
            this.TxbSigla.Name = "TxbSigla";
            this.TxbSigla.Size = new System.Drawing.Size(107, 29);
            this.TxbSigla.TabIndex = 7;
            // 
            // TxbNome
            // 
            this.TxbNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxbNome.Location = new System.Drawing.Point(12, 39);
            this.TxbNome.Name = "TxbNome";
            this.TxbNome.Size = new System.Drawing.Size(349, 29);
            this.TxbNome.TabIndex = 6;
            // 
            // CnsEstado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 450);
            this.Name = "CnsEstado";
            this.Text = "CnsEstado";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxbSigla;
        private System.Windows.Forms.TextBox TxbNome;
    }
}