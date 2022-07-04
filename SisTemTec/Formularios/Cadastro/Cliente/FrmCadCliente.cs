using SisTemTec.Banco.Manter;
using SisTemTec.Banco.Tabelas;
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

namespace SisTemTec.Formularios.Cadastro.Cliente
{
    public partial class FrmCadCliente : FrmPadraoCadastro
    {
        public int IDCLIENTE { get; set; }
        
        private int _IDENDERECO;
        private ClienteBO _ObjClienteBO;

        public FrmCadCliente(ClienteBO parClienteBO)
        {
            InitializeComponent();

            if(parClienteBO != null)
            {
                IDCLIENTE = parClienteBO.IDCLIENTE;
                TxbNome.Text = parClienteBO.NMNOME;
                TxbEmail.Text = parClienteBO.NMEMAIL;
                MskCpfCnpj.Text = parClienteBO.NRCPFCNPJ.ToString();
                TxbNomeRazao.Text = parClienteBO.NMNOMERAZAO;
                MskTxbNumero.Text = parClienteBO.NRTELEFONE.ToString();
                TxbEndereco.Text = parClienteBO.NMENDERECO;
                _IDENDERECO = parClienteBO.IDENDERECO;

                if (MskCpfCnpj.Text.Length == 14)
                {
                    CkbJuridica.Checked = false;
                    CkbFisica.Checked = true;
                    MskCpfCnpj.Mask = @"000\.000\.000\-00"; 
                }
                else
                {
                    CkbJuridica.Checked = true;
                    CkbFisica.Checked = false;
                    MskCpfCnpj.Mask = @"00\.000\.000\/0000\-00";
                }
            }
            else
            {
                CkbJuridica.Checked = false;
                CkbFisica.Checked = true;
                TxbNomeRazao.Enabled = false;
            }
            SetTela();
        }

        protected override bool Salvar()
        {
            try
            {
                ManterCliente ObjManterCliente = new ManterCliente();
                SetObjectSave();
                if (ObjManterCliente.SalvarCliente(_ObjClienteBO))
                {
                    if (IDCLIENTE == 0)
                    {
                        TxbNome.Text = "";
                        TxbEmail.Text = "";
                        MskCpfCnpj.Text = "";
                        TxbNomeRazao.Text = "";
                        MskTxbNumero.Text = "";
                        TxbEndereco.Text = "";
                        _IDENDERECO = 0;

                        CkbJuridica.Checked = false;
                        CkbFisica.Checked = true;
                        MskCpfCnpj.Mask = @"000\.000\.000\-00";
                    }
                    else
                    {
                        this.Close();
                    }

                    return true;
                }
                else
                {
                    if (ObjManterCliente.TemMensagem)
                    {
                        Tratamento.MostrarMensagem(ObjManterCliente.Mansegem);
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
                CkbFisica.TabStop = false;
                CkbJuridica.TabStop = false;
                TxbNomeRazao.TabStop = false;
                this.Text = "Cadastro de Cliente";
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
                _ObjClienteBO = new ClienteBO
                    (
                        IDCLIENTE,
                        Convert.ToInt64(MskCpfCnpj.Text.Replace("-", "").Replace(".", "").Replace("/", "")),
                        TxbNome.Text,
                        TxbNomeRazao.Text,
                        Convert.ToInt64(MskTxbNumero.Text.Replace("-","").Replace("(", "").Replace(")", "").Replace(" ", "")),
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

        private void CkbJuridica_CheckedChanged(object sender, EventArgs e)
        {
            if (CkbJuridica.Checked)
            {
                CkbFisica.Checked = false;
                TxbNomeRazao.Enabled = true;
                MskCpfCnpj.Mask = @"00\.000\.000\/0000\-00";
            }
            else
            {
                MskCpfCnpj.Mask = @"000\.000\.000\-00";
                TxbNomeRazao.Enabled = false;
                CkbFisica.Checked = true;
            }
        }
        private void CkbFisica_CheckedChanged(object sender, EventArgs e)
        {
            if (CkbFisica.Checked)
            {
                MskCpfCnpj.Mask = @"000\.000\.000\-00";
                TxbNomeRazao.Enabled = false;
                CkbJuridica.Checked = false;
            }
            else
            {
                MskCpfCnpj.Mask = @"00\.000\.000\/0000\-00";
                TxbNomeRazao.Enabled = true;
                CkbJuridica.Checked = true;
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
