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
        public bool Resultado { get; set; } = false;

        public FrmLogin()
        {
            InitializeComponent();
            if (Constantes.NomeMaquina == @"DESKTOP-8C0QSSV\SQLEXPRESS")
            {
                TxtUsuario.Text = "vitor";
                TxtSenha.Text = "1234";
            }
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                Login login = new Login();
                if (login.ValidarAcesso(TxtUsuario.Text, TxtSenha.Text))
                {
                    Resultado = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(login.Messagem);
                    if (login.Messagem.Contains("Usuário"))
                    {
                        TxtUsuario.Focus();
                    }
                    else
                    {
                        TxtSenha.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                Tratamento.Exception(ex);
            }
        }

        private void TxtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == ((char)Keys.Enter))
                {
                    TxtSenha.Focus();
                }
            }
            catch (Exception ex)
            {
                Tratamento.Exception(ex);
            }
        }

        private void TxtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == ((char)Keys.Enter))
                {
                    BtnEntrar.PerformClick();
                }
            }
            catch (Exception ex)
            {
                Tratamento.Exception(ex);
            }
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            try
            {
                Resultado = false;
                this.Close();
            }
            catch (Exception ex)
            {
                Tratamento.Exception(ex);
            }
        }
    }
}
