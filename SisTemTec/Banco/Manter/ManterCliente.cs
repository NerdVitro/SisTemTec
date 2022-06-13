using System;
using System.Collections.Generic;
using System.Text;

namespace SisTemTec.Banco.Manter
{
    public class ManterCliente : ManterObterDados
    {
        public string Mansegem { get; set; }
        public bool TemMensagem { get => !Mansegem.Equals(""); }



    }
}
