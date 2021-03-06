using SisTemTec.Banco;
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

namespace SisTemTec.Formularios.Cadastro.Estado
{
    public partial class FrmEstado : FrmPadraoGerenciar
    {
        DataTable DadosGrid;

        public FrmEstado()
        {
            InitializeComponent();
            LoadDados();
            SetTela();
        }

        protected override void LoadDados()
        {
            try
            {
                DadosGrid = new ManterEstado().GetEstados(TxbNome.Text, TxbSigla.Text);
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
                objFormatarGridView.AdicionaColuna(new FormatarColunas("Estado", "NMESTADO", 200, DataGridViewContentAlignment.MiddleLeft, true, DataGridViewAutoSizeColumnMode.Fill));
                objFormatarGridView.AdicionaColuna(new FormatarColunas("Sigla", "NMSIGLA", 200, DataGridViewContentAlignment.MiddleLeft, true, DataGridViewAutoSizeColumnMode.None));
                objFormatarGridView.AdicionaColuna(new FormatarColunas("ID", "IDESTADO", false));

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
                new FrmCadEstado(null).ShowDialog();
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
                    new FrmCadEstado(new ManterEstado().GetEstadoById(Convert.ToInt32(DgvDados.CurrentRow.Cells["IDESTADO"].Value))).ShowDialog();
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
                TxbSigla.TabIndex = 1;

                TxbNome.MaxLength = 50;
                TxbSigla.MaxLength = 2;
                this.Text = "Gerenciar Cadastro de Estado";
            }
            catch (Exception ex)
            {
                Tratamento.Exception(ex);
            }
        }
    }
}
