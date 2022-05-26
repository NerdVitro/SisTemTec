using System;
using System.Collections.Generic;
using System.Text;

namespace SisTemTec.Banco.Tabelas
{
    /// <summary>
    /// Tabela de cadastro de Produto Ordem Serviço
    /// </summary>
    public class TBPRODUTOSERVICO
    {
        private int _IDPRODUTOSERVICO;
        private int _IDPRODUTO;
        private int _IDORDEMSERVICO;

        public TBPRODUTOSERVICO(int iDPRODUTOSERVICO, int iDPRODUTO, int iDORDEMSERVICO)
        {
            _IDPRODUTOSERVICO = iDPRODUTOSERVICO;
            _IDPRODUTO = iDPRODUTO;
            _IDORDEMSERVICO = iDORDEMSERVICO;
        }

        /// <summary>
        /// Primary Key
        /// </summary>
        public int IDPRODUTOSERVICO { get => _IDPRODUTOSERVICO; set => _IDPRODUTOSERVICO = value; }
        /// <summary>
        /// Foreign key - TBPRODUTO
        /// </summary>
        public int IDPRODUTO { get => _IDPRODUTO; set => _IDPRODUTO = value; }
        /// <summary>
        /// Foreign key - TBORDEMSERVICO
        /// </summary>
        public int IDORDEMSERVICO { get => _IDORDEMSERVICO; set => _IDORDEMSERVICO = value; }
    }
}
