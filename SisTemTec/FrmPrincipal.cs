using SisTemTec.Core.Classes;
using SisTemTec.Formularios.Cadastro;
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
        }

        private void BtnOrdemVenda_Click(object sender, EventArgs e)
        {
            try
            {
                using (FrmOrdemServico frmOrdemServico = new FrmOrdemServico())
                {
                    frmOrdemServico.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                Tratamento.Exception(ex);
            }
        }

        private void TmrClock_Tick(object sender, EventArgs e)
        {
            try
            {
                LblClock.Text = DateTime.Now.ToString("HH:mm:ss");
            }
            catch (Exception ex)
            {
                Tratamento.Exception(ex);
            }
        }
    }
}
