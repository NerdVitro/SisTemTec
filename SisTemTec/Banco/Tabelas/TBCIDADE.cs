using System;
using System.Collections.Generic;
using System.Text;

namespace SisTemTec.Banco.Tabelas
{
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

        public int IDCIDADE { get => _IDCIDADE; set => _IDCIDADE = value; }
        public int IDESTADO { get => _IDESTADO; set => _IDESTADO = value; }
        public string NMCIDADE { get => _NMCIDADE; set => _NMCIDADE = value; }
    }
}
