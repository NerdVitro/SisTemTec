using System;
using System.Collections.Generic;
using System.Text;

namespace SisTemTec.Banco.Tabelas
{
    /// <summary>
    /// Tabela de cadastro de Tecnico
    /// </summary>
    public class TBTECNICO
    {
        private int _IDTECNICO;
        private int _IDENDERECO;
        private int _NRCPF;
        private string _NMNOME;

        public TBTECNICO(int iDTECNICO, int iDENDERECO, int nRCPF, string nMNOME)
        {
            _IDTECNICO = iDTECNICO;
            _IDENDERECO = iDENDERECO;
            _NRCPF = nRCPF;
            _NMNOME = nMNOME;
        }

        /// <summary>
        /// Primary Key
        /// </summary>
        public int IDTECNICO { get => _IDTECNICO; set => _IDTECNICO = value; }
        /// <summary>
        /// Foreign key - TBENDERECO
        /// </summary>
        public int IDENDERECO { get => _IDENDERECO; set => _IDENDERECO = value; }
        /// <summary>
        /// Numero do Cpf
        /// </summary>
        public int NRCPF { get => _NRCPF; set => _NRCPF = value; }
        /// <summary>
        /// Nome do tecnico
        /// </summary>
        public string NMNOME { get => _NMNOME; set => _NMNOME = value; }
    }
}
