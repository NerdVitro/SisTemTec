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
                        @"INSERT INTO TBESTADO
                        (
	                        NMESTADO
	                        ,NMSIGLA
                         OUTPUT INSERTED.(ID)
                        )VALUES 
                        (
	                        @NMESTADO
	                        ,@NMSIGLA
                        )";

                sqlcmd.Parameters.Clear();
                sqlcmd.Parameters.AddWithValue("@NMESTADO", "");
                sqlcmd.Parameters.AddWithValue("@NMSIGLA", "");

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
                return 0;
                if (false)
                {

                }
                else
                {

                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        private int CadastrarBairro(int parCidade, string parBairro)
        {
            try
            {
                return 0;
                if (false)
                {

                }
                else
                {

                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
