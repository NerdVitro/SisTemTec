using SisTemTec.Banco.Tabelas;
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
            try
            {
                sqldr = null;
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

        public DataTable GetEstados(string parNMESTADO, string parNMSIGLA)
        {
            try
            {
                DataTable Dados = new DataTable();

                sqldr = null;
                sqlcmd.CommandText =
                     @" SELECT EST.IDESTADO 
                                ,EST.NMESTADO
                                ,EST.NMSIGLA
                        FROM TBESTADO AS EST
                            WHERE 1 = 1 ";

                if (!string.IsNullOrEmpty(parNMESTADO))
                {
                    sqlcmd.CommandText += " AND EST.NMESTADO LIKE @NMESTADO ";
                }
                if (!string.IsNullOrEmpty(parNMSIGLA))
                {
                    sqlcmd.CommandText += " AND EST.NMSIGLA LIKE @NMSIGLA ";
                }

                sqlcmd.Parameters.Clear();

                if (!string.IsNullOrEmpty(parNMESTADO))
                {
                    sqlcmd.Parameters.AddWithValue("@NMESTADO", "%" + parNMESTADO + "%");
                }
                if (!string.IsNullOrEmpty(parNMSIGLA))
                {
                    sqlcmd.Parameters.AddWithValue("@NMSIGLA", "%" + parNMSIGLA + "%");
                }

                sqlcmd.Connection = conexao.Conectar();
                sqldr = sqlcmd.ExecuteReader();

                if (sqldr.HasRows)
                {
                    Dados.Columns.Clear();
                    Dados.Columns.Add("IDESTADO", typeof(int));
                    Dados.Columns.Add("NMESTADO", typeof(string));
                    Dados.Columns.Add("NMSIGLA", typeof(string));

                    while (sqldr.Read())
                    {
                        Dados.Rows.Add
                        (
                            sqldr["IDESTADO"] == DBNull.Value ? 0 : Convert.ToInt32(sqldr["IDESTADO"], cultureInfo),
                            sqldr["NMESTADO"] == DBNull.Value ? "" : Convert.ToString(sqldr["NMESTADO"], cultureInfo),
                            sqldr["NMSIGLA"] == DBNull.Value ? "" : Convert.ToString(sqldr["NMSIGLA"], cultureInfo)
                        );
                    }
                }
                return Dados;
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
        public TBESTADO GetEstadoById(int parIDESTADO)
        {
            try
            {
                TBESTADO estado = null;

                sqldr = null;
                sqlcmd.CommandText =
                     @" SELECT EST.IDESTADO 
                                ,EST.NMESTADO
                                ,EST.NMSIGLA
                        FROM TBESTADO AS EST
                            WHERE EST.IDESTADO = @IDESTADO ";

                sqlcmd.Parameters.Clear();
                sqlcmd.Parameters.AddWithValue("@IDESTADO", parIDESTADO);

                sqlcmd.Connection = conexao.Conectar();
                sqldr = sqlcmd.ExecuteReader();

                if (sqldr.HasRows && sqldr.Read())
                {
                    estado = new TBESTADO
                        (
                            sqldr["IDESTADO"] == DBNull.Value ? 0 : Convert.ToInt32(sqldr["IDESTADO"], cultureInfo),
                            sqldr["NMESTADO"] == DBNull.Value ? "" : Convert.ToString(sqldr["NMESTADO"], cultureInfo),
                            sqldr["NMSIGLA"] == DBNull.Value ? "" : Convert.ToString(sqldr["NMSIGLA"], cultureInfo)
                        );
                }
                return estado;
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
