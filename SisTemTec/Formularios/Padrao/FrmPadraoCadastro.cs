using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SisTemTec.Formularios.Padrao
{
    public partial class FrmPadraoCadastro : Form
    {
        public FrmPadraoCadastro()
        {
            InitializeComponent();
        }

        protected virtual bool Salvar()
        {
            return true;
        }
        protected virtual bool Cancelar()
        {
            return true;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            if (Cancelar())
            {
                Close();
            }
        }
    }
}
