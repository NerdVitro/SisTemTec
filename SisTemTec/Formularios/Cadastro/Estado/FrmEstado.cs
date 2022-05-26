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
        public FrmEstado()
        {
            InitializeComponent();
        }


        protected override void LoadDados()
        {
            try
            {
                //if (!_ObjProdutosxAdicionaisMobileController.LoadDadosProdutosxAdicionaisMobile(SpoEdtProduto.Text, SpoEdtAdicional.Text, CkbSomenteAtivos.Checked))
                //{
                //    _Mensagem.LimparMensagens();
                //    _Mensagem.A0000_MENSAGEMPADRAO(_ObjProdutosxAdicionaisMobileController.SsxMensagem);
                //    _Mensagem.Show(ETipoMensagem.Aviso, false);
                //}
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
                objFormatarGridView.AdicionaColuna(new FormatarColunas("PRO", "Produto", 200, DataGridViewContentAlignment.MiddleLeft, true, DataGridViewAutoSizeColumnMode.Fill));
                objFormatarGridView.AdicionaColuna(new FormatarColunas("DESC", "Descricao", 300, DataGridViewContentAlignment.MiddleLeft, true, DataGridViewAutoSizeColumnMode.None));
                objFormatarGridView.AdicionaColuna(new FormatarColunas("TIPO", "tipo", 200, DataGridViewContentAlignment.MiddleLeft, true, DataGridViewAutoSizeColumnMode.None));
                objFormatarGridView.AdicionaColuna(new FormatarColunas("iddododod", "id", false));
                DataTable Dados = new DataTable();

                objFormatarGridView.Finalizar(Dados);

                base.LoadDados();
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
                //_ObjProdutosxAdicionaisMobileController.IDRLCPAD021 = 0;
                //_ObjProdutosxAdicionaisMobileController.IsInsert = true;
                //using (FrmCadTBRLC021PAD_DSK Novo = new FrmCadTBRLC021PAD_DSK(objBaseFrpSoftiseEVODesktop, _ObjProdutosxAdicionaisMobileController))
                //{
                //    Novo.ShowDialog();
                //}

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
                //_ObjProdutosxAdicionaisMobileController.IDRLCPAD021 = DgvConsulta.CurrentRow is null ? 0 : Convert.ToInt32(DgvConsulta.CurrentRow.Cells["IDRLCPAD021"].Value);

                //if (_ObjProdutosxAdicionaisMobileController.IDRLCPAD021 > 0)
                //{
                //    if (_ObjProdutosxAdicionaisMobileController.GetProdutosxAdicionaisByIdEvoDesk())
                //    {
                //        _ObjProdutosxAdicionaisMobileController.IsInsert = false;
                //        using (FrmCadTBRLC021PAD_DSK Novo = new FrmCadTBRLC021PAD_DSK(objBaseFrpSoftiseEVODesktop, _ObjProdutosxAdicionaisMobileController))
                //        {
                //            Novo.ShowDialog();
                //        }

                //        LoadDados();
                //    }
                //    else
                //    {
                //        _Mensagem.LimparMensagens();
                //        _Mensagem.A0000_MENSAGEMPADRAO(_ObjProdutosxAdicionaisMobileController.SsxMensagem);
                //        _Mensagem.Show(ETipoMensagem.Advertencia, false);
                //    }
                //}
            }
            catch (Exception ex)
            {
                Tratamento.Exception(ex);
            }
        }
    }
}
