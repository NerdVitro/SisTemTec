using System;
using System.Collections.Generic;
using System.Text;

namespace SisTemTec.Banco.Tabelas
{
    /// <summary>
    /// Tabela de cadastro de Estado
    /// </summary>
    public class TBESTADO
    {
        private int _IDESTADO;
        private string _NMESTADO;
        private string _NMSIGLA;

        public TBESTADO(int iDESTADO, string nMESTADO, string nMSIGLA)
        {
            _IDESTADO = iDESTADO;
            _NMESTADO = nMESTADO;
            _NMSIGLA = nMSIGLA;
        }

        /// <summary>
        /// Primary Key
        /// </summary>
        public int IDESTADO { get => _IDESTADO; set => _IDESTADO = value; }
        /// <summary>
        /// Nome do Estado
        /// </summary>
        public string NMESTADO { get => _NMESTADO; set => _NMESTADO = value; }
        public string NMSIGLA { get => _NMSIGLA; set => _NMSIGLA = value; }
    }
}
