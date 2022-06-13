
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
            this.BtnCadastros = new System.Windows.Forms.Button();
            this.BtnEstoque = new System.Windows.Forms.Button();
            this.BtnOrdemVenda = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.TmrClock = new System.Windows.Forms.Timer(this.components);
            this.LblClock = new System.Windows.Forms.Label();
            this.PnlCadastros = new System.Windows.Forms.Panel();
            this.BtnCadastroEquipamentos = new System.Windows.Forms.Button();
            this.BtnCadastroFornecedor = new System.Windows.Forms.Button();
            this.BtnCadastroCliente = new System.Windows.Forms.Button();
            this.BtnCadastroTecnico = new System.Windows.Forms.Button();
            this.BtnCadastroEndereco = new System.Windows.Forms.Button();
            this.BtnCadastroBairro = new System.Windows.Forms.Button();
            this.BtnCadastroCidade = new System.Windows.Forms.Button();
            this.BtnCdastrarEstado = new System.Windows.Forms.Button();
            this.PnlEquipamentos = new System.Windows.Forms.Panel();
            this.BtnCadastroEquipamento = new System.Windows.Forms.Button();
            this.BtnCadastroProduto = new System.Windows.Forms.Button();
            this.BtnCadastroTipoEquipamento = new System.Windows.Forms.Button();
            this.BtnCadastroTipoProduto = new System.Windows.Forms.Button();
            this.PnlMenu.SuspendLayout();
            this.PnlCadastros.SuspendLayout();
            this.PnlEquipamentos.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlMenu
            // 
            this.PnlMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PnlMenu.BackColor = System.Drawing.Color.White;
            this.PnlMenu.Controls.Add(this.BtnCadastros);
            this.PnlMenu.Controls.Add(this.BtnEstoque);
            this.PnlMenu.Controls.Add(this.BtnOrdemVenda);
            this.PnlMenu.Location = new System.Drawing.Point(0, 0);
            this.PnlMenu.Name = "PnlMenu";
            this.PnlMenu.Size = new System.Drawing.Size(200, 681);
            this.PnlMenu.TabIndex = 0;
            // 
            // BtnCadastros
            // 
            this.BtnCadastros.BackColor = System.Drawing.Color.Silver;
            this.BtnCadastros.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnCadastros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCadastros.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCadastros.Location = new System.Drawing.Point(0, 614);
            this.BtnCadastros.Name = "BtnCadastros";
            this.BtnCadastros.Size = new System.Drawing.Size(200, 67);
            this.BtnCadastros.TabIndex = 3;
            this.BtnCadastros.Text = "Cadastros";
            this.BtnCadastros.UseVisualStyleBackColor = false;
            this.BtnCadastros.Click += new System.EventHandler(this.BtnCadastros_Click);
            // 
            // BtnEstoque
            // 
            this.BtnEstoque.BackColor = System.Drawing.Color.Silver;
            this.BtnEstoque.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEstoque.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnEstoque.Location = new System.Drawing.Point(0, 67);
            this.BtnEstoque.Name = "BtnEstoque";
            this.BtnEstoque.Size = new System.Drawing.Size(200, 67);
            this.BtnEstoque.TabIndex = 2;
            this.BtnEstoque.Text = "Estoque";
            this.BtnEstoque.UseVisualStyleBackColor = false;
            // 
            // BtnOrdemVenda
            // 
            this.BtnOrdemVenda.BackColor = System.Drawing.Color.Silver;
            this.BtnOrdemVenda.Dock = System.Windows.Forms.DockStyle.Top;
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
            // 
            // LblClock
            // 
            this.LblClock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblClock.AutoSize = true;
            this.LblClock.Font = new System.Drawing.Font("Arial Narrow", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblClock.Location = new System.Drawing.Point(850, 67);
            this.LblClock.Name = "LblClock";
            this.LblClock.Size = new System.Drawing.Size(363, 110);
            this.LblClock.TabIndex = 1;
            this.LblClock.Text = "";
            // 
            // PnlCadastros
            // 
            this.PnlCadastros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PnlCadastros.BackColor = System.Drawing.Color.White;
            this.PnlCadastros.Controls.Add(this.BtnCadastroEquipamentos);
            this.PnlCadastros.Controls.Add(this.BtnCadastroFornecedor);
            this.PnlCadastros.Controls.Add(this.BtnCadastroCliente);
            this.PnlCadastros.Controls.Add(this.BtnCadastroTecnico);
            this.PnlCadastros.Controls.Add(this.BtnCadastroEndereco);
            this.PnlCadastros.Controls.Add(this.BtnCadastroBairro);
            this.PnlCadastros.Controls.Add(this.BtnCadastroCidade);
            this.PnlCadastros.Controls.Add(this.BtnCdastrarEstado);
            this.PnlCadastros.Location = new System.Drawing.Point(200, 141);
            this.PnlCadastros.Name = "PnlCadastros";
            this.PnlCadastros.Size = new System.Drawing.Size(200, 541);
            this.PnlCadastros.TabIndex = 2;
            // 
            // BtnCadastroEquipamentos
            // 
            this.BtnCadastroEquipamentos.BackColor = System.Drawing.Color.Silver;
            this.BtnCadastroEquipamentos.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCadastroEquipamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCadastroEquipamentos.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCadastroEquipamentos.Location = new System.Drawing.Point(0, 469);
            this.BtnCadastroEquipamentos.Name = "BtnCadastroEquipamentos";
            this.BtnCadastroEquipamentos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnCadastroEquipamentos.Size = new System.Drawing.Size(200, 67);
            this.BtnCadastroEquipamentos.TabIndex = 11;
            this.BtnCadastroEquipamentos.Text = "Equipamentos";
            this.BtnCadastroEquipamentos.UseVisualStyleBackColor = false;
            this.BtnCadastroEquipamentos.Click += new System.EventHandler(this.BtnCadastroEquipamentos_Click);
            // 
            // BtnCadastroFornecedor
            // 
            this.BtnCadastroFornecedor.BackColor = System.Drawing.Color.Silver;
            this.BtnCadastroFornecedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCadastroFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCadastroFornecedor.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCadastroFornecedor.Location = new System.Drawing.Point(0, 402);
            this.BtnCadastroFornecedor.Name = "BtnCadastroFornecedor";
            this.BtnCadastroFornecedor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnCadastroFornecedor.Size = new System.Drawing.Size(200, 67);
            this.BtnCadastroFornecedor.TabIndex = 10;
            this.BtnCadastroFornecedor.Text = "Fornecedor";
            this.BtnCadastroFornecedor.UseVisualStyleBackColor = false;
            // 
            // BtnCadastroCliente
            // 
            this.BtnCadastroCliente.BackColor = System.Drawing.Color.Silver;
            this.BtnCadastroCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCadastroCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCadastroCliente.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCadastroCliente.Location = new System.Drawing.Point(0, 335);
            this.BtnCadastroCliente.Name = "BtnCadastroCliente";
            this.BtnCadastroCliente.Size = new System.Drawing.Size(200, 67);
            this.BtnCadastroCliente.TabIndex = 9;
            this.BtnCadastroCliente.Text = "Cliente";
            this.BtnCadastroCliente.UseVisualStyleBackColor = false;
            this.BtnCadastroCliente.Click += new System.EventHandler(this.BtnCadastroCliente_Click);
            // 
            // BtnCadastroTecnico
            // 
            this.BtnCadastroTecnico.BackColor = System.Drawing.Color.Silver;
            this.BtnCadastroTecnico.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCadastroTecnico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCadastroTecnico.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCadastroTecnico.Location = new System.Drawing.Point(0, 268);
            this.BtnCadastroTecnico.Name = "BtnCadastroTecnico";
            this.BtnCadastroTecnico.Size = new System.Drawing.Size(200, 67);
            this.BtnCadastroTecnico.TabIndex = 8;
            this.BtnCadastroTecnico.Text = "Técnico";
            this.BtnCadastroTecnico.UseVisualStyleBackColor = false;
            // 
            // BtnCadastroEndereco
            // 
            this.BtnCadastroEndereco.BackColor = System.Drawing.Color.Silver;
            this.BtnCadastroEndereco.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCadastroEndereco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCadastroEndereco.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCadastroEndereco.Location = new System.Drawing.Point(0, 201);
            this.BtnCadastroEndereco.Name = "BtnCadastroEndereco";
            this.BtnCadastroEndereco.Size = new System.Drawing.Size(200, 67);
            this.BtnCadastroEndereco.TabIndex = 7;
            this.BtnCadastroEndereco.Text = "Endereço";
            this.BtnCadastroEndereco.UseVisualStyleBackColor = false;
            // 
            // BtnCadastroBairro
            // 
            this.BtnCadastroBairro.BackColor = System.Drawing.Color.Silver;
            this.BtnCadastroBairro.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCadastroBairro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCadastroBairro.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCadastroBairro.Location = new System.Drawing.Point(0, 134);
            this.BtnCadastroBairro.Name = "BtnCadastroBairro";
            this.BtnCadastroBairro.Size = new System.Drawing.Size(200, 67);
            this.BtnCadastroBairro.TabIndex = 6;
            this.BtnCadastroBairro.Text = "Bairro";
            this.BtnCadastroBairro.UseVisualStyleBackColor = false;
            // 
            // BtnCadastroCidade
            // 
            this.BtnCadastroCidade.BackColor = System.Drawing.Color.Silver;
            this.BtnCadastroCidade.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCadastroCidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCadastroCidade.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCadastroCidade.Location = new System.Drawing.Point(0, 67);
            this.BtnCadastroCidade.Name = "BtnCadastroCidade";
            this.BtnCadastroCidade.Size = new System.Drawing.Size(200, 67);
            this.BtnCadastroCidade.TabIndex = 5;
            this.BtnCadastroCidade.Text = "Cidade";
            this.BtnCadastroCidade.UseVisualStyleBackColor = false;
            this.BtnCadastroCidade.Click += new System.EventHandler(this.BtnCadastroCidade_Click);
            // 
            // BtnCdastrarEstado
            // 
            this.BtnCdastrarEstado.BackColor = System.Drawing.Color.Silver;
            this.BtnCdastrarEstado.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCdastrarEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCdastrarEstado.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCdastrarEstado.Location = new System.Drawing.Point(0, 0);
            this.BtnCdastrarEstado.Name = "BtnCdastrarEstado";
            this.BtnCdastrarEstado.Size = new System.Drawing.Size(200, 67);
            this.BtnCdastrarEstado.TabIndex = 4;
            this.BtnCdastrarEstado.Text = "Estado";
            this.BtnCdastrarEstado.UseVisualStyleBackColor = false;
            this.BtnCdastrarEstado.Click += new System.EventHandler(this.BtnCdastrarEstado_Click);
            // 
            // PnlEquipamentos
            // 
            this.PnlEquipamentos.BackColor = System.Drawing.Color.White;
            this.PnlEquipamentos.Controls.Add(this.BtnCadastroEquipamento);
            this.PnlEquipamentos.Controls.Add(this.BtnCadastroProduto);
            this.PnlEquipamentos.Controls.Add(this.BtnCadastroTipoEquipamento);
            this.PnlEquipamentos.Controls.Add(this.BtnCadastroTipoProduto);
            this.PnlEquipamentos.Location = new System.Drawing.Point(400, 408);
            this.PnlEquipamentos.Name = "PnlEquipamentos";
            this.PnlEquipamentos.Size = new System.Drawing.Size(200, 274);
            this.PnlEquipamentos.TabIndex = 3;
            // 
            // BtnCadastroEquipamento
            // 
            this.BtnCadastroEquipamento.BackColor = System.Drawing.Color.Silver;
            this.BtnCadastroEquipamento.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCadastroEquipamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCadastroEquipamento.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCadastroEquipamento.Location = new System.Drawing.Point(0, 201);
            this.BtnCadastroEquipamento.Name = "BtnCadastroEquipamento";
            this.BtnCadastroEquipamento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnCadastroEquipamento.Size = new System.Drawing.Size(200, 67);
            this.BtnCadastroEquipamento.TabIndex = 18;
            this.BtnCadastroEquipamento.Text = "Equipamento";
            this.BtnCadastroEquipamento.UseVisualStyleBackColor = false;
            // 
            // BtnCadastroProduto
            // 
            this.BtnCadastroProduto.BackColor = System.Drawing.Color.Silver;
            this.BtnCadastroProduto.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCadastroProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCadastroProduto.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCadastroProduto.Location = new System.Drawing.Point(0, 134);
            this.BtnCadastroProduto.Name = "BtnCadastroProduto";
            this.BtnCadastroProduto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnCadastroProduto.Size = new System.Drawing.Size(200, 67);
            this.BtnCadastroProduto.TabIndex = 17;
            this.BtnCadastroProduto.Text = "Produto";
            this.BtnCadastroProduto.UseVisualStyleBackColor = false;
            // 
            // BtnCadastroTipoEquipamento
            // 
            this.BtnCadastroTipoEquipamento.BackColor = System.Drawing.Color.Silver;
            this.BtnCadastroTipoEquipamento.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCadastroTipoEquipamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCadastroTipoEquipamento.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCadastroTipoEquipamento.Location = new System.Drawing.Point(0, 67);
            this.BtnCadastroTipoEquipamento.Name = "BtnCadastroTipoEquipamento";
            this.BtnCadastroTipoEquipamento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnCadastroTipoEquipamento.Size = new System.Drawing.Size(200, 67);
            this.BtnCadastroTipoEquipamento.TabIndex = 16;
            this.BtnCadastroTipoEquipamento.Text = "Tipo Equipamento";
            this.BtnCadastroTipoEquipamento.UseVisualStyleBackColor = false;
            // 
            // BtnCadastroTipoProduto
            // 
            this.BtnCadastroTipoProduto.BackColor = System.Drawing.Color.Silver;
            this.BtnCadastroTipoProduto.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCadastroTipoProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCadastroTipoProduto.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCadastroTipoProduto.Location = new System.Drawing.Point(0, 0);
            this.BtnCadastroTipoProduto.Name = "BtnCadastroTipoProduto";
            this.BtnCadastroTipoProduto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnCadastroTipoProduto.Size = new System.Drawing.Size(200, 67);
            this.BtnCadastroTipoProduto.TabIndex = 12;
            this.BtnCadastroTipoProduto.Text = "Tipo Produto";
            this.BtnCadastroTipoProduto.UseVisualStyleBackColor = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.PnlEquipamentos);
            this.Controls.Add(this.PnlCadastros);
            this.Controls.Add(this.LblClock);
            this.Controls.Add(this.PnlMenu);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "FrmPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SisTemTec";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.PnlMenu.ResumeLayout(false);
            this.PnlCadastros.ResumeLayout(false);
            this.PnlEquipamentos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlMenu;
        private System.Windows.Forms.Button BtnOrdemVenda;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer TmrClock;
        private System.Windows.Forms.Label LblClock;
        private System.Windows.Forms.Button BtnEstoque;
        private System.Windows.Forms.Button BtnCadastros;
        private System.Windows.Forms.Panel PnlCadastros;
        private System.Windows.Forms.Button BtnCadastroCidade;
        private System.Windows.Forms.Button BtnCdastrarEstado;
        private System.Windows.Forms.Button BtnCadastroEndereco;
        private System.Windows.Forms.Button BtnCadastroBairro;
        private System.Windows.Forms.Button BtnCadastroFornecedor;
        private System.Windows.Forms.Button BtnCadastroCliente;
        private System.Windows.Forms.Button BtnCadastroTecnico;
        private System.Windows.Forms.Button BtnCadastroEquipamentos;
        private System.Windows.Forms.Panel PnlEquipamentos;
        private System.Windows.Forms.Button BtnCadastroTipoProduto;
        private System.Windows.Forms.Button BtnCadastroEquipamento;
        private System.Windows.Forms.Button BtnCadastroProduto;
        private System.Windows.Forms.Button BtnCadastroTipoEquipamento;
    }
}

