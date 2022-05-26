using SisTemTec.Banco;
using SisTemTec.Banco.Tabelas;
using SisTemTec.Core.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SisTemTec.Formularios.Cadastro.Estado
{
    public partial class FrmCadEstado : Form
    {
        public FrmCadEstado()
        {
            InitializeComponent();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    if (Salvar())
                    {

                    }
                    else
                    {

                    }
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                Tratamento.Exception(ex);
            }
        }

        private bool Validar()
        {
            try
            {
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
        private bool Salvar()
        {
            try
            {
                TBESTADO estado = new TBESTADO(TxbEstado.Text, TxbSigla.Text);
                InserirDados inserir = new InserirDados();
                if(inserir.CadastrarEstado(estado))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
