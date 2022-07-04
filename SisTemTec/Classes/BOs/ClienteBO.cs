using System;
using System.Collections.Generic;
using System.Text;

namespace SisTemTec.Classes.BOs
{
    public class ClienteBO
    {
        private int _IDCLIENTE;
        private Int64 _NRCPFCNPJ;
        private string _NMNOME;
        private string _NMNOMERAZAO;
        private Int64 _NRTELEFONE;
        private string _NMEMAIL;
        private int _IDENDERECO;
        private string _NMENDERECO;

        public ClienteBO(int iDCLIENTE, Int64 nRCPFCNPJ, string nMNOME, string nMNOMERAZAO, Int64 nRTELEFONE, string nMEMAIL, int iDENDERECO, string nMENDERECO)
        {
            _IDCLIENTE = iDCLIENTE;
            _NRCPFCNPJ = nRCPFCNPJ;
            _NMNOME = nMNOME;
            _NMNOMERAZAO = nMNOMERAZAO;
            _NRTELEFONE = nRTELEFONE;
            _NMEMAIL = nMEMAIL;
            _IDENDERECO = iDENDERECO;
            _NMENDERECO = nMENDERECO;
        }
        public ClienteBO()
        {

        }

        public int IDCLIENTE { get => _IDCLIENTE; set => _IDCLIENTE = value; }
        public Int64 NRCPFCNPJ { get => _NRCPFCNPJ; set => _NRCPFCNPJ = value; }
        public string NMNOME { get => _NMNOME; set => _NMNOME = value; }
        public string NMNOMERAZAO { get => _NMNOMERAZAO; set => _NMNOMERAZAO = value; }
        public Int64 NRTELEFONE { get => _NRTELEFONE; set => _NRTELEFONE = value; }
        public string NMEMAIL { get => _NMEMAIL; set => _NMEMAIL = value; }
        public int IDENDERECO { get => _IDENDERECO; set => _IDENDERECO = value; }
        public string NMENDERECO { get => _NMENDERECO; set => _NMENDERECO = value; }
    }
}
