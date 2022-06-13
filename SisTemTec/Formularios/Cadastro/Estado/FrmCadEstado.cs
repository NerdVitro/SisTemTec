using SisTemTec.Banco;
using SisTemTec.Banco.Manter;
using SisTemTec.Banco.Tabelas;
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
    public partial class FrmCadEstado : FrmPadraoCadastro
    {
        private int IDESTADO;

        public FrmCadEstado(TBESTADO parTBESTADO)
        {
            InitializeComponent();
            SetTela();

            if (parTBESTADO != null)
            {
                IDESTADO = parTBESTADO.IDESTADO;
                TxbNome.Text = parTBESTADO.NMESTADO;
                TxbSigla.Text = parTBESTADO.NMSIGLA;
            }
            else
            {
                IDESTADO = 0;
            }
        }

        protected override bool Salvar()
        {
            try
            {
                ManterEstado ObjManterEstado = new ManterEstado();

                if (ObjManterEstado.CadastrarEstado(new TBESTADO(IDESTADO,TxbNome.Text, TxbSigla.Text)))
                {
                    if(IDESTADO == 0)
                    {
                        TxbNome.Text = "";
                        TxbSigla.Text = "";
                    }
                    else
                    {
                        this.Close();
                    }

                    return true;
                }
                else
                {
                    if (ObjManterEstado.TemMensagem)
                    {
                        Tratamento.MostrarMensagem(ObjManterEstado.Mansegem);
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
                TxbNome.TabIndex = 0;
                TxbSigla.TabIndex = 1;

                TxbNome.MaxLength = 50;
                TxbSigla.MaxLength = 2;
                this.Text = "Cadastro de Estado";
            }
            catch (Exception ex)
            {
                Tratamento.Exception(ex);
            }
        }
    }
}
