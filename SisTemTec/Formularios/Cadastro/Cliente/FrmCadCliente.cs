using SisTemTec.Banco.Tabelas;
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
        public FrmCadCliente(TBCLIENTE parTBCLIENTE)
        {
            InitializeComponent();

            if(parTBCLIENTE != null)
            {

            }
        }
    }
}
