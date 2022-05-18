using System;
using System.Collections.Generic;
using System.Text;

namespace SisTemTec.Banco.Tabelas
{
    public class TBENDERECO
    {
        private int _IDENDERECO;
        private int _IDBAIRRO;
        private int _NRNUMERO;
        private string _NMRUA;
        private string _NMCOMPLEMENTO;

        public TBENDERECO(int iDENDERECO, int iDBAIRRO, int nRNUMERO, string nMRUA, string nMCOMPLEMENTO)
        {
            _IDENDERECO = iDENDERECO;
            _IDBAIRRO = iDBAIRRO;
            _NRNUMERO = nRNUMERO;
            _NMRUA = nMRUA;
            _NMCOMPLEMENTO = nMCOMPLEMENTO;
        }

        public int IDENDERECO { get => _IDENDERECO; set => _IDENDERECO = value; }
        public int IDBAIRRO { get => _IDBAIRRO; set => _IDBAIRRO = value; }
        public int NRNUMERO { get => _NRNUMERO; set => _NRNUMERO = value; }
        public string NMRUA { get => _NMRUA; set => _NMRUA = value; }
        public string NMCOMPLEMENTO { get => _NMCOMPLEMENTO; set => _NMCOMPLEMENTO = value; }
    }
}
