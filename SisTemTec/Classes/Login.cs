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
                return true;
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
                else if (parUsu.ToLower() != "vitor.souza")
                {
                    _Messagem = "Usuário não encontrado";
                    return false;
                }
                else if (parSen.ToLower() != "1234")
                {
                    _Messagem = "Senha Incorreta";
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
