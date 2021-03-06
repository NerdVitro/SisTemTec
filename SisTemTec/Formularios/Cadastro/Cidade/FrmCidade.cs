using SisTemTec.Core.Classes;
using SisTemTec.Formularios.Cadastro.Estado;
using SisTemTec.Formularios.Consultas;
using SisTemTec.Formularios.Padrao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SisTemTec.Formularios.Cadastro.Cidade
{
    public partial class FrmCidade : FrmPadraoGerenciar
    {
        private int IDEstado;
        private DataTable DadosGrid;

        public FrmCidade()
        {
            InitializeComponent();
            LoadDados();
            SetTela();
        }

        protected override void LoadDados()
        {
            try
            {
                //DadosGrid = new ManterEstado().GetEstados(TxbNome.Text, TxbSigla.Text);
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
                objFormatarGridView.AdicionaColuna(new FormatarColunas("Cidade", "NMESTADO", 200, DataGridViewContentAlignment.MiddleLeft, true, DataGridViewAutoSizeColumnMode.Fill));
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
                    //new FrmCadEstado(new ManterEstado().GetEstadoById(Convert.ToInt32(DgvDados.CurrentRow.Cells["IDESTADO"].Value))).ShowDialog();
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
                TbxEstado.TabIndex = 0;
                TxbCidade.TabIndex = 1;

                TbxEstado.MaxLength = 50;
                TxbCidade.MaxLength = 2;
                this.Text = "Gerenciar Cadastro de Cidade";
            }
            catch (Exception ex)
            {
                Tratamento.Exception(ex);
            }
        }

        private void BtnConsultaEstado_Click(object sender, EventArgs e)
        {
            try
            {
                using (CnsEstado Consulta = new CnsEstado())
                {
                    Consulta.ShowDialog();
                    TbxEstado.Text = Consulta.Nome;
                    IDEstado = Consulta.ID;
                }
            }
            catch (Exception ex)
            {
                Tratamento.Exception(ex);
            }
        }
        private void BtnLimparEstado_Click(object sender, EventArgs e)
        {
            try
            {
                TbxEstado.Text = "";
                IDEstado = 0;
            }
            catch (Exception ex)
            {
                Tratamento.Exception(ex);
            }
        }
    }
}
