
namespace SisTemTec
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PnlMenu = new System.Windows.Forms.Panel();
            this.BtnOrdemVenda = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.TmrClock = new System.Windows.Forms.Timer(this.components);
            this.LblClock = new System.Windows.Forms.Label();
            this.PnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlMenu
            // 
            this.PnlMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PnlMenu.BackColor = System.Drawing.Color.White;
            this.PnlMenu.Controls.Add(this.BtnOrdemVenda);
            this.PnlMenu.Location = new System.Drawing.Point(0, 0);
            this.PnlMenu.Name = "PnlMenu";
            this.PnlMenu.Size = new System.Drawing.Size(200, 771);
            this.PnlMenu.TabIndex = 0;
            // 
            // BtnOrdemVenda
            // 
            this.BtnOrdemVenda.BackColor = System.Drawing.Color.Silver;
            this.BtnOrdemVenda.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnOrdemVenda.FlatAppearance.BorderSize = 0;
            this.BtnOrdemVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOrdemVenda.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnOrdemVenda.Location = new System.Drawing.Point(0, 0);
            this.BtnOrdemVenda.Name = "BtnOrdemVenda";
            this.BtnOrdemVenda.Size = new System.Drawing.Size(200, 67);
            this.BtnOrdemVenda.TabIndex = 1;
            this.BtnOrdemVenda.Text = "Ordem Venda";
            this.BtnOrdemVenda.UseVisualStyleBackColor = false;
            this.BtnOrdemVenda.Click += new System.EventHandler(this.BtnOrdemVenda_Click);
            // 
            // TmrClock
            // 
            this.TmrClock.Enabled = true;
            this.TmrClock.Tick += new System.EventHandler(this.TmrClock_Tick);
            // 
            // LblClock
            // 
            this.LblClock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblClock.AutoSize = true;
            this.LblClock.Font = new System.Drawing.Font("Arial Narrow", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblClock.Location = new System.Drawing.Point(729, 67);
            this.LblClock.Name = "LblClock";
            this.LblClock.Size = new System.Drawing.Size(363, 110);
            this.LblClock.TabIndex = 1;
            this.LblClock.Text = "00:00:00";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1143, 771);
            this.Controls.Add(this.LblClock);
            this.Controls.Add(this.PnlMenu);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "FrmPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SisTemTec";
            this.PnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlMenu;
        private System.Windows.Forms.Button BtnOrdemVenda;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer TmrClock;
        private System.Windows.Forms.Label LblClock;
    }
}

