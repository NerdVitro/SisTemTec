using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace SisTemTec.Core.Classes
{
    public class Tratamento
    {
        static public void Exception(Exception ex)
        {
            MessageBox.Show(ex.Message + "\n\n" + ex.StackTrace);
        }
        static public void MostrarMensagem(string Mensagem)
        {
            MessageBox.Show(Mensagem);
        }
    }
}
