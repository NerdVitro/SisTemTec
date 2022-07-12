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
            if (ex.Message.Contains("brigatório"))
            {
                MessageBox.Show(ex.Message, "Atenção!!");
            }
            else
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.StackTrace, "Erro!!");
            }

        }
        static public void MostrarMensagem(string Mensagem)
        {
            MessageBox.Show(Mensagem, "Atenção!!");
        }
    }
}
