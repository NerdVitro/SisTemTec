using System;
using System.Collections.Generic;
using System.Text;

namespace SisTemTec.Banco.Manter
{
    public class ManterEnderecoFast : ManterObterDados
    {
        public int CadastrarEndereco(int parIDESTADO, string parCidade, string parBairro, int parNumero, string parRua, string Complemento)
        {
            try
            {
                int Cidade = CadastrarCidade(parIDESTADO, parCidade);
                int Bairro = CadastrarBairro(Cidade, parBairro);

                sqlcmd.CommandText =
                        @"INSERT INTO TBENDERECO    
                        (
	                        IDBAIRRO
	                        ,NRNUMERO
	                        ,NMRUA
	                        ,NMCOMPLEMENTO
                        ) OUTPUT INSERTED.IDENDERECO
                        VALUES 
                        (
	                        @IDBAIRRO
	                        ,@NRNUMERO
	                        ,@NMRUA
	                        ,@NMCOMPLEMENTO
                        )";

                sqlcmd.Parameters.Clear();
                sqlcmd.Parameters.AddWithValue("@IDBAIRRO", Bairro);
                sqlcmd.Parameters.AddWithValue("@NRNUMERO", parNumero);
                sqlcmd.Parameters.AddWithValue("@NMRUA", parRua);
                sqlcmd.Parameters.AddWithValue("@NMCOMPLEMENTO", Complemento);

                sqlcmd.Connection = conexao.Conectar();

                return (int)sqlcmd.ExecuteScalar();
            }
            catch (Exception)
            {
                throw;
            }
        }
        private int CadastrarCidade(int parIDESTADO, string parCidade)
        {
            try
            {
                int idCidade = ExisteCidade(parIDESTADO, parCidade);

                if (idCidade != 0)
                {
                    return idCidade;
                }
                else
                {
                    sqlcmd.CommandText =
                        @"INSERT INTO TBCIDADE
                        (
	                        IDESTADO
	                        ,NMCIDADE
                        )OUTPUT INSERTED.IDCIDADE
                        VALUES 
                        (
	                        @IDESTADO
	                        ,@NMCIDADE
                        )";

                    sqlcmd.Parameters.Clear();
                    sqlcmd.Parameters.AddWithValue("@IDESTADO", parIDESTADO);
                    sqlcmd.Parameters.AddWithValue("@NMCIDADE", parCidade);

                    sqlcmd.Connection = conexao.Conectar();

                    return (int)sqlcmd.ExecuteScalar();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        private int ExisteCidade(int parIDESTADO, string parCidade)
        {
            sqldr = null;
            try
            {
                sqlcmd.CommandText =
                     @" SELECT IDCIDADE 
                        FROM TBCIDADE
                        WHERE IDESTADO = @IDESTADO
                        AND NMCIDADE = @NMCIDADE";

                sqlcmd.Parameters.Clear();
                sqlcmd.Parameters.AddWithValue("@IDESTADO", parIDESTADO);
                sqlcmd.Parameters.AddWithValue("@NMCIDADE", parCidade);

                sqlcmd.Connection = conexao.Conectar();
                sqldr = sqlcmd.ExecuteReader();

                if (sqldr.HasRows && sqldr.Read())
                {
                    return sqldr["IDCIDADE"] == DBNull.Value ? 0 : Convert.ToInt32(sqldr["IDCIDADE"], cultureInfo);
                }
                return 0;
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

        private int CadastrarBairro(int parCidade, string parBairro)
        {
            try
            {
                int idBairro = ExisteBairro(parCidade, parBairro);

                if (idBairro != 0)
                {
                    return idBairro;
                }
                else
                {
                    sqlcmd.CommandText =
                        @"INSERT INTO TBBAIRRO
                        (
	                        IDCIDADE
	                        ,NMBAIRRO
                        ) OUTPUT INSERTED.IDBAIRRO
                        VALUES 
                        (
	                        @IDCIDADE
	                        ,@NMBAIRRO
                        )";

                    sqlcmd.Parameters.Clear();
                    sqlcmd.Parameters.AddWithValue("@IDCIDADE", parCidade);
                    sqlcmd.Parameters.AddWithValue("@NMBAIRRO", parBairro);

                    sqlcmd.Connection = conexao.Conectar();

                    return (int)sqlcmd.ExecuteScalar();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        private int ExisteBairro(int parCidade, string parBairro)
        {
            sqldr = null;
            try
            {
                sqlcmd.CommandText =
                     @" SELECT IDBAIRRO 
                        FROM TBBAIRRO
                        WHERE IDCIDADE = @IDCIDADE
                        AND NMBAIRRO = @NMBAIRRO";

                sqlcmd.Parameters.Clear();
                sqlcmd.Parameters.AddWithValue("@IDCIDADE", parCidade);
                sqlcmd.Parameters.AddWithValue("@NMBAIRRO", parBairro);

                sqlcmd.Connection = conexao.Conectar();
                sqldr = sqlcmd.ExecuteReader();

                if (sqldr.HasRows && sqldr.Read())
                {
                    return sqldr["IDBAIRRO"] == DBNull.Value ? 0 : Convert.ToInt32(sqldr["IDBAIRRO"], cultureInfo);
                }
                return 0;
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
