using System;
using System.Collections.Generic;
using System.Text;

namespace SisTemTec.Banco.Tabelas
{
    /// <summary>
    /// Tabela de cadastro de Tipo Equipamento
    /// </summary>
    public class TBTIPOEQUIPAMENTO
    {
        private int _IDTIPOEQUIPAMENTO;
        private string _NMDESCRICAO;

        public TBTIPOEQUIPAMENTO(int iDTIPOEQUIPAMENTO, string nMDESCRICAO)
        {
            _IDTIPOEQUIPAMENTO = iDTIPOEQUIPAMENTO;
            _NMDESCRICAO = nMDESCRICAO;
        }

        /// <summary>
        /// Primary Key
        /// </summary>
        public int IDTIPOEQUIPAMENTO { get => _IDTIPOEQUIPAMENTO; set => _IDTIPOEQUIPAMENTO = value; }
        /// <summary>
        /// Descrição Tipo de Equipamento
        /// </summary>
        public string NMDESCRICAO { get => _NMDESCRICAO; set => _NMDESCRICAO = value; }
    }
}
