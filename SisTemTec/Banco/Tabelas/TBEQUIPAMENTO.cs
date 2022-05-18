using System;
using System.Collections.Generic;
using System.Text;

namespace SisTemTec.Banco.Tabelas
{
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

        public int IDEQUIPAMENTO { get => _IDEQUIPAMENTO; set => _IDEQUIPAMENTO = value; }
        public int IDCLIENTE { get => _IDCLIENTE; set => _IDCLIENTE = value; }
        public int IDTIPOEQUIPAMENTO { get => _IDTIPOEQUIPAMENTO; set => _IDTIPOEQUIPAMENTO = value; }
        public string NMDESCRICAO { get => _NMDESCRICAO; set => _NMDESCRICAO = value; }
    }
}
