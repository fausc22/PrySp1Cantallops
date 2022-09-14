using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sp1Cantallops
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        int intentos = 0;
        // evento click del boton BtnAceptar
        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if ((txtUsuario.Text == "Administrador" &&
                txtContrasenia.Text == "adm135$") ||
                (txtUsuario.Text == "Operador" &&
                txtContrasenia.Text == "ope246$")) ;
            {
                this.Hide(); //oculta este formulario
                FrmInicio f = new FrmInicio(); //crea el formulario
                f.Text = txtUsuario.Text; //asigna el texto del titulo
                f.ShowDialog(); // visualiza y ejecuta el frmInicio
                this.Show(); //visualiza nuevamente este formulario
            }
            else
            {
                MessageBox.Show("Datos incorrectos. Acceso Denegado.");
                intentos++; //incrementa el contador de intentos fallidos
                if (intentos == 3) //si es 3 cierre el formulario
                {
                    this.Close();
                }
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); // cierra el formulario
        }
    }
}









