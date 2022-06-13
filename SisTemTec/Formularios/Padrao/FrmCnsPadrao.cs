using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SisTemTec.Formularios.Padrao
{
    public partial class FrmCnsPadrao : Form
    {
        public FrmCnsPadrao()
        {
            InitializeComponent();
        }

        private void FrmCnsPadrao_Load(object sender, EventArgs e)
        {
            LoadDados();
        }
        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            LoadDados();
        }

        private void BtnSelecionar_Click(object sender, EventArgs e)
        {
            Selecionar();
        }

        protected virtual void Selecionar()
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
        private void DgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
         {
            if (e.RowIndex > -1)
            {
                Selecionar();
            }
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
