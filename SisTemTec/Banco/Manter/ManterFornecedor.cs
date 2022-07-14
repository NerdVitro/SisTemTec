using SisTemTec.Classes.BOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SisTemTec.Banco.Manter
{
    public class ManterFornecedor : ManterObterDados
    {
        public string Mansegem { get; set; }
        public bool TemMensagem { get => !Mansegem.Equals(""); }

        public DataTable GetFornecedor(string parNMNOME)
        {
            sqldr = null;
            try
            {
                DataTable Dados = new DataTable();
                sqlcmd.CommandText =
                     @" SELECT FORN.IDFORNECEDOR
		                        ,FORN.NRCNPJ
		                        ,FORN.NMNOME
		                        ,FORN.NMNOMERAZAO
		                        ,FORN.NRTELEFONE
		                        ,FORN.NMEMAIL
		                        ,FORN.IDENDERECO
		                        ,CID.NMCIDADE
		                        ,BAI.NMBAIRRO
                        FROM TBFORNECEDOR FORN
                        INNER JOIN TBENDERECO ECO ON ECO.IDENDERECO = FORN.IDENDERECO
                        INNER JOIN TBBAIRRO BAI ON BAI.IDBAIRRO = ECO.IDBAIRRO
                        INNER JOIN TBCIDADE CID ON CID.IDCIDADE = BAI.IDCIDADE
                            WHERE 1 = 1";

                if (!string.IsNullOrEmpty(parNMNOME))
                {
                    sqlcmd.CommandText += " AND FORN.NMNOME LIKE @NMNOME ";
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
        public FornecedorBO GetFornecedorById(int parIDFORNECEDOR)
        {
            sqldr = null;
            try
            {
                FornecedorBO objRetornoCliente = new FornecedorBO();

                sqlcmd.CommandText =
                     @" SELECT FORN.IDFORNECEDOR
		                        ,FORN.NRCNPJ
		                        ,FORN.NMNOME
		                        ,FORN.NMNOMERAZAO
		                        ,FORN.NRTELEFONE
		                        ,FORN.NMEMAIL
		                        ,FORN.IDENDERECO
		                        ,CID.NMCIDADE
		                        ,BAI.NMBAIRRO
                        FROM TBFORNECEDOR FORN
                        INNER JOIN TBENDERECO ECO ON ECO.IDENDERECO = FORN.IDENDERECO
                        INNER JOIN TBBAIRRO BAI ON BAI.IDBAIRRO = ECO.IDBAIRRO
                        INNER JOIN TBCIDADE CID ON CID.IDCIDADE = BAI.IDCIDADE 
                        WHERE FORN.IDFORNECEDOR = @IDFORNECEDOR";

                sqlcmd.Parameters.Clear();
                sqlcmd.Parameters.AddWithValue("@IDFORNECEDOR", parIDFORNECEDOR);

                sqlcmd.Connection = conexao.Conectar();
                sqldr = sqlcmd.ExecuteReader();

                if (sqldr.HasRows && sqldr.Read())
                {
                    objRetornoCliente = new FornecedorBO
                        (
                            sqldr["IDFORNECEDOR"] == DBNull.Value ? 0 : Convert.ToInt32(sqldr["IDFORNECEDOR"], cultureInfo),
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

        public bool SalvarFornecedor(FornecedorBO parFornecedorBO)
        {
            try
            {
                if (ValidarCliente(parFornecedorBO))
                {
                    return false;
                }

                if (parFornecedorBO.IDFORNECEDOR == 0)
                {
                    sqlcmd.CommandText =
                         @" INSERT INTO TBFORNECEDOR
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
                    sqlcmd.Parameters.AddWithValue("@IDENDERECO", parFornecedorBO.IDENDERECO);
                    sqlcmd.Parameters.AddWithValue("@NRCPFCNPJ", parFornecedorBO.NRCPFCNPJ);
                    sqlcmd.Parameters.AddWithValue("@NMNOME", parFornecedorBO.NMNOME);
                    sqlcmd.Parameters.AddWithValue("@NMNOMERAZAO", parFornecedorBO.NMNOMERAZAO);
                    sqlcmd.Parameters.AddWithValue("@NRTELEFONE", parFornecedorBO.NRTELEFONE);
                    sqlcmd.Parameters.AddWithValue("@NMEMAIL", parFornecedorBO.NMEMAIL);
                }
                else
                {
                    sqlcmd.CommandText =
                         @" UPDATE TBFORNECEDOR SET
                                IDENDERECO = @IDENDERECO
                                ,NRCPFCNPJ = @NRCPFCNPJ
                                ,NMNOME = @NMNOME
                                ,NMNOMERAZAO = @NMNOMERAZAO
                                ,NRTELEFONE = @NRTELEFONE
                                ,NMEMAIL = @NMEMAIL
                            WHERE IDFORNECEDOR = @IDFORNECEDOR ";

                    sqlcmd.Parameters.Clear();
                    sqlcmd.Parameters.AddWithValue("@IDENDERECO", parFornecedorBO.IDENDERECO);
                    sqlcmd.Parameters.AddWithValue("@NRCPFCNPJ", parFornecedorBO.NRCPFCNPJ);
                    sqlcmd.Parameters.AddWithValue("@NMNOME", parFornecedorBO.NMNOME);
                    sqlcmd.Parameters.AddWithValue("@NMNOMERAZAO", parFornecedorBO.NMNOMERAZAO);
                    sqlcmd.Parameters.AddWithValue("@NRTELEFONE", parFornecedorBO.NRTELEFONE);
                    sqlcmd.Parameters.AddWithValue("@NMEMAIL", parFornecedorBO.NMEMAIL);
                    sqlcmd.Parameters.AddWithValue("@IDFORNECEDOR", parFornecedorBO.IDFORNECEDOR);
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
        private bool ValidarCliente(FornecedorBO parFornecedorBO)
        {
            try
            {
                Mansegem = "";
                string obrigatorio = " É Obrigatório.\n";

                if (parFornecedorBO.NMNOMERAZAO == "")
                {
                    Mansegem = "Nome Razão" + obrigatorio;
                }
                if (parFornecedorBO.NMNOME == "")
                {
                    Mansegem = "Nome" + obrigatorio;
                }
                if (parFornecedorBO.NMEMAIL == "")
                {
                    Mansegem = "Email" + obrigatorio;
                }
                if (parFornecedorBO.NMENDERECO == "")
                {
                    Mansegem = "Endereço" + obrigatorio;
                }

                if (Mansegem != "")
                {
                    return true;
                }

                if (ValidarNomeFornecedor(parFornecedorBO))
                {
                    return true;
                }
                else if (ValidarNomeRazaoFornecedor(parFornecedorBO))
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

        private bool ValidarNomeFornecedor(FornecedorBO parFornecedorBO)
        {
            sqldr = null;
            try
            {
                sqlcmd.CommandText = @" SELECT IDCLIENTE
                                        FROM TBCLIENTE
                                        WHERE NMNOME = @NMNOME 
                                        AND IDCLIENTE <> @IDCLIENTE ";
                sqlcmd.Parameters.Clear();
                sqlcmd.Parameters.AddWithValue("@NMNOME", parFornecedorBO.NMNOME);
                sqlcmd.Parameters.AddWithValue("@IDCLIENTE", parFornecedorBO.IDFORNECEDOR);

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
        private bool ValidarNomeRazaoFornecedor(FornecedorBO parFornecedorBO)
        {
            sqldr = null;
            try
            {
                sqlcmd.CommandText = @" SELECT IDCLIENTE
                                        FROM TBCLIENTE
                                        WHERE NMNOMERAZAO = @NMNOMERAZAO 
                                        AND IDCLIENTE <> @IDCLIENTE ";
                sqlcmd.Parameters.Clear();
                sqlcmd.Parameters.AddWithValue("@NMNOMERAZAO", parFornecedorBO.NMNOMERAZAO);
                sqlcmd.Parameters.AddWithValue("@IDCLIENTE", parFornecedorBO.IDFORNECEDOR);

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
        private bool ValidarObrigatorio(FornecedorBO parFornecedorBO)
        {
            try
            {
                bool retorno = false;

                if (string.IsNullOrEmpty(parFornecedorBO.NMNOME))
                {
                    Mansegem += "Nome é Obrigatório";
                    retorno = true;
                }
                if (string.IsNullOrEmpty(parFornecedorBO.NMNOMERAZAO))
                {
                    Mansegem += "Nome Razão é Obrigatório";
                    retorno = true;
                }
                if (string.IsNullOrEmpty(parFornecedorBO.NMEMAIL))
                {
                    Mansegem += "Email é Obrigatório";
                    retorno = true;
                }

                return retorno;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
