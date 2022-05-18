using System;
using System.Collections.Generic;
using System.Text;

namespace SisTemTec.Banco.Tabelas
{
    public class TBBAIRRO
    {
        private int _IDBAIRRO;
        private int _IDCIDADE;
        private string _NMBAIRRO;

        public TBBAIRRO(int iDBAIRRO, int iDCIDADE, string nMBAIRRO)
        {
            _IDBAIRRO = iDBAIRRO;
            _IDCIDADE = iDCIDADE;
            _NMBAIRRO = nMBAIRRO;
        }

        public int IDBAIRRO { get => _IDBAIRRO; set => _IDBAIRRO = value; }
        public int IDCIDADE { get => _IDCIDADE; set => _IDCIDADE = value; }
        public string NMBAIRRO { get => _NMBAIRRO; set => _NMBAIRRO = value; }
    }
}
