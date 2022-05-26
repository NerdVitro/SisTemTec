using System;
using System.Collections.Generic;
using System.Text;

namespace SisTemTec.Banco.Tabelas
{
    /// <summary>
    /// Tabela de cadastro de Cliente
    /// </summary>
    public class TBCLIENTE
    {
        private int _IDCLIENTE;
        private int _IDENDERECO;
        private int _NRCPFCNPJ;
        private string _NMNOME;
        private string _NMNOMERAZAO;
        private int _NRTELEFONE;
        private string _NMEMAIL;

        public TBCLIENTE(int iDCLIENTE, int iDENDERECO, int nRCPFCNPJ, string nMNOME, string nMNOMERAZAO, int nRTELEFONE, string nMEMAIL)
        {
            _IDCLIENTE = iDCLIENTE;
            _IDENDERECO = iDENDERECO;
            _NRCPFCNPJ = nRCPFCNPJ;
            _NMNOME = nMNOME;
            _NMNOMERAZAO = nMNOMERAZAO;
            _NRTELEFONE = nRTELEFONE;
            _NMEMAIL = nMEMAIL;
        }

        /// <summary>
        /// Primary Key
        /// </summary>
        public int IDCLIENTE { get => _IDCLIENTE; set => _IDCLIENTE = value; }
        /// <summary>
        /// Foreign key - TBENDERECO
        /// </summary>
        public int IDENDERECO { get => _IDENDERECO; set => _IDENDERECO = value; }
        /// <summary>
        /// Numero do cnpj ou do cpf do cliente
        /// </summary>
        public int NRCPFCNPJ { get => _NRCPFCNPJ; set => _NRCPFCNPJ = value; }
        /// <summary>
        /// Nome completo do cliente
        /// </summary>
        public string NMNOME { get => _NMNOME; set => _NMNOME = value; }
        /// <summary>
        /// Se cliente for uma empresa aqui sera o nome da empresa
        /// </summary>
        public string NMNOMERAZAO { get => _NMNOMERAZAO; set => _NMNOMERAZAO = value; }
        /// <summary>
        /// Numero do telefone do cliente
        /// </summary>
        public int NRTELEFONE { get => _NRTELEFONE; set => _NRTELEFONE = value; }
        /// <summary>
        /// Email do cliente
        /// </summary>
        public string NMEMAIL { get => _NMEMAIL; set => _NMEMAIL = value; }
    }
}
