using SisTemTec.Banco;
using System;
using System.Collections.Generic;
using System.Text;

namespace SisTemTec.Classes
{
    public class Login
    {
        private string _Messagem;

        public string Messagem { get => _Messagem;}

        public bool ValidarAcesso(string parUsu, string parSen)
        {
            try
            {
                if (string.IsNullOrEmpty(parUsu))
                {
                    _Messagem = "Favor Informar Usuário";
                    return false;
                }
                else if (string.IsNullOrEmpty(parSen))
                {
                    _Messagem = "Favor Informar Senha";
                    return false;
                }
                else if (!new ObterDados().Usuario(parUsu, parSen))
                {
                    _Messagem = "Usuário ou Senha Incorreto(a)";
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
