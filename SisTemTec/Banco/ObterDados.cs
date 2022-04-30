using SisTemTec.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Text;

namespace SisTemTec.Banco
{
    public class ObterDados
    {
        readonly private Conexao conexao = new Conexao();
        readonly private SqlCommand sqlcmd = new SqlCommand();
        readonly private CultureInfo cultureInfo = new CultureInfo(Constantes.Cultureinfo);
        private SqlDataReader sqldr;

        public bool Usuario(string parUsu, string parSen)
        {
            sqldr = null;
            try
            {
                sqlcmd.CommandText =
                    @" SELECT NMSENHA FROM TBTESTEUSU WHERE NMUSUARIO = @NMUSUARIO";

                sqlcmd.Parameters.Clear();
                sqlcmd.Parameters.AddWithValue("@NMUSUARIO", parUsu);

                sqlcmd.Connection = conexao.Conectar();
                sqldr = sqlcmd.ExecuteReader();

                if (sqldr.HasRows && sqldr.Read())
                {
                    return ((sqldr["NMSENHA"] == DBNull.Value ? "" : Convert.ToString(sqldr["NMSENHA"], cultureInfo)).Equals(parSen));
                }
                return false;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                sqldr?.Close();
                conexao.Desconectar();
            }
        }
    }
}
