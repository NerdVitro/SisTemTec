using SisTemTec.Classes;
using SisTemTec.Core.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SisTemTec.Formularios
{
    public partial class FrmLogin : Form
    {
        private bool _Resultado = false;

        public bool Resultado { get => _Resultado;}

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                Login login = new Login();
                if (login.ValidarAcesso(TxtUsuario.Text,TxtSenha.Text))
                {
                    _Resultado = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(login.Messagem);
                }
            }
            catch (Exception ex)
            {
                Tratamento.Exception(ex);
            }
        }
    }
}
