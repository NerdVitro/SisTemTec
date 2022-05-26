using System;
using System.Collections.Generic;
using System.Text;

namespace SisTemTec.Banco.Tabelas
{
    /// <summary>
    /// Tabela de cadastro de equipamento
    /// </summary>
    public class TBEQUIPAMENTO
    {
        private int _IDEQUIPAMENTO;
        private int _IDCLIENTE;
        private int _IDTIPOEQUIPAMENTO;
        private string _NMDESCRICAO;

        public TBEQUIPAMENTO(int iDEQUIPAMENTO, int iDCLIENTE, int iDTIPOEQUIPAMENTO, string nMDESCRICAO)
        {
            _IDEQUIPAMENTO = iDEQUIPAMENTO;
            _IDCLIENTE = iDCLIENTE;
            _IDTIPOEQUIPAMENTO = iDTIPOEQUIPAMENTO;
            _NMDESCRICAO = nMDESCRICAO;
        }

        /// <summary>
        /// Primary Key
        /// </summary>
        public int IDEQUIPAMENTO { get => _IDEQUIPAMENTO; set => _IDEQUIPAMENTO = value; }
        /// <summary>
        /// Foreign key - TBCLIENTE
        /// </summary>
        public int IDCLIENTE { get => _IDCLIENTE; set => _IDCLIENTE = value; }
        /// <summary>
        /// Foreign key - TBTIPOEQUIPAMENTO
        /// </summary>
        public int IDTIPOEQUIPAMENTO { get => _IDTIPOEQUIPAMENTO; set => _IDTIPOEQUIPAMENTO = value; }
        /// <summary>
        /// Descrição do equipamento
        /// </summary>
        public string NMDESCRICAO { get => _NMDESCRICAO; set => _NMDESCRICAO = value; }
    }
}
