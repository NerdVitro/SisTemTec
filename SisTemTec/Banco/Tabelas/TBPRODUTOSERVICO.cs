using System;
using System.Collections.Generic;
using System.Text;

namespace SisTemTec.Banco.Tabelas
{
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

        public int IDPRODUTOSERVICO { get => _IDPRODUTOSERVICO; set => _IDPRODUTOSERVICO = value; }
        public int IDPRODUTO { get => _IDPRODUTO; set => _IDPRODUTO = value; }
        public int IDORDEMSERVICO { get => _IDORDEMSERVICO; set => _IDORDEMSERVICO = value; }
    }
}
