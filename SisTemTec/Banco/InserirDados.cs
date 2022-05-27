using SisTemTec.Banco.Tabelas;
using System;
using System.Collections.Generic;
using System.Text;

namespace SisTemTec.Banco
{
    public class InserirDados : ManterObterDados
    {
        public bool CadastrarEstado(TBESTADO estado)
        {
            try
            {
                if(estado.IDESTADO == 0)
                {
                    sqlcmd.CommandText =
                         @"INSERT INTO TBESTADO
                            (
	                            NMESTADO
	                            ,NMSIGLA
                            )VALUES 
                            (
	                            @NMESTADO
	                            ,@NMSIGLA
                            )";

                    sqlcmd.Parameters.Clear();
                    sqlcmd.Parameters.AddWithValue("@NMESTADO", estado.NMESTADO);
                    sqlcmd.Parameters.AddWithValue("@NMSIGLA", estado.NMSIGLA);
                }
                else
                {
                    sqlcmd.CommandText =
                         @"";

                    sqlcmd.Parameters.Clear();
                    sqlcmd.Parameters.AddWithValue("@NMESTADO", estado.NMESTADO);
                    sqlcmd.Parameters.AddWithValue("@NMSIGLA", estado.NMSIGLA);
                    sqlcmd.Parameters.AddWithValue("@IDESTADO", estado.IDESTADO);
                }


                sqlcmd.Connection = conexao.Conectar();
                return sqlcmd.ExecuteNonQuery() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexao.Desconectar();
            }
        }
    }
}
