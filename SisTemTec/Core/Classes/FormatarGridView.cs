using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SisTemTec.Core.Classes
{
    public class FormatarGridView
    {
        readonly DataGridView dataGridView;
        readonly List<FormatarColunas> objLstColunas;

        public FormatarGridView(DataGridView parDataGridView)
        {
            dataGridView = parDataGridView;

            dataGridView.Columns.Clear();

            objLstColunas = null;
            objLstColunas = new List<FormatarColunas>();
            dataGridView.AutoGenerateColumns = false;
        }

        public void AdicionaColuna(FormatarColunas parColuna)
        {
            objLstColunas.Add(parColuna);
        }

        public void Finalizar(Object listaObjetos)
        {
            FormatarColunas objColuna;
            dataGridView.DataSource = listaObjetos;
            Configurar();

            for (int iixTable = 0; iixTable < objLstColunas.Count; iixTable++)
            {
                objColuna = objLstColunas[iixTable];
                DataGridViewTextBoxColumn coluna = new DataGridViewTextBoxColumn()
                {
                    HeaderText = objColuna.Titulo,
                    Name = objColuna.NomeCampo,
                    Visible = objColuna.ColunaVisivel,
                    ReadOnly = objColuna.ReadOnly,
                    Resizable = DataGridViewTriState.True,
                    Width = objColuna.Tamanho,
                    SortMode = DataGridViewColumnSortMode.Programmatic,
                    DataPropertyName = objColuna.NomeCampo,
                    AutoSizeMode = objColuna.AutoSizeMode,
                };
                coluna.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                coluna.DefaultCellStyle.Alignment = objColuna.Alinhamento;
                coluna.DefaultCellStyle.BackColor = objColuna.CorFundo;
                coluna.DefaultCellStyle.Format = objColuna.Mascara;
                coluna.DefaultCellStyle.ForeColor = objColuna.CorFonte;
                dataGridView.Columns.Add(coluna);
            }

            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }
        }

        private void Configurar()
        {
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Forma de seleção será linha inteira
            dataGridView.AllowUserToDeleteRows = false;     // Usuário NÃO pode excluir linhas
            dataGridView.AllowUserToResizeRows = false;     // Usuário NÃO pode redimencionar as LINHAS
            dataGridView.AllowUserToResizeColumns = true;   // Usuário pode redimencionar as colunas
            dataGridView.AllowUserToOrderColumns = true;    // Usuário pode trocar as colunas de lugar
            dataGridView.AllowUserToAddRows = false;        // Usuário NÃO pode adicionar linhas
            dataGridView.MultiSelect = false;               // NÃO pode selecionar mais que uma linha por vez
            dataGridView.ColumnHeadersVisible = true;       // Cabeçalhos das colunas são visíveis
        }
    }





    public class FormatarColunas
    {
        public FormatarColunas(string titulo, string nomeCampo, int tamanho, DataGridViewContentAlignment alinhamento, bool colunaVisivel, DataGridViewAutoSizeColumnMode autoSizeMode)
        {
            Titulo = titulo;
            NomeCampo = nomeCampo;
            Tamanho = tamanho;
            Alinhamento = alinhamento;
            ColunaVisivel = colunaVisivel;
            AutoSizeMode = autoSizeMode;
            ColunaSelecao = false;
            Mascara = "";
            CorFonte = new Color();
            CorFundo = new Color();
            ReadOnly = true;
        }
        public FormatarColunas(string titulo, string nomeCampo, bool colunaVisivel)
        {
            Titulo = titulo;
            NomeCampo = nomeCampo;
            Tamanho = 0;
            Alinhamento = DataGridViewContentAlignment.MiddleLeft;
            ColunaVisivel = colunaVisivel;
            AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            ColunaSelecao = false;
            Mascara = "";
            CorFonte = new Color();
            CorFundo = new Color();
            ReadOnly = true;
        }

        public string Titulo { get; set; }                              // Titulo do campo
        public string NomeCampo { get; set; }                           // Nome do campo
        public int Tamanho { get; set; }                                // Tamanho do campo
        public DataGridViewContentAlignment Alinhamento { get; set; }   // Alinhamento do campo (Esquerda, direita, centro)
        public Boolean ColunaSelecao { get; set; }                      // Identifica se é uma coluna de selecao
        public string Mascara { get; set; }                             // Mascara do campo
        public Color CorFonte { get; set; }                             // Cor da fonte que ira aparecer
        public Color CorFundo { get; set; }                             // Cor do fundo que ira aparecer
        public bool ColunaVisivel { get; set; }                         // Coluna é visivel
        public bool ReadOnly { get; set; }                              // Coluna é só leitura
        public DataGridViewAutoSizeColumnMode AutoSizeMode { get; set; }// tamanho automatico 
    }
}
