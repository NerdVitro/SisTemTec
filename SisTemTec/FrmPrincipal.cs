using SisTemTec.Core.Classes;
using SisTemTec.Formularios.Cadastro;
using SisTemTec.Formularios.Cadastro.Cidade;
using SisTemTec.Formularios.Cadastro.Cliente;
using SisTemTec.Formularios.Cadastro.Estado;
using SisTemTec.Formularios.Cadastro.Fornecedor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisTemTec
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            PnlCadastros.Visible = false;
            PnlEquipamentos.Visible = false;
        }
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
        private void TmrClock_Tick(object sender, EventArgs e)
        {
            try
            {
                //LblClock.Text = DateTime.Now.ToString("HH:mm:ss");
            }
            catch (Exception ex)
            {
                Tratamento.Exception(ex);
            }
        }
        private void OcultarMenus()
        {
            PnlCadastros.Visible = false;
            PnlEquipamentos.Visible = false;
        }

        private void BtnOrdemVenda_Click(object sender, EventArgs e)
        {
            try
            {
                OcultarMenus();
                new FrmOrdemServico().ShowDialog();
            }
            catch (Exception ex)
            {
                Tratamento.Exception(ex);
            }
        }

        private void BtnCadastros_Click(object sender, EventArgs e)
        {
            try
            {
                if (PnlCadastros.Visible)
                {
                    PnlCadastros.Visible = false;
                    PnlEquipamentos.Visible = false;
                }
                else
                {
                    PnlCadastros.Visible = true;
                }
            }
            catch (Exception ex)
            {
                Tratamento.Exception(ex);
            }
        }
        private void BtnCadastroEquipamentos_Click(object sender, EventArgs e)
        {
            try
            {
                if (PnlEquipamentos.Visible)
                {
                    PnlEquipamentos.Visible = false;
                }
                else
                {
                    PnlEquipamentos.Visible = true;
                }
            }
            catch (Exception ex)
            {
                Tratamento.Exception(ex);
            }
        }

        private void BtnCdastrarEstado_Click(object sender, EventArgs e)
        {
            try
            {
                OcultarMenus();
                new FrmEstado().ShowDialog();
            }
            catch (Exception ex)
            {
                Tratamento.Exception(ex);
            }
        }
        private void BtnCadastroCidade_Click(object sender, EventArgs e)
        {
            try
            {
                OcultarMenus();
                new FrmCidade().ShowDialog();
            }
            catch (Exception ex)
            {
                Tratamento.Exception(ex);
            }
        }

        private void BtnCadastroCliente_Click(object sender, EventArgs e)
        {
            try
            {
                OcultarMenus();
                new FrmCliente().ShowDialog();
            }
            catch (Exception ex)
            {
                Tratamento.Exception(ex);
            }
        }
        private void BtnCadastroFornecedor_Click(object sender, EventArgs e)
        {
            try
            {
                OcultarMenus();
                new FrmFornecedor().ShowDialog();
            }
            catch (Exception ex)
            {
                Tratamento.Exception(ex);
            }
        }
    }
}
