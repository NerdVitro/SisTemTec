using System;
using System.Collections.Generic;
using System.Text;

namespace SisTemTec.Classes
{
    public class Usuario
    {
        #region Properties
        private string _NomeUsuario;
        private int _IDUsuario;

        public string NomeUsuario { get => _NomeUsuario; set => _NomeUsuario = value; }
        public int IDUsuario { get => _IDUsuario; set => _IDUsuario = value; }
        #endregion

        #region Construtores
        public Usuario(string parNomeUsuario, int parIDUsuario)
        {
            _NomeUsuario = parNomeUsuario;
            _IDUsuario = parIDUsuario;
        }
        public Usuario()
        {
            _NomeUsuario = string.Empty;
            _IDUsuario = 0;
        }
        #endregion
    }
}
