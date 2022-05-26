using System;
using System.Collections.Generic;
using System.Text;

namespace SisTemTec.Banco.Tabelas
{
    /// <summary>
    /// Tabela de cadastro de Cidade
    /// </summary>
    public class TBCIDADE
    {
        private int _IDCIDADE;
        private int _IDESTADO;
        private string _NMCIDADE;

        public TBCIDADE(int iDCIDADE, int iDESTADO, string nMCIDADE)
        {
            _IDCIDADE = iDCIDADE;
            _IDESTADO = iDESTADO;
            _NMCIDADE = nMCIDADE;
        }

        /// <summary>
        /// Primary Key
        /// </summary>
        public int IDCIDADE { get => _IDCIDADE; set => _IDCIDADE = value; }
        /// <summary>
        /// Foreign key - TBESTADO
        /// </summary>
        public int IDESTADO { get => _IDESTADO; set => _IDESTADO = value; }
        /// <summary>
        /// Nome da cidade
        /// </summary>
        public string NMCIDADE { get => _NMCIDADE; set => _NMCIDADE = value; }
    }
}
