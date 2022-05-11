using SisTemTec.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Text;

namespace SisTemTec.Banco
{
    public class ManterObterDados
    {
        protected Conexao conexao = new Conexao();
        protected SqlCommand sqlcmd = new SqlCommand();
        protected CultureInfo cultureInfo = new CultureInfo(Constantes.Cultureinfo);
        protected SqlDataReader sqldr;
    }
}
