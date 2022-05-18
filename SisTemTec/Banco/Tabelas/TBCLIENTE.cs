using System;
using System.Collections.Generic;
using System.Text;

namespace SisTemTec.Banco.Tabelas
{
    public  class TBCLIENTE
    {
        private int _IDCLIENTE;
        private int _IDENDERECO;
        private int _NRCPFCNPJ;
        private string _NMNOME;
        private string _NMNOMERAZAO;
        private int _NRTELEFONE;
        private string _NMEMAIL;

        public TBCLIENTE(int iDCLIENTE, int iDENDERECO, int nRCPFCNPJ, string nMNOME, string nMNOMERAZAO, int nRTELEFONE, string nMEMAIL)
        {
            _IDCLIENTE = iDCLIENTE;
            _IDENDERECO = iDENDERECO;
            _NRCPFCNPJ = nRCPFCNPJ;
            _NMNOME = nMNOME;
            _NMNOMERAZAO = nMNOMERAZAO;
            _NRTELEFONE = nRTELEFONE;
            _NMEMAIL = nMEMAIL;
        }

        public int IDCLIENTE { get => _IDCLIENTE; set => _IDCLIENTE = value; }
        public int IDENDERECO { get => _IDENDERECO; set => _IDENDERECO = value; }
        public int NRCPFCNPJ { get => _NRCPFCNPJ; set => _NRCPFCNPJ = value; }
        public string NMNOME { get => _NMNOME; set => _NMNOME = value; }
        public string NMNOMERAZAO { get => _NMNOMERAZAO; set => _NMNOMERAZAO = value; }
        public int NRTELEFONE { get => _NRTELEFONE; set => _NRTELEFONE = value; }
        public string NMEMAIL { get => _NMEMAIL; set => _NMEMAIL = value; }
    }
}
