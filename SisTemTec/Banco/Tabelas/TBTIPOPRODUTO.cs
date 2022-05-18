using System;
using System.Collections.Generic;
using System.Text;

namespace SisTemTec.Banco.Tabelas
{
    public class TBTIPOPRODUTO
    {
        private int _IDTIPOPRODUTO;
        private string _NMDESCRICAO;

        public TBTIPOPRODUTO(int iDTIPOPRODUTO, string nMDESCRICAO)
        {
            _IDTIPOPRODUTO = iDTIPOPRODUTO;
            _NMDESCRICAO = nMDESCRICAO;
        }

        public int IDTIPOPRODUTO { get => _IDTIPOPRODUTO; set => _IDTIPOPRODUTO = value; }
        public string NMDESCRICAO { get => _NMDESCRICAO; set => _NMDESCRICAO = value; }
    }
}
