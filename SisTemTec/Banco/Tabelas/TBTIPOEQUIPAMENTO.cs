using System;
using System.Collections.Generic;
using System.Text;

namespace SisTemTec.Banco.Tabelas
{
    public class TBTIPOEQUIPAMENTO
    {
        private int _IDTIPOEQUIPAMENTO;
        private string _NMDESCRICAO;

        public TBTIPOEQUIPAMENTO(int iDTIPOEQUIPAMENTO, string nMDESCRICAO)
        {
            _IDTIPOEQUIPAMENTO = iDTIPOEQUIPAMENTO;
            _NMDESCRICAO = nMDESCRICAO;
        }

        public int IDTIPOEQUIPAMENTO { get => _IDTIPOEQUIPAMENTO; set => _IDTIPOEQUIPAMENTO = value; }
        public string NMDESCRICAO { get => _NMDESCRICAO; set => _NMDESCRICAO = value; }
    }
}
