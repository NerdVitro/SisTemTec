using SisTemTec.Banco.Tabelas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace SisTemTec.Banco.Manter
{
    public class ManterEstado : ManterObterDados
    {
        public string Mansegem { get; set; }
        public bool TemMensagem { get => !Mansegem.Equals(""); }

        public bool CadastrarEstado(TBESTADO estado)
        {
            try
            {
                if (ValidarEstado(estado))
                {
                    return false;
                }

                if (estado.IDESTADO == 0)
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
                         @" UPDATE TBESTADO SET
                                NMESTADO = @NMESTADO
                                ,NMSIGLA = @NMSIGLA
                            WHERE IDESTADO = @IDESTADO ";

                    sqlcmd.Parameters.Clear();
                    sqlcmd.Parameters.AddWithValue("@NMESTADO", estado.NMESTADO);
                    sqlcmd.Parameters.AddWithValue("@NMSIGLA", estado.NMSIGLA);
                    sqlcmd.Parameters.AddWithValue("@IDESTADO", estado.IDESTADO);
                }

                sqlcmd.Connection = conexao.Conectar();
                return sqlcmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                Mansegem = ex.Message;
                return false;
            }
            finally
            {
                conexao.Desconectar();
            }
        }
        private bool ValidarEstado(TBESTADO estado)
        {
            try
            {
                if(ValidarNomeEstado(estado))
                {
                    return true;
                }
                else if (ValidarSiglaEstado(estado))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private bool ValidarNomeEstado(TBESTADO estado)
        {
            sqldr = null;
            try
            {
                sqlcmd.CommandText = @" SELECT IDESTADO
                                        FROM TBESTADO
                                        WHERE NMESTADO = @NMESTADO 
                                        AND IDESTADO <> @IDESTADO ";
                sqlcmd.Parameters.Clear();
                sqlcmd.Parameters.AddWithValue("@NMESTADO", estado.NMESTADO);
                sqlcmd.Parameters.AddWithValue("@IDESTADO", estado.IDESTADO);

                sqlcmd.Connection = conexao.Conectar();
                sqldr = sqlcmd.ExecuteReader();

                if (sqldr.HasRows && sqldr.Read())
                {
                    Mansegem = "Nome estado já cadastrado";
                    return true;
                }
                else
                {
                    return false;
                }
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
        private bool ValidarSiglaEstado(TBESTADO estado)
        {
            sqldr = null;
            try
            {
                sqlcmd.CommandText = @" SELECT IDESTADO
                                        FROM TBESTADO
                                        WHERE NMSIGLA = @NMSIGLA 
                                        AND IDESTADO <> @IDESTADO ";
                sqlcmd.Parameters.Clear();
                sqlcmd.Parameters.AddWithValue("@NMSIGLA", estado.NMSIGLA);
                sqlcmd.Parameters.AddWithValue("@IDESTADO", estado.IDESTADO);

                sqlcmd.Connection = conexao.Conectar();
                sqldr = sqlcmd.ExecuteReader();

                if (sqldr.HasRows && sqldr.Read())
                {
                    Mansegem = "Sigla estado já cadastrado";
                    return true;
                }
                else
                {
                    return false;
                }
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
            sqldr = null;
            try
            {
                DataTable Dados = null;

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
                    Dados = new DataTable();
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
            sqldr = null;
            try
            {
                TBESTADO estado = null;

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
