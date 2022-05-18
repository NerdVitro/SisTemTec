using System;
using System.Collections.Generic;
using System.Text;

namespace SisTemTec.Banco.Tabelas
{
    public class TBPRODUTO
    {
        private int _IDPRODUTO;
        private int _IDTIPOPRODUTO;
        private int _IDFORNECEDOR;
        private int _DCQUANTIDADE;
        private decimal _DCVALORUNITARIO;
        private string _NMDESCRICAO;

        public TBPRODUTO(int iDPRODUTO, int iDTIPOPRODUTO, int iDFORNECEDOR, int dCQUANTIDADE, decimal dCVALORUNITARIO, string nMDESCRICAO)
        {
            _IDPRODUTO = iDPRODUTO;
            _IDTIPOPRODUTO = iDTIPOPRODUTO;
            _IDFORNECEDOR = iDFORNECEDOR;
            _DCQUANTIDADE = dCQUANTIDADE;
            _DCVALORUNITARIO = dCVALORUNITARIO;
            _NMDESCRICAO = nMDESCRICAO;
        }

        public int IDPRODUTO { get => _IDPRODUTO; set => _IDPRODUTO = value; }
        public int IDTIPOPRODUTO { get => _IDTIPOPRODUTO; set => _IDTIPOPRODUTO = value; }
        public int IDFORNECEDOR { get => _IDFORNECEDOR; set => _IDFORNECEDOR = value; }
        public int DCQUANTIDADE { get => _DCQUANTIDADE; set => _DCQUANTIDADE = value; }
        public decimal DCVALORUNITARIO { get => _DCVALORUNITARIO; set => _DCVALORUNITARIO = value; }
        public string NMDESCRICAO { get => _NMDESCRICAO; set => _NMDESCRICAO = value; }
    }
}
