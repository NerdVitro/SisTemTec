using System;
using System.Collections.Generic;
using System.Text;

namespace SisTemTec.Banco.Tabelas
{
    /// <summary>
    /// Tabela de cadastro de Fornecedor
    /// </summary>
    public class TBFORNECEDOR
    {
        private int _IDFORNECEDOR;
        private int _IDENDERECO;
        private int _NRCNPJ;
        private string _NMNOME;
        private string _NMNOMERAZAO;
        private int _NRTELEFONE;
        private string _NMEMAIL;

        public TBFORNECEDOR(int iDFORNECEDOR, int iDENDERECO, int nRCNPJ, string nMNOME, string nMNOMERAZAO, int nRTELEFONE, string nMEMAIL)
        {
            _IDFORNECEDOR = iDFORNECEDOR;
            _IDENDERECO = iDENDERECO;
            _NRCNPJ = nRCNPJ;
            _NMNOME = nMNOME;
            _NMNOMERAZAO = nMNOMERAZAO;
            _NRTELEFONE = nRTELEFONE;
            _NMEMAIL = nMEMAIL;
        }

        /// <summary>
        /// Primary Key
        /// </summary>
        public int IDFORNECEDOR { get => _IDFORNECEDOR; set => _IDFORNECEDOR = value; }
        /// <summary>
        /// Foreign key - TBENDERECO
        /// </summary>
        public int IDENDERECO { get => _IDENDERECO; set => _IDENDERECO = value; }
        /// <summary>
        /// CNPJ do Fornecedor
        /// </summary>
        public int NRCNPJ { get => _NRCNPJ; set => _NRCNPJ = value; }
        /// <summary>
        /// Nome do Fornecedor
        /// </summary>
        public string NMNOME { get => _NMNOME; set => _NMNOME = value; }
        /// <summary>
        /// Nome Razão  do fornecedor
        /// </summary>
        public string NMNOMERAZAO { get => _NMNOMERAZAO; set => _NMNOMERAZAO = value; }
        /// <summary>
        /// Numero de telefone do Fornecedor
        /// </summary>
        public int NRTELEFONE { get => _NRTELEFONE; set => _NRTELEFONE = value; }
        /// <summary>
        /// Email do Fornecedor
        /// </summary>
        public string NMEMAIL { get => _NMEMAIL; set => _NMEMAIL = value; }
    }
}
