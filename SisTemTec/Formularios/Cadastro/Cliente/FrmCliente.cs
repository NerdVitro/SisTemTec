using SisTemTec.Banco.Manter;
using SisTemTec.Core.Classes;
using SisTemTec.Formularios.Padrao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SisTemTec.Formularios.Cadastro.Cliente
{
    public partial class FrmCliente : FrmPadraoGerenciar
    {
        private DataTable DadosGrid;

        public FrmCliente()
        {
            InitializeComponent();
            LoadDados();
            SetTela();
        }

        protected override void LoadDados()
        {
            try
            {
                DadosGrid = new ManterCliente().GetCliente(TxbNome.Text);
                AjustarGrid();
            }
            catch (Exception ex)
            {
                Tratamento.Exception(ex);
            }
        }
        protected override void AjustarGrid()
        {
            try
            {
                FormatarGridView objFormatarGridView = new FormatarGridView(DgvDados);
                objFormatarGridView.AdicionaColuna(new FormatarColunas("Nome", "NMNOME", 200, DataGridViewContentAlignment.MiddleLeft, true, DataGridViewAutoSizeColumnMode.Fill));
                objFormatarGridView.AdicionaColuna(new FormatarColunas("Telefone", "NRTELEFONE", 200, DataGridViewContentAlignment.MiddleLeft, true, DataGridViewAutoSizeColumnMode.None));
                objFormatarGridView.AdicionaColuna(new FormatarColunas("Cidade", "NMCIDADE", 200, DataGridViewContentAlignment.MiddleLeft, true, DataGridViewAutoSizeColumnMode.Fill));
                objFormatarGridView.AdicionaColuna(new FormatarColunas("Bairro", "NMBAIRRO", 200, DataGridViewContentAlignment.MiddleLeft, true, DataGridViewAutoSizeColumnMode.Fill));
                objFormatarGridView.AdicionaColuna(new FormatarColunas("ID", "IDCLIENTE", false));

                objFormatarGridView.Finalizar(DadosGrid);
            }
            catch (Exception ex)
            {
                Tratamento.Exception(ex);
            }
        }
        protected override void Novo()
        {
            try
            {
                new FrmCadCliente(null).ShowDialog();
                LoadDados();
            }
            catch (Exception ex)
            {
                Tratamento.Exception(ex);
            }
        }
        protected override void Editar()
        {
            try
            {
                if (DgvDados.CurrentRow != null)
                {
                    new FrmCadCliente(new ManterCliente().GetClienteById(Convert.ToInt32(DgvDados.CurrentRow.Cells["IDCLIENTE"].Value))).ShowDialog();
                }
                LoadDados();
            }
            catch (Exception ex)
            {
                Tratamento.Exception(ex);
            }
        }
        private void SetTela()
        {
            try
            {
                TxbNome.TabIndex = 0;

                TxbNome.MaxLength = 50;
                this.Text = "Gerenciar Cadastro de Cliente";
            }
            catch (Exception ex)
            {
                Tratamento.Exception(ex);
            }
        }
    }
}
