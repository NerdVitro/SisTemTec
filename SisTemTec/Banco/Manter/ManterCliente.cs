using SisTemTec.Banco.Tabelas;
using SisTemTec.Classes.BOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SisTemTec.Banco.Manter
{
    public class ManterCliente : ManterObterDados
    {
        public string Mansegem { get; set; }
        public bool TemMensagem { get => !Mansegem.Equals(""); }

        public DataTable GetCliente(string parNMNOME)
        {
            sqldr = null;
            try
            {
                DataTable Dados = new DataTable();
                sqlcmd.CommandText =
                     @" SELECT CLI.IDCLIENTE 
                                ,CLI.NMNOME
                                ,CLI.NRTELEFONE
		                        ,CID.NMCIDADE
		                        ,BAI.NMBAIRRO
                        FROM TBCLIENTE AS CLI
                        INNER JOIN TBENDERECO ECO ON ECO.IDENDERECO = CLI.IDENDERECO
                        INNER JOIN TBBAIRRO BAI ON BAI.IDBAIRRO = ECO.IDBAIRRO
                        INNER JOIN TBCIDADE CID ON CID.IDCIDADE = BAI.IDCIDADE
                            WHERE 1 = 1";

                if (!string.IsNullOrEmpty(parNMNOME))
                {
                    sqlcmd.CommandText += " AND CLI.NMNOME LIKE @NMNOME ";
                }

                sqlcmd.Parameters.Clear();

                if (!string.IsNullOrEmpty(parNMNOME))
                {
                    sqlcmd.Parameters.AddWithValue("@NMNOME", "%" + parNMNOME + "%");
                }

                sqlcmd.Connection = conexao.Conectar();
                sqldr = sqlcmd.ExecuteReader();

                if (sqldr.HasRows)
                {
                    Dados.Columns.Clear();
                    Dados.Columns.Add("IDCLIENTE", typeof(int));
                    Dados.Columns.Add("NMNOME", typeof(string));
                    Dados.Columns.Add("NMCIDADE", typeof(string));
                    Dados.Columns.Add("NMBAIRRO", typeof(string));
                    Dados.Columns.Add("NRTELEFONE", typeof(Int64));

                    while (sqldr.Read())
                    {
                        Dados.Rows.Add
                        (
                            sqldr["IDCLIENTE"] == DBNull.Value ? 0 : Convert.ToInt32(sqldr["IDCLIENTE"], cultureInfo),
                            sqldr["NMNOME"] == DBNull.Value ? "" : Convert.ToString(sqldr["NMNOME"], cultureInfo),
                            sqldr["NMCIDADE"] == DBNull.Value ? "" : Convert.ToString(sqldr["NMCIDADE"], cultureInfo),
                            sqldr["NMBAIRRO"] == DBNull.Value ? "" : Convert.ToString(sqldr["NMBAIRRO"], cultureInfo),
                            sqldr["NRTELEFONE"] == DBNull.Value ? 0 : Convert.ToInt64(sqldr["NRTELEFONE"], cultureInfo)
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
        public ClienteBO GetClienteById(int parIDCLIENTE)
        {
            sqldr = null;
            try
            {
                ClienteBO objRetornoCliente = new ClienteBO();

                sqlcmd.CommandText =
                     @" SELECT CLI.IDCLIENTE 
                                ,CLI.IDENDERECO
                                ,CLI.NRCPFCNPJ
                                ,CLI.NMNOME
                                ,CLI.NMNOMERAZAO
                                ,CLI.NRTELEFONE
                                ,CLI.NMEMAIL
		                        ,CID.NMCIDADE
		                        ,BAI.NMBAIRRO
		                        ,ECO.NRNUMERO
                        FROM TBCLIENTE AS CLI
                        INNER JOIN TBENDERECO ECO ON ECO.IDENDERECO = CLI.IDENDERECO
                        INNER JOIN TBBAIRRO BAI ON BAI.IDBAIRRO = ECO.IDBAIRRO
                        INNER JOIN TBCIDADE CID ON CID.IDCIDADE = BAI.IDCIDADE
                            WHERE CLI.IDCLIENTE = @IDCLIENTE ";

                sqlcmd.Parameters.Clear();
                sqlcmd.Parameters.AddWithValue("@IDCLIENTE", parIDCLIENTE);

                sqlcmd.Connection = conexao.Conectar();
                sqldr = sqlcmd.ExecuteReader();

                if (sqldr.HasRows && sqldr.Read())
                {
                    objRetornoCliente = new ClienteBO
                        (
                            sqldr["IDCLIENTE"] == DBNull.Value ? 0 : Convert.ToInt32(sqldr["IDCLIENTE"], cultureInfo),
                            sqldr["NRCPFCNPJ"] == DBNull.Value ? 0 : Convert.ToInt64(sqldr["NRCPFCNPJ"], cultureInfo),
                            sqldr["NMNOME"] == DBNull.Value ? "" : Convert.ToString(sqldr["NMNOME"], cultureInfo),
                            sqldr["NMNOMERAZAO"] == DBNull.Value ? "" : Convert.ToString(sqldr["NMNOMERAZAO"], cultureInfo),
                            sqldr["NRTELEFONE"] == DBNull.Value ? 0 : Convert.ToInt64(sqldr["NRTELEFONE"], cultureInfo),
                            sqldr["NMEMAIL"] == DBNull.Value ? "" : Convert.ToString(sqldr["NMEMAIL"], cultureInfo),
                            sqldr["IDENDERECO"] == DBNull.Value ? 0 : Convert.ToInt32(sqldr["IDENDERECO"], cultureInfo),
                            (
                                (sqldr["NMCIDADE"] == DBNull.Value ? "" : Convert.ToString(sqldr["NMCIDADE"], cultureInfo)) + " " +
                                (sqldr["NMBAIRRO"] == DBNull.Value ? "" : Convert.ToString(sqldr["NMBAIRRO"], cultureInfo)) + " " +
                                (sqldr["NRNUMERO"] == DBNull.Value ? 0 : Convert.ToInt32(sqldr["NRNUMERO"], cultureInfo))
                            )
                        );
                }
                return objRetornoCliente;
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

        public bool SalvarCliente(ClienteBO parClienteBO)
        {
            try
            {
                if (ValidarCliente(parClienteBO))
                {
                    return false;
                }

                if (parClienteBO.IDCLIENTE == 0)
                {
                    sqlcmd.CommandText =
                         @" INSERT INTO TBCLIENTE
                            (
	                            IDENDERECO
	                            ,NRCPFCNPJ
	                            ,NMNOME
	                            ,NMNOMERAZAO
	                            ,NRTELEFONE
	                            ,NMEMAIL
                            )VALUES 
                            (
	                            @IDENDERECO
	                            ,@NRCPFCNPJ
	                            ,@NMNOME
	                            ,@NMNOMERAZAO
	                            ,@NRTELEFONE
	                            ,@NMEMAIL
                            )";

                    sqlcmd.Parameters.Clear();
                    sqlcmd.Parameters.AddWithValue("@IDENDERECO", parClienteBO.IDENDERECO);
                    sqlcmd.Parameters.AddWithValue("@NRCPFCNPJ", parClienteBO.NRCPFCNPJ);
                    sqlcmd.Parameters.AddWithValue("@NMNOME", parClienteBO.NMNOME);
                    sqlcmd.Parameters.AddWithValue("@NMNOMERAZAO", parClienteBO.NMNOMERAZAO);
                    sqlcmd.Parameters.AddWithValue("@NRTELEFONE", parClienteBO.NRTELEFONE);
                    sqlcmd.Parameters.AddWithValue("@NMEMAIL", parClienteBO.NMEMAIL);
                }
                else
                {
                    sqlcmd.CommandText =
                         @" UPDATE TBCLIENTE SET
                                IDENDERECO = @IDENDERECO
                                ,NRCPFCNPJ = @NRCPFCNPJ
                                ,NMNOME = @NMNOME
                                ,NMNOMERAZAO = @NMNOMERAZAO
                                ,NRTELEFONE = @NRTELEFONE
                                ,NMEMAIL = @NMEMAIL
                            WHERE IDCLIENTE = @IDCLIENTE ";

                    sqlcmd.Parameters.Clear();
                    sqlcmd.Parameters.AddWithValue("@IDENDERECO", parClienteBO.IDENDERECO);
                    sqlcmd.Parameters.AddWithValue("@NRCPFCNPJ", parClienteBO.NRCPFCNPJ);
                    sqlcmd.Parameters.AddWithValue("@NMNOME", parClienteBO.NMNOME);
                    sqlcmd.Parameters.AddWithValue("@NMNOMERAZAO", parClienteBO.NMNOMERAZAO);
                    sqlcmd.Parameters.AddWithValue("@NRTELEFONE", parClienteBO.NRTELEFONE);
                    sqlcmd.Parameters.AddWithValue("@NMEMAIL", parClienteBO.NMEMAIL);
                    sqlcmd.Parameters.AddWithValue("@IDCLIENTE", parClienteBO.IDCLIENTE);
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
        private bool ValidarCliente(ClienteBO parClienteBO)
        {
            try
            {
                Mansegem = "";
                string obrigatorio = " É Obrigatório.\n";

                if (parClienteBO.NRCPFCNPJ.ToString().Length == 9 && parClienteBO.NMNOMERAZAO == "")
                {
                    Mansegem = "Nome Razão" + obrigatorio;
                }
                if (parClienteBO.NMNOME == "")
                {
                    Mansegem = "Nome" + obrigatorio;
                }
                if (parClienteBO.NMEMAIL == "")
                {
                    Mansegem = "Email" + obrigatorio;
                }
                if (parClienteBO.NMENDERECO == "")
                {
                    Mansegem = "Endereço" + obrigatorio;
                }

                if (Mansegem != "")
                {
                    return true;
                }

                if (ValidarNomeCliente(parClienteBO))
                {
                    return true;
                }
                else if (parClienteBO.NMNOMERAZAO != "" && ValidarNomeRazaoCliente(parClienteBO))
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

        private bool ValidarNomeCliente(ClienteBO parClienteBO)
        {
            sqldr = null;
            try
            {
                sqlcmd.CommandText = @" SELECT IDCLIENTE
                                        FROM TBCLIENTE
                                        WHERE NMNOME = @NMNOME 
                                        AND IDCLIENTE <> @IDCLIENTE ";
                sqlcmd.Parameters.Clear();
                sqlcmd.Parameters.AddWithValue("@NMNOME", parClienteBO.NMNOME);
                sqlcmd.Parameters.AddWithValue("@IDCLIENTE", parClienteBO.IDCLIENTE);

                sqlcmd.Connection = conexao.Conectar();
                sqldr = sqlcmd.ExecuteReader();

                if (sqldr.HasRows && sqldr.Read())
                {
                    Mansegem = "Nome Cliente já cadastrado";
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
        private bool ValidarNomeRazaoCliente(ClienteBO parClienteBO)
        {
            sqldr = null;
            try
            {
                sqlcmd.CommandText = @" SELECT IDCLIENTE
                                        FROM TBCLIENTE
                                        WHERE NMNOMERAZAO = @NMNOMERAZAO 
                                        AND IDCLIENTE <> @IDCLIENTE ";
                sqlcmd.Parameters.Clear();
                sqlcmd.Parameters.AddWithValue("@NMNOMERAZAO", parClienteBO.NMNOMERAZAO);
                sqlcmd.Parameters.AddWithValue("@IDCLIENTE", parClienteBO.IDCLIENTE);

                sqlcmd.Connection = conexao.Conectar();
                sqldr = sqlcmd.ExecuteReader();

                if (sqldr.HasRows && sqldr.Read())
                {
                    Mansegem = "Nome Razão já cadastrado";
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
    }
}
