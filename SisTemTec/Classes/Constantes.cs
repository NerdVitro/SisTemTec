using System;
using System.Collections.Generic;
using System.Text;

namespace SisTemTec.Classes
{
    public class Constantes
    {
        public const string NomeBanco = "BD_SistemTec";
        public const string NomeMaquina = @"DESKTOP-8C0QSSV\SQLEXPRESS";
        public const string ConnectionString = "Data Source="+ NomeMaquina + ";Initial Catalog="+ NomeBanco + ";Integrated Security=True";

        public const string Cultureinfo = "pt-BR";

        public const int Ativo = 1;
        public const int Inativo = 0;
    }
}
