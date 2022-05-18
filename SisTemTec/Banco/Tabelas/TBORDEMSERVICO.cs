using System;
using System.Collections.Generic;
using System.Text;

namespace SisTemTec.Banco.Tabelas
{
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

        public int IDORDEMSERVICO { get => _IDORDEMSERVICO; set => _IDORDEMSERVICO = value; }
        public int IDEQUIPAMENTO { get => _IDEQUIPAMENTO; set => _IDEQUIPAMENTO = value; }
        public int IDTECNICO { get => _IDTECNICO; set => _IDTECNICO = value; }
        public DateTime? DTENTRADA { get => _DTENTRADA; set => _DTENTRADA = value; }
        public DateTime? DTSERVICO { get => _DTSERVICO; set => _DTSERVICO = value; }
        public DateTime? DTSAIDA { get => _DTSAIDA; set => _DTSAIDA = value; }
        public string NMDESCRICAO { get => _NMDESCRICAO; set => _NMDESCRICAO = value; }
        public decimal? DCMAODEOBRA { get => _DCMAODEOBRA; set => _DCMAODEOBRA = value; }
        public decimal? DCVALORTOTAL { get => _DCVALORTOTAL; set => _DCVALORTOTAL = value; }
    }
}
