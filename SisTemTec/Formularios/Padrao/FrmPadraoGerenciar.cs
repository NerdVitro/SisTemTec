using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SisTemTec.Formularios.Padrao
{
    public partial class FrmPadraoGerenciar : Form
    {
        public FrmPadraoGerenciar()
        {
            InitializeComponent();
        }
        private void FrmPadraoGerenciar_Load(object sender, EventArgs e)
        {
            AjustarGrid();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }
        private void BtnNovo_Click(object sender, EventArgs e)
        {
            Novo();
        }
        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            LoadDados();
        }
        private void DgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                Editar();
            }

            if (this.DgvDados.Rows.Count > 0)
            {
                SendKeys.Send(" ");
            }
        }

        protected virtual void Editar()
        {

        }
        protected virtual void Novo()
        {

        }
        protected virtual void LoadDados()
        {
            
        }
        protected virtual void AjustarGrid()
        {

        }
        protected virtual void Order(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void DgvDados_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Order(sender, e);
        }
        protected SortOrder ObterOrdem(int columnIndex)
        {
            if (DgvDados.Columns[columnIndex].HeaderCell.SortGlyphDirection == SortOrder.None ||
                DgvDados.Columns[columnIndex].HeaderCell.SortGlyphDirection == SortOrder.Descending)
            {
                DgvDados.Columns[columnIndex].HeaderCell.SortGlyphDirection = SortOrder.Ascending;
                return SortOrder.Ascending;
            }
            else
            {
                DgvDados.Columns[columnIndex].HeaderCell.SortGlyphDirection = SortOrder.Descending;
                return SortOrder.Descending;
            }
        }
    }
}
