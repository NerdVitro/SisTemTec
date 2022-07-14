using System;
using System.Collections.Generic;
using System.Text;

namespace SisTemTec.Classes.BOs
{
    public class FornecedorBO
    {
        private int _IDFORNECEDOR;
        private Int64 _NRCNPJ;
        private string _NMNOME;
        private string _NMNOMERAZAO;
        private Int64 _NRTELEFONE;
        private string _NMEMAIL;
        private int _IDENDERECO;
        private string _NMENDERECO;

        public FornecedorBO(int iDFORNECEDOR, long nRCPFCNPJ, string nMNOME, string nMNOMERAZAO, long nRTELEFONE, string nMEMAIL, int iDENDERECO, string nMENDERECO)
        {
            _IDFORNECEDOR = iDFORNECEDOR;
            _NRCNPJ = nRCPFCNPJ;
            _NMNOME = nMNOME;
            _NMNOMERAZAO = nMNOMERAZAO;
            _NRTELEFONE = nRTELEFONE;
            _NMEMAIL = nMEMAIL;
            _IDENDERECO = iDENDERECO;
            _NMENDERECO = nMENDERECO;
        }

        public FornecedorBO()
        {

        }

        public int IDFORNECEDOR { get => _IDFORNECEDOR; set => _IDFORNECEDOR = value; }
        public long NRCNPJ { get => _NRCNPJ; set => _NRCNPJ = value; }
        public string NMNOME { get => _NMNOME; set => _NMNOME = value; }
        public string NMNOMERAZAO { get => _NMNOMERAZAO; set => _NMNOMERAZAO = value; }
        public long NRTELEFONE { get => _NRTELEFONE; set => _NRTELEFONE = value; }
        public string NMEMAIL { get => _NMEMAIL; set => _NMEMAIL = value; }
        public int IDENDERECO { get => _IDENDERECO; set => _IDENDERECO = value; }
        public string NMENDERECO { get => _NMENDERECO; set => _NMENDERECO = value; }
    }
}
