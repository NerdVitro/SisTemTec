using SisTemTec.Banco.Manter;
using SisTemTec.Core.Classes;
using SisTemTec.Formularios.Padrao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SisTemTec.Formularios.Consultas
{
    public partial class CnsEstado : FrmCnsPadrao
    {
        private DataTable _DadosGrid;
        public string Nome { get; set; }
        public int ID { get; set; }

        public CnsEstado()
        {
            InitializeComponent();
            SetTela();
        }
        protected override void LoadDados()
        {
            try
            {
                _DadosGrid = new ManterEstado().GetEstados(TxbNome.Text, TxbSigla.Text);
                AjustarGrid();
            }
            catch (Exception ex)
            {
                Tratamento.Exception(ex);
            }
        }
        protected override void AjustarGrid()
        {
            try
            {
                FormatarGridView objFormatarGridView = new FormatarGridView(DgvDados);
                objFormatarGridView.AdicionaColuna(new FormatarColunas("Estado", "NMESTADO", 200, DataGridViewContentAlignment.MiddleLeft, true, DataGridViewAutoSizeColumnMode.Fill));
                objFormatarGridView.AdicionaColuna(new FormatarColunas("Sigla", "NMSIGLA", 200, DataGridViewContentAlignment.MiddleLeft, true, DataGridViewAutoSizeColumnMode.None));
                objFormatarGridView.AdicionaColuna(new FormatarColunas("ID", "IDESTADO", false));

                objFormatarGridView.Finalizar(_DadosGrid);
            }
            catch (Exception ex)
            {
                Tratamento.Exception(ex);
            }
        }

        protected override void Selecionar()
        {
            try
            {
                if (DgvDados.CurrentRow != null)
                {
                    Nome = Convert.ToString(DgvDados.CurrentRow.Cells["NMESTADO"].Value);
                    ID = Convert.ToInt32(DgvDados.CurrentRow.Cells["IDESTADO"].Value);

                    this.Close();                    
                }
            }
            catch (Exception ex)
            {
                Tratamento.Exception(ex);
            }
        }

        private void SetTela()
        {
            TxbNome.TabIndex = 0;
            TxbSigla.TabIndex = 0;

            TxbNome.MaxLength = 50;
            TxbSigla.MaxLength = 2;
        }
    }
}
