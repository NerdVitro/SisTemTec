using System;
using System.Collections.Generic;
using System.Text;

namespace SisTemTec.Banco.Tabelas
{
    /// <summary>
    /// Tabela de cadastro de Tipo Produto
    /// </summary>
    public class TBTIPOPRODUTO
    {
        private int _IDTIPOPRODUTO;
        private string _NMDESCRICAO;

        public TBTIPOPRODUTO(int iDTIPOPRODUTO, string nMDESCRICAO)
        {
            _IDTIPOPRODUTO = iDTIPOPRODUTO;
            _NMDESCRICAO = nMDESCRICAO;
        }

        /// <summary>
        /// Primary Key
        /// </summary>
        public int IDTIPOPRODUTO { get => _IDTIPOPRODUTO; set => _IDTIPOPRODUTO = value; }
        /// <summary>
        /// Descrição do tipo de produto
        /// </summary>
        public string NMDESCRICAO { get => _NMDESCRICAO; set => _NMDESCRICAO = value; }
    }
}
