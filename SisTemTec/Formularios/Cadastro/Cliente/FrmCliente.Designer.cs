﻿
namespace SisTemTec.Formularios.Cadastro.Cliente
{
    partial class FrmCliente
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
            this.PnlBotoes.SuspendLayout();
            this.PnlFiltros.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlBotoes
            // 
            this.PnlBotoes.Size = new System.Drawing.Size(122, 450);
            // 
            // PnlFiltros
            // 
            this.PnlFiltros.Controls.Add(this.label1);
            this.PnlFiltros.Controls.Add(this.TxbNome);
            this.PnlFiltros.Size = new System.Drawing.Size(678, 117);
            this.PnlFiltros.Controls.SetChildIndex(this.panel1, 0);
            this.PnlFiltros.Controls.SetChildIndex(this.TxbNome, 0);
            this.PnlFiltros.Controls.SetChildIndex(this.label1, 0);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(521, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(36, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome";
            // 
            // TxbNome
            // 
            this.TxbNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxbNome.Location = new System.Drawing.Point(36, 47);
            this.TxbNome.Name = "TxbNome";
            this.TxbNome.Size = new System.Drawing.Size(463, 29);
            this.TxbNome.TabIndex = 5;
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "FrmCliente";
            this.Text = "FrmCliente";
            this.PnlBotoes.ResumeLayout(false);
            this.PnlFiltros.ResumeLayout(false);
            this.PnlFiltros.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxbNome;
    }
}