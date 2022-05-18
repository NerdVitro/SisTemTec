using System;
using System.Collections.Generic;
using System.Text;

namespace SisTemTec.Banco.Tabelas
{
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

        public int IDTECNICO { get => _IDTECNICO; set => _IDTECNICO = value; }
        public int IDENDERECO { get => _IDENDERECO; set => _IDENDERECO = value; }
        public int NRCPF { get => _NRCPF; set => _NRCPF = value; }
        public string NMNOME { get => _NMNOME; set => _NMNOME = value; }
    }
}
