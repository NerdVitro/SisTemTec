using System;
using System.Collections.Generic;
using System.Text;

namespace SisTemTec.Banco.Tabelas
{
    /// <summary>
    /// Tabela de cadastro de Produto
    /// </summary>
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

        /// <summary>
        /// Primary Key
        /// </summary>
        public int IDPRODUTO { get => _IDPRODUTO; set => _IDPRODUTO = value; }
        /// <summary>
        /// Foreign key - TIPOPRODUTO
        /// </summary>
        public int IDTIPOPRODUTO { get => _IDTIPOPRODUTO; set => _IDTIPOPRODUTO = value; }
        /// <summary>
        /// Foreign key - TBFORNECEDOR
        /// </summary>
        public int IDFORNECEDOR { get => _IDFORNECEDOR; set => _IDFORNECEDOR = value; }
        /// <summary>
        /// Quantidade de produtos
        /// </summary>
        public int DCQUANTIDADE { get => _DCQUANTIDADE; set => _DCQUANTIDADE = value; }
        /// <summary>
        /// Valor unitario de cada produto
        /// </summary>
        public decimal DCVALORUNITARIO { get => _DCVALORUNITARIO; set => _DCVALORUNITARIO = value; }
        /// <summary>
        /// Descrição do produto
        /// </summary>
        public string NMDESCRICAO { get => _NMDESCRICAO; set => _NMDESCRICAO = value; }
    }
}
