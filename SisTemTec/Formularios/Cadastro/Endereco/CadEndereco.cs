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
        bool Fechando;

        public CadEndereco()
        {
            InitializeComponent();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            // Cadastrar e fechar retornando endereço cadastrado
            IDENDERECO = new ManterEnderecoFast().CadastrarEndereco(_IDEstado, TxbCidade.Text, TxbBairro.Text,Convert.ToInt32(MskNumero.Text),TxbRua.Text,TxbComplemento.Text);
            NOMEENDERECO = TxbCidade.Text + " " + TxbBairro.Text + " " + MskNumero.Text;
            Fechando = true;
            this.Close();
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            IDENDERECO = 0;
            NOMEENDERECO = "";
            Fechando = false;
            this.Close();
        }

        private void CadEndereco_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!Fechando)
            {
                IDENDERECO = 0;
                NOMEENDERECO = "";
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
            TxbEstado.Text = "";
            _IDEstado = 0;
        }
    }
}
