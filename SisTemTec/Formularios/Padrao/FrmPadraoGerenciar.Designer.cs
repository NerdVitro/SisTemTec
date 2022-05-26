
namespace SisTemTec.Formularios.Padrao
{
    partial class FrmPadraoGerenciar
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
            this.PnlBotoes = new System.Windows.Forms.Panel();
            this.BtnSair = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.PnlGrid = new System.Windows.Forms.Panel();
            this.DgvDados = new System.Windows.Forms.DataGridView();
            this.PnlFiltros = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnFiltrar = new System.Windows.Forms.Button();
            this.PnlBotoes.SuspendLayout();
            this.PnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDados)).BeginInit();
            this.PnlFiltros.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlBotoes
            // 
            this.PnlBotoes.Controls.Add(this.BtnSair);
            this.PnlBotoes.Controls.Add(this.BtnEditar);
            this.PnlBotoes.Controls.Add(this.BtnNovo);
            this.PnlBotoes.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlBotoes.Location = new System.Drawing.Point(0, 0);
            this.PnlBotoes.Name = "PnlBotoes";
            this.PnlBotoes.Size = new System.Drawing.Size(122, 543);
            this.PnlBotoes.TabIndex = 0;
            // 
            // BtnSair
            // 
            this.BtnSair.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnSair.BackColor = System.Drawing.Color.Silver;
            this.BtnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSair.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnSair.Location = new System.Drawing.Point(6, 471);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(110, 64);
            this.BtnSair.TabIndex = 0;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = false;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.Color.Silver;
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnEditar.Location = new System.Drawing.Point(6, 82);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(108, 64);
            this.BtnEditar.TabIndex = 2;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnNovo
            // 
            this.BtnNovo.BackColor = System.Drawing.Color.Silver;
            this.BtnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNovo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnNovo.Location = new System.Drawing.Point(6, 12);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(110, 64);
            this.BtnNovo.TabIndex = 1;
            this.BtnNovo.Text = "Novo";
            this.BtnNovo.UseVisualStyleBackColor = false;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // PnlGrid
            // 
            this.PnlGrid.Controls.Add(this.DgvDados);
            this.PnlGrid.Controls.Add(this.PnlFiltros);
            this.PnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlGrid.Location = new System.Drawing.Point(122, 0);
            this.PnlGrid.Name = "PnlGrid";
            this.PnlGrid.Size = new System.Drawing.Size(776, 543);
            this.PnlGrid.TabIndex = 1;
            // 
            // DgvDados
            // 
            this.DgvDados.AllowUserToAddRows = false;
            this.DgvDados.AllowUserToDeleteRows = false;
            this.DgvDados.AllowUserToResizeColumns = false;
            this.DgvDados.AllowUserToResizeRows = false;
            this.DgvDados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvDados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvDados.Location = new System.Drawing.Point(1, 117);
            this.DgvDados.MultiSelect = false;
            this.DgvDados.Name = "DgvDados";
            this.DgvDados.ReadOnly = true;
            this.DgvDados.RowTemplate.Height = 25;
            this.DgvDados.Size = new System.Drawing.Size(775, 426);
            this.DgvDados.TabIndex = 1;
            this.DgvDados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDados_CellDoubleClick);
            this.DgvDados.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvDados_ColumnHeaderMouseClick);
            // 
            // PnlFiltros
            // 
            this.PnlFiltros.Controls.Add(this.panel1);
            this.PnlFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlFiltros.Location = new System.Drawing.Point(0, 0);
            this.PnlFiltros.Name = "PnlFiltros";
            this.PnlFiltros.Size = new System.Drawing.Size(776, 117);
            this.PnlFiltros.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnFiltrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(619, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(157, 117);
            this.panel1.TabIndex = 1;
            // 
            // BtnFiltrar
            // 
            this.BtnFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnFiltrar.BackColor = System.Drawing.Color.Silver;
            this.BtnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFiltrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnFiltrar.Location = new System.Drawing.Point(4, 75);
            this.BtnFiltrar.Name = "BtnFiltrar";
            this.BtnFiltrar.Size = new System.Drawing.Size(147, 36);
            this.BtnFiltrar.TabIndex = 0;
            this.BtnFiltrar.Text = "Filtrar";
            this.BtnFiltrar.UseVisualStyleBackColor = false;
            this.BtnFiltrar.Click += new System.EventHandler(this.BtnFiltrar_Click);
            // 
            // FrmPadraoGerenciar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 543);
            this.Controls.Add(this.PnlGrid);
            this.Controls.Add(this.PnlBotoes);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPadraoGerenciar";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPadraoGerenciar";
            this.Load += new System.EventHandler(this.FrmPadraoGerenciar_Load);
            this.PnlBotoes.ResumeLayout(false);
            this.PnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDados)).EndInit();
            this.PnlFiltros.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PnlGrid;
        protected System.Windows.Forms.Panel PnlBotoes;
        public System.Windows.Forms.Panel PnlFiltros;
        protected internal System.Windows.Forms.Button BtnNovo;
        protected internal System.Windows.Forms.Button BtnFiltrar;
        protected internal System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.Button BtnSair;
        protected internal System.Windows.Forms.Button BtnEditar;
        protected System.Windows.Forms.DataGridView DgvDados;
    }
}