using SisTemTec.Banco.Tabelas;
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
        int IDENDERECO;

        public FrmCadCliente(TBCLIENTE parTBCLIENTE)
        {
            InitializeComponent();

            if(parTBCLIENTE != null)
            {

            }
            else
            {
                CkbJuridica.Checked = false;
                CkbFisica.Checked = true;
            }
        }

        private void CkbJuridica_CheckedChanged(object sender, EventArgs e)
        {
            if (CkbJuridica.Checked)
            {
                CkbFisica.Checked = false;
                MskCpfCnpj.Mask = @"00\.000\.000\/0000\-00";
            }
            else
            {
                MskCpfCnpj.Mask = @"000\.000\.000\-00";
                CkbFisica.Checked = true;
            }
        }

        private void CkbFisica_CheckedChanged(object sender, EventArgs e)
        {
            if (CkbFisica.Checked)
            {
                MskCpfCnpj.Mask = @"000\.000\.000\-00";
                CkbJuridica.Checked = false;
            }
            else
            {
                MskCpfCnpj.Mask = @"00\.000\.000\/0000\-00";
                CkbJuridica.Checked = true;
            }
        }

        private void BtnConsultaEstado_Click(object sender, EventArgs e)
        {
            using (CadEndereco endereco = new CadEndereco())
            {
                endereco.ShowDialog();
                TxbEndereco.Text = endereco.NOMEENDERECO;
                IDENDERECO = endereco.IDENDERECO;
            }
        }
    }
}
