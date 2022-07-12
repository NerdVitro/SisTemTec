using SisTemTec.Banco.Manter;
using SisTemTec.Core.Classes;
using SisTemTec.Formularios.Consultas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SisTemTec.Formularios.Cadastro.Endereco
{
    public partial class CadEndereco : Form
    {
        private int _IDEstado;
        public int IDENDERECO { get; set; }
        public string NOMEENDERECO { get; set; }
        bool Fechando = false;

        public CadEndereco()
        {
            InitializeComponent();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    // Cadastrar e fechar retornando endereço cadastrado
                    IDENDERECO = new ManterEnderecoFast().CadastrarEndereco(_IDEstado, TxbCidade.Text.Replace(" ", ""), TxbBairro.Text.Replace(" ", ""), Convert.ToInt32(MskNumero.Text), TxbRua.Text, TxbComplemento.Text);
                    NOMEENDERECO = TxbCidade.Text + " " + TxbBairro.Text + " " + MskNumero.Text;
                    Fechando = true;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Tratamento.Exception(ex);
            }
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            try
            {

                IDENDERECO = 0;
                NOMEENDERECO = "";
                Fechando = false;
                this.Close();
            }
            catch (Exception ex)
            {
                Tratamento.Exception(ex);
            }
        }

        private void CadEndereco_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                if (!Fechando)
                {
                    IDENDERECO = 0;
                    NOMEENDERECO = "";
                }
            }
            catch (Exception ex)
            {
                Tratamento.Exception(ex);
            }
        }

        private void BtnConsulta_Click(object sender, EventArgs e)
        {
            try
            {
                using (CnsEstado Consulta = new CnsEstado())
                {
                    Consulta.ShowDialog();
                    TxbEstado.Text = Consulta.Nome;
                    _IDEstado = Consulta.ID;
                }
            }
            catch (Exception ex)
            {
                Tratamento.Exception(ex);
            }
        }

        private void BtneXConsulta_Click(object sender, EventArgs e)
        {
            try
            {
                TxbEstado.Text = "";
                _IDEstado = 0;
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
                string mensagem = "";

                if (string.IsNullOrEmpty(TxbEstado.Text) || _IDEstado != 0)
                {
                    mensagem += "Estado é Obrigatório.\n";
                }
                if (string.IsNullOrEmpty(TxbCidade.Text))
                {
                    mensagem += "Cidade é Obrigatório.\n";
                }
                if (string.IsNullOrEmpty(TxbBairro.Text))
                {
                    mensagem += "Bairro é Obrigatório.\n";
                }
                if (string.IsNullOrEmpty(MskNumero.Text))
                {
                    mensagem += "Numero é Obrigatório.\n";
                }
                if (string.IsNullOrEmpty(TxbRua.Text))
                {
                    mensagem += "Rua é Obrigatório.\n";
                }

                if (mensagem != "")
                {
                    Tratamento.MostrarMensagem(mensagem);
                }
                return mensagem == "";
            }
            catch (Exception ex)
            {
                Tratamento.Exception(ex);
                return false;
            }
        }
    }
}
