using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjerciciosFunciones
{
    public partial class frmFuncion : Form
    {
        public frmFuncion()
        {
            InitializeComponent();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            int contador = cuenta_letras(this.txtFrase.Text, "c");
            this.txtResultado.Text = contador.ToString();
        }
        /// <summary>
        /// Cuenta la cantidad de 'a' que existen en una frase
        /// </summary>
        /// <param name="frase"></param>
        /// <returns></returns>
        private int cuenta_letras(string frase, string letra)
        {
            int cont = 0;
            for (int i=0; i<frase.Length; i++)
            {
                if (frase[i].ToString().ToLower() == letra.ToLower())
                    cont++;
            }
            return cont;
        }
    }
}
