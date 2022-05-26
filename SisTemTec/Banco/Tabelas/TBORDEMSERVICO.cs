using System;
using System.Collections.Generic;
using System.Text;

namespace SisTemTec.Banco.Tabelas
{
    /// <summary>
    /// Tabela de cadastro de Ordem de Serviço
    /// </summary>
    public class TBORDEMSERVICO
    {
        private int _IDORDEMSERVICO;
        private int _IDEQUIPAMENTO;
        private int _IDTECNICO;
        private DateTime? _DTENTRADA;
        private DateTime? _DTSERVICO;
        private DateTime? _DTSAIDA;
        private string? _NMDESCRICAO;
        private decimal? _DCMAODEOBRA;
        private decimal? _DCVALORTOTAL;

        public TBORDEMSERVICO(int iDORDEMSERVICO, int iDEQUIPAMENTO, int iDTECNICO, DateTime? dTENTRADA, DateTime? dTSERVICO, DateTime? dTSAIDA, string nMDESCRICAO, decimal? dCMAODEOBRA, decimal? dCVALORTOTAL)
        {
            _IDORDEMSERVICO = iDORDEMSERVICO;
            _IDEQUIPAMENTO = iDEQUIPAMENTO;
            _IDTECNICO = iDTECNICO;
            _DTENTRADA = dTENTRADA;
            _DTSERVICO = dTSERVICO;
            _DTSAIDA = dTSAIDA;
            _NMDESCRICAO = nMDESCRICAO;
            _DCMAODEOBRA = dCMAODEOBRA;
            _DCVALORTOTAL = dCVALORTOTAL;
        }

        /// <summary>
        /// Primary Key
        /// </summary>
        public int IDORDEMSERVICO { get => _IDORDEMSERVICO; set => _IDORDEMSERVICO = value; }
        /// <summary>
        /// Foreign key - TBEQUIPAMENTO
        /// </summary>
        public int IDEQUIPAMENTO { get => _IDEQUIPAMENTO; set => _IDEQUIPAMENTO = value; }
        /// <summary>
        /// Foreign key - TBTECNICO
        /// </summary>
        public int IDTECNICO { get => _IDTECNICO; set => _IDTECNICO = value; }
        /// <summary>
        /// Data de entrada
        /// </summary>
        public DateTime? DTENTRADA { get => _DTENTRADA; set => _DTENTRADA = value; }
        /// <summary>
        /// Data de Serviço
        /// </summary>
        public DateTime? DTSERVICO { get => _DTSERVICO; set => _DTSERVICO = value; }
        /// <summary>
        /// Data de Saida do equipamento
        /// </summary>
        public DateTime? DTSAIDA { get => _DTSAIDA; set => _DTSAIDA = value; }
        /// <summary>
        /// Descrição do que foi feito no equipamento
        /// </summary>
        public string NMDESCRICAO { get => _NMDESCRICAO; set => _NMDESCRICAO = value; }
        /// <summary>
        /// Valor da mão de obra
        /// </summary>
        public decimal? DCMAODEOBRA { get => _DCMAODEOBRA; set => _DCMAODEOBRA = value; }
        /// <summary>
        /// Valor total
        /// </summary>
        public decimal? DCVALORTOTAL { get => _DCVALORTOTAL; set => _DCVALORTOTAL = value; }
    }
}
