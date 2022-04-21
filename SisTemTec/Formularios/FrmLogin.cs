using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SisTemTec.Formularios
{
    public partial class FrmLogin : Form
    {
        private bool _Resultado = false;

        public bool Resultado { get => _Resultado;}

        public FrmLogin()
        {
            InitializeComponent();
        }

    }
}
