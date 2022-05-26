using System;
using System.Collections.Generic;
using System.Text;

namespace SisTemTec.Banco.Tabelas
{
    /// <summary>
    /// Tabela de cadastro de Bairro
    /// </summary>
    public class TBBAIRRO
    {
        private int _IDBAIRRO;
        private int _IDCIDADE;
        private string _NMBAIRRO;

        public TBBAIRRO(int iDBAIRRO, int iDCIDADE, string nMBAIRRO)
        {
            _IDBAIRRO = iDBAIRRO;
            _IDCIDADE = iDCIDADE;
            _NMBAIRRO = nMBAIRRO;
        }

        /// <summary>
        /// Primary key
        /// </summary>
        public int IDBAIRRO { get => _IDBAIRRO; set => _IDBAIRRO = value; }
        /// <summary>
        /// Foreign key - TBCIDADE
        /// </summary>
        public int IDCIDADE { get => _IDCIDADE; set => _IDCIDADE = value; }
        /// <summary>
        /// Nome do bairro
        /// </summary>
        public string NMBAIRRO { get => _NMBAIRRO; set => _NMBAIRRO = value; }
    }
}
