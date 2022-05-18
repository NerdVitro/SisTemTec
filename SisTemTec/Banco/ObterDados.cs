using SisTemTec.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Text;

namespace SisTemTec.Banco
{
    public class ObterDados : ManterObterDados
    {
        public bool ValidarUsuario(string parUsu, string parSen)
        {
            sqldr = null;
            try
            {
                sqlcmd.CommandText =
                     @" SELECT NMSENHA 
                        FROM TBTECNICO 
                            WHERE NMUSUARIO = @NMUSUARIO ";

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
