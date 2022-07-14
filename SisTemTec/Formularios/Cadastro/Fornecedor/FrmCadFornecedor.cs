using SisTemTec.Banco.Manter;
using SisTemTec.Classes.BOs;
using SisTemTec.Core.Classes;
using SisTemTec.Formularios.Cadastro.Endereco;
using SisTemTec.Formularios.Padrao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SisTemTec.Formularios.Cadastro.Fornecedor
{
    public partial class FrmCadFornecedor : FrmPadraoCadastro
    {
        private int _IDENDERECO;
        private int _IDFORNECEDOR;
        private FornecedorBO _ObjFornecedorBO;

        public FrmCadFornecedor(FornecedorBO parFornecedorBO)
        {
            InitializeComponent();

            if (parFornecedorBO != null)
            {
                _ObjFornecedorBO = parFornecedorBO;
                _IDFORNECEDOR = parFornecedorBO.IDFORNECEDOR;
                TxbNome.Text = parFornecedorBO.NMNOME;
                TxbEmail.Text = parFornecedorBO.NMEMAIL;
                MskCpfCnpj.Text = parFornecedorBO.NRCNPJ.ToString();
                TxbNomeRazao.Text = parFornecedorBO.NMNOMERAZAO;
                MskTxbNumero.Text = parFornecedorBO.NRTELEFONE.ToString();
                TxbEndereco.Text = parFornecedorBO.NMENDERECO;
                _IDENDERECO = parFornecedorBO.IDENDERECO;

                MskCpfCnpj.Mask = @"00\.000\.000\/0000\-00";
            }
            SetTela();
        }

        protected override bool Salvar()
        {
            try
            {
                ManterFornecedor ObjManterFornecedor = new ManterFornecedor();
                SetObjectSave();
                if (ObjManterFornecedor.SalvarFornecedor(_ObjFornecedorBO))
                {
                    if (_IDFORNECEDOR == 0)
                    {
                        TxbNome.Text = "";
                        TxbEmail.Text = "";
                        MskCpfCnpj.Text = "";
                        TxbNomeRazao.Text = "";
                        MskTxbNumero.Text = "";
                        TxbEndereco.Text = "";
                        _IDENDERECO = 0;

                        MskCpfCnpj.Mask = @"00\.000\.000\/0000\-00";
                    }
                    else
                    {
                        this.Close();
                    }

                    return true;
                }
                else
                {
                    if (ObjManterFornecedor.TemMensagem)
                    {
                        Tratamento.MostrarMensagem(ObjManterFornecedor.Mansegem);
                    }

                    return false;
                }
            }
            catch (Exception ex)
            {
                Tratamento.Exception(ex);
                return false;
            }
        }
        protected override bool Cancelar()
        {
            try
            {
                bool alterado = false;
                if (_IDFORNECEDOR == 0)
                {
                    if (TxbNome.Text == "" ||
                        TxbEmail.Text == "" ||
                        TxbNomeRazao.Text == "" ||
                        MskTxbNumero.Text == "(  )      -" ||
                        MskCpfCnpj.Text == "   .   .   -" ||
                        TxbEndereco.Text == "")
                    {
                        alterado = true;
                    }
                }
                else
                {
                    if (TxbNome.Text == _ObjFornecedorBO.NMNOME ||
                        TxbEmail.Text == _ObjFornecedorBO.NMEMAIL ||
                        TxbNomeRazao.Text == _ObjFornecedorBO.NMNOMERAZAO ||
                        MskTxbNumero.Text.Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "") == _ObjFornecedorBO.NRTELEFONE.ToString() ||
                        MskCpfCnpj.Text.Replace("-", "").Replace(".", "").Replace("/", "") == _ObjFornecedorBO.NRCNPJ.ToString() ||
                        TxbEndereco.Text == _ObjFornecedorBO.NMENDERECO)
                    {
                        alterado = true;
                    }
                }

                if (alterado)
                {
                    DialogResult dialogResult = MessageBox.Show("Deseja descartar alterações feitas?", "Atenção", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        return true;
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        return false;
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                Tratamento.Exception(ex);
                return false;
            }
        }

        private void SetTela()
        {
            try
            {
                //TxbNome.TabIndex = 0;
                //TxbSigla.TabIndex = 1;

                //TxbNome.MaxLength = 50;
                //TxbSigla.MaxLength = 2;

                BtnLimparEstado.TabStop = false;
                TxbNomeRazao.TabStop = false;
                this.Text = "Cadastro de Fornecedor";
            }
            catch (Exception ex)
            {
                Tratamento.Exception(ex);
            }
        }
        private void SetObjectSave()
        {
            try
            {
                if (MskTxbNumero.Text == "(  )      -")
                {
                    throw new Exception("Número é obrigatório");
                }
                if (MskCpfCnpj.Text == "  .   .   /    -")
                {
                    throw new Exception("CNPJ é obrigatório.");
                }

                _ObjFornecedorBO = new FornecedorBO
                    (
                        _IDFORNECEDOR,
                        Convert.ToInt64(MskCpfCnpj.Text.Replace("-", "").Replace(".", "").Replace("/", "")),
                        TxbNome.Text,
                        TxbNomeRazao.Text,
                        Convert.ToInt64(MskTxbNumero.Text.Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "")),
                        TxbEmail.Text,
                        _IDENDERECO,
                        TxbEndereco.Text
                    );
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void BtnConsultaEstado_Click(object sender, EventArgs e)
        {
            try
            {
                using (CadEndereco endereco = new CadEndereco())
                {
                    endereco.ShowDialog();
                    TxbEndereco.Text = endereco.NOMEENDERECO;
                    _IDENDERECO = endereco.IDENDERECO;
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
                TxbEndereco.Text = "";
                _IDENDERECO = 0;
            }
            catch (Exception ex)
            {
                Tratamento.Exception(ex);
            }
        }
    }
}
