using System;
using System.Collections.Generic;
using System.Text;

namespace SisTemTec.Banco.Tabelas
{
    public class TBESTADO
    {
        private int _IDESTADO;
        private string _NMESTADO;

        public TBESTADO(int iDESTADO, string nMESTADO)
        {
            _IDESTADO = iDESTADO;
            _NMESTADO = nMESTADO;
        }

        public int IDESTADO { get => _IDESTADO; set => _IDESTADO = value; }
        public string NMESTADO { get => _NMESTADO; set => _NMESTADO = value; }
    }
}
